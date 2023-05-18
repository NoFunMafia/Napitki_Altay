#region [using's]
using Napitki_Altay2.Classes;
using Napitki_Altay2.Design;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class UpdateUserForm : Form
    {
        #region [Подключение классов, объявление переменных]
        // Класс запросов в БД
        readonly SqlQueries sqlQueries = new SqlQueries();
        // Использование класса работы с БД
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        private string oldUserLogin;
        #endregion
        public UpdateUserForm()
        {
            InitializeComponent();
        }
        #region [Событие нажатия на кнопку RolePictureBox]
        /// <summary>
        /// Событие нажатия на кнопку RolePictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RolePictureBox_Click(object sender, EventArgs e)
        {
            RoleMenuStrip.Show(RolePictureBox,
                new Point(0, RolePictureBox.Height));
        }
        #endregion
        #region [Событие нажатия на item "администратор" ToolStrip'а]
        /// <summary>
        /// Событие нажатия на item "администратор" ToolStrip'а
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void АдминистраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleTextBox.Texts = "Администратор";
        }
        #endregion
        #region [Событие нажатия на item "сотрудник" ToolStrip'а]
        /// <summary>
        /// Событие нажатия на item "сотрудник" ToolStrip'а
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void СотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleTextBox.Texts = "Сотрудник";
        }
        #endregion
        #region [Событие нажатия на item "заявитель" ToolStrip'а]
        /// <summary>
        /// Событие нажатия на item "заявитель" ToolStrip'а
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ЗаявительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleTextBox.Texts = "Заявитель";
        }
        #endregion
        #region [Событие нажатия на кнопку CancelButton]
        /// <summary>
        /// Событие нажатия на кнопку CancelButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region [Событие нажатия на кнопку InputUsersButton]
        /// <summary>
        /// Событие нажатия на кнопку InputUsersButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputUsersButton_Click(object sender, EventArgs e)
        {
            List<bool> allChecks = CheckIsNullOrEmptyTextBox();
            if (allChecks.All(x => x))
            {
                ReceiveRoleID(out string roleID);
                ReceiveBoolCheckUpdateUser(out bool checkInsertUser, roleID);
                if (checkInsertUser)
                {
                    ReceiveFioFK(out string fioFK);
                    if (FamTextBox.Texts != string.Empty && ImyaTextBox.Texts != string.Empty)
                    {
                        ReceiveBoolCheckUpdateAuth(out bool checkUpdateAuth, fioFK);
                        if (checkUpdateAuth)
                            MessageBox.Show("Пользовательские данные обновлены!", "Информация", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Пользовательские данные обновлены!", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion
        #region [Метод, выполняющий все проверки вводимых значений в TextBox'ы]
        /// <summary>
        /// Метод, проверяющий TextBox'ы на пустоту, 
        /// исключая некоторые "excludedTextBoxes"
        /// </summary>
        /// <returns></returns>
        private List<bool> CheckIsNullOrEmptyTextBox()
        {
            List<CustomTextBox> excludedTextBoxes = new List<CustomTextBox>
            {
                FamTextBox, ImyaTextBox, OtchTextBox
            };
            List<bool> allChecks = new List<bool>
            {
                IsValidEmail(EmailTextBox.Texts),
                CheckTextBoxIsNull(excludedTextBoxes),
                CheckLoginUserInDB(oldUserLogin, MainWorkFormAdmin.selectedRowId)
            };
            return allChecks;
        }
        #endregion
        #region [Метод, формирующий bool значение проверки CheckUpdateAuth]
        /// <summary>
        /// Метод, формирующий bool значение проверки CheckUpdateAuth
        /// </summary>
        /// <param name="checkUpdateAuth">Bool значение выполненного sql-запроса</param>
        /// <param name="fioFK">Переменная, использующаяся в формировании sql-запроса</param>
        private void ReceiveBoolCheckUpdateAuth(out bool checkUpdateAuth, string fioFK)
        {
            string sqlQueryFour = sqlQueries.SqlComUpdateAuth(fioFK, LoginTextBox.Texts);
            checkUpdateAuth = dataBaseWork.WithoutOutputQuery(sqlQueryFour);
        }
        #endregion
        #region [Метод, формирующий string значение fioFK из полученного результата sql-запроса]
        /// <summary>
        /// Метод, формирующий string значение fioFK из полученного результата sql-запроса
        /// </summary>
        /// <param name="fioFK">Переменная, хранящая значение из sql-запроса</param>
        private void ReceiveFioFK(out string fioFK)
        {
            if (OtchTextBox.Texts != string.Empty)
            {
                string sqlQueryThree = sqlQueries.SqlComTakeFKFio(
                    ImyaTextBox.Texts, FamTextBox.Texts, OtchTextBox.Texts);
                fioFK = dataBaseWork.GetString(sqlQueryThree);
            }
            else
            {
                string sqlQueryThree = sqlQueries.SqlComTakeFKFi(
                    ImyaTextBox.Texts, FamTextBox.Texts);
                fioFK = dataBaseWork.GetString(sqlQueryThree);
            }
        }
        #endregion
        #region [Метод, формирующий bool значение проверки CheckInsertUser]
        /// <summary>
        /// Метод, формирующий bool значение проверки CheckInsertUser
        /// </summary>
        /// <param name="checkUpdateUser">Bool значение выполненного sql-запроса</param>
        /// <param name="roleID">Переменная, использующаяся в формировании sql-запроса</param>
        private void ReceiveBoolCheckUpdateUser(out bool checkUpdateUser, string roleID)
        {
            string sqlQuerySecond = sqlQueries.SqlComUpdateUser
                (MainWorkFormAdmin.selectedRowId, LoginTextBox.Texts, 
                PasswordTextBox.Texts, roleID, EmailTextBox.Texts);
            checkUpdateUser = dataBaseWork.WithoutOutputQuery(sqlQuerySecond);
        }
        #endregion
        #region [Метод, формирующий string значение roleID из полученного результата sql-запроса]
        /// <summary>
        /// Метод, формирующий string значение roleID из полученного результата sql-запроса
        /// </summary>
        /// <param name="roleID"></param>
        private void ReceiveRoleID(out string roleID)
        {
            string sqlQuery = sqlQueries.SqlComRoleAddUser(RoleTextBox.Texts);
            roleID = dataBaseWork.GetString(sqlQuery);
        }
        #endregion
        #region [Метод, проверяющий на пустоту TextBox'ы на форме]
        /// <summary>
        /// Метод, проверяющий на пустоту TextBox'ы на форме
        /// </summary>
        /// <param name="excludedTextBoxes">Исключенные для проверки TextBox'ы</param>
        /// <returns></returns>
        private bool CheckTextBoxIsNull(List<CustomTextBox> excludedTextBoxes = null)
        {
            bool hasEmptyTextBoxes = false;
            foreach (CustomTextBox customTextBox in Controls.OfType<CustomTextBox>())
            {
                if (excludedTextBoxes != null && excludedTextBoxes.Contains(customTextBox))
                {
                    continue; // Пропускает textbox'ы, которые находятся в списке исключений
                }
                if (string.IsNullOrWhiteSpace(customTextBox.Texts))
                {
                    MessageBox.Show("Не все поля данных заполнены!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hasEmptyTextBoxes = true;
                    break;
                }
            }
            // Проверка на изменение исключенных textbox'ов
            bool hasEditedExcludedTextBoxes = false;
            string sqlQuery;
            if (excludedTextBoxes != null)
            {
                foreach (CustomTextBox customTextBox in excludedTextBoxes)
                {
                    if (!string.IsNullOrWhiteSpace(customTextBox.Texts))
                    {
                        hasEditedExcludedTextBoxes = true;
                        break;
                    }
                }
                if (hasEditedExcludedTextBoxes)
                {
                    bool emptyExcludedTextBoxFound = false;
                    bool otchTextBoxIsEmpty = string.IsNullOrWhiteSpace(OtchTextBox.Texts);

                    foreach (CustomTextBox customTextBox in excludedTextBoxes)
                    {
                        if (string.IsNullOrWhiteSpace(customTextBox.Texts) && customTextBox != OtchTextBox)
                        {
                            emptyExcludedTextBoxFound = true;
                            break;
                        }
                    }
                    if (!emptyExcludedTextBoxFound)
                    {
                        if (otchTextBoxIsEmpty)
                        {
                            sqlQuery = sqlQueries.SqlComUpdateFioWithoutOtch
                                (ImyaTextBox.Texts, FamTextBox.Texts, MainWorkFormAdmin.selectedRowId);
                            dataBaseWork.WithoutOutputQuery(sqlQuery);
                        }
                        else
                        {
                            sqlQuery = sqlQueries.SqlComUpdateFio
                                (ImyaTextBox.Texts, FamTextBox.Texts,
                                OtchTextBox.Texts, MainWorkFormAdmin.selectedRowId);
                            dataBaseWork.WithoutOutputQuery(sqlQuery);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы начали заполнять поля данных ФИО, " +
                            "пожалуйста, заполните их все, кроме поля отчества, если оно отсутствует!",
                            "Внимание",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            if (hasEmptyTextBoxes)
            {
                return false;
            }
            return true;
        }
        #endregion
        #region [Метод, проверяющий правильность ввода адреса электронной почты]
        /// <summary>
        /// Метод, проверяющий правильность ввода адреса электронной почты
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private Boolean IsValidEmail(string email)
        {
            Regex emailRegex = new Regex (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
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
        #region [Метод, проверяющий уникальность добавляемого логина в БД]
        /// <summary>
        /// Метод, проверяющий уникальность добавляемого логина в БД
        /// </summary>
        /// <returns>True - логин свободен, 
        /// Ложь - логин занят</returns>
        private bool CheckLoginUserInDB(string oldLogin, string userId)
        {
            if (LoginTextBox.Texts != oldLogin)
            {
                string sqlQuery = sqlQueries.SqlComCheckLogin(LoginTextBox.Texts);
                List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 2);
                if (listSearch != null)
                {
                    string foundUserId = listSearch[0][1];
                    if (foundUserId != userId)
                    {
                        MessageBox.Show("Вносимый логин уже зарегистрирован в БД!",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion
        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            List<string[]> listSearch = GetAccountInfo();
            FillTextBoxWithAccountInfo(listSearch);
        }
        private void FillTextBoxWithAccountInfo(List<string[]> listSearch)
        {
            if (listSearch != null)
            {
                foreach (string[] item in listSearch)
                {
                    LoginTextBox.Texts = item[0];
                    PasswordTextBox.Texts = item[1];
                    EmailTextBox.Texts = item[2];
                    FamTextBox.Texts = item[3];
                    ImyaTextBox.Texts = item[4];
                    OtchTextBox.Texts = item[5];
                    RoleTextBox.Texts = item[6];
                    oldUserLogin = item[0];
                }
            }
            else
            {
                LoginTextBox.Texts = "";
                PasswordTextBox.Texts = "";
                EmailTextBox.Texts = "";
                FamTextBox.Texts = "";
                ImyaTextBox.Texts = "";
                OtchTextBox.Texts = "";
                RoleTextBox.Texts = "";
            }
        }

        private List<string[]> GetAccountInfo()
        {
            string sqlQuery = sqlQueries.SqlComCheckAccountInfo(MainWorkFormAdmin.selectedRowId);
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 7);
            return listSearch;
        }
    }
}