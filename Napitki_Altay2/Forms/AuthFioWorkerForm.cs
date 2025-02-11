#region [using's]
using Napitki_Altay2.Classes;
using System;
using System.Windows.Forms;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class AuthFioWorkerForm : Form
    {
        #region [Подключение классов, обьявление переменных]
        readonly DataBaseWork dataBaseWork = new DataBaseWork();
        readonly SqlQueries sqlQueries = new SqlQueries();
        public static string workerName, workerFam, workerOtch, idWorker;
        public bool IsAccountWorker { get; set; }
        #endregion
        public AuthFioWorkerForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        #region [Событие нажатия на кнопку CancelFioButton]
        /// <summary>
        /// Событие нажатия на кнопку CancelFioButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelFioButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region [Событие нажатия на кнопку EnterFioButton]
        /// <summary>
        /// Событие нажатия на кнопку EnterFioButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterFioButton_Click(object sender, EventArgs e)
        {
            CheckFioWorker();
        }
        #endregion
        #region [Метод, проверяющий наличие ФИО в БД]
        /// <summary>
        /// Метод, проверяющий наличие ФИО в БД
        /// </summary>
        private void CheckFioWorker()
        {
            string sqlQuery;
            if (EnterFamTextBox.Texts != string.Empty
                || EnterNameTextBox.Texts != string.Empty)
            {
                if (EnterOtchTextBox.Texts == string.Empty)
                {
                    sqlQuery = sqlQueries.SqlComTakeIdWorker
                        (EnterNameTextBox.Texts, EnterFamTextBox.Texts);
                }
                else
                {
                    sqlQuery = sqlQueries.SqlComTakeIdWorkerFull
                        (EnterNameTextBox.Texts, 
                        EnterFamTextBox.Texts,
                        EnterOtchTextBox.Texts);
                }
                idWorker = dataBaseWork.GetString(sqlQuery);
                string sqlQueryThree = sqlQueries.SqlComCheckAccountWorker(idWorker);
                string idAccountWorker = dataBaseWork.GetString(sqlQueryThree);
                string sqlQueryFourth = sqlQueries.SqlComTakeEmployeeNumber(idWorker);
                string employeeNumber = dataBaseWork.GetString(sqlQueryFourth);
                if (idWorker != null)
                {
                    IsAccountWorker = false;
                    if (idAccountWorker == null && employeeNumber != "")
                    {
                        IsAccountWorker = true;
                        workerFam = EnterFamTextBox.Texts;
                        workerName = EnterNameTextBox.Texts;
                        workerOtch = EnterOtchTextBox.Texts;
                        MessageBox.Show($"Рады Вас видеть, {workerFam} {workerName} {workerOtch}! " +
                            $"Продолжайте регистрацию и вы сможете приступить к работе.", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else if(employeeNumber == "")
                    {
                        IsAccountWorker = false;
                        MessageBox.Show("Ваш табельный номер не определен, обратитесь к администратору!", 
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        IsAccountWorker = false;
                        MessageBox.Show("Ваш аккаунт уже зарегистрирован!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    IsAccountWorker = false;
                    MessageBox.Show("Работник с таким ФИО отсутствует. " +
                        "Проверьте правильность введённых данных!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Не все поля данных заполнены!", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}