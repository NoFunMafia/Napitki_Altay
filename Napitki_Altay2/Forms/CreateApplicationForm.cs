using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Napitki_Altay2.Forms
{
    public partial class CreateApplicationForm : Form
    {
        DataBaseCon dateBaseCon = new DataBaseCon();
        public string fk_info_user;
        public CreateApplicationForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Закрытие формы обращения]
        private void CancelApplButton_Click(object sender, EventArgs e)
        {
            MainWorkForm mainWorkForm = new MainWorkForm();
            mainWorkForm.Show();
            this.Hide();
        }
        #endregion
        private void RegApplButton_Click(object sender, EventArgs e)
        {
            bool successFK_Info_User;
            try
            {
                string sqlComFK_Info_User = $"select * from Info_About_User " +
                    $"where User_Surname = " +
                    $"'{MainWorkForm.SurnameUserString}' " +
                    $"and User_Name = '{MainWorkForm.NameUserString}' " +
                    $"and User_Patronymic = '{MainWorkForm.PatronymicUserString}'";
                SqlCommand check = Check(sqlComFK_Info_User);
                dateBaseCon.openConnection();
                using (var datareader = check.ExecuteReader())
                {
                    successFK_Info_User = datareader.Read();
                    {
                        CheckDataReaderRowsInfo(datareader);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, 
                    "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            finally
            {
                dateBaseCon.closeConnection();
            }
            try
            {
                bool successApplCreate;
                int chooseType = CheckType();
                int chooseDepartment = CheckDepartment(chooseType);
                string sqlComApplCreate = $"insert into " +
                    $"Application_To_Company (Applicant_Company, " +
                    $"FK_Type_Of_Appeal, FK_Type_Of_Department, " +
                    $"Description_Of_Appeal, Date_Of_Request, " +
                    $"FK_Info_User, FK_Status_Application) " +
                    $"values ('{CompanyTextBox.Texts}', " +
                    $"'{chooseType}', '{chooseDepartment}', '{DescripTextBox.Texts}', '{ApplDTP.Value}', '{fk_info_user}', '1')";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                SqlCommand check = Check(sqlComApplCreate);
                dateBaseCon.openConnection();
                using (var datareader = check.ExecuteReader())
                {
                    successApplCreate = datareader.Read();
                }
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
                dateBaseCon.closeConnection();
            }
        }
        private static int CheckDepartment(int chooseType)
        {
            int chooseDepartment;
            if (chooseType == 2 || chooseType == 4)
            {
                chooseDepartment = 3;
            }
            else
                chooseDepartment = 2;
            return chooseDepartment;
        }

        private int CheckType()
        {
            // 1,3,5
            // 2,4
            int chooseType = 0;
            if (TypeApplTextBox.Texts == 
                "Сотрудничество")
                chooseType = 1;
            else if (TypeApplTextBox.Texts == 
                "Обсуждение проблемы")
                chooseType = 2;
            else if (TypeApplTextBox.Texts == 
                "Ознакомление с каталогом продукции")
                chooseType = 3;
            else if (TypeApplTextBox.Texts == 
                "Письмо-притензия")
                chooseType = 4;
            else
                chooseType = 5;
            return chooseType;
        }
        #region [Метод получения ID пользователя при составлении обращения]
        /// <summary>
        /// Метод получения ID пользователя при составлении обращения
        /// </summary>
        /// <param name="datareader"></param>
        private void CheckDataReaderRowsInfo(SqlDataReader datareader)
        {
            if (datareader.HasRows)
            {
                fk_info_user = datareader.GetValue(0).ToString();
            }
        }
        #endregion
        #region [Проверка входящего запроса в БД]
        /// <summary>
        /// Проверка работы входящего запроса в базу данных
        /// </summary>
        /// <param name="command">Запрос в базу данных</param>
        /// <returns></returns>
        private SqlCommand Check(string command)
        {
            return new SqlCommand(command, dateBaseCon.sqlConnection());
        }
        #endregion
        #region [Работа с ToolStripMenu, выбор типа обращения]
        /// <summary>
        /// Событие нажатия на картинку с последующим 
        /// действием выпадающего элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseTypeApplPictureBox_Click
            (object sender, EventArgs e)
        {
            TypeApplMenuStip.Show(ChooseTypeApplPictureBox,
                new Point(0, ChooseTypeApplPictureBox.Height));
        }
        /// <summary>
        /// Событие нажатия на кнопку "Сотрудничество" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сотрудничествоToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            TypeApplTextBox.Texts = "Сотрудничество";
        }
        /// <summary>
        /// Событие нажатия на кнопку 
        /// "Обсуждение проблемы" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void обсуждениеПроблемыToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            TypeApplTextBox.Texts = "Обсуждение проблемы";
        }
        /// <summary>
        /// Событие нажатия на кнопку 
        /// "Ознакомление с каталогом продукции" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ознакомлениеСКаталогомПродукцииToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            TypeApplTextBox.Texts = "Ознакомление с каталогом продукции";
        }
        /// <summary>
        /// Событие нажатия на кнопку 
        /// "Письмо-притензия" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void письмопритензияToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            TypeApplTextBox.Texts = "Письмо-притензия";
        }
        /// <summary>
        /// Событие нажатия на кнопку 
        /// "Письмо-благодарность" в ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void письмоблагодарностьToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            TypeApplTextBox.Texts = "Письмо-благодарность";
        }
        #endregion
    }
}