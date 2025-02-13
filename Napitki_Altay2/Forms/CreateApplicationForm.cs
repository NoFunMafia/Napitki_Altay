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
using System.Linq;
using System.Net.Sockets;
using System.Threading;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class CreateApplicationForm : Form
    {
        #region [Подключение классов, обьявление переменных]
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        readonly SqlQueries sqlQueries = new SqlQueries();
        private string fkInfoUser;
        private string checkType;
        private List<string> selectedFiles = new List<string>();
        #endregion
        public CreateApplicationForm()
        {
            InitializeComponent();
            this.Size = new Size((int)(1645 / 1.98), (int)(1888 / 1.93));
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
            // Найдите открытую форму MainWorkFormWorker
            MainWorkForm mainWorkForm = Application.OpenForms.OfType<MainWorkForm>().FirstOrDefault();
            // Если форма найдена, вызовите методы обновления
            mainWorkForm?.Show();
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
            fkInfoUser = dataBaseWork.GetString(sqlQueries.sqlComFkInfoUser);
            if (string.IsNullOrEmpty(TypeApplTextBox.Texts) || string.IsNullOrEmpty(DescripTextBox.Texts))
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            checkType = dataBaseWork.GetString(sqlQueries.SqlComCheckTypeID(TypeApplTextBox.Texts));
            // Создаем обращение и получаем ID
            string sqlCreateAppeal = sqlQueries.SqlComAddApplicationSecond(checkType, DescripTextBox.Texts, ApplDTP.Value, fkInfoUser);
            string newAppealId = dataBaseWork.GetString(sqlCreateAppeal);
            // Загружаем прикрепленные файлы
            if (selectedFiles.Any())
            {
                foreach (string filePath in selectedFiles)
                {
                    InsertDocumentQuery(filePath, newAppealId);
                }
            }
            MessageBox.Show("Обращение успешно создано!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SendAnEmail();
            MainWorkForm mainWorkForm = Application.OpenForms.OfType<MainWorkForm>().FirstOrDefault();
            mainWorkForm?.LoadDataGridView(); // Вызываем метод обновления DataGridView
            Close();
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
        /// Событие нажатия на кнопку "Компенсация" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void КомпенсацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeApplTextBox.Texts = "Компенсация родительской платы";
        }
        /// <summary>
        /// Событие нажатия на кнопку 
        /// "Постановка" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ПостановкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeApplTextBox.Texts = "Постановка на учет в образовательные организации";
        }
        /// <summary>
        /// Событие нажатия на кнопку 
        /// "Получение" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ПолучениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeApplTextBox.Texts = "Получение информации об образовании";
        }
        #endregion
        #region [Событие нажатия на кнопку ChooseDocumentButton]
        /// <summary>
        /// Событие нажатия на кнопку ChooseDocumentButton (выбор нескольких документов)
        /// </summary>
        private void ChooseDocumentButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Документы|*.docx;*.doc;*.xlsx;*.xls;*.pdf",
                Multiselect = true // Разрешаем выбирать несколько файлов
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    string fileName = Path.GetFileName(file);
                    if (!selectedFiles.Contains(file)) // Избегаем дубликатов
                    {
                        selectedFiles.Add(file);
                        DocumentListBox.Items.Add(fileName); // Добавляем в ListBox
                    }
                }
            }
        }
        #endregion
        #region [Очистка списка файлов]
        /// <summary>
        /// Очищает список прикрепленных документов
        /// </summary>
        private void ClearFilesButton_Click(object sender, EventArgs e)
        {
            selectedFiles.Clear(); // Очищаем список файлов
            DocumentListBox.Items.Clear(); // Очищаем ListBox
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
            // Найдите открытую форму MainWorkFormWorker
            MainWorkForm mainWorkForm = Application.OpenForms.OfType<MainWorkForm>().FirstOrDefault();
            // Если форма найдена, вызовите методы обновления
            mainWorkForm?.Show();
        }
        #endregion
        #region [Метод, получающий значение email пользователя]
        private string GetEmailUser(string idUser)
        {
            string sqlQueryEmail = "select Email from User_Auth " +
                "join User_Info on User_Auth.User_ID = " +
                $"User_Info.User_ID where User_Auth.User_ID = '{idUser}'";
            string emailAdress = dataBaseWork.GetString(sqlQueryEmail);
            return emailAdress;
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
                mimeMessage.To.Add(MailboxAddress.Parse(GetEmailUser(fkInfoUser)));
                mimeMessage.Subject = "Уведомление о подаче заявления";
                mimeMessage.Body = new TextPart("html")
                {
                    Text = "<h2>Ваше заявление успешно подано</h2>" +
                    "<p>Благодарим вас за обращение. Ваш запрос будет обработан в установленные сроки.</p>" +
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
                        MessageBox.Show("Не удалось отправить уведомление на указанную почту. Проверьте правильность данных или попробуйте позже.",
                            "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (SocketException)
                    {
                        MessageBox.Show("Ошибка соединения с почтовым сервером. Попробуйте позже.",
                            "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Не удалось отправить письмо. Это не повлияет на регистрацию заявления.",
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
                MessageBox.Show("Произошла непредвиденная ошибка при отправке письма. Ваше заявление зарегистрировано.",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region [Метод, отправляющий sql-запрос на внесение документа]
        /// <summary>
        /// Метод, отправляющий sql-запрос на внесение документа
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="extension"></param>
        /// <param name="name"></param>
        private void InsertDocumentQuery(string filePath, string appealId)
        {
            byte[] fileData;
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);

            using (Stream stream = File.OpenRead(filePath))
            {
                fileData = new byte[stream.Length];
                stream.Read(fileData, 0, fileData.Length);
            }
            string sqlInsertDocument = sqlQueries.SqlComAddDocument(fkInfoUser);
            try
            {
                dataBaseWork.OpenConnection();
                SqlCommand sqlCommand = new SqlCommand(sqlInsertDocument, dataBaseWork.GetConnection());
                sqlCommand.Parameters.Add("@fileName", SqlDbType.VarChar).Value = fileName;
                sqlCommand.Parameters.Add("@data", SqlDbType.VarBinary).Value = fileData;
                sqlCommand.Parameters.Add("@extension", SqlDbType.Char).Value = fileExtension;
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
            // Получаем ID загруженного документа
            string docId = dataBaseWork.GetString(sqlQueries.SqlComInfoAboutDocument(fileName, fileExtension, fkInfoUser));
            // Привязываем документ к обращению
            if (!string.IsNullOrEmpty(docId))
            {
                dataBaseWork.WithoutOutputQuerySecond(sqlQueries.LinkDocumentToAppealQuery(), new Dictionary<string, object>
                {
                    { "@AppealId", appealId },
                    { "@DocId", docId }
                });
            }
        }
        #endregion
        #region [Удаление конкретного файла из списка]
        /// <summary>
        /// Удаляет выбранный файл из списка при двойном клике
        /// </summary>
        private void DocumentListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DocumentListBox.SelectedIndex != -1)
            {
                string selectedFile = DocumentListBox.SelectedItem.ToString();
                string fullPath = selectedFiles.FirstOrDefault(f => Path.GetFileName(f) == selectedFile);
                if (fullPath != null)
                {
                    DialogResult result = MessageBox.Show("Вы уверены что хотите открепить выбранный файл?", "Внимание", 
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if(result == DialogResult.OK)
                    {
                        selectedFiles.Remove(fullPath);
                        DocumentListBox.Items.Remove(selectedFile);
                    }
                }
            }
        }
        #endregion
    }
}