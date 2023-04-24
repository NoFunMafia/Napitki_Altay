#region [using's]
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using Napitki_Altay2.Classes;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
#endregion
namespace Napitki_Altay2.Forms
{   
    public partial class ReadyApplicationInfoForUserForm : Form
    {
        #region [Подключение классов, обьявление переменных]
        readonly SqlQueries sqlQueries = new SqlQueries();
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        #endregion
        public ReadyApplicationInfoForUserForm()
        {
            InitializeComponent();
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
        }
        #endregion
        #region [Событие нажатия на кнопку OpenPinDocumentButton]
        /// <summary>
        /// Событие нажатия на кнопку OpenPinDocumentButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenPinDocumentButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        #endregion
        #region [Метод, открывающий прикрепленный документ]
        /// <summary>
        /// Метод, открывающий прикрепленный документ
        /// </summary>
        private void OpenFile()
        {
            try
            {
                string sqlQueryFirst = sqlQueries.SqlComOpenWorkerDocument
                    (MainWorkForm.selectedRowIDInDGWC);
                SqlCommand sqlCommand = new SqlCommand(sqlQueryFirst, dataBaseWork.GetConnection());
                dataBaseWork.OpenConnection();
                var dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    var name = dataReader["Document_Name_W"].ToString();
                    var data = (byte[])dataReader["Document_Data_W"];
                    var extn = dataReader["Document_Extension_W"].ToString();
                    var newFileName = name.Replace(extn,
                        DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                    File.WriteAllBytes(newFileName, data);
                    Process.Start(newFileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                dataBaseWork.CloseConnection();
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
                    PinDocumentTextBox.Texts = item[5];
                }
            }
            else
            {
                TypeAppealAnswerTextBox.Texts = "";
                StatusCompleteTextBox.Texts = "";
                DescripCompleteTextBox.Texts = "";
                ApplCompleteDTP.Text = "";
                PinDocumentTextBox.Texts = "";
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
    }
}
