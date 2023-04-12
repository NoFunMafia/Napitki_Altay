#region [using's]
using Napitki_Altay2.Classes;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
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
        #endregion
        public MainWorkFormAdmin()
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
            if (WindowState == FormWindowState.Maximized)
            {
                MainWorkAdminTabControl.Size = new Size(1532, 829);
                DataGridViewUsers.Size = new Size(1520, 750);
                DataGridViewApplication.Size = new Size(1520, 750);
            }
            else
            {
                MainWorkAdminTabControl.Size = new Size(764, 448);
                DataGridViewUsers.Size = new Size(754, 372);
                DataGridViewApplication.Size = new Size(754, 340);
            }
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
        private void UpdateUserButton_Click(object sender, EventArgs e)
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
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            ReceiveRowAndList(out string rowToDelete, out List<string[]> listSearch);
            if (SendQueryFromList(listSearch))
            {
                SendQueryToDeleteUser(rowToDelete);
                LoadDataGridViewUsers();
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
        #region [Событие нажатия на кнопку FilePathChooseButton]
        /// <summary>
        /// Событие нажатия на кнопку FilePathChooseButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilePathChooseButton_Click(object sender, EventArgs e)
        {
            if (FolderPathBrowserDialog.ShowDialog() == DialogResult.OK)
                FilePathTextBox.Texts = FolderPathBrowserDialog.SelectedPath;
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
            GenerateExcelRaport();
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
        #region [Метод, создающий запрос в БД из List списка]
        /// <summary>
        /// Метод, создающий запрос в БД из List списка
        /// </summary>
        /// <param name="listSearch">List список для формирования sql-запроса</param>
        private bool SendQueryFromList(List<string[]> listSearch)
        {
            if (listSearch != null)
            {
                StringBuilder sqlQueryBuilder = new StringBuilder();
                foreach (string[] item in listSearch)
                {
                    string name = item[0].ToString();
                    string fam = item[1].ToString();
                    string otch = item[2].ToString();
                    string sqlQueryItem = sqlQueries.SqlComDeleteFio(fam, name, otch);
                    sqlQueryBuilder.AppendLine(sqlQueryItem);
                }
                string sqlQuerySecond = sqlQueryBuilder.ToString();
                bool checkDeleteFio = dataBaseWork.WithoutOutputQuery(sqlQuerySecond);
                if (!checkDeleteFio)
                    return false;
                return true;
            }
            return false;
        }
        #endregion
        #region [Метод, для получения строки из DataGridView и List объекта, содержащего данные из sql-запроса]
        /// <summary>
        /// Метод, для получения строки из DataGridView 
        /// и List объекта, содержащего данные из sql-запроса
        /// </summary>
        /// <param name="rowToDelete"></param>
        /// <param name="listSearch"></param>
        private void ReceiveRowAndList(out string rowToDelete, out List<string[]> listSearch)
        {
            rowToDelete = DataGridViewUsers.CurrentRow.Cells[0].Value.ToString();
            string sqlQuery = sqlQueries.SqlComTakeFio(rowToDelete);
            listSearch = dataBaseWork.GetMultiList(sqlQuery, 3);
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
                "Номер обращения пользователя";
            DataGridViewApplication.Columns[0].Width = 100;
            DataGridViewApplication.Columns[1].HeaderText =
                "Фамилия сотрудника";
            DataGridViewApplication.Columns[1].Width = 150;
            DataGridViewApplication.Columns[2].HeaderText =
                "Имя сотрудника";
            DataGridViewApplication.Columns[2].Width = 150;
            DataGridViewApplication.Columns[3].HeaderText =
                "Отчество сотрудника";
            DataGridViewApplication.Columns[3].Width = 150;
            DataGridViewApplication.Columns[4].HeaderText =
                "Время ответа сотрудника";
            DataGridViewApplication.Columns[4].Width = 148;
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
        private void GenerateExcelRaport()
        {
            object missingValue = Type.Missing;
            Excel.Application IApplication = new Excel.Application();
            Excel.Workbook IWorkbook = IApplication.Workbooks.Add(missingValue);
            Excel.Worksheet IWorksheet = IWorkbook.Worksheets.get_Item(1);
            // Заголовок отчета
            IWorksheet.Cells[1, 1].Font.Size = 20;
            IWorksheet.Cells[1, 1].Font.Bold = true;
            IWorksheet.Cells[1, 1] = $"Отчет о проделанной работе сотрудников";
            IWorksheet.get_Range("A1", "E1").Merge();
            IWorksheet.get_Range("A1", "E1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            // Заголовки столбцов
            int columnIndex = 1;
            for (int i = 0; i < DataGridViewApplication.Columns.Count; i++)
            {
                if (DataGridViewApplication.Columns[i].HeaderText == "User_Surname" ||
                    DataGridViewApplication.Columns[i].HeaderText == "User_Name" ||
                    DataGridViewApplication.Columns[i].HeaderText == "User_Patronymic")
                    continue;
                IWorksheet.Cells[3, columnIndex] = DataGridViewApplication.Columns[i].HeaderText;
                IWorksheet.Cells[3, columnIndex].Font.Bold = true;
                IWorksheet.Cells[3, columnIndex].Interior.Color = Color.FromArgb(201, 235, 200);
                IWorksheet.Cells[3, columnIndex].Borders.Color = Color.Black;
                columnIndex++;
            }
            // Данные таблицы
            Dictionary<string, int> employeeTasksCount = new Dictionary<string, int>();
            for (int j = 0; j < DataGridViewApplication.Rows.Count; j++)
            {
                DateTime taskDate = Convert.ToDateTime
                    (DataGridViewApplication.Rows[j].Cells["Date_Of_Answer"].Value);
                string currentEmployeeFullName = $"{DataGridViewApplication.Rows[j].Cells["User_Surname"].Value}" +
                    $" {DataGridViewApplication.Rows[j].Cells["User_Name"].Value}" +
                    $" {DataGridViewApplication.Rows[j].Cells["User_Patronymic"].Value}";
                if (!employeeTasksCount.ContainsKey(currentEmployeeFullName))
                {
                    employeeTasksCount[currentEmployeeFullName] = 1;
                }
                else
                {
                    employeeTasksCount[currentEmployeeFullName] += 1;
                }
                columnIndex = 1;
                for (int i = 0; i < DataGridViewApplication.Columns.Count; i++)
                {
                    if (DataGridViewApplication.Columns[i].HeaderText == "User_Surname" ||
                        DataGridViewApplication.Columns[i].HeaderText == "User_Name" ||
                        DataGridViewApplication.Columns[i].HeaderText == "User_Patronymic")
                        continue;
                    IWorksheet.Cells[j + 4, columnIndex] = Convert.ToString
                        (DataGridViewApplication.Rows[j].Cells[i].Value);
                    IWorksheet.Cells[j + 4, columnIndex].Interior.Color = Color.FromArgb(218, 237, 255);
                    IWorksheet.Cells[j + 4, columnIndex].Borders.Color = Color.Black;
                    columnIndex++;
                }
            }
            IWorksheet.Columns.AutoFit();
            // Вывод статистики по сотрудникам
            int summaryRow = DataGridViewApplication.Rows.Count + 5;
            IWorksheet.Cells[summaryRow, 1] = "Сотрудник";
            IWorksheet.Cells[summaryRow, 2] = "Количество завершенных обращений";
            IWorksheet.Cells[summaryRow, 1].Font.Bold = true;
            IWorksheet.Cells[summaryRow, 1].Interior.Color = Color.FromArgb(201, 235, 200);
            IWorksheet.Cells[summaryRow, 1].Borders.Color = Color.Black;
            IWorksheet.Cells[summaryRow, 2].Font.Bold = true;
            IWorksheet.Cells[summaryRow, 2].Interior.Color = Color.FromArgb(201, 235, 200);
            IWorksheet.Cells[summaryRow, 2].Borders.Color = Color.Black;
            int employeeRow = summaryRow + 1;
            foreach (var employee in employeeTasksCount)
            {
                IWorksheet.Cells[employeeRow, 1] = employee.Key;
                IWorksheet.Cells[employeeRow, 1].Interior.Color = Color.FromArgb(218, 237, 255);
                IWorksheet.Cells[employeeRow, 1].Borders.Color = Color.Black;
                IWorksheet.Cells[employeeRow, 2] = employee.Value;
                IWorksheet.Cells[employeeRow, 2].Interior.Color = Color.FromArgb(218, 237, 255);
                IWorksheet.Cells[employeeRow, 2].Borders.Color = Color.Black;
                employeeRow++;
            }
            // Добавление диаграммы
            Excel.ChartObjects chartObjects = (Excel.ChartObjects)IWorksheet.ChartObjects(Type.Missing);
            Excel.ChartObject chartObject = chartObjects.Add(400, 60, 400, 300); // Изменение размеров диаграммы
            Excel.Chart chart = chartObject.Chart;
            Excel.Range dataRange = IWorksheet.Range[IWorksheet.Cells[summaryRow + 1, 2], 
                IWorksheet.Cells[employeeRow - 1, 2]];
            chart.SetSourceData(dataRange);
            chart.ChartType = Excel.XlChartType.xlColumnClustered;
            chart.HasTitle = true;
            chart.ChartTitle.Text = $"Завершенные обращения за месяцы";
            chart.HasLegend = false;
            // Изменение подписи горизонтальной оси на ФИО сотрудников
            Excel.Series series = (Excel.Series)chart.SeriesCollection(1);
            series.XValues = IWorksheet.Range[IWorksheet.Cells[summaryRow + 1, 1], 
                IWorksheet.Cells[employeeRow - 1, 1]];
            // Подпись и дата
            int lastRow = employeeRow + 1;
            IWorksheet.Cells[lastRow, 1].Font.Bold = true;
            IWorksheet.Cells[lastRow, 1] = $"Дата: {DateTime.Now.ToString("dd-MM-yyyy")}";
            IWorksheet.Cells[lastRow, 5] = "Подпись главы отдела:_____________";
            IWorksheet.Cells[lastRow, 5].Font.Bold = true; // Выделение жирным
            IWorksheet.Cells[lastRow + 1, 5] = "Место печати ";
            IWorksheet.Cells[lastRow + 1, 5].Font.Bold = true; // Выделение жирным
            // Сохранение файла
            string excelFileName = " Отчет о завершенных обращениях.xlsx";
            string finalFileName = DateTime.Now.ToString
                ("dd-MM-yyyy", CultureInfo.InvariantCulture) + excelFileName;
            string filePath = FilePathTextBox.Texts;
            if (string.IsNullOrWhiteSpace(filePath))
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
    }
}