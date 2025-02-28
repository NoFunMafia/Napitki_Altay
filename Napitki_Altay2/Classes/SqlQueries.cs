﻿#region [using's]
using Napitki_Altay2.Forms;
using System;
#endregion
namespace Napitki_Altay2.Classes
{
    internal class SqlQueries
    {
        #region [MainWorkForm]
        // MainWorkForm - MainWorkForm_Load
        public string sqlComRecFIO = $"select * from User_Info " +
                $"join User_Auth on User_Auth.User_ID " +
                $"= User_Info.User_ID " +
                $"where User_Auth.Username = " +
                $"'{AuthForm.LoginString}'";

        // MainWorkForm - LoadDataGridView
        public string SqlOutputMWF(string name, string fam, string otch)
        {
            string sqlCom = "SELECT " +
                "User_Appeal.Appeal_ID, " +
                "User_Info.Last_Name, " +
                "User_Info.First_Name, " +
                "User_Info.Middle_Name, " +
                "Appeal_Status.Status_Name " +
                "FROM User_Appeal " +
                "JOIN User_Info ON User_Appeal.User_ID = User_Info.User_ID " +
                "JOIN Appeal_Status ON User_Appeal.Status_ID = Appeal_Status.Status_ID " +
                $"WHERE User_Info.First_Name = '{name}' " +
                $"AND User_Info.Last_Name = '{fam}' " +
                $"AND User_Info.Middle_Name = '{otch}' " +
                $"AND (Appeal_Status.Status_ID = 1 OR Appeal_Status.Status_ID = 2)";
            return sqlCom;
        }

        // MainWorkForm - LoadDataGridViewComplete
        public string SqlComIDUser(string fam, string name, string otch)
        {
            string sqlCom = $"select * " +
                    $"from User_Info " +
                    $"where Last_Name = " +
                    $"'{fam}' " +
                    $"and First_Name = '{name}' " +
                    $"and Middle_Name = " +
                    $"'{otch}'";
            return sqlCom;
        }

        // MainWorkForm - LoadDataGridViewComplete2
        public string SqlComFKInfo(string fkInfoUser)
        {
            string sqlCom = "SELECT " +
            "Appeal_Response.Appeal_ID, " +
            "User_Info.Last_Name, " +
            "User_Info.First_Name, " +
            "User_Info.Middle_Name, " +
            "Appeal_Response.Response_Date, " +
            "Appeal_Status.Status_Name " +
            "FROM Appeal_Response " +
            "JOIN User_Info ON Appeal_Response.Worker_ID = User_Info.User_ID " +
            "JOIN User_Appeal ON User_Appeal.Appeal_ID = Appeal_Response.Appeal_ID " +
            "JOIN Appeal_Status ON Appeal_Status.Status_ID = User_Appeal.Status_ID " +
            $"WHERE User_Appeal.User_ID = '{fkInfoUser}'";
            return sqlCom;
        }

        public string SqlComCheckInfoAcc(string idAcc)
        {
            string sqlCom = "select Username, User_Password, Email, " +
                "Role_Name, Employee_Number from User_Auth join User_Role " +
                "on User_Auth.Role_ID = User_Role.Role_ID " +
                $"where Auth_ID = '{idAcc}'";
            return sqlCom;
        }
        // MainWorkForm - UpdLogPassButton_Click
        public string SqlComUpdPass(string pass)
        {
            string sqlCom = "update User_Auth " +
                "set User_Password = " +
                $"'{pass}' where Username = '{AuthForm.LoginString}'";
            return sqlCom;
        }

        // MainWorkForm - CheckFIOUserInDB
        public string SqlComCheckINFOonFIO(string fam, string name, string otch)
        {
            string sqlCom = "select * from User_Info " +
                $"where Last_Name = '{fam}' " +
                $"and First_Name = '{name}' " +
                $"and Middle_Name = '{otch}'";
            return sqlCom;
        }

