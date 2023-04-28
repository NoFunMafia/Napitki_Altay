#region [using's]
using Napitki_Altay2.Forms;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using Napitki_Altay2.Classes;
using System.Collections.Generic;
using Napitki_Altay2.Design;
using System.Linq;
#endregion

namespace Napitki_Altay2
{
    public partial class RegistrationForm : Form
    {
        #region [Подключение класса соединения с БД]
        // Использование класса соединения с БД
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        readonly SqlQueries sqlQueries = new SqlQueries();
        public static int uniqueCode;
        #endregion
        public RegistrationForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Событие нажатия на кнопку ChoosePictureBox]
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
        #endregion
        #region [Событие нажатия на item "администратор" ToolStrip'а]
        /// <summary>
        /// Событие нажатия на кнопку "Администратор" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void АдминистраторToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            ChooseRoleTextBox.Texts = "Администратор";
        }
        #endregion
        #region [Событие нажатия на item "сотрудник" ToolStrip'а]
        /// <summary>
        /// Событие нажатия на кнопку "Сотрудник" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void СотрудникToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            ChooseRoleTextBox.Texts = "Сотрудник";
        }
        #endregion
        #region [Событие нажатия на item "заявитель" ToolStrip'а]
        /// <summary>
        /// Событие нажатия на кнопку "Заказчик" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ЗаказчикToolStripMenuItem_Click
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
        #region [Событие нажатия на проверочную кнопку VisiblePassCheckRegForm]
        private void VisiblePassCheckRegForm_CheckedChanged
            (object sender, EventArgs e)
        {
            PasswordCreateTextBox.PasswordChar = !VisiblePassCheckRegForm.Checked;
        }
        #endregion
        #region [Событие нажатия на кнопку RegisterAccountButton]
        /// <summary>
        /// Действие регистрации нового аккаунта с 
        /// проверками на успешность внесения данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterAccountButton_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxIsNotNull())
            {
                if (!CheckLoginUserInDB())
                    return;
                if (CheckPass(PasswordCreateTextBox.Texts, 7, 15))
                    return;
                if (!IsValidEmail(EmailTextBox.Texts))
                    return;
                Enabled = false;
                if(ChooseRoleTextBox.Texts == "Сотрудник")
                {
                    AuthFioWorkerForm authFioWorker = new AuthFioWorkerForm();
                    authFioWorker.FormClosed += new FormClosedEventHandler(AuthFioWorkerForm_FormClosed);
                    authFioWorker.Show();
                }
                else
                    SendAnEmail();
            }
        }
        #endregion
        void AuthFioWorkerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
            bool createAccount = (sender as AuthFioWorkerForm).IsAccountWorker;
            if (createAccount == true)
            {
                ReceiveRoleID(out string roleID);
                ReceiveBoolCheckInsertUser(out bool checkInsertUser, roleID);
                if (checkInsertUser)
                {
                    ReceiveUserIdFromLogin(AuthFioWorkerForm.idWorker, LoginCreateTextBox.Texts);
                    MessageBox.Show("Ваши данные успешно внесены, можете приступать к работе!",
                        "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AuthForm authForm = new AuthForm();
                    authForm.Show();
                    Hide();
                }
            }
        }
        #region [Событие закрытия формы AuthEmailForm]
        void AuthEmailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
            bool rightCode = (sender as AuthEmailForm).RightCode;
            if (rightCode == true)
            {
                ReceiveRoleID(out string roleID);
                ReceiveBoolCheckInsertUser(out bool checkInsertUser, roleID);
                if (checkInsertUser)
                {
                    MessageBox.Show("Пользователь успешно добавлен!",
                        "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AuthForm authForm = new AuthForm();
                    authForm.Show();
                    Hide();
                }
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
            Hide();
        }
        #endregion
        #region [Событие закрытия формы]
        private void RegistrationForm_FormClosed
            (object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region [Событие нажатия кнопочную картинку InfoPictureBox]
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
        #region [Метод, получающий id нового внесенного аккаунта]
        public void ReceiveUserIdFromLogin(string idWorker, string login)
        {
            string sqlQuery = sqlQueries.SqlComSetWorkerIdToAccount(idWorker, login);
            dataBaseWork.WithoutOutputQuery(sqlQuery);
        }
        #endregion
        #region [Метод, отправляющий письмо на Email почту]
        public async void SendAnEmail()
        {
            GetUniqueCode();
            MimeMessage mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("Волчихинский Пивоваренный Завод",
                "napitki-altay@mail.ru"));
            mimeMessage.To.Add(MailboxAddress.Parse(EmailTextBox.Texts));
            mimeMessage.Subject = $"Код подтверждения: {uniqueCode}";
            mimeMessage.Body = new TextPart("html")
            {
                Text = $"<h1>Благодарим за регистрацию в приложении «Автоматизация документоборота»!</h1>" +
                $"<p>Наше приложение предоставит Вам, множество функций и возможностей для работы с документами.</p>" +
                $"<p>Для завершения процесса регистрации, пожалуйста, введите код подтверждения в соответствующее поле в приложении:</p>" +
                $"<h2 style='color: #007BFF;'>{uniqueCode}</h2>" +
                $"<p>Мы надеемся, что оно станет незаменимым инструментом в Вашей работе!</p>" +
                $"<p>С уважением,<br>Команда ЗАО «Волчихинский пивоваренный завод»</p>"
            };
            SmtpClient smtpClient = new SmtpClient();
            try
            {
                await smtpClient.ConnectAsync("smtp.mail.ru", 465, true);
                smtpClient.Authenticate("napitki-altay@mail.ru", "5TGsxjXKrXYpVxeajrgY");
                smtpClient.Send(mimeMessage);
                AuthEmailForm authEmailForm = new AuthEmailForm();
                authEmailForm.FormClosed += new FormClosedEventHandler(AuthEmailForm_FormClosed);
                authEmailForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                smtpClient.Disconnect(true);
                smtpClient.Dispose();
            }
        }
        #endregion
        #region [Метод, формирующий уникальное значение для Email]
        private static void GetUniqueCode()
        {
            Random rand = new Random();
            uniqueCode = rand.Next(100000, 999999);
        }
        #endregion
        #region [Метод, формирующий string значение roleID из полученного результата sql-запроса]
        /// <summary>
        /// Метод, формирующий string значение roleID из полученного результата sql-запроса
        /// </summary>
        /// <param name="roleID"></param>
        private void ReceiveRoleID(out string roleID)
        {
            string sqlQuery = sqlQueries.SqlComRoleAddUser(ChooseRoleTextBox.Texts);
            roleID = dataBaseWork.GetString(sqlQuery);
        }
        #endregion
        #region [Метод, формирующий bool значение проверки CheckInsertUser]
        /// <summary>
        /// Метод, формирующий bool значение проверки CheckInsertUser
        /// </summary>
        /// <param name="checkInsertUser">Bool значение выполненного sql-запроса</param>
        /// <param name="roleID">Переменная, использующаяся в формировании sql-запроса</param>
        private void ReceiveBoolCheckInsertUser(out bool checkInsertUser, string roleID)
        {
            string sqlQuerySecond = sqlQueries.SqlComInsertUser
                (LoginCreateTextBox.Texts, PasswordCreateTextBox.Texts, 
                roleID, EmailTextBox.Texts);
            checkInsertUser = dataBaseWork.WithoutOutputQuery(sqlQuerySecond);
        }
        #endregion
        #region [Метод, проверяющий на пустоту TextBox'ы]
        private bool CheckTextBoxIsNotNull()
        {
            foreach (CustomTextBox customTextBox in Controls.OfType<CustomTextBox>())
            {
                if (string.IsNullOrWhiteSpace(customTextBox.Texts))
                {
                    MessageBox.Show("Не все поля данных заполненны!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            return false;
        }
        #endregion
        #region [Метод, проверяющий уникальность добавляемого логина в БД]
        /// <summary>
        /// Метод, проверяющий уникальность добавляемого логина в БД
        /// </summary>
        /// <returns>True - логин свободен, 
        /// Ложь - логин занят</returns>
        private bool CheckLoginUserInDB()
        {
            string sqlQuery = sqlQueries.SqlComCheckLogin(LoginCreateTextBox.Texts);
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 2);
            if (listSearch != null)
            {
                MessageBox.Show("Вносимый логин уже зарегистрирован в БД!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion
        #region [Метод, проверяющий правильность ввода адреса электронной почты]
        public Boolean IsValidEmail(string email)
        {
            Regex emailRegex = new Regex
                (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
                RegexOptions.IgnoreCase);
            if (emailRegex.IsMatch(email))
                return true;
            else
            {
                MessageBox.Show("Адрес электронной почты введен некорректно!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
        #region [Метод, проверяющий пароль на надёжность]
        public Boolean CheckPass(string inputPass, int minLenght, int maxLenght)
        {
            bool hasCap = true, hasLow = true, hasSpec = true;
            char currentCharacter;
            bool hasNum;
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
            for (int i = 0; i < inputPass.Length; i++)
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
    }
}