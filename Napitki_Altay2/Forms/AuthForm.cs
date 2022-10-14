using Napitki_Altay2.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Napitki_Altay2
{
    public partial class AuthForm : Form
    {
        // Использование класса соединения с БД
        DataBaseCon datebaseCon = new DataBaseCon();
        public AuthForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Проверка входящего запроса в БД]
        /// <summary>
        /// Проверка отправки запроса в БД
        /// </summary>
        /// <param name="dbQuery">Запрос в БД</param>
        /// <returns></returns>
        private SqlCommand Check(string dbQuery)
        {
            return new SqlCommand(dbQuery, datebaseCon.sqlConnection());
        }
        #endregion
        #region [События фокусировки с TextBox'ами]
        /// <summary>
        /// Событие при котором пользователь, 
        /// входит в зону взаимодействия с LoginTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void User_Enter_In_TextBox_Login
            (object sender, EventArgs e)
        {
            if (LoginTextBox.Texts.Equals(@"Логин"))
            {
                LoginTextBox.Texts = "";
            }
        }
        /// <summary>
        /// Событие при котором пользователь, 
        /// выходит из зоны взаимодействия с LoginTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void User_Leave_From_TextBox_Login
            (object sender, EventArgs e)
        {
            if (LoginTextBox.Texts.Equals(""))
            {
                LoginTextBox.Texts = "Логин";
            }
        }
        /// <summary>
        /// Событие при котором пользователь, 
        /// входит в зону взаимодействия с PasswordTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void User_Enter_In_TextBox_Pass
            (object sender, EventArgs e)
        {
            if (PasswordTextBox.Texts.Equals(@"Пароль"))
            {
                PasswordTextBox.Texts = "";
            }
        }
        /// <summary>
        /// Событие при котором пользователь, 
        /// выходит из зоны взаимодействия c PasswordTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void User_Leave_From_TextBox_Pass
            (object sender, EventArgs e)
        {
            if (PasswordTextBox.Texts.Equals(""))
            {
                PasswordTextBox.Texts = "Пароль";
            }
        }
        /// <summary>
        /// Событие, которое открывает форму регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #endregion
        #region [Открытие формы регистрации аккаунтов]
        private void OpenFormRegistration_LinkClicked(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm RegForm = new RegistrationForm();
            RegForm.Show();
            this.Hide();
        }
        #endregion
        #region [Вход в приложение, сверка логина/пароля с данными в БД]
        /// <summary>
        /// Событие входа в приложение, открытие главной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInAppButton_Click
            (object sender, EventArgs e)
        {
            bool success = false;
            try // Открытие соединения, проверка работы БД
            {
                const string command = "select * from Auth " +
                    "where User_login=@login " +
                    "and User_password=@password";
                SqlCommand check = Check(command);
                check.Parameters.AddWithValue("@login", 
                    LoginTextBox.Texts);
                check.Parameters.AddWithValue("@password", 
                    PasswordTextBox.Texts);
                datebaseCon.openConnection();
                using (var dataReader = check.ExecuteReader())
                {
                    success = dataReader.Read();
                }
            }
            finally // Закрытие соединения с БД
            {
                datebaseCon.closeConnection();
            }
            if (success) // Если, успех
            {
                MainWorkForm mainWorkForm = new MainWorkForm();
                mainWorkForm.Show();
                this.Hide();
            }
            else // Иначе, ошибка
            {
                MessageBox.Show("Введен неправильный логин/пароль!",
                    "Ошибка",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}