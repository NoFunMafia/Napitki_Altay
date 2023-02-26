#region [using's]
using Napitki_Altay2.Forms;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
#endregion
namespace Napitki_Altay2
{
    public partial class AuthForm : Form
    {
        #region [Использование переменных и класса работы с БД]
        // Использование класса работы с БД
        DataBaseWork datebaseWork = new DataBaseWork();
        /// <summary>
        /// Переменная хранащая логин пользователя для 
        /// передачи его в карточку на форме MainWorkForm
        /// </summary>
        public static string LoginString;
        /// <summary>
        /// Переменная хранащая пароль пользователя для 
        /// передачи его в карточку на форме MainWorkForm
        /// </summary>
        public static string PasswordString;
        public static string RoleString;
        #endregion
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
            return new SqlCommand(dbQuery, datebaseWork.GetConnection());
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
                PasswordTextBox.PasswordChar = true;
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
                PasswordTextBox.PasswordChar = false;
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
            bool success;
            try // Открытие соединения, проверка работы БД
            {
                if (LoginTextBox.Texts == "Логин" || 
                    PasswordTextBox.Texts == "Пароль")
                {
                    MessageBox.Show("Данные для входа не введены!",
                        "Ошибка", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        bool successLoad;
                        string sqlComRoleUser = $"select * " +
                            $"from Authentication_ " +
                            $"where Login_User = " +
                            $"'{LoginTextBox.Texts}' and " +
                            $"Password_User = '{PasswordTextBox.Texts}'";
                        SqlCommand checkRole = Check(sqlComRoleUser);
                        datebaseWork.OpenConnection();
                        using (var datareader = checkRole.ExecuteReader())
                        {
                            successLoad = datareader.Read();
                            {
                                CheckUserRole(datareader);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, 
                            "Ошибка", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        datebaseWork.CloseConnection();
                    }
                    string sqlComRole 
                        = $"select * from Authentication_ " +
                        $"where Login_User=@login and " +
                        $"Password_User=@password and " +
                        $"FK_Role_User = '{RoleString}'";
                    SqlCommand check = Check(sqlComRole);
                    SqlCommand sqlCommand = new SqlCommand(sqlComRole, datebaseWork.GetConnection());
                    sqlCommand.Parameters.AddWithValue("@login",
                        LoginTextBox.Texts);
                    sqlCommand.Parameters.AddWithValue("@password",
                        PasswordTextBox.Texts);
                    datebaseWork.OpenConnection();
                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        LoginString = LoginTextBox.Texts;
                        PasswordString = PasswordTextBox.Texts;
                        success = dataReader.Read();
                    }
                    if (success)
                    {
                        if(RoleString == "3")
                        {
                            MainWorkForm mainWorkForm = new MainWorkForm();
                            mainWorkForm.Show();
                            this.Hide();
                        }
                        else if(RoleString == "2")
                        {
                            MainWorkFormWorker mainWorkFormWorker = new MainWorkFormWorker();
                            mainWorkFormWorker.Show();
                            this.Hide();
                        }
                        else
                        {
                            MainWorkFormAdmin mainWorkFormAdmin = new MainWorkFormAdmin();
                            mainWorkFormAdmin.Show();
                            this.Hide();
                        }
                    }
                    else
                        MessageBox.Show("Введен неправильный логин/пароль!", 
                            "Ошибка",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, 
                    "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            finally // Закрытие соединения с БД
            {
                datebaseWork.CloseConnection();
            }
        }
        #endregion
        #region [Метод проверки роли пользователя]
        private void CheckUserRole(SqlDataReader dataReader)
        {
            if (dataReader.HasRows)
            {
                RoleString = dataReader.GetValue(3).ToString();
            }
        }
        #endregion
        #region [Показ/скрытие пароля]
        /// <summary>
        /// Состояние показа пароля при 
        /// разных переключателях CheckBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Visible_Pass_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (VisiblePassCheck.Checked == true)
                PasswordTextBox.PasswordChar = false;
            else
                PasswordTextBox.PasswordChar = true;
        }
        #endregion
    }
}