        // MainWorkForm - CreateUserFIOButton_Click
        public string SqlComInsFIO(string fam, string name, string otch)
        {
            string sqlQuery = "insert into User_Info " +
            "(Last_Name, First_Name, Middle_Name) " +
            $"values ('{fam}', '{name}', '{otch}')";
            return sqlQuery;
        }

        // MainWorkForm - CreateUserFIOButton_Click
        public string SqlComInsFIOSec(string fam, string name, string otch)
        {
            string sqlQuery = "update User_Auth " +
                $"set User_ID = User_Info.User_ID " +
                $"from User_Info where " +
                $"User_Info.Last_Name = '{fam}' " +
                $"and User_Info.First_Name = '{name}' " +
                $"and User_Info.Middle_Name = '{otch}' " +
                $"and User_Auth.Username = '{AuthForm.LoginString}'";
            return sqlQuery;
        }

        // MainWorkForm - UpdateDataInDGW_Click
        public string SqlComUpdateDGW(string fam, string name, string otch)
        {
            string sqlCom = "SELECT User_Appeal.Appeal_ID, " +
                "User_Info.Last_Name, " +
                "User_Info.First_Name, " +
                "User_Info.Middle_Name, " +
                "Appeal_Status.Status_Name " +
                "FROM User_Appeal " +
                "JOIN User_Info ON " +
                "User_Appeal.User_ID = User_Info.User_ID " +
                "JOIN Appeal_Status ON " +
                "User_Appeal.Status_ID = Appeal_Status.Status_ID " +
                "WHERE User_Info.First_Name = " +
                $"'{name}' AND " +
                $"User_Info.Last_Name = " +
                $"'{fam}' AND " +
                $"User_Info.Middle_Name = " +
                $"'{otch}' AND (Appeal_Status.Status_ID = 1 OR Appeal_Status.Status_ID = 2)";
            return sqlCom;
        }

