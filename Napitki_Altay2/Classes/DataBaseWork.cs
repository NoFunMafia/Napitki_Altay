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
        /// <summary>
        /// Метод для заполнения типизированного 
        /// списка объектов полученными данными из запроса в БД
        /// </summary>
        /// <param name="sqlQuery">Запрос в БД</param>
        /// <param name="col">Количество столбцов 
        /// для заполнения в список объектов</param>
        /// <returns></returns>
        public List<string[]> GetMultiList(string sqlQuery, int col)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, GetConnection());
                OpenConnection();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,
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
                MessageBox.Show(ex.Message,
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
    }
}