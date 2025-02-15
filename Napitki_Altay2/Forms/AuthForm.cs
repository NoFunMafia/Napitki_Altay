#region [using's]
using Napitki_Altay2.Classes;
using Napitki_Altay2.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
#endregion
namespace Napitki_Altay2
{
    public partial class AuthForm : Form
    {
        #region [Подключение классов, объявление переменных]
        // Класс запросов в БД
        private readonly SqlQueries sqlQueries = new SqlQueries();
        // Использование класса работы с БД
        private readonly DataBaseWork dataBaseWork = new DataBaseWork();
        public static string LoginString;
        public static string PasswordString;
        public static string RoleString;
        #endregion
        public AuthForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
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
        #region [Событие нажатия на кнопочную-ссылку OpenFormRegistration]
        private void OpenFormRegistration_LinkClicked(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm RegForm = new RegistrationForm();
            RegForm.Show();
            Hide();
        }
        #endregion
        #region [Событие нажатия на кнопку LogInAppButton]
        /// <summary>
        /// Событие входа в приложение, открытие главной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInAppButton_Click
            (object sender, EventArgs e)
        {
            if (LoginTextBox.Texts.Equals("Логин") || string.IsNullOrWhiteSpace(LoginTextBox.Texts) ||
                PasswordTextBox.Texts.Equals("Пароль") || string.IsNullOrWhiteSpace(PasswordTextBox.Texts))
            {
                ShowErrorMessage("Данные для входа не введены!");
                return;
            }
            if (!dataBaseWork.IsConnectionAvailable())
            {
                ShowErrorMessage("Отсутствует подключение к базе данных!");
                return;
            }
            List<string[]> listSearch = FillListQuery();

            if (listSearch == null || listSearch.Count == 0)
            {
                ShowErrorMessage("Введен неправильный логин/пароль!");
                return;
            }
            CheckUserRole(listSearch);
            if (!CheckRoleUserQuery())
            {
                ShowErrorMessage("Роль пользователя не определена или доступ закрыт!");
                return;
            }
            string titleRole = GetTitleRole();
            if (string.IsNullOrEmpty(titleRole))
            {
                ShowErrorMessage("Ошибка получения роли пользователя!");
                return;
            }
            OpenSpecificForm(titleRole);
        }
        #endregion
        #region [Метод, заполняющий список List из sql-запроса]
        /// <summary>
        /// Метод, заполняющий список List из sql-запроса
        /// </summary>
        /// <returns></returns>
        private List<string[]> FillListQuery()
        {
            string sqlQueryFirst = sqlQueries.SqlComRoleUser(LoginTextBox.Texts, PasswordTextBox.Texts);
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQueryFirst, 5);
            return listSearch;
        }
        #endregion
        #region [Метод, проверяющий наличие пользователя в БД]
        /// <summary>
        /// Метод, проверяющий наличие пользователя в БД
        /// </summary>
        /// <returns></returns>
        private bool CheckRoleUserQuery()
        {
            string sqlQuerySecond = sqlQueries.SqlComRole(LoginTextBox.Texts, PasswordTextBox.Texts, RoleString);
            return dataBaseWork.WithoutOutputQuery(sqlQuerySecond);
        }
        #endregion
        #region [Метод, получающий название роли пользователя]
        /// <summary>
        /// Метод, получающий название роли пользователя
        /// </summary>
        /// <returns></returns>
        private string GetTitleRole()
        {
            LoginString = LoginTextBox.Texts;
            PasswordString = PasswordTextBox.Texts;
            string sqlQueryThree = sqlQueries.SqlComTitleRole(RoleString);
            return dataBaseWork.GetString(sqlQueryThree);
        }
        #endregion
        #region [Метод, открывающий определенную форму по роли пользователя]
        private void OpenSpecificForm(string TitleRole)
        {
            Form targetForm = null;
            switch (TitleRole)
            {
                case "Заявитель":
                    targetForm = new MainWorkForm();
                    break;
                case "Муниципальный служащий":
                    targetForm = new MainWorkFormWorker();
                    break;
                case "Администратор":
                    targetForm = new MainWorkFormAdmin();
                    break;
                default:
                    ShowErrorMessage("Неизвестная роль пользователя!");
                    return;
            }
            targetForm?.Show();
            Hide();
        }
        #endregion
        #region [Метод, проверяющий пользовательскую роль в приложении]
        /// <summary>
        /// Метод, проверяющий пользовательскую роль в приложении
        /// </summary>
        /// <param name="strings"></param>
        private void CheckUserRole(List<string[]> strings)
        {
            if (strings != null)
            {
                foreach (string[] item in strings)
                {
                    RoleString = item[4].ToString();
                }
            }
        }
        #endregion
        #region [Метод для отображения ошибки]
        /// <summary>
        /// Показывает сообщение об ошибке в MessageBox
        /// </summary>
        /// <param name="message"></param>
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
        #region [Метод, показывающий/скрывающий видимость пароля]
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