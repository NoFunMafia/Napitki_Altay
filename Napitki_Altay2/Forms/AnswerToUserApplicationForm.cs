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
    public partial class AnswerToUserApplicationForm : Form
    {
        public AnswerToUserApplicationForm()
        {
            this.Location = new Point(740, 90);
            InitializeComponent();
            DoubleBuffered = true; // Включение двойной буферизации
        }
        private void CloseApplicWorkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}