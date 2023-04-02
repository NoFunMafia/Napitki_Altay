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
            if (string.IsNullOrEmpty(FamWorkCreateTextBox.Texts) ||
                string.IsNullOrEmpty(NameWorkCreateTextBox.Texts) ||
                string.IsNullOrEmpty(PatrWorkCreateTextBox.Texts))
            {
                MessageBox.Show("Поля данных не заполнены до конца!",
                    "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (!CheckFIOUserInDB())
                    return;
                InsertAndUpdateQuery(out bool checkInsertFio,
                    out bool checkUpdateWorkerFio);
                if (checkInsertFio && checkUpdateWorkerFio)
                {
                    MessageBox.Show("Пользователь успешно добавлен!",
                        "Информация", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    CreateUserFIOButton.Enabled = false;
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
            GenerateExcelRaport();
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
                    if (item.Contains(""))
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
                        PatrWorkCreateTextBox.Texts = item.GetValue(3).ToString();
                        CreateUserFIOButton.Enabled = false;
                        ((Control)AnswerToApplicationPage).Enabled = true;
                    }
                }
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
            string sqlQueryFourth = sqlQueries.sqlComOutputAnswers;
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
            string sqlQueryFive = sqlQueries.sqlComOutputApplications;
            DataTable dataTable = dataBaseWork.OutputQuery(sqlQueryFive);
            OutputInTableSetting(dataTable);
            FillStrings();
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
            DataGridViewAnswer.Columns[0].Width = 60;
            DataGridViewAnswer.Columns[1].HeaderText = "Компания заявителя";
            DataGridViewAnswer.Columns[1].Width = 140;
            DataGridViewAnswer.Columns[2].HeaderText = "Фамилия заявителя";
            DataGridViewAnswer.Columns[2].Width = 120;
            DataGridViewAnswer.Columns[3].HeaderText = "Имя заявителя";
            DataGridViewAnswer.Columns[3].Width = 130;
            DataGridViewAnswer.Columns[4].HeaderText = "Отчество заявителя";
            DataGridViewAnswer.Columns[4].Width = 130;
            DataGridViewAnswer.Columns[5].HeaderText = "Статус заявки";
            DataGridViewAnswer.Columns[5].Width = 116;
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
                "Номер обращения пользователя";
            CompleteApplicationDGW.Columns[0].Width = 100;
            CompleteApplicationDGW.Columns[1].HeaderText = 
                "Фамилия сотрудника";
            CompleteApplicationDGW.Columns[1].Width = 150;
            CompleteApplicationDGW.Columns[2].HeaderText = 
                "Имя сотрудника";
            CompleteApplicationDGW.Columns[2].Width = 150;
            CompleteApplicationDGW.Columns[3].HeaderText = 
                "Отчество сотрудника";
            CompleteApplicationDGW.Columns[3].Width = 150;
            CompleteApplicationDGW.Columns[4].HeaderText = 
                "Время ответа сотрудника";
            CompleteApplicationDGW.Columns[4].Width = 148;
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
            SelectedRowID = DataGridViewAnswer.CurrentRow.Cells[0].Value.ToString();
            if (DataGridViewAnswer.CurrentRow.Cells[5].Value.ToString() == "На рассмотрении")
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
            for (int i = 0; i < CompleteApplicationDGW.Columns.Count; i++)
            {
                IWorksheet.Cells[3, i + 1] = CompleteApplicationDGW.Columns[i].HeaderText;
            }
            for (int j = 0; j < CompleteApplicationDGW.Rows.Count; j++)
            {
                for (int i = 0; i < CompleteApplicationDGW.Columns.Count; i++)
                {
                    IWorksheet.Cells[j + 4, i + 1] = Convert.ToString
                        (CompleteApplicationDGW.Rows[j].Cells[i].Value);
                }
            }
            IWorksheet.UsedRange.Borders.Color = Color.Black;
            IWorksheet.Cells[1, 3].Font.Size = 20;
            IWorksheet.Cells[3, 7].Font.Size = 16;
            IWorksheet.Cells[6, 7].Font.Size = 16;
            IWorksheet.Cells[2, 1].Font.Size = 14;
            IWorksheet.Cells[1, 3] = "Отчёт о проделанной работе";
            IWorksheet.Cells[3, 7] = "Подпись главы отдела_____________";
            IWorksheet.Cells[6, 7] = "М.П";
            IWorksheet.Cells[2, 1] = "Все завершенные обращения сотрудников";
            IWorksheet.Columns.AutoFit();
            string excelFileName = " Отчет о завершенных обращениях.xlsx";
            string finalFileName = DateTime.Now.ToString
                ("dd-MM-yyyy", CultureInfo.InvariantCulture) + excelFileName;
            string filePath = FilePathTextBox.Texts;
            if (FilePathTextBox.Texts.IsNullOrWhiteSpace())
                MessageBox.Show("Путь сохранения не определен!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        #region [Метод выбора пути для сохранения отчёта]
        /// <summary>
        /// Метод выбора пути для сохранения отчёта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilePathChooseButton_Click(object sender, EventArgs e)
        {
            if (FolderPathBrowserDialog.ShowDialog() == DialogResult.OK)
                FilePathTextBox.Texts = FolderPathBrowserDialog.SelectedPath;
        }
        #endregion
    }
}