namespace Napitki_Altay2.Forms
{
    partial class MainWorkFormWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWorkFormWorker));
            this.MainWorkWorkerTabControl = new System.Windows.Forms.TabControl();
            this.AnswerToApplicationPage = new System.Windows.Forms.TabPage();
            this.InfoAnswerLabel = new System.Windows.Forms.Label();
            this.DataGridViewAnswer = new System.Windows.Forms.DataGridView();
            this.DoneApplicationPage = new System.Windows.Forms.TabPage();
            this.HelpToApplicationPage = new System.Windows.Forms.TabPage();
            this.WorkerDataPage = new System.Windows.Forms.TabPage();
            this.MainWorkFormWorkerPictureBox = new System.Windows.Forms.PictureBox();
            this.PasswordWorkInfoLabel = new System.Windows.Forms.Label();
            this.SurnameWorkInfoLabel = new System.Windows.Forms.Label();
            this.NameWorkInfoLabel = new System.Windows.Forms.Label();
            this.FamWorkInfoLabel = new System.Windows.Forms.Label();
            this.InfoUserLabel = new System.Windows.Forms.Label();
            this.UpdateAnswerInDGW = new Napitki_Altay2.Design.CustomButton();
            this.AnswerToApplicationButton = new Napitki_Altay2.Design.CustomButton();
            this.UpdLogPassButton = new Napitki_Altay2.Design.CustomButton();
            this.CreateUserFIOButton = new Napitki_Altay2.Design.CustomButton();
            this.PassWorkCreaUpdaTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.PatrWorkCreateTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.NameWorkCreateTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.FamWorkCreateTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.MainWorkWorkerTabControl.SuspendLayout();
            this.AnswerToApplicationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAnswer)).BeginInit();
            this.WorkerDataPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainWorkFormWorkerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainWorkWorkerTabControl
            // 
            this.MainWorkWorkerTabControl.Controls.Add(this.AnswerToApplicationPage);
            this.MainWorkWorkerTabControl.Controls.Add(this.DoneApplicationPage);
            this.MainWorkWorkerTabControl.Controls.Add(this.HelpToApplicationPage);
            this.MainWorkWorkerTabControl.Controls.Add(this.WorkerDataPage);
            this.MainWorkWorkerTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MainWorkWorkerTabControl.ItemSize = new System.Drawing.Size(130, 23);
            this.MainWorkWorkerTabControl.Location = new System.Drawing.Point(4, 5);
            this.MainWorkWorkerTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainWorkWorkerTabControl.Name = "MainWorkWorkerTabControl";
            this.MainWorkWorkerTabControl.SelectedIndex = 0;
            this.MainWorkWorkerTabControl.Size = new System.Drawing.Size(1019, 551);
            this.MainWorkWorkerTabControl.TabIndex = 0;
            // 
            // AnswerToApplicationPage
            // 
            this.AnswerToApplicationPage.BackColor = System.Drawing.Color.White;
            this.AnswerToApplicationPage.Controls.Add(this.UpdateAnswerInDGW);
            this.AnswerToApplicationPage.Controls.Add(this.AnswerToApplicationButton);
            this.AnswerToApplicationPage.Controls.Add(this.InfoAnswerLabel);
            this.AnswerToApplicationPage.Controls.Add(this.DataGridViewAnswer);
            this.AnswerToApplicationPage.Location = new System.Drawing.Point(4, 27);
            this.AnswerToApplicationPage.Name = "AnswerToApplicationPage";
            this.AnswerToApplicationPage.Padding = new System.Windows.Forms.Padding(3);
            this.AnswerToApplicationPage.Size = new System.Drawing.Size(1011, 520);
            this.AnswerToApplicationPage.TabIndex = 1;
            this.AnswerToApplicationPage.Text = "Дать ответ на обращение";
            // 
            // InfoAnswerLabel
            // 
            this.InfoAnswerLabel.AutoSize = true;
            this.InfoAnswerLabel.BackColor = System.Drawing.Color.White;
            this.InfoAnswerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.InfoAnswerLabel.ForeColor = System.Drawing.Color.Black;
            this.InfoAnswerLabel.Location = new System.Drawing.Point(357, 6);
            this.InfoAnswerLabel.Name = "InfoAnswerLabel";
            this.InfoAnswerLabel.Size = new System.Drawing.Size(354, 46);
            this.InfoAnswerLabel.TabIndex = 15;
            this.InfoAnswerLabel.Text = "Данные о сотруднике не заполнены,\r\nфункция ответа на обращение отключена.\r\n";
            this.InfoAnswerLabel.Visible = false;
            // 
            // DataGridViewAnswer
            // 
            this.DataGridViewAnswer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewAnswer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAnswer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewAnswer.Location = new System.Drawing.Point(3, 61);
            this.DataGridViewAnswer.Name = "DataGridViewAnswer";
            this.DataGridViewAnswer.ReadOnly = true;
            this.DataGridViewAnswer.RowHeadersWidth = 51;
            this.DataGridViewAnswer.RowTemplate.Height = 24;
            this.DataGridViewAnswer.Size = new System.Drawing.Size(1005, 456);
            this.DataGridViewAnswer.TabIndex = 0;
            // 
            // DoneApplicationPage
            // 
            this.DoneApplicationPage.BackColor = System.Drawing.Color.White;
            this.DoneApplicationPage.Location = new System.Drawing.Point(4, 27);
            this.DoneApplicationPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoneApplicationPage.Name = "DoneApplicationPage";
            this.DoneApplicationPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoneApplicationPage.Size = new System.Drawing.Size(1011, 520);
            this.DoneApplicationPage.TabIndex = 0;
            this.DoneApplicationPage.Text = "Завершенные обращения";
            // 
            // HelpToApplicationPage
            // 
            this.HelpToApplicationPage.BackColor = System.Drawing.Color.White;
            this.HelpToApplicationPage.Location = new System.Drawing.Point(4, 27);
            this.HelpToApplicationPage.Name = "HelpToApplicationPage";
            this.HelpToApplicationPage.Padding = new System.Windows.Forms.Padding(3);
            this.HelpToApplicationPage.Size = new System.Drawing.Size(1011, 520);
            this.HelpToApplicationPage.TabIndex = 2;
            this.HelpToApplicationPage.Text = "Справка по ответам на обращения";
            // 
            // WorkerDataPage
            // 
            this.WorkerDataPage.BackColor = System.Drawing.Color.White;
            this.WorkerDataPage.Controls.Add(this.MainWorkFormWorkerPictureBox);
            this.WorkerDataPage.Controls.Add(this.PasswordWorkInfoLabel);
            this.WorkerDataPage.Controls.Add(this.SurnameWorkInfoLabel);
            this.WorkerDataPage.Controls.Add(this.NameWorkInfoLabel);
            this.WorkerDataPage.Controls.Add(this.FamWorkInfoLabel);
            this.WorkerDataPage.Controls.Add(this.InfoUserLabel);
            this.WorkerDataPage.Controls.Add(this.UpdLogPassButton);
            this.WorkerDataPage.Controls.Add(this.CreateUserFIOButton);
            this.WorkerDataPage.Controls.Add(this.PassWorkCreaUpdaTextBox);
            this.WorkerDataPage.Controls.Add(this.PatrWorkCreateTextBox);
            this.WorkerDataPage.Controls.Add(this.NameWorkCreateTextBox);
            this.WorkerDataPage.Controls.Add(this.FamWorkCreateTextBox);
            this.WorkerDataPage.Location = new System.Drawing.Point(4, 27);
            this.WorkerDataPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WorkerDataPage.Name = "WorkerDataPage";
            this.WorkerDataPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WorkerDataPage.Size = new System.Drawing.Size(1011, 520);
            this.WorkerDataPage.TabIndex = 3;
            this.WorkerDataPage.Text = "Данные о сотруднике";
            // 
            // MainWorkFormWorkerPictureBox
            // 
            this.MainWorkFormWorkerPictureBox.Image = global::Napitki_Altay2.Properties.Resources.PictureMainWorkForm;
            this.MainWorkFormWorkerPictureBox.Location = new System.Drawing.Point(502, 264);
            this.MainWorkFormWorkerPictureBox.Name = "MainWorkFormWorkerPictureBox";
            this.MainWorkFormWorkerPictureBox.Size = new System.Drawing.Size(507, 255);
            this.MainWorkFormWorkerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainWorkFormWorkerPictureBox.TabIndex = 33;
            this.MainWorkFormWorkerPictureBox.TabStop = false;
            // 
            // PasswordWorkInfoLabel
            // 
            this.PasswordWorkInfoLabel.AutoSize = true;
            this.PasswordWorkInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordWorkInfoLabel.Location = new System.Drawing.Point(512, 100);
            this.PasswordWorkInfoLabel.Name = "PasswordWorkInfoLabel";
            this.PasswordWorkInfoLabel.Size = new System.Drawing.Size(88, 28);
            this.PasswordWorkInfoLabel.TabIndex = 30;
            this.PasswordWorkInfoLabel.Text = "Пароль:";
            // 
            // SurnameWorkInfoLabel
            // 
            this.SurnameWorkInfoLabel.AutoSize = true;
            this.SurnameWorkInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SurnameWorkInfoLabel.Location = new System.Drawing.Point(223, 247);
            this.SurnameWorkInfoLabel.Name = "SurnameWorkInfoLabel";
            this.SurnameWorkInfoLabel.Size = new System.Drawing.Size(105, 28);
            this.SurnameWorkInfoLabel.TabIndex = 29;
            this.SurnameWorkInfoLabel.Text = "Отчество:";
            // 
            // NameWorkInfoLabel
            // 
            this.NameWorkInfoLabel.AutoSize = true;
            this.NameWorkInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.NameWorkInfoLabel.Location = new System.Drawing.Point(223, 174);
            this.NameWorkInfoLabel.Name = "NameWorkInfoLabel";
            this.NameWorkInfoLabel.Size = new System.Drawing.Size(58, 28);
            this.NameWorkInfoLabel.TabIndex = 28;
            this.NameWorkInfoLabel.Text = "Имя:";
            // 
            // FamWorkInfoLabel
            // 
            this.FamWorkInfoLabel.AutoSize = true;
            this.FamWorkInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FamWorkInfoLabel.Location = new System.Drawing.Point(223, 100);
            this.FamWorkInfoLabel.Name = "FamWorkInfoLabel";
            this.FamWorkInfoLabel.Size = new System.Drawing.Size(104, 28);
            this.FamWorkInfoLabel.TabIndex = 27;
            this.FamWorkInfoLabel.Text = "Фамилия:";
            // 
            // InfoUserLabel
            // 
            this.InfoUserLabel.AutoSize = true;
            this.InfoUserLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.InfoUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(64)))), ((int)(((byte)(127)))));
            this.InfoUserLabel.Location = new System.Drawing.Point(174, 33);
            this.InfoUserLabel.Name = "InfoUserLabel";
            this.InfoUserLabel.Size = new System.Drawing.Size(598, 50);
            this.InfoUserLabel.TabIndex = 26;
            this.InfoUserLabel.Text = "ИНФОРМАЦИЯ О СОТРУДНИКЕ";
            // 
            // UpdateAnswerInDGW
            // 
            this.UpdateAnswerInDGW.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateAnswerInDGW.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.UpdateAnswerInDGW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.UpdateAnswerInDGW.BorderRadius = 0;
            this.UpdateAnswerInDGW.BorderSize = 0;
            this.UpdateAnswerInDGW.FlatAppearance.BorderSize = 0;
            this.UpdateAnswerInDGW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateAnswerInDGW.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateAnswerInDGW.ForeColor = System.Drawing.Color.White;
            this.UpdateAnswerInDGW.Location = new System.Drawing.Point(144, 9);
            this.UpdateAnswerInDGW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateAnswerInDGW.Name = "UpdateAnswerInDGW";
            this.UpdateAnswerInDGW.Size = new System.Drawing.Size(207, 43);
            this.UpdateAnswerInDGW.TabIndex = 17;
            this.UpdateAnswerInDGW.Text = "Обновить данные";
            this.UpdateAnswerInDGW.TextColor = System.Drawing.Color.White;
            this.UpdateAnswerInDGW.UseVisualStyleBackColor = false;
            this.UpdateAnswerInDGW.Click += new System.EventHandler(this.UpdateAnswerInDGW_Click);
            // 
            // AnswerToApplicationButton
            // 
            this.AnswerToApplicationButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AnswerToApplicationButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.AnswerToApplicationButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.AnswerToApplicationButton.BorderRadius = 0;
            this.AnswerToApplicationButton.BorderSize = 0;
            this.AnswerToApplicationButton.FlatAppearance.BorderSize = 0;
            this.AnswerToApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerToApplicationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerToApplicationButton.ForeColor = System.Drawing.Color.White;
            this.AnswerToApplicationButton.Location = new System.Drawing.Point(5, 9);
            this.AnswerToApplicationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerToApplicationButton.Name = "AnswerToApplicationButton";
            this.AnswerToApplicationButton.Size = new System.Drawing.Size(133, 43);
            this.AnswerToApplicationButton.TabIndex = 16;
            this.AnswerToApplicationButton.Text = "Ответить";
            this.AnswerToApplicationButton.TextColor = System.Drawing.Color.White;
            this.AnswerToApplicationButton.UseVisualStyleBackColor = false;
            this.AnswerToApplicationButton.Click += new System.EventHandler(this.AnswerToApplicationButton_Click);
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
            this.UpdLogPassButton.TabIndex = 32;
            this.UpdLogPassButton.Text = "Изменить";
            this.UpdLogPassButton.TextColor = System.Drawing.Color.White;
            this.UpdLogPassButton.UseVisualStyleBackColor = false;
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
            this.CreateUserFIOButton.TabIndex = 31;
            this.CreateUserFIOButton.Text = "Внести";
            this.CreateUserFIOButton.TextColor = System.Drawing.Color.White;
            this.CreateUserFIOButton.UseVisualStyleBackColor = false;
            this.CreateUserFIOButton.Click += new System.EventHandler(this.CreateUserFIOButton_Click);
            // 
            // PassWorkCreaUpdaTextBox
            // 
            this.PassWorkCreaUpdaTextBox.BackColor = System.Drawing.Color.White;
            this.PassWorkCreaUpdaTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PassWorkCreaUpdaTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.PassWorkCreaUpdaTextBox.BorderSize = 2;
            this.PassWorkCreaUpdaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PassWorkCreaUpdaTextBox.ForeColor = System.Drawing.Color.Black;
            this.PassWorkCreaUpdaTextBox.Location = new System.Drawing.Point(517, 130);
            this.PassWorkCreaUpdaTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PassWorkCreaUpdaTextBox.Multiline = false;
            this.PassWorkCreaUpdaTextBox.Name = "PassWorkCreaUpdaTextBox";
            this.PassWorkCreaUpdaTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.PassWorkCreaUpdaTextBox.PasswordChar = false;
            this.PassWorkCreaUpdaTextBox.Size = new System.Drawing.Size(239, 35);
            this.PassWorkCreaUpdaTextBox.TabIndex = 25;
            this.PassWorkCreaUpdaTextBox.Texts = "";
            this.PassWorkCreaUpdaTextBox.UnderlinedStyle = false;
            // 
            // PatrWorkCreateTextBox
            // 
            this.PatrWorkCreateTextBox.BackColor = System.Drawing.Color.White;
            this.PatrWorkCreateTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PatrWorkCreateTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.PatrWorkCreateTextBox.BorderSize = 2;
            this.PatrWorkCreateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PatrWorkCreateTextBox.ForeColor = System.Drawing.Color.Black;
            this.PatrWorkCreateTextBox.Location = new System.Drawing.Point(228, 279);
            this.PatrWorkCreateTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PatrWorkCreateTextBox.Multiline = false;
            this.PatrWorkCreateTextBox.Name = "PatrWorkCreateTextBox";
            this.PatrWorkCreateTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.PatrWorkCreateTextBox.PasswordChar = false;
            this.PatrWorkCreateTextBox.Size = new System.Drawing.Size(239, 35);
            this.PatrWorkCreateTextBox.TabIndex = 24;
            this.PatrWorkCreateTextBox.Texts = "";
            this.PatrWorkCreateTextBox.UnderlinedStyle = false;
            // 
            // NameWorkCreateTextBox
            // 
            this.NameWorkCreateTextBox.BackColor = System.Drawing.Color.White;
            this.NameWorkCreateTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.NameWorkCreateTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.NameWorkCreateTextBox.BorderSize = 2;
            this.NameWorkCreateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.NameWorkCreateTextBox.ForeColor = System.Drawing.Color.Black;
            this.NameWorkCreateTextBox.Location = new System.Drawing.Point(228, 204);
            this.NameWorkCreateTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NameWorkCreateTextBox.Multiline = false;
            this.NameWorkCreateTextBox.Name = "NameWorkCreateTextBox";
            this.NameWorkCreateTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.NameWorkCreateTextBox.PasswordChar = false;
            this.NameWorkCreateTextBox.Size = new System.Drawing.Size(239, 35);
            this.NameWorkCreateTextBox.TabIndex = 23;
            this.NameWorkCreateTextBox.Texts = "";
            this.NameWorkCreateTextBox.UnderlinedStyle = false;
            // 
            // FamWorkCreateTextBox
            // 
            this.FamWorkCreateTextBox.BackColor = System.Drawing.Color.White;
            this.FamWorkCreateTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.FamWorkCreateTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.FamWorkCreateTextBox.BorderSize = 2;
            this.FamWorkCreateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.FamWorkCreateTextBox.ForeColor = System.Drawing.Color.Black;
            this.FamWorkCreateTextBox.Location = new System.Drawing.Point(228, 130);
            this.FamWorkCreateTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.FamWorkCreateTextBox.Multiline = false;
            this.FamWorkCreateTextBox.Name = "FamWorkCreateTextBox";
            this.FamWorkCreateTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.FamWorkCreateTextBox.PasswordChar = false;
            this.FamWorkCreateTextBox.Size = new System.Drawing.Size(239, 35);
            this.FamWorkCreateTextBox.TabIndex = 22;
            this.FamWorkCreateTextBox.Texts = "";
            this.FamWorkCreateTextBox.UnderlinedStyle = false;
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
            this.CustomFormForAllProject.HeaderColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CustomFormForAllProject.HeaderColorGradientEnable = true;
            this.CustomFormForAllProject.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.CustomFormForAllProject.HeaderHeight = 29;
            this.CustomFormForAllProject.HeaderImage = null;
            this.CustomFormForAllProject.HeaderTextColor = System.Drawing.Color.White;
            this.CustomFormForAllProject.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // MainWorkFormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 561);
            this.Controls.Add(this.MainWorkWorkerTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWorkFormWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Напитки Алтая";
            this.Load += new System.EventHandler(this.MainWorkFormWorker_Load);
            this.MainWorkWorkerTabControl.ResumeLayout(false);
            this.AnswerToApplicationPage.ResumeLayout(false);
            this.AnswerToApplicationPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAnswer)).EndInit();
            this.WorkerDataPage.ResumeLayout(false);
            this.WorkerDataPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainWorkFormWorkerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.FormStyleCustom CustomFormForAllProject;
        private System.Windows.Forms.TabControl MainWorkWorkerTabControl;
        private System.Windows.Forms.TabPage DoneApplicationPage;
        private System.Windows.Forms.TabPage AnswerToApplicationPage;
        private System.Windows.Forms.TabPage HelpToApplicationPage;
        private System.Windows.Forms.TabPage WorkerDataPage;
        private System.Windows.Forms.DataGridView DataGridViewAnswer;
        private System.Windows.Forms.PictureBox MainWorkFormWorkerPictureBox;
        private System.Windows.Forms.Label PasswordWorkInfoLabel;
        private System.Windows.Forms.Label SurnameWorkInfoLabel;
        private System.Windows.Forms.Label NameWorkInfoLabel;
        private System.Windows.Forms.Label FamWorkInfoLabel;
        private System.Windows.Forms.Label InfoUserLabel;
        private Design.CustomButton UpdLogPassButton;
        private Design.CustomButton CreateUserFIOButton;
        private Design.CustomTextBox PassWorkCreaUpdaTextBox;
        private Design.CustomTextBox PatrWorkCreateTextBox;
        private Design.CustomTextBox NameWorkCreateTextBox;
        private Design.CustomTextBox FamWorkCreateTextBox;
        private System.Windows.Forms.Label InfoAnswerLabel;
        private Design.CustomButton AnswerToApplicationButton;
        private Design.CustomButton UpdateAnswerInDGW;
    }
}