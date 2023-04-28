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
            string sqlQuery = sqlQueries.SqlComTakeIdWorker
                (EnterNameTextBox.Texts,
                EnterFamTextBox.Texts,
                EnterOtchTextBox.Texts);
            idWorker = dataBaseWork.GetString(sqlQuery);
            string sqlQuerySecond = sqlQueries.SqlComCheckAccountWorker(idWorker);
            string idAccountWorker = dataBaseWork.GetString(sqlQuerySecond);
            if (idWorker != string.Empty)
            {
                IsAccountWorker = false;
                if (idAccountWorker == null)
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
        #endregion
    }
}
