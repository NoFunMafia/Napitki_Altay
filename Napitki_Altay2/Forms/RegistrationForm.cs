using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Napitki_Altay2
{
    public partial class RegistrationForm : Form
    {
        #region [Подключение класса соединения с БД]
        // Использование класса соединения с БД
        DataBaseCon datebaseCon = new DataBaseCon();
        #endregion
        public RegistrationForm()
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
        #region [Работа с ToolStripMenu, выбор прав пользователя]
        /// <summary>
        /// Событие нажатия на картинку с последующим 
        /// действием выпадающего элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChoosePictureBox_Click(object sender, 
            EventArgs e)
        {
            RoleContextMenuStip.Show(ChoosePictureBox, 
                new Point(0, ChoosePictureBox.Height));
        }
        /// <summary>
        /// Событие нажатия на кнопку "Администратор" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void администраторToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            ChooseRoleTextBox.Texts = "Администратор";
        }
        /// <summary>
        /// Событие нажатия на кнопку "Сотрудник" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сотрудникToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            ChooseRoleTextBox.Texts = "Сотрудник";
        }
        /// <summary>
        /// Событие нажатия на кнопку "Демо-режим" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void деморежимToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            ChooseRoleTextBox.Texts = "Демо-режим";
        }
        #endregion
        #region [Событие фокусировки с TextBox'ами]
        /// <summary>
        /// Событие при котором пользователь, 
        /// входит в зону взаимодействия с LoginCreateTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void User_Enter_In_TextBox_Login_Create
            (object sender, EventArgs e)
        {
            if (LoginCreateTextBox.Texts.Equals(@"Создание логина"))
            {
                LoginCreateTextBox.Texts = "";
            }
        }
        /// <summary>
        /// Событие при котором пользователь,
        /// выходит из зоны взаимодействия с LoginCreateTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void User_Leave_From_TextBox_Login_Create
            (object sender, EventArgs e)
        {
            if (LoginCreateTextBox.Texts.Equals(""))
            {
                LoginCreateTextBox.Texts = "Создание логина";
            }
        }
        /// <summary>
        /// Событие при котором пользователь, 
        /// входит в зону взаимодействия с PasswordCreateTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void User_Enter_In_TextBox_Pass_Create
            (object sender, EventArgs e)
        {
            if (PasswordCreateTextBox.Texts.Equals
                (@"Создание пароля"))
            {
                PasswordCreateTextBox.Texts = "";
                PasswordCreateTextBox.PasswordChar = true;
            }
        }
        /// <summary>
        /// Событие при котором пользователь, 
        /// выходит из зоны взаимодействия с PasswordCreateTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void User_Leave_From_TextBox_Pass_Create
            (object sender, EventArgs e)
        {
            if (PasswordCreateTextBox.Texts.Equals(""))
            {
                PasswordCreateTextBox.Texts = "Создание пароля";
                PasswordCreateTextBox.PasswordChar = false;
            }
        }
        #endregion
        #region [Показ/скрытие пароля]
        private void VisiblePassCheckRegForm_CheckedChanged
            (object sender, EventArgs e)
        {
            if (VisiblePassCheckRegForm.Checked == true)
                PasswordCreateTextBox.PasswordChar = false;
            else
                PasswordCreateTextBox.PasswordChar = true;
        }
        #endregion
        #region [Внесение нового логина и пароля пользователя в БД, проверка полей заполнения]
        /// <summary>
        /// Действие регистрации нового аккаунта с 
        /// проверками на успешность внесения данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterAccountButton_Click
            (object sender, EventArgs e)
        {
            bool success;
            try // Открытие соединения, проверка работы БД
            {
                int isAdmin = 0, isUser = 0, isDemo = 0;
                CheckUserRole(ref isAdmin, ref isUser, ref isDemo);
                if (isAdmin == 0 && isUser == 0 && isDemo == 0)
                {
                    MessageBox.Show
                        ("Права пользователя не определены!",
                        "Ошибка", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
                else if(isAdmin >= 0 || isUser >= 0 || isDemo >= 0)
                {
                    if(LoginCreateTextBox.Texts == "Создание логина" || 
                        PasswordCreateTextBox.Texts == "Создание пароля")
                        MessageBox.Show
                            ("Поля данных не заполнены до конца!",
                            "Ошибка", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                    else
                    {
                        if (CheckLoginUserInDB())
                            return;
                        string sqlCom = "insert into " +
                        "Auth(User_login, User_pass, User_demo, " +
                        "User_casual, User_admin) values" + "('"
                        + LoginCreateTextBox.Texts.ToString() + "','"
                        + PasswordCreateTextBox.Texts.ToString() + "','"
                        + isDemo.ToString() + "','"
                        + isUser.ToString() + "','"
                        + isAdmin.ToString() + "')";
                        SqlCommand check = Check(sqlCom);
                        datebaseCon.openConnection();
                        using (var datareader = check.ExecuteReader())
                        {
                            success = datareader.Read();
                            MessageBox.Show
                                ("Пользователь успешно добавлен!",
                            "Информация", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            AuthForm authForm = new AuthForm();
                            authForm.Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка подключения к базе данных!",
                    "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally // Закрытие соединения с БД
            {
                datebaseCon.closeConnection();
            }
        }
        #endregion
        #region [Метод проверки уникальности логина]
        /// <summary>
        /// Проверка уникальности логина пользователя
        /// </summary>
        /// <returns>Правда - если логин занят, 
        /// ложь - свободен</returns>
        public Boolean CheckLoginUserInDB()
        {
            DataBaseCon dataBaseCon = new DataBaseCon();
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand
                ("select * from Auth where User_login=@usLog", 
                dataBaseCon.sqlConnection());
            command.Parameters.Add
                ("@usLog", SqlDbType.VarChar).Value 
                = LoginCreateTextBox.Texts;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Данный логин занят, используйте другой!",
                                    "Ошибка",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return true;
            }
            else
                return false;
        }
        #endregion
        #region [Метод сверки роли пользователя]
        /// <summary>
        /// Сверка роли пользователя при регистрации аккаунта
        /// </summary>
        /// <param name="isAdmin">Пользователь админ?</param>
        /// <param name="isUser">Пользователь сотрудник?</param>
        /// <param name="isDemo">Пользователь использует демо-режим?</param>
        private void CheckUserRole
            (ref int isAdmin, ref int isUser, ref int isDemo)
        {
            if (ChooseRoleTextBox.Texts == "Администратор")
                isAdmin = 1;
            else if (ChooseRoleTextBox.Texts == "Сотрудник")
                isUser = 1;
            else if (ChooseRoleTextBox.Texts == "Демо-режим")
                isDemo = 1;
            else
            {
                isAdmin = 0;
                isUser = 0;
                isDemo = 0;
            }
        }
        #endregion
        #region [Событие перехода на форму AuthForm]
        /// <summary>
        /// Открытие формы авторизации, 
        /// если у пользователя уже есть аккаунт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFormLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Hide();
        }
        #endregion
    }
}