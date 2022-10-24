using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Napitki_Altay2.Forms
{
    public partial class UserApplicationInfoForWorkerForm : Form
    {
        DataBaseCon dataBaseCon = new DataBaseCon();
        public UserApplicationInfoForWorkerForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        private void CloseApplicWorkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWorkFormWorker 
                mainWorkFormWorker = 
                new MainWorkFormWorker();
            mainWorkFormWorker.Show();
        }
        private void CheckDataReaderRowsInfo(SqlDataReader datareader)
        {
            if (datareader.HasRows)
            {
                CompanyWorkTextBox.Texts = 
                    datareader.GetValue(1).ToString();
            }
            else
            {
                CompanyWorkTextBox.Texts = "";
            }
            if (datareader.HasRows)
            {
                TypeApplWorkTextBox.Texts = 
                    datareader.GetValue(2).ToString();
            }
            else
            {
                TypeApplWorkTextBox.Texts = "";
            }
            if (datareader.HasRows)
            {
                DescripWorkTextBox.Texts = 
                    datareader.GetValue(3).ToString();
            }
            else
            {
                DescripWorkTextBox.Texts = "";
            }
            if (datareader.HasRows)
            {
                ApplWorkDTP.Text =
                    datareader.GetDateTime(4).ToString();
            }
            else
            {
                ApplWorkDTP.Text = "";
            }
            if (datareader.HasRows)
            {
                DocumentWorkTextBox.Texts = 
                    datareader.GetValue(5).ToString();
            }
        }
        private void UserApplicationInfoForWorkerForm_Load(object sender, EventArgs e)
        {
            try
            {
                bool successLoad;
                string sqlComUserFIO = "select " +
                    "ID_Application, Applicant_Company, " +
                    "Type_Appeal, Description_Of_Appeal, " +
                    "Date_Of_Request, Document_Name " +
                    "from Application_To_Company " +
                    "join Type_Of_Appeal on " +
                    "Application_To_Company.FK_Type_Of_Appeal " +
                    "= Type_Of_Appeal.ID_Type_Of_Appeal " +
                    "full join Application_Document_From_User " +
                    "on Application_To_Company." +
                    "FK_Application_Document_From_User = " +
                    "Application_Document_From_User." +
                    $"ID_Document_From_User where " +
                    $"Id_Application = " +
                    $"'{MainWorkFormWorker.SelectedRowID}'";
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
        }
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
        private void OpenDocumentWorkButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void OpenFile()
        {
            try
            {
                string sqlQuery = "select " +
                "Document_Name, Document_Data, " +
                "Document_Extension from Application_To_Company " +
                "join Application_Document_From_User " +
                "on Application_To_Company." +
                "FK_Application_Document_From_User" +
                " = Application_Document_From_User." +
                $"ID_Document_From_User where ID_Application = " +
                $"{MainWorkFormWorker.SelectedRowID}";
                SqlCommand command = new SqlCommand(sqlQuery, dataBaseCon.sqlConnection());
                dataBaseCon.openConnection();
                var dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    var name = dataReader["Document_Name"].ToString();
                    var data = (byte[])dataReader["Document_Data"];
                    var extn = dataReader["Document_Extension"].ToString();
                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                    File.WriteAllBytes(newFileName, data);
                    System.Diagnostics.Process.Start(newFileName);
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
                dataBaseCon.closeConnection();
            }
        }
    }
}