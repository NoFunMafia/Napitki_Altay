#region [using's]
using Napitki_Altay2.Classes;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class MainWorkFormAdmin : Form
    {
        #region [Подключение классов, объявление переменных]
        // Класс запросов в БД
        readonly SqlQueries sqlQueries = new SqlQueries();
        // Использование класса работы с БД
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        public static string selectedRowId;
        private bool isButtonRaportToggled = false;
        #endregion
        public MainWorkFormAdmin()
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
        private void MainWorkFormAdmin_Load(object sender, EventArgs e)
        {
            LoadDataGridViewUsers();
            LoadDataGridViewApplication();
        }
        #endregion
        #region [Событие нажатия на кнопку CreateUserButton]
        /// <summary>
        /// Событие нажатия на кнопку CreateUserButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }
        #endregion
        #region [Событие, при котором меняются размеры элементов при развороте приложения]
        /// <summary>
        /// Событие, при котором меняются 
        /// размеры элементов при развороте приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWorkFormAdmin_Resize(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Maximized)
            //{
            //    MainWorkAdminTabControl.Size = new Size(1532, 829);
            //    DataGridViewUsers.Size = new Size(1520, 750);
            //    DataGridViewApplication.Size = new Size(1520, 750);
            //}
            //else
            //{
            //    MainWorkAdminTabControl.Size = new Size(764, 448);
            //    DataGridViewUsers.Size = new Size(754, 372);
            //    DataGridViewApplication.Size = new Size(754, 340);
            //}
        }
        #endregion
        #region [Событие закрытия приложения при закрытии формы]
        /// <summary>
        /// Закрытие приложения при закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWorkFormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region [Событие нажатия на кнопку UpdateUserButton]
        /// <summary>
        /// Событие нажатия на кнопку UpdateUserButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateUserDataButton_Click(object sender, EventArgs e)
        {
            LoadDataGridViewUsers();
        }
        #endregion
        #region [Событие нажатия на кнопку DeleteUserButton]
        /// <summary>
        /// Событие нажатия на кнопку DeleteUserButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridViewUsers.RowCount != 0)
                {
                    selectedRowId = DataGridViewUsers.CurrentRow.Cells[0].Value.ToString();
                    UpdateUserForm updateUserForm = new UpdateUserForm();
                    updateUserForm.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выделили пользователя для изменения его данных!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region [Событие нажатия на кнопку UpdateApplicationButton]
        /// <summary>
        /// Событие нажатия на кнопку UpdateApplicationButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateApplicationButton_Click(object sender, EventArgs e)
        {
            LoadDataGridViewApplication();
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
                LoadDataInDataGridViewAnswersWithDate();
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
        #region [Метод, отправляющий sql-запрос на удаление пользователя]
        /// <summary>
        /// Метод, отправляющий sql-запрос на удаление пользователя
        /// </summary>
        /// <param name="rowToDelete">Строка, содержащая данные из DataGridView</param>
        private void SendQueryToDeleteUser(string rowToDelete)
        {
            string sqlQueryThree = sqlQueries.SqlComDeleteUser(rowToDelete);
            bool checkDelete = dataBaseWork.WithoutOutputQuery(sqlQueryThree);
            if (checkDelete)
                MessageBox.Show("Пользователь успешно удален!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region [Метод, использующийся для вывода данных в таблицу DataGridViewUsers]
        /// <summary>
        /// Метод, использующийся для вывода данных в таблицу DataGridViewUsers
        /// </summary>
        private void LoadDataGridViewUsers()
        {
            string sqlQuery = sqlQueries.sqlComOutputUsers;
            DataTable dataTable = dataBaseWork.OutputQuery(sqlQuery);
            OutputSettingDataGridViewUsers(dataTable);
        }
        #endregion
        #region [Метод, настраивающий отображения выводимых данных в таблицу DataGridViewUsers]
        /// <summary>
        /// Метод, настроивающий отображения выводимых 
        /// данных в таблицу DataGridViewUsers
        /// </summary>
        /// <param name="dataTable">Передаваемая таблица с данными</param>
        private void OutputSettingDataGridViewUsers(DataTable dataTable)
        {
            DataGridViewUsers.DataSource = dataTable;
            DataGridViewUsers.Columns[0].HeaderText = "ID пользователя";
            DataGridViewUsers.Columns[0].Width = 60;
            DataGridViewUsers.Columns[1].HeaderText = "Логин";
            DataGridViewUsers.Columns[1].Width = 140;
            DataGridViewUsers.Columns[2].HeaderText = "Пароль";
            DataGridViewUsers.Columns[2].Width = 120;
            DataGridViewUsers.Columns[3].HeaderText = "Фамилия";
            DataGridViewUsers.Columns[3].Width = 130;
            DataGridViewUsers.Columns[4].HeaderText = "Имя";
            DataGridViewUsers.Columns[4].Width = 130;
            DataGridViewUsers.Columns[5].HeaderText = "Отчество";
            DataGridViewUsers.Columns[5].Width = 116;
            DataGridViewUsers.Columns[6].HeaderText = "Роль";
            DataGridViewUsers.Columns[6].Width = 116;
            DataGridViewUsers.Columns[7].HeaderText = "Email";
            DataGridViewUsers.Columns[7].Width = 116;
        }
        #endregion
        #region [Метод, использующийся для вывода данных в таблицу DataGridViewApplication]
        /// <summary>
        /// Метод, использующийся для вывода данных в таблицу DataGridViewApplication
        /// </summary>
        private void LoadDataGridViewApplication()
        {
            string sqlQuery = sqlQueries.sqlComOutputCompleteApplication;
            DataTable dataTable = dataBaseWork.OutputQuery(sqlQuery);
            OutputSettingDataGridViewApplication(dataTable);
        }
        #endregion
        #region [Метод, настраивающий отображения выводимых данных в таблицу DataGridViewApplication]
        /// <summary>
        /// Метод, настроивающий отображения выводимых 
        /// данных в таблицу DataGridViewApplication
        /// </summary>
        /// <param name="dataTable">Передаваемая таблица с данными</param>
        private void OutputSettingDataGridViewApplication(DataTable dataTable)
        {
            DataGridViewApplication.DataSource = dataTable;
            DataGridViewApplication.Columns[0].HeaderText =
                "Номер обращения";
            DataGridViewApplication.Columns[0].Width = 80;
            DataGridViewApplication.Columns[1].HeaderText =
                "Фамилия";
            DataGridViewApplication.Columns[1].Width = 100;
            DataGridViewApplication.Columns[2].HeaderText =
                "Имя";
            DataGridViewApplication.Columns[2].Width = 100;
            DataGridViewApplication.Columns[3].HeaderText =
                "Отчество";
            DataGridViewApplication.Columns[3].Width = 100;
            DataGridViewApplication.Columns[4].HeaderText =
                "Время ответа сотрудника";
            DataGridViewApplication.Columns[4].Width = 130;
            DataGridViewApplication.Columns[5].HeaderText =
                "Статус обращения";
            DataGridViewApplication.Columns[5].Width = 174;
        }
        #endregion
        #region [Метод, получающий русское название месяцев для выводного отчёта]
        private string GetRussianMonthName(int month)
        {
            string[] monthNames = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            return monthNames[month - 1];
        }
        #endregion
        #region [Метод, позволяющий сформировать excel рапорт]
        /// <summary>
        /// Метод, позволяющий сформировать excel рапорт
        /// </summary>
        private void GenerateExcelRaport(DateTime fromDate, DateTime toDate)
        {
            DialogResult result = MessageBox.Show
                ($"Вы уверены что хотите создать отчёт от " +
                $"{fromDate:dd-MM-yyyy} до {toDate:dd-MM-yyyy}?",
                "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                object missingValue = Type.Missing;
                Excel.Application IApplication = new Excel.Application();
                Excel.Workbook IWorkbook = IApplication.Workbooks.Add(missingValue);

                // Заголовок отчета и столбцов
                void CreateHeader(Excel.Worksheet IWorksheet, string employeeName)
                {
                    IWorksheet.Cells[1, 1].Font.Size = 14;
                    IWorksheet.Cells[1, 1].Font.Bold = true;
                    IWorksheet.Cells[1, 1] = $"Отчет о проделанной работе сотрудника: {employeeName}";
                    IWorksheet.Range["A1", "F1"].Merge();
                    IWorksheet.Range["A1", "F1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                    int columnIndex = 1;
                    for (int i = 0; i < DataGridViewApplication.Columns.Count; i++)
                    {
                        if (DataGridViewApplication.Columns[i].HeaderText == "Фамилия" ||
                            DataGridViewApplication.Columns[i].HeaderText == "Имя" ||
                            DataGridViewApplication.Columns[i].HeaderText == "Отчество")
                            continue;
                        IWorksheet.Cells[3, columnIndex] = DataGridViewApplication.Columns[i].HeaderText;
                        IWorksheet.Cells[3, columnIndex].Font.Bold = true;
                        IWorksheet.Cells[3, columnIndex].Interior.Color = Color.FromArgb(201, 235, 200);
                        IWorksheet.Cells[3, columnIndex].Borders.Color = Color.Black;
                        columnIndex++;
                    }
                }

                // Создание отдельных листов для каждого сотрудника и заполнение данными
                List<string> createdEmployeeNames = new List<string>();
                int sheetIndex = 1;
                for (int j = 0; j < DataGridViewApplication.Rows.Count; j++)
                {
                    string currentEmployeeFullName = $"{DataGridViewApplication.Rows[j].Cells["User_Surname"].Value}" + $" {DataGridViewApplication.Rows[j].Cells["User_Name"].Value}" +
                        $" {DataGridViewApplication.Rows[j].Cells["User_Patronymic"].Value}";

                    // Если лист для текущего сотрудника уже создан, переходим к следующей итерации цикла
                    if (createdEmployeeNames.Contains(currentEmployeeFullName))
                    {
                        continue;
                    }

                    createdEmployeeNames.Add(currentEmployeeFullName);

                    Excel.Worksheet IWorksheet;
                    if (sheetIndex == 1)
                    {
                        IWorksheet = IWorkbook.Worksheets.get_Item(sheetIndex);
                    }
                    else
                    {
                        IWorksheet = IWorkbook.Worksheets.Add(Type.Missing, IWorkbook.Worksheets[sheetIndex - 1], 1, Excel.XlSheetType.xlWorksheet);
                    }
                    IWorksheet.Name = $"{currentEmployeeFullName}";
                    CreateHeader(IWorksheet, currentEmployeeFullName); // передаем имя сотрудника в функцию CreateHeader

                    // Заполнение таблицы данными
                    int rowIndex = 4;
                    Dictionary<string, int> statusCounts = new Dictionary<string, int>();
                    for (int i = 0; i < DataGridViewApplication.Rows.Count; i++)
                    {
                        if (DataGridViewApplication.Rows[i].Cells["User_Surname"].Value.ToString() == DataGridViewApplication.Rows[j].Cells["User_Surname"].Value.ToString() &&
                            DataGridViewApplication.Rows[i].Cells["User_Name"].Value.ToString() == DataGridViewApplication.Rows[j].Cells["User_Name"].Value.ToString() &&
                            DataGridViewApplication.Rows[i].Cells["User_Patronymic"].Value.ToString() == DataGridViewApplication.Rows[j].Cells["User_Patronymic"].Value.ToString())
                        {
                            int columnIndex = 1;
                            for (int k = 0; k < DataGridViewApplication.Columns.Count; k++)
                            {
                                if (DataGridViewApplication.Columns[k].HeaderText == "Фамилия" ||
                                    DataGridViewApplication.Columns[k].HeaderText == "Имя" ||
                                    DataGridViewApplication.Columns[k].HeaderText == "Отчество")
                                    continue;

                                IWorksheet.Cells[rowIndex, columnIndex] = DataGridViewApplication.Rows[i].Cells[k].Value;
                                columnIndex++;
                            }
                            rowIndex++;

                            string currentStatus = $"{DataGridViewApplication.Rows[i].Cells["Status_Name"].Value}";
                            if (!statusCounts.ContainsKey(currentStatus))
                            {
                                statusCounts[currentStatus] = 0;
                            }
                            statusCounts[currentStatus]++;
                        }
                    }

                    // Применение границ для таблицы данных
                    Excel.Range dataRange = IWorksheet.Range[IWorksheet.Cells[4, 1], IWorksheet.Cells[rowIndex - 1, DataGridViewApplication.Columns.Count - 3]];
                    ApplyBorder(dataRange);

                    // Вставка итоговой таблицы с числом обращений по каждому статусу
                    rowIndex += 2;
                    IWorksheet.Cells[rowIndex, 1] = "Статус";
                    IWorksheet.Cells[rowIndex, 2] = "Количество обращений";
                    IWorksheet.Cells[rowIndex, 1].Font.Bold = true;
                    IWorksheet.Cells[rowIndex, 2].Font.Bold = true;
                    // Обводка ячеек "Статус" и "Количество обращений"
                    Excel.Range headerRange = IWorksheet.Range[IWorksheet.Cells[rowIndex, 1], IWorksheet.Cells[rowIndex, 2]];
                    ApplyBorder(headerRange);
                    // Заполнение цветом ячеек "Статус" и "Количество обращений"
                    headerRange.Interior.Color = Color.FromArgb(201, 235, 200);
                    rowIndex++;
                    // Применение границ для итоговой таблицы
                    Excel.Range summaryRange = IWorksheet.Range[IWorksheet.Cells[rowIndex, 1], IWorksheet.Cells[rowIndex + statusCounts.Count - 1, 2]];
                    ApplyBorder(summaryRange);
                    foreach (var statusCount in statusCounts)
                    {
                        IWorksheet.Cells[rowIndex, 1] = statusCount.Key;
                        IWorksheet.Cells[rowIndex, 2] = statusCount.Value;
                        rowIndex++;
                    }
                    // Создание диаграммы для каждого сотрудника
                    Excel.ChartObjects chartObjects = (Excel.ChartObjects)IWorksheet.ChartObjects(Type.Missing);
                    Excel.ChartObject chartObject = chartObjects.Add(170, 25, 400, 300); // Изменение размеров диаграммы
                    Excel.Chart chart = chartObject.Chart;
                    chart.ChartType = Excel.XlChartType.xlColumnClustered;
                    chart.HasTitle = true;
                    chart.ChartTitle.Text = $"Обращения находящиеся в работе " +
                        $"с {fromDate:dd.MM.yyyy} по {toDate:dd.MM.yyyy}";
                    chart.HasLegend = true;
                    int chartRowIndex = rowIndex - statusCounts.Count;
                    foreach (var statusCount in statusCounts)
                    {
                        Excel.Series series = (Excel.Series)chart.SeriesCollection().NewSeries;
                        series.Name = statusCount.Key;
                        series.Values = IWorksheet.Range[IWorksheet.Cells[chartRowIndex, 2], IWorksheet.Cells[chartRowIndex, 2]];
                        series.XValues = IWorksheet.Range[IWorksheet.Cells[chartRowIndex, 1], IWorksheet.Cells[chartRowIndex, 1]];
                        chartRowIndex++;
                    }
                    IWorksheet.Columns.AutoFit();
                    sheetIndex++;
                }
                // Сохранение файла
                string finalFileName = "Отчет о завершенных обращениях сотрудников за период от " +
                    $"{fromDate:dd.MM.yyyy} до {toDate:dd.MM.yyyy}.xlsx";
                string filePath = FilePathTextBox.Texts;
                if (string.IsNullOrWhiteSpace(filePath))
                {
                    MessageBox.Show("Путь сохранения не определен!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        finalFileName = Path.Combine(filePath, finalFileName);
                        IWorkbook.SaveAs(finalFileName);
                        MessageBox.Show("Отчёт успешно сформирован!", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IWorkbook.Close(true, missingValue, missingValue);
                        IApplication.Quit();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
        #endregion
        private void ApplyBorder(Excel.Range range)
        {
            Excel.Borders borders = range.Borders;
            borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
        }

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
        private void LoadDataInDataGridViewAnswersWithDate()
        {
            string sqlQuery = sqlQueries.SqlComOutputAnswerAllWorkerWithDateTime
                (FirstDateToRaportDTP.Value.Date.ToString("yyyy-MM-dd"),
                SecondDateToRaportDTP.Value.Date.ToString("yyyy-MM-dd"));
            DataTable dataTable = dataBaseWork.OutputQuery(sqlQuery);
            MessageBox.Show("Обращения в работе были отсортированы. " +
                   "Для формирования финального отчёта, пожалуйста, " +
                   "нажмите на кнопку формирования ещё раз.",
                   "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OutputSettingDataGridViewApplication(dataTable);
        }
    }
}