        // MainWorkForm - DeleteApplicationButton_Click
        public string SqlComDelete(string deleteRow)
        {
            string sqlCom = $@"
            -- Удаляем сами документы, если они больше нигде не используются
            DELETE FROM User_Document 
            WHERE Document_ID IN (
            SELECT Document_ID FROM Appeal_Documents 
            GROUP BY Document_ID 
            HAVING COUNT(Appeal_ID) = 1);
            -- Удаляем связи между обращением и документами
            DELETE FROM Appeal_Documents WHERE Appeal_ID = '{deleteRow}';
            -- Удаляем само обращение
            DELETE FROM User_Appeal WHERE Appeal_ID = '{deleteRow}';";
            return sqlCom;
        }
        #endregion
        #region [AuthForm]
        // AuthForm - LogInAppButton_Click
        public string SqlComRoleUser(string login, string pass)
        {
            string sqlCom = "select * from User_Auth " +
                $"where Username = '{login}' and User_Password = '{pass}'";
            return sqlCom;
        }
        // AuthForm - LogInAppButton_Click
        public string SqlComRole(string login, string pass, string role)
        {
            string sqlCom = "select * from User_Auth " +
                $"where Username = '{login}' and User_Password = '{pass}' " +
                $"and Role_ID = '{role}'";
            return sqlCom;
        }
        // AuthForm - OpenSpecificForm
        public string SqlComTitleRole(string role)
        {
            string sqlCom = $"select Role_Name from User_Role " +
                $"where Role_ID = '{role}'";
            return sqlCom;
        }
        #endregion
        #region [MainWorkFormAdmin]
        // MainWorkFormAdmin - MainWorkFormAdmin_Load
        public string sqlComOutputUsers = "select Auth_ID, Username, User_Password, " +
            "Last_Name, First_Name, Middle_Name, Role_Name, Email " +
            "from User_Auth join User_Role on " +
            "User_Auth.Role_ID = User_Role.Role_ID left join " +
            "User_Info on User_Auth.User_ID = User_Info.User_ID";
        // MainWorkFormAdmin - LoadDataGridViewApplication
        public string sqlComOutputCompleteApplication = "SELECT Appeal_Responce.Appeal_ID, " +
                "User_Info.Last_Name, User_Info.First_Name, User_Info.Middle_Name, " +
                "Appeal_Responce.Response_Date, Appeal_Status.Status_Name " +
                "FROM Appeal_Response Appeal_Responce " +
                "JOIN User_Info ON Appeal_Responce.Worker_ID = User_Info.User_ID " +
                "JOIN User_Appeal ON Appeal_Responce.Appeal_ID = User_Appeal.Appeal_ID " +
                "JOIN Appeal_Status ON User_Appeal.Status_ID = Appeal_Status.Status_ID";
        public string SqlComOutputAnswerAllWorkerWithDateTime
            (string firstDate, string secondDate)
        {
            string sqlCom = "SELECT Appeal_Response.Appeal_ID, " +
                "User_Info.Last_Name, User_Info.First_Name, User_Info.Middle_Name, " +
                "Appeal_Response.Response_Date, Appeal_Status.Status_Name " +
                "FROM Appeal_Response " +
                "JOIN User_Info ON Appeal_Response.Worker_ID = User_Info.User_ID " +
                "JOIN User_Appeal ON Appeal_Response.Appeal_ID = User_Appeal.Appeal_ID " +
                "JOIN Appeal_Status ON User_Appeal.Status_ID = Appeal_Status.Status_ID " +
                $"WHERE User_Appeal.Appeal_Date BETWEEN '{firstDate}T00:00:00' AND '{secondDate}T23:59:59' " +
                "ORDER BY Appeal_Response.Response_Date";
            return sqlCom;
        }
        #endregion
        #region [AddUserForm]
        // AddUserForm - InputUsersButton
        public string SqlComRoleAddUser(string role)
        {
            string sqlCom = $"select Role_ID from User_Role where Role_Name = '{role}'";
            return sqlCom;
        }
        // AddUserForm - InputUsersButton
        public string SqlComCheckLogin(string login)
        {
            string sqlCom = $"select * from User_Auth where Username = '{login}'";
            return sqlCom;
        }
        public string SqlComCheckEmail(string email)
        {
            string sqlCom = $"select * from User_Auth where Email = '{email}'";
            return sqlCom;
        }
        public string SqlComCheckEmpNum(string empNum, string role)
        {
            string sqlCom;
            if (role == "Администратор" || role == "Муниципальный служащий")
            {
                sqlCom = $"SELECT COUNT(*) FROM User_Info WHERE Employee_Number = '{empNum}'";
            }
            else
            {
                sqlCom = "SELECT 0"; // Если роль - заявитель, то проверка всегда пройдет
            }
            return sqlCom;
        }

