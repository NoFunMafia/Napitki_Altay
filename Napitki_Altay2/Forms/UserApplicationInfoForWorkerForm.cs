#region [using's]
using Napitki_Altay2.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
#endregion

namespace Napitki_Altay2.Forms
{
    public partial class UserApplicationInfoForWorkerForm : Form
    {
        #region [Подключение классов, объявление переменных]
        // Использование класса работы с БД
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        // Класс запросов в БД
        readonly SqlQueries sqlQueries = new SqlQueries();
        public static string typeApplication;
        public static string description;
        public static DateTime dateTimeWork;
        private List<Tuple<string, byte[], string>> documentList = new List<Tuple<string, byte[], string>>();
        #endregion
        public UserApplicationInfoForWorkerForm()
        {
            Location = new Point(40, 30);
            InitializeComponent();
            this.Size = new Size((int)(1645 / 1.98), (int)(1888 / 1.93));
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Событие нажатия на кнопку CloseApplicWorkButton]
        /// <summary>
        /// Событие нажатия на кнопку CloseApplicWorkButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseApplicWorkButton_Click(object sender, EventArgs e)
        {
            Close();
            Form userForm = Application.OpenForms["AnswerToUserApplicationForm"];
            userForm?.Close();
        }
        #endregion
        #region [Событие загрузки формы]
        /// <summary>
        /// Событие загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserApplicationInfoForWorkerForm_Load(object sender, EventArgs e)
        {
            List<string[]> listSearch = GetApplicationInfoQuery();
            CheckDataReaderRowsInfo(listSearch);
            LoadDocuments();
        }
        #endregion
        #region [Метод загрузки документов в ListBox]
        private void LoadDocuments()
        {
            try
            {
                string sqlQuery = sqlQueries.sqlComOpenDocumentWorker;
                SqlCommand command = new SqlCommand(sqlQuery, dataBaseWork.GetConnection());
                dataBaseWork.OpenConnection();
                SqlDataReader reader = command.ExecuteReader();
                DocumentListBox.Items.Clear();
                documentList.Clear();
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
        #region [Событие нажатия на кнопку OpenDocumentWorkButton]
        /// <summary>
        /// Событие нажатия на кнопку OpenDocumentWorkButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenDocumentWorkButton_Click(object sender, EventArgs e)
        {
            OpenFileFromUser();
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
                    TypeApplWorkTextBox.Texts = item[1];
                    DescripWorkTextBox.Texts = item[2];
                    ApplWorkDTP.Text = DateTime.Parse(item[3]).ToString();
                    typeApplication = item[1];
                    description = item[2];
                    dateTimeWork = DateTime.Parse(ApplWorkDTP.Text);
                }
            }
            else
            {
                TypeApplWorkTextBox.Texts = "";
                DescripWorkTextBox.Texts = "";
                ApplWorkDTP.Text = "";
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
            string sqlQuery = sqlQueries.sqlComCheckApplicationWorker;
            return dataBaseWork.GetMultiList(sqlQuery, 4);
        }
        #endregion
        #region [Метод скачивания выбранных документов]
        private void DownloadAllDocuments()
        {
            if (DocumentListBox.Items.Count == 0)
            {
                MessageBox.Show("Нет доступных документов для скачивания!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    string message = $"Все файлы будут сохранены в папку:\n{selectedPath}\nПродолжить?";
                    DialogResult result = MessageBox.Show(message, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            foreach (var document in documentList)
                            {
                                string filePath = Path.Combine(selectedPath, document.Item1);
                                // Если файл уже существует, добавляем индекс
                                int index = 1;
                                while (File.Exists(filePath))
                                {
                                    string newFileName = Path.GetFileNameWithoutExtension(document.Item1) + $"_{index}" + document.Item3;
                                    filePath = Path.Combine(selectedPath, newFileName);
                                    index++;
                                }
                                File.WriteAllBytes(filePath, document.Item2);
                            }
                            MessageBox.Show("Все файлы успешно загружены!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка сохранения файлов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion
        #region [Метод, открывающий выбранный документ]
        /// <summary>
        /// Метод, открывающий выбранный документ из ListBox
        /// </summary>
        private void OpenFileFromUser()
        {
            if (DocumentListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите документ для открытия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string selectedFileName = DocumentListBox.SelectedItem.ToString();
                var document = documentList.FirstOrDefault(d => d.Item1 == selectedFileName);
                if (document != null)
                {
                    string tempFilePath = Path.Combine(Path.GetTempPath(), document.Item1);
                    // Если файл уже существует, добавляем индекс
                    int index = 1;
                    while (File.Exists(tempFilePath))
                    {
                        string newFileName = Path.GetFileNameWithoutExtension(document.Item1) + $"_{index}" + document.Item3;
                        tempFilePath = Path.Combine(Path.GetTempPath(), newFileName);
                        index++;
                    }
                    File.WriteAllBytes(tempFilePath, document.Item2);
                    Process.Start(tempFilePath);
                }
                else
                {
                    MessageBox.Show("Ошибка: не удалось найти файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void UserApplicationInfoForWorkerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Найдите открытую форму MainWorkFormWorker
            MainWorkFormWorker mainWorkFormWork = Application.OpenForms.OfType<MainWorkFormWorker>().FirstOrDefault();
            // Если форма найдена, вызовите методы обновления
            mainWorkFormWork?.Show();
            Form answerForm = Application.OpenForms["AnswerToUserApplicationForm"];
            answerForm?.Close();
            Form supForm = Application.OpenForms["SupplementWorkForm"];
            supForm?.Close();
        }
        private void DownloadDocWorkButton_Click(object sender, EventArgs e)
        {
            DownloadAllDocuments();
        }
    }
}