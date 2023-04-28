#region [using's]
using Napitki_Altay2.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Globalization;
using Point = System.Drawing.Point;
using System.Linq;
using System.Text;
#endregion

namespace Napitki_Altay2.Forms
{
    public partial class AnswerToUserApplicationForm : Form
    {
        #region [Подключение класса соединения с БД, объявление string переменных]
        string documentPath;
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        readonly SqlQueries sqlQueries = new SqlQueries();
        string fkInfoUser, docName, docExtension, checkStatus, 
            fkApplicationDocumentFromWorker, userFam, userName, userOtch;
        readonly CultureInfo russianCulture = new CultureInfo("ru-RU");
        #endregion
        public AnswerToUserApplicationForm()
        {
            Location = new Point(740, 90);
            InitializeComponent();
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
        private void ЗавершеноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusApplicationTextBox.Texts = "Завершено";
        }
        private void ОжиданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusApplicationTextBox.Texts = "Ожидание доп. информации";
        }
        #endregion
        #region [Событие нажатия на кнопку ChooseAnsWorkDocumentButton]
        /// <summary>
        /// Событие нажатия на кнопку ChooseAnsWorkDocumentButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseAnsWorkDocumentButton_Click
            (object sender, EventArgs e)
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
        #endregion
        #region [Событие нажатия на кнопку DeleteAnsWorkDocumentButton]
        /// <summary>
        /// Событие нажатия на кнопку DeleteAnsWorkDocumentButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAnsWorkDocumentButton_Click
            (object sender, EventArgs e)
        {
            DocumentWorkAnsTextBox.Texts = "";
        }
        #endregion
        #region [Событие нажатия на кнопку AnswerApplButton]
        /// <summary>
        /// Событие нажатия на кнопку AnswerApplButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerApplButton_Click(object sender, EventArgs e)
        {
            TakeWorkerId(out List<string[]> listSearch);
            CheckDataReaderRowsInfo(listSearch);
            string filepath = DocumentWorkAnsTextBox.Texts;
            if (string.IsNullOrEmpty(DocumentWorkAnsTextBox.Texts))
            {
                CreateAnswerWithoutDocument();
            }
            else
            {
                if (string.IsNullOrEmpty(StatusApplicationTextBox.Texts)
                    || string.IsNullOrEmpty(DescripWorkAnsTextBox.Texts))
                {
                    MessageBox.Show("Не все поля заполнены!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                using (Stream stream = File.OpenRead(documentPath))
                {
                    GetDocumentInfo(filepath, stream, out byte[] buffer,
                        out string extension, out string name);
                    InsertDocumentQuery(buffer, extension, name);
                }
                TakeDocumentIdInfo(out List<string[]> listSearchSecond);
                CheckDataRowsIdDocument(listSearchSecond);
                CreateAnswerWithDocument();
            }
        }
        #endregion
        #region [Событие нажатия на кнопку HelpCollaborationButton]
        /// <summary>
        /// Событие нажатия на кнопку HelpCollaborationButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        #endregion
        #region [Событие нажатия на кнопку HelpThanksButton]
        /// <summary>
        /// Событие нажатия на кнопку HelpThanksButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        #endregion
        #region [Событие нажатия на кнопку HelpDiscussionButton]
        /// <summary>
        /// Событие нажатия на кнопку HelpDiscussionButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        #endregion
        #region [Метод, получающий ID пользователя при составлении обращения]
        /// <summary>
        /// Метод получения ID пользователя при составлении ответа на обращение
        /// </summary>
        /// <param name="datareader"></param>
        private void CheckDataReaderRowsInfo(List<string[]> strings)
        {
            if (strings != null)
            {
                foreach (string[] item in strings)
                {
                    fkInfoUser = item[0];
                }
            }
        }
        #endregion
        #region [Метод, получающий ID документа]
        /// <summary>
        /// Метод, получающий ID документа
        /// </summary>
        /// <param name="strings"></param>
        private void CheckDataRowsIdDocument(List<string[]> strings)
        {
            if (strings != null)
            {
                foreach (string[] item in strings)
                {
                    fkApplicationDocumentFromWorker = item[0];
                }
            }
        }
        #endregion
        #region [Метод, создающий ответ с прикрепленным документом]
        /// <summary>
        /// Метод, создающий ответ с прикрепленным документом
        /// </summary>
        private void CreateAnswerWithDocument()
        {
            string sqlQuerySeven = sqlQueries.SqlComCheckStatusID
                (StatusApplicationTextBox.Texts);
            checkStatus = dataBaseWork.GetString(sqlQuerySeven);
            string sqlQueryEight = sqlQueries.SqlComUpdateStatus
                (checkStatus, MainWorkFormWorker.SelectedRowID);
            dataBaseWork.WithoutOutputQuery(sqlQueryEight);
            string sqlQueryNine = sqlQueries.SqlComCreateReadyApplicationWithDocument
                (MainWorkFormWorker.SelectedRowID, fkInfoUser,
                DescripWorkAnsTextBox.Texts, ApplAnsWorkDTP.Value,
                fkApplicationDocumentFromWorker);
            bool checkInsertAnswer = dataBaseWork.WithoutOutputQuery(sqlQueryNine);
            if (checkInsertAnswer)
            {
                MessageBox.Show("Ответ на обращение создан!",
                "Информация", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                // Найдите открытую форму MainWorkFormWorker
                MainWorkFormWorker mainWorkFormWork = Application.OpenForms.OfType<MainWorkFormWorker>().FirstOrDefault();
                // Если форма найдена, вызовите методы обновления
                if (mainWorkFormWork != null)
                {
                    mainWorkFormWork.LoadDataInDataGridViewAnswer();
                    mainWorkFormWork.LoadDataInCompleteApplicationDGW();
                }
                Close();
                Form userForm = Application.OpenForms["UserApplicationInfoForWorkerForm"];
                userForm?.Close();
            }
        }
        #endregion
        #region [Метод, заполняющий List список информации о внесенном документе]
        /// <summary>
        /// Метод, заполняющий List список информации о внесенном документе
        /// </summary>
        /// <param name="listSearchSecond"></param>
        private void TakeDocumentIdInfo(out List<string[]> listSearchSecond)
        {
            string sqlQuerySix = sqlQueries.SqlComInfoAboutDocumentWorker
                (docName, docExtension);
            listSearchSecond = dataBaseWork.GetMultiList(sqlQuerySix, 4);
        }
        #endregion
        #region [Метод, вносящий прикрепляемый файл в БД]
        /// <summary>
        /// Метод, вносящий прикрепляемый файл в БД
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="extn"></param>
        /// <param name="name"></param>
        private void InsertDocumentQuery(byte[] buffer, string extn, string name)
        {
            string sqlQueryFifth = sqlQueries.SqlComInsertWorkerDoc(fkInfoUser);
            docName = name;
            docExtension = extn;
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
        #region [Метод, создающий ответ без прикрепленного документа]
        /// <summary>
        /// Метод, создающий ответ без прикрепленного документа
        /// </summary>
        private void CreateAnswerWithoutDocument()
        {
            if (string.IsNullOrEmpty(StatusApplicationTextBox.Texts)
                | string.IsNullOrEmpty(DescripWorkAnsTextBox.Texts))
            {
                MessageBox.Show("Не все поля заполнены!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sqlQuerySecond = sqlQueries.SqlComCheckStatusID
                (StatusApplicationTextBox.Texts);
            checkStatus = dataBaseWork.GetString(sqlQuerySecond);
            string sqlQueryFourth = sqlQueries.SqlComUpdateStatus
                (checkStatus, MainWorkFormWorker.SelectedRowID);
            dataBaseWork.WithoutOutputQuery(sqlQueryFourth);
            string sqlQueryFive = sqlQueries.SqlComCreateReadyApplicationWithoutDocument
                (MainWorkFormWorker.SelectedRowID, fkInfoUser,
                DescripWorkAnsTextBox.Texts, ApplAnsWorkDTP.Value);
            bool checkInsert = dataBaseWork.WithoutOutputQuery(sqlQueryFive);
            if (checkInsert)
            {
                MessageBox.Show("Ответ на обращение создан!",
                    "Информация", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // Найдите открытую форму MainWorkFormWorker
                MainWorkFormWorker mainWorkFormWork = Application.OpenForms.OfType<MainWorkFormWorker>().FirstOrDefault();
                // Если форма найдена, вызовите методы обновления
                if (mainWorkFormWork != null)
                {
                    mainWorkFormWork.LoadDataInDataGridViewAnswer();
                    mainWorkFormWork.LoadDataInCompleteApplicationDGW();
                }
                Close();
                Form userForm = Application.OpenForms["UserApplicationInfoForWorkerForm"];
                userForm?.Close();
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
        #region [Метод, получающий ID сотрудника-ответчика]
        private void TakeWorkerId(out List<string[]> listSearch)
        {
            string sqlQueryFirst = sqlQueries.SqlComTakeFkInfoWorker
                (MainWorkFormWorker.NameWorkerString,
                MainWorkFormWorker.SurnameWorkerString,
                MainWorkFormWorker.PatrWorkerString);
            listSearch = dataBaseWork.GetMultiList(sqlQueryFirst, 4);
        }

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
                { "{applicationNumber}", MainWorkFormWorker.SelectedRowID?.ToString() ?? "Неизвестно" },
                { "{companyName}", UserApplicationInfoForWorkerForm.companyWork?.ToString() ?? "Неизвестно" },
                { "{imya}", userName?.Substring(0, 1).ToString() ?? "Неизвестно" },
                { "{fam}", userFam?.Substring(0, 1).ToString() ?? "Неизвестно" },
                { "{otchFull}", userOtch?.ToString() ?? "Неизвестно"},
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
            string templateFileName = "Пример для составления ответа на проблему.docx";
            string templatePath = Path.Combine(assemblyDirectory, subfolderName, templateFileName);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string newDocumentName = "Ответ на проблему.docx";
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