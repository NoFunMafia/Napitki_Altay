namespace Napitki_Altay2.Forms
{
    partial class MainWorkFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWorkFormAdmin));
            this.MainWorkAdminTabControl = new System.Windows.Forms.TabControl();
            this.AllUsersPage = new System.Windows.Forms.TabPage();
            this.InfoUsersLabel = new System.Windows.Forms.Label();
            this.DataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.AllApplicationPage = new System.Windows.Forms.TabPage();
            this.LatterPoLabel = new System.Windows.Forms.Label();
            this.LatterOtLabel = new System.Windows.Forms.Label();
            this.SecondDateToRaportDTP = new System.Windows.Forms.DateTimePicker();
            this.FirstDateToRaportDTP = new System.Windows.Forms.DateTimePicker();
            this.FolderPathLabel = new System.Windows.Forms.Label();
            this.DataGridViewApplication = new System.Windows.Forms.DataGridView();
            this.FolderPathBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.UpdateUserButton = new Napitki_Altay2.Design.CustomButton();
            this.DeleteUserButton = new Napitki_Altay2.Design.CustomButton();
            this.CreateUserButton = new Napitki_Altay2.Design.CustomButton();
            this.FilePathTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.UpdateApplicationButton = new Napitki_Altay2.Design.CustomButton();
            this.GenerateRaportButton = new Napitki_Altay2.Design.CustomButton();
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.MainWorkAdminTabControl.SuspendLayout();
            this.AllUsersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).BeginInit();
            this.AllApplicationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // MainWorkAdminTabControl
            // 
            this.MainWorkAdminTabControl.Controls.Add(this.AllUsersPage);
            this.MainWorkAdminTabControl.Controls.Add(this.AllApplicationPage);
            this.MainWorkAdminTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MainWorkAdminTabControl.Location = new System.Drawing.Point(4, 5);
            this.MainWorkAdminTabControl.Name = "MainWorkAdminTabControl";
            this.MainWorkAdminTabControl.SelectedIndex = 0;
            this.MainWorkAdminTabControl.Size = new System.Drawing.Size(1019, 619);
            this.MainWorkAdminTabControl.TabIndex = 0;
            // 
            // AllUsersPage
            // 
            this.AllUsersPage.Controls.Add(this.InfoUsersLabel);
            this.AllUsersPage.Controls.Add(this.UpdateUserButton);
            this.AllUsersPage.Controls.Add(this.DeleteUserButton);
            this.AllUsersPage.Controls.Add(this.CreateUserButton);
            this.AllUsersPage.Controls.Add(this.DataGridViewUsers);
            this.AllUsersPage.Location = new System.Drawing.Point(4, 27);
            this.AllUsersPage.Name = "AllUsersPage";
            this.AllUsersPage.Padding = new System.Windows.Forms.Padding(3);
            this.AllUsersPage.Size = new System.Drawing.Size(1011, 588);
            this.AllUsersPage.TabIndex = 0;
            this.AllUsersPage.Text = "Пользователи";
            this.AllUsersPage.UseVisualStyleBackColor = true;
            // 
            // InfoUsersLabel
            // 
            this.InfoUsersLabel.AutoSize = true;
            this.InfoUsersLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.InfoUsersLabel.ForeColor = System.Drawing.Color.Black;
            this.InfoUsersLabel.Location = new System.Drawing.Point(497, 3);
            this.InfoUsersLabel.Name = "InfoUsersLabel";
            this.InfoUsersLabel.Size = new System.Drawing.Size(465, 46);
            this.InfoUsersLabel.TabIndex = 17;
            this.InfoUsersLabel.Text = "Внимание! Удаление сотрудников и заявителей которые\r\nучаствовали в документооборо" +
    "те недопустимо!";
            // 
            // DataGridViewUsers
            // 
            this.DataGridViewUsers.AllowUserToAddRows = false;
            this.DataGridViewUsers.AllowUserToDeleteRows = false;
            this.DataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUsers.Location = new System.Drawing.Point(3, 59);
            this.DataGridViewUsers.Name = "DataGridViewUsers";
            this.DataGridViewUsers.ReadOnly = true;
            this.DataGridViewUsers.RowHeadersWidth = 51;
            this.DataGridViewUsers.RowTemplate.Height = 24;
            this.DataGridViewUsers.Size = new System.Drawing.Size(1005, 525);
            this.DataGridViewUsers.TabIndex = 0;
            // 
            // AllApplicationPage
            // 
            this.AllApplicationPage.Controls.Add(this.LatterPoLabel);
            this.AllApplicationPage.Controls.Add(this.LatterOtLabel);
            this.AllApplicationPage.Controls.Add(this.SecondDateToRaportDTP);
            this.AllApplicationPage.Controls.Add(this.FirstDateToRaportDTP);
            this.AllApplicationPage.Controls.Add(this.FolderPathLabel);
            this.AllApplicationPage.Controls.Add(this.FilePathTextBox);
            this.AllApplicationPage.Controls.Add(this.UpdateApplicationButton);
            this.AllApplicationPage.Controls.Add(this.GenerateRaportButton);
            this.AllApplicationPage.Controls.Add(this.DataGridViewApplication);
            this.AllApplicationPage.Location = new System.Drawing.Point(4, 27);
            this.AllApplicationPage.Name = "AllApplicationPage";
            this.AllApplicationPage.Padding = new System.Windows.Forms.Padding(3);
            this.AllApplicationPage.Size = new System.Drawing.Size(1011, 588);
            this.AllApplicationPage.TabIndex = 1;
            this.AllApplicationPage.Text = "Отчётность";
            this.AllApplicationPage.UseVisualStyleBackColor = true;
            // 
            // LatterPoLabel
            // 
            this.LatterPoLabel.AutoSize = true;
            this.LatterPoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LatterPoLabel.Location = new System.Drawing.Point(8, 143);
            this.LatterPoLabel.Name = "LatterPoLabel";
            this.LatterPoLabel.Size = new System.Drawing.Size(42, 28);
            this.LatterPoLabel.TabIndex = 37;
            this.LatterPoLabel.Text = "ДО";
            // 
            // LatterOtLabel
            // 
            this.LatterOtLabel.AutoSize = true;
            this.LatterOtLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LatterOtLabel.Location = new System.Drawing.Point(13, 101);
            this.LatterOtLabel.Name = "LatterOtLabel";
            this.LatterOtLabel.Size = new System.Drawing.Size(37, 28);
            this.LatterOtLabel.TabIndex = 36;
            this.LatterOtLabel.Text = "ОТ";
            // 
            // SecondDateToRaportDTP
            // 
            this.SecondDateToRaportDTP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SecondDateToRaportDTP.Location = new System.Drawing.Point(56, 138);
            this.SecondDateToRaportDTP.Name = "SecondDateToRaportDTP";
            this.SecondDateToRaportDTP.Size = new System.Drawing.Size(198, 34);
            this.SecondDateToRaportDTP.TabIndex = 35;
            this.SecondDateToRaportDTP.ValueChanged += new System.EventHandler(this.SecondDateToRaportDTP_ValueChanged);
            // 
            // FirstDateToRaportDTP
            // 
            this.FirstDateToRaportDTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstDateToRaportDTP.Location = new System.Drawing.Point(56, 96);
            this.FirstDateToRaportDTP.Name = "FirstDateToRaportDTP";
            this.FirstDateToRaportDTP.Size = new System.Drawing.Size(198, 34);
            this.FirstDateToRaportDTP.TabIndex = 34;
            this.FirstDateToRaportDTP.ValueChanged += new System.EventHandler(this.FirstDateToRaportDTP_ValueChanged);
            // 
            // FolderPathLabel
            // 
            this.FolderPathLabel.AutoSize = true;
            this.FolderPathLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FolderPathLabel.Location = new System.Drawing.Point(5, 5);
            this.FolderPathLabel.Name = "FolderPathLabel";
            this.FolderPathLabel.Size = new System.Drawing.Size(440, 28);
            this.FolderPathLabel.TabIndex = 29;
            this.FolderPathLabel.Text = "Путь сохранения для формирования отчёта:";
            // 
            // DataGridViewApplication
            // 
            this.DataGridViewApplication.AllowUserToAddRows = false;
            this.DataGridViewApplication.AllowUserToDeleteRows = false;
            this.DataGridViewApplication.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewApplication.Location = new System.Drawing.Point(3, 193);
            this.DataGridViewApplication.Name = "DataGridViewApplication";
            this.DataGridViewApplication.RowHeadersWidth = 51;
            this.DataGridViewApplication.RowTemplate.Height = 24;
            this.DataGridViewApplication.Size = new System.Drawing.Size(1005, 392);
            this.DataGridViewApplication.TabIndex = 0;
            // 
            // UpdateUserButton
            // 
            this.UpdateUserButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateUserButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.UpdateUserButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.UpdateUserButton.BorderRadius = 0;
            this.UpdateUserButton.BorderSize = 0;
            this.UpdateUserButton.FlatAppearance.BorderSize = 0;
            this.UpdateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateUserButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateUserButton.ForeColor = System.Drawing.Color.White;
            this.UpdateUserButton.Location = new System.Drawing.Point(284, 8);
            this.UpdateUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateUserButton.Name = "UpdateUserButton";
            this.UpdateUserButton.Size = new System.Drawing.Size(207, 43);
            this.UpdateUserButton.TabIndex = 16;
            this.UpdateUserButton.Text = "Обновить данные";
            this.UpdateUserButton.TextColor = System.Drawing.Color.White;
            this.UpdateUserButton.UseVisualStyleBackColor = false;
            this.UpdateUserButton.Click += new System.EventHandler(this.UpdateUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteUserButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.DeleteUserButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DeleteUserButton.BorderRadius = 0;
            this.DeleteUserButton.BorderSize = 0;
            this.DeleteUserButton.FlatAppearance.BorderSize = 0;
            this.DeleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUserButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteUserButton.ForeColor = System.Drawing.Color.White;
            this.DeleteUserButton.Location = new System.Drawing.Point(145, 8);
            this.DeleteUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(133, 43);
            this.DeleteUserButton.TabIndex = 15;
            this.DeleteUserButton.Text = "Удалить";
            this.DeleteUserButton.TextColor = System.Drawing.Color.White;
            this.DeleteUserButton.UseVisualStyleBackColor = false;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CreateUserButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.CreateUserButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CreateUserButton.BorderRadius = 0;
            this.CreateUserButton.BorderSize = 0;
            this.CreateUserButton.FlatAppearance.BorderSize = 0;
            this.CreateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateUserButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateUserButton.ForeColor = System.Drawing.Color.White;
            this.CreateUserButton.Location = new System.Drawing.Point(6, 8);
            this.CreateUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(133, 43);
            this.CreateUserButton.TabIndex = 14;
            this.CreateUserButton.Text = "Создать";
            this.CreateUserButton.TextColor = System.Drawing.Color.White;
            this.CreateUserButton.UseVisualStyleBackColor = false;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.BackColor = System.Drawing.Color.White;
            this.FilePathTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.FilePathTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.FilePathTextBox.BorderSize = 2;
            this.FilePathTextBox.Enabled = false;
            this.FilePathTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FilePathTextBox.ForeColor = System.Drawing.Color.Black;
            this.FilePathTextBox.Location = new System.Drawing.Point(10, 37);
            this.FilePathTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.FilePathTextBox.Multiline = false;
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.FilePathTextBox.PasswordChar = false;
            this.FilePathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FilePathTextBox.SelectionStart = 0;
            this.FilePathTextBox.Size = new System.Drawing.Size(991, 41);
            this.FilePathTextBox.TabIndex = 27;
            this.FilePathTextBox.Texts = "";
            this.FilePathTextBox.UnderlinedStyle = false;
            // 
            // UpdateApplicationButton
            // 
            this.UpdateApplicationButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateApplicationButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.UpdateApplicationButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.UpdateApplicationButton.BorderRadius = 0;
            this.UpdateApplicationButton.BorderSize = 0;
            this.UpdateApplicationButton.FlatAppearance.BorderSize = 0;
            this.UpdateApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateApplicationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateApplicationButton.ForeColor = System.Drawing.Color.White;
            this.UpdateApplicationButton.Location = new System.Drawing.Point(478, 87);
            this.UpdateApplicationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateApplicationButton.Name = "UpdateApplicationButton";
            this.UpdateApplicationButton.Size = new System.Drawing.Size(168, 92);
            this.UpdateApplicationButton.TabIndex = 26;
            this.UpdateApplicationButton.Text = "Обновить данные";
            this.UpdateApplicationButton.TextColor = System.Drawing.Color.White;
            this.UpdateApplicationButton.UseVisualStyleBackColor = false;
            this.UpdateApplicationButton.Click += new System.EventHandler(this.UpdateApplicationButton_Click);
            // 
            // GenerateRaportButton
            // 
            this.GenerateRaportButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.GenerateRaportButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.GenerateRaportButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.GenerateRaportButton.BorderRadius = 0;
            this.GenerateRaportButton.BorderSize = 0;
            this.GenerateRaportButton.FlatAppearance.BorderSize = 0;
            this.GenerateRaportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateRaportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateRaportButton.ForeColor = System.Drawing.Color.White;
            this.GenerateRaportButton.Location = new System.Drawing.Point(272, 87);
            this.GenerateRaportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateRaportButton.Name = "GenerateRaportButton";
            this.GenerateRaportButton.Size = new System.Drawing.Size(200, 92);
            this.GenerateRaportButton.TabIndex = 25;
            this.GenerateRaportButton.Text = "Сформировать отчёт";
            this.GenerateRaportButton.TextColor = System.Drawing.Color.White;
            this.GenerateRaportButton.UseVisualStyleBackColor = false;
            this.GenerateRaportButton.Click += new System.EventHandler(this.GenerateRaportButton_Click);
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
            // MainWorkFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 628);
            this.Controls.Add(this.MainWorkAdminTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWorkFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Админ-панель «Автоматизация документооборота»";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWorkFormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.MainWorkFormAdmin_Load);
            this.MainWorkAdminTabControl.ResumeLayout(false);
            this.AllUsersPage.ResumeLayout(false);
            this.AllUsersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).EndInit();
            this.AllApplicationPage.ResumeLayout(false);
            this.AllApplicationPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewApplication)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.FormStyleCustom CustomFormForAllProject;
        private System.Windows.Forms.TabControl MainWorkAdminTabControl;
        private System.Windows.Forms.TabPage AllUsersPage;
        private System.Windows.Forms.TabPage AllApplicationPage;
        private System.Windows.Forms.DataGridView DataGridViewUsers;
        private Design.CustomButton UpdateUserButton;
        private Design.CustomButton DeleteUserButton;
        private Design.CustomButton CreateUserButton;
        private System.Windows.Forms.Label InfoUsersLabel;
        private System.Windows.Forms.DataGridView DataGridViewApplication;
        private Design.CustomTextBox FilePathTextBox;
        private Design.CustomButton UpdateApplicationButton;
        private Design.CustomButton GenerateRaportButton;
        private System.Windows.Forms.FolderBrowserDialog FolderPathBrowserDialog;
        private System.Windows.Forms.Label FolderPathLabel;
        private System.Windows.Forms.Label LatterPoLabel;
        private System.Windows.Forms.Label LatterOtLabel;
        private System.Windows.Forms.DateTimePicker SecondDateToRaportDTP;
        private System.Windows.Forms.DateTimePicker FirstDateToRaportDTP;
    }
}