        // AddUserForm - InputUsersButton
        public string SqlComInsertUser(string login, string pass, string role, string email)
        {
            string sqlCom = "insert into User_Auth" +
                "(Username, User_Password, Role_ID, Email) " +
                $"values('{login}', '{pass}', '{role}', '{email}')";
            return sqlCom;
        }
        public string SqlComUpdateUser
            (string idUser, string login, string pass, string role, string email)
        {
            string sqlCom = $"update User_Auth set Username = '{login}', " +
                $"User_Password = '{pass}', Role_ID = '{role}', " +
                $"Email = '{email}' where User_Auth.Auth_ID = '{idUser}'";
            return sqlCom;
        }
        // AddUserForm - CheckTextBoxIsNull
        public string SqlComInsertFio(string name, string fam, string otch, string empNum)
        {
            string sqlCom = $"insert into User_Info(Last_Name, First_Name, Middle_Name, Employee_Number) " +
                $"values ('{fam}', '{name}', '{otch}', '{empNum}')";
            return sqlCom;
        }
        public string SqlComInsertFioWithoutOtch(string name, string fam, string empNum)
        {
            string sqlCom = $"insert into User_Info(Last_Name, First_Name, Employee_Number) " +
                $"values ('{fam}', '{name}', '{empNum}')";
            return sqlCom;
        }
        public string SqlComUpdateFio(string name, string fam, string otch, string idRow)
        {
            string sqlCom = $"update User_Info set Last_Name = '{fam}', " +
                $"First_Name = '{name}', Middle_Name = '{otch}' " +
                $"from User_Auth join User_Info " +
                $"on User_Auth.User_ID = User_Info.User_ID " +
                $"where User_Info.User_ID = '{idRow}'";
            return sqlCom;
        }
        public string SqlComUpdateFioWithoutOtch(string name, string fam, string idRow)
        {
            string sqlCom = $"update User_Info set Last_Name = '{fam}', " +
                $"First_Name = '{name}', Middle_Name = '' " +
                $"from User_Auth join User_Info " +
                $"on User_Auth.User_ID = User_Info.User_ID " +
                $"where User_ID = '{idRow}'";
            return sqlCom;
        }
        public string SqlComCheckAccountInfo(string idUser)
        {
            string sqlCom = "select Username, User_Password, Email, Employee_Number, Last_Name, " +
                "First_Name, Middle_Name, Role_Name from User_Auth left join User_Info " +
                "on User_Auth.User_ID = User_Info.User_ID join User_Role " +
                $"on User_Auth.Role_ID = User_Role.Role_ID where User_Auth.Auth_ID = '{idUser}'";
            return sqlCom;
        }
        // AddUserForm - InputUsersButton
        public string SqlComTakeFKFio(string name, string fam, string otch)
        {
            string sqlCom = "select * from User_Info where " +
                $"Last_Name = '{fam}' and First_Name = '{name}' and Middle_Name = '{otch}'";
            return sqlCom;
        }
        public string SqlComTakeFKFi(string name, string fam)
        {
            string sqlCom = "select * from User_Info where " +
                $"Last_Name = '{fam}' and First_Name = '{name}'";
            return sqlCom;
        }
        // AddUserForm - InputUsersButton
        public string SqlComUpdateAuth(string fioFK, string login)
        {
            string sqlCom = $"update User_Auth set " +
                $"User_ID = '{fioFK}' where Username = '{login}'";
            return sqlCom;
        }
        #endregion
        #region [UserApplicationInfoForWorkerForm]
        public string sqlComCheckApplicationWorker = "SELECT ua.Appeal_ID, at.Appeal_Name, " +
            "ua.Appeal_Description, ua.Appeal_Date FROM User_Appeal ua " +
            "JOIN Appeal_Type at ON ua.Appeal_Type_ID = at.Appeal_Type_ID " +
            $"WHERE ua.Appeal_ID = '{MainWorkFormWorker.SelectedRowID}'";
        public string sqlComOpenDocumentWorker = "SELECT DISTINCT ud.Document_Name, ud.Document_Data, ud.Document_Extension " +
            "FROM User_Document ud LEFT JOIN User_Appeal ua ON ud.User_ID = ua.User_ID " +
            $"WHERE ua.Appeal_ID = {MainWorkFormWorker.SelectedRowID};";
        #endregion
        #region [CreateApplicationForm]
        public string sqlComFkInfoUser = "select * from User_Info where " +
            $"Last_Name = '{MainWorkForm.surnameUserString}' and " +
            $"First_Name = '{MainWorkForm.nameUserString}' and " +
            $"Middle_Name = '{MainWorkForm.patronymicUserString}'";
        public string sqlComFkInfoWorkUser = "select * from User_Info where " +
            $"Last_Name = '{MainWorkFormWorker.SurnameWorkerString}' and " +
            $"First_Name = '{MainWorkFormWorker.NameWorkerString}' and " +
            $"Middle_Name = '{MainWorkFormWorker.PatrWorkerString}'";
        public string SqlComCheckTypeID(string typeName)
        {
            string sqlCom = "select Appeal_Type_ID " +
                $"from Appeal_Type where Appeal_Name = '{typeName}'";
            return sqlCom;
        }
        public string SqlComAddDocument(string infoUser)
        {
            string sqlCom = "insert into User_Document(Document_Name, " +
                $"Document_Data, Document_Extension, User_ID) values (@fileName, " +
                $"@data, @extension, '{infoUser}')";
            return sqlCom;
        }
        public string SqlComAddWorkDocument(string infoUser)
        {
            string sqlCom = "insert into Answer_Document_From_Worker(Document_Name_W, " +
                $"Document_Data_W, Document_Extension_W, FK_Info_User) values (@fileName, " +
                $"@data, @extension, '{infoUser}')";
            return sqlCom;
        }
        public string SqlComInfoAboutDocument(string documentName, string documentExtansion, string userID)
        {
            string sqlCom = "select Document_ID from User_Document " +
                $"where Document_Name = '{documentName}' " +
                $"and Document_Extension = '{documentExtansion}' and User_ID = '{userID}'";
            return sqlCom;
        }
        public string SqlComInfoAboutWDocument(string documentName, string documentExtansion)
        {
            string sqlCom = "select * from Answer_Document_From_Worker " +
                $"where Document_Name_W = '{documentName}' " +
                $"and Document_Extension_W = '{documentExtansion}'";
            return sqlCom;
        }
        public string SqlComAddApplicationSecond(string type,
            string description, DateTime dateTime, string infoUser)
        {
            string sqlCom = "insert into User_Appeal (Appeal_Type_ID, " +
                "Appeal_Description, Appeal_Date, User_ID, Status_ID) " +
                $"OUTPUT INSERTED.Appeal_ID values ('{type}', '{description}', '{dateTime}', '{infoUser}', '1')";
            return sqlCom;
        }
        public string LinkDocumentToAppealQuery()
        {
            return "INSERT INTO Appeal_Documents (Appeal_ID, Document_ID) VALUES (@AppealId, @DocId)";
        }
        #endregion
        #region [AnswerToUserApplicationForm]
        public string SqlComCheckStatusID(string statusName)
        {
            string sqlCom = "select Status_ID from Appeal_Status " +
                $"where Status_Name = '{statusName}'";
            return sqlCom;
        }
        public string SqlComUpdateStatus(string status, string idRow)
        {
            string sqlCom = "update User_Appeal set " +
                $"Status_ID = '{status}' where Appeal_ID = '{idRow}'";
            return sqlCom;
        }
        public string SqlComCreateAppealResponse(string appealId, string workerId, string responseText)
        {
            return $"INSERT INTO Appeal_Response (Appeal_ID, Worker_ID, Response_Text, Response_Date) " +
                   $"VALUES ('{appealId}', '{workerId}', '{responseText}', GETDATE()); SELECT SCOPE_IDENTITY();";
        }
        public string SqlComInsertWorkerDoc(string workerId)
        {
            return $"INSERT INTO Worker_Document (Document_Name, Document_Data, Document_Extension, Worker_ID) " +
                   $"VALUES (@filename, @data, @extn, '{workerId}'); SELECT SCOPE_IDENTITY();";
        }
        public string SqlComGetWorkerId(string name, string fam, string otch)
        {
            return $"SELECT User_ID FROM User_Info WHERE Last_Name = '{fam}' AND First_Name = '{name}' " +
                   (string.IsNullOrEmpty(otch) ? "" : $"AND Middle_Name = '{otch}'");
        }
        public string SqlComLinkDocumentToResponse(string responseId, string documentId)
        {
            return $"INSERT INTO Response_Documents (Response_ID, Document_ID) " +
                   $"VALUES ('{responseId}', '{documentId}');";
        }
        public string SqlComInfoAboutDocumentWorker
            (string documentName, string documentExtension)
        {
            string sqlCom = "select * from Answer_Document_From_Worker where " +
                $"Document_Name_W = '{documentName}' and " +
                $"Document_Extension_W = '{documentExtension}'";
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
            string sqlCom = "select * from User_Info join User_Auth " +
                $"on User_Auth.User_ID = User_Info.User_ID where User_Auth.Username = '{login}'";
            return sqlCom;
        }
        public string SqlComCheckWorkerFio(string name, string fam, string otch)
        {
            string sqlCom = "select * from User_Info where " +
                $"Last_Name = '{fam}' and First_Name = '{name}' and Middle_Name = '{otch}'";
            return sqlCom;
        }
        public string SqlComInsertWorkerFio(string name, string fam, string otch)
        {
            string sqlCom = "insert into User_Info(Last_Name, " +
                $"First_Name, Middle_Name) values ('{fam}','{name}','{otch}')";
            return sqlCom;
        }
        public string SqlComUpdateWorkerForFio(string name, string fam, string otch, string login)
        {
            string sqlCom = $"update User_Auth set User_Auth.User_ID = " +
                "User_Info.User_ID from User_Info where " +
                $"User_Info.Last_Name = '{fam}' and " +
                $"User_Info.First_Name = '{name}' and " +
                $"User_Info.Middle_Name = '{otch}' and " +
                $"User_Auth.Username = '{login}'";
            return sqlCom;
        }
        public string SqlComOutputAnswers(string workerID)
        {
            string sqlCom = "SELECT ua.Appeal_ID AS FK_ID_Application, " +
                "ui.Last_Name AS User_Surname, ui.First_Name AS User_Name, " +
                "ui.Middle_Name AS User_Patronymic, ar.Response_Date AS Date_Of_Answer, " +
                "asu.Status_Name FROM User_Appeal ua JOIN Appeal_Response ar " +
                "ON ua.Appeal_ID = ar.Appeal_ID JOIN User_Info ui ON ua.User_ID = ui.User_ID " +
                "JOIN Appeal_Status asu ON ua.Status_ID = asu.Status_ID " +
                $"WHERE asu.Status_Name = 'Рассмотрено и закрыто' AND ar.Worker_ID = '{workerID}' " +
                "ORDER BY ar.Response_Date DESC;\r\n";
            return sqlCom;
        }
        public string sqlComOutputApplications = "SELECT ua.Appeal_ID, " +
            "ui.Last_Name AS User_Surname, ui.First_Name AS User_Name, ui.Middle_Name AS User_Patronymic, " +
            "at.Appeal_Name, asu.Status_Name " +
            "FROM User_Appeal ua " +
            "JOIN User_Info ui ON ua.User_ID = ui.User_ID " +
            "JOIN Appeal_Status asu ON ua.Status_ID = asu.Status_ID " +
            "JOIN Appeal_Type at ON ua.Appeal_Type_ID = at.Appeal_Type_ID " +
            "WHERE asu.Status_Name IN ('Принято к рассмотрению', 'На исполнении')";
        public string sqlComCheckStatusId = "select Status_ID from Appeal_Status where Status_Name = 'На исполнении'";
        public string SqlComUpdateStatusApplication(string idStatus, string idRow)
        {
            string sqlCom = $"update User_Appeal set Status_ID = '{idStatus}' where Appeal_ID = '{idRow}'";
            return sqlCom;
        }
        public string SqlComOpenWorkerDocument(string idRow)
        {
            string sqlCom = "SELECT wd.Document_ID, wd.Document_Name, wd.Document_Data, wd.Document_Extension " +
                "FROM Worker_Document wd " +
                "JOIN Response_Documents rd ON wd.Document_ID = rd.Document_ID " +
                "JOIN Appeal_Response ar ON rd.Response_ID = ar.Response_ID " +
                $"WHERE ar.Appeal_ID = {idRow}";
            return sqlCom;
        }

