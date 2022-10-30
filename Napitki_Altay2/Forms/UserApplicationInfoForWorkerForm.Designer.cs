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
            this.DocumentWorkTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CloseApplicWorkButton = new Napitki_Altay2.Design.CustomButton();
            this.DescripWorkTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.ApplPictureBox = new System.Windows.Forms.PictureBox();
            this.CompanyWorkTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CompanyNameWorkLabel = new System.Windows.Forms.Label();
            this.TypeApplWorkTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.TypeApplWorkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ApplPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenDocumentWorkLabel
            // 
            this.OpenDocumentWorkLabel.AutoSize = true;
            this.OpenDocumentWorkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.OpenDocumentWorkLabel.Location = new System.Drawing.Point(452, 176);
            this.OpenDocumentWorkLabel.Name = "OpenDocumentWorkLabel";
            this.OpenDocumentWorkLabel.Size = new System.Drawing.Size(214, 25);
            this.OpenDocumentWorkLabel.TabIndex = 36;
            this.OpenDocumentWorkLabel.Text = "Прикрепленный файл:";
            // 
            // DateTimeDescrWorkLabel
            // 
            this.DateTimeDescrWorkLabel.AutoSize = true;
            this.DateTimeDescrWorkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DateTimeDescrWorkLabel.Location = new System.Drawing.Point(20, 606);
            this.DateTimeDescrWorkLabel.Name = "DateTimeDescrWorkLabel";
            this.DateTimeDescrWorkLabel.Size = new System.Drawing.Size(269, 28);
            this.DateTimeDescrWorkLabel.TabIndex = 30;
            this.DateTimeDescrWorkLabel.Text = "Время подачи обращения:";
            // 
            // DescripApplWorkLabel
            // 
            this.DescripApplWorkLabel.AutoSize = true;
            this.DescripApplWorkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DescripApplWorkLabel.Location = new System.Drawing.Point(20, 319);
            this.DescripApplWorkLabel.Name = "DescripApplWorkLabel";
            this.DescripApplWorkLabel.Size = new System.Drawing.Size(225, 28);
            this.DescripApplWorkLabel.TabIndex = 29;
            this.DescripApplWorkLabel.Text = "Описание обращения:";
            // 
            // ApplWorkDTP
            // 
            this.ApplWorkDTP.Enabled = false;
            this.ApplWorkDTP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplWorkDTP.Location = new System.Drawing.Point(25, 634);
            this.ApplWorkDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplWorkDTP.Name = "ApplWorkDTP";
            this.ApplWorkDTP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ApplWorkDTP.Size = new System.Drawing.Size(285, 38);
            this.ApplWorkDTP.TabIndex = 26;
            // 
            // OpenDocumentWorkButton
            // 
            this.OpenDocumentWorkButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OpenDocumentWorkButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.OpenDocumentWorkButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.OpenDocumentWorkButton.BorderRadius = 0;
            this.OpenDocumentWorkButton.BorderSize = 0;
            this.OpenDocumentWorkButton.FlatAppearance.BorderSize = 0;
            this.OpenDocumentWorkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDocumentWorkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenDocumentWorkButton.ForeColor = System.Drawing.Color.White;
            this.OpenDocumentWorkButton.Location = new System.Drawing.Point(531, 257);
            this.OpenDocumentWorkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenDocumentWorkButton.Name = "OpenDocumentWorkButton";
            this.OpenDocumentWorkButton.Size = new System.Drawing.Size(237, 67);
            this.OpenDocumentWorkButton.TabIndex = 35;
            this.OpenDocumentWorkButton.Text = "Открыть файл";
            this.OpenDocumentWorkButton.TextColor = System.Drawing.Color.White;
            this.OpenDocumentWorkButton.UseVisualStyleBackColor = false;
            this.OpenDocumentWorkButton.Click += new System.EventHandler(this.OpenDocumentWorkButton_Click);
            // 
            // DocumentWorkTextBox
            // 
            this.DocumentWorkTextBox.BackColor = System.Drawing.Color.White;
            this.DocumentWorkTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.DocumentWorkTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DocumentWorkTextBox.BorderSize = 2;
            this.DocumentWorkTextBox.Enabled = false;
            this.DocumentWorkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DocumentWorkTextBox.ForeColor = System.Drawing.Color.Black;
            this.DocumentWorkTextBox.Location = new System.Drawing.Point(457, 206);
            this.DocumentWorkTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DocumentWorkTextBox.Multiline = false;
            this.DocumentWorkTextBox.Name = "DocumentWorkTextBox";
            this.DocumentWorkTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.DocumentWorkTextBox.PasswordChar = false;
            this.DocumentWorkTextBox.Size = new System.Drawing.Size(383, 35);
            this.DocumentWorkTextBox.TabIndex = 34;
            this.DocumentWorkTextBox.Texts = "";
            this.DocumentWorkTextBox.UnderlinedStyle = false;
            // 
            // CloseApplicWorkButton
            // 
            this.CloseApplicWorkButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CloseApplicWorkButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.CloseApplicWorkButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CloseApplicWorkButton.BorderRadius = 0;
            this.CloseApplicWorkButton.BorderSize = 0;
            this.CloseApplicWorkButton.FlatAppearance.BorderSize = 0;
            this.CloseApplicWorkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApplicWorkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseApplicWorkButton.ForeColor = System.Drawing.Color.White;
            this.CloseApplicWorkButton.Location = new System.Drawing.Point(419, 625);
            this.CloseApplicWorkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseApplicWorkButton.Name = "CloseApplicWorkButton";
            this.CloseApplicWorkButton.Size = new System.Drawing.Size(399, 82);
            this.CloseApplicWorkButton.TabIndex = 32;
            this.CloseApplicWorkButton.Text = "Закрыть обращение";
            this.CloseApplicWorkButton.TextColor = System.Drawing.Color.White;
            this.CloseApplicWorkButton.UseVisualStyleBackColor = false;
            this.CloseApplicWorkButton.Click += new System.EventHandler(this.CloseApplicWorkButton_Click);
            // 
            // DescripWorkTextBox
            // 
            this.DescripWorkTextBox.BackColor = System.Drawing.Color.White;
            this.DescripWorkTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.DescripWorkTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DescripWorkTextBox.BorderSize = 2;
            this.DescripWorkTextBox.Enabled = false;
            this.DescripWorkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DescripWorkTextBox.ForeColor = System.Drawing.Color.Black;
            this.DescripWorkTextBox.Location = new System.Drawing.Point(27, 348);
            this.DescripWorkTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DescripWorkTextBox.Multiline = true;
            this.DescripWorkTextBox.Name = "DescripWorkTextBox";
            this.DescripWorkTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.DescripWorkTextBox.PasswordChar = false;
            this.DescripWorkTextBox.Size = new System.Drawing.Size(839, 254);
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
            this.CustomFormForAllProject.HeaderColor = System.Drawing.Color.RoyalBlue;
            this.CustomFormForAllProject.HeaderColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(48)))), ((int)(((byte)(207)))));
            this.CustomFormForAllProject.HeaderColorGradientEnable = true;
            this.CustomFormForAllProject.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.CustomFormForAllProject.HeaderHeight = 29;
            this.CustomFormForAllProject.HeaderImage = null;
            this.CustomFormForAllProject.HeaderTextColor = System.Drawing.Color.White;
            this.CustomFormForAllProject.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // ApplPictureBox
            // 
            this.ApplPictureBox.BackColor = System.Drawing.Color.White;
            this.ApplPictureBox.Image = global::Napitki_Altay2.Properties.Resources.PictureLoginForm;
            this.ApplPictureBox.Location = new System.Drawing.Point(327, 4);
            this.ApplPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplPictureBox.Name = "ApplPictureBox";
            this.ApplPictureBox.Size = new System.Drawing.Size(239, 210);
            this.ApplPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ApplPictureBox.TabIndex = 22;
            this.ApplPictureBox.TabStop = false;
            // 
            // CompanyWorkTextBox
            // 
            this.CompanyWorkTextBox.BackColor = System.Drawing.Color.White;
            this.CompanyWorkTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.CompanyWorkTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CompanyWorkTextBox.BorderSize = 2;
            this.CompanyWorkTextBox.Enabled = false;
            this.CompanyWorkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.CompanyWorkTextBox.ForeColor = System.Drawing.Color.Black;
            this.CompanyWorkTextBox.Location = new System.Drawing.Point(25, 206);
            this.CompanyWorkTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyWorkTextBox.Multiline = false;
            this.CompanyWorkTextBox.Name = "CompanyWorkTextBox";
            this.CompanyWorkTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.CompanyWorkTextBox.PasswordChar = false;
            this.CompanyWorkTextBox.Size = new System.Drawing.Size(383, 35);
            this.CompanyWorkTextBox.TabIndex = 23;
            this.CompanyWorkTextBox.Texts = "";
            this.CompanyWorkTextBox.UnderlinedStyle = false;
            // 
            // CompanyNameWorkLabel
            // 
            this.CompanyNameWorkLabel.AutoSize = true;
            this.CompanyNameWorkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.CompanyNameWorkLabel.Location = new System.Drawing.Point(20, 170);
            this.CompanyNameWorkLabel.Name = "CompanyNameWorkLabel";
            this.CompanyNameWorkLabel.Size = new System.Drawing.Size(262, 28);
            this.CompanyNameWorkLabel.TabIndex = 27;
            this.CompanyNameWorkLabel.Text = "Наименование компании:";
            // 
            // TypeApplWorkTextBox
            // 
            this.TypeApplWorkTextBox.BackColor = System.Drawing.Color.White;
            this.TypeApplWorkTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.TypeApplWorkTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.TypeApplWorkTextBox.BorderSize = 2;
            this.TypeApplWorkTextBox.Enabled = false;
            this.TypeApplWorkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TypeApplWorkTextBox.ForeColor = System.Drawing.Color.Black;
            this.TypeApplWorkTextBox.Location = new System.Drawing.Point(25, 278);
            this.TypeApplWorkTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TypeApplWorkTextBox.Multiline = false;
            this.TypeApplWorkTextBox.Name = "TypeApplWorkTextBox";
            this.TypeApplWorkTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.TypeApplWorkTextBox.PasswordChar = false;
            this.TypeApplWorkTextBox.Size = new System.Drawing.Size(383, 35);
            this.TypeApplWorkTextBox.TabIndex = 24;
            this.TypeApplWorkTextBox.Texts = "";
            this.TypeApplWorkTextBox.UnderlinedStyle = false;
            // 
            // TypeApplWorkLabel
            // 
            this.TypeApplWorkLabel.AutoSize = true;
            this.TypeApplWorkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.TypeApplWorkLabel.Location = new System.Drawing.Point(20, 246);
            this.TypeApplWorkLabel.Name = "TypeApplWorkLabel";
            this.TypeApplWorkLabel.Size = new System.Drawing.Size(165, 28);
            this.TypeApplWorkLabel.TabIndex = 28;
            this.TypeApplWorkLabel.Text = "Тип обращения:";
            // 
            // UserApplicationInfoForWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 730);
            this.Controls.Add(this.OpenDocumentWorkLabel);
            this.Controls.Add(this.OpenDocumentWorkButton);
            this.Controls.Add(this.DocumentWorkTextBox);
            this.Controls.Add(this.CloseApplicWorkButton);
            this.Controls.Add(this.DateTimeDescrWorkLabel);
            this.Controls.Add(this.DescripApplWorkLabel);
            this.Controls.Add(this.TypeApplWorkLabel);
            this.Controls.Add(this.CompanyNameWorkLabel);
            this.Controls.Add(this.ApplWorkDTP);
            this.Controls.Add(this.DescripWorkTextBox);
            this.Controls.Add(this.TypeApplWorkTextBox);
            this.Controls.Add(this.CompanyWorkTextBox);
            this.Controls.Add(this.ApplPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserApplicationInfoForWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Обращение пользователя";
            this.Load += new System.EventHandler(this.UserApplicationInfoForWorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApplPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label OpenDocumentWorkLabel;
        private Design.CustomButton OpenDocumentWorkButton;
        private Design.CustomTextBox DocumentWorkTextBox;
        private System.Windows.Forms.Label DateTimeDescrWorkLabel;
        private System.Windows.Forms.Label DescripApplWorkLabel;
        private System.Windows.Forms.DateTimePicker ApplWorkDTP;
        private Design.CustomTextBox DescripWorkTextBox;
        private System.Windows.Forms.PictureBox ApplPictureBox;
        private Components.FormStyleCustom CustomFormForAllProject;
        private Design.CustomButton CloseApplicWorkButton;
        private System.Windows.Forms.Label CompanyNameWorkLabel;
        private Design.CustomTextBox CompanyWorkTextBox;
        private System.Windows.Forms.Label TypeApplWorkLabel;
        private Design.CustomTextBox TypeApplWorkTextBox;
    }
}