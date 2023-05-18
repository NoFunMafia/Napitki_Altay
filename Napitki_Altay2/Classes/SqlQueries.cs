#region [using's]
using Napitki_Altay2.Forms;
using System;
#endregion
namespace Napitki_Altay2.Classes
{
    internal class SqlQueries
    {
        #region [MainWorkForm]
        // MainWorkForm - MainWorkForm_Load
        public string sqlComRecFIO = $"select * from Info_About_User " +
                $"join Authentication_ on Authentication_.FK_Info_User " +
                $"= Info_About_User.ID_Info_User " +
                $"where Authentication_.Login_User = " +
                $"'{AuthForm.LoginString}'";

        // MainWorkForm - LoadDataGridView
        public string SqlOutputMWF(string name, string fam, string otch)
        {
            string sqlCom = "select Id_Application, " +
                    "Applicant_Company, User_Surname, " +
                    "User_Name, " +
                    "User_Patronymic, " +
                    "Status_Name " +
                    "from Application_To_Company" +
                    " join Info_About_User on " +
                    "Application_To_Company.FK_Info_User = " +
                    "Info_About_User.ID_Info_User join " +
                    "Status_Application on " +
                    "Application_To_Company.FK_Status_Application" +
                    " = Status_Application.ID_Status " +
                    $"where Info_About_User.User_Name = " +
                    $"'{name}' and " +
                    $"Info_About_User.User_Surname = " +
                    $"'{fam}' and " +
                    $"Info_About_User.User_Patronymic = " +
                    $"'{otch}' and ID_Status = '1' " +
                    $"or ID_Status = '2'";
            return sqlCom;
        }

        // MainWorkForm - LoadDataGridViewComplete
        public string SqlComIDUser(string fam, string name, string otch)
        {
            string sqlCom = $"select * " +
                    $"from Info_About_User " +
                    $"where User_Surname = " +
                    $"'{fam}' " +
                    $"and User_Name = '{name}' " +
                    $"and User_Patronymic = " +
                    $"'{otch}'";
            return sqlCom;
        }

        // MainWorkForm - LoadDataGridViewComplete2
        public string SqlComFKInfo(string fkInfoUser)
        {
            string sqlCom = "select FK_ID_Application, " +
                    "User_Surname, User_Name, " +
                    "User_Patronymic, " +
                    "Date_Of_Answer, Status_Name " +
                    "from Ready_Application " +
                    "join Info_About_User on " +
                    "Ready_Application.FK_Info_User " +
                    "= Info_About_User.ID_Info_User " +
                    "join Application_To_Company " +
                    "on Application_To_Company.ID_Application " +
                    "= Ready_Application.FK_ID_Application " +
                    "join Status_Application " +
                    "on Status_Application.ID_Status = Application_To_Company.FK_Status_Application " +
                    $"where Application_To_Company.FK_Info_User = " +
                    $"'{fkInfoUser}'";
            return sqlCom;
        }

        // MainWorkForm - UpdLogPassButton_Click
        public string SqlComUpdPass(string pass)
        {
            string sqlCom = "update Authentication_ " +
                "set Password_User = " +
                $"'{pass}' where Login_User = '{AuthForm.LoginString}'";
            return sqlCom;
        }

        // MainWorkForm - CheckFIOUserInDB
        public string SqlComCheckINFOonFIO(string fam, string name, string otch)
        {
            string sqlCom = "select * from Info_About_User " +
                $"where User_Surname = '{fam}' " +
                $"and User_Name = '{name}' " +
                $"and User_Patronymic = '{otch}'";
            return sqlCom;
        }

        // MainWorkForm - CreateUserFIOButton_Click
        public string SqlComInsFIO(string fam, string name, string otch)
        {
            string sqlQuery = "insert into Info_About_User " +
            "(User_Surname, User_Name, User_Patronymic) " +
            $"values ('{fam}', '{name}', '{otch}')";
            return sqlQuery;
        }

