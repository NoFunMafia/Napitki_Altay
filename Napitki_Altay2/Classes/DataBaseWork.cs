using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Napitki_Altay2
{
    public class DataBaseWork
    {
        #region [Выбор БД для дома/учёбы]
         //БД для тестирования в домашних условиях
        SqlConnection con = new SqlConnection(@"Data Source=MYHOMIES;
        Initial Catalog=Altai_zavodBackup;
        Persist Security Info=True;
        User ID=Admin;
        Password=Admin");

        // БД для тестирования в учебных условиях
        /*SqlConnection con = new SqlConnection(@"Data Source=62.78.81.19;
        Initial Catalog=Altai_zavod;
        Persist Security Info=True;
        User ID=25-тпмоксингв;
        Password=650131");*/
        #endregion
        #region [Открытие/закрытие соединения с БД]
        /// <summary>
        /// Открытие соединения с БД
        /// </summary>
        public void OpenConnection()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        /// <summary>
        /// Закрытие соединения с БД
        /// </summary>
        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        #endregion
        #region [Возврат значение соединения]
        /// <summary>
        /// Возврат соединения
        /// </summary>
        /// <returns>Значение соединения</returns>
        public SqlConnection GetConnection()
        {
            return con;
        }
        #endregion
        #region [Методы для непосредственной работой с БД]
        /// <summary>
        /// Метод для заполнения типизированного 
        /// списка объектов полученными данными из SQL - запроса
        /// </summary>
        /// <param name="sqlQuery">Строка запроса для БД</param>
        /// <param name="col">Количество столбцов 
        /// для заполнения в список объектов</param>
        /// <returns></returns>
        public List<string[]> GetMultiList(string sqlQuery, int col)
        {
            try
            {
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, GetConnection());
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                List<string[]> sqlList = new List<string[]>();
                while (sqlDataReader.Read())
                {
                    sqlList.Add(new string[col]);
                    for (int i = 0; i < col; i++)
                        sqlList[sqlList.Count - 1][i] = sqlDataReader[i].ToString();
                }
                sqlDataReader.Close();
                if (sqlList.Count != 0)
                {
                    CloseConnection();
                    return sqlList;
                }
                else
                {
                    CloseConnection();
                    return null;
                }
            }
            catch(Exception)
            {
                CloseConnection();
                MessageBox.Show("Возникла непредвиденная ошибка!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }
        /// <summary>
        /// Метод для вывода получаемых 
        /// значений из SQL - запроса в DataGridView
        /// </summary>
        /// <param name="sqlQuery">Строка запроса для БД</param>
        /// <returns></returns>
        public DataTable OutputQuery(string sqlQuery)
        {
            try
            {
                OpenConnection();
                SqlDataAdapter sqlDataAdapter = 
                    new SqlDataAdapter(sqlQuery, GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch(Exception)
            {
                CloseConnection();
                MessageBox.Show("Возникла непредвиденная ошибка!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
            finally 
            { 
                CloseConnection(); 
            }
        }
        /// <summary>
        /// Метод для получения единичного значения из SQL - запроса
        /// </summary>
        /// <param name="sqlQuery">Строка запроса для БД</param>
        /// <returns></returns>
        public string GetString(string sqlQuery) 
        {
            try
            {
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, GetConnection());
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                string responce = null;
                while (sqlDataReader.Read())
                {
                    responce = sqlDataReader[0].ToString();
                }
                sqlDataReader.Close();
                return responce;
            }
            catch (Exception ex)
            {
                CloseConnection();
                MessageBox.Show("Возникла непредвиденная ошибка!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }
        /// <summary>
        /// Метод, осуществляющий обработку 
        /// SQL - запроса для 
        /// добавления/удаления/редактирования данных
        /// </summary>
        /// <param name="sqlQuery">Строка запроса для БД</param>
        public Boolean WithoutOutputQuery(string sqlQuery)
        {
            try
            {
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Операция с данными проведена!", 
                    "Информация", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                return true;
            }
            catch(Exception)
            {
                CloseConnection();
                MessageBox.Show("Возникла непредвиденная ошибка!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        #endregion
    }
}