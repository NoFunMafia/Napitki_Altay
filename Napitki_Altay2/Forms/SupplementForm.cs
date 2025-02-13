#region [using's]
using Napitki_Altay2.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Smtp;
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
        string workerEmail;
        public static string typeApplication;
        public static string description;
        public static DateTime dateTimeWork;
        string documentName;
        string documentExtansion;
        string fkInfoUser;
        string fkDocumentId;
        public SupplementForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
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
            Form userInfoForm = Application.OpenForms["UserApplicationInfoForWorkerForm"];
            userInfoForm?.Close();
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
            LoadForm();
        }

        private void LoadForm()
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
                SendAnEmail();
            }
            else
            {
                if (string.IsNullOrEmpty(DescripTextBox.Texts))
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
                    CreateSupplement();
                    SendAnEmail();
                }
            }
        }
        #endregion
        #region [Метод, отправляющий email уведомление о добавлении обращения]
        private async void SendAnEmail()
        {
            List<string[]> listSearch = GetFioWorker();
            CheckEmailWorker(listSearch);
            MimeMessage mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("ЗАО «Волчихинский пивоваренный завод»",
                "napitki-altay@mail.ru"));
            mimeMessage.To.Add(MailboxAddress.Parse(workerEmail));
            mimeMessage.Subject = $"Получен ответ от заявителя!";
            mimeMessage.Body = new TextPart("html")
            {
                Text = $"<p>Заявитель, с которым Вы работаете, дополнил своё обращение. " +
                $"Пожалуйста, ответьте на него в ближайшее время!</p>" +
                $"<p>С уважением,<br>Ваша автоматизированная система документооборота.</p>"
            };
            SmtpClient smtpClient = new SmtpClient();
            await smtpClient.ConnectAsync("smtp.mail.ru", 465, true);
            smtpClient.Authenticate("napitki-altay@mail.ru", "5TGsxjXKrXYpVxeajrgY");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);
            smtpClient.Dispose();
        }
        #endregion
        #region [Метод закрытия формы]
        private void SupplementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Найдите открытую форму MainWorkFormWorker
            MainWorkForm mainWorkForm = Application.OpenForms.OfType<MainWorkForm>().FirstOrDefault();
            // Если форма найдена, вызовите методы обновления
            mainWorkForm?.Show();
            Form readyForm = Application.OpenForms["ReadyApplicationInfoForUserForm"];
            readyForm?.Close();
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
        #region [Метод, получающий значение почты работника]
        /// <summary>
        /// Метод, заполняющий List список из sql-запроса
        /// </summary>
        /// <returns></returns>
        private List<string[]> GetFioWorker()
        {
            string sqlQuery = sqlQueries.SqlComGetFioWorker(MainWorkForm.selectedRowIDInDGWC);
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 3);
            return listSearch;
        }
        #endregion
        private void CheckEmailWorker(List<string[]> strings)
        {
            if (strings != null)
            {
                foreach (string[] item in strings)
                {
                    string sqlQuery = sqlQueries.SqlComGetEmailWorker
                        (item[1].ToString(), item[0].ToString(), item[2].ToString());
                    workerEmail = dataBaseWork.GetString(sqlQuery);
                }
            }
        }
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
                    if (DescripTextBox.ReadOnly != true)
                    {
                        DescripTextBox.Texts = item[3] + $"\r\n\r\nДополнение от {DateTime.Now}:\r\n";
                        CompanyTextBox.Texts = item[1];
                        TypeApplTextBox.Texts = item[2];
                        companyWork = item[1];
                        typeApplication = item[2];
                        description = item[3];
                        dateTimeWork = DateTime.Parse(ApplDTP.Text);
                    }
                    else
                    {
                        if (item[5] != string.Empty)
                            DocumentTextBox.Texts = item[5];
                        else
                            DocumentTextBox.Texts = "Отсутствует";
                        DescripTextBox.Texts = item[3];
                        CompanyTextBox.Texts = item[1];
                        TypeApplTextBox.Texts = item[2];
                        companyWork = item[1];
                        typeApplication = item[2];
                        description = item[3];
                        dateTimeWork = DateTime.Parse(ApplDTP.Text);
                    }
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
            string sqlQuerySixth = sqlQueries.SqlComSupplementDocumentInfo
                (MainWorkForm.selectedRowIDInDGWC);
            string documentCheckName = dataBaseWork.GetString(sqlQuerySixth);
            if (documentCheckName == string.Empty || documentCheckName == "")
            {
                CheckFkIdUser(out List<string[]> listSearch);
                CheckUserIdInfo(listSearch);
                string sqlQueryFour = sqlQueries.SqlComAddDocument(fkInfoUser);
                documentName = name;
                documentExtansion = extn;
                try
                {
                    dataBaseWork.OpenConnection();
                    SqlCommand sqlCommand = new SqlCommand
                        (sqlQueryFour, dataBaseWork.GetConnection());
                    sqlCommand.Parameters.Add("@fileName", SqlDbType.VarChar).Value = name;
                    sqlCommand.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    sqlCommand.Parameters.Add("@extension", SqlDbType.Char).Value = extn;
                    sqlCommand.ExecuteNonQuery();
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
                //TakeDocumentIdInfo(out List<string[]> listSearchSecond);
                //CheckDataRowsIDDocument(listSearchSecond);
                string sqlUpdateDoc = sqlQueries.SqlComUpdateDocumentUserNew
                    (fkDocumentId, MainWorkForm.selectedRowIDInDGWC);
                dataBaseWork.WithoutOutputQuery(sqlUpdateDoc);
            }
            else
            {
                string sqlQueryFifth = sqlQueries.SqlComUpdateDocumentUser
                (MainWorkForm.selectedRowIDInDGWC);
                try
                {
                    dataBaseWork.OpenConnection();
                    SqlCommand sqlCommand = new SqlCommand(sqlQueryFifth, dataBaseWork.GetConnection());
                    sqlCommand.Parameters.Add("@filename", SqlDbType.VarChar).Value = name;
                    sqlCommand.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    sqlCommand.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dataBaseWork.CloseConnection();
                }
            }
        }
        private void CheckDataRowsIDDocument(List<string[]> strings)
        {
            if (strings != null)
            {
                foreach (string[] item in strings)
                {
                    fkDocumentId = item[0];
                }
            }
        }
        /*private void TakeDocumentIdInfo(out List<string[]> listSearchSecond)
        {
            string sqlQueryFive = sqlQueries.SqlComInfoAboutDocument
                (documentName, documentExtansion);
            listSearchSecond = dataBaseWork.GetMultiList(sqlQueryFive, 4);
        }*/
        private void CheckUserIdInfo(List<string[]> strings)
        {
            if (strings != null)
            {
                foreach (string[] item in strings)
                {
                    fkInfoUser = item[0];
                }
            }
        }
        private void CheckFkIdUser(out List<string[]> listSearch)
        {
            string sqlQuery = sqlQueries.sqlComFkInfoUser;
            listSearch = dataBaseWork.GetMultiList(sqlQuery, 4);
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
                (DescripTextBox.Texts, DateTime.Now.ToString(), MainWorkForm.selectedRowIDInDGWC);
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
        public void DisableControls()
        {
            ChooseDocumentButton.Enabled = false;
            DeleteDocumentButton.Enabled = false;
            DescripTextBox.ReadOnly = true;
            PlusSupButton.Enabled = false;
            CancelSupButton.Text = "Закрыть обращение";
            SelectDocumentLabel.Text = "Прикрепленный файл к ответу:";
            Text = "Ваше обращение";
            LoadForm();
        }

        public void EnableControls()
        {
            List<string[]> listSearch = GetApplicationInfoQuery();
            CheckDataReaderRowsInfo(listSearch);
            DeleteDocumentButton.Enabled = true;
            DescripTextBox.ReadOnly = false;
            PlusSupButton.Enabled = true;
            CancelSupButton.Text = "Прекратить дополнение";
            Text = "Добавление доп. информации к обращению";
            LoadForm();
        }
    }
}