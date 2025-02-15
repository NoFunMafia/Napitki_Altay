#region [using's]
using Napitki_Altay2.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using DocumentFormat.OpenXml.Packaging;
using System.Text;
using DocumentFormat.OpenXml.Wordprocessing;
using MimeKit;
using MailKit.Net.Smtp;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class SupplementWorkForm : Form
    {
        #region [Подключение классов, обьявление переменных]
        string userFam, userName, userOtch, documentPath;
        readonly SqlQueries sqlQueries = new SqlQueries();
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        readonly CultureInfo russianCulture = new CultureInfo("ru-RU");
        string userEmail;
        string documentName;
        string documentExtansion;
        string fkInfoUser;
        string fkDocumentId;
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
            ChooseAnsWorkDocumentButton.Enabled = false;
            DeleteAnsWorkDocumentButton.Enabled = false;
            ChooseStatusApplPictureBox.Visible = false;
            DescripWorkAnsTextBox.ReadOnly = true;
            HelpCollaborationButton.Enabled = false;
            HelpDiscussionButton.Enabled = false;
            HelpThanksButton.Enabled = false;
            AnswerApplButton.Enabled = false;
            CloseAnsButton.Text = "Закрыть ответ";
            Text = "Ваш ответ на обращение";
            SelectAnsWorkDocumentLabel.Text = "Прикрепленный файл к ответу:";
            SelectAnsWorkDocumentLabel.Location = new Point(335, 190);
            DescripApplWorkLabel.Text = "Ответ на обращение пользователя:";
            LoadForm();
        }

        public void EnableControls()
        {
            List<string[]> listSearch = GetApplicationInfoQuery();
            CheckDataReaderRowsInfo(listSearch);
            ChooseAnsWorkDocumentButton.Enabled = true;
            DeleteAnsWorkDocumentButton.Enabled = true;
            ChooseStatusApplPictureBox.Visible = true;
            DescripWorkAnsTextBox.ReadOnly = false;
            HelpCollaborationButton.Enabled = true;
            HelpDiscussionButton.Enabled = true;
            HelpThanksButton.Enabled = true;
            AnswerApplButton.Enabled = true;
            CloseAnsButton.Text = "Прекратить дополнение";
            Text = "Ответ на доп. информацию по обращению";
            SelectAnsWorkDocumentLabel.Text = "Прикрепить файл \nк ответу на обращение (опционально):";
            SelectAnsWorkDocumentLabel.Location = new Point(335, 175);
            DescripApplWorkLabel.Text = "Дополнение ответа на обращение:";
            LoadForm();
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

        public void SupplementWorkForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
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
                    if (DescripWorkAnsTextBox.ReadOnly != true)
                    {
                        DescripWorkAnsTextBox.Texts = item[3] + $"\r\n\r\nДополнение от {DateTime.Now}:\r\n";
                        StatusApplicationTextBox.Texts = "";
                        DocumentWorkAnsTextBox.Texts = "";
                    }
                    else
                    {
                        StatusApplicationTextBox.Texts = item[2];
                        DescripWorkAnsTextBox.Texts = item[3];
                        if (item[5] != string.Empty)
                            DocumentWorkAnsTextBox.Texts = item[5];
                        else
                            DocumentWorkAnsTextBox.Texts = "Отсутствует";
                    }
                    //ApplAnsWorkDTP.Text = DateTime.Parse(item[4]).ToString();
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
                SendAnEmail();
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
                    SendAnEmail();
                }
            }
        }
        #region [Метод, отправляющий email уведомление о добавлении обращения]
        private async void SendAnEmail()
        {
            List<string[]> listSearch = GetFioUser();
            CheckEmailUser(listSearch);
            MimeMessage mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("ЗАО «Волчихинский пивоваренный завод»",
                "napitki-altay@mail.ru"));
            mimeMessage.To.Add(MailboxAddress.Parse(userEmail));
            mimeMessage.Subject = $"Получен ответ от сотрудника!";
            mimeMessage.Body = new TextPart("html")
            {
                Text = $"<p>Сотрудник, работающий по вашему обращению дополнил свой ответ. " +
                $"Мы надеемся что вы сможете посмотреть его в ближайшее время!" +
                $"<p>С уважением,<br>Команда ЗАО «Волчихинский пивоваренный завод»</p>"
            };
            SmtpClient smtpClient = new SmtpClient();
            await smtpClient.ConnectAsync("smtp.mail.ru", 465, true);
            smtpClient.Authenticate("napitki-altay@mail.ru", "5TGsxjXKrXYpVxeajrgY");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);
            smtpClient.Dispose();
        }
        #endregion
        private void CheckEmailUser(List<string[]> strings)
        {
            if (strings != null)
            {
                foreach (string[] item in strings)
                {
                    string sqlQuery = sqlQueries.SqlComGetEmailWorker
                        (item[1].ToString(), item[0].ToString(), item[2].ToString());
                    userEmail = dataBaseWork.GetString(sqlQuery);
                }
            }
        }
        #region [Метод, получающий значение почты работника]
        /// <summary>
        /// Метод, заполняющий List список из sql-запроса
        /// </summary>
        /// <returns></returns>
        private List<string[]> GetFioUser()
        {
            string sqlQuery = sqlQueries.SqlComGetFioUser(MainWorkFormWorker.SelectedRowID);
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 3);
            return listSearch;
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
            string sqlQuerySixth = sqlQueries.SqlComOpenWorkerAnswerDocInfo
                (MainWorkFormWorker.SelectedRowID);
            string documentCheckName = dataBaseWork.GetString(sqlQuerySixth);
            if (documentCheckName == string.Empty || documentCheckName == "")
            {
                CheckFkIdUser(out List<string[]> listSearch);
                CheckUserIdInfo(listSearch);
                string sqlQueryFour = sqlQueries.SqlComAddWorkDocument(fkInfoUser);
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
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dataBaseWork.CloseConnection();
                }
                TakeDocumentIdInfo(out List<string[]> listSearchSecond);
                CheckDataRowsIDDocument(listSearchSecond);
                string sqlQueryCheckId = sqlQueries.SqlComTakeApplId
                    (MainWorkFormWorker.SelectedRowID);
                string checkApplId = dataBaseWork.GetString(sqlQueryCheckId);
                string sqlUpdateDoc = sqlQueries.SqlComUpdateDocumentWorkNew
                    (fkDocumentId, checkApplId);
                dataBaseWork.WithoutOutputQuery(sqlUpdateDoc);
            }
            else
            {
                string sqlQueryFifth = sqlQueries.SqlComUpdateDocumentUser
                (MainWorkFormWorker.SelectedRowID);
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
        private void TakeDocumentIdInfo(out List<string[]> listSearchSecond)
        {
            string sqlQueryFive = sqlQueries.SqlComInfoAboutWDocument
                (documentName, documentExtansion);
            listSearchSecond = dataBaseWork.GetMultiList(sqlQueryFive, 4);
        }
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
            string sqlQuery = sqlQueries.sqlComFkInfoWorkUser;
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
        #region [Метод, получающий ФИО заявителя]
        /// <summary>
        /// Метод, получающий ФИО заявителя
        /// </summary>
        /// <returns></returns>
        private List<string[]> GetFioFromQuery()
        {
            string sqlQuery = sqlQueries.SqlComFioApplication(MainWorkFormWorker.SelectedRowID);
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 4);
            return listSearch;
        }
        #endregion
        #region [Метод, заполняющий ФИО в string переменные]
        /// <summary>
        /// Метод, заполняющий ФИО в string переменные
        /// </summary>
        /// <param name="strings"></param>
        private void FillFioStrings(List<string[]> strings)
        {
            if (strings != null)
            {
                foreach (string[] item in strings)
                {
                    userFam = item[1];
                    userName = item[2];
                    userOtch = item[3];
                }
            }
        }
        #endregion
        #region [Метод, создающий документ сотрудничества по пути рабочего стола]
        /// <summary>
        /// Метод, создающий документ сотрудничества по пути рабочего стола
        /// </summary>
        /// <returns></returns>
        private static string CreateCollaborationDocumentPath()
        {
            string assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string assemblyDirectory = Path.GetDirectoryName(assemblyPath);
            string subfolderName = "WordDocuments";
            string templateFileName = "Пример для составления ответа на сотрудничество.docx";
            string templatePath = Path.Combine(assemblyDirectory, subfolderName, templateFileName);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string newDocumentName = "Ответ на сотрудничество.docx";
            string newDocumentPath = Path.Combine(desktopPath, newDocumentName);
            // Создание копии шаблона
            File.Copy(templatePath, newDocumentPath, true);
            return newDocumentPath;
        }
        #endregion
        #region [Метод, создающий плейсхолдеры для макетов документов]
        /// <summary>
        /// Метод, создающий плейсхолдеры для макетов документов
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, string> CreatePlaceHolders()
        {
            // Заполнить плейсхолдеры данными
            return new Dictionary<string, string>
            {
                { "{applicationNumber}", MainWorkFormWorker.SelectedRowID?.ToString() ?? "Неизвестно" },
                //{ "{companyName}", UserApplicationInfoForWorkerForm.companyWork?.ToString() ?? "Неизвестно" },
                { "{imya}", userName?.Substring(0, 1).ToString() ?? "Неизвестно" },
                { "{famFull}", userFam?.ToString().ToString() ?? "Неизвестно" },
                { "{otch}", userOtch?.Substring(0, 1).ToString() ?? "Неизвестно"},
                { "{day}", DateTime.Today.Day.ToString() },
                { "{monthName}", russianCulture.DateTimeFormat.GetMonthName(DateTime.Today.Month) },
                { "{year}", DateTime.Today.Year.ToString() },
                { "{dayFiling}", UserApplicationInfoForWorkerForm.dateTimeWork.Day.ToString() },
                { "{monthFiling}", russianCulture.DateTimeFormat.GetMonthName
                (UserApplicationInfoForWorkerForm.dateTimeWork.Month).ToString() },
                { "{yearFiling}", UserApplicationInfoForWorkerForm.dateTimeWork.Year.ToString() }
            };
        }
        #endregion
        #region [Метод, меняющий слова в {скобках} на плейсхолдеры]
        /// <summary>
        /// Метод, меняющий слова в {скобках} на плейсхолдеры
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="placeholders"></param>
        private void ReplacePlaceholdersInDocument(string filePath, Dictionary<string, string> placeholders)
        {
            try
            {
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filePath, true))
                {
                    var doc = wordDoc.MainDocumentPart.Document.CloneNode(true) as Document;
                    var body = doc.Body;
                    foreach (var paragraph in body.Descendants<Paragraph>())
                    {
                        var runs = paragraph.Descendants<Run>().ToList();
                        if (runs.Count == 0) continue;
                        // Склеиваем все текстовые элементы всех Run внутри параграфа
                        StringBuilder sb = new StringBuilder();
                        foreach (var run in runs)
                        {
                            foreach (var textElement in run.Descendants<Text>())
                            {
                                sb.Append(textElement.Text);
                            }
                        }
                        string fullText = sb.ToString();
                        // Замена плейсхолдеров
                        foreach (var placeholder in placeholders)
                        {
                            fullText = fullText.Replace(placeholder.Key, placeholder.Value);
                        }
                        // Удаляем все Run элементы в параграфе
                        foreach (var run in runs)
                        {
                            paragraph.RemoveChild(run);
                        }
                        // Добавляем новый Run элемент с замененными плейсхолдерами
                        var newRun = new Run();
                        newRun.AppendChild(new Text(fullText));
                        paragraph.AppendChild(newRun);
                    }
                    wordDoc.MainDocumentPart.Document = doc;
                    wordDoc.MainDocumentPart.Document.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region [Метод, создающий документ проблемы по пути рабочего стола]
        /// <summary>
        /// Метод, создающий документ проблемы по пути рабочего стола
        /// </summary>
        /// <returns></returns>
        private static string CreateDiscussionDocumentPath()
        {
            string assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string assemblyDirectory = Path.GetDirectoryName(assemblyPath);
            string subfolderName = "WordDocuments";
            string templateFileName = "Пример для составления ответа на благодарность.docx";
            string templatePath = Path.Combine(assemblyDirectory, subfolderName, templateFileName);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string newDocumentName = "Ответ на благодарность.docx";
            string newDocumentPath = Path.Combine(desktopPath, newDocumentName);
            // Создание копии шаблона
            File.Copy(templatePath, newDocumentPath, true);
            return newDocumentPath;
        }
        #endregion
        #region [Метод, создающий документ претензии по пути рабочего стола]
        /// <summary>
        /// Метод, создающий документ претензии по пути рабочего стола
        /// </summary>
        /// <returns></returns>
        private static string CreateThanksDocumentPath()
        {
            string assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string assemblyDirectory = Path.GetDirectoryName(assemblyPath);
            string subfolderName = "WordDocuments";
            string templateFileName = "Пример для составления ответа на претензию.docx";
            string templatePath = Path.Combine(assemblyDirectory, subfolderName, templateFileName);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string newDocumentName = "Ответ на претензию.docx";
            string newDocumentPath = Path.Combine(desktopPath, newDocumentName);
            // Создание копии шаблона
            File.Copy(templatePath, newDocumentPath, true);
            return newDocumentPath;
        }
        #endregion

        private void HelpCollaborationButton_Click(object sender, EventArgs e)
        {
            List<string[]> listSearch = GetFioFromQuery();
            FillFioStrings(listSearch);
            string newDocumentPath = CreateCollaborationDocumentPath();
            Dictionary<string, string> placeHolders = CreatePlaceHolders();
            ReplacePlaceholdersInDocument(newDocumentPath, placeHolders);
            MessageBox.Show("Документ создан и сохранен по пути: " + newDocumentPath,
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HelpDiscussionButton_Click(object sender, EventArgs e)
        {
            List<string[]> listSearch = GetFioFromQuery();
            FillFioStrings(listSearch);
            string newDocumentPath = CreateDiscussionDocumentPath();
            Dictionary<string, string> placeHolders = CreatePlaceHolders();
            ReplacePlaceholdersInDocument(newDocumentPath, placeHolders);
            MessageBox.Show("Документ создан и сохранен по пути: " + newDocumentPath,
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HelpThanksButton_Click(object sender, EventArgs e)
        {
            List<string[]> listSearch = GetFioFromQuery();
            FillFioStrings(listSearch);
            string newDocumentPath = CreateThanksDocumentPath();
            Dictionary<string, string> placeHolders = CreatePlaceHolders();
            ReplacePlaceholdersInDocument(newDocumentPath, placeHolders);
            MessageBox.Show("Документ создан и сохранен по пути: " + newDocumentPath,
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}