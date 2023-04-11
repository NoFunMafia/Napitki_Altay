#region [using's]
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Napitki_Altay2.Classes;
using System.Collections.Generic;
using MimeKit;
using MailKit.Net.Smtp;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class CreateApplicationForm : Form
    {
        #region [Подключение классов, обьявление переменных]
        // Использование класса работы с БД
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        // Класс запросов в БД
        readonly SqlQueries sqlQueries = new SqlQueries();
        string fkInfoUser;
        string fkDocumentId;
        string checkType;
        string documentName;
        string documentExtansion;
        #endregion
        public CreateApplicationForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Событие нажатия на кнопку CancelApplButton]
        /// <summary>
        /// Событие нажатия на кнопку CancelApplButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelApplButton_Click(object sender, EventArgs e)
        {
            MainWorkForm mainWorkForm = new MainWorkForm();
            mainWorkForm.Show();
            Close();
        }
        #endregion
        #region [Событие нажатия на кнопку RegApplButton]
        /// <summary>
        /// Событие нажатия на кнопку RegApplButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegApplButton_Click(object sender, EventArgs e)
        {
            TakeFilePathAndList(out string filePath, out List<string[]> listSearch);
            CheckDataReaderRowsInfo(listSearch);
            if (string.IsNullOrEmpty(DocumentTextBox.Texts))
            {
                CreateApplicationWithoutDocument();
                SendAnEmail();
            }
            else
            {
                if (string.IsNullOrEmpty(CompanyTextBox.Texts)
                    || string.IsNullOrEmpty(TypeApplTextBox.Texts)
                    || string.IsNullOrEmpty(DescripTextBox.Texts))
                {
                    MessageBox.Show("Не все поля заполнены!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    using (Stream stream = File.OpenRead(filePath))
                    {
                        GetDocumentInfo(filePath, stream, out byte[] buffer,
                            out string extension, out string name);
                        if (!CheckNameOfUserFile(name))
                            return;
                        InsertDocumentQuery(buffer, extension, name);
                    }
                    TakeDocumentIdInfo(out List<string[]> listSearchSecond);
                    CheckDataRowsIDDocument(listSearchSecond);
                    CreateApplicationWithDocument();
                    SendAnEmail();
                }
            }
        }
        #endregion
        #region [Метод, получающий значение email пользователя]
        private string GetEmailUser(string idUser)
        {
            string sqlQueryEmail = "select Email from Authentication_ " +
                "join Info_About_User on Authentication_.FK_Info_User = " +
                $"Info_About_User.ID_Info_User where FK_Info_User = '{idUser}'";
            string emailAdress = dataBaseWork.GetString(sqlQueryEmail);
            return emailAdress;
        }
        #endregion
        #region [Метод, отправляющий email уведомление о добавлении обращения]
        private void SendAnEmail()
        {
            MimeMessage mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("Волчихинский Пивоваренный Завод",
                "napitki-altay@mail.ru"));
            mimeMessage.To.Add(MailboxAddress.Parse(GetEmailUser(fkInfoUser)));
            mimeMessage.Subject = $"Заявление успешно создано!";
            mimeMessage.Body = new TextPart("html")
            {
                Text = $"<h1>Спасибо за создание обращения в приложении Напитки Алтая!</h1>" +
                "<p>Оно было успешно отправлено на предприятие. Мы приложим все усилия для его скорейшей обработки и ответа на ваш запрос.</p>" +
                "<p>С уважением,<br>Команда «Волчихинского пивоваренного завода»</p>"
            };
            SmtpClient smtpClient = new SmtpClient();
            try
            {
                smtpClient.Connect("smtp.mail.ru", 465, true);
                smtpClient.Authenticate("napitki-altay@mail.ru", "5TGsxjXKrXYpVxeajrgY");
                smtpClient.Send(mimeMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                smtpClient.Disconnect(true);
                smtpClient.Dispose();
            }
        }
        #endregion
        #region [События работы с ToolStripMenu, выбор типа обращения]
        /// <summary>
        /// Событие нажатия на картинку с последующим 
        /// действием выпадающего элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseTypeApplPictureBox_Click
            (object sender, EventArgs e)
        {
            TypeApplMenuStrip.Show(ChooseTypeApplPictureBox,
                new Point(0, ChooseTypeApplPictureBox.Height));
        }
        /// <summary>
        /// Событие нажатия на кнопку "Сотрудничество" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void СотрудничествоToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            TypeApplTextBox.Texts = "Сотрудничество";
        }
        /// <summary>
        /// Событие нажатия на кнопку 
        /// "Обсуждение проблемы" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ОбсуждениеПроблемыToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            TypeApplTextBox.Texts = "Обсуждение проблемы";
        }
        /// <summary>
        /// Событие нажатия на кнопку 
        /// "Ознакомление с каталогом продукции" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ОзнакомлениеСКаталогомПродукцииToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            TypeApplTextBox.Texts = "Вопросы по каталогу продукции";
        }
        /// <summary>
        /// Событие нажатия на кнопку 
        /// "Письмо-притензия" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ПисьмопритензияToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            TypeApplTextBox.Texts = "Письмо-претензия";
        }
        /// <summary>
        /// Событие нажатия на кнопку 
        /// "Письмо-благодарность" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ПисьмоблагодарностьToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            TypeApplTextBox.Texts = "Письмо-благодарность";
        }
        #endregion
        #region [Событие нажатия на кнопку ChooseDocumentButton]
        /// <summary>
        /// Событие нажатия на кнопку ChooseDocumentButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseDocumentButton_Click
            (object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Documents|*.docx;*.pdf;*.doc;*.xlsx"
            };
            openFileDialog.ShowDialog();
            DocumentTextBox.Texts = openFileDialog.FileName;
        }
        #endregion
        #region [Событие нажатия на кнопку DeleteDocumentButton]
        private void DeleteDocumentButton_Click(object sender, EventArgs e)
        {
            DocumentTextBox.Texts = "";
        }
        #endregion
        #region [Событие закрытия формы]
        /// <summary>
        /// Событие закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateApplicationForm_FormClosed
            (object sender, FormClosedEventArgs e)
        {
            MainWorkForm mainWorkForm = new MainWorkForm();
            mainWorkForm.Show();
        }
        #endregion
        #region [Метод, отправляющий sql-запрос на создание обращения с документом]
        /// <summary>
        /// Метод, отправляющий sql-запрос на создание обращения с документом
        /// </summary>
        private void CreateApplicationWithDocument()
        {
            string sqlQuerySecond = sqlQueries.SqlComCheckTypeID(TypeApplTextBox.Texts);
            checkType = dataBaseWork.GetString(sqlQuerySecond);
            string sqlQuerySix = sqlQueries.SqlComAddApplicationSecond
                (CompanyTextBox.Texts, checkType, DescripTextBox.Texts,
                ApplDTP.Value, fkInfoUser, fkDocumentId);
            bool checkInsertApplication = dataBaseWork.WithoutOutputQuery(sqlQuerySix);
            if (checkInsertApplication)
            {
                MessageBox.Show("Обращение создано!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                MainWorkForm mainWorkForm = new MainWorkForm();
                mainWorkForm.Show();
            }
        }
        #endregion
        #region [Метод, принимающий значение id документа из sql-запроса]
        /// <summary>
        /// Метод, принимающий значение id документа из sql-запроса
        /// </summary>
        /// <param name="listSearchSecond"></param>
        private void TakeDocumentIdInfo(out List<string[]> listSearchSecond)
        {
            string sqlQueryFive = sqlQueries.SqlComInfoAboutDocument
                (documentName, documentExtansion);
            listSearchSecond = dataBaseWork.GetMultiList(sqlQueryFive, 4);
        }
        #endregion
        #region [Метод, отправляющий sql-запрос на внесение документа]
        /// <summary>
        /// Метод, отправляющий sql-запрос на внесение документа
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="extension"></param>
        /// <param name="name"></param>
        private void InsertDocumentQuery(byte[] buffer, string extension, string name)
        {
            string sqlQueryFour = sqlQueries.SqlComAddDocument(fkInfoUser);
            documentName = name;
            documentExtansion = extension;
            try
            {
                dataBaseWork.OpenConnection();
                SqlCommand sqlCommand = new SqlCommand
                    (sqlQueryFour, dataBaseWork.GetConnection());
                sqlCommand.Parameters.Add("@fileName", SqlDbType.VarChar).Value = name;
                sqlCommand.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                sqlCommand.Parameters.Add("@extension", SqlDbType.Char).Value = extension;
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
        }
        #endregion
        #region [Метод, получающий информацию о прикрепляемом документе]
        /// <summary>
        /// Метод, получающий информацию о прикрепляемом документе
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="stream"></param>
        /// <param name="buffer"></param>
        /// <param name="extension"></param>
        /// <param name="name"></param>
        private static void GetDocumentInfo(string filePath, Stream stream, 
            out byte[] buffer, out string extension, out string name)
        { 
            buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);
            var fileInfo = new FileInfo(filePath);
            extension = fileInfo.Extension;
            name = fileInfo.Name;
        }
        #endregion
        #region [Метод, отправляющий sql-запрос на создание обращения без документа]
        /// <summary>
        /// Метод, отправляющий sql-запрос на создание обращения без документа
        /// </summary>
        private void CreateApplicationWithoutDocument()
        {
            if (string.IsNullOrEmpty(CompanyTextBox.Texts)
                || string.IsNullOrEmpty(TypeApplTextBox.Texts)
                || string.IsNullOrEmpty(DescripTextBox.Texts))
            {
                MessageBox.Show("Не все поля заполнены!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                string sqlQuerySecond = sqlQueries.SqlComCheckTypeID(TypeApplTextBox.Texts);
                checkType = dataBaseWork.GetString(sqlQuerySecond);
                string sqlQueryThree = sqlQueries.SqlComAddApplication
                    (CompanyTextBox.Texts, checkType,
                    DescripTextBox.Texts, ApplDTP.Value, fkInfoUser);
                bool checkInsertQuery = dataBaseWork.WithoutOutputQuery(sqlQueryThree);
                if (checkInsertQuery)
                {
                    MessageBox.Show("Обращение создано!", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    MainWorkForm mainWorkForm = new MainWorkForm();
                    mainWorkForm.Show();
                }
            }
        }
        #endregion
        #region [Метод, заполняющий переменную пути к документу и List список из sql-запроса]
        /// <summary>
        /// Метод, заполняющий переменную пути 
        /// к документу и List список из sql-запроса
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="listSearch"></param>
        private void TakeFilePathAndList(out string filePath, out List<string[]> listSearch)
        {
            filePath = DocumentTextBox.Texts;
            string sqlQuery = sqlQueries.sqlComFkInfoUser;
            listSearch = dataBaseWork.GetMultiList(sqlQuery, 4);
        }
        #endregion
        #region [Метод проверки уникальности названия прикрепляемого документа]
        /// <summary>
        /// Метод проверки уникальности названия прикрепляемого документа
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Boolean CheckNameOfUserFile(string name)
        {
            string filepath = DocumentTextBox.Texts;
            using (Stream stream = File.OpenRead(filepath))
            {
                string sqlQuery = sqlQueries.SqlComCheckDocumentName(name);
                List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 4);
                if(listSearch != null && listSearch.Count > 0)
                {
                    MessageBox.Show("Переименуйте файл! " +
                        "Данное название уже присутствует в базе данных!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
        }
        #endregion
        #region [Метод получения ID пользователя при составлении обращения]
        /// <summary>
        /// Метод получения ID пользователя при составлении обращения
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
        #region [Метод получения ID документа]
        /// <summary>
        /// Метод получения ID документа
        /// </summary>
        /// <param name="datareader"></param>
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
        #endregion
    }
}