#region [using's]
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
#endregion
namespace Napitki_Altay2.Forms
{   
    public partial class ReadyApplicationInfoForUserForm : Form
    {
        DataBaseWork dataBaseCon = new DataBaseWork();
        public ReadyApplicationInfoForUserForm()
        {
            InitializeComponent();
        }
        private void ReadyApplicationInfoForUserForm_FormClosed
            (object sender, FormClosedEventArgs e)
        {
            MainWorkForm mainWorkForm = new MainWorkForm();
            mainWorkForm.Show();
        }
        private void OpenFile()
        {
            try
            {
                string sqlQuery = "select Document_Name_W, " +
                    "Document_Data_W, " +
                    "Document_Extension_W " +
                    "from Ready_Application " +
                    "join Answer_Document_From_Worker " +
                    "on Ready_Application." +
                    "FK_Answer_Document_From_Worker " +
                    "= Answer_Document_From_Worker." +
                    "ID_Document_From_Worker" +
                    " join Application_To_Company " +
                    "on Ready_Application.FK_ID_Application " +
                    "= Application_To_Company." +
                    "ID_Application where " +
                    $"ID_Application = " +
                    $"'{MainWorkForm.SelectedRowIDInDGW}'";
                SqlCommand command = new SqlCommand
                    (sqlQuery, dataBaseCon.GetConnection());
                dataBaseCon.OpenConnection();
                var dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    var name = dataReader["Document_Name_W"].ToString();
                    var data = (byte[])dataReader["Document_Data_W"];
                    var extn = dataReader["Document_Extension_W"].ToString();
                    var newFileName = name.Replace(extn,
                        DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                    File.WriteAllBytes(newFileName, data);
                    System.Diagnostics.Process.Start(newFileName);
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
        private void CheckDataReaderRowsInfo(SqlDataReader datareader)
        {
            if (datareader.HasRows)
            {
                TypeAppealAnswerTextBox.Texts =
                    datareader.GetValue(1).ToString();
            }
            if (datareader.HasRows)
            {
                StatusCompleteTextBox.Texts =
                    datareader.GetValue(2).ToString();
            }
            else
            {
                StatusCompleteTextBox.Texts = "";
            }
            if (datareader.HasRows)
            {
                DescripCompleteTextBox.Texts =
                    datareader.GetValue(3).ToString();
            }
            else
            {
                DescripCompleteTextBox.Texts = "";
            }
            if (datareader.HasRows)
            {
                ApplCompleteDTP.Text =
                    datareader.GetDateTime(4).ToString();
            }
            else
            {
                ApplCompleteDTP.Text = "";
            }
            if (datareader.HasRows)
            {
                PinDocumentTextBox.Texts =
                    datareader.GetValue(5).ToString();
            }
        }
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
        private void ReadyApplicationInfoForUserForm_Load(object sender, EventArgs e)
        {
            try
            {
                bool successLoad;
                string sqlComUserFIO = "select FK_ID_Application, " +
                    "Type_Appeal, Status_Name, " +
                    "Answer_To_Application, Date_Of_Answer, " +
                    "Document_Name_W from Ready_Application " +
                    "full join Answer_Document_From_Worker on " +
                    "Ready_Application.FK_Answer_Document_From_Worker" +
                    " = Answer_Document_From_Worker." +
                    "ID_Document_From_Worker join " +
                    "Application_To_Company on " +
                    "Application_To_Company.ID_Application " +
                    "= Ready_Application.FK_ID_Application " +
                    "join Type_Of_Appeal on " +
                    "Application_To_Company.FK_Type_Of_Appeal " +
                    "= Type_Of_Appeal.ID_Type_Of_Appeal join " +
                    "Status_Application on " +
                    "Application_To_Company.FK_Status_Application" +
                    $" = Status_Application.ID_Status " +
                    $"where FK_ID_Application = " +
                    $"'{MainWorkForm.SelectedRowIDInDGW}'";
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
        }
        private void CloseCompleteApplicationButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void OpenPinDocumentButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
    }
}
