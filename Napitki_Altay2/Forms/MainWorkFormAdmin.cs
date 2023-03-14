using Napitki_Altay2.Classes;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Napitki_Altay2.Forms
{
    public partial class MainWorkFormAdmin : Form
    {
        #region [Подключение классов, объявление переменных]
        // Класс запросов в БД
        SqlQueries sqlQueries = new SqlQueries();
        // Использование класса работы с БД
        DataBaseWork dataBaseWork = new DataBaseWork();
        #endregion
        public MainWorkFormAdmin()
        {
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Событие загрузки формы]
        /// <summary>
        /// Событие загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWorkFormAdmin_Load(object sender, EventArgs e)
        {
            LoadDataGridViewUsers();
        }
        #endregion
        #region [Вывод данных в таблицу DataGridViewUsers]
        /// <summary>
        /// Вывод данных в таблицу DataGridViewUsers
        /// </summary>
        private void LoadDataGridViewUsers()
        {
            string sqlQuery = sqlQueries.sqlComOutputUsers;
            DataTable dataTable = dataBaseWork.OutputQuery(sqlQuery);
            OutputInTableSetting(dataTable);
        }
        #endregion
        #region [Настройка отображения выводимых данных в таблицу DataGridViewUsers]
        /// <summary>
        /// Настройка отображения выводимых 
        /// данных в таблицу DataGridViewUsers
        /// </summary>
        /// <param name="dataTable">Передаваемая таблица с данными</param>
        private void OutputInTableSetting(DataTable dataTable)
        {
            DataGridViewUsers.DataSource = dataTable;
            DataGridViewUsers.Columns[0].HeaderText = "ID пользователя";
            DataGridViewUsers.Columns[0].Width = 60;
            DataGridViewUsers.Columns[1].HeaderText = "Логин";
            DataGridViewUsers.Columns[1].Width = 140;
            DataGridViewUsers.Columns[2].HeaderText = "Пароль";
            DataGridViewUsers.Columns[2].Width = 120;
            DataGridViewUsers.Columns[3].HeaderText = "Фамилия";
            DataGridViewUsers.Columns[3].Width = 130;
            DataGridViewUsers.Columns[4].HeaderText = "Имя";
            DataGridViewUsers.Columns[4].Width = 130;
            DataGridViewUsers.Columns[5].HeaderText = "Отчество";
            DataGridViewUsers.Columns[5].Width = 116;
            DataGridViewUsers.Columns[6].HeaderText = "Роль";
            DataGridViewUsers.Columns[6].Width = 116;
            DataGridViewUsers.Columns[7].HeaderText = "Email";
            DataGridViewUsers.Columns[7].Width = 116;
        }
        #endregion
        #region [Событие нажатия на кнопку CreateUserButton]
        /// <summary>
        /// Событие нажатия на кнопку CreateUserButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }
        #endregion
        #region [Событие, при котором меняются размеры элементов при развороте приложения]
        /// <summary>
        /// Событие, при котором меняются 
        /// размеры элементов при развороте приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWorkFormAdmin_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                MainWorkAdminTabControl.Size = new Size(1532, 829);
                DataGridViewUsers.Size = new Size(1520, 750);
            }
            else
            {
                MainWorkAdminTabControl.Size = new Size(764, 448);
                DataGridViewUsers.Size = new Size(754, 372);
            }
        }
        #endregion
        #region [Закрытие приложения при закрытии формы]
        /// <summary>
        /// Закрытие приложения при закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWorkFormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region [Событие нажатия на кнопку UpdateUserButton]
        /// <summary>
        /// Событие нажатия на кнопку UpdateUserButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            LoadDataGridViewUsers();
        }
        #endregion
    }
}