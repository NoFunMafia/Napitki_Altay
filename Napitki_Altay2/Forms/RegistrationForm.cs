#region [using's]
using Napitki_Altay2.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
#endregion

namespace Napitki_Altay2
{
    public partial class RegistrationForm : Form
    {
        #region [Подключение класса соединения с БД]
        // Использование класса соединения с БД
        DataBaseWork datebaseCon = new DataBaseWork();
        public static int unicCode;
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
            return new SqlCommand(dbQuery, datebaseCon.GetConnection());
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
        /// Событие нажатия на кнопку "Заказчик" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void заказчикToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            ChooseRoleTextBox.Texts = "Заявитель";
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
                LoginCreateTextBox.Texts = "";
        }
        /// <summary>
        /// Событие при котором пользователь, 
        /// входит в зону взаимодействия с EmailTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void User_Enter_In_TextBox_Email_Create(object sender, EventArgs e)
        {
            if (EmailTextBox.Texts.Equals(@"Ваш Email"))
                EmailTextBox.Texts = "";
        }
        /// <summary>
        /// Событие при котором пользователь,
        /// выходит из зоны взаимодействия с EmailTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void User_Leave_From_TextBox_Email_Create(object sender, EventArgs e)
        {
            if (EmailTextBox.Texts.Equals(""))
                EmailTextBox.Texts = "Ваш Email";
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
                LoginCreateTextBox.Texts = "Создание логина";
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
            try // Открытие соединения, проверка работы БД
            {
                if (ChooseRoleTextBox.Texts == "Роль пользователя")
                {
                    MessageBox.Show
                        ("Роль пользователя не определена!",
                        "Ошибка", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
                else if(ChooseRoleTextBox.Texts == "Администратор" 
                    || ChooseRoleTextBox.Texts == "Сотрудник" 
                    || ChooseRoleTextBox.Texts == "Заявитель")
                {
                    if(LoginCreateTextBox.Texts == "Создание логина" || 
                        PasswordCreateTextBox.Texts == "Создание пароля" ||
                        EmailTextBox.Texts == "Ваш Email")
                    {
                        MessageBox.Show
                            ("Поля данных не заполнены до конца!",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        Random rand = new Random();
                        unicCode = rand.Next(100000, 999999);
                        if (CheckLoginUserInDB())
                            return;
                        if (CheckPass(PasswordCreateTextBox.Texts, 8, 15))
                            return;
                        if (IsValidEmail(EmailTextBox.Texts))
                            return;
                        this.Enabled = false;
                        SMTPCon();
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
            finally // Закрытие соединения с БД
            {
                datebaseCon.CloseConnection();
            }
        }
        private void SMTPCon()
        {
            MimeMessage mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress
                ("Волчихинский Пивоваренный Завод",
                "napitki-altay@mail.ru"));
            mimeMessage.To.Add
                (MailboxAddress.Parse(EmailTextBox.Texts));
            mimeMessage.Subject
                = $"Код подтверждения: {unicCode}";
            mimeMessage.Body = new TextPart("html")
            {
                Text = "<b>Мы очень рады, что Вы, решили " +
                "воспользоваться нашим приложением!</b>" +
                $"<br>Ваш код подтверждения: " +
                $"<b>{unicCode}</b>"
            };
            SmtpClient smtpClient = new SmtpClient();
            try
            {
                smtpClient.Connect
                    ("smtp.mail.ru", 465, true);
                smtpClient.Authenticate
                    ("napitki-altay@mail.ru",
                    "5TGsxjXKrXYpVxeajrgY");
                smtpClient.Send(mimeMessage);
                AuthEmailForm authEmailForm
                    = new AuthEmailForm();
                authEmailForm.FormClosed
                    += new FormClosedEventHandler
                    (AuthEmailForm_FormClosed);
                authEmailForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                smtpClient.Disconnect(true);
                smtpClient.Dispose();
            }
        }
        void AuthEmailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            bool rightCode = (sender as AuthEmailForm).RightCode;
            if (rightCode == true)
            {
                int chooseRole = CheckUserRole();
                string sqlCom = "insert " +
                "into Authentication_" +
                "(Login_User, Password_User, " +
                "FK_Role_User, Email) " +
                $"values ('{LoginCreateTextBox.Texts}', " +
                $"'{PasswordCreateTextBox.Texts}', " +
                $"'{chooseRole}', '{EmailTextBox.Texts}')";
                SqlCommand check = Check(sqlCom);
                datebaseCon.OpenConnection();
                using (var datareader
                    = check.ExecuteReader())
                {
                    datareader.Read();
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
        private int CheckUserRole()
        {
            int chooseRole;
            if (ChooseRoleTextBox.Texts == "Администратор")
                chooseRole = 1;
            else if (ChooseRoleTextBox.Texts == "Сотрудник")
                chooseRole = 2;
            else
                chooseRole = 3;
            return chooseRole;
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
            DataBaseWork dataBaseCon = new DataBaseWork();
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand
                ("select * from Authentication_ " +
                "where Login_User=@usLog", 
                dataBaseCon.GetConnection());
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
        #region [Проверка правильности ввода Email адреса]
        public Boolean IsValidEmail(string email)
        {
            Regex emailRegex = new Regex
                (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", 
                RegexOptions.IgnoreCase);
            if (emailRegex.IsMatch(email)) 
            {
                return false;
            }
            else
            {
                MessageBox.Show("Email введен некорректно!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return true;
            }
        }
        #endregion
        #region [Проверка пароля (надёжность)]
        public Boolean CheckPass(string inputPass, 
            int minLenght, int maxLenght)
        {
            bool hasNum = true, 
                hasCap = true, 
                hasLow = true, 
                hasSpec = true;
            char currentCharacter;
            if (!(inputPass.Length <= minLenght
                || inputPass.Length >= maxLenght))
            {
                hasNum = false;
            }
            else
            {
                MessageBox.Show("Пароль не соответствует требованиям!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return true;
            }
            for(int i = 0; i < inputPass.Length; i++)
            {
                currentCharacter = inputPass[i];
                if (char.IsDigit(currentCharacter))
                    hasNum = true;
                else if(char.IsUpper(currentCharacter))
                    hasCap = true;
                else if(char.IsLower(currentCharacter))
                    hasLow = true;
                else if(!char.IsLetterOrDigit(currentCharacter))
                    hasSpec = true;
            }
            if (hasNum && hasCap && hasLow && hasSpec)
                return false;
            else
                MessageBox.Show("Пароль не соответствует требованиям!", 
                    "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            return true;
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
        #region [Закрытие формы]
        private void RegistrationForm_FormClosed
            (object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region [Подсказка к паролю]
        private void InfoPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("• Пароль должен содержать " +
                "не менее 8 и не более 15 символов" +
                "\n• Пароль должен содержать минимум 1 цифру" +
                "\n• Пароль должен содержать 1 букву нижнего регистра" +
                "\n• Пароль должен содержать 1 букву верхнего регистра" +
                "\n• Пароль должен содержать 1 спецсимвол", "Информация", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}