using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Napitki_Altay2.Forms
{
    public partial class MainWorkFormWorker : Form
    {
        DataBaseCon dataBaseCon = new DataBaseCon();
        public static string SelectedRowID;
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
                dataBaseCon.openConnection();
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
                dataBaseCon.closeConnection();
            }
            LoadDataInDWG();
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
            return new SqlCommand(command, dataBaseCon.sqlConnection());
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
                    dataBaseCon.openConnection();
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
                dataBaseCon.closeConnection();
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
        public void LoadDataInDWG()
        {
            try
            {
                dataBaseCon.openConnection();
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
                    "Application_To_Company.FK_Application_Document_From_User" +
                    " = Application_Document_From_User.ID_Document_From_User",
                    dataBaseCon.sqlConnection());
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
                dataBaseCon.closeConnection();
            }
        }
        #region [Настройки вывода информации в DataGridViewAnswer]
        /// <summary>
        /// Настройки вывода информации в DataGridViewApplication
        /// </summary>
        /// <param name="dataTable"></param>
        private void OutputInTableSetting(DataTable dataTable)
        {
            DataGridViewAnswer.DataSource = dataTable;
            DataGridViewAnswer.Columns[0].HeaderText = "Номер заявки";
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
        private void UpdateAnswerInDGW_Click(object sender, EventArgs e)
        {
            LoadDataInDWG();
        }
        private void AnswerToApplicationButton_Click(object sender, EventArgs e)
        {
            SelectedRowID = DataGridViewAnswer.CurrentRow.Cells[0].Value.ToString();
            this.Hide();
            UserApplicationInfoForWorkerForm
                userApplicationInfoForWorkerForm =
                new UserApplicationInfoForWorkerForm();
            userApplicationInfoForWorkerForm.Show();
        }
    }
}