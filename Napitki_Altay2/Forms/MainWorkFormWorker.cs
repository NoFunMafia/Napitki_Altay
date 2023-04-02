#region [using's]
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class MainWorkFormWorker : Form
    {
        #region [Подключение к БД, инициализация переменных string]
        readonly DataBaseWork dataBaseCon = new DataBaseWork();
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
        #region [Загрузка формы]
        private void MainWorkFormWorker_Load(object sender, EventArgs e)
        {
            try
            {
                bool successLoad;
                // Передача значения Пароля из формы AuthForm
                PassWorkCreaUpdaTextBox.Texts = AuthForm.PasswordString;
                string sqlComUserFIO = $"select * from Info_About_User " +
                    $"join Authentication_ on Authentication_.FK_Info_User " +
                    $"= Info_About_User.ID_Info_User " +
                    $"where Authentication_.Login_User = " +
                    $"'{AuthForm.LoginString}'";
                SqlCommand check = Check(sqlComUserFIO);
                dataBaseCon.OpenConnection();
                using (var datareader = check.ExecuteReader())
                {
                    successLoad = datareader.Read();
                    {
                        CheckDataReaderRowsInfo(datareader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                dataBaseCon.CloseConnection();
            }
            LoadDataInDWG();
            LoadDataInDWGComplete();
        }
        #endregion
        #region [Метод проверки наличия у пользователя заполненного ФИО в БД]
        /// <summary>
        /// Метод проверки наличия у пользователя заполненного ФИО в БД
        /// </summary>
        /// <param name="datareader"></param>
        private void CheckDataReaderRowsInfo(SqlDataReader datareader)
        {
            if (datareader.HasRows)
            {
                FamWorkCreateTextBox.Texts =
                    datareader.GetValue(1).ToString();
                CreateUserFIOButton.Enabled = false;
                ((Control)this.AnswerToApplicationPage).Enabled = true;
            }
            else
            {
                FamWorkCreateTextBox.Texts = "";
                ((Control)this.AnswerToApplicationPage).Enabled = false;
                InfoAnswerLabel.Visible = true;
            }
            if (datareader.HasRows)
            {
                NameWorkCreateTextBox.Texts =
                    datareader.GetValue(2).ToString();
                CreateUserFIOButton.Enabled = false;
                ((Control)this.AnswerToApplicationPage).Enabled = true;
            }
            else
            {
                NameWorkCreateTextBox.Texts = "";
                ((Control)this.AnswerToApplicationPage).Enabled = false;
                InfoAnswerLabel.Visible = true;
            }
            if (datareader.HasRows)
            {
                PatrWorkCreateTextBox.Texts =
                    datareader.GetValue(3).ToString();
                CreateUserFIOButton.Enabled = false;
                ((Control)this.AnswerToApplicationPage).Enabled = true;
            }
            else
            {
                PatrWorkCreateTextBox.Texts = "";
                ((Control)this.AnswerToApplicationPage).Enabled = false;
                InfoAnswerLabel.Visible = true;
            }
        }
        #endregion
        #region [Проверка входящего запроса в БД]
        /// <summary>
        /// Проверка работы входящего запроса в базу данных
        /// </summary>
        /// <param name="command">Запрос в базу данных</param>
        /// <returns></returns>
        private SqlCommand Check(string command)
        {
            return new SqlCommand(command, dataBaseCon.GetConnection());
        }
        #endregion
        #region [Создание ФИО сотрудника]
        private void CreateUserFIOButton_Click(object sender, EventArgs e)
        {
            bool success;
            try
            {
                if (FamWorkCreateTextBox.Texts == ""
                || NameWorkCreateTextBox.Texts == ""
                || PatrWorkCreateTextBox.Texts == "")
                    MessageBox.Show("Поля данных не заполнены до конца!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                {
                    if (CheckFIOUserInDB())
                        return;
                    string sqlComFIO = "insert into Info_About_User" +
                        "(User_Surname, User_Name, User_Patronymic) " +
                        "values ('"
                        + FamWorkCreateTextBox.Texts
                        + "','"
                        + NameWorkCreateTextBox.Texts
                        + "','"
                        + PatrWorkCreateTextBox.Texts
                        + "')";
                    string sqlComFIO2 = $"update Authentication_ " +
                        $"set FK_Info_User = Info_About_User.ID_Info_User " +
                        $"from Info_About_User where " +
                        $"Info_About_User.User_Surname = " +
                        $"'{FamWorkCreateTextBox.Texts}' " +
                        $"and Info_About_User.User_Name = " +
                        $"'{NameWorkCreateTextBox.Texts}' " +
                        $"and Info_About_User.User_Patronymic = " +
                        $"'{PatrWorkCreateTextBox.Texts}' " +
                        $"and Authentication_.Login_User = " +
                        $"'{AuthForm.LoginString}'";
                    SqlCommand check = Check(sqlComFIO);
                    SqlCommand check2 = Check(sqlComFIO2);
                    dataBaseCon.OpenConnection();
                    using (var datareader = check.ExecuteReader())
                    {
                        success = datareader.Read();
                        MessageBox.Show
                            ("Пользователь успешно добавлен!",
                        "Информация", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        CreateUserFIOButton.Enabled = false;
                    }
                    using (var datareader = check2.ExecuteReader())
                    {
                        success = datareader.Read();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                dataBaseCon.CloseConnection();
            }
        }
        #endregion
        #region [Метод проверки занятости ФИО в БД]
        /// <summary>
        /// Метод проверки занятости ФИО в БД
        /// </summary>
        /// <returns>True - занят, false - свободен</returns>
        public Boolean CheckFIOUserInDB()
        {
            DataBaseWork dataBaseCon = new DataBaseWork();
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand
                ("select * from Info_About_User where User_Surname=@usSur " +
                "and User_Name=@usName and User_Patronymic=@usPat",
                dataBaseCon.GetConnection());
            command.Parameters.Add
                ("@usSur", SqlDbType.VarChar).Value
                = FamWorkCreateTextBox.Texts;
            command.Parameters.Add
                ("@usName", SqlDbType.VarChar).Value
                = NameWorkCreateTextBox.Texts;
            command.Parameters.Add
                ("@usPat", SqlDbType.VarChar).Value
                = PatrWorkCreateTextBox.Texts;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Данное ФИО уже зарегистрировано " +
                    "в системе, используйте другое!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return true;
            }
            else
                return false;
        }
        #endregion
        #region [Вывод данных в CompleteAnswerDGW]
        public void LoadDataInDWGComplete()
        {
            try
            {
                dataBaseCon.OpenConnection();
                SqlDataAdapter dataAdapter = new SqlDataAdapter
                    ("select FK_ID_Application, " +
                    "User_Surname, User_Name, " +
                    "User_Patronymic, " +
                    "Date_Of_Answer " +
                    "from Ready_Application " +
                    "join Info_About_User on " +
                    "Ready_Application.FK_Info_User " +
                    "= Info_About_User.ID_Info_User",
                    dataBaseCon.GetConnection());
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                OutputInTableSettingTwo(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                dataBaseCon.CloseConnection();
            }
        }
        #endregion
        #region [Вывод данных в DataGridViewApplication]
        public void LoadDataInDWG()
        {
            try
            {
                dataBaseCon.OpenConnection();
                SqlDataAdapter dataAdapter = new SqlDataAdapter
                    ("select Id_Application, " +
                    "Applicant_Company, User_Surname, " +
                    "User_Name, " +
                    "User_Patronymic, " +
                    "Status_Name " +
                    "from Application_To_Company" +
                    " join Info_About_User on " +
                    "Application_To_Company.FK_Info_User = " +
                    "Info_About_User.ID_Info_User join " +
                    "Status_Application on " +
                    "Application_To_Company.FK_Status_Application" +
                    " = Status_Application.ID_Status full join " +
                    "Application_Document_From_User on " +
                    "Application_To_Company." +
                    "FK_Application_Document_From_User" +
                    " = Application_Document_From_User." +
                    "ID_Document_From_User " +
                    "where Application_To_Company." +
                    "FK_Status_Application " +
                    "= '1' or " +
                    "Application_To_Company.FK_Status_Application = '2'",
                    dataBaseCon.GetConnection());
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                OutputInTableSetting(dataTable);
                SurnameWorkerString = FamWorkCreateTextBox.Texts;
                NameWorkerString = NameWorkCreateTextBox.Texts;
                PatrWorkerString = PatrWorkCreateTextBox.Texts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                dataBaseCon.CloseConnection();
            }
        }
        #endregion
        #region [Настройки вывода информации в DataGridViewAnswer]
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
        #region [Настройки вывода информации в CompleteApplicationDGW]
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
        #region [Обновление данных в DataGridViewAnswer]
        private void UpdateAnswerInDGW_Click(object sender, EventArgs e)
        {
            LoadDataInDWG();
        }
        #endregion
        #region [Ответ на обращение]
        private void AnswerToApplicationButton_Click(object sender, EventArgs e)
        {
            SelectedRowID = DataGridViewAnswer.CurrentRow.
                Cells[0].Value.ToString();
            if (DataGridViewAnswer.
                CurrentRow.Cells[5]
                .Value.ToString() == "На рассмотрении")
            {
                try
                {
                    bool successLoad;
                    string sqlComUserFIO = $"update Application_To_Company" +
                        $" set FK_Status_Application = " +
                        $"'2' where ID_Application = '{SelectedRowID}'";
                    SqlCommand check = Check(sqlComUserFIO);
                    dataBaseCon.OpenConnection();
                    using (var datareader = check.ExecuteReader())
                    {
                        successLoad = datareader.Read();
                    }
                    LoadDataInDWG();
                    AnswerToUserApplicationForm
                        answerToUserApplicationForm
                        = new AnswerToUserApplicationForm();
                    answerToUserApplicationForm.Show();
                    UserApplicationInfoForWorkerForm
                        userApplicationInfoForWorkerForm
                        = new UserApplicationInfoForWorkerForm();
                    userApplicationInfoForWorkerForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    dataBaseCon.CloseConnection();
                }
            }
            else
            {
                AnswerToUserApplicationForm
                answerToUserApplicationForm
                = new AnswerToUserApplicationForm();
                answerToUserApplicationForm.Show();
                UserApplicationInfoForWorkerForm
                    userApplicationInfoForWorkerForm
                    = new UserApplicationInfoForWorkerForm();
                userApplicationInfoForWorkerForm.Show();
            }
        }
        #endregion
        #region [Создание Excel документа с таблицей завершённых обращений]
        private void GenerateRaportButton_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            for(int i = 0; i < CompleteApplicationDGW.Columns.Count; i++)
            {
                xlWorkSheet.Cells[3, i + 1] 
                    = CompleteApplicationDGW.Columns[i].HeaderText;
            }
            for(int j = 0; 
                j < CompleteApplicationDGW.Rows.Count; j++)
            {
                for(int i = 0; 
                    i < CompleteApplicationDGW.Columns.Count; i++)
                {
                    xlWorkSheet.Cells[j + 4, i + 1]
                        = CompleteApplicationDGW.
                        Rows[j].Cells[i].Value.ToString();
                }
            }
            xlWorkSheet.UsedRange.Borders.Color = Color.Black;
            xlWorkSheet.Cells[1, 3].Font.Size = 20;
            xlWorkSheet.Cells[3, 7].Font.Size = 16;
            xlWorkSheet.Cells[6, 7].Font.Size = 16;
            xlWorkSheet.Cells[2, 1].Font.Size = 14;
            xlWorkSheet.Cells[1, 3] = "Отчёт о проделанной работе";
            xlWorkSheet.Cells[3, 7] = "Подпись главы отдела_____________";
            xlWorkSheet.Cells[6, 7] = "М.П";
            xlWorkSheet.Cells[2, 1] = "Все завершенные обращения сотрудников";
            xlWorkSheet.Columns.AutoFit();
            string excelfilename = " Отчёт о закрытых обращениях.xlsx";
            string destfilename = DateTime.Now.ToString
                        ("dd-MM-yyyy", CultureInfo.InvariantCulture)
                        + excelfilename;
            string pathexp = FilePathTextBox.Texts;
            if (FilePathTextBox.Texts == "")
            {
                MessageBox.Show("Путь сохранения не определен!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                destfilename = Path.Combine(pathexp, destfilename);
                xlWorkBook.SaveAs(destfilename);
                MessageBox.Show("Отчёт успешно сформирован!",
                            "Информация",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
            }
        }
        #endregion
        #region [Обновление данных в DGW]
        private void UpdateDataDGWAnswer_Click(object sender, EventArgs e)
        {
            LoadDataInDWGComplete();
        }
        #endregion
        #region [Выбор пути для сохранения отчёта]
        private void FilePathChooseButton_Click(object sender, EventArgs e)
        {
            if (FolderPathBrowserDialog.ShowDialog() == DialogResult.OK)
                FilePathTextBox.Texts = FolderPathBrowserDialog.SelectedPath;
        }

        #endregion
        private void MainWorkFormWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}