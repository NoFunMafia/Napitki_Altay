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
using System.Drawing;
using System.Diagnostics;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class SupplementForm : Form
    {
        #region [Переменные и классы]
        private List<Tuple<string, byte[], string>> documentList = new List<Tuple<string, byte[], string>>();
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        readonly SqlQueries sqlQueries = new SqlQueries();
        #endregion
        public SupplementForm()
        {
            InitializeComponent();
            this.Size = new Size((int)(1645 / 1.98), (int)(1888 / 1.93));
            Location = new Point(40, 30);
            DoubleBuffered = true; // Включение двойной буферизации
        }
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
            //DocumentTextBox.Texts = "";
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
            LoadDocumentsToListBox(); // Загрузка документов в ListBox
        }
        #endregion
        #region [Событие нажатия на кнопку PlusSupButton]
        private void PlusSupButton_Click(object sender, EventArgs e)
        {
            ////string filepath = DocumentTextBox.Texts;
            //if (string.IsNullOrEmpty(TypeApplTextBox.Texts))
            //{
            //    CreateSupplement();
            //}
            //else
            //{
            //    if (string.IsNullOrEmpty(DescripTextBox.Texts))
            //    {
            //        MessageBox.Show("Не все поля заполнены!",
            //            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        using (Stream stream = File.OpenRead(documentPath))
            //        {
            //            //GetDocumentInfo(filepath, stream, out byte[] buffer,
            //            //    out string extension, out string name);
            //            //UpdateDocumentQuery(buffer, extension, name);
            //        }
            //        CreateSupplement();
            //    }
            //}
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
            return dataBaseWork.GetMultiList(sqlQuery, 6);
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
                    TypeApplTextBox.Texts = item[1];
                    DescripTextBox.Texts = item[3];
                    ApplDTP.Text = item[4];
                }
            }
            else
            {
                TypeApplTextBox.Texts = "";
                DescripTextBox.Texts = "";
            }
        }
        #endregion
        #region [Метод загрузки документов в ListBox]
        private void LoadDocumentsToListBox()
        {
            try
            {
                string sqlQuery = sqlQueries.SqlComGetResponseDocumentsUser(MainWorkForm.selectedRowIDInDGWC);
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
        public void DisableControls()
        {
            ChooseDocumentButton.Enabled = false;
            DeleteDocumentButton.Enabled = false;
            DescripTextBox.ReadOnly = true;
            PlusSupButton.Enabled = false;
            PlusSupButton.Visible = false;
            CancelSupButton.Text = "Закрыть обращение";
            SelectDocumentLabel.Text = "Прикрепленный файл к ответу:";
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