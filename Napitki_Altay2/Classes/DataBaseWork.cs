﻿#region [using's]
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
#endregion
namespace Napitki_Altay2
{
    public class DataBaseWork
    {
        #region [Выбор БД для дома/учёбы]
        private readonly List<string> connectionStrings = new List<string>
        {
            //БД для тестирования в домашних условиях с использ. локал.
            @"Data Source=ASUSROG;Initial Catalog=FORWORK;Persist Security Info=True;User ID=Admin;Password=admin;TrustServerCertificate=True;Connect Timeout=2",
        };
        private SqlConnection _sqlCon;
        public SqlConnection SqlCon
        {
            get
            {
                if (_sqlCon == null)
                {
                    _sqlCon = ConnectToDatabase();
                }
                return _sqlCon;
            }
        }
        #endregion
        private bool _errorDisplayed = false;
        private SqlConnection ConnectToDatabase()
        {
            _errorDisplayed = false;
            foreach (string connectionString in connectionStrings)
            {
                SqlConnection connection;
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    return connection;
                }
                catch (Exception)
                {
                    connection = null;
                }
            }
            if (!_errorDisplayed)
            {
                MessageBox.Show($"Ошибка подключения к доступным базам данных. Повторите попытку позже!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _errorDisplayed = true; // Устанавливаем флаг, чтобы больше не показывать сообщение
            }
            return null;
        }
        public bool IsConnectionAvailable()
        {
            return SqlCon != null && SqlCon.State == ConnectionState.Open;
        }

        #region [Метод, получающий значение sqlCon]
        /// <summary>
        /// Метод, получающий значение sqlCon
        /// </summary>
        /// <returns>Значение соединения</returns>
        public SqlConnection GetConnection()
        {
            return SqlCon;
        }
        #endregion
        #region [Методы, для открытия/закрытия соединения с БД]
        /// <summary>
        /// Открытие соединения с БД
        /// </summary>
        public void OpenConnection()
        {
            if (SqlCon != null && SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
        }
        /// <summary>
        /// Закрытие соединения с БД
        /// </summary>
        public void CloseConnection()
        {
            if (SqlCon != null && SqlCon.State == ConnectionState.Open)
            {
                SqlCon.Close();
            }
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
            catch (Exception)
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
        /// <summary>
        /// Метод, выполняющий SQL-запрос с параметрами
        /// </summary>
        /// <param name="sqlQuery">Строка запроса</param>
        /// <param name="parameters">Словарь параметров для SQL-запроса</param>
        public Boolean WithoutOutputQuerySecond(string sqlQuery, Dictionary<string, object> parameters)
        {
            try
            {
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, GetConnection());
                // Добавляем параметры в SQL-команду
                foreach (var param in parameters)
                {
                    sqlCommand.Parameters.AddWithValue(param.Key, param.Value);
                }
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
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
        public int InsertAndGetId(string sqlQuery, Tuple<string, byte[], string> document = null)
        {
            int insertedId = -1;
            try
            {
                OpenConnection();
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, GetConnection()))
                {
                    if (document != null)
                    {
                        sqlCommand.Parameters.Add("@filename", SqlDbType.NVarChar).Value = document.Item1;
                        sqlCommand.Parameters.Add("@data", SqlDbType.VarBinary).Value = document.Item2;
                        sqlCommand.Parameters.Add("@extn", SqlDbType.Char).Value = document.Item3;
                    }

                    // Выполняем запрос и возвращаем ID вставленной записи
                    object result = sqlCommand.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        insertedId = id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вставке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
            return insertedId;
        }
    }
}