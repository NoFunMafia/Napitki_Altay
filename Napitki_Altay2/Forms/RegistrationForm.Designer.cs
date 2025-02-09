namespace Napitki_Altay2
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.RoleContextMenuStip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сотрудникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VisiblePassCheckRegForm = new System.Windows.Forms.CheckBox();
            this.OpenFormLogin = new System.Windows.Forms.LinkLabel();
            this.EmailTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.RegisterAccountButton = new Napitki_Altay2.Design.CustomButton();
            this.ChooseRoleTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.PasswordCreateTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.LoginCreateTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.InfoPictureBox = new System.Windows.Forms.PictureBox();
            this.ChoosePictureBox = new System.Windows.Forms.PictureBox();
            this.RegPictureBox = new System.Windows.Forms.PictureBox();
            this.DetailsPictureBox = new System.Windows.Forms.PictureBox();
            this.RoleContextMenuStip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoosePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RoleContextMenuStip
            // 
            this.RoleContextMenuStip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.RoleContextMenuStip.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            this.RoleContextMenuStip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RoleContextMenuStip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникToolStripMenuItem,
            this.заказчикToolStripMenuItem});
            this.RoleContextMenuStip.Name = "RoleContextMenuStip";
            this.RoleContextMenuStip.Size = new System.Drawing.Size(450, 92);
            // 
            // сотрудникToolStripMenuItem
            // 
            this.сотрудникToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.сотрудникToolStripMenuItem.Name = "сотрудникToolStripMenuItem";
            this.сотрудникToolStripMenuItem.Size = new System.Drawing.Size(449, 44);
            this.сотрудникToolStripMenuItem.Text = "Муниципальный служащий";
            this.сотрудникToolStripMenuItem.Click += new System.EventHandler(this.МунСлужToolStripMenuItem_Click);
            // 
            // заказчикToolStripMenuItem
            // 
            this.заказчикToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.заказчикToolStripMenuItem.Name = "заказчикToolStripMenuItem";
            this.заказчикToolStripMenuItem.Size = new System.Drawing.Size(449, 44);
            this.заказчикToolStripMenuItem.Text = "Заявитель";
            this.заказчикToolStripMenuItem.Click += new System.EventHandler(this.ЗаказчикToolStripMenuItem_Click);
            // 
            // VisiblePassCheckRegForm
            // 
            this.VisiblePassCheckRegForm.AutoSize = true;
            this.VisiblePassCheckRegForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisiblePassCheckRegForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisiblePassCheckRegForm.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.VisiblePassCheckRegForm.Font = new System.Drawing.Font("Segoe UI Variable Text", 7.6F);
            this.VisiblePassCheckRegForm.Location = new System.Drawing.Point(590, 358);
            this.VisiblePassCheckRegForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VisiblePassCheckRegForm.Name = "VisiblePassCheckRegForm";
            this.VisiblePassCheckRegForm.Size = new System.Drawing.Size(132, 32);
            this.VisiblePassCheckRegForm.TabIndex = 11;
            this.VisiblePassCheckRegForm.Text = "Показать";
            this.VisiblePassCheckRegForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VisiblePassCheckRegForm.UseVisualStyleBackColor = true;
            this.VisiblePassCheckRegForm.CheckedChanged += new System.EventHandler(this.VisiblePassCheckRegForm_CheckedChanged);
            // 
            // OpenFormLogin
            // 
            this.OpenFormLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.OpenFormLogin.AutoSize = true;
            this.OpenFormLogin.Font = new System.Drawing.Font("Segoe UI Variable Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFormLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.OpenFormLogin.Location = new System.Drawing.Point(228, 689);
            this.OpenFormLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpenFormLogin.Name = "OpenFormLogin";
            this.OpenFormLogin.Size = new System.Drawing.Size(277, 28);
            this.OpenFormLogin.TabIndex = 12;
            this.OpenFormLogin.TabStop = true;
            this.OpenFormLogin.Text = "Уже есть аккаунт? Войдите!";
            this.OpenFormLogin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.OpenFormLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenFormLogin_LinkClicked);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.White;
            this.EmailTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.EmailTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.EmailTextBox.BorderSize = 2;
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            this.EmailTextBox.ForeColor = System.Drawing.Color.Black;
            this.EmailTextBox.Location = new System.Drawing.Point(155, 426);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EmailTextBox.Multiline = false;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.EmailTextBox.PasswordChar = false;
            this.EmailTextBox.ReadOnly = false;
            this.EmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailTextBox.SelectionStart = 0;
            this.EmailTextBox.Size = new System.Drawing.Size(428, 60);
            this.EmailTextBox.TabIndex = 14;
            this.EmailTextBox.Texts = "Ваш Email";
            this.EmailTextBox.UnderlinedStyle = false;
            this.EmailTextBox.Enter += new System.EventHandler(this.User_Enter_In_TextBox_Email_Create);
            this.EmailTextBox.Leave += new System.EventHandler(this.User_Leave_From_TextBox_Email_Create);
            // 
            // RegisterAccountButton
            // 
            this.RegisterAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.RegisterAccountButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.RegisterAccountButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.RegisterAccountButton.BorderRadius = 5;
            this.RegisterAccountButton.BorderSize = 0;
            this.RegisterAccountButton.FlatAppearance.BorderSize = 0;
            this.RegisterAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterAccountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterAccountButton.ForeColor = System.Drawing.Color.White;
            this.RegisterAccountButton.Location = new System.Drawing.Point(263, 589);
            this.RegisterAccountButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegisterAccountButton.Name = "RegisterAccountButton";
            this.RegisterAccountButton.Size = new System.Drawing.Size(211, 84);
            this.RegisterAccountButton.TabIndex = 9;
            this.RegisterAccountButton.Text = "Создать";
            this.RegisterAccountButton.TextColor = System.Drawing.Color.White;
            this.RegisterAccountButton.UseVisualStyleBackColor = false;
            this.RegisterAccountButton.Click += new System.EventHandler(this.RegisterAccountButton_Click);
            // 
            // ChooseRoleTextBox
            // 
            this.ChooseRoleTextBox.BackColor = System.Drawing.Color.White;
            this.ChooseRoleTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.ChooseRoleTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.ChooseRoleTextBox.BorderSize = 2;
            this.ChooseRoleTextBox.Enabled = false;
            this.ChooseRoleTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            this.ChooseRoleTextBox.ForeColor = System.Drawing.Color.Black;
            this.ChooseRoleTextBox.Location = new System.Drawing.Point(155, 509);
            this.ChooseRoleTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ChooseRoleTextBox.Multiline = false;
            this.ChooseRoleTextBox.Name = "ChooseRoleTextBox";
            this.ChooseRoleTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.ChooseRoleTextBox.PasswordChar = false;
            this.ChooseRoleTextBox.ReadOnly = false;
            this.ChooseRoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChooseRoleTextBox.SelectionStart = 0;
            this.ChooseRoleTextBox.Size = new System.Drawing.Size(428, 60);
            this.ChooseRoleTextBox.TabIndex = 7;
            this.ChooseRoleTextBox.Texts = "Роль пользователя";
            this.ChooseRoleTextBox.UnderlinedStyle = false;
            // 
            // PasswordCreateTextBox
            // 
            this.PasswordCreateTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordCreateTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.PasswordCreateTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.PasswordCreateTextBox.BorderSize = 2;
            this.PasswordCreateTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            this.PasswordCreateTextBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordCreateTextBox.Location = new System.Drawing.Point(155, 343);
            this.PasswordCreateTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PasswordCreateTextBox.Multiline = false;
            this.PasswordCreateTextBox.Name = "PasswordCreateTextBox";
            this.PasswordCreateTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.PasswordCreateTextBox.PasswordChar = false;
            this.PasswordCreateTextBox.ReadOnly = false;
            this.PasswordCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordCreateTextBox.SelectionStart = 0;
            this.PasswordCreateTextBox.Size = new System.Drawing.Size(428, 60);
            this.PasswordCreateTextBox.TabIndex = 6;
            this.PasswordCreateTextBox.Texts = "Создание пароля";
            this.PasswordCreateTextBox.UnderlinedStyle = false;
            this.PasswordCreateTextBox.Enter += new System.EventHandler(this.User_Enter_In_TextBox_Pass_Create);
            this.PasswordCreateTextBox.Leave += new System.EventHandler(this.User_Leave_From_TextBox_Pass_Create);
            // 
            // LoginCreateTextBox
            // 
            this.LoginCreateTextBox.BackColor = System.Drawing.Color.White;
            this.LoginCreateTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.LoginCreateTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.LoginCreateTextBox.BorderSize = 2;
            this.LoginCreateTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            this.LoginCreateTextBox.ForeColor = System.Drawing.Color.Black;
            this.LoginCreateTextBox.Location = new System.Drawing.Point(155, 260);
            this.LoginCreateTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LoginCreateTextBox.Multiline = false;
            this.LoginCreateTextBox.Name = "LoginCreateTextBox";
            this.LoginCreateTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.LoginCreateTextBox.PasswordChar = false;
            this.LoginCreateTextBox.ReadOnly = false;
            this.LoginCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LoginCreateTextBox.SelectionStart = 0;
            this.LoginCreateTextBox.Size = new System.Drawing.Size(428, 60);
            this.LoginCreateTextBox.TabIndex = 5;
            this.LoginCreateTextBox.Texts = "Создание логина";
            this.LoginCreateTextBox.UnderlinedStyle = false;
            this.LoginCreateTextBox.Enter += new System.EventHandler(this.User_Enter_In_TextBox_Login_Create);
            this.LoginCreateTextBox.Leave += new System.EventHandler(this.User_Leave_From_TextBox_Login_Create);
            // 
            // CustomFormForAllProject
            // 
            this.CustomFormForAllProject.AllowUserResize = false;
            this.CustomFormForAllProject.BackColor = System.Drawing.Color.White;
            this.CustomFormForAllProject.ContextMenuForm = null;
            this.CustomFormForAllProject.ControlBoxButtonsWidth = 20;
            this.CustomFormForAllProject.EnableControlBoxIconsLight = true;
            this.CustomFormForAllProject.EnableControlBoxMouseLight = false;
            this.CustomFormForAllProject.Form = this;
            this.CustomFormForAllProject.FormStyle = Napitki_Altay2.Components.FormStyleCustom.fStyle.UserStyle;
            this.CustomFormForAllProject.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CustomFormForAllProject.HeaderColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.CustomFormForAllProject.HeaderColorGradientEnable = true;
            this.CustomFormForAllProject.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.CustomFormForAllProject.HeaderHeight = 29;
            this.CustomFormForAllProject.HeaderImage = null;
            this.CustomFormForAllProject.HeaderTextColor = System.Drawing.Color.White;
            this.CustomFormForAllProject.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // InfoPictureBox
            // 
            this.InfoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoPictureBox.Image = global::Napitki_Altay2.Properties.Resources.Picture2RegForm;
            this.InfoPictureBox.Location = new System.Drawing.Point(92, 352);
            this.InfoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InfoPictureBox.Name = "InfoPictureBox";
            this.InfoPictureBox.Size = new System.Drawing.Size(48, 42);
            this.InfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoPictureBox.TabIndex = 13;
            this.InfoPictureBox.TabStop = false;
            this.InfoPictureBox.Click += new System.EventHandler(this.InfoPictureBox_Click);
            // 
            // ChoosePictureBox
            // 
            this.ChoosePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoosePictureBox.Image = global::Napitki_Altay2.Properties.Resources.PictureRegForm;
            this.ChoosePictureBox.Location = new System.Drawing.Point(530, 517);
            this.ChoosePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChoosePictureBox.Name = "ChoosePictureBox";
            this.ChoosePictureBox.Size = new System.Drawing.Size(48, 42);
            this.ChoosePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChoosePictureBox.TabIndex = 8;
            this.ChoosePictureBox.TabStop = false;
            this.ChoosePictureBox.Click += new System.EventHandler(this.ChoosePictureBox_Click);
            // 
            // RegPictureBox
            // 
            this.RegPictureBox.BackColor = System.Drawing.Color.White;
            this.RegPictureBox.Image = global::Napitki_Altay2.Properties.Resources.Герб_Алтайского_края;
            this.RegPictureBox.Location = new System.Drawing.Point(265, 35);
            this.RegPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegPictureBox.Name = "RegPictureBox";
            this.RegPictureBox.Size = new System.Drawing.Size(208, 200);
            this.RegPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RegPictureBox.TabIndex = 4;
            this.RegPictureBox.TabStop = false;
            // 
            // DetailsPictureBox
            // 
            this.DetailsPictureBox.Image = global::Napitki_Altay2.Properties.Resources.Лента_флага;
            this.DetailsPictureBox.Location = new System.Drawing.Point(3, 702);
            this.DetailsPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DetailsPictureBox.Name = "DetailsPictureBox";
            this.DetailsPictureBox.Size = new System.Drawing.Size(733, 200);
            this.DetailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DetailsPictureBox.TabIndex = 10;
            this.DetailsPictureBox.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 905);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.InfoPictureBox);
            this.Controls.Add(this.OpenFormLogin);
            this.Controls.Add(this.VisiblePassCheckRegForm);
            this.Controls.Add(this.RegisterAccountButton);
            this.Controls.Add(this.ChoosePictureBox);
            this.Controls.Add(this.ChooseRoleTextBox);
            this.Controls.Add(this.PasswordCreateTextBox);
            this.Controls.Add(this.LoginCreateTextBox);
            this.Controls.Add(this.RegPictureBox);
            this.Controls.Add(this.DetailsPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.RoleContextMenuStip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoosePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormStyleCustom CustomFormForAllProject;
        private System.Windows.Forms.PictureBox RegPictureBox;
        private Design.CustomTextBox LoginCreateTextBox;
        private Design.CustomTextBox PasswordCreateTextBox;
        private System.Windows.Forms.PictureBox ChoosePictureBox;
        private Design.CustomTextBox ChooseRoleTextBox;
        private System.Windows.Forms.ContextMenuStrip RoleContextMenuStip;
        private System.Windows.Forms.ToolStripMenuItem сотрудникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказчикToolStripMenuItem;
        private Design.CustomButton RegisterAccountButton;
        private System.Windows.Forms.PictureBox DetailsPictureBox;
        private System.Windows.Forms.CheckBox VisiblePassCheckRegForm;
        private System.Windows.Forms.LinkLabel OpenFormLogin;
        private System.Windows.Forms.PictureBox InfoPictureBox;
        private Design.CustomTextBox EmailTextBox;
    }
}