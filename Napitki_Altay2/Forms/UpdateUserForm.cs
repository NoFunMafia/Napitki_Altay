#region [using's]
using ClosedXML.Report.Utils;
using Napitki_Altay2.Classes;
using Napitki_Altay2.Design;
using System;
using System.Collections.Generic;
using System.Data;
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
        private string oldUserName;
        private string oldUserFam;
        private string oldUserOtch;
        #endregion
        public UpdateUserForm()
        {
            InitializeComponent();
        }
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
                InsertOrUpdateFio();
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
        private void InsertOrUpdateFio()
        {
            if (oldUserFam != null && oldUserName != null && oldUserOtch != null)
            {
                string sqlQuery = sqlQueries.SqlComUpdateFio
                    (ImyaTextBox.Texts, FamTextBox.Texts,
                    OtchTextBox.Texts, MainWorkFormAdmin.selectedRowId);
                dataBaseWork.WithoutOutputQuery(sqlQuery);
            }
            else if (oldUserFam != null && oldUserName != null)
            {
                string sqlQuery = sqlQueries.SqlComUpdateFioWithoutOtch
                    (ImyaTextBox.Texts, FamTextBox.Texts,
                    MainWorkFormAdmin.selectedRowId);
                dataBaseWork.WithoutOutputQuery(sqlQuery);
            }
            else if (oldUserFam == null && oldUserName == null && oldUserOtch == null)
            {
                if (OtchTextBox.Texts.IsNullOrWhiteSpace())
                {
                    string sqlQuery = sqlQueries.SqlComInsertFioWithoutOtch
                        (ImyaTextBox.Texts, FamTextBox.Texts, FamTextBox.Texts);
                    dataBaseWork.WithoutOutputQuery(sqlQuery);
                }
                else
                {
                    string sqlQuery = sqlQueries.SqlComInsertFio
                        (ImyaTextBox.Texts, FamTextBox.Texts, OtchTextBox.Texts, FamTextBox.Texts);
                    dataBaseWork.WithoutOutputQuery(sqlQuery);
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
                CheckLoginUserInDB(oldUserLogin, MainWorkFormAdmin.selectedRowId),
                CheckFIOUserInDB(),
                CheckTextBoxIsNull(excludedTextBoxes)
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
                    return false;
                }
            }
            // Проверка на изменение исключенных textbox'ов
            bool hasEditedExcludedTextBoxes = false;
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
                        return true;
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
        #region [Метод, проверяющий занятость ФИО в БД]
        /// <summary>
        /// Метод, проверяющий занятость ФИО в БД
        /// </summary>
        /// <returns>True - ФИО занято, False - ФИО свободно</returns>
        public Boolean CheckFIOUserInDB()
        {
            if(oldUserFam == FamTextBox.Texts && 
                oldUserName == ImyaTextBox.Texts)
            {
                return true;
            }
            else
            {
                string sqlQuery = sqlQueries.SqlComCheckINFOonFIO
                (FamTextBox.Texts,
                ImyaTextBox.Texts,
                OtchTextBox.Texts);
                DataTable dataTable = dataBaseWork.OutputQuery(sqlQuery);
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Данное ФИО уже зарегистрировано " +
                        "в системе, используйте другое!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                    return true;
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
                return true;
            }
            return true;
        }
        #endregion
        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            List<string[]> listSearch = GetAccountInfo();
            List<string[]> listSearchSec = GetAccountInfoSec();
            if (listSearch != null)
            {
                FillTextBoxWithAccountInfo(listSearch);
            }
            else if (listSearchSec != null)
            {
                FillTextBoxWithAccountInfoSec(listSearchSec);
            }
        }
        private List<string[]> GetAccountInfoSec()
        {
            string sqlQuery = sqlQueries.SqlComCheckInfoAcc(MainWorkFormAdmin.selectedRowId);
            List<string[]> listSearchSec = dataBaseWork.GetMultiList(sqlQuery, 5);
            return listSearchSec;
        }
        private void FillTextBoxWithAccountInfoSec(List<string[]> listSearch)
        {
            foreach (string[] item in listSearch)
            {
                LoginTextBox.Texts = item[0];
                PasswordTextBox.Texts = item[1];
                EmailTextBox.Texts = item[2];
                RoleTextBox.Texts = item[3];
                EmpNumTextBox.Texts = item[4];
                oldUserLogin = item[0];
            }
        }
        private void FillTextBoxWithAccountInfo(List<string[]> listSearch)
        {
            foreach (string[] item in listSearch)
            {
                LoginTextBox.Texts = item[0];
                PasswordTextBox.Texts = item[1];
                EmailTextBox.Texts = item[2];
                EmpNumTextBox.Texts = item[3];
                FamTextBox.Texts = item[4];
                ImyaTextBox.Texts = item[5];
                OtchTextBox.Texts = item[6];
                RoleTextBox.Texts = item[7];
                oldUserLogin = item[0];
                oldUserFam = item[3];
                oldUserName = item[4];
                oldUserOtch = item[5];
            }
        }
        private List<string[]> GetAccountInfo()
        {
            string sqlQuery = sqlQueries.SqlComCheckAccountInfo(MainWorkFormAdmin.selectedRowId);
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 8);
            return listSearch;
        }
        #region [Метод, проверяющий уникальность добавляемого логина в БД]
        /// <summary>
        /// Метод, проверяющий уникальность добавляемого логина в БД
        /// </summary>
        /// <returns>True - логин свободен, 
        /// Ложь - логин занят</returns>
        private bool CheckMailUserInDB()
        {
            string sqlQuery = sqlQueries.SqlComCheckEmail(EmailTextBox.Texts);
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 2);
            if (listSearch != null)
            {
                MessageBox.Show("Вносимый адрес электронной почты уже зарегистрирован в базе данных!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion
    }
}