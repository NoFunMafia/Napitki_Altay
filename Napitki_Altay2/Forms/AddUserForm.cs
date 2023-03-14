using ClosedXML.Report.Utils;
using Napitki_Altay2.Classes;
using Napitki_Altay2.Design;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Napitki_Altay2.Forms
{
    public partial class AddUserForm : Form
    {
        #region [Подключение классов, объявление переменных]
        // Класс запросов в БД
        SqlQueries sqlQueries = new SqlQueries();
        // Использование класса работы с БД
        DataBaseWork dataBaseWork = new DataBaseWork();
        #endregion
        public AddUserForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Событие нажатия на кнопку RolePictureBox]
        /// <summary>
        /// Событие нажатия на кнопку RolePictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RolePictureBox_Click(object sender, EventArgs e)
        {
            RoleMenuStrip.Show(RolePictureBox,
                new Point(0, RolePictureBox.Height));
        }
        #endregion
        #region [Событие нажатия на item "администратор" ToolStrip'а]
        /// <summary>
        /// Событие нажатия на item "администратор" ToolStrip'а
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void администраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleTextBox.Texts = "Администратор";
        }
        #endregion
        #region [Событие нажатия на item "сотрудник" ToolStrip'а]
        /// <summary>
        /// Событие нажатия на item "сотрудник" ToolStrip'а
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleTextBox.Texts = "Сотрудник";
        }
        #endregion
        #region [Событие нажатия на item "заявитель" ToolStrip'а]
        /// <summary>
        /// Событие нажатия на item "заявитель" ToolStrip'а
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void заявительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleTextBox.Texts = "Заявитель";
        }
        #endregion
        #region [Событие нажатия на кнопку CancelButton]
        /// <summary>
        /// Событие нажатия на кнопку CancelButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region [Событие нажатия на кнопку InputUsersButton]
        /// <summary>
        /// Событие нажатия на кнопку InputUsersButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputUsersButton_Click(object sender, EventArgs e)
        {
            List<CustomTextBox> excludedTextBoxes = new List<CustomTextBox>
            {
                FamTextBox, ImyaTextBox, OtchTextBox
            };
            bool checkEmail = IsValidEmail(EmailTextBox.Texts);
            bool checkTextBox = CheckTextBoxIsNull(excludedTextBoxes);
            if (checkEmail && checkTextBox)
            {
                MessageBox.Show("all in OK!");
            }
        }
        #endregion
        #region [Метод, проверяющий на пустоту TextBox'ов на форме]
        public bool CheckTextBoxIsNull(List<CustomTextBox> excludedTextBoxes = null)
        {
            foreach (CustomTextBox customTextBox in Controls.OfType<CustomTextBox>())
            {
                if (excludedTextBoxes != null && excludedTextBoxes.Contains(customTextBox))
                {
                    continue;
                }
                if (string.IsNullOrWhiteSpace(customTextBox.Texts))
                {
                    MessageBox.Show("Не все поля данных заполненны!",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        #endregion
        #region [Метод, проверяющий правильность ввода адреса электронной почты]
        public Boolean IsValidEmail(string email)
        {
            Regex emailRegex = new Regex
                (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
                RegexOptions.IgnoreCase);
            if (emailRegex.IsMatch(email))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Адрес электронной почты введен некорректно!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
    }
}