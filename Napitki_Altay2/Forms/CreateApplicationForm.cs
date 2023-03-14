#region [using's]
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Napitki_Altay2.Classes;
using System.Data.Common;
#endregion
namespace Napitki_Altay2.Forms
{
    public partial class CreateApplicationForm : Form
    {
        #region [Переменные для работы с БД]
        DataBaseWork dateBaseCon = new DataBaseWork();
        //DataBaseCom dataGridFill = new DataBaseCom();
        public string fk_info_user;
        public string fk_application_to_company;
        public string fk_application_document_from_user;
        public string DocName;
        public string DocExtn;
        #endregion
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
            this.Close();
        }
        #endregion
        #region [Создание обращения]
        private void RegApplButton_Click(object sender, EventArgs e)
        {
            bool successFK_Info_User;
            try
            {
                string sqlComFK_Info_User = $"select * " +
                    $"from Info_About_User " +
                    $"where User_Surname = " +
                    $"'{MainWorkForm.SurnameUserString}' " +
                    $"and User_Name = '{MainWorkForm.NameUserString}' " +
                    $"and User_Patronymic = " +
                    $"'{MainWorkForm.PatronymicUserString}'";
                SqlCommand check = Check(sqlComFK_Info_User);
                dateBaseCon.OpenConnection();
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
                dateBaseCon.CloseConnection();
            }
            string filepath = DocumentTextBox.Texts;
            if(DocumentTextBox.Texts == "")
            {
                if (CompanyTextBox.Texts == "" || 
                    TypeApplTextBox.Texts == "" || 
                    DescripTextBox.Texts == "")
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
                        bool successApplCreate;
                        int chooseType = CheckType();
                        int chooseDepartment = CheckDepartment(chooseType);
                        string sqlComApplCreate = $"insert into " +
                            $"Application_To_Company (Applicant_Company, " +
                            $"FK_Type_Of_Appeal, FK_Type_Of_Department, " +
                            $"Description_Of_Appeal, Date_Of_Request, " +
                            $"FK_Info_User, " +
                            $"FK_Status_Application) " +
                            $"values ('{CompanyTextBox.Texts}', " +
                            $"'{chooseType}', '{chooseDepartment}', " +
                            $"'{DescripTextBox.Texts}', " +
                            $"'{ApplDTP.Value}', " +
                            $"'{fk_info_user}', " +
                            $"'1')";
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        SqlCommand check = Check(sqlComApplCreate);
                        dateBaseCon.OpenConnection();
                        using (var datareader = check.ExecuteReader())
                        {
                            successApplCreate = datareader.Read();
                            MessageBox.Show("Обращение создано!",
                                    "Информация",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            this.Hide();
                            MainWorkForm mainWorkForm = new MainWorkForm();
                            mainWorkForm.Show();
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
                        dateBaseCon.CloseConnection();
                    }
                }
            }
            else if(DocumentTextBox.Texts.Length > 1)
            {
                if(CompanyTextBox.Texts == "" || 
                    TypeApplTextBox.Texts == "" || 
                    DescripTextBox.Texts == "")
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
                            "Application_Document_From_User" +
                            "(Document_Name, Document_Data, " +
                            $"Document_Extension, FK_Info_User) " +
                            $"values (@filename, @data, @extn, " +
                            $"'{fk_info_user}')";
                        try
                        {
                            dateBaseCon.OpenConnection();
                            SqlCommand command = new SqlCommand
                                (sqlQueryInsertFile, dateBaseCon.GetConnection());
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
                            dateBaseCon.CloseConnection();
                        }
                    }
                    // 777
                    /*string sqlComFK_Application_From_User = $"select * " +
                            $"from Application_Document_From_User " +
                            $"where Document_Name = '{DocName}' " +
                            $"and Document_Extension = '{DocExtn}'";
                    dataGridFill.FillTable(sqlComFK_Application_From_User);
                    if (dataGridFill.dataReader.HasRows)
                    {
                        fk_application_document_from_user = 
                            dataGridFill.dataReader.GetValue(0).ToString();
                    }*/
                    // 777
                    try
                    {
                        bool successApplCreate;
                        int chooseType = CheckType();
                        int chooseDepartment = CheckDepartment(chooseType);
                        string sqlComApplCreate = $"insert into " +
                            $"Application_To_Company (Applicant_Company, " +
                            $"FK_Type_Of_Appeal, FK_Type_Of_Department, " +
                            $"Description_Of_Appeal, Date_Of_Request, " +
                            $"FK_Info_User, " +
                            $"FK_Application_Document_From_User, " +
                            $"FK_Status_Application) " +
                            $"values ('{CompanyTextBox.Texts}', " +
                            $"'{chooseType}', '{chooseDepartment}', " +
                            $"'{DescripTextBox.Texts}', " +
                            $"'{ApplDTP.Value}', " +
                            $"'{fk_info_user}', " +
                            $"'{fk_application_document_from_user}', " +
                            $"'1')";
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        SqlCommand check = Check(sqlComApplCreate);
                        dateBaseCon.OpenConnection();
                        using (var datareader = check.ExecuteReader())
                        {
                            successApplCreate = datareader.Read();
                            MessageBox.Show("Обращение создано!",
                                    "Информация",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            this.Hide();
                            MainWorkForm mainWorkForm = new MainWorkForm();
                            mainWorkForm.Show();
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
                        dateBaseCon.CloseConnection();
                    }
                }
            }
        }
        #endregion
        #region [Метод проверки уникальности имени прикрепляемого документа]
        public Boolean CheckNameOfUserFile()
        {
            string filepath = DocumentTextBox.Texts;
            using (Stream stream = File.OpenRead(filepath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                var fileInfo = new FileInfo(filepath);
                string name = fileInfo.Name;
                DataBaseWork dataBaseCon = new DataBaseWork();
                DataTable dataTable = new DataTable();
                SqlCommand command = new SqlCommand
                    ("select * from Application_Document_From_User " +
                    "where Document_Name=@docName",
                    dataBaseCon.GetConnection());
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
        #region [Проверка инициализации департамента для выбранного типа обращения]
        private static int CheckDepartment(int chooseType)
        {
            int chooseDepartment;
            if (chooseType == 1 || chooseType == 2)
            {
                chooseDepartment = 4;
            }
            else
                chooseDepartment = 2;
            return chooseDepartment;
        }
        #endregion
        #region [Выбор типа обращения]
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
        #endregion
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
        #region [Метод получения ID заявки]
        /// <summary>
        /// Метод получения ID пользователя при составлении обращения
        /// </summary>
        /// <param name="datareader"></param>
        private void CheckDataRowsIDDocument(SqlDataReader datareader)
        {
            if (datareader.HasRows)
            {
                fk_application_document_from_user = datareader.GetValue(0).ToString();
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
            return new SqlCommand(command, dateBaseCon.GetConnection());
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
            TypeApplMenuStrip.Show(ChooseTypeApplPictureBox,
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
            TypeApplTextBox.Texts = "Вопросы по каталогу продукции";
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
        #region [Событие нажатия на кнопку выбора документа для прикрепления]
        private void ChooseDocumentButton_Click
            (object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            DocumentTextBox.Texts = openFileDialog.FileName;
        }
        #endregion
        #region [Удаление прикреплённого документа]
        private void DeleteDocumentButton_Click(object sender, EventArgs e)
        {
            DocumentTextBox.Texts = "";
        }
        #endregion
        private void CreateApplicationForm_FormClosed
            (object sender, FormClosedEventArgs e)
        {
            MainWorkForm mainWorkForm = new MainWorkForm();
            mainWorkForm.Show();
        }
    }
}