#region [using's]
using System;
using System.Windows.Forms;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class AuthEmailForm : Form
    {
        #region [Объявление переменной]
        public bool RightCode { get; set; }
        #endregion
        public AuthEmailForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Событие нажатия на кнопку CancelCodeButton]
        /// <summary>
        /// Событие нажатия на кнопку CancelCodeButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelCodeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region [Событие нажатия на кнопку EnterCodeButton]
        /// <summary>
        /// Событие нажатия на кнопку EnterCodeButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterCodeButton_Click(object sender, EventArgs e)
        {
            CheckCode();
        }
        #endregion
        #region [Метод, проверяющий правильность кода отправленного на email почту]
        /// <summary>
        /// Метод, проверяющий правильность кода отправленного на email почту
        /// </summary>
        private void CheckCode()
        {
            if (EnterCodeTextBox.Texts == RegistrationForm.uniqueCode.ToString())
            {
                RightCode = true;
                Close();
            }
            else
            {
                RightCode = false;
                MessageBox.Show("Введен неправильный код подтверждения!", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}