using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Napitki_Altay2.Forms
{
    public partial class AuthEmailForm : Form
    {
        public bool rightCode { get; set; }
        public AuthEmailForm()
        {
            InitializeComponent();
        }
        private void CancelCodeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EnterCodeButton_Click(object sender, EventArgs e)
        {
            if(EnterCodeTextBox.Texts 
                == RegistrationForm.unicCode.ToString())
            {
                rightCode = true;
                this.Close();
            }
            else
            {
                rightCode = false;
            }
        }
    }
}