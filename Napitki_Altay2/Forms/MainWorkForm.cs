using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Napitki_Altay2.Forms
{
    public partial class MainWorkForm : Form
    {
        #region [Подключение класса соединения с БД]
        // Использование класса соединения с БД
        DataBaseCon datebaseCon = new DataBaseCon();
        #endregion
        public MainWorkForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Загрузка формы]
        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWorkForm_Load(object sender, EventArgs e)
        {
            // Передача значения Пароля из формы AuthForm
            PassCreaUpdaTextBox.Texts = AuthForm.PasswordString;
            string sqlComUserFIO = "";
        }
        #endregion
        #region [Изменение логина и пароля пользователя, использование метода схожести логина с другими пользователями]
        private void UpdLogPassButton_Click(object sender, EventArgs e)
        {
            bool success;
            try
            {
                string sqlCom = "update Auth set User_pass = " +
                    "@updPass where User_login = @oldLog";
                SqlCommand check = Check(sqlCom);
                check.Parameters.AddWithValue("@updPass", 
                    PassCreaUpdaTextBox.Texts);
                check.Parameters.AddWithValue("@oldLog", 
                    AuthForm.LoginString);
                datebaseCon.openConnection();
                using (var dataReader = check.ExecuteReader())
                {
                    success = dataReader.Read();
                    MessageBox.Show("Данные успешно изменены!",
                        "Информация", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    UpdLogPassButton.Enabled = false;
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
                datebaseCon.closeConnection();
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
            return new SqlCommand(command, datebaseCon.sqlConnection());
        }
        #endregion
        private void CreateUserFIOButton_Click(object sender, EventArgs e)
        {
            bool success;
            try
            {
                if (FamCreateTextBox.Texts == ""
                || NameCreateTextBox.Texts == ""
                || PatrCreateTextBox.Texts == "")
                    MessageBox.Show("Поля данных не заполнены до конца!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                {
                    if (CheckFIOUserInDB())
                        return;
                    string sqlComFIO = "insert into About_user" +
                        "(Surname, Name_user, Patronymic) " +
                        "values ('"
                        + FamCreateTextBox.Texts
                        + "','"
                        + NameCreateTextBox.Texts
                        + "','"
                        + PatrCreateTextBox.Texts
                        + "')";
                    string sqlComFIO2 = $"update Auth " +
                        $"set id_user_for_role = About_user.id_user " +
                        $"from About_user where " +
                        $"About_user.Surname = " +
                        $"'{FamCreateTextBox.Texts}' " +
                        $"and About_user.Name_user = " +
                        $"'{NameCreateTextBox.Texts}' " +
                        $"and About_user.Patronymic = " +
                        $"'{PatrCreateTextBox.Texts}' " +
                        $"and Auth.User_login = " +
                        $"'{AuthForm.LoginString}'";
                    SqlCommand check = Check(sqlComFIO);
                    SqlCommand check2 = Check(sqlComFIO2);
                    datebaseCon.openConnection();
                    using (var datareader = check.ExecuteReader())
                    {
                        success = datareader.Read();
                        MessageBox.Show
                            ("Пользователь успешно добавлен!",
                        "Информация", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    using (var datareader = check2.ExecuteReader())
                    {
                        success = datareader.Read();
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
                datebaseCon.closeConnection();
            }
        }
        public Boolean CheckFIOUserInDB()
        {
            DataBaseCon dataBaseCon = new DataBaseCon();
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand
                ("select * from About_user where Surname=@usSur " +
                "and Name_user=@usName and Patronymic=@usPat",
                dataBaseCon.sqlConnection());
            command.Parameters.Add
                ("@usSur", SqlDbType.VarChar).Value
                = FamCreateTextBox.Texts;
            command.Parameters.Add
                ("@usName", SqlDbType.VarChar).Value
                = NameCreateTextBox.Texts;
            command.Parameters.Add
                ("@usPat", SqlDbType.VarChar).Value 
                = PatrCreateTextBox.Texts;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Данное ФИО уже зарегестрировано " +
                    "в системе, используйте другое!",
                                    "Ошибка",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return true;
            }
            else
                return false;
        }
    }
}