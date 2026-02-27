#region [using's]
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using MailKit.Net.Smtp;
using MimeKit;
using Napitki_Altay2.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Point = System.Drawing.Point;
#endregion

namespace Napitki_Altay2.Forms
{
    public partial class AnswerToUserApplicationForm : Form
    {
        #region [Подключение класса соединения с БД, объявление string переменных]
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        readonly SqlQueries sqlQueries = new SqlQueries();
        string workerId;
        List<Tuple<string, byte[], string>> attachedDocuments = new List<Tuple<string, byte[], string>>();
        private string userFam;
        private string userName;
        private string userOtch;
        readonly CultureInfo russianCulture = new CultureInfo("ru-RU");
        #endregion
        public AnswerToUserApplicationForm()
        {
            Location = new Point(900, 30);
            InitializeComponent();
            this.Size = new Size((int)(1645 / 1.98), (int)(1888 / 1.85));
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Событие нажатия на кнопку CloseApplicWorkButton]
        /// <summary>
        /// Событие нажатия на кнопку закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseApplicWorkButton_Click(object sender, EventArgs e)
        {
            Close();
            Form userForm = Application.OpenForms["UserApplicationInfoForWorkerForm"];
            userForm?.Close();
        }
        #endregion
        #region [События работы с ToolStripMenu, выбор статуса обращения]
        /// <summary>
        /// Событие нажатия на картинку с последующим 
        /// действием выпадающего элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseStatusApplPictureBox_Click(object sender, EventArgs e)
        {
            TypeApplWorkMenuStrip.Show(ChooseStatusApplPictureBox,
                new Point(0, ChooseStatusApplPictureBox.Height));
        }
        private void ОтказаноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusApplicationTextBox.Texts = "Отказано в рассмотрении";
        }
        private void РасИЗакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusApplicationTextBox.Texts = "Услуга оказана";
        }
        #endregion
        #region [Добавление документов в список]
        private void ChooseAnsWorkDocumentButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Документы|*.docx;*.doc;*.xlsx;*.xls;*.pdf"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    string fileName = Path.GetFileName(filePath);
                    byte[] fileData = File.ReadAllBytes(filePath);
                    string fileExt = Path.GetExtension(filePath);
                    attachedDocuments.Add(new Tuple<string, byte[], string>(fileName, fileData, fileExt));
                    DocumentListBox.Items.Add(fileName);
                }
            }
        }
        #endregion
        #region [Удаление документа из списка]
        private void DeleteAnsWorkDocumentButton_Click(object sender, EventArgs e)
        {
            if (DocumentListBox.SelectedItem != null)
            {
                string selectedDocument = DocumentListBox.SelectedItem.ToString();
                attachedDocuments.RemoveAll(doc => doc.Item1 == selectedDocument);
                DocumentListBox.Items.Remove(selectedDocument);
            }
        }
        #endregion
        #region [Метод, отправляющий email уведомление о добавлении обращения]
        private async void SendAnEmail()
        {
            try
            {
                MimeMessage mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress("Администрация Волчихинского района Алтайского края",
                    "napitki-altay@mail.ru"));
                mimeMessage.To.Add(MailboxAddress.Parse(sqlQueries.SqlComGetApplicantEmailByAppealId(workerId)));
                mimeMessage.Subject = "Уведомление о получении ответа на Ваше заявление";
                mimeMessage.Body = new TextPart("html")
                {
                    Text = "<h2>На ваше заявление ответил сотрудник</h2>" +
                    "<p>Ответ на ваше заявление можете посмотреть в приложении.</p>" +
                    "<p>С уважением,<br>Администрация Волчихинского района Алтайского края</p>"
                };
                using (var smtpClient = new SmtpClient())
                {
                    try
                    {
                        await smtpClient.ConnectAsync("smtp.mail.ru", 465, true);
                        await smtpClient.AuthenticateAsync("napitki-altay@mail.ru", "zqfuuDCwzsSzyuMsrktn");
                        await smtpClient.SendAsync(mimeMessage);
                    }
                    catch (SmtpCommandException)
                    {
                        MessageBox.Show("Не удалось отправить уведомление на указанную почту.",
                            "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (SocketException)
                    {
                        MessageBox.Show("Ошибка соединения с почтовым сервером.",
                            "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Не удалось отправить письмо.",
                            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        await smtpClient.DisconnectAsync(true);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка при отправке письма.",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region [Создание ответа и прикрепление документов]
        private void AnswerApplButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StatusApplicationTextBox.Texts) || string.IsNullOrEmpty(DescripWorkAnsTextBox.Texts))
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            workerId = GetWorkerId();
            string appealId = MainWorkFormWorker.SelectedRowID;
            string sqlStatusId = sqlQueries.SqlComCheckStatusID(StatusApplicationTextBox.Texts);
            string statusId = dataBaseWork.GetString(sqlStatusId);
            string sqlUpdateStatus = sqlQueries.SqlComUpdateStatus(statusId, appealId);
            bool statusUpdated = dataBaseWork.WithoutOutputQuery(sqlUpdateStatus);
            if (!statusUpdated)
            {
                MessageBox.Show("Ошибка обновления статуса обращения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 1. Создаем ответ сотрудника (получаем его ID)
            string sqlInsertResponse = sqlQueries.SqlComCreateAppealResponse(appealId, workerId, DescripWorkAnsTextBox.Texts);
            int responseId = dataBaseWork.InsertAndGetId(sqlInsertResponse);
            if (responseId > 0) // Если успешно создан ответ
            {
                if (attachedDocuments.Count > 0) // Если есть прикрепленные документы
                {
                    foreach (var document in attachedDocuments)
                    {
                        // 2. Загружаем документ в Worker_Document и получаем его ID
                        string sqlInsertDocument = sqlQueries.SqlComInsertWorkerDoc(workerId);
                        int documentId = dataBaseWork.InsertAndGetId(sqlInsertDocument, document);
                        // 3. Связываем документ с ответом в Response_Documents
                        if (documentId > 0)
                        {
                            string sqlLinkDocument = sqlQueries.SqlComLinkDocumentToResponse(responseId.ToString(), documentId.ToString());
                            dataBaseWork.WithoutOutputQuery(sqlLinkDocument);
                            MainWorkFormWorker mainWorkFormWS = Application.OpenForms.OfType<MainWorkFormWorker>().FirstOrDefault();
                            mainWorkFormWS?.LoadDataInDataGridViewAnswer(); // Вызываем метод обновления DataGridView
                            mainWorkFormWS?.LoadDataInCompleteApplicationDGW(); // Вызываем метод обновления DataGridView
                            Close();
                        }
                    }
                }
                MessageBox.Show("Ответ на обращение создан!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainWorkFormWorker mainWorkFormW = Application.OpenForms.OfType<MainWorkFormWorker>().FirstOrDefault();
                SendAnEmail();
                mainWorkFormW?.LoadDataInDataGridViewAnswer(); // Вызываем метод обновления DataGridView
                mainWorkFormW?.LoadDataInCompleteApplicationDGW(); // Вызываем метод обновления DataGridView
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка создания ответа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region [Метод получения ID сотрудника]
        private string GetWorkerId()
        {
            string sqlQuery = sqlQueries.SqlComGetWorkerId(MainWorkFormWorker.NameWorkerString,
                MainWorkFormWorker.SurnameWorkerString, MainWorkFormWorker.PatrWorkerString);
            return dataBaseWork.GetString(sqlQuery);
        }
        #endregion
        #region [Событие нажатия на кнопку HelpCollaborationButton]
        /// <summary>
        /// Событие нажатия на кнопку HelpCollaborationButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrationButtonButton_Click(object sender, EventArgs e)
        {
            List<string[]> listSearch = GetFioFromQuery();
            FillFioStrings(listSearch);
            string newDocumentPath = CreateCollaborationDocumentPath();
            Dictionary<string, string> placeHolders = CreatePlaceHolders();
            ReplacePlaceholdersInDocument(newDocumentPath, placeHolders);
            MessageBox.Show("Документ создан и сохранен по пути: " + newDocumentPath,
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region [Событие нажатия на кнопку HelpThanksButton]
        /// <summary>
        /// Событие нажатия на кнопку HelpThanksButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DenialCompensationButton_Click(object sender, EventArgs e)
        {
            List<string[]> listSearch = GetFioFromQuery();
            FillFioStrings(listSearch);
            string newDocumentPath = DenialCompensationDocumentPath();
            Dictionary<string, string> placeHolders = CreatePlaceHolders();
            ReplacePlaceholdersInDocument(newDocumentPath, placeHolders);
            MessageBox.Show("Документ создан и сохранен по пути: " + newDocumentPath,
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region [Событие нажатия на кнопку HelpDiscussionButton]
        /// <summary>
        /// Событие нажатия на кнопку HelpDiscussionButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefusalRegistrationButton_Click(object sender, EventArgs e)
        {
            List<string[]> listSearch = GetFioFromQuery();
            FillFioStrings(listSearch);
            string newDocumentPath = RefusalRegistrationDocumentPath();
            Dictionary<string, string> placeHolders = CreatePlaceHolders();
            ReplacePlaceholdersInDocument(newDocumentPath, placeHolders);
            MessageBox.Show("Документ создан и сохранен по пути: " + newDocumentPath,
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region [Метод, закрывающий формы]
        private void AnswerToUserApplicationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Найдите открытую форму MainWorkFormWorker
            MainWorkFormWorker mainWorkFormWork = Application.OpenForms.OfType<MainWorkFormWorker>().FirstOrDefault();
            // Если форма найдена, вызовите методы обновления
            mainWorkFormWork?.Show();
            Form userForm = Application.OpenForms["UserApplicationInfoForWorkerForm"];
            userForm?.Close();
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
                { "{applicationNum}", MainWorkFormWorker.SelectedRowID?.ToString() ?? "-" },
                { "{day}", DateTime.Today.Day.ToString() },
                { "{month}", russianCulture.DateTimeFormat.GetMonthName(DateTime.Today.Month) },
                { "{year}", DateTime.Today.Year.ToString() },
            };
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
            string templateFileName = "Постановка на учет(плейсхолдеры).docx";
            string templatePath = Path.Combine(assemblyDirectory, subfolderName, templateFileName);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string newDocumentName = "Постановка на учет.docx";
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
        private static string DenialCompensationDocumentPath()
        {
            string assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string assemblyDirectory = Path.GetDirectoryName(assemblyPath);
            string subfolderName = "WordDocuments";
            string templateFileName = "Отказ в компенсации(плейсхолдеры).docx";
            string templatePath = Path.Combine(assemblyDirectory, subfolderName, templateFileName);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string newDocumentName = "Отказ в компенсации.docx";
            string newDocumentPath = Path.Combine(desktopPath, newDocumentName);
            // Создание копии шаблона
            File.Copy(templatePath, newDocumentPath, true);
            return newDocumentPath;
        }
        #endregion
        #region [Метод, создающий документ проблемы по пути рабочего стола]
        /// <summary>
        /// Метод, создающий документ проблемы по пути рабочего стола
        /// </summary>
        /// <returns></returns>
        private static string RefusalRegistrationDocumentPath()
        {
            string assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string assemblyDirectory = Path.GetDirectoryName(assemblyPath);
            string subfolderName = "WordDocuments";
            string templateFileName = "Отказ в постановке на учет(плейсхолдеры).docx";
            string templatePath = Path.Combine(assemblyDirectory, subfolderName, templateFileName);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string newDocumentName = "Отказ постановки на учет.docx";
            string newDocumentPath = Path.Combine(desktopPath, newDocumentName);
            // Создание копии шаблона
            File.Copy(templatePath, newDocumentPath, true);
            return newDocumentPath;
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
    }
}