        public string SqlComOpenWorkerAnswer(string idRow)
        {
            string sqlCom = "SELECT " +
                "ar.Appeal_ID AS FK_ID_Application, " +
                "at.Appeal_Name AS Type_Appeal, " +
                "asu.Status_Name, " +
                "ar.Response_Text AS Answer_To_Application, " +
                "CONVERT(VARCHAR, ar.Response_Date, 120) AS Date_Of_Answer, " +  // Формат без миллисекунд
                "STRING_AGG(wd.Document_Name, ', ') AS Document_Names " +  // Объединение всех документов в строку
            "FROM Appeal_Response ar " +
            "JOIN User_Appeal ua ON ar.Appeal_ID = ua.Appeal_ID " +  // Присоединяем обращение
            "JOIN Appeal_Type at ON ua.Appeal_Type_ID = at.Appeal_Type_ID " +  // Присоединяем тип обращения
            "JOIN Appeal_Status asu ON ua.Status_ID = asu.Status_ID " +  // Присоединяем статус
            "LEFT JOIN Response_Documents rd ON ar.Response_ID = rd.Response_ID " +  // Присоединяем документы к ответу
            "LEFT JOIN Worker_Document wd ON rd.Document_ID = wd.Document_ID " +  // Присоединяем документы сотрудника
            $"WHERE ar.Appeal_ID = '{idRow}' " +  // Фильтруем по ID обращения
            "GROUP BY ar.Appeal_ID, at.Appeal_Name, asu.Status_Name, ar.Response_Text, ar.Response_Date " +  // Группировка по уникальным полям
            "ORDER BY ar.Response_Date DESC;";
            return sqlCom;
        }
        public string SqlComGetResponseDocuments(string appealId)
        {
            string sqlCom = "SELECT wd.Document_Name, wd.Document_Data, wd.Document_Extension " +
                "FROM Worker_Document wd " +
                "JOIN Response_Documents rd ON wd.Document_ID = rd.Document_ID " +
                "JOIN Appeal_Response ar ON rd.Response_ID = ar.Response_ID " +
                $"WHERE ar.Appeal_ID = '{appealId}'";
            return sqlCom;
        }

