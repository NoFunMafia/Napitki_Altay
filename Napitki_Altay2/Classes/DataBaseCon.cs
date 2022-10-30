using System.Data.SqlClient;
namespace Napitki_Altay2
{
    internal class DataBaseCon
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
        public void openConnection()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        /// <summary>
        /// Закрытие соединения с БД
        /// </summary>
        public void closeConnection()
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
        public SqlConnection sqlConnection()
        {
            return con;
        }
        #endregion
    }
}