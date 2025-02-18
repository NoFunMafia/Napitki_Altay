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
using System.Diagnostics;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class SupplementWorkForm : Form
    {
        #region [Переменные и классы]
        private List<Tuple<string, byte[], string>> documentList = new List<Tuple<string, byte[], string>>();
        readonly SqlQueries sqlQueries = new SqlQueries();
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        #endregion
        public SupplementWorkForm()
        {
            Location = new Point(900, 30);
            InitializeComponent();
            this.Size = new Size((int)(1645 / 1.98), (int)(1888 / 1.85));
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
            AnswerApplButton.Visible = false;
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
            LoadDocumentsToListBox(); // Загрузка документов в ListBox
        }
        #region [Метод, заполняющий List список из sql-запроса]
        /// <summary>
        /// Метод, заполняющий List список из sql-запроса
        /// </summary>
        /// <returns></returns>
        private List<string[]> GetApplicationInfoQuery()
        {
            string sqlQuery = sqlQueries.SqlComOpenWorkerAnswer(MainWorkFormWorker.SelectedRowID);
            return dataBaseWork.GetMultiList(sqlQuery, 6);
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
                    StatusApplicationTextBox.Texts = item[2];
                    DescripWorkAnsTextBox.Texts = item[3];
                    ApplAnsWorkDTP.Text = item[4];
                }
            }
            else
            {
                StatusApplicationTextBox.Texts = "";
                DescripWorkAnsTextBox.Texts = "";
            }
        }
        #endregion
        #region [Метод загрузки документов в ListBox]
        private void LoadDocumentsToListBox()
        {
            try
            {
                string sqlQuery = sqlQueries.SqlComGetResponseDocuments(MainWorkFormWorker.SelectedRowID);
                SqlCommand command = new SqlCommand(sqlQuery, dataBaseWork.GetConnection());

                dataBaseWork.OpenConnection();
                SqlDataReader reader = command.ExecuteReader();

                DocumentListBox.Items.Clear();
                documentList.Clear(); // Очистка списка документов

                while (reader.Read())
                {
                    string name = reader["Document_Name"].ToString();
                    byte[] data = (byte[])reader["Document_Data"];
                    string extension = reader["Document_Extension"].ToString();

                    documentList.Add(new Tuple<string, byte[], string>(name, data, extension));
                    DocumentListBox.Items.Add(name);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки документов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataBaseWork.CloseConnection();
            }
        }
        #endregion
        private void AnswerApplButton_Click(object sender, EventArgs e)
        {
            //string filepath = DocumentWorkAnsTextBox.Texts;
            //if (string.IsNullOrEmpty(DocumentWorkAnsTextBox.Texts))
            //{
            //    CreateSupplementWorker();
            //    SendAnEmail();
            //}
            //else
            //{
            //    if (string.IsNullOrEmpty(DescripWorkAnsTextBox.Texts) 
            //        || string.IsNullOrEmpty(StatusApplicationTextBox.Texts))
            //    {
            //        MessageBox.Show("Не все поля заполнены!",
            //            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        using (Stream stream = File.OpenRead(documentPath))
            //        {
            //            GetDocumentInfo(filepath, stream, out byte[] buffer,
            //                out string extension, out string name);
            //            UpdateDocumentQuery(buffer, extension, name);
            //        }
            //        CreateSupplementWorker();
            //        SendAnEmail();
            //    }
            //}
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
        private void CheckFkIdUser(out List<string[]> listSearch)
        {
            string sqlQuery = sqlQueries.sqlComFkInfoWorkUser;
            listSearch = dataBaseWork.GetMultiList(sqlQuery, 4);
        }
        private void DeleteAnsWorkDocumentButton_Click(object sender, EventArgs e)
        {

        }
        private void ChooseAnsWorkDocumentButton_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog
            //{
            //    Filter = "Документы|*.docx;*.doc;*.xlsx;*.xls;*.pdf"
            //};
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string fileName = Path.GetFileName(openFileDialog.FileName);
            //    //DocumentWorkAnsTextBox.Texts = fileName;
            //    documentPath = openFileDialog.FileName;
            //}
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
        #region [Открытие выбранного документа]
        private void OpenSelectedDocument()
        {
            if (DocumentListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите документ для открытия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fileName = DocumentListBox.SelectedItem.ToString();
            var document = documentList.FirstOrDefault(d => d.Item1 == fileName);

            if (document != null)
            {
                string tempFilePath = Path.Combine(Path.GetTempPath(), document.Item1);

                try
                {
                    File.WriteAllBytes(tempFilePath, document.Item2);
                    Process.Start(tempFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при открытии документа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void OpenDocumentButton_Click(object sender, EventArgs e)
        {
            OpenSelectedDocument();
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
                    //userFam = item[1];
                    //userName = item[2];
                    //userOtch = item[3];
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
            //return new Dictionary<string, string>
            //{
            //    { "{applicationNumber}", MainWorkFormWorker.SelectedRowID?.ToString() ?? "Неизвестно" },
            //    //{ "{companyName}", UserApplicationInfoForWorkerForm.companyWork?.ToString() ?? "Неизвестно" },
            //    { "{imya}", userName?.Substring(0, 1).ToString() ?? "Неизвестно" },
            //    { "{famFull}", userFam?.ToString().ToString() ?? "Неизвестно" },
            //    { "{otch}", userOtch?.Substring(0, 1).ToString() ?? "Неизвестно"},
            //    { "{day}", DateTime.Today.Day.ToString() },
            //    { "{monthName}", russianCulture.DateTimeFormat.GetMonthName(DateTime.Today.Month) },
            //    { "{year}", DateTime.Today.Year.ToString() },
            //    { "{dayFiling}", UserApplicationInfoForWorkerForm.dateTimeWork.Day.ToString() },
            //    { "{monthFiling}", russianCulture.DateTimeFormat.GetMonthName
            //    (UserApplicationInfoForWorkerForm.dateTimeWork.Month).ToString() },
            //    { "{yearFiling}", UserApplicationInfoForWorkerForm.dateTimeWork.Year.ToString() }
            //};
            return new Dictionary<string, string>();
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