        public string SqlComOpenWorkerAnswerDocInfo(string idRow)
        {
            string sqlCom = "select Document_Name_W from Ready_Application " +
                "full join Answer_Document_From_Worker " +
                "on Ready_Application.FK_Answer_Document_From_Worker = Answer_Document_From_Worker.ID_Document_From_Worker " +
                "join Application_To_Company " +
                "on Application_To_Company.ID_Application = Ready_Application.FK_ID_Application " +
                "join Type_Of_Appeal " +
                "on Application_To_Company.FK_Type_Of_Appeal = Type_Of_Appeal.ID_Type_Of_Appeal " +
                "join Status_Application " +
                "on Application_To_Company.FK_Status_Application = Status_Application.ID_Status " +
                $"where FK_ID_Application = '{idRow}'";
            return sqlCom;
        }
        #endregion
        #region [SupplementForm]
        public string SqlComGetResponseDocumentsUser(string appealId)
        {
            string sqlCom = "SELECT ud.Document_Name, ud.Document_Data, ud.Document_Extension " +
                "FROM User_Document ud " +
                "JOIN User_Appeal ua ON ud.User_ID = ua.User_ID " + // Связываем документы с пользователями через обращения
                $"WHERE ua.Appeal_ID = '{appealId}'";
            return sqlCom;
        }

