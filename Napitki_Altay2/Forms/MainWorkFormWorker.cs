#region [using's]
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;
using Napitki_Altay2.Classes;
using System.Collections.Generic;
using System.Linq;
using ClosedXML.Report.Utils;
using ClosedXML.Excel;
using Microsoft.VisualBasic.ApplicationServices;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class MainWorkFormWorker : Form
    {
        #region [Подключение классов, обьявление переменных]
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        readonly SqlQueries sqlQueries = new SqlQueries();
        public static string SelectedRowID;
        public static string SurnameWorkerString;
        public static string NameWorkerString;
        public static string PatrWorkerString;
        #endregion
        public MainWorkFormWorker()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Событие загрузки формы]
        private void MainWorkFormWorker_Load(object sender, EventArgs e)
        {
            // Передача значения Пароля из формы AuthForm
            PassWorkCreaUpdaTextBox.Texts = AuthForm.PasswordString;
            TakeFioWorker(out List<string[]> listSearch);
            CheckDataReaderRowsInfo(listSearch);
            LoadDataInDataGridViewAnswer();
            LoadDataInCompleteApplicationDGW();
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
        #region [Метод, отправляющий sql-запросы на внесение ФИО в БД]
        /// <summary>
        /// Метод, отправляющий sql-запросы на внесение ФИО в БД
        /// </summary>
        private void CreateUserInfoQuery()
        {
            if (string.IsNullOrEmpty(FamWorkCreateTextBox.Texts) ||
                string.IsNullOrEmpty(NameWorkCreateTextBox.Texts))
                MessageBox.Show("Поля данных не заполнены до конца!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!CheckFIOUserInDB())
                    return;
                InsertAndUpdateQuery(out bool checkInsertFio,
                    out bool checkUpdateWorkerFio);
                if (checkInsertFio && checkUpdateWorkerFio)
                {
                    MessageBox.Show("Операция с данными проведена успешно!",
                        "Информация", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ((Control)AnswerToApplicationPage).Enabled = true;
                    InfoAnswerLabel.Visible = false;
                    CreateUserFIOButton.Enabled = false;
                    FamWorkCreateTextBox.Enabled = false;
                    NameWorkCreateTextBox.Enabled = false;
                    PatrWorkCreateTextBox.Enabled = false;
                }
            }
        }
        #endregion
        #region [Событие нажатия на кнопку AnswerToApplicationButton]
        /// <summary>
        /// Событие нажатия на кнопку AnswerToApplicationButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerToApplicationButton_Click(object sender, EventArgs e)
        {
            OpenAnswerFormAndUpdateStatus();
        }
        #endregion
        #region [Событие нажатия на кнопку GenerateRaportButton]
        /// <summary>
        /// Событие нажатия на кнопку GenerateRaportButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateRaportButton_Click(object sender, EventArgs e)
        {
            if (FolderPathBrowserDialog.ShowDialog() == DialogResult.OK)
                FilePathTextBox.Texts = FolderPathBrowserDialog.SelectedPath;
            if(FilePathTextBox.Texts != string.Empty)
            {
                GenerateExcelRaport();
            }
        }
        #endregion
        #region [Событие закрытия формы]
        /// <summary>
        /// Событие закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWorkFormWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region [Событие нажатия на кнопку UpdLogPassButton]
        private void UpdLogPassButton_Click(object sender, EventArgs e)
        {
            UpdatePassQuery();
        }
        #endregion
        #region [Метод, получающий ФИО сотрудника]
        /// <summary>
        /// Метод, получающий ФИО сотрудника
        /// </summary>
        /// <param name="listSearch"></param>
        private void TakeFioWorker(out List<string[]> listSearch)
        {
            string sqlQueryFirst = sqlQueries.SqlComTakeFioWorker(AuthForm.LoginString);
            listSearch = dataBaseWork.GetMultiList(sqlQueryFirst, 4);
        }
        #endregion
        #region [Метод, проверяющий наличие у пользователя заполненного ФИО в БД]
        /// <summary>
        /// Метод проверки наличия у пользователя заполненного ФИО в БД
        /// </summary>
        /// <param name="strings"></param>
        private void CheckDataReaderRowsInfo(List<string[]> strings)
        {
            if (strings != null)
            {
                foreach (string[] item in strings)
                {
                    if (item.GetValue(1).ToString() == string.Empty)
                    {
                        FamWorkCreateTextBox.Texts = "";
                        NameWorkCreateTextBox.Texts = "";
                        PatrWorkCreateTextBox.Texts = "";
                        ((Control)AnswerToApplicationPage).Enabled = false;
                        InfoAnswerLabel.Visible = true;
                    }
                    else
                    {
                        FamWorkCreateTextBox.Texts = item.GetValue(1).ToString();
                        NameWorkCreateTextBox.Texts = item.GetValue(2).ToString();
                        if (item.GetValue(3) == null || item.GetValue(3).ToString() == string.Empty)
                            PatrWorkCreateTextBox.Texts = "";
                        else
                            PatrWorkCreateTextBox.Texts = item.GetValue(3).ToString();
                        CreateUserFIOButton.Enabled = false;
                        FamWorkCreateTextBox.Enabled = false;
                        NameWorkCreateTextBox.Enabled = false;
                        PatrWorkCreateTextBox.Enabled = false;
                        InfoAnswerLabel.Visible = false;
                        ((Control)AnswerToApplicationPage).Enabled = true;
                    }
                }
            }
            else
            {
                FamWorkCreateTextBox.Texts = "";
                NameWorkCreateTextBox.Texts = "";
                PatrWorkCreateTextBox.Texts = "";
                ((Control)AnswerToApplicationPage).Enabled = false;
                InfoAnswerLabel.Visible = true;
            }
        }
        #endregion
        #region [Метод, вносящий ФИО и добавляющий его к пользователю]
        /// <summary>
        /// Метод, вносящий ФИО и добавляющий его к пользователю
        /// </summary>
        /// <param name="checkInsertFio"></param>
        /// <param name="checkUpdateWorkerFio"></param>
        private void InsertAndUpdateQuery(out bool checkInsertFio, 
            out bool checkUpdateWorkerFio)
        {
            string sqlQuerySecond = sqlQueries.SqlComInsertWorkerFio
                (NameWorkCreateTextBox.Texts,
                FamWorkCreateTextBox.Texts,
                PatrWorkCreateTextBox.Texts);
            string sqlQueryThree = sqlQueries.SqlComUpdateWorkerForFio
                (NameWorkCreateTextBox.Texts,
                FamWorkCreateTextBox.Texts,
                PatrWorkCreateTextBox.Texts,
                AuthForm.LoginString);
            checkInsertFio = dataBaseWork.WithoutOutputQuery(sqlQuerySecond);
            checkUpdateWorkerFio = dataBaseWork.WithoutOutputQuery(sqlQueryThree);
        }
        #endregion
        #region [Метод, проверяющий занятость ФИО в БД]
        /// <summary>
        /// Метод проверки занятости ФИО в БД
        /// </summary>
        /// <returns>True - свободен, false - занят</returns>
        public Boolean CheckFIOUserInDB()
        {
            string sqlQueryFirst = sqlQueries.SqlComCheckWorkerFio
                (NameWorkCreateTextBox.Texts, 
                FamWorkCreateTextBox.Texts, 
                PatrWorkCreateTextBox.Texts);
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQueryFirst, 4);
            if (listSearch != null)
                return false;
            else
                return true;
        }
        #endregion
        #region [Метод, выводящий данные в CompleteApplicationDGW]
        public void LoadDataInCompleteApplicationDGW()
        {
            string sqlQueryFourth = sqlQueries.SqlComOutputAnswers
                (NameWorkCreateTextBox.Texts, 
                FamWorkCreateTextBox.Texts, 
                PatrWorkCreateTextBox.Texts);
            DataTable dataTable = dataBaseWork.OutputQuery(sqlQueryFourth);
            OutputInTableSettingTwo(dataTable);
        }
        #endregion
        #region [Метод, выводящий данные в DataGridViewAnswer]
        /// <summary>
        /// Метод, выводящий данные в DataGridViewAnswer
        /// </summary>
        public void LoadDataInDataGridViewAnswer()
        {
            FillStrings();
            string sqlQueryFive = sqlQueries.sqlComOutputApplications;
            DataTable dataTable = dataBaseWork.OutputQuery(sqlQueryFive);
            OutputInTableSetting(dataTable);
        }
        #endregion
        #region [Метод, заполняющий string переменные]
        /// <summary>
        /// Метод, заполняющий string переменные
        /// </summary>
        private void FillStrings()
        {
            SurnameWorkerString = FamWorkCreateTextBox.Texts;
            NameWorkerString = NameWorkCreateTextBox.Texts;
            PatrWorkerString = PatrWorkCreateTextBox.Texts;
        }
        #endregion
        #region [Метод, настраивающий вывод информации в DataGridViewAnswer]
        /// <summary>
        /// Настройки вывода информации в DataGridViewApplication
        /// </summary>
        /// <param name="dataTable"></param>
        private void OutputInTableSetting(DataTable dataTable)
        {
            DataGridViewAnswer.DataSource = dataTable;
            DataGridViewAnswer.Columns[0].HeaderText = "Номер обращения";
            DataGridViewAnswer.Columns[0].Width = 80;
            DataGridViewAnswer.Columns[1].HeaderText = "Компания";
            DataGridViewAnswer.Columns[1].Width = 100;
            DataGridViewAnswer.Columns[2].HeaderText = "Фамилия";
            DataGridViewAnswer.Columns[2].Width = 100;
            DataGridViewAnswer.Columns[3].HeaderText = "Имя";
            DataGridViewAnswer.Columns[3].Width = 100;
            DataGridViewAnswer.Columns[4].HeaderText = "Отчество";
            DataGridViewAnswer.Columns[4].Width = 100;
            DataGridViewAnswer.Columns[5].HeaderText = "Статус обращения";
            DataGridViewAnswer.Columns[5].Width = 218;
        }
        #endregion
        #region [Метод, настраивающий вывод информации в CompleteApplicationDGW]
        /// <summary>
        /// Настройки вывода информации в DataGridViewApplication
        /// </summary>
        /// <param name="dataTable"></param>
        private void OutputInTableSettingTwo(DataTable dataTable)
        {
            CompleteApplicationDGW.DataSource = dataTable;
            CompleteApplicationDGW.Columns[0].HeaderText = 
                "Номер обращения";
            CompleteApplicationDGW.Columns[0].Width = 80;
            CompleteApplicationDGW.Columns[1].HeaderText = 
                "Фамилия";
            CompleteApplicationDGW.Columns[1].Width = 100;
            CompleteApplicationDGW.Columns[2].HeaderText = 
                "Имя";
            CompleteApplicationDGW.Columns[2].Width = 100;
            CompleteApplicationDGW.Columns[3].HeaderText = 
                "Отчество";
            CompleteApplicationDGW.Columns[3].Width = 100;
            CompleteApplicationDGW.Columns[4].HeaderText = 
                "Время ответа сотрудника";
            CompleteApplicationDGW.Columns[4].Width = 130;
            CompleteApplicationDGW.Columns[5].HeaderText =
                "Статус обращения";
            CompleteApplicationDGW.Columns[5].Width = 188;
        }
        #endregion
        #region [Метод, обновляющий данные в DataGridViewAnswer]
        private void UpdateAnswerInDGW_Click(object sender, EventArgs e)
        {
            LoadDataInDataGridViewAnswer();
        }
        #endregion
        #region [Метод, открывающий форму ответа на заявление и обновление статуса]
        /// <summary>
        /// Метод, открывающий форму ответа на заявление и обновление статуса
        /// </summary>
        private void OpenAnswerFormAndUpdateStatus()
        {
            try
            {
                if (DataGridViewAnswer.RowCount != 0)
                {
                    SelectedRowID = DataGridViewAnswer.CurrentRow.Cells[0].Value.ToString();
                    if (DataGridViewAnswer.CurrentRow.Cells[5].Value.ToString() == "Новое обращение")
                    {
                        string sqlQuerySix = sqlQueries.sqlComCheckStatusId;
                        string statusName = dataBaseWork.GetString(sqlQuerySix);
                        string sqlQuerySeven = sqlQueries.SqlComUpdateStatusApplication
                            (statusName, SelectedRowID);
                        bool checkInsert = dataBaseWork.WithoutOutputQuery(sqlQuerySeven);
                        if (checkInsert)
                        {
                            LoadDataInDataGridViewAnswer();
                            AnswerToUserApplicationForm answerForm = new AnswerToUserApplicationForm();
                            answerForm.Show();
                            UserApplicationInfoForWorkerForm userForm = new UserApplicationInfoForWorkerForm();
                            userForm.Show();
                        }
                    }
                    else
                    {
                        AnswerToUserApplicationForm answerForm = new AnswerToUserApplicationForm();
                        answerForm.Show();
                        UserApplicationInfoForWorkerForm userForm = new UserApplicationInfoForWorkerForm();
                        userForm.Show();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно дать ответ на не выделенное обращение!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region [Метод, получающий русское название месяцев для выводного отчёта]
        private string GetRussianMonthName(int month)
        {
            string[] monthNames = { "Январь", "Февраль", "Март", "Апрель", 
                "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", 
                "Ноябрь", "Декабрь" };
            return monthNames[month - 1];
        }
        #endregion
        #region [Метод, позволяющий сформировать excel рапорт]
        /// <summary>
        /// Метод, позволяющий сформировать excel рапорт
        /// </summary>
        private void GenerateExcelRaport()
        {
            object missingValue = Type.Missing;
            Excel.Application IApplication = new Excel.Application();
            Excel.Workbook IWorkbook = IApplication.Workbooks.Add(missingValue);
            Excel.Worksheet IWorksheet = IWorkbook.Worksheets.get_Item(1);
            // Заголовок отчета
            IWorksheet.Cells[1, 1].Font.Size = 20;
            IWorksheet.Cells[1, 1].Font.Bold = true;
            IWorksheet.Cells[1, 1] = $"Отчет о проделанной работе сотрудника";
            // Заголовки столбцов
            int columnIndex = 1;
            for (int i = 0; i < CompleteApplicationDGW.Columns.Count; i++)
            {
                if (CompleteApplicationDGW.Columns[i].HeaderText == "User_Surname" ||
                    CompleteApplicationDGW.Columns[i].HeaderText == "User_Name" ||
                    CompleteApplicationDGW.Columns[i].HeaderText == "User_Patronymic")
                    continue;
                IWorksheet.Cells[3, columnIndex] = CompleteApplicationDGW.Columns[i].HeaderText;
                IWorksheet.Cells[3, columnIndex].Font.Bold = true;
                IWorksheet.Cells[3, columnIndex].Interior.Color = Color.FromArgb(201, 235, 200);
                IWorksheet.Cells[3, columnIndex].Borders.Color = Color.Black;
                columnIndex++;
            }
            Dictionary<string, int> employeeTasksCount = new Dictionary<string, int>();
            // Данные таблицы
            for (int j = 0; j < CompleteApplicationDGW.Rows.Count; j++)
            {
                string currentEmployeeName = Convert.ToString
                    (CompleteApplicationDGW.Rows[j].Cells["User_Name"].Value);
                if (!employeeTasksCount.ContainsKey(currentEmployeeName))
                {
                    employeeTasksCount[currentEmployeeName] = 1;
                }
                else
                {
                    employeeTasksCount[currentEmployeeName]++;
                }
                columnIndex = 1;
                for (int i = 0; i < CompleteApplicationDGW.Columns.Count; i++)
                {
                    if (CompleteApplicationDGW.Columns[i].HeaderText == "User_Surname" ||
                        CompleteApplicationDGW.Columns[i].HeaderText == "User_Name" ||
                        CompleteApplicationDGW.Columns[i].HeaderText == "User_Patronymic")
                        continue;
                    IWorksheet.Cells[j + 4, columnIndex] = Convert.ToString
                        (CompleteApplicationDGW.Rows[j].Cells[i].Value);
                    IWorksheet.Cells[j + 4, columnIndex].Interior.Color = Color.FromArgb(218, 237, 255);
                    IWorksheet.Cells[j + 4, columnIndex].Borders.Color = Color.Black;
                    columnIndex++;
                }
            }
            IWorksheet.Columns.AutoFit();
            // Вывод статистики по сотрудникам
            int summaryRow = CompleteApplicationDGW.Rows.Count + 5;
            IWorksheet.Cells[summaryRow, 1] = "Количество завершенных обращений";
            IWorksheet.Cells[summaryRow, 1].Font.Bold = true;
            IWorksheet.Cells[summaryRow, 1].Interior.Color = Color.FromArgb(201, 235, 200);
            IWorksheet.Cells[summaryRow, 1].Borders.Color = Color.Black;
            int employeeRow = summaryRow + 1;
            foreach (var employee in employeeTasksCount)
            {
                IWorksheet.Cells[employeeRow, 1] = employee.Value;
                IWorksheet.Cells[employeeRow, 1].Interior.Color = Color.FromArgb(218, 237, 255);
                IWorksheet.Cells[employeeRow, 1].Borders.Color = Color.Black;
                employeeRow++;
            }
            // Добавление диаграммы
            Excel.ChartObjects chartObjects = (Excel.ChartObjects)IWorksheet.ChartObjects(Type.Missing);
            Excel.ChartObject chartObject = chartObjects.Add(400, 60, 400, 300); // Изменение размеров диаграммы
            Excel.Chart chart = chartObject.Chart;
            Excel.Range dataRange = IWorksheet.Range[IWorksheet.Cells[summaryRow + 1, 1], IWorksheet.Cells[employeeRow - 1, 1]];
            chart.SetSourceData(dataRange);
            chart.ChartType = Excel.XlChartType.xlColumnClustered;
            chart.HasTitle = true;
            var cultureInfo = new CultureInfo("ru-RU");
            string monthName = DateTime.Now.ToString("MMMM", cultureInfo);
            chart.ChartTitle.Text = $"Завершенные обращения за {monthName}";
            chart.HasLegend = false;
            // Подпись и дата
            int lastRow = employeeRow + 1;
            IWorksheet.Cells[lastRow, 1].Font.Bold = true;
            IWorksheet.Cells[lastRow, 1] = $"Дата: {DateTime.Now:dd-MM-yyyy}";
            IWorksheet.Cells[lastRow, 5] = "Подпись главы отдела:_____________";
            IWorksheet.Cells[lastRow, 5].Font.Bold = true; // Выделение жирным
            IWorksheet.Cells[lastRow + 1, 5] = "Место печати ";
            IWorksheet.Cells[lastRow + 1, 5].Font.Bold = true; // Выделение жирным
            // Сохранение файла
            string excelFileName = " Отчет о завершенных обращениях.xlsx";
            string finalFileName = DateTime.Now.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture) + excelFileName;
            string filePath = FilePathTextBox.Texts;
            if (FilePathTextBox.Texts.IsNullOrWhiteSpace())
            {
                MessageBox.Show("Путь сохранения не определен!", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                finalFileName = Path.Combine(filePath, finalFileName);
                IWorkbook.SaveAs(finalFileName);
                MessageBox.Show("Отчёт успешно сформирован!", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                IWorkbook.Close(true, missingValue, missingValue);
                IApplication.Quit();
            }
        }
        #endregion
        #region [Метод, обновляющий данные в CompleteApplicationDGW]
            /// <summary>
            /// Метод, обновляющий данные в CompleteApplicationDGW
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void UpdateDataDGWAnswer_Click(object sender, EventArgs e)
        {
            LoadDataInCompleteApplicationDGW();
        }
        #endregion
        #region [Метод, показывающий/скрывающий видимость пароля]
        private void VisiblePassCheckMain_CheckedChanged(object sender, EventArgs e)
        {
            PassWorkCreaUpdaTextBox.PasswordChar = !VisiblePassCheckMain.Checked;
        }
        #endregion
        #region [Метод, отправляющий sql-запрос на обновление пароля]
        /// <summary>
        /// Метод, отправляющий sql-запрос на обновление пароля 
        /// </summary>
        private void UpdatePassQuery()
        {
            string sqlQuery = sqlQueries.SqlComUpdPass(PassWorkCreaUpdaTextBox.Texts);
            bool checkSql = dataBaseWork.WithoutOutputQuery(sqlQuery);
            if (checkSql != false)
            {
                MessageBox.Show("Операция с данными проведена успешно!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdLogPassButton.Enabled = false;
            }
        }
        #endregion
        #region [Событие нажатия на кнопку SupplementReplyButton]
        /// <summary>
        /// Событие нажатия на кнопку SupplementReplyButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SupplementReplyButton_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}