        // MainWorkForm - CreateUserFIOButton_Click
        public string SqlComInsFIOSec(string fam, string name, string otch)
        {
            string sqlQuery = "update Authentication_ " +
                $"set FK_Info_User = Info_About_User.ID_Info_User " +
                $"from Info_About_User where " +
                $"Info_About_User.User_Surname = '{fam}' " +
                $"and Info_About_User.User_Name = '{name}' " +
                $"and Info_About_User.User_Patronymic = '{otch}' " +
                $"and Authentication_.Login_User = '{AuthForm.LoginString}'";
            return sqlQuery;
        }

        // MainWorkForm - UpdateDataInDGW_Click
        public string SqlComUpdateDGW(string fam, string name, string otch)
        {
            string sqlCom = "select Id_Application, " +
                "Applicant_Company, User_Surname, " +
                "User_Name, " +
                "User_Patronymic, Status_Name " +
                "from Application_To_Company" +
                " join Info_About_User on " +
                "Application_To_Company.FK_Info_User = " +
                "Info_About_User.ID_Info_User join " +
                "Status_Application on " +
                "Application_To_Company.FK_Status_Application" +
                " = Status_Application.ID_Status " +
                "where Info_About_User.User_Name = " +
                $"'{name}' and " +
                $"Info_About_User.User_Surname = " +
                $"'{fam}' and " +
                $"Info_About_User.User_Patronymic = " +
                $"'{otch}' and ID_Status = '1' or ID_Status = '2'";
            return sqlCom;
        }

