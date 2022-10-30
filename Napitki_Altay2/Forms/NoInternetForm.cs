#region [using's]
using System;
using System.Windows.Forms;
#endregion

namespace Napitki_Altay2.Forms
{
    public partial class NoInternetForm : Form
    {
        public NoInternetForm()
        {
            InitializeComponent();
        }
        #region [Событие нажатия на кнопку попытки подключения к интернету]
        private void RestartInternetButton_Click(object sender, EventArgs e)
        {
            if(Classes.InternetCheck.CheckConnection() == true)
            {
                AuthForm authForm = new AuthForm();
                authForm.Show();  
                this.Hide();
            }
        }
        #endregion
    }
}
