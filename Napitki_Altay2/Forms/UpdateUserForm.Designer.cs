﻿namespace Napitki_Altay2.Forms
{
    partial class UpdateUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUserForm));
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.OtchLabel = new System.Windows.Forms.Label();
            this.OtchTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.ImyaLabel = new System.Windows.Forms.Label();
            this.ImyaTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.FamLabel = new System.Windows.Forms.Label();
            this.FamTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CancelButton = new Napitki_Altay2.Design.CustomButton();
            this.InputUsersButton = new Napitki_Altay2.Design.CustomButton();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.RoleTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.UsersPictureBox = new System.Windows.Forms.PictureBox();
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.RoleMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.администраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpNumLabel = new System.Windows.Forms.Label();
            this.EmpNumTextBox = new Napitki_Altay2.Design.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsersPictureBox)).BeginInit();
            this.RoleMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.EmailLabel.Location = new System.Drawing.Point(20, 642);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(315, 41);
            this.EmailLabel.TabIndex = 50;
            this.EmailLabel.Text = "Почта (e-mail адрес):";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.White;
            this.EmailTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.EmailTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.EmailTextBox.BorderSize = 2;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.EmailTextBox.ForeColor = System.Drawing.Color.Black;
            this.EmailTextBox.Location = new System.Drawing.Point(27, 694);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.EmailTextBox.Multiline = false;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.EmailTextBox.PasswordChar = false;
            this.EmailTextBox.ReadOnly = false;
            this.EmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailTextBox.SelectionStart = 0;
            this.EmailTextBox.Size = new System.Drawing.Size(330, 55);
            this.EmailTextBox.TabIndex = 49;
            this.EmailTextBox.Texts = "";
            this.EmailTextBox.UnderlinedStyle = false;
            // 
            // OtchLabel
            // 
            this.OtchLabel.AutoSize = true;
            this.OtchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.OtchLabel.Location = new System.Drawing.Point(394, 527);
            this.OtchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OtchLabel.Name = "OtchLabel";
            this.OtchLabel.Size = new System.Drawing.Size(156, 41);
            this.OtchLabel.TabIndex = 48;
            this.OtchLabel.Text = "Отчество:";
            // 
            // OtchTextBox
            // 
            this.OtchTextBox.BackColor = System.Drawing.Color.White;
            this.OtchTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.OtchTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.OtchTextBox.BorderSize = 2;
            this.OtchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.OtchTextBox.ForeColor = System.Drawing.Color.Black;
            this.OtchTextBox.Location = new System.Drawing.Point(402, 578);
            this.OtchTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.OtchTextBox.Multiline = false;
            this.OtchTextBox.Name = "OtchTextBox";
            this.OtchTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.OtchTextBox.PasswordChar = false;
            this.OtchTextBox.ReadOnly = false;
            this.OtchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OtchTextBox.SelectionStart = 0;
            this.OtchTextBox.Size = new System.Drawing.Size(330, 55);
            this.OtchTextBox.TabIndex = 47;
            this.OtchTextBox.Texts = "";
            this.OtchTextBox.UnderlinedStyle = false;
            // 
            // ImyaLabel
            // 
            this.ImyaLabel.AutoSize = true;
            this.ImyaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.ImyaLabel.Location = new System.Drawing.Point(394, 406);
            this.ImyaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImyaLabel.Name = "ImyaLabel";
            this.ImyaLabel.Size = new System.Drawing.Size(86, 41);
            this.ImyaLabel.TabIndex = 46;
            this.ImyaLabel.Text = "Имя:";
            // 
            // ImyaTextBox
            // 
            this.ImyaTextBox.BackColor = System.Drawing.Color.White;
            this.ImyaTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.ImyaTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.ImyaTextBox.BorderSize = 2;
            this.ImyaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ImyaTextBox.ForeColor = System.Drawing.Color.Black;
            this.ImyaTextBox.Location = new System.Drawing.Point(402, 458);
            this.ImyaTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.ImyaTextBox.Multiline = false;
            this.ImyaTextBox.Name = "ImyaTextBox";
            this.ImyaTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.ImyaTextBox.PasswordChar = false;
            this.ImyaTextBox.ReadOnly = false;
            this.ImyaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ImyaTextBox.SelectionStart = 0;
            this.ImyaTextBox.Size = new System.Drawing.Size(330, 55);
            this.ImyaTextBox.TabIndex = 45;
            this.ImyaTextBox.Texts = "";
            this.ImyaTextBox.UnderlinedStyle = false;
            // 
            // FamLabel
            // 
            this.FamLabel.AutoSize = true;
            this.FamLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.FamLabel.Location = new System.Drawing.Point(394, 286);
            this.FamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FamLabel.Name = "FamLabel";
            this.FamLabel.Size = new System.Drawing.Size(155, 41);
            this.FamLabel.TabIndex = 44;
            this.FamLabel.Text = "Фамилия:";
            // 
            // FamTextBox
            // 
            this.FamTextBox.BackColor = System.Drawing.Color.White;
            this.FamTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.FamTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.FamTextBox.BorderSize = 2;
            this.FamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.FamTextBox.ForeColor = System.Drawing.Color.Black;
            this.FamTextBox.Location = new System.Drawing.Point(402, 338);
            this.FamTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.FamTextBox.Multiline = false;
            this.FamTextBox.Name = "FamTextBox";
            this.FamTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.FamTextBox.PasswordChar = false;
            this.FamTextBox.ReadOnly = false;
            this.FamTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FamTextBox.SelectionStart = 0;
            this.FamTextBox.Size = new System.Drawing.Size(330, 55);
            this.FamTextBox.TabIndex = 43;
            this.FamTextBox.Texts = "";
            this.FamTextBox.UnderlinedStyle = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CancelButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CancelButton.BorderRadius = 0;
            this.CancelButton.BorderSize = 0;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(402, 781);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(330, 88);
            this.CancelButton.TabIndex = 42;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.TextColor = System.Drawing.Color.White;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // InputUsersButton
            // 
            this.InputUsersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.InputUsersButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.InputUsersButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.InputUsersButton.BorderRadius = 0;
            this.InputUsersButton.BorderSize = 0;
            this.InputUsersButton.FlatAppearance.BorderSize = 0;
            this.InputUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputUsersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.InputUsersButton.ForeColor = System.Drawing.Color.White;
            this.InputUsersButton.Location = new System.Drawing.Point(27, 781);
            this.InputUsersButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InputUsersButton.Name = "InputUsersButton";
            this.InputUsersButton.Size = new System.Drawing.Size(330, 88);
            this.InputUsersButton.TabIndex = 41;
            this.InputUsersButton.Text = "Обновить пользователя";
            this.InputUsersButton.TextColor = System.Drawing.Color.White;
            this.InputUsersButton.UseVisualStyleBackColor = false;
            this.InputUsersButton.Click += new System.EventHandler(this.InputUsersButton_Click);
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.RoleLabel.Location = new System.Drawing.Point(20, 522);
            this.RoleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(316, 45);
            this.RoleLabel.TabIndex = 39;
            this.RoleLabel.Text = "Роль пользователя:";
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.BackColor = System.Drawing.Color.White;
            this.RoleTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.RoleTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.RoleTextBox.BorderSize = 2;
            this.RoleTextBox.Enabled = false;
            this.RoleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.RoleTextBox.ForeColor = System.Drawing.Color.Black;
            this.RoleTextBox.Location = new System.Drawing.Point(27, 578);
            this.RoleTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.RoleTextBox.Multiline = false;
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.RoleTextBox.PasswordChar = false;
            this.RoleTextBox.ReadOnly = false;
            this.RoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RoleTextBox.SelectionStart = 0;
            this.RoleTextBox.Size = new System.Drawing.Size(330, 55);
            this.RoleTextBox.TabIndex = 38;
            this.RoleTextBox.Texts = "";
            this.RoleTextBox.UnderlinedStyle = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.Location = new System.Drawing.Point(20, 402);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(142, 45);
            this.PasswordLabel.TabIndex = 37;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.PasswordTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.PasswordTextBox.BorderSize = 2;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTextBox.Location = new System.Drawing.Point(27, 458);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.PasswordTextBox.PasswordChar = false;
            this.PasswordTextBox.ReadOnly = false;
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.Size = new System.Drawing.Size(330, 55);
            this.PasswordTextBox.TabIndex = 36;
            this.PasswordTextBox.Texts = "";
            this.PasswordTextBox.UnderlinedStyle = false;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LoginLabel.Location = new System.Drawing.Point(20, 281);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(120, 45);
            this.LoginLabel.TabIndex = 35;
            this.LoginLabel.Text = "Логин:";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.White;
            this.LoginTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.LoginTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.LoginTextBox.BorderSize = 2;
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.LoginTextBox.ForeColor = System.Drawing.Color.Black;
            this.LoginTextBox.Location = new System.Drawing.Point(27, 338);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.LoginTextBox.Multiline = false;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.LoginTextBox.PasswordChar = false;
            this.LoginTextBox.ReadOnly = false;
            this.LoginTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LoginTextBox.SelectionStart = 0;
            this.LoginTextBox.Size = new System.Drawing.Size(330, 55);
            this.LoginTextBox.TabIndex = 34;
            this.LoginTextBox.Texts = "";
            this.LoginTextBox.UnderlinedStyle = false;
            // 
            // UsersPictureBox
            // 
            this.UsersPictureBox.BackColor = System.Drawing.Color.White;
            this.UsersPictureBox.Image = global::Napitki_Altay2.Properties.Resources.Герб_Алтайского_края;
            this.UsersPictureBox.Location = new System.Drawing.Point(256, 23);
            this.UsersPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsersPictureBox.Name = "UsersPictureBox";
            this.UsersPictureBox.Size = new System.Drawing.Size(258, 228);
            this.UsersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsersPictureBox.TabIndex = 33;
            this.UsersPictureBox.TabStop = false;
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
            this.CustomFormForAllProject.HeaderColor = System.Drawing.Color.RoyalBlue;
            this.CustomFormForAllProject.HeaderColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(48)))), ((int)(((byte)(207)))));
            this.CustomFormForAllProject.HeaderColorGradientEnable = true;
            this.CustomFormForAllProject.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.CustomFormForAllProject.HeaderHeight = 29;
            this.CustomFormForAllProject.HeaderImage = null;
            this.CustomFormForAllProject.HeaderTextColor = System.Drawing.Color.White;
            this.CustomFormForAllProject.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // RoleMenuStrip
            // 
            this.RoleMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.RoleMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RoleMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администраторToolStripMenuItem,
            this.сотрудникToolStripMenuItem,
            this.заявительToolStripMenuItem});
            this.RoleMenuStrip.Name = "RoleMenuStrip";
            this.RoleMenuStrip.Size = new System.Drawing.Size(301, 162);
            // 
            // администраторToolStripMenuItem
            // 
            this.администраторToolStripMenuItem.Name = "администраторToolStripMenuItem";
            this.администраторToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.администраторToolStripMenuItem.Text = "Администратор";
            this.администраторToolStripMenuItem.Click += new System.EventHandler(this.АдминистраторToolStripMenuItem_Click);
            // 
            // сотрудникToolStripMenuItem
            // 
            this.сотрудникToolStripMenuItem.Name = "сотрудникToolStripMenuItem";
            this.сотрудникToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.сотрудникToolStripMenuItem.Text = "Сотрудник";
            this.сотрудникToolStripMenuItem.Click += new System.EventHandler(this.СотрудникToolStripMenuItem_Click);
            // 
            // заявительToolStripMenuItem
            // 
            this.заявительToolStripMenuItem.Name = "заявительToolStripMenuItem";
            this.заявительToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.заявительToolStripMenuItem.Text = "Заявитель";
            this.заявительToolStripMenuItem.Click += new System.EventHandler(this.ЗаявительToolStripMenuItem_Click);
            // 
            // EmpNumLabel
            // 
            this.EmpNumLabel.AutoSize = true;
            this.EmpNumLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.EmpNumLabel.Location = new System.Drawing.Point(394, 643);
            this.EmpNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpNumLabel.Name = "EmpNumLabel";
            this.EmpNumLabel.Size = new System.Drawing.Size(281, 41);
            this.EmpNumLabel.TabIndex = 52;
            this.EmpNumLabel.Text = "Табельный номер:";
            // 
            // EmpNumTextBox
            // 
            this.EmpNumTextBox.BackColor = System.Drawing.Color.White;
            this.EmpNumTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.EmpNumTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.EmpNumTextBox.BorderSize = 2;
            this.EmpNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.EmpNumTextBox.ForeColor = System.Drawing.Color.Black;
            this.EmpNumTextBox.Location = new System.Drawing.Point(402, 694);
            this.EmpNumTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.EmpNumTextBox.Multiline = false;
            this.EmpNumTextBox.Name = "EmpNumTextBox";
            this.EmpNumTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.EmpNumTextBox.PasswordChar = false;
            this.EmpNumTextBox.ReadOnly = false;
            this.EmpNumTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmpNumTextBox.SelectionStart = 0;
            this.EmpNumTextBox.Size = new System.Drawing.Size(330, 55);
            this.EmpNumTextBox.TabIndex = 51;
            this.EmpNumTextBox.Texts = "";
            this.EmpNumTextBox.UnderlinedStyle = false;
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 894);
            this.Controls.Add(this.EmpNumLabel);
            this.Controls.Add(this.EmpNumTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.OtchLabel);
            this.Controls.Add(this.OtchTextBox);
            this.Controls.Add(this.ImyaLabel);
            this.Controls.Add(this.ImyaTextBox);
            this.Controls.Add(this.FamLabel);
            this.Controls.Add(this.FamTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.InputUsersButton);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.RoleTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.UsersPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление пользователя";
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersPictureBox)).EndInit();
            this.RoleMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private Design.CustomTextBox EmailTextBox;
        private System.Windows.Forms.Label OtchLabel;
        private Design.CustomTextBox OtchTextBox;
        private System.Windows.Forms.Label ImyaLabel;
        private Design.CustomTextBox ImyaTextBox;
        private System.Windows.Forms.Label FamLabel;
        private Design.CustomTextBox FamTextBox;
        private Design.CustomButton CancelButton;
        private Design.CustomButton InputUsersButton;
        private System.Windows.Forms.Label RoleLabel;
        private Design.CustomTextBox RoleTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private Design.CustomTextBox PasswordTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private Design.CustomTextBox LoginTextBox;
        private System.Windows.Forms.PictureBox UsersPictureBox;
        private Components.FormStyleCustom CustomFormForAllProject;
        private System.Windows.Forms.ContextMenuStrip RoleMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem администраторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявительToolStripMenuItem;
        private System.Windows.Forms.Label EmpNumLabel;
        private Design.CustomTextBox EmpNumTextBox;
    }
}