#region [using's]
using Napitki_Altay2.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
#endregion

namespace Napitki_Altay2.Forms
{
    public partial class UserApplicationInfoForWorkerForm : Form
    {
        #region [Подключение классов, объявление переменных]
        // Использование класса работы с БД
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        // Класс запросов в БД
        readonly SqlQueries sqlQueries = new SqlQueries();
        public static string companyWork;
        public static string typeApplication;
        public static string description;
        public static DateTime dateTimeWork;
        #endregion
        public UserApplicationInfoForWorkerForm()
        {
            Location = new Point(40, 90);
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Событие нажатия на кнопку CloseApplicWorkButton]
        /// <summary>
        /// Событие нажатия на кнопку CloseApplicWorkButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseApplicWorkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region [Событие загрузки формы]
        /// <summary>
        /// Событие загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserApplicationInfoForWorkerForm_Load(object sender, EventArgs e)
        {
            List<string[]> listSearch = GetApplicationInfoQuery();
            CheckDataReaderRowsInfo(listSearch);
        }
        #endregion
        #region [Событие нажатия на кнопку OpenDocumentWorkButton]
        /// <summary>
        /// Событие нажатия на кнопку OpenDocumentWorkButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenDocumentWorkButton_Click(object sender, EventArgs e)
        {
            OpenFileFromUser();
        }
        #endregion
        #region [Метод, заполняющий TextBox'ы данными из sql-запроса]
        /// <summary>
        /// Метод, заполняющий TextBox'ы
        /// </summary>
        /// <param name="datareader"></param>
        private void CheckDataReaderRowsInfo(List<string[]> strings)
        {
            if (strings != null)
            {
                foreach (string[] item in strings)
                {
                    CompanyWorkTextBox.Texts = item[1];
                    TypeApplWorkTextBox.Texts = item[2];
                    DescripWorkTextBox.Texts = item[3];
                    ApplWorkDTP.Text = DateTime.Parse(item[4]).ToString();
                    DocumentWorkTextBox.Texts = item[5];
                    companyWork = item[1];
                    typeApplication = item[2];
                    description = item[3];
                    dateTimeWork = DateTime.Parse(ApplWorkDTP.Text);
                }
            }
            else
            {
                CompanyWorkTextBox.Texts = "";
                TypeApplWorkTextBox.Texts = "";
                DescripWorkTextBox.Texts = "";
                ApplWorkDTP.Text = "";
                DocumentWorkTextBox.Texts = "";
            }
        }
        #endregion
        #region [Метод, заполняющий List список из sql-запроса]
        /// <summary>
        /// Метод, заполняющий List список из sql-запроса
        /// </summary>
        /// <returns></returns>
        private List<string[]> GetApplicationInfoQuery()
        {
            string sqlQuery = sqlQueries.sqlComCheckApplicationWorker;
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 6);
            return listSearch;
        }
        #endregion
        #region [Метод, открывающий прикрепленный файл к обращению]
        /// <summary>
        /// Метод, открывающий прикрепленный файл к обращению
        /// </summary>
        private void OpenFileFromUser()
        {
            try
            {
                string sqlQuery = sqlQueries.sqlComOpenDocumentWorker;
                SqlCommand command = new SqlCommand(sqlQuery, dataBaseWork.GetConnection());
                dataBaseWork.OpenConnection();
                var dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    var name = dataReader["Document_Name"].ToString();
                    var data = (byte[])dataReader["Document_Data"];
                    var extn = dataReader["Document_Extension"].ToString();
                    var newFileName = name.Replace
                        (extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                    File.WriteAllBytes(newFileName, data);
                    Process.Start(newFileName);
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
                dataBaseWork.CloseConnection();
            }
        }
        #endregion
    }
}