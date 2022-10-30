#region [using's]
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
#endregion

namespace Napitki_Altay2.Forms
{
    public partial class AnswerToUserApplicationForm : Form
    {
        #region [Подключение класса соединения с БД, объявление string переменных]
        DataBaseCon dateBaseCon = new DataBaseCon();
        public string fk_info_user;
        public string DocName;
        public string DocExtn;
        public string fk_application_document_from_worker;
        #endregion
        public AnswerToUserApplicationForm()
        {
            this.Location = new Point(740, 90);
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        #region [Событие нажатия на кнопку закрытия формы]
        /// <summary>
        /// Событие нажатия на кнопку закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseApplicWorkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region [Метод проверки уникальности имени прикрепляемого документа]
        /// <summary>
        /// Метод проверки уникальности имени прикрепляемого документа
        /// </summary>
        /// <returns></returns>
        public Boolean CheckNameOfUserFile()
        {
            string filepath = DocumentWorkAnsTextBox.Texts;
            using (Stream stream = File.OpenRead(filepath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                var fileInfo = new FileInfo(filepath);
                string name = fileInfo.Name;
                DataBaseCon dataBaseCon = new DataBaseCon();
                DataTable dataTable = new DataTable();
                SqlCommand command = new SqlCommand
                    ("select * from Answer_Document_From_Worker " +
                    "where Document_Name_W=@docName",
                    dataBaseCon.sqlConnection());
                command.Parameters.Add
                    ("@docName", SqlDbType.VarChar).Value
                    = name;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show
                        ("Переименуйте файл! " +
                        "Данное название уже присутствует в системе!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return true;
                }
                else
                    return false;
            }
        }
        #endregion
        #region [Работа с ToolStripMenu, выбор статуса обращения]
        /// <summary>
        /// Событие нажатия на картинку с последующим 
        /// действием выпадающего элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseStatusApplPictureBox_Click(object sender, EventArgs e)
        {
            TypeApplWorkMenuStrip.Show(ChooseStatusApplPictureBox,
                new Point(0, ChooseStatusApplPictureBox.Height));
        }
        private void завершеноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusApplicationTextBox.Texts = "Завершено";
        }
        private void отклоненоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusApplicationTextBox.Texts = "Отклонено";
        }
        #endregion
        #region [Событие нажатия на кнопку выбора документа для прикрепления]
        /// <summary>
        /// Событие нажатия на кнопку выбора документа для прикрепления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseAnsWorkDocumentButton_Click
            (object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            DocumentWorkAnsTextBox.Texts = openFileDialog.FileName;
        }
        #endregion
        #region [Удаление прикреплённого документа]
        /// <summary>
        /// Событие нажатия на удаление прикреплённого документа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAnsWorkDocumentButton_Click
            (object sender, EventArgs e)
        {
            DocumentWorkAnsTextBox.Texts = "";
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
        #region [Метод получения ID пользователя при составлении обращения]
        /// <summary>
        /// Метод получения ID пользователя при составлении ответа на обращение
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
        #region [Метод получения ID заявки]
        /// <summary>
        /// Метод получения ID пользователя при составлении обращения
        /// </summary>
        /// <param name="datareader"></param>
        private void CheckDataRowsIDDocument(SqlDataReader datareader)
        {
            if (datareader.HasRows)
            {
                fk_application_document_from_worker = 
                    datareader.GetValue(0).ToString();
            }
        }
        #endregion
        #region [Событие нажатия на кнопку дачи ответа]
        /// <summary>
        /// Событие нажатия на кнопку дачи ответа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerApplButton_Click(object sender, EventArgs e)
        {
            bool successFK_Info_User;
            try
            {
                string sqlComFK_Info_User = $"select * " +
                    $"from Info_About_User " +
                    $"where User_Surname = " +
                    $"'{MainWorkFormWorker.SurnameWorkerString}' " +
                    $"and User_Name = " +
                    $"'{MainWorkFormWorker.NameWorkerString}' " +
                    $"and User_Patronymic = " +
                    $"'{MainWorkFormWorker.PatrWorkerString}'";
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
            string filepath = DocumentWorkAnsTextBox.Texts;
            if (DocumentWorkAnsTextBox.Texts == "")
            {
                if (StatusApplicationTextBox.Texts == "" ||
                    DescripWorkAnsTextBox.Texts == "")
                {
                    MessageBox.Show("Не все поля заполнены!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        int UpdateStat;
                        if (StatusApplicationTextBox.Texts == "Завершено")
                        {
                            UpdateStat = 3;
                        }
                        else
                            UpdateStat = 4;
                        bool success;
                        string sqlComApplCreate = "update " +
                            "Application_To_Company " +
                            $"set FK_Status_Application = '{UpdateStat}' " +
                            $"where ID_Application = " +
                            $"'{MainWorkFormWorker.SelectedRowID}'";
                        SqlCommand check = Check(sqlComApplCreate);
                        dateBaseCon.openConnection();
                        using (var datareader = check.ExecuteReader())
                        {
                            success = datareader.Read();
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
                    try
                    {
                        bool successApplCreate;
                        string sqlComApplCreate = "insert into " +
                            "Ready_Application(FK_ID_Application, " +
                            "FK_Info_User, Answer_To_Application, " +
                            "Date_Of_Answer) " +
                            $"values " +
                            $"('{MainWorkFormWorker.SelectedRowID}', " +
                            $"'{fk_info_user}', " +
                            $"'{DescripWorkAnsTextBox.Texts}', " +
                            $"'{ApplAnsWorkDTP.Value}'" +
                            $")";
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        SqlCommand check = Check(sqlComApplCreate);
                        dateBaseCon.openConnection();
                        using (var datareader = check.ExecuteReader())
                        {
                            successApplCreate = datareader.Read();
                            MessageBox.Show("Ответ на обращение дан!",
                                    "Информация",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            this.Close();
                            Form fc = Application.OpenForms
                                ["UserApplicationInfoForWorkerForm"];
                            if(fc != null)
                                fc.Close(); 
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
            }
            else if (DocumentWorkAnsTextBox.Texts.Length > 1)
            {
                if (StatusApplicationTextBox.Texts == "" ||
                    DescripWorkAnsTextBox.Texts == "")
                {
                    MessageBox.Show("Не все поля заполнены!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    using (Stream stream = File.OpenRead(filepath))
                    {
                        byte[] buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);
                        var fileInfo = new FileInfo(filepath);
                        string extn = fileInfo.Extension;
                        string name = fileInfo.Name;
                        if (CheckNameOfUserFile())
                            return;
                        string sqlQueryInsertFile = "insert into " +
                            "Answer_Document_From_Worker" +
                            "(Document_Name_W, Document_Data_W, " +
                            $"Document_Extension_W, FK_Info_User) " +
                            $"values (@filename, @data, @extn, " +
                            $"'{fk_info_user}')";
                        try
                        {
                            dateBaseCon.openConnection();
                            SqlCommand command = new SqlCommand
                                (sqlQueryInsertFile, 
                                dateBaseCon.sqlConnection());
                            command.Parameters.Add("@filename",
                                SqlDbType.VarChar).Value = name;
                            DocName = name;
                            command.Parameters.Add("@data",
                                SqlDbType.VarBinary).Value = buffer;
                            command.Parameters.Add("@extn",
                                SqlDbType.Char).Value = extn;
                            DocExtn = extn;
                            command.ExecuteNonQuery();
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
                    try
                    {
                        bool successFK_Application_Document_From_User;
                        string sqlComFK_Application_From_User 
                            = $"select * " +
                            $"from Answer_Document_From_Worker " +
                            $"where Document_Name_W = '{DocName}' " +
                            $"and Document_Extension_W = '{DocExtn}'";
                        SqlCommand check 
                            = Check(sqlComFK_Application_From_User);
                        dateBaseCon.openConnection();
                        using (var datareader = check.ExecuteReader())
                        {
                            successFK_Application_Document_From_User
                                = datareader.Read();
                            {
                                CheckDataRowsIDDocument(datareader);
                            }
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
                    try
                    {
                        int UpdateStat;
                        if (StatusApplicationTextBox.Texts == "Завершено")
                        {
                            UpdateStat = 3;
                        }
                        else
                            UpdateStat = 4;
                        bool success;
                        string sqlComApplCreate = "update " +
                            "Application_To_Company " +
                            $"set FK_Status_Application = '{UpdateStat}' " +
                            $"where ID_Application = " +
                            $"'{MainWorkFormWorker.SelectedRowID}'";
                        SqlCommand check = Check(sqlComApplCreate);
                        dateBaseCon.openConnection();
                        using(var datareader = check.ExecuteReader())
                        {
                            success = datareader.Read();
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
                        string sqlComApplCreate = "insert into " +
                            "Ready_Application(FK_ID_Application, " +
                            "FK_Info_User, Answer_To_Application, " +
                            "Date_Of_Answer, " +
                            "FK_Answer_Document_From_Worker) " +
                            $"values " +
                            $"('{MainWorkFormWorker.SelectedRowID}', " +
                            $"'{fk_info_user}', " +
                            $"'{DescripWorkAnsTextBox.Texts}', " +
                            $"'{ApplAnsWorkDTP.Value}', " +
                            $"'{fk_application_document_from_worker}')";
                        SqlDataAdapter sqlDataAdapter 
                            = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        SqlCommand check = Check(sqlComApplCreate);
                        dateBaseCon.openConnection();
                        using (var datareader = check.ExecuteReader())
                        {
                            successApplCreate = datareader.Read();
                            MessageBox.Show("Ответ на обращение дан!",
                                    "Информация",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            this.Close();
                            Form fc = Application.OpenForms
                                ["UserApplicationInfoForWorkerForm"];
                            if (fc != null)
                                fc.Close();
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
            }
        }
        #endregion
    }
}