        // MainWorkForm - DeleteApplicationButton_Click
        public string SqlComDelete(string deleteRow)
        {
            string sqlCom = "delete from " +
                "Application_To_Company " +
                "where ID_Application " +
                $"= '{deleteRow}'";
            return sqlCom;
        }
        #endregion
        #region [AuthForm]
        // AuthForm - LogInAppButton_Click
        public string SqlComRoleUser(string login, string pass)
        {
            string sqlCom = "select * from Authentication_ " +
                $"where Login_User = '{login}' and Password_User = '{pass}'";
            return sqlCom;
        }
        // AuthForm - LogInAppButton_Click
        public string SqlComRole(string login, string pass, string role)
        {
            string sqlCom = "select * from Authentication_ " +
                $"where Login_User = '{login}' and Password_User = '{pass}' " +
                $"and FK_Role_User = '{role}'";
            return sqlCom;
        }
        // AuthForm - OpenSpecificForm
        public string SqlComTitleRole(string role)
        {
            string sqlCom = $"select Role_Title from Role_User " +
                $"where ID_Role_User = '{role}'";
            return sqlCom;
        }
        #endregion
        #region [MainWorkFormAdmin]
        // MainWorkFormAdmin - MainWorkFormAdmin_Load
        public string sqlComOutputUsers = "select ID_User, Login_User, Password_User, " +
            "User_Surname, User_Name, User_Patronymic, Role_Title, Email " +
            "from Authentication_ join Role_User on " +
            "Authentication_.FK_Role_User = Role_User.ID_Role_User left join " +
            "Info_About_User on Authentication_.FK_Info_User = Info_About_User.ID_Info_User";
        // MainWorkFormAdmin - SendQueryToDeleteUser
        public string SqlComDeleteUser(string loginID)
        {
            string sqlCom = $"delete from Authentication_ where ID_User = '{loginID}'";
            return sqlCom;
        }
        // MainWorkFormAdmin - LoadDataGridViewApplication
        public string sqlComOutputCompleteApplication = "select FK_ID_Application, User_Surname, " +
            "User_Name, User_Patronymic, Date_Of_Answer, Status_Name from " +
            "Ready_Application join Info_About_User on " +
            "Ready_Application.FK_Info_User = Info_About_User.ID_Info_User " +
            "join Application_To_Company on Ready_Application.FK_ID_Application = " +
            "Application_To_Company.ID_Application join Status_Application on " +
            "Application_To_Company.FK_Status_Application = Status_Application.ID_Status ";
        public string SqlComOutputAnswerAllWorkerWithDateTime
            (string firstDate, string secondDate)
        {
            string sqlCom = "select FK_ID_Application, User_Surname, User_Name, " +
                "User_Patronymic, Date_Of_Answer, Status_Name from Ready_Application " +
                "join Info_About_User on Ready_Application.FK_Info_User = " +
                "Info_About_User.ID_Info_User join Application_To_Company on " +
                "Ready_Application.FK_ID_Application = Application_To_Company.ID_Application " +
                "join Status_Application on Application_To_Company.FK_Status_Application = " +
                "Status_Application.ID_Status where Date_Of_Request " +
                $"BETWEEN '{firstDate}T00:00:00' AND '{secondDate}T23:59:59' order by Date_Of_Answer";
            return sqlCom;
        }
        #endregion
        #region [AddUserForm]
        // AddUserForm - InputUsersButton
        public string SqlComRoleAddUser(string role)
        {
            string sqlCom = $"select ID_Role_User from Role_User where Role_Title = '{role}'";
            return sqlCom;
        }
        // AddUserForm - InputUsersButton
        public string SqlComCheckLogin(string login)
        {
            string sqlCom = $"select * from Authentication_ where Login_User = '{login}'";
            return sqlCom;
        }
        public string SqlComCheckEmail(string email)
        {
            string sqlCom = $"select * from Authentication_ where Email = '{email}'";
            return sqlCom;
        }
        // AddUserForm - InputUsersButton
        public string SqlComInsertUser(string login, string pass, string role, string email)
        {
            string sqlCom = "insert into Authentication_" +
                "(Login_User, Password_User, FK_Role_User, Email) " +
                $"values('{login}', '{pass}', '{role}', '{email}')";
            return sqlCom;
        }
        public string SqlComUpdateUser
            (string idUser, string login, string pass, string role, string email)
        {
            string sqlCom = $"update Authentication_ set Login_User = '{login}', " +
                $"Password_User = '{pass}', FK_Role_User = '{role}', " +
                $"Email = '{email}' where ID_User = '{idUser}'";
            return sqlCom;
        }
        // AddUserForm - CheckTextBoxIsNull
        public string SqlComInsertFio(string name, string fam, string otch)
        {
            string sqlCom = $"insert into Info_About_User(User_Surname, User_Name, User_Patronymic) " +
                $"values ('{fam}', '{name}', '{otch}')";
            return sqlCom;
        }
        public string SqlComInsertFioWithoutOtch(string name, string fam)
        {
            string sqlCom = $"insert into Info_About_User(User_Surname, User_Name) " +
                $"values ('{fam}', '{name}')";
            return sqlCom;
        }
        public string SqlComUpdateFio(string name, string fam, string otch, string idRow)
        {
            string sqlCom = $"update Info_About_User set User_Surname = '{fam}', " +
                $"User_Name = '{name}', User_Patronymic = '{otch}' " +
                $"from Authentication_ join Info_About_User " +
                $"on Authentication_.FK_Info_User = Info_About_User.ID_Info_User " +
                $"where ID_User = '{idRow}'";
            return sqlCom;
        }
        public string SqlComUpdateFioWithoutOtch(string name, string fam, string idRow)
        {
            string sqlCom = $"update Info_About_User set User_Surname = '{fam}', " +
                $"User_Name = '{name}', User_Patronymic = '' " +
                $"from Authentication_ join Info_About_User " +
                $"on Authentication_.FK_Info_User = Info_About_User.ID_Info_User " +
                $"where ID_User = '{idRow}'";
            return sqlCom;
        }
        public string SqlComCheckAccountInfo(string idUser)
        {
            string sqlCom = "select Login_User, Password_User, Email, User_Surname, " +
                "User_Name, User_Patronymic, Role_Title from Authentication_ join Info_About_User " +
                "on Authentication_.FK_Info_User = Info_About_User.ID_Info_User join Role_User " +
                $"on Authentication_.FK_Role_User = Role_User.ID_Role_User where ID_User = '{idUser}'";
            return sqlCom;
        }
        // AddUserForm - InputUsersButton
        public string SqlComTakeFKFio(string name, string fam, string otch)
        {
            string sqlCom = "select * from Info_About_User where " +
                $"User_Surname = '{fam}' and User_Name = '{name}' and User_Patronymic = '{otch}'";
            return sqlCom;
        }
        public string SqlComTakeFKFi(string name, string fam)
        {
            string sqlCom = "select * from Info_About_User where " +
                $"User_Surname = '{fam}' and User_Name = '{name}'";
            return sqlCom;
        }
        // AddUserForm - InputUsersButton
        public string SqlComUpdateAuth(string fioFK, string login)
        {
            string sqlCom = $"update Authentication_ set " +
                $"FK_Info_User = '{fioFK}' where Login_User = '{login}'";
            return sqlCom;
        }
        #endregion
        #region [UserApplicationInfoForWorkerForm]
        public string sqlComCheckApplicationWorker = "select " +
                    "ID_Application, Applicant_Company, " +
                    "Type_Appeal, Description_Of_Appeal, " +
                    "Date_Of_Request, Document_Name " +
                    "from Application_To_Company " +
                    "join Type_Of_Appeal on " +
                    "Application_To_Company.FK_Type_Of_Appeal " +
                    "= Type_Of_Appeal.ID_Type_Of_Appeal " +
                    "full join Application_Document_From_User " +
                    "on Application_To_Company." +
                    "FK_Application_Document_From_User = " +
                    "Application_Document_From_User." +
                    $"ID_Document_From_User where " +
                    $"Id_Application = " +
                    $"'{MainWorkFormWorker.SelectedRowID}'";
        public string sqlComOpenDocumentWorker = "select " +
                "Document_Name, Document_Data, " +
                "Document_Extension from Application_To_Company " +
                "join Application_Document_From_User " +
                "on Application_To_Company." +
                "FK_Application_Document_From_User" +
                " = Application_Document_From_User." +
                $"ID_Document_From_User where ID_Application = " +
                $"'{MainWorkFormWorker.SelectedRowID}'";
        #endregion
        #region [CreateApplicationForm]
        public string sqlComFkInfoUser = "select * from Info_About_User where " +
            $"User_Surname = '{MainWorkForm.surnameUserString}' and " +
            $"User_Name = '{MainWorkForm.nameUserString}' and " +
            $"User_Patronymic = '{MainWorkForm.patronymicUserString}'";
        public string SqlComCheckTypeID(string typeName)
        {
            string sqlCom = "select Id_Type_Of_Appeal " +
                $"from Type_Of_Appeal where Type_Appeal = '{typeName}'";
            return sqlCom;
        }
        public string SqlComAddApplication(string company, string type,
            string description, DateTime dateTime, string infoUser)
        {
            string sqlCom = "insert into Application_To_Company (Applicant_Company, " +
                "FK_Type_Of_Appeal, Description_Of_Appeal, Date_Of_Request, " +
                $"FK_Info_User, FK_Status_Application) values ('{company}', " +
                $"'{type}', '{description}', '{dateTime}', '{infoUser}', '1')";
            return sqlCom;
        }
        public string SqlComAddDocument(string infoUser)
        {
            string sqlCom = "insert into Application_Document_From_User(Document_Name, " +
                $"Document_Data, Document_Extension, FK_Info_User) values (@fileName, " +
                $"@data, @extension, '{infoUser}')";
            return sqlCom;
        }
        public string SqlComInfoAboutDocument(string documentName, string documentExtansion)
        {
            string sqlCom = "select * from Application_Document_From_User " +
                $"where Document_Name = '{documentName}' " +
                $"and Document_Extension = '{documentExtansion}'";
            return sqlCom;
        }
        public string SqlComAddApplicationSecond(string company, string type,
            string description, DateTime dateTime, string infoUser, string documentId)
        {
            string sqlCom = "insert into Application_To_Company (Applicant_Company, " +
                "FK_Type_Of_Appeal, Description_Of_Appeal, Date_Of_Request, " +
                "FK_Info_User, FK_Application_Document_From_User, " +
                $"FK_Status_Application) values ('{company}', " +
                $"'{type}', '{description}', '{dateTime}', " +
                $"'{infoUser}', '{documentId}', '1')";
            return sqlCom;
        }
        public string SqlComCheckDocumentName(string name)
        {
            string sqlCom = "select * from Application_Document_From_User " +
                $"where Document_Name = '{name}'";
            return sqlCom;
        }
        #endregion
        #region [AnswerToUserApplicationForm]
        public string SqlComCheckDocumentNameWorker(string name)
        {
            string sqlCom = "select * from Answer_Document_From_Worker " +
                $"where Document_Name_W = '{name}'";
            return sqlCom;
        }
        public string SqlComTakeFkInfoWorker(string name, string fam, string otch)
        {
            string sqlCom = "select * from Info_About_User where " +
                $"User_Surname = '{fam}' and User_Name = '{name}' " +
                $"and User_Patronymic = '{otch}'";
            return sqlCom;
        }
        public string SqlComTakeFkInfoWorkerWithoutOtch(string name, string fam)
        {
            string sqlCom = "select * from Info_About_User where " +
                $"User_Surname = '{fam}' and User_Name = '{name}'";
            return sqlCom;
        }
        public string SqlComCheckStatusID(string statusName)
        {
            string sqlCom = "select ID_Status from Status_Application " +
                $"where Status_Name = '{statusName}'";
            return sqlCom;
        }
        public string SqlComUpdateStatus(string status, string idRow)
        {
            string sqlCom = "update Application_To_Company set " +
                $"FK_Status_Application = '{status}' where ID_Application = '{idRow}'";
            return sqlCom;
        }
        public string SqlComCreateReadyApplicationWithoutDocument
            (string idRow, string idUser, string description, DateTime dateTime)
        {
            string sqlCom = "insert into Ready_Application(FK_ID_Application, " +
                "FK_Info_User, Answer_To_Application, Date_Of_Answer) values " +
                $"('{idRow}', '{idUser}', '{description}', '{dateTime}')";
            return sqlCom;
        }
        public string SqlComInsertWorkerDoc(string infoUser)
        {
            string sqlCom = "insert into Answer_Document_From_Worker(Document_Name_W, " +
                "Document_Data_W, Document_Extension_W, FK_Info_User) values " +
                $"(@filename, @data, @extn, '{infoUser}')";
            return sqlCom;
        }
        public string SqlComInfoAboutDocumentWorker
            (string documentName, string documentExtension)
        {
            string sqlCom = "select * from Answer_Document_From_Worker where " +
                $"Document_Name_W = '{documentName}' and " +
                $"Document_Extension_W = '{documentExtension}'";
            return sqlCom;
        }
        public string SqlComCreateReadyApplicationWithDocument
            (string idRow, string idUser, string description, 
            DateTime dateTime, string idDocument)
        {
            string sqlCom = "insert into Ready_Application(FK_ID_Application, " +
                "FK_Info_User, Answer_To_Application, Date_Of_Answer, " +
                "FK_Answer_Document_From_Worker) values " +
                $"('{idRow}', '{idUser}', " +
                $"'{description}', '{dateTime}', " +
                $"'{idDocument}')";
            return sqlCom;
        }
        public string SqlComFioApplication(string idApplication)
        {
            string sqlCom = "select ID_Application, User_Surname, User_Name, " +
                "User_Patronymic from Application_To_Company join " +
                "Info_About_User on Application_To_Company.FK_Info_User = " +
                $"Info_About_User.ID_Info_User where ID_Application = '{idApplication}'";
            return sqlCom;
        }
        #endregion
        #region [MainWorkFormWorker]
        public string SqlComTakeFioWorker(string login)
        {
            string sqlCom = "select * from Info_About_User join Authentication_ " +
                "on Authentication_.FK_Info_User = Info_About_User.ID_Info_User " +
                $"where Authentication_.Login_User = '{login}'";
            return sqlCom;
        }
        public string SqlComCheckWorkerFio(string name, string fam, string otch)
        {
            string sqlCom = "select * from Info_About_User where " +
                $"User_Surname = '{fam}' and User_Name = '{name}' " +
                $"and User_Patronymic = '{otch}'";
            return sqlCom;
        }
        public string SqlComInsertWorkerFio(string name, string fam, string otch)
        {
            string sqlCom = "insert into Info_About_User(User_Surname, " +
                $"User_Name, User_Patronymic) values ('{fam}','{name}','{otch}')";
            return sqlCom;
        }
        public string SqlComUpdateWorkerForFio(string name, string fam, string otch, string login)
        {
            string sqlCom = $"update Authentication_ set FK_Info_User = " +
                "Info_About_User.ID_Info_User from Info_About_User where " +
                $"Info_About_User.User_Surname = '{fam}' and " +
                $"Info_About_User.User_Name = '{name}' and " +
                $"Info_About_User.User_Patronymic = '{otch}' and " +
                $"Authentication_.Login_User = '{login}'";
            return sqlCom;
        }
        public string SqlComOutputAnswers(string name, string fam, string otch)
        {
            string sqlCom = "select FK_ID_Application, User_Surname, " +
                "User_Name, User_Patronymic, Date_Of_Answer, Status_Name from " +
                "Ready_Application join Info_About_User on Ready_Application.FK_Info_User " +
                $"= Info_About_User.ID_Info_User join Application_To_Company on " +
                $"Ready_Application.FK_ID_Application = Application_To_Company.ID_Application " +
                $"join Status_Application " +
                $"on Application_To_Company.FK_Status_Application = " +
                $"Status_Application.ID_Status where User_Surname = '{fam}' " +
                $"and User_Name = '{name}' and User_Patronymic = '{otch}'";
            return sqlCom;
        }
        public string SqlComOutputAnswersWithoudOtch(string name, string fam)
        {
            string sqlCom = "select FK_ID_Application, User_Surname, " +
                "User_Name, User_Patronymic, Date_Of_Answer, Status_Name from " +
                "Ready_Application join Info_About_User on Ready_Application.FK_Info_User " +
                $"= Info_About_User.ID_Info_User join Application_To_Company on " +
                $"Ready_Application.FK_ID_Application = Application_To_Company.ID_Application " +
                $"join Status_Application " +
                $"on Application_To_Company.FK_Status_Application = " +
                $"Status_Application.ID_Status where User_Surname = '{fam}' " +
                $"and User_Name = '{name}'";
            return sqlCom;
        }
        public string sqlComOutputApplications = "select Id_Application, " +
            "Applicant_Company, User_Surname, User_Name, User_Patronymic, " +
            "Status_Name from Application_To_Company join Info_About_User on " +
            "Application_To_Company.FK_Info_User = Info_About_User.ID_Info_User " +
            "join Status_Application on Application_To_Company.FK_Status_Application = " +
            "Status_Application.ID_Status full join " +
            "Application_Document_From_User on " +
            "Application_To_Company.FK_Application_Document_From_User = " +
            "Application_Document_From_User.ID_Document_From_User " +
            "where Status_Application.Status_Name = 'Новое обращение' or " +
            "Status_Application.Status_Name = 'В процессе рассмотрения'";
        public string sqlComCheckStatusId = "select ID_Status from Status_Application " +
            "where Status_Name = 'В процессе рассмотрения'";
        public string SqlComUpdateStatusApplication(string idStatus, string idRow)
        {
            string sqlCom = "update Application_To_Company set " +
                $"FK_Status_Application = '{idStatus}' " +
                $"where ID_Application = '{idRow}'";
            return sqlCom;
        }
        public string SqlComOpenWorkerDocument(string idRow)
        {
            string sqlCom = "select Document_Name_W, Document_Data_W, " +
                "Document_Extension_W from Ready_Application join " +
                "Answer_Document_From_Worker on " +
                "Ready_Application.FK_Answer_Document_From_Worker = " +
                "ID_Document_From_Worker join Application_To_Company on " +
                "Ready_Application.FK_ID_Application = " +
                $"Application_To_Company.ID_Application where ID_Application = '{idRow}'";
            return sqlCom;
        }
        public string SqlComOpenWorkerAnswer(string idRow)
        {
            string sqlCom = "select FK_ID_Application, Type_Appeal, Status_Name, " +
                "Answer_To_Application, Date_Of_Answer, Document_Name_W " +
                "from Ready_Application full join Answer_Document_From_Worker on " +
                "Ready_Application.FK_Answer_Document_From_Worker " +
                "= Answer_Document_From_Worker.ID_Document_From_Worker join " +
                "Application_To_Company on Application_To_Company.ID_Application " +
                "= Ready_Application.FK_ID_Application join Type_Of_Appeal on " +
                "Application_To_Company.FK_Type_Of_Appeal = " +
                "Type_Of_Appeal.ID_Type_Of_Appeal join Status_Application on " +
                "Application_To_Company.FK_Status_Application = " +
                $"Status_Application.ID_Status where FK_ID_Application = '{idRow}'";
            return sqlCom;
        }
        #endregion
        #region [SupplementForm]
        public string SqlComSupplementInfo(string idRow)
        {
            string sqlCom = "select " +
                    "ID_Application, Applicant_Company, " +
                    "Type_Appeal, Description_Of_Appeal, " +
                    "Date_Of_Request, Document_Name " +
                    "from Application_To_Company " +
                    "join Type_Of_Appeal on " +
                    "Application_To_Company.FK_Type_Of_Appeal " +
                    "= Type_Of_Appeal.ID_Type_Of_Appeal " +
                    "full join Application_Document_From_User " +
                    "on Application_To_Company." +
                    "FK_Application_Document_From_User = " +
                    "Application_Document_From_User." +
                    $"ID_Document_From_User where " +
                    $"Id_Application = " +
                    $"'{idRow}'";
            return sqlCom;
        }
        public string SqlComGetFioWorker(string idRow)
        {
            string sqlCom = "select User_Surname, User_Name, User_Patronymic " +
                "from Ready_Application join Info_About_User on " +
                "Ready_Application.FK_Info_User = Info_About_User.ID_Info_User " +
                "join Application_To_Company " +
                "on Application_To_Company.ID_Application = Ready_Application.FK_ID_Application " +
                "join Status_Application " +
                "on Status_Application.ID_Status = Application_To_Company.FK_Status_Application " +
                $"where Application_To_Company.ID_Application = '{idRow}'";
            return sqlCom;
        }
        public string SqlComGetFioUser(string idRow)
        {
            string sqlCom = "select User_Surname, User_Name, User_Patronymic " +
                "from Application_To_Company join Info_About_User " +
                "on Application_To_Company.FK_Info_User = Info_About_User.ID_Info_User " +
                "join Status_Application " +
                "on Status_Application.ID_Status = Application_To_Company.FK_Status_Application " +
                "join Ready_Application " +
                "on Ready_Application.FK_ID_Application = Application_To_Company.ID_Application " +
                $"where Ready_Application.ID_Ready_Application = '{idRow}'";
            return sqlCom;
        }
        public string SqlComGetEmailWorker(string name, string fam, string otch)
        {
            string sqlCom = "select Email from Authentication_ " +
                "join Info_About_User on Authentication_.FK_Info_User = Info_About_User.ID_Info_User " +
                $"where User_Surname = '{fam}' and User_Name = '{name}' and User_Patronymic = '{otch}'";
            return sqlCom;
        }
        public string SqlComUpdateApplication(string desc, string dateTime, string idRow)
        {
            string sqlCom = "update Application_To_Company set " +
                $"Description_Of_Appeal = '{desc}', " +
                $"Date_Of_Request = '{dateTime}' where ID_Application = '{idRow}'";
            return sqlCom;
        }
        public string SqlComUpdateStatusAppl(string idRow)
        {
            string sqlCom = "update Application_To_Company set " +
                $"FK_Status_Application = '5' where ID_Application = '{idRow}'";
            return sqlCom;
        }
        public string SqlComUpdateDocumentUser(string idRow)
        {
            string sqlCom = "update Application_Document_From_User set " +
                "Document_Name = @filename, Document_Data = @data, Document_Extension = @extn " +
                "from Application_To_Company join Application_Document_From_User on " +
                "Application_To_Company.FK_Application_Document_From_User " +
                "= Application_Document_From_User.ID_Document_From_User " +
                $"where ID_Application = '{idRow}'";
            return sqlCom;
        }
        #endregion
        #region [SupplementWorkForm]
        public string SqlComUpdateAnswer(string desc, string dateTime, string idRow)
        {
            string sqlCom = $"update Ready_Application set Answer_To_Application = '{desc}', " +
                $"Date_Of_Answer = '{dateTime}' where ID_Ready_Application = '{idRow}'";
            return sqlCom;
        }
        public string SqlComUpdateDocumentWorker(string idRow)
        {
            string sqlCom = "update Answer_Document_From_Worker set " +
                "Document_Name_W = @filename, Document_Data_W = @data, " +
                "Document_Extension_W = @extn " +
                "from Ready_Application join Answer_Document_From_Worker on " +
                "Ready_Application.FK_Answer_Document_From_Worker " +
                "= Answer_Document_From_Worker.ID_Document_From_Worker " +
                $"where ID_Application = '{idRow}'";
            return sqlCom;
        }
        public string SqlComGetReadyId(string idRow)
        {
            string sqlCom = "select ID_Ready_Application from " +
                $"Ready_Application where FK_ID_Application = '{idRow}'";
            return sqlCom;
        }
        public string SqlComOutputAnswerWithDateTime
            (string name, string fam, string otch, string firstDate, string secondDate)
        {
            string sqlCom = "select FK_ID_Application, User_Surname, User_Name, " +
                "User_Patronymic, Date_Of_Answer, Status_Name from Ready_Application " +
                "join Info_About_User on Ready_Application.FK_Info_User = Info_About_User.ID_Info_User " +
                "join Application_To_Company on " +
                "Ready_Application.FK_ID_Application = Application_To_Company.ID_Application " +
                "join Status_Application on " +
                "Application_To_Company.FK_Status_Application = Status_Application.ID_Status " +
                $"where User_Surname = '{fam}' and User_Name = '{name}' " +
                $"and User_Patronymic = '{otch}' and Date_Of_Answer " +
                $"BETWEEN '{firstDate}T00:00:00' AND '{secondDate}T23:59:59' order by Date_Of_Answer";
            return sqlCom;
        }
        public string SqlComOutputAnswerWithDateTimeWithoutOtch
            (string name, string fam, string firstDate, string secondDate)
        {
            string sqlCom = "select FK_ID_Application, User_Surname, User_Name, " +
                "User_Patronymic, Date_Of_Answer, Status_Name from Ready_Application " +
                "join Info_About_User on Ready_Application.FK_Info_User = Info_About_User.ID_Info_User " +
                "join Application_To_Company on " +
                "Ready_Application.FK_ID_Application = Application_To_Company.ID_Application " +
                "join Status_Application on " +
                "Application_To_Company.FK_Status_Application = Status_Application.ID_Status " +
                $"where User_Surname = '{fam}' and User_Name = '{name}' and Date_Of_Answer " +
                $"BETWEEN '{firstDate}T00:00:00' AND '{secondDate}T23:59:59' order by Date_Of_Answer";
            return sqlCom;
        }
        #endregion
        #region [AuthFioWorkerForm]
        public string SqlComTakeIdWorkerFull(string name, string fam, string otch)
        {
            string sqlCom = "select ID_Info_User from Info_About_User where " +
                $"User_Surname = '{fam}' and User_Name = '{name}' and User_Patronymic = '{otch}'";
            return sqlCom;
        }
        public string SqlComTakeIdWorker(string name, string fam)
        {
            string sqlCom = "select ID_Info_User from Info_About_User where " +
                $"User_Surname = '{fam}' and User_Name = '{name}'";
            return sqlCom;
        }
        public string SqlComCheckAccountWorker(string idWorker)
        {
            string sqlCom = $"select ID_User from Authentication_ where FK_Info_User = '{idWorker}'";
            return sqlCom;
        }
        #endregion
        #region [RegistrationForm]
        public string SqlComSetWorkerIdToAccount(string idWorker, string login)
        {
            string sqlCom = $"update Authentication_ set FK_Info_User = '{idWorker}' " +
                $"where Login_User = '{login}'";
            return sqlCom;
        }
        #endregion
    }
}