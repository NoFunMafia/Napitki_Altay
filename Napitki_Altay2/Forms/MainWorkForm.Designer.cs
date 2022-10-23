namespace Napitki_Altay2.Forms
{
    partial class MainWorkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWorkForm));
            this.MainWorkTabControl = new System.Windows.Forms.TabControl();
            this.ApplicationPage = new System.Windows.Forms.TabPage();
            this.InfoApplicationLabel = new System.Windows.Forms.Label();
            this.UpdateDataInDGW = new Napitki_Altay2.Design.CustomButton();
            this.DeleteApplicationButton = new Napitki_Altay2.Design.CustomButton();
            this.CreateApplicationButton = new Napitki_Altay2.Design.CustomButton();
            this.DataGridViewApplication = new System.Windows.Forms.DataGridView();
            this.AnswerForUserApplicPage = new System.Windows.Forms.TabPage();
            this.UserDataPage = new System.Windows.Forms.TabPage();
            this.PasswordInfoLabel = new System.Windows.Forms.Label();
            this.SurnameInfoLabel = new System.Windows.Forms.Label();
            this.NameInfoLabel = new System.Windows.Forms.Label();
            this.FamInfoLabel = new System.Windows.Forms.Label();
            this.InfoUserLabel = new System.Windows.Forms.Label();
            this.UpdLogPassButton = new Napitki_Altay2.Design.CustomButton();
            this.CreateUserFIOButton = new Napitki_Altay2.Design.CustomButton();
            this.PassCreaUpdaTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.PatrCreateTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.NameCreateTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.FamCreateTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.AboutOurCompanyPage = new System.Windows.Forms.TabPage();
            this.ContactInfoLabel = new System.Windows.Forms.Label();
            this.CustomFormForAllProject = new Napitki_Altay2.DesignComponents.CustomForm(this.components);
            this.MainWorkFormPictureBox = new System.Windows.Forms.PictureBox();
            this.MainWorkFormPictureBox3 = new System.Windows.Forms.PictureBox();
            this.MainWorkFormPictureBox2 = new System.Windows.Forms.PictureBox();
            this.AboutOurCompanyLabel = new System.Windows.Forms.Label();
            this.DocumentTypeInfoPage = new System.Windows.Forms.TabPage();
            this.MainWorkTabControl.SuspendLayout();
            this.ApplicationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewApplication)).BeginInit();
            this.UserDataPage.SuspendLayout();
            this.AboutOurCompanyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainWorkFormPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWorkFormPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWorkFormPictureBox2)).BeginInit();
            this.DocumentTypeInfoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWorkTabControl
            // 
            this.MainWorkTabControl.Controls.Add(this.ApplicationPage);
            this.MainWorkTabControl.Controls.Add(this.AnswerForUserApplicPage);
            this.MainWorkTabControl.Controls.Add(this.DocumentTypeInfoPage);
            this.MainWorkTabControl.Controls.Add(this.UserDataPage);
            this.MainWorkTabControl.Controls.Add(this.AboutOurCompanyPage);
            this.MainWorkTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainWorkTabControl.Location = new System.Drawing.Point(4, 5);
            this.MainWorkTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainWorkTabControl.Name = "MainWorkTabControl";
            this.MainWorkTabControl.SelectedIndex = 0;
            this.MainWorkTabControl.Size = new System.Drawing.Size(1019, 551);
            this.MainWorkTabControl.TabIndex = 0;
            // 
            // ApplicationPage
            // 
            this.ApplicationPage.BackColor = System.Drawing.Color.White;
            this.ApplicationPage.Controls.Add(this.InfoApplicationLabel);
            this.ApplicationPage.Controls.Add(this.UpdateDataInDGW);
            this.ApplicationPage.Controls.Add(this.DeleteApplicationButton);
            this.ApplicationPage.Controls.Add(this.CreateApplicationButton);
            this.ApplicationPage.Controls.Add(this.DataGridViewApplication);
            this.ApplicationPage.Location = new System.Drawing.Point(4, 27);
            this.ApplicationPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplicationPage.Name = "ApplicationPage";
            this.ApplicationPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplicationPage.Size = new System.Drawing.Size(1011, 520);
            this.ApplicationPage.TabIndex = 0;
            this.ApplicationPage.Text = "Ваши обращения";
            // 
            // InfoApplicationLabel
            // 
            this.InfoApplicationLabel.AutoSize = true;
            this.InfoApplicationLabel.BackColor = System.Drawing.Color.White;
            this.InfoApplicationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.InfoApplicationLabel.ForeColor = System.Drawing.Color.Black;
            this.InfoApplicationLabel.Location = new System.Drawing.Point(496, 6);
            this.InfoApplicationLabel.Name = "InfoApplicationLabel";
            this.InfoApplicationLabel.Size = new System.Drawing.Size(325, 46);
            this.InfoApplicationLabel.TabIndex = 14;
            this.InfoApplicationLabel.Text = "Данные о пользователе не заполнены,\r\nфункции создания заявки отключены.\r\n";
            this.InfoApplicationLabel.Visible = false;
            // 
            // UpdateDataInDGW
            // 
            this.UpdateDataInDGW.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateDataInDGW.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.UpdateDataInDGW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.UpdateDataInDGW.BorderRadius = 0;
            this.UpdateDataInDGW.BorderSize = 0;
            this.UpdateDataInDGW.FlatAppearance.BorderSize = 0;
            this.UpdateDataInDGW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDataInDGW.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateDataInDGW.ForeColor = System.Drawing.Color.White;
            this.UpdateDataInDGW.Location = new System.Drawing.Point(283, 9);
            this.UpdateDataInDGW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateDataInDGW.Name = "UpdateDataInDGW";
            this.UpdateDataInDGW.Size = new System.Drawing.Size(207, 43);
            this.UpdateDataInDGW.TabIndex = 13;
            this.UpdateDataInDGW.Text = "Обновить данные";
            this.UpdateDataInDGW.TextColor = System.Drawing.Color.White;
            this.UpdateDataInDGW.UseVisualStyleBackColor = false;
            this.UpdateDataInDGW.Click += new System.EventHandler(this.UpdateDataInDGW_Click);
            // 
            // DeleteApplicationButton
            // 
            this.DeleteApplicationButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteApplicationButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.DeleteApplicationButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DeleteApplicationButton.BorderRadius = 0;
            this.DeleteApplicationButton.BorderSize = 0;
            this.DeleteApplicationButton.FlatAppearance.BorderSize = 0;
            this.DeleteApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteApplicationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteApplicationButton.ForeColor = System.Drawing.Color.White;
            this.DeleteApplicationButton.Location = new System.Drawing.Point(144, 9);
            this.DeleteApplicationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteApplicationButton.Name = "DeleteApplicationButton";
            this.DeleteApplicationButton.Size = new System.Drawing.Size(133, 43);
            this.DeleteApplicationButton.TabIndex = 12;
            this.DeleteApplicationButton.Text = "Удалить";
            this.DeleteApplicationButton.TextColor = System.Drawing.Color.White;
            this.DeleteApplicationButton.UseVisualStyleBackColor = false;
            this.DeleteApplicationButton.Click += new System.EventHandler(this.DeleteApplicationButton_Click);
            // 
            // CreateApplicationButton
            // 
            this.CreateApplicationButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CreateApplicationButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.CreateApplicationButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CreateApplicationButton.BorderRadius = 0;
            this.CreateApplicationButton.BorderSize = 0;
            this.CreateApplicationButton.FlatAppearance.BorderSize = 0;
            this.CreateApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateApplicationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateApplicationButton.ForeColor = System.Drawing.Color.White;
            this.CreateApplicationButton.Location = new System.Drawing.Point(5, 9);
            this.CreateApplicationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateApplicationButton.Name = "CreateApplicationButton";
            this.CreateApplicationButton.Size = new System.Drawing.Size(133, 43);
            this.CreateApplicationButton.TabIndex = 10;
            this.CreateApplicationButton.Text = "Создать";
            this.CreateApplicationButton.TextColor = System.Drawing.Color.White;
            this.CreateApplicationButton.UseVisualStyleBackColor = false;
            this.CreateApplicationButton.Click += new System.EventHandler(this.CreateApplicationButton_Click);
            // 
            // DataGridViewApplication
            // 
            this.DataGridViewApplication.AllowUserToAddRows = false;
            this.DataGridViewApplication.AllowUserToDeleteRows = false;
            this.DataGridViewApplication.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewApplication.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewApplication.Location = new System.Drawing.Point(3, 60);
            this.DataGridViewApplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewApplication.Name = "DataGridViewApplication";
            this.DataGridViewApplication.ReadOnly = true;
            this.DataGridViewApplication.RowHeadersWidth = 51;
            this.DataGridViewApplication.RowTemplate.Height = 24;
            this.DataGridViewApplication.Size = new System.Drawing.Size(1005, 458);
            this.DataGridViewApplication.TabIndex = 0;
            // 
            // AnswerForUserApplicPage
            // 
            this.AnswerForUserApplicPage.BackColor = System.Drawing.Color.White;
            this.AnswerForUserApplicPage.Location = new System.Drawing.Point(4, 27);
            this.AnswerForUserApplicPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerForUserApplicPage.Name = "AnswerForUserApplicPage";
            this.AnswerForUserApplicPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerForUserApplicPage.Size = new System.Drawing.Size(1011, 520);
            this.AnswerForUserApplicPage.TabIndex = 1;
            this.AnswerForUserApplicPage.Text = "Ответы на обращения";
            // 
            // UserDataPage
            // 
            this.UserDataPage.BackColor = System.Drawing.Color.White;
            this.UserDataPage.Controls.Add(this.MainWorkFormPictureBox);
            this.UserDataPage.Controls.Add(this.PasswordInfoLabel);
            this.UserDataPage.Controls.Add(this.SurnameInfoLabel);
            this.UserDataPage.Controls.Add(this.NameInfoLabel);
            this.UserDataPage.Controls.Add(this.FamInfoLabel);
            this.UserDataPage.Controls.Add(this.InfoUserLabel);
            this.UserDataPage.Controls.Add(this.UpdLogPassButton);
            this.UserDataPage.Controls.Add(this.CreateUserFIOButton);
            this.UserDataPage.Controls.Add(this.PassCreaUpdaTextBox);
            this.UserDataPage.Controls.Add(this.PatrCreateTextBox);
            this.UserDataPage.Controls.Add(this.NameCreateTextBox);
            this.UserDataPage.Controls.Add(this.FamCreateTextBox);
            this.UserDataPage.Location = new System.Drawing.Point(4, 27);
            this.UserDataPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserDataPage.Name = "UserDataPage";
            this.UserDataPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserDataPage.Size = new System.Drawing.Size(1011, 520);
            this.UserDataPage.TabIndex = 2;
            this.UserDataPage.Text = "Данные о пользователе";
            // 
            // PasswordInfoLabel
            // 
            this.PasswordInfoLabel.AutoSize = true;
            this.PasswordInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordInfoLabel.Location = new System.Drawing.Point(512, 100);
            this.PasswordInfoLabel.Name = "PasswordInfoLabel";
            this.PasswordInfoLabel.Size = new System.Drawing.Size(88, 28);
            this.PasswordInfoLabel.TabIndex = 16;
            this.PasswordInfoLabel.Text = "Пароль:";
            // 
            // SurnameInfoLabel
            // 
            this.SurnameInfoLabel.AutoSize = true;
            this.SurnameInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SurnameInfoLabel.Location = new System.Drawing.Point(223, 247);
            this.SurnameInfoLabel.Name = "SurnameInfoLabel";
            this.SurnameInfoLabel.Size = new System.Drawing.Size(105, 28);
            this.SurnameInfoLabel.TabIndex = 14;
            this.SurnameInfoLabel.Text = "Отчество:";
            // 
            // NameInfoLabel
            // 
            this.NameInfoLabel.AutoSize = true;
            this.NameInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.NameInfoLabel.Location = new System.Drawing.Point(223, 174);
            this.NameInfoLabel.Name = "NameInfoLabel";
            this.NameInfoLabel.Size = new System.Drawing.Size(58, 28);
            this.NameInfoLabel.TabIndex = 13;
            this.NameInfoLabel.Text = "Имя:";
            // 
            // FamInfoLabel
            // 
            this.FamInfoLabel.AutoSize = true;
            this.FamInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FamInfoLabel.Location = new System.Drawing.Point(223, 100);
            this.FamInfoLabel.Name = "FamInfoLabel";
            this.FamInfoLabel.Size = new System.Drawing.Size(104, 28);
            this.FamInfoLabel.TabIndex = 12;
            this.FamInfoLabel.Text = "Фамилия:";
            // 
            // InfoUserLabel
            // 
            this.InfoUserLabel.AutoSize = true;
            this.InfoUserLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.InfoUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(64)))), ((int)(((byte)(127)))));
            this.InfoUserLabel.Location = new System.Drawing.Point(164, 33);
            this.InfoUserLabel.Name = "InfoUserLabel";
            this.InfoUserLabel.Size = new System.Drawing.Size(645, 50);
            this.InfoUserLabel.TabIndex = 11;
            this.InfoUserLabel.Text = "ИНФОРМАЦИЯ О ПОЛЬЗОВАТЕЛЕ";
            // 
            // UpdLogPassButton
            // 
            this.UpdLogPassButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdLogPassButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.UpdLogPassButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.UpdLogPassButton.BorderRadius = 0;
            this.UpdLogPassButton.BorderSize = 0;
            this.UpdLogPassButton.FlatAppearance.BorderSize = 0;
            this.UpdLogPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdLogPassButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdLogPassButton.ForeColor = System.Drawing.Color.White;
            this.UpdLogPassButton.Location = new System.Drawing.Point(565, 183);
            this.UpdLogPassButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdLogPassButton.Name = "UpdLogPassButton";
            this.UpdLogPassButton.Size = new System.Drawing.Size(147, 54);
            this.UpdLogPassButton.TabIndex = 20;
            this.UpdLogPassButton.Text = "Изменить";
            this.UpdLogPassButton.TextColor = System.Drawing.Color.White;
            this.UpdLogPassButton.UseVisualStyleBackColor = false;
            this.UpdLogPassButton.Click += new System.EventHandler(this.UpdLogPassButton_Click);
            // 
            // CreateUserFIOButton
            // 
            this.CreateUserFIOButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CreateUserFIOButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.CreateUserFIOButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CreateUserFIOButton.BorderRadius = 0;
            this.CreateUserFIOButton.BorderSize = 0;
            this.CreateUserFIOButton.FlatAppearance.BorderSize = 0;
            this.CreateUserFIOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateUserFIOButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateUserFIOButton.ForeColor = System.Drawing.Color.White;
            this.CreateUserFIOButton.Location = new System.Drawing.Point(277, 332);
            this.CreateUserFIOButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateUserFIOButton.Name = "CreateUserFIOButton";
            this.CreateUserFIOButton.Size = new System.Drawing.Size(147, 54);
            this.CreateUserFIOButton.TabIndex = 19;
            this.CreateUserFIOButton.Text = "Внести";
            this.CreateUserFIOButton.TextColor = System.Drawing.Color.White;
            this.CreateUserFIOButton.UseVisualStyleBackColor = false;
            this.CreateUserFIOButton.Click += new System.EventHandler(this.CreateUserFIOButton_Click);
            // 
            // PassCreaUpdaTextBox
            // 
            this.PassCreaUpdaTextBox.BackColor = System.Drawing.Color.White;
            this.PassCreaUpdaTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PassCreaUpdaTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.PassCreaUpdaTextBox.BorderSize = 2;
            this.PassCreaUpdaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PassCreaUpdaTextBox.ForeColor = System.Drawing.Color.Black;
            this.PassCreaUpdaTextBox.Location = new System.Drawing.Point(517, 130);
            this.PassCreaUpdaTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PassCreaUpdaTextBox.Multiline = false;
            this.PassCreaUpdaTextBox.Name = "PassCreaUpdaTextBox";
            this.PassCreaUpdaTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.PassCreaUpdaTextBox.PasswordChar = false;
            this.PassCreaUpdaTextBox.Size = new System.Drawing.Size(239, 35);
            this.PassCreaUpdaTextBox.TabIndex = 9;
            this.PassCreaUpdaTextBox.Texts = "";
            this.PassCreaUpdaTextBox.UnderlinedStyle = false;
            // 
            // PatrCreateTextBox
            // 
            this.PatrCreateTextBox.BackColor = System.Drawing.Color.White;
            this.PatrCreateTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PatrCreateTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.PatrCreateTextBox.BorderSize = 2;
            this.PatrCreateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PatrCreateTextBox.ForeColor = System.Drawing.Color.Black;
            this.PatrCreateTextBox.Location = new System.Drawing.Point(228, 279);
            this.PatrCreateTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PatrCreateTextBox.Multiline = false;
            this.PatrCreateTextBox.Name = "PatrCreateTextBox";
            this.PatrCreateTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.PatrCreateTextBox.PasswordChar = false;
            this.PatrCreateTextBox.Size = new System.Drawing.Size(239, 35);
            this.PatrCreateTextBox.TabIndex = 8;
            this.PatrCreateTextBox.Texts = "";
            this.PatrCreateTextBox.UnderlinedStyle = false;
            // 
            // NameCreateTextBox
            // 
            this.NameCreateTextBox.BackColor = System.Drawing.Color.White;
            this.NameCreateTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.NameCreateTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.NameCreateTextBox.BorderSize = 2;
            this.NameCreateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.NameCreateTextBox.ForeColor = System.Drawing.Color.Black;
            this.NameCreateTextBox.Location = new System.Drawing.Point(228, 204);
            this.NameCreateTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NameCreateTextBox.Multiline = false;
            this.NameCreateTextBox.Name = "NameCreateTextBox";
            this.NameCreateTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.NameCreateTextBox.PasswordChar = false;
            this.NameCreateTextBox.Size = new System.Drawing.Size(239, 35);
            this.NameCreateTextBox.TabIndex = 7;
            this.NameCreateTextBox.Texts = "";
            this.NameCreateTextBox.UnderlinedStyle = false;
            // 
            // FamCreateTextBox
            // 
            this.FamCreateTextBox.BackColor = System.Drawing.Color.White;
            this.FamCreateTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.FamCreateTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.FamCreateTextBox.BorderSize = 2;
            this.FamCreateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.FamCreateTextBox.ForeColor = System.Drawing.Color.Black;
            this.FamCreateTextBox.Location = new System.Drawing.Point(228, 130);
            this.FamCreateTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.FamCreateTextBox.Multiline = false;
            this.FamCreateTextBox.Name = "FamCreateTextBox";
            this.FamCreateTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.FamCreateTextBox.PasswordChar = false;
            this.FamCreateTextBox.Size = new System.Drawing.Size(239, 35);
            this.FamCreateTextBox.TabIndex = 6;
            this.FamCreateTextBox.Texts = "";
            this.FamCreateTextBox.UnderlinedStyle = false;
            // 
            // AboutOurCompanyPage
            // 
            this.AboutOurCompanyPage.BackColor = System.Drawing.Color.White;
            this.AboutOurCompanyPage.Controls.Add(this.MainWorkFormPictureBox3);
            this.AboutOurCompanyPage.Controls.Add(this.ContactInfoLabel);
            this.AboutOurCompanyPage.Controls.Add(this.AboutOurCompanyLabel);
            this.AboutOurCompanyPage.Controls.Add(this.MainWorkFormPictureBox2);
            this.AboutOurCompanyPage.Location = new System.Drawing.Point(4, 27);
            this.AboutOurCompanyPage.Name = "AboutOurCompanyPage";
            this.AboutOurCompanyPage.Padding = new System.Windows.Forms.Padding(3);
            this.AboutOurCompanyPage.Size = new System.Drawing.Size(1011, 520);
            this.AboutOurCompanyPage.TabIndex = 3;
            this.AboutOurCompanyPage.Text = "О нашей компании";
            // 
            // ContactInfoLabel
            // 
            this.ContactInfoLabel.AutoSize = true;
            this.ContactInfoLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(64)))), ((int)(((byte)(127)))));
            this.ContactInfoLabel.Location = new System.Drawing.Point(17, 16);
            this.ContactInfoLabel.Name = "ContactInfoLabel";
            this.ContactInfoLabel.Size = new System.Drawing.Size(436, 50);
            this.ContactInfoLabel.TabIndex = 1;
            this.ContactInfoLabel.Text = "О НАШЕЙ КОМПАНИИ";
            // 
            // CustomFormForAllProject
            // 
            this.CustomFormForAllProject.Form = this;
            this.CustomFormForAllProject.FormStyle = Napitki_Altay2.DesignComponents.CustomForm.fStyle.None;
            // 
            // MainWorkFormPictureBox
            // 
            this.MainWorkFormPictureBox.Image = global::Napitki_Altay2.Properties.Resources.PictureMainWorkForm;
            this.MainWorkFormPictureBox.Location = new System.Drawing.Point(502, 264);
            this.MainWorkFormPictureBox.Name = "MainWorkFormPictureBox";
            this.MainWorkFormPictureBox.Size = new System.Drawing.Size(507, 255);
            this.MainWorkFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainWorkFormPictureBox.TabIndex = 21;
            this.MainWorkFormPictureBox.TabStop = false;
            // 
            // MainWorkFormPictureBox3
            // 
            this.MainWorkFormPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("MainWorkFormPictureBox3.Image")));
            this.MainWorkFormPictureBox3.Location = new System.Drawing.Point(495, 19);
            this.MainWorkFormPictureBox3.Name = "MainWorkFormPictureBox3";
            this.MainWorkFormPictureBox3.Size = new System.Drawing.Size(510, 405);
            this.MainWorkFormPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainWorkFormPictureBox3.TabIndex = 2;
            this.MainWorkFormPictureBox3.TabStop = false;
            // 
            // MainWorkFormPictureBox2
            // 
            this.MainWorkFormPictureBox2.Image = global::Napitki_Altay2.Properties.Resources.Picture2MainWorkForm;
            this.MainWorkFormPictureBox2.Location = new System.Drawing.Point(157, 281);
            this.MainWorkFormPictureBox2.Name = "MainWorkFormPictureBox2";
            this.MainWorkFormPictureBox2.Size = new System.Drawing.Size(851, 236);
            this.MainWorkFormPictureBox2.TabIndex = 0;
            this.MainWorkFormPictureBox2.TabStop = false;
            // 
            // AboutOurCompanyLabel
            // 
            this.AboutOurCompanyLabel.AutoSize = true;
            this.AboutOurCompanyLabel.Font = new System.Drawing.Font("Segoe UI", 12.1F);
            this.AboutOurCompanyLabel.Location = new System.Drawing.Point(18, 80);
            this.AboutOurCompanyLabel.Name = "AboutOurCompanyLabel";
            this.AboutOurCompanyLabel.Size = new System.Drawing.Size(462, 330);
            this.AboutOurCompanyLabel.TabIndex = 3;
            this.AboutOurCompanyLabel.Text = resources.GetString("AboutOurCompanyLabel.Text");
            // 
            // DocumentTypeInfoPage
            // 
            this.DocumentTypeInfoPage.BackColor = System.Drawing.Color.White;
            this.DocumentTypeInfoPage.Location = new System.Drawing.Point(4, 27);
            this.DocumentTypeInfoPage.Name = "DocumentTypeInfoPage";
            this.DocumentTypeInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.DocumentTypeInfoPage.Size = new System.Drawing.Size(1011, 520);
            this.DocumentTypeInfoPage.TabIndex = 4;
            this.DocumentTypeInfoPage.Text = "Документация";
            // 
            // MainWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 561);
            this.Controls.Add(this.MainWorkTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Напитки Алтая";
            this.Load += new System.EventHandler(this.MainWorkForm_Load);
            this.MainWorkTabControl.ResumeLayout(false);
            this.ApplicationPage.ResumeLayout(false);
            this.ApplicationPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewApplication)).EndInit();
            this.UserDataPage.ResumeLayout(false);
            this.UserDataPage.PerformLayout();
            this.AboutOurCompanyPage.ResumeLayout(false);
            this.AboutOurCompanyPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainWorkFormPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWorkFormPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWorkFormPictureBox2)).EndInit();
            this.DocumentTypeInfoPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DesignComponents.CustomForm CustomFormForAllProject;
        private System.Windows.Forms.TabControl MainWorkTabControl;
        private System.Windows.Forms.TabPage ApplicationPage;
        private System.Windows.Forms.TabPage AnswerForUserApplicPage;
        private System.Windows.Forms.TabPage UserDataPage;
        private System.Windows.Forms.DataGridView DataGridViewApplication;
        private Design.CustomButton DeleteApplicationButton;
        private Design.CustomButton CreateApplicationButton;
        private Design.CustomButton UpdateDataInDGW;
        private System.Windows.Forms.Label InfoUserLabel;
        private Design.CustomTextBox PassCreaUpdaTextBox;
        private Design.CustomTextBox PatrCreateTextBox;
        private Design.CustomTextBox NameCreateTextBox;
        private Design.CustomTextBox FamCreateTextBox;
        private System.Windows.Forms.Label FamInfoLabel;
        private System.Windows.Forms.Label NameInfoLabel;
        private System.Windows.Forms.Label SurnameInfoLabel;
        private System.Windows.Forms.Label PasswordInfoLabel;
        private Design.CustomButton UpdLogPassButton;
        private Design.CustomButton CreateUserFIOButton;
        private System.Windows.Forms.Label InfoApplicationLabel;
        private System.Windows.Forms.PictureBox MainWorkFormPictureBox;
        private System.Windows.Forms.TabPage AboutOurCompanyPage;
        private System.Windows.Forms.PictureBox MainWorkFormPictureBox2;
        private System.Windows.Forms.Label ContactInfoLabel;
        private System.Windows.Forms.PictureBox MainWorkFormPictureBox3;
        private System.Windows.Forms.Label AboutOurCompanyLabel;
        private System.Windows.Forms.TabPage DocumentTypeInfoPage;
    }
}