#region [using's]
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using Napitki_Altay2.Classes;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
#endregion
namespace Napitki_Altay2.Forms
{   
    public partial class ReadyApplicationInfoForUserForm : Form
    {
        #region [Подключение классов, объявление переменных]
        readonly SqlQueries sqlQueries = new SqlQueries();
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        private Dictionary<string, byte[]> documentData = new Dictionary<string, byte[]>(); // Хранит данные всех документов
        #endregion
        public ReadyApplicationInfoForUserForm()
        {
            InitializeComponent();
            this.Size = new Size((int)(1645 / 1.98), (int)(1888 / 1.93));
        }
        #region [Событие закрытия формы]
        /// <summary>
        /// Событие закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadyApplicationInfoForUserForm_FormClosed
            (object sender, FormClosedEventArgs e)
        {
            // Найдите открытую форму MainWorkFormWorker
            MainWorkForm mainWorkForm = Application.OpenForms.OfType<MainWorkForm>().FirstOrDefault();
            // Если форма найдена, вызовите методы обновления
            mainWorkForm?.Show();
            Form supForm = Application.OpenForms["SupplementForm"];
            supForm?.Close();
        }
        #endregion
        #region [Событие загрузки формы]
        /// <summary>
        /// Событие загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadyApplicationInfoForUserForm_Load(object sender, EventArgs e)
        {
            List<string[]> listSearch = GetApplicationInfoQuery();
            CheckDataReaderRowsInfo(listSearch);
            LoadDocumentsList();
        }
        #endregion
        #region [Метод загрузки списка документов в ListBox]
        private void LoadDocumentsList()
        {
            DocumentListBox.Items.Clear();
            documentData.Clear();
            try
            {
                string sqlQuery = sqlQueries.SqlComOpenWorkerDocument(MainWorkForm.selectedRowIDInDGWC);
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, dataBaseWork.GetConnection()))
                {
                    sqlCommand.Parameters.AddWithValue("@idRow", MainWorkForm.selectedRowIDInDGWC);
                    dataBaseWork.OpenConnection();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            string docName = dataReader["Document_Name"].ToString();
                            byte[] docData = (byte[])dataReader["Document_Data"];
                            documentData[docName] = docData;
                            DocumentListBox.Items.Add(docName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки документов: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataBaseWork.CloseConnection();
            }
        }
        #endregion
        #region [Событие нажатия на кнопку OpenPinDocumentButton]
        private void OpenPinDocumentButton_Click(object sender, EventArgs e)
        {
            if (DocumentListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите документ для открытия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFile(DocumentListBox.SelectedItem.ToString());
        }
        #endregion
        #region [Событие нажатия на кнопку CloseCompleteApplicationButton]
        /// <summary>
        /// Событие нажатия на кнопку CloseCompleteApplicationButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseCompleteApplicationButton_Click(object sender, EventArgs e)
        {
            Close();
            Form supForm = Application.OpenForms["SupplementForm"];
            supForm?.Close();
        }
        #endregion
        #region [Метод, открывающий прикрепленный документ]
        /// <summary>
        /// Метод, открывающий прикрепленный документ
        /// </summary>
        private void OpenFile(string documentName)
        {
            try
            {
                if (!documentData.ContainsKey(documentName))
                {
                    MessageBox.Show("Документ не найден в данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] data = documentData[documentName];
                string extn = Path.GetExtension(documentName);
                string newFileName = Path.GetFileNameWithoutExtension(documentName) +
                                     DateTime.Now.ToString("ddMMyyyyhhmmss") + extn;

                File.WriteAllBytes(newFileName, data);
                Process.Start(newFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии документа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    TypeAppealAnswerTextBox.Texts = item[1];
                    StatusCompleteTextBox.Texts = item[2];
                    DescripCompleteTextBox.Texts = item[3];
                    ApplCompleteDTP.Text = DateTime.Parse(item[4]).ToString();
                }
            }
            else
            {
                TypeAppealAnswerTextBox.Texts = "";
                StatusCompleteTextBox.Texts = "";
                DescripCompleteTextBox.Texts = "";
                ApplCompleteDTP.Text = "";
            }
        }
        #endregion
        #region [Метод, заполняющий List список из sql-запроса]
        /// <summary>
        /// Метод, заполняющий List список из sql-запроса
        /// </summary>
        /// <returns></returns>
        private List<string[]> GetApplicationInfoQuery()
        {
            string sqlQuerySecond = sqlQueries.SqlComOpenWorkerAnswer
                (MainWorkForm.selectedRowIDInDGWC);
            List<string[]> listSearch = dataBaseWork.GetMultiList(sqlQuerySecond, 6);
            return listSearch;
        }
        #endregion
        /// <summary>
        /// Метод для скачивания документа по выбранному пути
        /// </summary>
        /// <param name="documentName">Имя документа</param>
        /// <summary>
        /// Метод для скачивания всех документов из ListBox в выбранную папку
        /// </summary>
        private void DownloadAllFiles()
        {
            try
            {
                if (DocumentListBox.Items.Count == 0)
                {
                    MessageBox.Show("Нет документов для скачивания!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Открываем диалог выбора папки
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Выберите папку для сохранения документов";
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = folderDialog.SelectedPath;
                        int downloadedCount = 0;

                        foreach (var item in DocumentListBox.Items)
                        {
                            string documentName = item.ToString();

                            if (documentData.ContainsKey(documentName))
                            {
                                byte[] data = documentData[documentName];
                                string newFileName = Path.Combine(selectedPath, documentName);

                                // Проверка на существование файла и перезапись
                                if (File.Exists(newFileName))
                                {
                                    var result = MessageBox.Show($"Файл {documentName} уже существует. Перезаписать?",
                                        "Подтверждение",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

                                    if (result == DialogResult.No)
                                        continue;
                                }

                                File.WriteAllBytes(newFileName, data);
                                downloadedCount++;
                            }
                        }

                        MessageBox.Show($"Скачано документов: {downloadedCount}",
                            "Успешное скачивание",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при скачивании документов: " + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void DownloadDocUserButton_Click(object sender, EventArgs e)
        {
            DownloadAllFiles();
        }
    }
}
