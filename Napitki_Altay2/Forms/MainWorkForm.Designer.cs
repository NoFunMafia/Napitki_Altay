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
            this.UpdateDataDGWCButton = new Napitki_Altay2.Design.CustomButton();
            this.MoreInformationButton = new Napitki_Altay2.Design.CustomButton();
            this.CompleteApplicationDGWUser = new System.Windows.Forms.DataGridView();
            this.UserDataPage = new System.Windows.Forms.TabPage();
            this.VisiblePassCheckMain = new System.Windows.Forms.CheckBox();
            this.PasswordWorkInfoLabel = new System.Windows.Forms.Label();
            this.SurnameWorkInfoLabel = new System.Windows.Forms.Label();
            this.NameWorkInfoLabel = new System.Windows.Forms.Label();
            this.FamWorkInfoLabel = new System.Windows.Forms.Label();
            this.InfoUserLabel = new System.Windows.Forms.Label();
            this.MainWorkFormPictureBox = new System.Windows.Forms.PictureBox();
            this.UpdLogPassButton = new Napitki_Altay2.Design.CustomButton();
            this.CreateUserFIOButton = new Napitki_Altay2.Design.CustomButton();
            this.PassCreaUpdaTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.PatrCreateTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.NameCreateTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.FamCreateTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.AboutOurCompanyPage = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ContactInfoLabel = new System.Windows.Forms.Label();
            this.AboutOurCompanyLabel = new System.Windows.Forms.Label();
            this.RussianFlagPictureBox = new System.Windows.Forms.PictureBox();
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.MainWorkTabControl.SuspendLayout();
            this.ApplicationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewApplication)).BeginInit();
            this.AnswerForUserApplicPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompleteApplicationDGWUser)).BeginInit();
            this.UserDataPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainWorkFormPictureBox)).BeginInit();
            this.AboutOurCompanyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RussianFlagPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainWorkTabControl
            // 
            this.MainWorkTabControl.Controls.Add(this.ApplicationPage);
            this.MainWorkTabControl.Controls.Add(this.AnswerForUserApplicPage);
            this.MainWorkTabControl.Controls.Add(this.UserDataPage);
            this.MainWorkTabControl.Controls.Add(this.AboutOurCompanyPage);
            this.MainWorkTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainWorkTabControl.Location = new System.Drawing.Point(6, 8);
            this.MainWorkTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainWorkTabControl.Name = "MainWorkTabControl";
            this.MainWorkTabControl.SelectedIndex = 0;
            this.MainWorkTabControl.Size = new System.Drawing.Size(1528, 861);
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
            this.ApplicationPage.Location = new System.Drawing.Point(8, 43);
            this.ApplicationPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ApplicationPage.Name = "ApplicationPage";
            this.ApplicationPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ApplicationPage.Size = new System.Drawing.Size(1512, 810);
            this.ApplicationPage.TabIndex = 0;
            this.ApplicationPage.Text = "Новые обращения";
            // 
            // InfoApplicationLabel
            // 
            this.InfoApplicationLabel.AutoSize = true;
            this.InfoApplicationLabel.BackColor = System.Drawing.Color.White;
            this.InfoApplicationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.InfoApplicationLabel.ForeColor = System.Drawing.Color.Black;
            this.InfoApplicationLabel.Location = new System.Drawing.Point(744, 9);
            this.InfoApplicationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoApplicationLabel.Name = "InfoApplicationLabel";
            this.InfoApplicationLabel.Size = new System.Drawing.Size(558, 74);
            this.InfoApplicationLabel.TabIndex = 14;
            this.InfoApplicationLabel.Text = "Данные о заявителе не заполнены,\r\nфункция создания обращения отключена.\r\n";
            this.InfoApplicationLabel.Visible = false;
            // 
            // UpdateDataInDGW
            // 
            this.UpdateDataInDGW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.UpdateDataInDGW.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.UpdateDataInDGW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.UpdateDataInDGW.BorderRadius = 0;
            this.UpdateDataInDGW.BorderSize = 0;
            this.UpdateDataInDGW.FlatAppearance.BorderSize = 0;
            this.UpdateDataInDGW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDataInDGW.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateDataInDGW.ForeColor = System.Drawing.Color.White;
            this.UpdateDataInDGW.Location = new System.Drawing.Point(424, 14);
            this.UpdateDataInDGW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdateDataInDGW.Name = "UpdateDataInDGW";
            this.UpdateDataInDGW.Size = new System.Drawing.Size(310, 67);
            this.UpdateDataInDGW.TabIndex = 13;
            this.UpdateDataInDGW.Text = "Обновить данные";
            this.UpdateDataInDGW.TextColor = System.Drawing.Color.White;
            this.UpdateDataInDGW.UseVisualStyleBackColor = false;
            this.UpdateDataInDGW.Click += new System.EventHandler(this.UpdateDataInDGW_Click);
            // 
            // DeleteApplicationButton
            // 
            this.DeleteApplicationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.DeleteApplicationButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.DeleteApplicationButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DeleteApplicationButton.BorderRadius = 0;
            this.DeleteApplicationButton.BorderSize = 0;
            this.DeleteApplicationButton.FlatAppearance.BorderSize = 0;
            this.DeleteApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteApplicationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteApplicationButton.ForeColor = System.Drawing.Color.White;
            this.DeleteApplicationButton.Location = new System.Drawing.Point(216, 14);
            this.DeleteApplicationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteApplicationButton.Name = "DeleteApplicationButton";
            this.DeleteApplicationButton.Size = new System.Drawing.Size(200, 67);
            this.DeleteApplicationButton.TabIndex = 12;
            this.DeleteApplicationButton.Text = "Удалить";
            this.DeleteApplicationButton.TextColor = System.Drawing.Color.White;
            this.DeleteApplicationButton.UseVisualStyleBackColor = false;
            this.DeleteApplicationButton.Click += new System.EventHandler(this.DeleteApplicationButton_Click);
            // 
            // CreateApplicationButton
            // 
            this.CreateApplicationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CreateApplicationButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CreateApplicationButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CreateApplicationButton.BorderRadius = 0;
            this.CreateApplicationButton.BorderSize = 0;
            this.CreateApplicationButton.FlatAppearance.BorderSize = 0;
            this.CreateApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateApplicationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateApplicationButton.ForeColor = System.Drawing.Color.White;
            this.CreateApplicationButton.Location = new System.Drawing.Point(8, 14);
            this.CreateApplicationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CreateApplicationButton.Name = "CreateApplicationButton";
            this.CreateApplicationButton.Size = new System.Drawing.Size(200, 67);
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
            this.DataGridViewApplication.Location = new System.Drawing.Point(4, 94);
            this.DataGridViewApplication.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataGridViewApplication.Name = "DataGridViewApplication";
            this.DataGridViewApplication.ReadOnly = true;
            this.DataGridViewApplication.RowHeadersWidth = 51;
            this.DataGridViewApplication.RowTemplate.Height = 24;
            this.DataGridViewApplication.Size = new System.Drawing.Size(1508, 716);
            this.DataGridViewApplication.TabIndex = 0;
            // 
            // AnswerForUserApplicPage
            // 
            this.AnswerForUserApplicPage.BackColor = System.Drawing.Color.White;
            this.AnswerForUserApplicPage.Controls.Add(this.UpdateDataDGWCButton);
            this.AnswerForUserApplicPage.Controls.Add(this.MoreInformationButton);
            this.AnswerForUserApplicPage.Controls.Add(this.CompleteApplicationDGWUser);
            this.AnswerForUserApplicPage.Location = new System.Drawing.Point(8, 43);
            this.AnswerForUserApplicPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AnswerForUserApplicPage.Name = "AnswerForUserApplicPage";
            this.AnswerForUserApplicPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AnswerForUserApplicPage.Size = new System.Drawing.Size(1512, 810);
            this.AnswerForUserApplicPage.TabIndex = 1;
            this.AnswerForUserApplicPage.Text = "Обращения в работе";
            // 
            // UpdateDataDGWCButton
            // 
            this.UpdateDataDGWCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.UpdateDataDGWCButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.UpdateDataDGWCButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.UpdateDataDGWCButton.BorderRadius = 0;
            this.UpdateDataDGWCButton.BorderSize = 0;
            this.UpdateDataDGWCButton.FlatAppearance.BorderSize = 0;
            this.UpdateDataDGWCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDataDGWCButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateDataDGWCButton.ForeColor = System.Drawing.Color.White;
            this.UpdateDataDGWCButton.Location = new System.Drawing.Point(548, 14);
            this.UpdateDataDGWCButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdateDataDGWCButton.Name = "UpdateDataDGWCButton";
            this.UpdateDataDGWCButton.Size = new System.Drawing.Size(252, 114);
            this.UpdateDataDGWCButton.TabIndex = 14;
            this.UpdateDataDGWCButton.Text = "Обновить данные";
            this.UpdateDataDGWCButton.TextColor = System.Drawing.Color.White;
            this.UpdateDataDGWCButton.UseVisualStyleBackColor = false;
            this.UpdateDataDGWCButton.Click += new System.EventHandler(this.UpdateDataDGWCButton_Click);
            // 
            // MoreInformationButton
            // 
            this.MoreInformationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.MoreInformationButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.MoreInformationButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.MoreInformationButton.BorderRadius = 0;
            this.MoreInformationButton.BorderSize = 0;
            this.MoreInformationButton.FlatAppearance.BorderSize = 0;
            this.MoreInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoreInformationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoreInformationButton.ForeColor = System.Drawing.Color.White;
            this.MoreInformationButton.Location = new System.Drawing.Point(9, 14);
            this.MoreInformationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MoreInformationButton.Name = "MoreInformationButton";
            this.MoreInformationButton.Size = new System.Drawing.Size(530, 114);
            this.MoreInformationButton.TabIndex = 12;
            this.MoreInformationButton.Text = "Дополнить информацию или\r\nпросмотреть ответ сотрудника\r\n";
            this.MoreInformationButton.TextColor = System.Drawing.Color.White;
            this.MoreInformationButton.UseVisualStyleBackColor = false;
            this.MoreInformationButton.Click += new System.EventHandler(this.MoreInformationButton_Click);
            // 
            // CompleteApplicationDGWUser
            // 
            this.CompleteApplicationDGWUser.AllowUserToAddRows = false;
            this.CompleteApplicationDGWUser.AllowUserToDeleteRows = false;
            this.CompleteApplicationDGWUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CompleteApplicationDGWUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompleteApplicationDGWUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CompleteApplicationDGWUser.Location = new System.Drawing.Point(4, 146);
            this.CompleteApplicationDGWUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CompleteApplicationDGWUser.Name = "CompleteApplicationDGWUser";
            this.CompleteApplicationDGWUser.ReadOnly = true;
            this.CompleteApplicationDGWUser.RowHeadersWidth = 51;
            this.CompleteApplicationDGWUser.RowTemplate.Height = 24;
            this.CompleteApplicationDGWUser.Size = new System.Drawing.Size(1504, 661);
            this.CompleteApplicationDGWUser.TabIndex = 1;
            // 
            // UserDataPage
            // 
            this.UserDataPage.BackColor = System.Drawing.Color.White;
            this.UserDataPage.Controls.Add(this.VisiblePassCheckMain);
            this.UserDataPage.Controls.Add(this.PasswordWorkInfoLabel);
            this.UserDataPage.Controls.Add(this.SurnameWorkInfoLabel);
            this.UserDataPage.Controls.Add(this.NameWorkInfoLabel);
            this.UserDataPage.Controls.Add(this.FamWorkInfoLabel);
            this.UserDataPage.Controls.Add(this.InfoUserLabel);
            this.UserDataPage.Controls.Add(this.MainWorkFormPictureBox);
            this.UserDataPage.Controls.Add(this.UpdLogPassButton);
            this.UserDataPage.Controls.Add(this.CreateUserFIOButton);
            this.UserDataPage.Controls.Add(this.PassCreaUpdaTextBox);
            this.UserDataPage.Controls.Add(this.PatrCreateTextBox);
            this.UserDataPage.Controls.Add(this.NameCreateTextBox);
            this.UserDataPage.Controls.Add(this.FamCreateTextBox);
            this.UserDataPage.Location = new System.Drawing.Point(8, 43);
            this.UserDataPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserDataPage.Name = "UserDataPage";
            this.UserDataPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserDataPage.Size = new System.Drawing.Size(1512, 810);
            this.UserDataPage.TabIndex = 2;
            this.UserDataPage.Text = "Данные о пользователе";
            // 
            // VisiblePassCheckMain
            // 
            this.VisiblePassCheckMain.AutoSize = true;
            this.VisiblePassCheckMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisiblePassCheckMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisiblePassCheckMain.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.VisiblePassCheckMain.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisiblePassCheckMain.Location = new System.Drawing.Point(1144, 212);
            this.VisiblePassCheckMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VisiblePassCheckMain.Name = "VisiblePassCheckMain";
            this.VisiblePassCheckMain.Size = new System.Drawing.Size(146, 36);
            this.VisiblePassCheckMain.TabIndex = 22;
            this.VisiblePassCheckMain.Text = "Показать";
            this.VisiblePassCheckMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VisiblePassCheckMain.UseVisualStyleBackColor = true;
            this.VisiblePassCheckMain.CheckedChanged += new System.EventHandler(this.VisiblePassCheckMain_CheckedChanged);
            // 
            // PasswordWorkInfoLabel
            // 
            this.PasswordWorkInfoLabel.AutoSize = true;
            this.PasswordWorkInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordWorkInfoLabel.Location = new System.Drawing.Point(768, 156);
            this.PasswordWorkInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordWorkInfoLabel.Name = "PasswordWorkInfoLabel";
            this.PasswordWorkInfoLabel.Size = new System.Drawing.Size(142, 45);
            this.PasswordWorkInfoLabel.TabIndex = 16;
            this.PasswordWorkInfoLabel.Text = "Пароль:";
            // 
            // SurnameWorkInfoLabel
            // 
            this.SurnameWorkInfoLabel.AutoSize = true;
            this.SurnameWorkInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SurnameWorkInfoLabel.Location = new System.Drawing.Point(334, 386);
            this.SurnameWorkInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SurnameWorkInfoLabel.Name = "SurnameWorkInfoLabel";
            this.SurnameWorkInfoLabel.Size = new System.Drawing.Size(168, 45);
            this.SurnameWorkInfoLabel.TabIndex = 14;
            this.SurnameWorkInfoLabel.Text = "Отчество:";
            // 
            // NameWorkInfoLabel
            // 
            this.NameWorkInfoLabel.AutoSize = true;
            this.NameWorkInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.NameWorkInfoLabel.Location = new System.Drawing.Point(334, 272);
            this.NameWorkInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameWorkInfoLabel.Name = "NameWorkInfoLabel";
            this.NameWorkInfoLabel.Size = new System.Drawing.Size(94, 45);
            this.NameWorkInfoLabel.TabIndex = 13;
            this.NameWorkInfoLabel.Text = "Имя:";
            // 
            // FamWorkInfoLabel
            // 
            this.FamWorkInfoLabel.AutoSize = true;
            this.FamWorkInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FamWorkInfoLabel.Location = new System.Drawing.Point(334, 156);
            this.FamWorkInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FamWorkInfoLabel.Name = "FamWorkInfoLabel";
            this.FamWorkInfoLabel.Size = new System.Drawing.Size(167, 45);
            this.FamWorkInfoLabel.TabIndex = 12;
            this.FamWorkInfoLabel.Text = "Фамилия:";
            // 
            // InfoUserLabel
            // 
            this.InfoUserLabel.AutoSize = true;
            this.InfoUserLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.InfoUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.InfoUserLabel.Location = new System.Drawing.Point(246, 52);
            this.InfoUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoUserLabel.Name = "InfoUserLabel";
            this.InfoUserLabel.Size = new System.Drawing.Size(1044, 81);
            this.InfoUserLabel.TabIndex = 11;
            this.InfoUserLabel.Text = "ИНФОРМАЦИЯ О ПОЛЬЗОВАТЕЛЕ";
            // 
            // MainWorkFormPictureBox
            // 
            this.MainWorkFormPictureBox.Image = global::Napitki_Altay2.Properties.Resources.Герб_Алтайского_края;
            this.MainWorkFormPictureBox.Location = new System.Drawing.Point(992, 436);
            this.MainWorkFormPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainWorkFormPictureBox.Name = "MainWorkFormPictureBox";
            this.MainWorkFormPictureBox.Size = new System.Drawing.Size(355, 325);
            this.MainWorkFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainWorkFormPictureBox.TabIndex = 21;
            this.MainWorkFormPictureBox.TabStop = false;
            // 
            // UpdLogPassButton
            // 
            this.UpdLogPassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.UpdLogPassButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.UpdLogPassButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.UpdLogPassButton.BorderRadius = 0;
            this.UpdLogPassButton.BorderSize = 0;
            this.UpdLogPassButton.FlatAppearance.BorderSize = 0;
            this.UpdLogPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdLogPassButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdLogPassButton.ForeColor = System.Drawing.Color.White;
            this.UpdLogPassButton.Location = new System.Drawing.Point(848, 286);
            this.UpdLogPassButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdLogPassButton.Name = "UpdLogPassButton";
            this.UpdLogPassButton.Size = new System.Drawing.Size(220, 84);
            this.UpdLogPassButton.TabIndex = 20;
            this.UpdLogPassButton.Text = "Изменить";
            this.UpdLogPassButton.TextColor = System.Drawing.Color.White;
            this.UpdLogPassButton.UseVisualStyleBackColor = false;
            this.UpdLogPassButton.Click += new System.EventHandler(this.UpdLogPassButton_Click);
            // 
            // CreateUserFIOButton
            // 
            this.CreateUserFIOButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CreateUserFIOButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CreateUserFIOButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CreateUserFIOButton.BorderRadius = 0;
            this.CreateUserFIOButton.BorderSize = 0;
            this.CreateUserFIOButton.FlatAppearance.BorderSize = 0;
            this.CreateUserFIOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateUserFIOButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateUserFIOButton.ForeColor = System.Drawing.Color.White;
            this.CreateUserFIOButton.Location = new System.Drawing.Point(416, 519);
            this.CreateUserFIOButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CreateUserFIOButton.Name = "CreateUserFIOButton";
            this.CreateUserFIOButton.Size = new System.Drawing.Size(220, 84);
            this.CreateUserFIOButton.TabIndex = 19;
            this.CreateUserFIOButton.Text = "Внести";
            this.CreateUserFIOButton.TextColor = System.Drawing.Color.White;
            this.CreateUserFIOButton.UseVisualStyleBackColor = false;
            this.CreateUserFIOButton.Click += new System.EventHandler(this.CreateUserFIOButton_Click);
            // 
            // PassCreaUpdaTextBox
            // 
            this.PassCreaUpdaTextBox.BackColor = System.Drawing.Color.White;
            this.PassCreaUpdaTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.PassCreaUpdaTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.PassCreaUpdaTextBox.BorderSize = 2;
            this.PassCreaUpdaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PassCreaUpdaTextBox.ForeColor = System.Drawing.Color.Black;
            this.PassCreaUpdaTextBox.Location = new System.Drawing.Point(776, 203);
            this.PassCreaUpdaTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.PassCreaUpdaTextBox.Multiline = false;
            this.PassCreaUpdaTextBox.Name = "PassCreaUpdaTextBox";
            this.PassCreaUpdaTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.PassCreaUpdaTextBox.PasswordChar = true;
            this.PassCreaUpdaTextBox.ReadOnly = false;
            this.PassCreaUpdaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassCreaUpdaTextBox.SelectionStart = 0;
            this.PassCreaUpdaTextBox.Size = new System.Drawing.Size(358, 55);
            this.PassCreaUpdaTextBox.TabIndex = 9;
            this.PassCreaUpdaTextBox.Texts = "";
            this.PassCreaUpdaTextBox.UnderlinedStyle = false;
            // 
            // PatrCreateTextBox
            // 
            this.PatrCreateTextBox.BackColor = System.Drawing.Color.White;
            this.PatrCreateTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.PatrCreateTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.PatrCreateTextBox.BorderSize = 2;
            this.PatrCreateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PatrCreateTextBox.ForeColor = System.Drawing.Color.Black;
            this.PatrCreateTextBox.Location = new System.Drawing.Point(342, 436);
            this.PatrCreateTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.PatrCreateTextBox.Multiline = false;
            this.PatrCreateTextBox.Name = "PatrCreateTextBox";
            this.PatrCreateTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.PatrCreateTextBox.PasswordChar = false;
            this.PatrCreateTextBox.ReadOnly = false;
            this.PatrCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PatrCreateTextBox.SelectionStart = 0;
            this.PatrCreateTextBox.Size = new System.Drawing.Size(358, 55);
            this.PatrCreateTextBox.TabIndex = 8;
            this.PatrCreateTextBox.Texts = "";
            this.PatrCreateTextBox.UnderlinedStyle = false;
            // 
            // NameCreateTextBox
            // 
            this.NameCreateTextBox.BackColor = System.Drawing.Color.White;
            this.NameCreateTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.NameCreateTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.NameCreateTextBox.BorderSize = 2;
            this.NameCreateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.NameCreateTextBox.ForeColor = System.Drawing.Color.Black;
            this.NameCreateTextBox.Location = new System.Drawing.Point(342, 319);
            this.NameCreateTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.NameCreateTextBox.Multiline = false;
            this.NameCreateTextBox.Name = "NameCreateTextBox";
            this.NameCreateTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.NameCreateTextBox.PasswordChar = false;
            this.NameCreateTextBox.ReadOnly = false;
            this.NameCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameCreateTextBox.SelectionStart = 0;
            this.NameCreateTextBox.Size = new System.Drawing.Size(358, 55);
            this.NameCreateTextBox.TabIndex = 7;
            this.NameCreateTextBox.Texts = "";
            this.NameCreateTextBox.UnderlinedStyle = false;
            // 
            // FamCreateTextBox
            // 
            this.FamCreateTextBox.BackColor = System.Drawing.Color.White;
            this.FamCreateTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.FamCreateTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.FamCreateTextBox.BorderSize = 2;
            this.FamCreateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.FamCreateTextBox.ForeColor = System.Drawing.Color.Black;
            this.FamCreateTextBox.Location = new System.Drawing.Point(342, 203);
            this.FamCreateTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.FamCreateTextBox.Multiline = false;
            this.FamCreateTextBox.Name = "FamCreateTextBox";
            this.FamCreateTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.FamCreateTextBox.PasswordChar = false;
            this.FamCreateTextBox.ReadOnly = false;
            this.FamCreateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FamCreateTextBox.SelectionStart = 0;
            this.FamCreateTextBox.Size = new System.Drawing.Size(358, 55);
            this.FamCreateTextBox.TabIndex = 6;
            this.FamCreateTextBox.Texts = "";
            this.FamCreateTextBox.UnderlinedStyle = false;
            // 
            // AboutOurCompanyPage
            // 
            this.AboutOurCompanyPage.BackColor = System.Drawing.Color.White;
            this.AboutOurCompanyPage.Controls.Add(this.pictureBox2);
            this.AboutOurCompanyPage.Controls.Add(this.ContactInfoLabel);
            this.AboutOurCompanyPage.Controls.Add(this.AboutOurCompanyLabel);
            this.AboutOurCompanyPage.Controls.Add(this.RussianFlagPictureBox);
            this.AboutOurCompanyPage.Location = new System.Drawing.Point(8, 43);
            this.AboutOurCompanyPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AboutOurCompanyPage.Name = "AboutOurCompanyPage";
            this.AboutOurCompanyPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AboutOurCompanyPage.Size = new System.Drawing.Size(1512, 810);
            this.AboutOurCompanyPage.TabIndex = 3;
            this.AboutOurCompanyPage.Text = "О Комитете по образованию и делам молодежи";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Napitki_Altay2.Properties.Resources.Герб_Алтайского_края;
            this.pictureBox2.Location = new System.Drawing.Point(974, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(454, 410);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // ContactInfoLabel
            // 
            this.ContactInfoLabel.AutoSize = true;
            this.ContactInfoLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.ContactInfoLabel.Location = new System.Drawing.Point(26, 25);
            this.ContactInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactInfoLabel.Name = "ContactInfoLabel";
            this.ContactInfoLabel.Size = new System.Drawing.Size(663, 81);
            this.ContactInfoLabel.TabIndex = 1;
            this.ContactInfoLabel.Text = "О РАБОТЕ КОМИТЕТА";
            // 
            // AboutOurCompanyLabel
            // 
            this.AboutOurCompanyLabel.AutoSize = true;
            this.AboutOurCompanyLabel.Font = new System.Drawing.Font("Segoe UI", 12.1F);
            this.AboutOurCompanyLabel.Location = new System.Drawing.Point(27, 125);
            this.AboutOurCompanyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AboutOurCompanyLabel.Name = "AboutOurCompanyLabel";
            this.AboutOurCompanyLabel.Size = new System.Drawing.Size(858, 405);
            this.AboutOurCompanyLabel.TabIndex = 3;
            this.AboutOurCompanyLabel.Text = resources.GetString("AboutOurCompanyLabel.Text");
            // 
            // RussianFlagPictureBox
            // 
            this.RussianFlagPictureBox.Image = global::Napitki_Altay2.Properties.Resources.Лента_флага2;
            this.RussianFlagPictureBox.Location = new System.Drawing.Point(0, 455);
            this.RussianFlagPictureBox.Name = "RussianFlagPictureBox";
            this.RussianFlagPictureBox.Size = new System.Drawing.Size(1512, 353);
            this.RussianFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RussianFlagPictureBox.TabIndex = 4;
            this.RussianFlagPictureBox.TabStop = false;
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
            this.CustomFormForAllProject.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.CustomFormForAllProject.HeaderHeight = 29;
            this.CustomFormForAllProject.HeaderImage = null;
            this.CustomFormForAllProject.HeaderTextColor = System.Drawing.Color.White;
            this.CustomFormForAllProject.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // MainWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1538, 877);
            this.Controls.Add(this.MainWorkTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоматизация документооборота. Заявитель - данные не определены";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWorkForm_FormClosed);
            this.Load += new System.EventHandler(this.MainWorkForm_Load);
            this.MainWorkTabControl.ResumeLayout(false);
            this.ApplicationPage.ResumeLayout(false);
            this.ApplicationPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewApplication)).EndInit();
            this.AnswerForUserApplicPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompleteApplicationDGWUser)).EndInit();
            this.UserDataPage.ResumeLayout(false);
            this.UserDataPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainWorkFormPictureBox)).EndInit();
            this.AboutOurCompanyPage.ResumeLayout(false);
            this.AboutOurCompanyPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RussianFlagPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.FormStyleCustom CustomFormForAllProject;
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
        private System.Windows.Forms.Label FamWorkInfoLabel;
        private System.Windows.Forms.Label NameWorkInfoLabel;
        private System.Windows.Forms.Label SurnameWorkInfoLabel;
        private System.Windows.Forms.Label PasswordWorkInfoLabel;
        private Design.CustomButton UpdLogPassButton;
        private Design.CustomButton CreateUserFIOButton;
        private System.Windows.Forms.Label InfoApplicationLabel;
        private System.Windows.Forms.PictureBox MainWorkFormPictureBox;
        private System.Windows.Forms.TabPage AboutOurCompanyPage;
        private System.Windows.Forms.Label ContactInfoLabel;
        private System.Windows.Forms.Label AboutOurCompanyLabel;
        private System.Windows.Forms.DataGridView CompleteApplicationDGWUser;
        private System.Windows.Forms.CheckBox VisiblePassCheckMain;
        private Design.CustomButton MoreInformationButton;
        private Design.CustomButton UpdateDataDGWCButton;
        private System.Windows.Forms.PictureBox RussianFlagPictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}