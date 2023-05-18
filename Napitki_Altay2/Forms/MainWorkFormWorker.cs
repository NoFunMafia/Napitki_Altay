#region [using's]
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;
using Napitki_Altay2.Classes;
using System.Collections.Generic;
using System.Linq;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class MainWorkFormWorker : Form
    {
        #region [Подключение классов, обьявление переменных]
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        readonly SqlQueries sqlQueries = new SqlQueries();
        public static string SelectedRowID;
        public static string SelectedRowCompleteID;
        public static string SurnameWorkerString;
        public static string NameWorkerString;
        public static string PatrWorkerString;
        private bool isButtonRaportToggled = false;
        #endregion
        public MainWorkFormWorker()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
            SetFirstDayOfMonth();
            SecondDateToRaportDTP.MaxDate = DateTime.Today;
        }
        #region [Событие загрузки формы]
        /// <summary>
        /// Событие загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWorkFormWorker_Load(object sender, EventArgs e)
        {
            // Передача значения Пароля из формы AuthForm
            PassWorkCreaUpdaTextBox.Texts = AuthForm.PasswordString;
            TakeFioWorker(out List<string[]> listSearch);
            CheckDataReaderRowsInfo(listSearch);
            LoadDataInDataGridViewAnswer();
            LoadDataInCompleteApplicationDGW();
            if (FamWorkCreateTextBox.Texts != string.Empty)
            {
                MainWorkFormWorker mainWorkFormWorker = Application.OpenForms.OfType
                    <MainWorkFormWorker>().FirstOrDefault();
                mainWorkFormWorker.Text = $"Автоматизация документооборота. " +
                    $"Сотрудник - {FamWorkCreateTextBox.Texts} {NameWorkCreateTextBox.Texts} " +
                    $"{PatrWorkCreateTextBox.Texts}";
            }
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
            if (!isButtonRaportToggled)
            {
                LoadDataInDataGridViewAnswerWithDate();
                isButtonRaportToggled = true;
            }
            else
            {
                if (FolderPathBrowserDialog.ShowDialog() == DialogResult.OK)
                    FilePathTextBox.Texts = FolderPathBrowserDialog.SelectedPath;
                if (FilePathTextBox.Texts != string.Empty)
                {
                    GenerateExcelRaport(FirstDateToRaportDTP.Value, SecondDateToRaportDTP.Value);
                    isButtonRaportToggled = false;
                }
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
        /// <summary>
        /// Событие нажатия на кнопку UpdLogPassButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdLogPassButton_Click(object sender, EventArgs e)
        {
            UpdatePassQuery();
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
            CreateSupplementReply();
        }

        private void CreateSupplementReply()
        {
            try
            {
                if (CompleteApplicationDGW.RowCount != 0)
                {
                    if (CompleteApplicationDGW.CurrentRow.Cells[5].Value.ToString() != "Дополнено")
                    {
                        SelectedRowID = CompleteApplicationDGW.CurrentRow.Cells[0].Value.ToString();
                        SupplementWorkForm supWorkForm = new SupplementWorkForm();
                        supWorkForm.Show();
                        supWorkForm.Location = new Point(740, 90);
                        supWorkForm.DisableControls();
                        UserApplicationInfoForWorkerForm userForm = new UserApplicationInfoForWorkerForm();
                        userForm.Show();
                        Hide();
                    }
                    else
                    {
                        SelectedRowID = CompleteApplicationDGW.CurrentRow.Cells[0].Value.ToString();
                        SupplementWorkForm supWorkForm = new SupplementWorkForm();
                        supWorkForm.Show();
                        supWorkForm.Location = new Point(740, 90);
                        supWorkForm.EnableControls();
                        UserApplicationInfoForWorkerForm userForm = new UserApplicationInfoForWorkerForm();
                        userForm.Show();
                        Hide();
                    }
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно дополнить/просмотреть ответ не выделенного обращения!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region [Событие смены значения даты в FirstDateToRaportDTP]
        /// <summary>
        /// Событие смены значения даты в FirstDateToRaportDTP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstDateToRaportDTP_ValueChanged(object sender, EventArgs e)
        {
            SecondDateToRaportDTP.MinDate = FirstDateToRaportDTP.Value;
            isButtonRaportToggled = false;
        }
        #endregion
        #region [Событие смены значения даты в SecondDateToRaportDTP]
        /// <summary>
        /// Событие смены значения даты в SecondDateToRaportDTP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SecondDateToRaportDTP_ValueChanged(object sender, EventArgs e)
        {
            FirstDateToRaportDTP.MaxDate = SecondDateToRaportDTP.Value;
            isButtonRaportToggled = false;
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
                    MainWorkFormWorker mainWorkForm = Application.OpenForms.OfType
                        <MainWorkFormWorker>().FirstOrDefault();
                    mainWorkForm.Text = $"Автоматизация документооборота. " +
                        $"Сотрудник - {FamWorkCreateTextBox.Texts} {NameWorkCreateTextBox.Texts} " +
                        $"{PatrWorkCreateTextBox.Texts}";
                }
            }
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
        /// <summary>
        /// Метод, выводящий данные в CompleteApplicationDGW
        /// </summary>
        public void LoadDataInCompleteApplicationDGW()
        {
            if (PatrWorkCreateTextBox.Texts != string.Empty)
            {
                string sqlQueryFourth = sqlQueries.SqlComOutputAnswers
                    (NameWorkCreateTextBox.Texts,
                    FamWorkCreateTextBox.Texts,
                    PatrWorkCreateTextBox.Texts);
                DataTable dataTable = dataBaseWork.OutputQuery(sqlQueryFourth);
                OutputInTableSettingTwo(dataTable);
            }
            else
            {
                string sqlQueryFourth = sqlQueries.SqlComOutputAnswersWithoudOtch
                    (NameWorkCreateTextBox.Texts,
                    FamWorkCreateTextBox.Texts);
                DataTable dataTable = dataBaseWork.OutputQuery(sqlQueryFourth);
                OutputInTableSettingTwo(dataTable);
            }
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
        /// <summary>
        /// Метод, обновляющий данные в DataGridViewAnswer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            Hide();
                        }
                    }
                    else
                    {
                        AnswerToUserApplicationForm answerForm = new AnswerToUserApplicationForm();
                        answerForm.Show();
                        UserApplicationInfoForWorkerForm userForm = new UserApplicationInfoForWorkerForm();
                        userForm.Show();
                        Hide();
                    }
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно создать ответ на не выделенное обращение!", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region [Метод, позволяющий сформировать excel рапорт]
        /// <summary>
        /// Метод, позволяющий сформировать excel рапорт
        /// </summary>
        private void GenerateExcelRaport(DateTime fromDate, DateTime toDate)
        {
            FillStrings();
            DialogResult result = MessageBox.Show
                ($"Вы уверены что хотите создать отчёт от " +
                $"{fromDate:dd-MM-yyyy} до {toDate:dd-MM-yyyy}?",
                "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                object missingValue = Type.Missing;
                Excel.Application IApplication = new Excel.Application();
                Excel.Workbook IWorkbook = IApplication.Workbooks.Add(missingValue);
                Excel.Worksheet IWorksheet = IWorkbook.Worksheets.get_Item(1);
                // Заголовок отчета
                string employeeName = $"{SurnameWorkerString} {NameWorkerString} {PatrWorkerString}";
                IWorksheet.Cells[1, 1].Font.Size = 14;
                IWorksheet.Cells[1, 1].Font.Bold = true;
                IWorksheet.get_Range("A1", "F1").Merge();
                IWorksheet.get_Range("A1", "F1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                IWorksheet.Cells[1, 1] = $"Отчет о проделанной работе сотрудника {employeeName}";
                // Заголовки столбцов
                int columnIndex = 1;
                for (int i = 0; i < CompleteApplicationDGW.Columns.Count; i++)
                {
                    if (CompleteApplicationDGW.Columns[i].HeaderText == "Фамилия" ||
                        CompleteApplicationDGW.Columns[i].HeaderText == "Имя" ||
                        CompleteApplicationDGW.Columns[i].HeaderText == "Отчество")
                        continue;
                    IWorksheet.Cells[4, columnIndex] = CompleteApplicationDGW.Columns[i].HeaderText;
                    IWorksheet.Cells[4, columnIndex].Font.Bold = true;
                    IWorksheet.Cells[4, columnIndex].Interior.Color = Color.FromArgb(201, 235, 200);
                    IWorksheet.Cells[4, columnIndex].Borders.Color = Color.Black;
                    columnIndex++;
                }
                Dictionary<string, int> employeeTasksCount = new Dictionary<string, int>();
                Dictionary<string, int> statusCounts = new Dictionary<string, int>()
                {
                    { "Дополнено", 0 },
                    { "Завершено", 0 },
                    { "Ожидание доп. информации", 0 }
                };
                // Данные таблицы
                for (int j = 0; j < CompleteApplicationDGW.Rows.Count; j++)
                {
                    string currentEmployeeName = Convert.ToString
                        (CompleteApplicationDGW.Rows[j].Cells["User_Name"].Value);
                    string currentStatus = Convert.ToString
                        (CompleteApplicationDGW.Rows[j].Cells["Status_Name"].Value);
                    if (!employeeTasksCount.ContainsKey(currentEmployeeName))
                    {
                        employeeTasksCount[currentEmployeeName] = 1;
                    }
                    else
                    {
                        employeeTasksCount[currentEmployeeName]++;
                    }
                    if (statusCounts.ContainsKey(currentStatus))
                    {
                        statusCounts[currentStatus]++;
                    }
                    columnIndex = 1;
                    for (int i = 0; i < CompleteApplicationDGW.Columns.Count; i++)
                    {
                        if (CompleteApplicationDGW.Columns[i].HeaderText == "Фамилия" ||
                        CompleteApplicationDGW.Columns[i].HeaderText == "Имя" ||
                        CompleteApplicationDGW.Columns[i].HeaderText == "Отчество")
                            continue;
                        IWorksheet.Cells[j + 5, columnIndex] = Convert.ToString
                        (CompleteApplicationDGW.Rows[j].Cells[i].Value);
                        IWorksheet.Cells[j + 5, columnIndex].Interior.Color = Color.FromArgb(218, 237, 255);
                        IWorksheet.Cells[j + 5, columnIndex].Borders.Color = Color.Black;
                        columnIndex++;
                    }
                }
                IWorksheet.Columns.AutoFit();
                // Вывод статистики по сотрудникам и статусам
                int summaryRow = CompleteApplicationDGW.Rows.Count + 6;
                IWorksheet.Cells[summaryRow, 1] = "Количество обращений по статусам";
                IWorksheet.Cells[summaryRow, 1].Font.Bold = true;
                IWorksheet.Cells[summaryRow, 1].Interior.Color = Color.FromArgb(201, 235, 200);
                IWorksheet.get_Range("A" + summaryRow, "B" + summaryRow).Merge();
                IWorksheet.get_Range("A" + summaryRow, "B" + summaryRow).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                IWorksheet.get_Range("A" + summaryRow, "B" + summaryRow).Borders.Color = Color.Black;
                int statusRow = summaryRow + 1;
                foreach (var status in statusCounts)
                {
                    IWorksheet.Cells[statusRow, 1] = $"{status.Key}: {status.Value}";
                    IWorksheet.Cells[statusRow, 1].Interior.Color = Color.FromArgb(218, 237, 255);
                    IWorksheet.Cells[statusRow, 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    IWorksheet.Cells[statusRow, 1].Borders.Color = Color.Black;
                    IWorksheet.Cells[statusRow, 2].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    IWorksheet.Cells[statusRow, 2].Borders.Color = Color.Black;
                    IWorksheet.get_Range("A" + statusRow, "B" + statusRow).Merge();
                    statusRow++;
                }
                // Добавление диаграммы
                Excel.ChartObjects chartObjects = (Excel.ChartObjects)IWorksheet.ChartObjects(Type.Missing);
                Excel.ChartObject chartObject = chartObjects.Add(480, 5, 370, 300); // Изменение размеров диаграммы
                Excel.Chart chart = chartObject.Chart;
                // Add data series
                Excel.SeriesCollection seriesCollection = (Excel.SeriesCollection)chart.SeriesCollection(Type.Missing);
                Excel.Series series = seriesCollection.NewSeries();
                series.XValues = new string[] { "Дополнено", "Завершено", "Ожидание доп. информации" };
                series.Values = new int[] { statusCounts["Дополнено"], statusCounts["Завершено"], statusCounts["Ожидание доп. информации"] };
                series.Name = "Завершенные обращения";
                series.ChartType = Excel.XlChartType.xlColumnClustered;
                chart.HasTitle = true;
                chart.ChartTitle.Text = $"Обращения находящиеся в работе " +
                    $"с {fromDate:dd.MM.yyyy} по {toDate:dd.MM.yyyy}";
                chart.HasLegend = false;
                // Назначение цветов для статусов
                Excel.SeriesCollection seriesCollectionSecond = (Excel.SeriesCollection)chart.SeriesCollection(Type.Missing);
                Excel.Series seriesSecond = seriesCollection.Item(1);
                // Отображение значений на столбцах
                series.HasDataLabels = true;
                Excel.DataLabels dataLabels = series.DataLabels(Type.Missing);
                dataLabels.Position = Excel.XlDataLabelPosition.xlLabelPositionInsideEnd;
                dataLabels.Font.Size = 10;
                dataLabels.Font.Bold = true;
                for (int i = 1; i <= series.Points().Count; i++)
                {
                    Excel.Point point = series.Points(i);
                    switch (i)
                    {
                        case 1:
                            point.Interior.Color = Color.FromArgb(255, 99, 71); // Дополнено - красный
                            break;
                        case 2:
                            point.Interior.Color = Color.FromArgb(50, 205, 50); // Завершено - зеленый
                            break;
                        case 3:
                            point.Interior.Color = Color.FromArgb(255, 215, 0); // Ожидание доп. информации - желтый
                            break;
                    }
                }

                // Подпись и дата
                int lastRow = statusRow + 1;
                IWorksheet.Cells[lastRow, 1].Font.Bold = true;
                IWorksheet.Cells[lastRow, 1] = $"Дата: {DateTime.Now:dd-MM-yyyy}";
                IWorksheet.Cells[lastRow, 3] = "Подпись руководителя отдела:_____________";
                IWorksheet.Cells[lastRow, 3].Font.Bold = true; // Выделение жирным
                IWorksheet.Cells[lastRow + 1, 3] = "М.П.";
                IWorksheet.Cells[lastRow + 1, 3].Font.Bold = true; // Выделение жирным
                string excelFileName = $"Отчет о завершённых обращениях " +
                    $"сотрудника {employeeName} за период от " +
                    $"{fromDate:dd.MM.yyyy} до {toDate:dd.MM.yyyy}.xlsx";
                string filePath = FilePathTextBox.Texts;
                if (string.IsNullOrWhiteSpace(filePath))
                {
                    MessageBox.Show("Путь сохранения не определен!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    excelFileName = Path.Combine(filePath, excelFileName);
                    IWorkbook.SaveAs(excelFileName);
                    MessageBox.Show("Отчёт успешно сформирован!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IWorkbook.Close(true, missingValue, missingValue);
                    IApplication.Quit();
                }
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
            isButtonRaportToggled = false;
        }
        #endregion
        #region [Метод, показывающий/скрывающий видимость пароля]
        /// <summary>
        /// Метод, показывающий/скрывающий видимость пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        #region [Метод, устанавливающий в дату "ОТ" первое число месяца]
        /// <summary>
        /// Метод, устанавливающий в дату "ОТ" первое число месяца
        /// </summary>
        private void SetFirstDayOfMonth()
        {
            DateTime now = DateTime.Now;
            DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
            FirstDateToRaportDTP.Value = firstDayOfMonth;
        }
        #endregion
        #region [Метод, выводящий значения из sql-запроса в CompleteApplicationDGW с отбором дат]
        /// <summary>
        /// Метод, выводящий значения из sql-запроса в CompleteApplicationDGW с отбором дат
        /// </summary>
        public void LoadDataInDataGridViewAnswerWithDate()
        {
            if (PatrWorkCreateTextBox.Texts != string.Empty)
            {
                string sqlQuery = sqlQueries.SqlComOutputAnswerWithDateTime
                    (NameWorkCreateTextBox.Texts,
                    FamWorkCreateTextBox.Texts,
                    PatrWorkCreateTextBox.Texts,
                    FirstDateToRaportDTP.Value.Date.ToString("yyyy-MM-dd"),
                    SecondDateToRaportDTP.Value.Date.ToString("yyyy-MM-dd"));
                DataTable dataTable = dataBaseWork.OutputQuery(sqlQuery);
                MessageBox.Show("Обращения в работе были отсортированы. " +
                    "Для формирования финального отчёта, пожалуйста, " +
                    "нажмите на кнопку формирования ещё раз.", 
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OutputInTableSettingTwo(dataTable);
            }
            else
            {
                string sqlQuery = sqlQueries.SqlComOutputAnswerWithDateTimeWithoutOtch
                    (NameWorkCreateTextBox.Texts,
                    FamWorkCreateTextBox.Texts,
                    FirstDateToRaportDTP.Value.Date.ToString("yyyy-MM-dd"),
                    SecondDateToRaportDTP.Value.Date.ToString("yyyy-MM-dd"));
                DataTable dataTable = dataBaseWork.OutputQuery(sqlQuery);
                MessageBox.Show("Обращения в работе были отсортированы. " +
                    "Для формирования финального отчёта, пожалуйста, " +
                    "нажмите на кнопку формирования ещё раз.",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OutputInTableSettingTwo(dataTable);
            }
        }
        #endregion
    }
}