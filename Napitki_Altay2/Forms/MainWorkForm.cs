#region [using's]
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class MainWorkForm : Form
    {
        #region [Подключение класса соединения с БД, объявление string переменных ФИО]
        // Использование класса соединения с БД
        DataBaseCon datebaseCon = new DataBaseCon();
        public static string SurnameUserString;
        public static string NameUserString;
        public static string PatronymicUserString;
        #endregion
        public MainWorkForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Загрузка формы]
        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWorkForm_Load(object sender, EventArgs e)
        {
            try
            {
                bool successLoad;
                // Передача значения Пароля из формы AuthForm
                PassCreaUpdaTextBox.Texts = AuthForm.PasswordString;
                string sqlComUserFIO = $"select * from Info_About_User " +
                    $"join Authentication_ on Authentication_.FK_Info_User " +
                    $"= Info_About_User.ID_Info_User " +
                    $"where Authentication_.Login_User = " +
                    $"'{AuthForm.LoginString}'";
                SqlCommand check = Check(sqlComUserFIO);
                datebaseCon.openConnection();
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
                datebaseCon.closeConnection();
            }
            LoadDataGridView();
        }
        #endregion
        #region [Метод обновления данных в DGW]
        /// <summary>
        /// Обновление данных в DGW
        /// </summary>
        private void LoadDataGridView()
        {
            try
            {
                datebaseCon.openConnection();
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
                    " = Status_Application.ID_Status " +
                    $"where Info_About_User.User_Name = " +
                    $"'{NameCreateTextBox.Texts}' and " +
                    $"Info_About_User.User_Surname = " +
                    $"'{FamCreateTextBox.Texts}' and " +
                    $"Info_About_User.User_Patronymic = " +
                    $"'{PatrCreateTextBox.Texts}'",
                    datebaseCon.sqlConnection());
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                OutputInTableSetting(dataTable);
                SurnameUserString = FamCreateTextBox.Texts;
                NameUserString = NameCreateTextBox.Texts;
                PatronymicUserString = PatrCreateTextBox.Texts;
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
                datebaseCon.closeConnection();
            }
        }
        #endregion
        #region [Настройки вывода информации в DataGridViewApplication]
        /// <summary>
        /// Настройки вывода информации в DataGridViewApplication
        /// </summary>
        /// <param name="dataTable"></param>
        private void OutputInTableSetting(DataTable dataTable)
        {
            DataGridViewApplication.DataSource = dataTable;
            DataGridViewApplication.Columns[0].HeaderText = "Номер заявки";
            DataGridViewApplication.Columns[0].Width = 60;
            DataGridViewApplication.Columns[1].HeaderText = "Компания заявителя";
            DataGridViewApplication.Columns[1].Width = 140;
            DataGridViewApplication.Columns[2].HeaderText = "Фамилия заявителя";
            DataGridViewApplication.Columns[2].Width = 120;
            DataGridViewApplication.Columns[3].HeaderText = "Имя заявителя";
            DataGridViewApplication.Columns[3].Width = 130;
            DataGridViewApplication.Columns[4].HeaderText = "Отчество заявителя";
            DataGridViewApplication.Columns[4].Width = 130;
            DataGridViewApplication.Columns[5].HeaderText = "Статус заявки";
            DataGridViewApplication.Columns[5].Width = 116;
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
                FamCreateTextBox.Texts =
                    datareader.GetValue(1).ToString();
                CreateUserFIOButton.Enabled = false;
                ((Control)this.ApplicationPage).Enabled = true;
            }
            else
            {
                FamCreateTextBox.Texts = "";
                ((Control)this.ApplicationPage).Enabled = false;
                InfoApplicationLabel.Visible = true;
            }
            if (datareader.HasRows)
            {
                NameCreateTextBox.Texts =
                    datareader.GetValue(2).ToString();
                CreateUserFIOButton.Enabled = false;
                ((Control)this.ApplicationPage).Enabled = true;
            }
            else
            {
                NameCreateTextBox.Texts = "";
                ((Control)this.ApplicationPage).Enabled = false;
                InfoApplicationLabel.Visible = true;
            }
            if (datareader.HasRows)
            {
                PatrCreateTextBox.Texts =
                    datareader.GetValue(3).ToString();
                CreateUserFIOButton.Enabled = false;
                ((Control)this.ApplicationPage).Enabled = true;
            }
            else
            {
                PatrCreateTextBox.Texts = "";
                ((Control)this.ApplicationPage).Enabled = false;
                InfoApplicationLabel.Visible = true;
            }
        }
        #endregion
        #region [Изменение пароля пользователя]
        private void UpdLogPassButton_Click(object sender, EventArgs e)
        {
            bool success;
            try
            {
                string sqlCom = "update Authentication_ " +
                    "set Password_User = " +
                    "@updPass where Login_User = @oldLog";
                SqlCommand check = Check(sqlCom);
                check.Parameters.AddWithValue("@updPass", 
                    PassCreaUpdaTextBox.Texts);
                check.Parameters.AddWithValue("@oldLog", 
                    AuthForm.LoginString);
                datebaseCon.openConnection();
                using (var dataReader = check.ExecuteReader())
                {
                    success = dataReader.Read();
                    MessageBox.Show("Данные успешно изменены!",
                        "Информация", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    UpdLogPassButton.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, 
                    "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            finally
            {
                datebaseCon.closeConnection();
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
            return new SqlCommand(command, datebaseCon.sqlConnection());
        }
        #endregion
        #region [Событие нажатия на кнопку CreateUserFIOButton]
        private void CreateUserFIOButton_Click(object sender, EventArgs e)
        {
            bool success;
            try
            {
                if (FamCreateTextBox.Texts == ""
                || NameCreateTextBox.Texts == ""
                || PatrCreateTextBox.Texts == "")
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
                        + FamCreateTextBox.Texts
                        + "','"
                        + NameCreateTextBox.Texts
                        + "','"
                        + PatrCreateTextBox.Texts
                        + "')";
                    string sqlComFIO2 = $"update Authentication_ " +
                        $"set FK_Info_User = Info_About_User.ID_Info_User " +
                        $"from Info_About_User where " +
                        $"Info_About_User.User_Surname = " +
                        $"'{FamCreateTextBox.Texts}' " +
                        $"and Info_About_User.User_Name = " +
                        $"'{NameCreateTextBox.Texts}' " +
                        $"and Info_About_User.User_Patronymic = " +
                        $"'{PatrCreateTextBox.Texts}' " +
                        $"and Authentication_.Login_User = " +
                        $"'{AuthForm.LoginString}'";
                    SqlCommand check = Check(sqlComFIO);
                    SqlCommand check2 = Check(sqlComFIO2);
                    datebaseCon.openConnection();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, 
                    "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            finally
            {
                datebaseCon.closeConnection();
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
            DataBaseCon dataBaseCon = new DataBaseCon();
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand
                ("select * from Info_About_User where User_Surname=@usSur " +
                "and User_Name=@usName and User_Patronymic=@usPat",
                dataBaseCon.sqlConnection());
            command.Parameters.Add
                ("@usSur", SqlDbType.VarChar).Value
                = FamCreateTextBox.Texts;
            command.Parameters.Add
                ("@usName", SqlDbType.VarChar).Value
                = NameCreateTextBox.Texts;
            command.Parameters.Add
                ("@usPat", SqlDbType.VarChar).Value 
                = PatrCreateTextBox.Texts;
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
        #region [Открытие формы создания обращения]
        private void CreateApplicationButton_Click(object sender, EventArgs e)
        {
            CreateApplicationForm createApplicationForm
                = new CreateApplicationForm();
            createApplicationForm.Show();
            this.Hide();
        }
        #endregion
        #region [Событие нажатия на кнопку перезагрузки данных в DGW]
        private void UpdateDataInDGW_Click(object sender, EventArgs e)
        {
            try
            {
                datebaseCon.openConnection();
                SqlDataAdapter dataAdapter = new SqlDataAdapter
                    ("select Id_Application, " +
                    "Applicant_Company, User_Surname, " +
                    "User_Name, " +
                    "User_Patronymic, Status_Name " +
                    "from Application_To_Company" +
                    " join Info_About_User on " +
                    "Application_To_Company.FK_Info_User = " +
                    "Info_About_User.ID_Info_User join " +
                    "Status_Application on " +
                    "Application_To_Company.FK_Status_Application" +
                    " = Status_Application.ID_Status " +
                    $"where Info_About_User.User_Name = " +
                    $"'{NameCreateTextBox.Texts}' and " +
                    $"Info_About_User.User_Surname = " +
                    $"'{FamCreateTextBox.Texts}' and " +
                    $"Info_About_User.User_Patronymic = " +
                    $"'{PatrCreateTextBox.Texts}'",
                    datebaseCon.sqlConnection());
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                OutputInTableSetting(dataTable);
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
                datebaseCon.closeConnection();
            }
        }
        #endregion
        #region [Удаление заявки]
        private void DeleteApplicationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Вы действительно хотите удалить обращение?", 
                "Внимание", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                string sqlComDelete = "delete from " +
                    "Application_To_Company " +
                    "where ID_Application " +
                    $"= " +
                    $"'{DataGridViewApplication.CurrentRow.Cells[0].Value}'";
                SqlCommand sqlCommand = new SqlCommand
                    (sqlComDelete, 
                    datebaseCon.sqlConnection());
                try
                {
                    datebaseCon.openConnection();
                    using(var datareader = sqlCommand)
                    {
                        sqlCommand.ExecuteReader();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, 
                        "Ошибка", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
                finally
                {
                    datebaseCon.closeConnection();
                }
                LoadDataGridView();
            }
        }
        #endregion
        #region [Открытие прайс-листа]
        private void OpenPriceListButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start
                ("https://napitki-altay.ru/wp-content/uploads/2022/01/" +
                "Прайс-лист-01.11.2021-3.pdf");
        }
        #endregion
        #region [Открытие СОУТов 2016-2021]
        private void OpenSout2016Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start
                ("https://napitki-altay.ru/wp-content/uploads/2018/09/" +
                "результаты-СОУТ-2016-2017.pdf");
        }
        private void OpenSout2018Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start
                ("https://napitki-altay.ru/wp-content/uploads/2018/09/" +
                "результаты-СОУТ-2018.pdf");
        }
        private void OpenSout2021Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start
                ("https://napitki-altay.ru/wp-content/uploads/2021/11/" +
                "Сводная-ведомость-результатов-" +
                "проведения-специальной-оценки" +
                "-условий-труда-01.11.2021г.pdf");
        }
        #endregion
    }
}