        public string SqlComSupplementInfo(string idRow)
        {
            string sqlCom = "SELECT " +
                "ua.Appeal_ID, " +
                "at.Appeal_Name, " +
                "ui.Last_Name + ' ' + ui.First_Name + ISNULL(' ' + ui.Middle_Name, '') AS Full_Name, " +
                "ua.Appeal_Description, " +
                "ua.Appeal_Date, " +
                "asu.Status_Name, " +
                "STRING_AGG(ud.Document_Name, ', ') AS Attached_Documents " +
                "FROM User_Appeal ua " +
                "JOIN Appeal_Type at ON ua.Appeal_Type_ID = at.Appeal_Type_ID " +
                "JOIN User_Info ui ON ua.User_ID = ui.User_ID " +
                "JOIN Appeal_Status asu ON ua.Status_ID = asu.Status_ID " +
                "LEFT JOIN User_Document ud ON ua.User_ID = ud.User_ID " + // Убрана Appeal_Documents, связываем документы по User_ID
                $"WHERE ua.Appeal_ID = '{idRow}' " +
                "GROUP BY ua.Appeal_ID, at.Appeal_Name, ui.Last_Name, ui.First_Name, ui.Middle_Name, " +
                "ua.Appeal_Description, ua.Appeal_Date, asu.Status_Name";
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
        public string SqlComUpdateDocumentUserNew(string idDoc, string idRow)
        {
            string sqlCom = $"update Application_To_Company " +
                $"set FK_Application_Document_From_User = '{idDoc}' " +
                $"where ID_Application = '{idRow}'";
            return sqlCom;
        }
        public string SqlComUpdateDocumentWorkNew(string idDoc, string idRow)
        {
            string sqlCom = $"update Ready_Application " +
                $"set FK_Answer_Document_From_Worker = '{idDoc}' " +
                $"where ID_Ready_Application = '{idRow}'";
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
        public string SqlComTakeApplId(string idAppl)
        {
            string sqlCom = "select ID_Ready_Application " +
                $"from Ready_Application where FK_ID_Application = '{idAppl}'";
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
        public string SqlComOutputAnswerWithDateTime(string workerId, string firstDate, string secondDate)
        {
            string sqlCom = "SELECT " +
                "ua.Appeal_ID AS FK_ID_Application, " +
                "ui.Last_Name AS User_Surname, " +
                "ui.First_Name AS User_Name, " +
                "ui.Middle_Name AS User_Patronymic, " +
                "ar.Response_Date AS Date_Of_Answer, " +
                "asu.Status_Name " +
            "FROM User_Appeal ua " +
            "JOIN Appeal_Response ar ON ua.Appeal_ID = ar.Appeal_ID  " + // Обращения должны иметь ответ
            "JOIN User_Info ui ON ua.User_ID = ui.User_ID " + // ФИО заявителя
            "JOIN Appeal_Status asu ON ua.Status_ID = asu.Status_ID " +
            "JOIN User_Info worker ON ar.Worker_ID = worker.User_ID " + // Привязываем ID работника
            $"WHERE worker.User_ID = '{workerId}' " + // Фильтр по ID работника
            $"AND ar.Response_Date BETWEEN CONVERT(DATETIME, '{firstDate} 00:00:00', 120) " +
            $"AND CONVERT(DATETIME, '{secondDate} 23:59:59', 120) " + // Фильтр по дате
            "ORDER BY ar.Response_Date DESC;";
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
            string sqlCom = "select User_ID, Employee_Number from User_Info where " +
                $"Last_Name = '{fam}' and First_Name = '{name}' and Middle_Name = '{otch}'";
            return sqlCom;
        }
        public string SqlComTakeIdWorker(string name, string fam)
        {
            string sqlCom = "select User_ID from User_Info where " +
                $"Last_Name = '{fam}' and First_Name = '{name}'";
            return sqlCom;
        }
        public string SqlComCheckAccountWorker(string idWorker)
        {
            string sqlCom = $"select Auth_ID from User_Auth where User_ID = '{idWorker}'";
            return sqlCom;
        }
        public string SqlComTakeEmployeeNumber(string idWorker)
        {
            string sqlCom = $"select Employee_Number from User_Info where User_ID = '{idWorker}'";
            return sqlCom;
        }
        #endregion
        #region [RegistrationForm]
        public string SqlComSetWorkerIdToAccount(string idWorker, string login)
        {
            string sqlCom = $"update User_Auth set User_ID = '{idWorker}' " +
                $"where Username = '{login}'";
            return sqlCom;
        }
        #endregion
    }
}