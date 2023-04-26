#region [using's]
using Napitki_Altay2.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class SupplementWorkForm : Form
    {
        #region [Подключение классов, обьявление переменных]
        readonly SqlQueries sqlQueries = new SqlQueries();
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        string documentPath;
        #endregion
        public SupplementWorkForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }

        private void ChooseStatusApplPictureBox_Click(object sender, EventArgs e)
        {
            TypeApplWorkMenuStrip.Show(ChooseStatusApplPictureBox,
                new Point(0, ChooseStatusApplPictureBox.Height));
        }

        public void DisableControls()
        {
            StatusApplicationTextBox.Enabled = false;
            DocumentWorkAnsTextBox.Enabled = false;
            ChooseAnsWorkDocumentButton.Enabled = false;
            ChooseStatusApplPictureBox.Enabled = false;
            DeleteAnsWorkDocumentButton.Enabled = false;
            DescripWorkAnsTextBox.Enabled = false;
            HelpCollaborationButton.Enabled = false;
            HelpDiscussionButton.Enabled = false;
            HelpThanksButton.Enabled = false;
            AnswerApplButton.Enabled = false;
            CloseAnsButton.Text = "Закрыть ответ";
        }

        public void EnableControls()
        {
            StatusApplicationTextBox.Enabled = false;
            DocumentWorkAnsTextBox.Enabled = false;
            ChooseAnsWorkDocumentButton.Enabled = true;
            ChooseStatusApplPictureBox.Enabled = true;
            DeleteAnsWorkDocumentButton.Enabled = true;
            DescripWorkAnsTextBox.Enabled = true;
            HelpCollaborationButton.Enabled = true;
            HelpDiscussionButton.Enabled = true;
            HelpThanksButton.Enabled = true;
            AnswerApplButton.Enabled = true;
            CloseAnsButton.Text = "Прекратить дополнение";
        }
        private void ОжиданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusApplicationTextBox.Texts = "Ожидание доп. информации";
        }
        private void ЗавершеноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusApplicationTextBox.Texts = "Завершено";
        }
        private void CloseAnsButton_Click(object sender, EventArgs e)
        {
            Close();
            Form userForm = Application.OpenForms["UserApplicationInfoForWorkerForm"];
            userForm?.Close();
        }

        private void SupplementWorkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Найдите открытую форму MainWorkFormWorker
            MainWorkFormWorker mainWorkFormWork = Application.OpenForms.OfType<MainWorkFormWorker>().FirstOrDefault();
            // Если форма найдена, вызовите методы обновления
            mainWorkFormWork?.Show();
            Form userForm = Application.OpenForms["UserApplicationInfoForWorkerForm"];
            userForm?.Close();
        }

        private void SupplementWorkForm_Load(object sender, EventArgs e)
        {
            List<string[]> listSearch = GetApplicationInfoQuery();
            CheckDataReaderRowsInfo(listSearch);
        }
        #region [Метод, заполняющий List список из sql-запроса]
        /// <summary>
        /// Метод, заполняющий List список из sql-запроса
        /// </summary>
        /// <returns></returns>
        private List<string[]> GetApplicationInfoQuery()
        {
            string sqlQuerySecond = sqlQueries.SqlComOpenWorkerAnswer
                (MainWorkFormWorker.SelectedRowID);
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuerySecond, 6);
            return listSearch;
        }
        #endregion
        #region [Метод, заполняющий TextBox'ы данными из sql-запроса]
        /// <summary>
        /// Метод, заполняющий TextBox'ы данными из sql-запроса
        /// </summary>
        /// <param name="strings"></param>
        private void CheckDataReaderRowsInfo(List<string[]> strings)
        {
            if (strings != null)
            {
                foreach (string[] item in strings)
                {
                    DescripWorkAnsTextBox.Texts = item[3] + $"\r\n\r\nДополнение от {DateTime.Now}:\r\n";
                    ApplAnsWorkDTP.Text = DateTime.Parse(item[4]).ToString();
                }
            }
            else
            {
                StatusApplicationTextBox.Texts = "";
                DescripWorkAnsTextBox.Texts = "";
                ApplAnsWorkDTP.Text = "";
                DocumentWorkAnsTextBox.Texts = "";
            }
        }
        #endregion

        private void AnswerApplButton_Click(object sender, EventArgs e)
        {
            string filepath = DocumentWorkAnsTextBox.Texts;
            if (string.IsNullOrEmpty(DocumentWorkAnsTextBox.Texts))
            {
                CreateSupplementWorker();
            }
            else
            {
                if (string.IsNullOrEmpty(DescripWorkAnsTextBox.Texts) 
                    || string.IsNullOrEmpty(StatusApplicationTextBox.Texts))
                {
                    MessageBox.Show("Не все поля заполнены!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (Stream stream = File.OpenRead(documentPath))
                    {
                        GetDocumentInfo(filepath, stream, out byte[] buffer,
                            out string extension, out string name);
                        UpdateDocumentQuery(buffer, extension, name);
                    }
                    CreateSupplementWorker();
                }
            }
        }
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
        #region [Метод, создающий дополнение работника]
        private void CreateSupplementWorker()
        {
            string sqlQueryFirst = sqlQueries.SqlComGetReadyId(MainWorkFormWorker.SelectedRowID);
            string readyID = dataBaseWork.GetString(sqlQueryFirst);
            string sqlQuerySecond = sqlQueries.SqlComUpdateAnswer
                (DescripWorkAnsTextBox.Texts, DateTime.Now.ToString(), readyID);
            bool checkUpdate = dataBaseWork.WithoutOutputQuery(sqlQuerySecond);
            string sqlQueryThree = sqlQueries.SqlComCheckStatusID
                (StatusApplicationTextBox.Texts);
            string checkStatus = dataBaseWork.GetString(sqlQueryThree);
            string sqlQueryFourth = sqlQueries.SqlComUpdateStatus
                (checkStatus, MainWorkFormWorker.SelectedRowID);
            bool checkUpdateStatus = dataBaseWork.WithoutOutputQuery(sqlQueryFourth);
            if (checkUpdate && checkUpdateStatus)
            {
                MessageBox.Show("Ответ дополнен!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                // Найдите открытую форму MainWorkFormWorker
                MainWorkFormWorker mainWorkFormWork = Application.OpenForms.OfType<MainWorkFormWorker>().FirstOrDefault();
                // Если форма найдена, вызовите методы обновления
                if (mainWorkFormWork != null)
                {
                    mainWorkFormWork.LoadDataInCompleteApplicationDGW();
                    mainWorkFormWork.Show();
                }
                Form userForm = Application.OpenForms["UserApplicationInfoForWorkerForm"];
                userForm?.Close();
            }
        }
        #endregion

        private void DeleteAnsWorkDocumentButton_Click(object sender, EventArgs e)
        {
            DocumentWorkAnsTextBox.Texts = "";
        }

        private void ChooseAnsWorkDocumentButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Документы|*.docx;*.doc;*.xlsx;*.xls;*.pdf"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog.FileName);
                DocumentWorkAnsTextBox.Texts = fileName;
                documentPath = openFileDialog.FileName;
            }
        }
    }
}