namespace Napitki_Altay2.Forms
{
    partial class UserApplicationInfoForWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserApplicationInfoForWorkerForm));
            this.OpenDocumentWorkLabel = new System.Windows.Forms.Label();
            this.DateTimeDescrWorkLabel = new System.Windows.Forms.Label();
            this.DescripApplWorkLabel = new System.Windows.Forms.Label();
            this.ApplWorkDTP = new System.Windows.Forms.DateTimePicker();
            this.OpenDocumentWorkButton = new Napitki_Altay2.Design.CustomButton();
            this.CloseApplicWorkButton = new Napitki_Altay2.Design.CustomButton();
            this.DescripWorkTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.ApplPictureBox = new System.Windows.Forms.PictureBox();
            this.TypeApplWorkTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.TypeApplWorkLabel = new System.Windows.Forms.Label();
            this.AdministrationLabel = new System.Windows.Forms.Label();
            this.DocumentListBox = new System.Windows.Forms.ListBox();
            this.DownloadDocWorkButton = new Napitki_Altay2.Design.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.ApplPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenDocumentWorkLabel
            // 
            this.OpenDocumentWorkLabel.AutoSize = true;
            this.OpenDocumentWorkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.OpenDocumentWorkLabel.Location = new System.Drawing.Point(715, 67);
            this.OpenDocumentWorkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpenDocumentWorkLabel.Name = "OpenDocumentWorkLabel";
            this.OpenDocumentWorkLabel.Size = new System.Drawing.Size(386, 45);
            this.OpenDocumentWorkLabel.TabIndex = 36;
            this.OpenDocumentWorkLabel.Text = "Прикрепленные файлы:";
            // 
            // DateTimeDescrWorkLabel
            // 
            this.DateTimeDescrWorkLabel.AutoSize = true;
            this.DateTimeDescrWorkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DateTimeDescrWorkLabel.Location = new System.Drawing.Point(30, 1487);
            this.DateTimeDescrWorkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateTimeDescrWorkLabel.Name = "DateTimeDescrWorkLabel";
            this.DateTimeDescrWorkLabel.Size = new System.Drawing.Size(636, 45);
            this.DateTimeDescrWorkLabel.TabIndex = 30;
            this.DateTimeDescrWorkLabel.Text = "Время создания/обновления заявления:";
            // 
            // DescripApplWorkLabel
            // 
            this.DescripApplWorkLabel.AutoSize = true;
            this.DescripApplWorkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DescripApplWorkLabel.Location = new System.Drawing.Point(30, 735);
            this.DescripApplWorkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescripApplWorkLabel.Name = "DescripApplWorkLabel";
            this.DescripApplWorkLabel.Size = new System.Drawing.Size(359, 45);
            this.DescripApplWorkLabel.TabIndex = 29;
            this.DescripApplWorkLabel.Text = "Описание обращения:";
            // 
            // ApplWorkDTP
            // 
            this.ApplWorkDTP.Enabled = false;
            this.ApplWorkDTP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplWorkDTP.Location = new System.Drawing.Point(38, 1540);
            this.ApplWorkDTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ApplWorkDTP.Name = "ApplWorkDTP";
            this.ApplWorkDTP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ApplWorkDTP.Size = new System.Drawing.Size(426, 56);
            this.ApplWorkDTP.TabIndex = 26;
            // 
            // OpenDocumentWorkButton
            // 
            this.OpenDocumentWorkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.OpenDocumentWorkButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.OpenDocumentWorkButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.OpenDocumentWorkButton.BorderRadius = 0;
            this.OpenDocumentWorkButton.BorderSize = 0;
            this.OpenDocumentWorkButton.FlatAppearance.BorderSize = 0;
            this.OpenDocumentWorkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDocumentWorkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.OpenDocumentWorkButton.ForeColor = System.Drawing.Color.White;
            this.OpenDocumentWorkButton.Location = new System.Drawing.Point(783, 669);
            this.OpenDocumentWorkButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OpenDocumentWorkButton.Name = "OpenDocumentWorkButton";
            this.OpenDocumentWorkButton.Size = new System.Drawing.Size(307, 88);
            this.OpenDocumentWorkButton.TabIndex = 35;
            this.OpenDocumentWorkButton.Text = "Открыть файл";
            this.OpenDocumentWorkButton.TextColor = System.Drawing.Color.White;
            this.OpenDocumentWorkButton.UseVisualStyleBackColor = false;
            this.OpenDocumentWorkButton.Click += new System.EventHandler(this.OpenDocumentWorkButton_Click);
            // 
            // CloseApplicWorkButton
            // 
            this.CloseApplicWorkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CloseApplicWorkButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CloseApplicWorkButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CloseApplicWorkButton.BorderRadius = 0;
            this.CloseApplicWorkButton.BorderSize = 0;
            this.CloseApplicWorkButton.FlatAppearance.BorderSize = 0;
            this.CloseApplicWorkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApplicWorkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseApplicWorkButton.ForeColor = System.Drawing.Color.White;
            this.CloseApplicWorkButton.Location = new System.Drawing.Point(783, 1636);
            this.CloseApplicWorkButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseApplicWorkButton.Name = "CloseApplicWorkButton";
            this.CloseApplicWorkButton.Size = new System.Drawing.Size(740, 128);
            this.CloseApplicWorkButton.TabIndex = 32;
            this.CloseApplicWorkButton.Text = "Закрыть заявление";
            this.CloseApplicWorkButton.TextColor = System.Drawing.Color.White;
            this.CloseApplicWorkButton.UseVisualStyleBackColor = false;
            this.CloseApplicWorkButton.Click += new System.EventHandler(this.CloseApplicWorkButton_Click);
            // 
            // DescripWorkTextBox
            // 
            this.DescripWorkTextBox.BackColor = System.Drawing.Color.White;
            this.DescripWorkTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.DescripWorkTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.DescripWorkTextBox.BorderSize = 2;
            this.DescripWorkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DescripWorkTextBox.ForeColor = System.Drawing.Color.Black;
            this.DescripWorkTextBox.Location = new System.Drawing.Point(41, 795);
            this.DescripWorkTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.DescripWorkTextBox.Multiline = true;
            this.DescripWorkTextBox.Name = "DescripWorkTextBox";
            this.DescripWorkTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.DescripWorkTextBox.PasswordChar = false;
            this.DescripWorkTextBox.ReadOnly = true;
            this.DescripWorkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescripWorkTextBox.SelectionStart = 0;
            this.DescripWorkTextBox.Size = new System.Drawing.Size(1537, 669);
            this.DescripWorkTextBox.TabIndex = 25;
            this.DescripWorkTextBox.Texts = "";
            this.DescripWorkTextBox.UnderlinedStyle = false;
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
            // ApplPictureBox
            // 
            this.ApplPictureBox.BackColor = System.Drawing.Color.White;
            this.ApplPictureBox.Image = global::Napitki_Altay2.Properties.Resources.Герб_Алтайского_края;
            this.ApplPictureBox.Location = new System.Drawing.Point(200, 38);
            this.ApplPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ApplPictureBox.Name = "ApplPictureBox";
            this.ApplPictureBox.Size = new System.Drawing.Size(314, 320);
            this.ApplPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ApplPictureBox.TabIndex = 22;
            this.ApplPictureBox.TabStop = false;
            // 
            // TypeApplWorkTextBox
            // 
            this.TypeApplWorkTextBox.BackColor = System.Drawing.Color.White;
            this.TypeApplWorkTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.TypeApplWorkTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.TypeApplWorkTextBox.BorderSize = 2;
            this.TypeApplWorkTextBox.Enabled = false;
            this.TypeApplWorkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TypeApplWorkTextBox.ForeColor = System.Drawing.Color.Black;
            this.TypeApplWorkTextBox.Location = new System.Drawing.Point(41, 580);
            this.TypeApplWorkTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.TypeApplWorkTextBox.Multiline = false;
            this.TypeApplWorkTextBox.Name = "TypeApplWorkTextBox";
            this.TypeApplWorkTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.TypeApplWorkTextBox.PasswordChar = false;
            this.TypeApplWorkTextBox.ReadOnly = false;
            this.TypeApplWorkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TypeApplWorkTextBox.SelectionStart = 0;
            this.TypeApplWorkTextBox.Size = new System.Drawing.Size(574, 55);
            this.TypeApplWorkTextBox.TabIndex = 24;
            this.TypeApplWorkTextBox.Texts = "";
            this.TypeApplWorkTextBox.UnderlinedStyle = false;
            // 
            // TypeApplWorkLabel
            // 
            this.TypeApplWorkLabel.AutoSize = true;
            this.TypeApplWorkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.TypeApplWorkLabel.Location = new System.Drawing.Point(33, 530);
            this.TypeApplWorkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeApplWorkLabel.Name = "TypeApplWorkLabel";
            this.TypeApplWorkLabel.Size = new System.Drawing.Size(263, 45);
            this.TypeApplWorkLabel.TabIndex = 28;
            this.TypeApplWorkLabel.Text = "Тип обращения:";
            // 
            // AdministrationLabel
            // 
            this.AdministrationLabel.AutoSize = true;
            this.AdministrationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.AdministrationLabel.Location = new System.Drawing.Point(26, 374);
            this.AdministrationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdministrationLabel.Name = "AdministrationLabel";
            this.AdministrationLabel.Size = new System.Drawing.Size(662, 92);
            this.AdministrationLabel.TabIndex = 37;
            this.AdministrationLabel.Text = "Администрация Волчихинского района \r\nАлтайского края";
            this.AdministrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DocumentListBox
            // 
            this.DocumentListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DocumentListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DocumentListBox.FormattingEnabled = true;
            this.DocumentListBox.ItemHeight = 31;
            this.DocumentListBox.Location = new System.Drawing.Point(723, 135);
            this.DocumentListBox.Name = "DocumentListBox";
            this.DocumentListBox.Size = new System.Drawing.Size(855, 500);
            this.DocumentListBox.TabIndex = 38;
            // 
            // DownloadDocWorkButton
            // 
            this.DownloadDocWorkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.DownloadDocWorkButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.DownloadDocWorkButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DownloadDocWorkButton.BorderRadius = 0;
            this.DownloadDocWorkButton.BorderSize = 0;
            this.DownloadDocWorkButton.FlatAppearance.BorderSize = 0;
            this.DownloadDocWorkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadDocWorkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.DownloadDocWorkButton.ForeColor = System.Drawing.Color.White;
            this.DownloadDocWorkButton.Location = new System.Drawing.Point(1213, 669);
            this.DownloadDocWorkButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DownloadDocWorkButton.Name = "DownloadDocWorkButton";
            this.DownloadDocWorkButton.Size = new System.Drawing.Size(307, 88);
            this.DownloadDocWorkButton.TabIndex = 39;
            this.DownloadDocWorkButton.Text = "Скачать файлы";
            this.DownloadDocWorkButton.TextColor = System.Drawing.Color.White;
            this.DownloadDocWorkButton.UseVisualStyleBackColor = false;
            this.DownloadDocWorkButton.Click += new System.EventHandler(this.DownloadDocWorkButton_Click);
            // 
            // UserApplicationInfoForWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1619, 1817);
            this.Controls.Add(this.DownloadDocWorkButton);
            this.Controls.Add(this.DocumentListBox);
            this.Controls.Add(this.AdministrationLabel);
            this.Controls.Add(this.OpenDocumentWorkLabel);
            this.Controls.Add(this.OpenDocumentWorkButton);
            this.Controls.Add(this.CloseApplicWorkButton);
            this.Controls.Add(this.DateTimeDescrWorkLabel);
            this.Controls.Add(this.DescripApplWorkLabel);
            this.Controls.Add(this.TypeApplWorkLabel);
            this.Controls.Add(this.ApplWorkDTP);
            this.Controls.Add(this.DescripWorkTextBox);
            this.Controls.Add(this.TypeApplWorkTextBox);
            this.Controls.Add(this.ApplPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserApplicationInfoForWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Заявление пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserApplicationInfoForWorkerForm_FormClosed);
            this.Load += new System.EventHandler(this.UserApplicationInfoForWorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApplPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label OpenDocumentWorkLabel;
        private Design.CustomButton OpenDocumentWorkButton;
        private System.Windows.Forms.Label DateTimeDescrWorkLabel;
        private System.Windows.Forms.Label DescripApplWorkLabel;
        private System.Windows.Forms.DateTimePicker ApplWorkDTP;
        private Design.CustomTextBox DescripWorkTextBox;
        private System.Windows.Forms.PictureBox ApplPictureBox;
        private Components.FormStyleCustom CustomFormForAllProject;
        private Design.CustomButton CloseApplicWorkButton;
        private System.Windows.Forms.Label TypeApplWorkLabel;
        private Design.CustomTextBox TypeApplWorkTextBox;
        private System.Windows.Forms.Label AdministrationLabel;
        private System.Windows.Forms.ListBox DocumentListBox;
        private Design.CustomButton DownloadDocWorkButton;
    }
}