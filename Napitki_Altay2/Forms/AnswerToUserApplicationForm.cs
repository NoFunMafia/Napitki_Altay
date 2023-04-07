#region [using's]
using Napitki_Altay2.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
#endregion

namespace Napitki_Altay2.Forms
{
    public partial class AnswerToUserApplicationForm : Form
    {
        #region [Подключение класса соединения с БД, объявление string переменных]
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        readonly SqlQueries sqlQueries = new SqlQueries();
        string fkInfoUser;
        string docName;
        string docExtension;
        string checkStatus;
        string fkApplicationDocumentFromWorker;
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
        private void ОтклоненоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusApplicationTextBox.Texts = "Отклонено";
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
                Filter = "Documents|*.docx;*.pdf;*.doc;*.xlsx"
            };
            openFileDialog.ShowDialog();
            DocumentWorkAnsTextBox.Texts = openFileDialog.FileName;
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
                using (Stream stream = File.OpenRead(filepath))
                {
                    GetDocumentInfo(filepath, stream, out byte[] buffer,
                        out string extension, out string name);
                    if (!CheckNameOfWorkerFile(name))
                        return;
                    InsertDocumentQuery(buffer, extension, name);
                }
                TakeDocumentIdInfo(out List<string[]> listSearchSecond);
                CheckDataRowsIdDocument(listSearchSecond);
                CreateAnswerWithDocument();
            }
        }
        #endregion
        #region [Метод, проверяющий уникальность названия прикрепляемого документа]
        /// <summary>
        /// Метод проверки уникальности названия прикрепляемого документа
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Boolean CheckNameOfWorkerFile(string name)
        {
            string filepath = DocumentWorkAnsTextBox.Texts;
            using (Stream stream = File.OpenRead(filepath))
            {
                string sqlQuery = sqlQueries.SqlComCheckDocumentNameWorker(name);
                List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuery, 4);
                if (listSearch != null && listSearch.Count > 0)
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
            string sqlQueryThree = sqlQueries.SqlComUpdateStatus
                (checkStatus, MainWorkFormWorker.SelectedRowID);
            dataBaseWork.WithoutOutputQuery(sqlQueryThree);
            string sqlQueryFourth = sqlQueries.SqlComCreateReadyApplicationWithoutDocument
                (MainWorkFormWorker.SelectedRowID, fkInfoUser,
                DescripWorkAnsTextBox.Texts, ApplAnsWorkDTP.Value);
            bool checkInsert = dataBaseWork.WithoutOutputQuery(sqlQueryFourth);
            if (checkInsert)
            {
                MessageBox.Show("Ответ на обращение создан!",
                    "Информация", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
        #endregion
    }
}