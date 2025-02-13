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
    public partial class AddUserForm : Form
    {
        #region [Подключение классов, объявление переменных]
        // Класс запросов в БД
        readonly SqlQueries sqlQueries = new SqlQueries();
        // Использование класса работы с БД
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        #endregion
        public AddUserForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
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
            EmpNumLabel.Visible = true;
            EmpNumTextBox.Visible = true;
            EmpNumTextBox.Texts = "";
        }
        #endregion
        #region [Событие нажатия на item "муниципальный служащий" ToolStrip'а]
        /// <summary>
        /// Событие нажатия на item "сотрудник" ToolStrip'а
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void МунСлужToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleTextBox.Texts = "Муниципальный служащий";
            EmpNumLabel.Visible = true;
            EmpNumTextBox.Visible = true;
            EmpNumTextBox.Texts = "";
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
            EmpNumLabel.Visible = false;
            EmpNumTextBox.Visible = false;
            EmpNumTextBox.Texts = "";
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
                InsertFioAndEmpNum();
                ReceiveRoleID(out string roleID);
                ReceiveBoolCheckInsertUser(out bool checkInsertUser, roleID);
                if (checkInsertUser)
                {
                    ReceiveFioFK(out string fioFK);
                    if (FamTextBox.Texts != string.Empty && ImyaTextBox.Texts != string.Empty)
                    {
                        ReceiveBoolCheckUpdateAuth(out bool checkUpdateAuth, fioFK);
                        if (checkUpdateAuth)
                        {
                            MessageBox.Show("Пользователь успешно добавлен!", "Информация",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        ReceiveBoolCheckUpdateAuth(out bool checkUpdateAuth, fioFK);
                        MessageBox.Show("Пользователь успешно добавлен!", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void InsertFioAndEmpNum()
        {
            if (EmpNumTextBox.Texts.IsNullOrWhiteSpace())
            {
                
                if (OtchTextBox.Texts.IsNullOrWhiteSpace())
                {
                    string sqlQuery = sqlQueries.SqlComInsertFioWithoutOtch
                        (ImyaTextBox.Texts, FamTextBox.Texts, null);
                    dataBaseWork.WithoutOutputQuery(sqlQuery);
                }
                else
                {
                    string sqlQuery = sqlQueries.SqlComInsertFio
                        (ImyaTextBox.Texts, FamTextBox.Texts, OtchTextBox.Texts, null);
                    dataBaseWork.WithoutOutputQuery(sqlQuery);
                }
            }
            else
            {
                if (OtchTextBox.Texts.IsNullOrWhiteSpace())
                {
                    string sqlQuery = sqlQueries.SqlComInsertFioWithoutOtch
                        (ImyaTextBox.Texts, FamTextBox.Texts, EmpNumTextBox.Texts);
                    dataBaseWork.WithoutOutputQuery(sqlQuery);
                }
                else
                {
                    string sqlQuery = sqlQueries.SqlComInsertFio
                        (ImyaTextBox.Texts, FamTextBox.Texts, OtchTextBox.Texts, EmpNumTextBox.Texts);
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
                CheckLoginUserInDB(),
                CheckFIOUserInDB(),
                CheckTextBoxIsNull(excludedTextBoxes),
                CheckMailUserInDB(),
                CheckEmpNumUserInDB()
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
            if(OtchTextBox.Texts != string.Empty)
            {
                string sqlQueryThree = sqlQueries.SqlComTakeFKFio(ImyaTextBox.Texts, FamTextBox.Texts, OtchTextBox.Texts);
                fioFK = dataBaseWork.GetString(sqlQueryThree);
            }
            else
            {
                string sqlQueryThree = sqlQueries.SqlComTakeFKFi(ImyaTextBox.Texts, FamTextBox.Texts);
                fioFK = dataBaseWork.GetString(sqlQueryThree);
            }
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
            string sqlQuerySecond = sqlQueries.SqlComInsertUser(
                LoginTextBox.Texts, PasswordTextBox.Texts, roleID, EmailTextBox.Texts);
            checkInsertUser = dataBaseWork.WithoutOutputQuery(sqlQuerySecond);
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
                // Пропускаем проверку табельного номера, если роль - заявитель
                if (RoleTextBox.Texts == "Заявитель" && customTextBox == EmpNumTextBox)
                {
                    continue;
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
                            "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        #region [Метод, проверяющий уникальность добавляемого логина в БД]
        /// <summary>
        /// Метод, проверяющий уникальность добавляемого логина в БД
        /// </summary>
        /// <returns>True - логин свободен, 
        /// Ложь - логин занят</returns>
        private bool CheckLoginUserInDB()
        {
            string sqlQuery = sqlQueries.SqlComCheckLogin(LoginTextBox.Texts);
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 2);
            if (listSearch != null)
            {
                MessageBox.Show("Вносимый логин уже зарегистрирован в БД!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion
        #region [Метод, проверяющий занятость ФИО в БД]
        /// <summary>
        /// Метод, проверяющий занятость ФИО в БД
        /// </summary>
        /// <returns>True - ФИО свободно, False - ФИО занято</returns>
        public Boolean CheckFIOUserInDB()
        {
            string sqlQuery = sqlQueries.SqlComCheckINFOonFIO
                (FamTextBox.Texts, ImyaTextBox.Texts, OtchTextBox.Texts);
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
        #endregion
        #region [Метод, проверяющий почту пользователя в БД]
        /// <summary>
        /// Метод, проверяющий добавляемого e-mail в БД
        /// </summary>
        /// <returns>True - почта свободна, 
        /// Ложь - почта занята</returns>
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
        #region [Метод, проверяющий уникальность добавляемого логина в БД]
        /// <summary>
        /// Метод, проверяющий уникальность табельного номера в БД
        /// </summary>
        /// <returns>True - табельный номер свободен, 
        /// Ложь - табельный номер занят</returns>
        private bool CheckEmpNumUserInDB()
        {
            string sqlQuery = sqlQueries.SqlComCheckEmpNum(EmpNumTextBox.Texts, RoleTextBox.Texts);
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 2);
            if (listSearch != null)
            {
                MessageBox.Show("Вносимый табельный номер уже зарегистрирован в базе данных!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion
    }
}