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
            this.UpdateUserDataButton = new Napitki_Altay2.Design.CustomButton();
            this.UpdateUserButton = new Napitki_Altay2.Design.CustomButton();
            this.CreateUserButton = new Napitki_Altay2.Design.CustomButton();
            this.DataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.AllApplicationPage = new System.Windows.Forms.TabPage();
            this.LatterPoLabel = new System.Windows.Forms.Label();
            this.LatterOtLabel = new System.Windows.Forms.Label();
            this.SecondDateToRaportDTP = new System.Windows.Forms.DateTimePicker();
            this.FirstDateToRaportDTP = new System.Windows.Forms.DateTimePicker();
            this.FolderPathLabel = new System.Windows.Forms.Label();
            this.FilePathTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.UpdateApplicationButton = new Napitki_Altay2.Design.CustomButton();
            this.GenerateRaportButton = new Napitki_Altay2.Design.CustomButton();
            this.DataGridViewApplication = new System.Windows.Forms.DataGridView();
            this.FolderPathBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
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
            this.MainWorkAdminTabControl.Location = new System.Drawing.Point(6, 8);
            this.MainWorkAdminTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainWorkAdminTabControl.Name = "MainWorkAdminTabControl";
            this.MainWorkAdminTabControl.SelectedIndex = 0;
            this.MainWorkAdminTabControl.Size = new System.Drawing.Size(1528, 967);
            this.MainWorkAdminTabControl.TabIndex = 0;
            // 
            // AllUsersPage
            // 
            this.AllUsersPage.Controls.Add(this.UpdateUserDataButton);
            this.AllUsersPage.Controls.Add(this.UpdateUserButton);
            this.AllUsersPage.Controls.Add(this.CreateUserButton);
            this.AllUsersPage.Controls.Add(this.DataGridViewUsers);
            this.AllUsersPage.Location = new System.Drawing.Point(8, 43);
            this.AllUsersPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllUsersPage.Name = "AllUsersPage";
            this.AllUsersPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllUsersPage.Size = new System.Drawing.Size(1512, 916);
            this.AllUsersPage.TabIndex = 0;
            this.AllUsersPage.Text = "Пользователи";
            this.AllUsersPage.UseVisualStyleBackColor = true;
            // 
            // UpdateUserDataButton
            // 
            this.UpdateUserDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.UpdateUserDataButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.UpdateUserDataButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.UpdateUserDataButton.BorderRadius = 0;
            this.UpdateUserDataButton.BorderSize = 0;
            this.UpdateUserDataButton.FlatAppearance.BorderSize = 0;
            this.UpdateUserDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateUserDataButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateUserDataButton.ForeColor = System.Drawing.Color.White;
            this.UpdateUserDataButton.Location = new System.Drawing.Point(426, 12);
            this.UpdateUserDataButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdateUserDataButton.Name = "UpdateUserDataButton";
            this.UpdateUserDataButton.Size = new System.Drawing.Size(310, 67);
            this.UpdateUserDataButton.TabIndex = 16;
            this.UpdateUserDataButton.Text = "Обновить данные";
            this.UpdateUserDataButton.TextColor = System.Drawing.Color.White;
            this.UpdateUserDataButton.UseVisualStyleBackColor = false;
            this.UpdateUserDataButton.Click += new System.EventHandler(this.UpdateUserDataButton_Click);
            // 
            // UpdateUserButton
            // 
            this.UpdateUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.UpdateUserButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.UpdateUserButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.UpdateUserButton.BorderRadius = 0;
            this.UpdateUserButton.BorderSize = 0;
            this.UpdateUserButton.FlatAppearance.BorderSize = 0;
            this.UpdateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateUserButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateUserButton.ForeColor = System.Drawing.Color.White;
            this.UpdateUserButton.Location = new System.Drawing.Point(218, 12);
            this.UpdateUserButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdateUserButton.Name = "UpdateUserButton";
            this.UpdateUserButton.Size = new System.Drawing.Size(200, 67);
            this.UpdateUserButton.TabIndex = 15;
            this.UpdateUserButton.Text = "Изменить";
            this.UpdateUserButton.TextColor = System.Drawing.Color.White;
            this.UpdateUserButton.UseVisualStyleBackColor = false;
            this.UpdateUserButton.Click += new System.EventHandler(this.UpdateUserButton_Click);
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CreateUserButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CreateUserButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CreateUserButton.BorderRadius = 0;
            this.CreateUserButton.BorderSize = 0;
            this.CreateUserButton.FlatAppearance.BorderSize = 0;
            this.CreateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateUserButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateUserButton.ForeColor = System.Drawing.Color.White;
            this.CreateUserButton.Location = new System.Drawing.Point(9, 12);
            this.CreateUserButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(200, 67);
            this.CreateUserButton.TabIndex = 14;
            this.CreateUserButton.Text = "Создать";
            this.CreateUserButton.TextColor = System.Drawing.Color.White;
            this.CreateUserButton.UseVisualStyleBackColor = false;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // DataGridViewUsers
            // 
            this.DataGridViewUsers.AllowUserToAddRows = false;
            this.DataGridViewUsers.AllowUserToDeleteRows = false;
            this.DataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUsers.Location = new System.Drawing.Point(4, 92);
            this.DataGridViewUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridViewUsers.Name = "DataGridViewUsers";
            this.DataGridViewUsers.ReadOnly = true;
            this.DataGridViewUsers.RowHeadersWidth = 51;
            this.DataGridViewUsers.RowTemplate.Height = 24;
            this.DataGridViewUsers.Size = new System.Drawing.Size(1508, 820);
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
            this.AllApplicationPage.Location = new System.Drawing.Point(8, 43);
            this.AllApplicationPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllApplicationPage.Name = "AllApplicationPage";
            this.AllApplicationPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllApplicationPage.Size = new System.Drawing.Size(1512, 916);
            this.AllApplicationPage.TabIndex = 1;
            this.AllApplicationPage.Text = "Отчётность";
            this.AllApplicationPage.UseVisualStyleBackColor = true;
            // 
            // LatterPoLabel
            // 
            this.LatterPoLabel.AutoSize = true;
            this.LatterPoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LatterPoLabel.Location = new System.Drawing.Point(12, 223);
            this.LatterPoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LatterPoLabel.Name = "LatterPoLabel";
            this.LatterPoLabel.Size = new System.Drawing.Size(67, 45);
            this.LatterPoLabel.TabIndex = 37;
            this.LatterPoLabel.Text = "ДО";
            // 
            // LatterOtLabel
            // 
            this.LatterOtLabel.AutoSize = true;
            this.LatterOtLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LatterOtLabel.Location = new System.Drawing.Point(20, 158);
            this.LatterOtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LatterOtLabel.Name = "LatterOtLabel";
            this.LatterOtLabel.Size = new System.Drawing.Size(61, 45);
            this.LatterOtLabel.TabIndex = 36;
            this.LatterOtLabel.Text = "ОТ";
            // 
            // SecondDateToRaportDTP
            // 
            this.SecondDateToRaportDTP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SecondDateToRaportDTP.Location = new System.Drawing.Point(84, 216);
            this.SecondDateToRaportDTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SecondDateToRaportDTP.Name = "SecondDateToRaportDTP";
            this.SecondDateToRaportDTP.Size = new System.Drawing.Size(295, 50);
            this.SecondDateToRaportDTP.TabIndex = 35;
            this.SecondDateToRaportDTP.ValueChanged += new System.EventHandler(this.SecondDateToRaportDTP_ValueChanged);
            // 
            // FirstDateToRaportDTP
            // 
            this.FirstDateToRaportDTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstDateToRaportDTP.Location = new System.Drawing.Point(84, 150);
            this.FirstDateToRaportDTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstDateToRaportDTP.Name = "FirstDateToRaportDTP";
            this.FirstDateToRaportDTP.Size = new System.Drawing.Size(295, 50);
            this.FirstDateToRaportDTP.TabIndex = 34;
            this.FirstDateToRaportDTP.ValueChanged += new System.EventHandler(this.FirstDateToRaportDTP_ValueChanged);
            // 
            // FolderPathLabel
            // 
            this.FolderPathLabel.AutoSize = true;
            this.FolderPathLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FolderPathLabel.Location = new System.Drawing.Point(8, 8);
            this.FolderPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FolderPathLabel.Name = "FolderPathLabel";
            this.FolderPathLabel.Size = new System.Drawing.Size(698, 45);
            this.FolderPathLabel.TabIndex = 29;
            this.FolderPathLabel.Text = "Путь сохранения для формирования отчёта:";
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
            this.FilePathTextBox.Location = new System.Drawing.Point(15, 58);
            this.FilePathTextBox.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.FilePathTextBox.Multiline = false;
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.FilePathTextBox.PasswordChar = false;
            this.FilePathTextBox.ReadOnly = false;
            this.FilePathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FilePathTextBox.SelectionStart = 0;
            this.FilePathTextBox.Size = new System.Drawing.Size(1486, 65);
            this.FilePathTextBox.TabIndex = 27;
            this.FilePathTextBox.Texts = "";
            this.FilePathTextBox.UnderlinedStyle = false;
            // 
            // UpdateApplicationButton
            // 
            this.UpdateApplicationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.UpdateApplicationButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.UpdateApplicationButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.UpdateApplicationButton.BorderRadius = 0;
            this.UpdateApplicationButton.BorderSize = 0;
            this.UpdateApplicationButton.FlatAppearance.BorderSize = 0;
            this.UpdateApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateApplicationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateApplicationButton.ForeColor = System.Drawing.Color.White;
            this.UpdateApplicationButton.Location = new System.Drawing.Point(717, 136);
            this.UpdateApplicationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdateApplicationButton.Name = "UpdateApplicationButton";
            this.UpdateApplicationButton.Size = new System.Drawing.Size(252, 144);
            this.UpdateApplicationButton.TabIndex = 26;
            this.UpdateApplicationButton.Text = "Обновить данные";
            this.UpdateApplicationButton.TextColor = System.Drawing.Color.White;
            this.UpdateApplicationButton.UseVisualStyleBackColor = false;
            this.UpdateApplicationButton.Click += new System.EventHandler(this.UpdateApplicationButton_Click);
            // 
            // GenerateRaportButton
            // 
            this.GenerateRaportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.GenerateRaportButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.GenerateRaportButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.GenerateRaportButton.BorderRadius = 0;
            this.GenerateRaportButton.BorderSize = 0;
            this.GenerateRaportButton.FlatAppearance.BorderSize = 0;
            this.GenerateRaportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateRaportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateRaportButton.ForeColor = System.Drawing.Color.White;
            this.GenerateRaportButton.Location = new System.Drawing.Point(408, 136);
            this.GenerateRaportButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GenerateRaportButton.Name = "GenerateRaportButton";
            this.GenerateRaportButton.Size = new System.Drawing.Size(300, 144);
            this.GenerateRaportButton.TabIndex = 25;
            this.GenerateRaportButton.Text = "Сформировать отчёт";
            this.GenerateRaportButton.TextColor = System.Drawing.Color.White;
            this.GenerateRaportButton.UseVisualStyleBackColor = false;
            this.GenerateRaportButton.Click += new System.EventHandler(this.GenerateRaportButton_Click);
            // 
            // DataGridViewApplication
            // 
            this.DataGridViewApplication.AllowUserToAddRows = false;
            this.DataGridViewApplication.AllowUserToDeleteRows = false;
            this.DataGridViewApplication.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewApplication.Location = new System.Drawing.Point(4, 302);
            this.DataGridViewApplication.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridViewApplication.Name = "DataGridViewApplication";
            this.DataGridViewApplication.RowHeadersWidth = 51;
            this.DataGridViewApplication.RowTemplate.Height = 24;
            this.DataGridViewApplication.Size = new System.Drawing.Size(1508, 612);
            this.DataGridViewApplication.TabIndex = 0;
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
            this.CustomFormForAllProject.HeaderColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CustomFormForAllProject.HeaderColorGradientEnable = true;
            this.CustomFormForAllProject.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.CustomFormForAllProject.HeaderHeight = 29;
            this.CustomFormForAllProject.HeaderImage = null;
            this.CustomFormForAllProject.HeaderTextColor = System.Drawing.Color.White;
            this.CustomFormForAllProject.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // MainWorkFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 981);
            this.Controls.Add(this.MainWorkAdminTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWorkFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Админ-панель «Автоматизация документооборота»";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWorkFormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.MainWorkFormAdmin_Load);
            this.MainWorkAdminTabControl.ResumeLayout(false);
            this.AllUsersPage.ResumeLayout(false);
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
        private Design.CustomButton UpdateUserDataButton;
        private Design.CustomButton UpdateUserButton;
        private Design.CustomButton CreateUserButton;
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