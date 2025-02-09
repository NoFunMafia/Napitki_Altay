#region [using's]
using System;
using System.Data;
using System.Windows.Forms;
using Napitki_Altay2.Classes;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class MainWorkForm : Form
    {
        #region [Подключение классов, объявление переменных]
        // Класс запросов в БД
        readonly SqlQueries sqlQueries = new SqlQueries();
        // Использование класса работы с БД
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        public static string surnameUserString;
        public static string nameUserString;
        public static string patronymicUserString;
        public static string selectedRowIDInDGWC;
        public static string deletedRow;
        #endregion
        public MainWorkForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Событие загрузки формы]
        /// <summary>
        /// Событие загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWorkForm_Load(object sender, EventArgs e)
        {
            // Передача значения Пароля из формы AuthForm
            PassCreaUpdaTextBox.Texts = AuthForm.PasswordString;
            List<string[]> listSearch = FillListQuery();
            CheckFIOinList(listSearch);
            LoadDataGridView();
            LoadDataGridViewComplete();
            if (FamCreateTextBox.Texts != string.Empty)
            {
                MainWorkForm mainWorkForm = Application.OpenForms.OfType<MainWorkForm>().FirstOrDefault();
                mainWorkForm.Text = $"Автоматизация документооборота. " +
                    $"Заявитель - {FamCreateTextBox.Texts} {NameCreateTextBox.Texts} " +
                    $"{PatrCreateTextBox.Texts}";
            }
        }
        #endregion
        #region [Событие нажатия на кнопку UpdLogPassButton]
        /// <summary>
        /// Событие нажатия на кнопку UpdLogPassButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdLogPassButton_Click(object sender, EventArgs e)
        {
            if (CheckPass(PassCreaUpdaTextBox.Texts, 7, 15))
                return;
            UpdatePassQuery();
        }
        #endregion
        #region [Событие нажатия на кнопку CreateUserFIOButton]
        /// <summary>
        /// Событие нажатия на кнопку CreateUserFIOButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateUserFIOButton_Click(object sender, EventArgs e)
        {
            CreateUserInfoQuery();
        }
        #endregion
        #region [Метод, проверяющий пароль на надёжность]
        public Boolean CheckPass(string inputPass, int minLenght, int maxLenght)
        {
            bool hasCap = false, hasLow = false, hasSpec = false;
            char currentCharacter;
            bool hasNum;
            if (!(inputPass.Length <= minLenght
                || inputPass.Length >= maxLenght))
            {
                hasNum = false;
            }
            else
            {
                MessageBox.Show("Пароль не соответствует требованиям!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            for (int i = 0; i < inputPass.Length; i++)
            {
                currentCharacter = inputPass[i];
                if (char.IsDigit(currentCharacter))
                    hasNum = true;
                else if (char.IsUpper(currentCharacter))
                    hasCap = true;
                else if (char.IsLower(currentCharacter))
                    hasLow = true;
                else if (!char.IsLetterOrDigit(currentCharacter))
                    hasSpec = true;
            }
            if (hasNum && hasCap && hasLow && hasSpec)
                return false;
            else
                MessageBox.Show("Пароль не соответствует требованиям!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }
        #endregion
        #region [Событие нажатия на кнопку CreateApplicationButton]
        /// <summary>
        /// Событие нажатия на кнопку CreateApplicationButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateApplicationButton_Click(object sender, EventArgs e)
        {
            CreateApplicationForm createApplicationForm = new CreateApplicationForm();
            createApplicationForm.Show();
            Hide();
        }
        #endregion
        #region [Событие нажатия на кнопку UpdateDataInDGW]
        /// <summary>
        /// Событие нажатия на кнопку UpdateDataInDGW
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateDataInDGW_Click(object sender, EventArgs e)
        {
            DataTable dataTable = UpdateInfoQuery();
            OutputInTableSetting(dataTable);
        }
        #endregion
        #region [Событие нажатия на кнопку DeleteApplicationButton]
        /// <summary>
        /// Событие нажатия на кнопку DeleteApplicationButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteApplicationButton_Click(object sender, EventArgs e)
        {
            DeleteApplicationQuery();
        }
        #endregion
        #region [Событие нажатия на кнопку OpenPriceListButton]
        /// <summary>
        /// Событие нажатия на кнопку OpenPriceListButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenPriceListButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start
                ("https://napitki-altay.ru/wp-content/uploads/2022/01/" +
                "Прайс-лист-01.11.2021-3.pdf");
        }
        #endregion
        #region [События нажатия на кнопки открытия СОУТов]
        /// <summary>
        /// Событие нажатия на кнопку OpenSout2016Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSout2016Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start
                ("https://napitki-altay.ru/wp-content/uploads/2018/09/" +
                "результаты-СОУТ-2016-2017.pdf");
        }
        /// <summary>
        /// Событие нажатия на кнопку OpenSout2018Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSout2018Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start
                ("https://napitki-altay.ru/wp-content/uploads/2018/09/" +
                "результаты-СОУТ-2018.pdf");
        }
        /// <summary>
        /// Событие нажатия на кнопку OpenSout2021Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSout2021Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start
                ("https://napitki-altay.ru/wp-content/uploads/2021/11/" +
                "Сводная-ведомость-результатов-" +
                "проведения-специальной-оценки" +
                "-условий-труда-01.11.2021г.pdf");
        }
        #endregion
        #region [Событие, закрывающее приложение при закрытии формы]
        private void MainWorkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region [Метод, осуществляющий открытие ответа от сотрудника]
        /// <summary>
        /// Метод, осуществляющий открытие ответа от сотрудника
        /// формы ReadyApplicationInfoForUserForm
        /// </summary>
        private void OpenMessageFromWorker()
        {
            try
            {
                if (CompleteApplicationDGWUser.RowCount != 0)
                {
                    selectedRowIDInDGWC = CompleteApplicationDGWUser.CurrentRow.Cells[0].Value.ToString();
                    ReadyApplicationInfoForUserForm readyForm = new ReadyApplicationInfoForUserForm();
                    readyForm.Show();
                    readyForm.Location = new Point(740, 90);
                    Hide();
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно открыть не выделенное обращение!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region [Метод, отправляющий sql-запрос на обновление пароля]
        /// <summary>
        /// Метод, отправляющий sql-запрос на обновление пароля 
        /// </summary>
        private void UpdatePassQuery()
        {
            string sqlQuery = sqlQueries.SqlComUpdPass(PassCreaUpdaTextBox.Texts);
            bool checkSql = dataBaseWork.WithoutOutputQuery(sqlQuery);
            if (checkSql != false)
            {
                MessageBox.Show("Операция с данными проведена успешно!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdLogPassButton.Enabled = false;
            }
        }
        #endregion
        #region [Метод, отправляющий sql-запросы на внесение ФИО в БД]
        /// <summary>
        /// Метод, отправляющий sql-запросы на внесение ФИО в БД
        /// </summary>
        private void CreateUserInfoQuery()
        {
            if (string.IsNullOrEmpty(FamCreateTextBox.Texts) ||
                string.IsNullOrEmpty(NameCreateTextBox.Texts))
                MessageBox.Show("Поля данных не заполнены до конца!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (CheckFIOUserInDB())
                    return;
                string sqlQueryFirst = sqlQueries.SqlComInsFIO
                    (FamCreateTextBox.Texts,
                    NameCreateTextBox.Texts,
                    PatrCreateTextBox.Texts);
                string sqlQuerySecond = sqlQueries.SqlComInsFIOSec
                    (FamCreateTextBox.Texts,
                    NameCreateTextBox.Texts,
                    PatrCreateTextBox.Texts);
                bool checkQueryFirst = dataBaseWork.WithoutOutputQuery(sqlQueryFirst);
                MessageBox.Show("Операция с данными проведена успешно!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (checkQueryFirst != false)
                {
                    FillStrings();
                    LoadDataGridView();
                    CreateUserFIOButton.Enabled = false;
                    ((Control)ApplicationPage).Enabled = true;
                    InfoApplicationLabel.Visible = false;
                    FamCreateTextBox.Enabled = false;
                    NameCreateTextBox.Enabled = false;
                    PatrCreateTextBox.Enabled = false;
                    MainWorkForm mainWorkForm = Application.OpenForms.OfType<MainWorkForm>().FirstOrDefault();
                    mainWorkForm.Text = $"Автоматизация документооборота. " +
                        $"Заявитель - {FamCreateTextBox.Texts} {NameCreateTextBox.Texts} " +
                        $"{PatrCreateTextBox.Texts}";
                }
                dataBaseWork.WithoutOutputQuery(sqlQuerySecond);
            }
        }
        #endregion
        #region [Метод, отправляющий sql-запрос на удаление записи обращения из БД]
        /// <summary>
        /// Метод, отправляющий sql-запрос на удаление записи обращения из БД
        /// </summary>
        private void DeleteApplicationQuery()
        {
            try
            {
                if (DataGridViewApplication.RowCount != 0)
                {
                    DialogResult result = MessageBox.Show
                        ("Вы действительно хотите удалить обращение?",
                        "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        deletedRow = DataGridViewApplication.CurrentRow.Cells[0].Value.ToString();
                        string sqlQuery = sqlQueries.SqlComDelete(deletedRow);
                        bool checkDelete = dataBaseWork.WithoutOutputQuery(sqlQuery);
                        if (checkDelete != true)
                            MessageBox.Show("Завершенные обращения удалять нельзя!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadDataGridView();
                    }
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно удалить не выделенное обращение!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region [Метод, обновляющий из sql-запроса данные в DataGridViewApplication]
        /// <summary>
        /// Метод, обновляющий из sql-запроса данные в DataGridViewApplication
        /// </summary>
        /// <returns></returns>
        private DataTable UpdateInfoQuery()
        {
            string sqlQuery = sqlQueries.SqlComUpdateDGW
                (FamCreateTextBox.Texts, NameCreateTextBox.Texts, PatrCreateTextBox.Texts);
            DataTable dataTable = dataBaseWork.OutputQuery(sqlQuery);
            return dataTable;
        }
        #endregion
        #region [Метод, заполняющий список List данными из sql-запроса]
        /// <summary>
        /// Метод, заполняющий список List данными из sql-запроса
        /// </summary>
        /// <returns></returns>
        private List<string[]> FillListQuery()
        {
            string sqlQuery = sqlQueries.sqlComRecFIO;
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 4);
            return listSearch;
        }
        #endregion
        #region [Метод, выводящий данные в таблицу DataGridViewApplication]
        /// <summary>
        /// Вывод данных в таблицу DataGridViewApplication
        /// </summary>
        public void LoadDataGridView()
        {
            FillStrings();
            string sqlQuery = sqlQueries.SqlOutputMWF
                (nameUserString, surnameUserString, patronymicUserString);
            DataTable dataTable = dataBaseWork.OutputQuery(sqlQuery);
            OutputInTableSetting(dataTable);
        }
        #endregion
        #region [Метод, заполняющий переменные string]
        /// <summary>
        /// Метод, заполняющий переменные string
        /// </summary>
        private void FillStrings()
        {
            surnameUserString = FamCreateTextBox.Texts;
            nameUserString = NameCreateTextBox.Texts;
            patronymicUserString = PatrCreateTextBox.Texts;
        }
        #endregion
        #region [Метод, выводящий данные в таблицу CompleteApplicationDGWUser]
        /// <summary>
        /// Вывод данных в таблицу CompleteApplicationDGWUser
        /// </summary>
        public void LoadDataGridViewComplete()
        {
            string sqlQuery = sqlQueries.SqlComIDUser
                (surnameUserString, nameUserString, patronymicUserString);
            string stringFromQuery = dataBaseWork.GetString(sqlQuery);
            string stringResultFK = sqlQueries.SqlComFKInfo(stringFromQuery);
            DataTable dataTable = dataBaseWork.OutputQuery(stringResultFK);
            OutputInTableSettingTwo(dataTable);
        }
        #endregion
        #region [Метод, настраивающий отображение выводимых данных в таблицу CompleteApplicationDGWUser]
        /// <summary>
        /// Настройка отображения выводимых 
        /// данных в таблицу CompleteApplicationDGWUser
        /// </summary>
        /// <param name="dataTable">Передаваемая таблица с данными</param>
        private void OutputInTableSettingTwo(DataTable dataTable)
        {
            CompleteApplicationDGWUser.DataSource = dataTable;
            CompleteApplicationDGWUser.Columns[0].HeaderText = "Номер обращения";
            CompleteApplicationDGWUser.Columns[0].Width = 74;
            CompleteApplicationDGWUser.Columns[1].HeaderText = "Фамилия";
            CompleteApplicationDGWUser.Columns[1].Width = 95;
            CompleteApplicationDGWUser.Columns[2].HeaderText = "Имя";
            CompleteApplicationDGWUser.Columns[2].Width = 95;
            CompleteApplicationDGWUser.Columns[3].HeaderText = "Отчество";
            CompleteApplicationDGWUser.Columns[3].Width = 95;
            CompleteApplicationDGWUser.Columns[4].HeaderText = "Время ответа сотрудника";
            CompleteApplicationDGWUser.Columns[4].Width = 118;
            CompleteApplicationDGWUser.Columns[5].HeaderText = "Статус обращения";
            CompleteApplicationDGWUser.Columns[5].Width = 220;
        }
        #endregion
        #region [Метод, настроивающий отображение выводимых данных в таблицу DataGridViewApplication]
        /// <summary>
        /// Настройка отображения выводимых 
        /// данных в таблицу DataGridViewApplication
        /// </summary>
        /// <param name="dataTable">Передаваемая таблица с данными</param>
        private void OutputInTableSetting(DataTable dataTable)
        {
            DataGridViewApplication.DataSource = dataTable;
            DataGridViewApplication.Columns[0].HeaderText = "Номер обращения";
            DataGridViewApplication.Columns[0].Width = 80;
            DataGridViewApplication.Columns[1].HeaderText = "Компания";
            DataGridViewApplication.Columns[1].Width = 130;
            DataGridViewApplication.Columns[2].HeaderText = "Фамилия";
            DataGridViewApplication.Columns[2].Width = 90;
            DataGridViewApplication.Columns[3].HeaderText = "Имя";
            DataGridViewApplication.Columns[3].Width = 90;
            DataGridViewApplication.Columns[4].HeaderText = "Отчество";
            DataGridViewApplication.Columns[4].Width = 110;
            /*DataGridViewApplication.Columns[5].HeaderText = "Статус обращения";
            DataGridViewApplication.Columns[5].Width = 197;*/
        }
        #endregion
        #region [Метод, проверяющий наличие у пользователя заполненного ФИО в БД]
        /// <summary>
        /// Метод, проверяющий наличие у 
        /// пользователя заполненного ФИО в БД
        /// </summary>
        /// <param name="strings">Коллекция значений 
        /// полученных из запроса в БД</param>
        public void CheckFIOinList(List<string[]> strings)
        {
            if(strings != null)
            {
                foreach (string[] item in strings)
                {
                    if (item.GetValue(1).ToString() == string.Empty)
                    {
                        FamCreateTextBox.Texts = "";
                        NameCreateTextBox.Texts = "";
                        PatrCreateTextBox.Texts = "";
                        ((Control)ApplicationPage).Enabled = false;
                        InfoApplicationLabel.Visible = true;
                    }
                    else
                    {
                        FamCreateTextBox.Texts = item.GetValue(1).ToString();
                        NameCreateTextBox.Texts = item.GetValue(2).ToString();
                        // Проверка значения отчества
                        if (item.GetValue(3) == null || item.GetValue(3).ToString() == string.Empty)
                            PatrCreateTextBox.Texts = "";
                        else
                            PatrCreateTextBox.Texts = item.GetValue(3).ToString();
                        CreateUserFIOButton.Enabled = false;
                        FamCreateTextBox.Enabled = false;
                        NameCreateTextBox.Enabled = false;
                        PatrCreateTextBox.Enabled = false;
                        ((Control)ApplicationPage).Enabled = true;
                    }
                }
            }
            else
            {
                FamCreateTextBox.Texts = "";
                NameCreateTextBox.Texts = "";
                PatrCreateTextBox.Texts = "";
                ((Control)ApplicationPage).Enabled = false;
                InfoApplicationLabel.Visible = true;
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
            string sqlQuery = sqlQueries.SqlComCheckINFOonFIO
                (FamCreateTextBox.Texts, 
                NameCreateTextBox.Texts, 
                PatrCreateTextBox.Texts);
            DataTable dataTable = dataBaseWork.OutputQuery(sqlQuery);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Данное ФИО уже зарегистрировано " +
                    "в системе, используйте другое!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return true;
            }
            else
                return false;
        }
        #endregion
        #region [Метод, показывающий и скрывающий пароль]
        /// <summary>
        /// Метод, показывающий и скрывающий пароль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VisiblePassCheckMain_CheckedChanged(object sender, EventArgs e)
        {
            PassCreaUpdaTextBox.PasswordChar = !VisiblePassCheckMain.Checked;
        }
        #endregion
        #region [Событие нажатия на кнопку MoreInformationButton]
        /// <summary>
        /// Событие нажатия на кнопку MoreInformationButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoreInformationButton_Click(object sender, EventArgs e)
        {
            OpenSupplementsForm();
        }
        #endregion
        private void OpenSupplementsForm()
        {
            try
            {
                if (CompleteApplicationDGWUser.RowCount != 0)
                {
                    if (CompleteApplicationDGWUser.CurrentRow.Cells[5].Value.ToString() != "Ожидание доп. информации")
                    {
                        selectedRowIDInDGWC = CompleteApplicationDGWUser.CurrentRow.Cells[0].Value.ToString();
                        SupplementForm supForm = new SupplementForm();
                        supForm.Show();
                        supForm.Location = new Point(40, 90);
                        supForm.DisableControls();
                        Hide();
                        OpenMessageFromWorker();
                    }
                    else
                    {
                        selectedRowIDInDGWC = CompleteApplicationDGWUser.CurrentRow.Cells[0].Value.ToString();
                        SupplementForm supForm = new SupplementForm();
                        supForm.Show();
                        supForm.Location = new Point(40, 90);
                        supForm.EnableControls();
                        Hide();
                        OpenMessageFromWorker();
                    }
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно дополнить ответ на не выделенное обращение!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDataDGWCButton_Click(object sender, EventArgs e)
        {
            LoadDataGridViewComplete();
        }
    }
}