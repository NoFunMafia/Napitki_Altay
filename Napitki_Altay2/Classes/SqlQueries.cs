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
                    $"'{otch}'";
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
                    "Date_Of_Answer " +
                    "from Ready_Application " +
                    "join Info_About_User on " +
                    "Ready_Application.FK_Info_User " +
                    "= Info_About_User.ID_Info_User " +
                    "join Application_To_Company " +
                    "on Application_To_Company.ID_Application " +
                    "= Ready_Application.FK_ID_Application " +
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
                $"'{otch}'";
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
        // MainWorkFormAdmin - ReceiveRowAndList
        public string SqlComTakeFio(string loginID)
        {
            string sqlCom = "select User_Surname, User_Name, User_Patronymic " +
                "from Authentication_ join Info_About_User " +
                "on Authentication_.FK_Info_User = Info_About_User.ID_Info_User " +
                $"where ID_User = '{loginID}'";
            return sqlCom;
        }
        // MainWorkFormAdmin - SendQueryFromList
        public string SqlComDeleteFio(string name, string fam, string otch)
        {
            string sqlCom = $"delete from Info_About_User where User_Surname = '{fam}' " +
                $"and User_Name = '{name}' and User_Patronymic = '{otch}'";
            return sqlCom;
        }
        // MainWorkFormAdmin - SendQueryToDeleteUser
        public string SqlComDeleteUser(string loginID)
        {
            string sqlCom = $"delete from Authentication_ where ID_User = '{loginID}'";
            return sqlCom;
        }
        // MainWorkFormAdmin - LoadDataGridViewApplication
        public string sqlComOutputCompleteApplication = "select FK_ID_Application, " +
                    "User_Surname, User_Name, User_Patronymic, Date_Of_Answer " +
                    "from Ready_Application join Info_About_User on " +
                    "Ready_Application.FK_Info_User = Info_About_User.ID_Info_User";


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
        // AddUserForm - InputUsersButton
        public string SqlComInsertUser(string login, string pass, string role, string email)
        {
            string sqlCom = "insert into Authentication_" +
                "(Login_User, Password_User, FK_Role_User, Email) " +
                $"values('{login}', '{pass}', '{role}', '{email}')";
            return sqlCom;
        }
        // AddUserForm - CheckTextBoxIsNull
        public string SqlComInsertFio(string name, string fam, string otch)
        {
            string sqlCom = $"insert into Info_About_User(User_Surname, User_Name, User_Patronymic) " +
                $"values ('{fam}', '{name}', '{otch}')";
            return sqlCom;
        }
        // AddUserForm - InputUsersButton
        public string SqlComTakeFKFio(string name, string fam, string otch)
        {
            string sqlCom = "select * from Info_About_User where " +
                $"User_Surname = '{fam}' and User_Name = '{name}' and User_Patronymic = '{otch}'";
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
    }
}