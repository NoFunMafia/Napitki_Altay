using System;
using System.Data.SqlClient;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace TelegramBot
{
    class Program
    {
        static ITelegramBotClient botClient;

        static void Main()
        {
            botClient = new TelegramBotClient("5660773245:AAGVrnlAYS6xOpk701SxcyFiMDw18AiUK8U");
            var me = botClient.GetMeAsync().Result;
            Console.WriteLine($"Бот запущен!\nID бота: {me.Id}\nНазвание бота: {me.FirstName}");
            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
            Console.ReadLine();
            botClient.StopReceiving();
        }
        private static void InsertNewUser(int userID)
        {
            var connectionString = "Data Source=MYHOMIES;Initial Catalog=Altai_zavodBackup;Persist Security Info=True;User ID=Admin;Password=Admin";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var insertCommand = new SqlCommand($"INSERT INTO Telegram_Account (Account_Telegram, IsLogin) VALUES ('{userID}', '0')", connection);
                insertCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Type == MessageType.Text)
            {
                Console.WriteLine($"Получено текстовое сообщение в чате от пользователя: {e.Message.Chat.Id}.");

                int userID = Convert.ToInt32(e.Message.Chat.Id);

                var connectionString = "Data Source=MYHOMIES;Initial Catalog=Altai_zavodBackup;Persist Security Info=True;User ID=Admin;Password=Admin";
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    var command = new SqlCommand($"SELECT * FROM Telegram_Account WHERE Account_Telegram = '{userID}'", connection);
                    var reader = await command.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        await reader.ReadAsync();
                        var isLogin = reader.GetBoolean(reader.GetOrdinal("IsLogin"));
                        if (isLogin != true)
                        {
                            var login = "";
                            var password = "";
                            try
                            {
                                var parts = e.Message.Text.Split(':');
                                login = parts[0];
                                password = parts[1];
                            }
                            catch (IndexOutOfRangeException)
                            {
                                await botClient.SendTextMessageAsync(
                                    chatId: e.Message.Chat.Id,
                                    text: "Пожалуйста, введите свой логин и пароль в правильном формате, разделенные двоеточием!"
                                );
                                return;
                            }
                            // User is not yet logged in, retrieve login and password from other table and check if it matches
                            reader.Close();
                            command = new SqlCommand($"SELECT * FROM Authentication_ WHERE Login_User = '{login}' AND Password_User = '{password}'", connection);
                            reader = await command.ExecuteReaderAsync();
                            if (reader.HasRows)
                            {
                                // Login and password match, update IsLogin field in database and send success message
                                reader.Close();
                                command = new SqlCommand($"UPDATE Telegram_Account SET IsLogin = '1' WHERE Account_Telegram = '{userID}'", connection);
                                await command.ExecuteNonQueryAsync();
                                command = new SqlCommand($"SELECT ID_Account FROM Telegram_Account WHERE Account_Telegram = '{userID}'", connection);
                                reader = await command.ExecuteReaderAsync();
                                if (reader.HasRows)
                                {
                                    await reader.ReadAsync();
                                    string idTelegram = reader[0].ToString();
                                    reader.Close();
                                    command = new SqlCommand($"UPDATE Authentication_ SET FK_Telegram_Account = '{idTelegram}' WHERE Login_User = '{login}'", connection);
                                    await command.ExecuteNonQueryAsync();
                                    await botClient.SendTextMessageAsync(
                                        chatId: e.Message.Chat.Id,
                                        text: "Вы успешно вошли в систему!"
                                        );
                                }
                            }
                            else
                            {
                                // Login and password don't match, send error message
                                reader.Close();
                                await botClient.SendTextMessageAsync(
                                    chatId: e.Message.Chat.Id,
                                    text: "Логин или пароль неверные!"
                                );
                            }
                        }
                        else if (isLogin)
                        {
                            // User is already logged in
                            await botClient.SendTextMessageAsync(
                                chatId: e.Message.Chat.Id,
                                text: "Вы уже вошли в систему!"
                            );
                        }
                    }
                    else
                    {
                        // User does not exist in the database
                        reader.Close();
                        InsertNewUser(userID);
                        var helloMessage = "Приветствую, меня зовут, Напитки Алтая!" +
                            "\nЯ - умный бот уведомлятор.\n\n" +
                            "Для того чтобы продолжить со мной общение, введите свой логин и " +
                            "пароль который вы используете в ПК версии приложения Напитки Алтая!\n\n" +
                            "Пароль должен быть в формате: «Имя пользователя:Пароль».";
                        await botClient.SendTextMessageAsync(
                            chatId: e.Message.Chat.Id,
                            text: helloMessage
                        );
                    }
                }
            }
        }    
    }     
}