#region [using's]
using Napitki_Altay2.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class SupplementForm : Form
    {
        #region [Подключение классов, обьявление переменных]
        string documentPath;
        // Использование класса работы с БД
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        // Класс запросов в БД
        readonly SqlQueries sqlQueries = new SqlQueries();
        public static string companyWork;
        public static string typeApplication;
        public static string description;
        public static DateTime dateTimeWork;
        public SupplementForm()
        {
            InitializeComponent();
        }
        #endregion
        #region [Событие нажатия на кнопку ChooseDocumentButton]
        private void ChooseDocumentButton_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Документы|*.docx;*.doc;*.xlsx;*.xls;*.pdf"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog.FileName);
                DocumentTextBox.Texts = fileName;
                documentPath = openFileDialog.FileName;
            }
        }
        #endregion
        #region [Событие нажатия на кнопку CancelSupButton]
        private void CancelSupButton_Click(object sender, System.EventArgs e)
        {
            // Найдите открытую форму MainWorkFormWorker
            MainWorkForm mainWorkForm = Application.OpenForms.OfType<MainWorkForm>().FirstOrDefault();
            // Если форма найдена, вызовите методы обновления
            mainWorkForm?.Show();
            Close();
            Form readyForm = Application.OpenForms["ReadyApplicationInfoForUserForm"];
            readyForm?.Close();
        }
        #endregion
        #region [Событие нажатия на кнопку DeleteDocumentButton]
        private void DeleteDocumentButton_Click(object sender, EventArgs e)
        {
            DocumentTextBox.Texts = "";
        }
        #endregion
        #region [Событие загрузки формы]
        /// <summary>
        /// Событие загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SupplementForm_Load(object sender, EventArgs e)
        {
            List<string[]> listSearch = GetApplicationInfoQuery();
            CheckDataReaderRowsInfo(listSearch);
        }
        #endregion
        #region [Событие нажатия на кнопку PlusSupButton]
        private void PlusSupButton_Click(object sender, EventArgs e)
        {
            string filepath = DocumentTextBox.Texts;
            if (string.IsNullOrEmpty(DocumentTextBox.Texts))
            {
                CreateSupplement();
            }
            else
            {
                if (string.IsNullOrEmpty(DescripTextBox.Texts))
                {
                    MessageBox.Show("Не все поля заполнены!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                using (Stream stream = File.OpenRead(documentPath))
                {
                    GetDocumentInfo(filepath, stream, out byte[] buffer,
                        out string extension, out string name);
                    UpdateDocumentQuery(buffer, extension, name);
                }
                CreateSupplement();
            }
        }
        #endregion
        #region [Метод закрытия формы]
        private void SupplementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Найдите открытую форму MainWorkFormWorker
            MainWorkForm mainWorkForm = Application.OpenForms.OfType<MainWorkForm>().FirstOrDefault();
            // Если форма найдена, вызовите методы обновления
            mainWorkForm?.Show();
        }
        #endregion
        #region [Метод, заполняющий List список из sql-запроса]
        /// <summary>
        /// Метод, заполняющий List список из sql-запроса
        /// </summary>
        /// <returns></returns>
        private List<string[]> GetApplicationInfoQuery()
        {
            string sqlQuery = sqlQueries.SqlComSupplementInfo(MainWorkForm.selectedRowIDInDGWC);
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 6);
            return listSearch;
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
                    CompanyTextBox.Texts = item[1];
                    TypeApplTextBox.Texts = item[2];
                    DescripTextBox.Texts = item[3] + $"\r\n\r\nДополнение от {DateTime.Now}:\r\n";
                    ApplDTP.Text = DateTime.Parse(item[4]).ToString();
                    companyWork = item[1];
                    typeApplication = item[2];
                    description = item[3];
                    dateTimeWork = DateTime.Parse(ApplDTP.Text);
                }
            }
            else
            {
                CompanyTextBox.Texts = "";
                TypeApplTextBox.Texts = "";
                DescripTextBox.Texts = "";
                ApplDTP.Text = "";
                DocumentTextBox.Texts = "";
            }
        }
        #endregion
        #region [Метод, вносящий прикрепляемый файл в БД]
        /// <summary>
        /// Метод, вносящий прикрепляемый файл в БД
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="extn"></param>
        /// <param name="name"></param>
        private void UpdateDocumentQuery(byte[] buffer, string extn, string name)
        {
            string sqlQueryFifth = sqlQueries.SqlComUpdateDocumentUser
                (MainWorkForm.selectedRowIDInDGWC);
            try
            {
                dataBaseWork.OpenConnection();
                SqlCommand sqlCommand = new SqlCommand
                    (sqlQueryFifth, dataBaseWork.GetConnection());
                sqlCommand.Parameters.Add("@filename", SqlDbType.VarChar).Value = name;
                sqlCommand.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                sqlCommand.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataBaseWork.CloseConnection();
            }
        }
        #endregion
        #region [Метод, получающий информацию о прикрепляемом документе]
        private static void GetDocumentInfo(string filepath, Stream stream,
            out byte[] buffer, out string extn, out string name)
        {
            buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);
            var fileInfo = new FileInfo(filepath);
            extn = fileInfo.Extension;
            name = fileInfo.Name;
        }
        #endregion
        #region [Метод, создающий дополнение]
        private void CreateSupplement()
        {
            string sqlQueryFirst = sqlQueries.SqlComUpdateApplication
                            (DescripTextBox.Texts, MainWorkForm.selectedRowIDInDGWC);
            bool checkUpdate = dataBaseWork.WithoutOutputQuery(sqlQueryFirst);
            string sqlQuerySecond = sqlQueries.SqlComUpdateStatusAppl
                (MainWorkForm.selectedRowIDInDGWC);
            bool checkUpdateStatus = dataBaseWork.WithoutOutputQuery(sqlQuerySecond);
            if (checkUpdate && checkUpdateStatus)
            {
                MessageBox.Show("Обращение дополнено!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                // Найдите открытую форму MainWorkFormWorker
                MainWorkForm mainWorkForm = Application.OpenForms.OfType<MainWorkForm>().FirstOrDefault();
                // Если форма найдена, вызовите методы обновления
                if (mainWorkForm != null)
                {
                    mainWorkForm.LoadDataGridViewComplete();
                    mainWorkForm.Show();
                }
                Form readyForm = Application.OpenForms["ReadyApplicationInfoForUserForm"];
                readyForm?.Close();
            }
        }
        #endregion
    }
}