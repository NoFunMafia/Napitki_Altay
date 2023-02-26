using Napitki_Altay2.Forms;

namespace Napitki_Altay2.Classes
{
    internal class SqlQueries
    {
        // MainWorkForm - MainWorkForm_Load
        public string sqlComRecFIO = $"select * from Info_About_User " +
                $"join Authentication_ on Authentication_.FK_Info_User " +
                $"= Info_About_User.ID_Info_User " +
                $"where Authentication_.Login_User = " +
                $"'{AuthForm.LoginString}'";

        // MainWorkForm - LoadDataGridView
        public string sqlOutputMWF(string name, string fam, string otch)
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
        public string sqlComIDUser(string fam, string name, string otch)
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
        public string sqlComFKInfo(string fkInfoUser)
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
    }
}