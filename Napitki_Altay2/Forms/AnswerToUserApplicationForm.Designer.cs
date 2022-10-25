namespace Napitki_Altay2.Forms
{
    partial class AnswerToUserApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnswerToUserApplicationForm));
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.DocumentWorkTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CloseApplicWorkButton = new Napitki_Altay2.Design.CustomButton();
            this.DateTimeDescrWorkLabel = new System.Windows.Forms.Label();
            this.DescripApplWorkLabel = new System.Windows.Forms.Label();
            this.CompanyNameWorkLabel = new System.Windows.Forms.Label();
            this.ApplWorkDTP = new System.Windows.Forms.DateTimePicker();
            this.DescripWorkTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CompanyWorkTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.ApplPictureBox = new System.Windows.Forms.PictureBox();
            this.RegApplButton = new Napitki_Altay2.Design.CustomButton();
            this.DeleteDocumentButton = new Napitki_Altay2.Design.CustomButton();
            this.ChooseDocumentButton = new Napitki_Altay2.Design.CustomButton();
            this.SelectDocumentLabel = new System.Windows.Forms.Label();
            this.ChooseTypeApplPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ApplPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseTypeApplPictureBox)).BeginInit();
            this.SuspendLayout();
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
            // DocumentWorkTextBox
            // 
            this.DocumentWorkTextBox.BackColor = System.Drawing.Color.White;
            this.DocumentWorkTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.DocumentWorkTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DocumentWorkTextBox.BorderSize = 2;
            this.DocumentWorkTextBox.Enabled = false;
            this.DocumentWorkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DocumentWorkTextBox.ForeColor = System.Drawing.Color.Black;
            this.DocumentWorkTextBox.Location = new System.Drawing.Point(450, 230);
            this.DocumentWorkTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DocumentWorkTextBox.Multiline = false;
            this.DocumentWorkTextBox.Name = "DocumentWorkTextBox";
            this.DocumentWorkTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.DocumentWorkTextBox.PasswordChar = false;
            this.DocumentWorkTextBox.Size = new System.Drawing.Size(383, 35);
            this.DocumentWorkTextBox.TabIndex = 47;
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
            this.CloseApplicWorkButton.Location = new System.Drawing.Point(467, 692);
            this.CloseApplicWorkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseApplicWorkButton.Name = "CloseApplicWorkButton";
            this.CloseApplicWorkButton.Size = new System.Drawing.Size(399, 82);
            this.CloseApplicWorkButton.TabIndex = 46;
            this.CloseApplicWorkButton.Text = "Закрыть окно ";
            this.CloseApplicWorkButton.TextColor = System.Drawing.Color.White;
            this.CloseApplicWorkButton.UseVisualStyleBackColor = false;
            this.CloseApplicWorkButton.Click += new System.EventHandler(this.CloseApplicWorkButton_Click);
            // 
            // DateTimeDescrWorkLabel
            // 
            this.DateTimeDescrWorkLabel.AutoSize = true;
            this.DateTimeDescrWorkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DateTimeDescrWorkLabel.Location = new System.Drawing.Point(20, 606);
            this.DateTimeDescrWorkLabel.Name = "DateTimeDescrWorkLabel";
            this.DateTimeDescrWorkLabel.Size = new System.Drawing.Size(289, 28);
            this.DateTimeDescrWorkLabel.TabIndex = 45;
            this.DateTimeDescrWorkLabel.Text = "Время ответа на обращение:";
            // 
            // DescripApplWorkLabel
            // 
            this.DescripApplWorkLabel.AutoSize = true;
            this.DescripApplWorkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DescripApplWorkLabel.Location = new System.Drawing.Point(20, 319);
            this.DescripApplWorkLabel.Name = "DescripApplWorkLabel";
            this.DescripApplWorkLabel.Size = new System.Drawing.Size(215, 28);
            this.DescripApplWorkLabel.TabIndex = 44;
            this.DescripApplWorkLabel.Text = "Ответ на обращение:";
            // 
            // CompanyNameWorkLabel
            // 
            this.CompanyNameWorkLabel.AutoSize = true;
            this.CompanyNameWorkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.CompanyNameWorkLabel.Location = new System.Drawing.Point(20, 194);
            this.CompanyNameWorkLabel.Name = "CompanyNameWorkLabel";
            this.CompanyNameWorkLabel.Size = new System.Drawing.Size(191, 28);
            this.CompanyNameWorkLabel.TabIndex = 42;
            this.CompanyNameWorkLabel.Text = "Статус обращения:";
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
            this.ApplWorkDTP.TabIndex = 41;
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
            this.DescripWorkTextBox.TabIndex = 40;
            this.DescripWorkTextBox.Texts = "";
            this.DescripWorkTextBox.UnderlinedStyle = false;
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
            this.CompanyWorkTextBox.Location = new System.Drawing.Point(25, 230);
            this.CompanyWorkTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyWorkTextBox.Multiline = false;
            this.CompanyWorkTextBox.Name = "CompanyWorkTextBox";
            this.CompanyWorkTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.CompanyWorkTextBox.PasswordChar = false;
            this.CompanyWorkTextBox.Size = new System.Drawing.Size(383, 35);
            this.CompanyWorkTextBox.TabIndex = 38;
            this.CompanyWorkTextBox.Texts = "";
            this.CompanyWorkTextBox.UnderlinedStyle = false;
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
            this.ApplPictureBox.TabIndex = 37;
            this.ApplPictureBox.TabStop = false;
            // 
            // RegApplButton
            // 
            this.RegApplButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.RegApplButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.RegApplButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.RegApplButton.BorderRadius = 0;
            this.RegApplButton.BorderSize = 0;
            this.RegApplButton.FlatAppearance.BorderSize = 0;
            this.RegApplButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegApplButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegApplButton.ForeColor = System.Drawing.Color.White;
            this.RegApplButton.Location = new System.Drawing.Point(25, 692);
            this.RegApplButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegApplButton.Name = "RegApplButton";
            this.RegApplButton.Size = new System.Drawing.Size(399, 82);
            this.RegApplButton.TabIndex = 50;
            this.RegApplButton.Text = "Ответить на обращение";
            this.RegApplButton.TextColor = System.Drawing.Color.White;
            this.RegApplButton.UseVisualStyleBackColor = false;
            // 
            // DeleteDocumentButton
            // 
            this.DeleteDocumentButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteDocumentButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.DeleteDocumentButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DeleteDocumentButton.BorderRadius = 0;
            this.DeleteDocumentButton.BorderSize = 0;
            this.DeleteDocumentButton.FlatAppearance.BorderSize = 0;
            this.DeleteDocumentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteDocumentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDocumentButton.ForeColor = System.Drawing.Color.White;
            this.DeleteDocumentButton.Location = new System.Drawing.Point(654, 278);
            this.DeleteDocumentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteDocumentButton.Name = "DeleteDocumentButton";
            this.DeleteDocumentButton.Size = new System.Drawing.Size(179, 56);
            this.DeleteDocumentButton.TabIndex = 52;
            this.DeleteDocumentButton.Text = "Удалить файл";
            this.DeleteDocumentButton.TextColor = System.Drawing.Color.White;
            this.DeleteDocumentButton.UseVisualStyleBackColor = false;
            // 
            // ChooseDocumentButton
            // 
            this.ChooseDocumentButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ChooseDocumentButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.ChooseDocumentButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.ChooseDocumentButton.BorderRadius = 0;
            this.ChooseDocumentButton.BorderSize = 0;
            this.ChooseDocumentButton.FlatAppearance.BorderSize = 0;
            this.ChooseDocumentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseDocumentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseDocumentButton.ForeColor = System.Drawing.Color.White;
            this.ChooseDocumentButton.Location = new System.Drawing.Point(450, 278);
            this.ChooseDocumentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChooseDocumentButton.Name = "ChooseDocumentButton";
            this.ChooseDocumentButton.Size = new System.Drawing.Size(179, 56);
            this.ChooseDocumentButton.TabIndex = 51;
            this.ChooseDocumentButton.Text = "Выбрать файл";
            this.ChooseDocumentButton.TextColor = System.Drawing.Color.White;
            this.ChooseDocumentButton.UseVisualStyleBackColor = false;
            // 
            // SelectDocumentLabel
            // 
            this.SelectDocumentLabel.AutoSize = true;
            this.SelectDocumentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.SelectDocumentLabel.Location = new System.Drawing.Point(445, 175);
            this.SelectDocumentLabel.Name = "SelectDocumentLabel";
            this.SelectDocumentLabel.Size = new System.Drawing.Size(349, 50);
            this.SelectDocumentLabel.TabIndex = 53;
            this.SelectDocumentLabel.Text = "Прикрепить файл \r\nк ответу на обращение (опционально):";
            // 
            // ChooseTypeApplPictureBox
            // 
            this.ChooseTypeApplPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseTypeApplPictureBox.Image = global::Napitki_Altay2.Properties.Resources.PictureRegForm;
            this.ChooseTypeApplPictureBox.Location = new System.Drawing.Point(371, 234);
            this.ChooseTypeApplPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChooseTypeApplPictureBox.Name = "ChooseTypeApplPictureBox";
            this.ChooseTypeApplPictureBox.Size = new System.Drawing.Size(32, 27);
            this.ChooseTypeApplPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChooseTypeApplPictureBox.TabIndex = 54;
            this.ChooseTypeApplPictureBox.TabStop = false;
            // 
            // AnswerToUserApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 790);
            this.Controls.Add(this.ChooseTypeApplPictureBox);
            this.Controls.Add(this.SelectDocumentLabel);
            this.Controls.Add(this.DeleteDocumentButton);
            this.Controls.Add(this.ChooseDocumentButton);
            this.Controls.Add(this.RegApplButton);
            this.Controls.Add(this.DocumentWorkTextBox);
            this.Controls.Add(this.CloseApplicWorkButton);
            this.Controls.Add(this.DateTimeDescrWorkLabel);
            this.Controls.Add(this.DescripApplWorkLabel);
            this.Controls.Add(this.CompanyNameWorkLabel);
            this.Controls.Add(this.ApplWorkDTP);
            this.Controls.Add(this.DescripWorkTextBox);
            this.Controls.Add(this.CompanyWorkTextBox);
            this.Controls.Add(this.ApplPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnswerToUserApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ответ на обращение пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.ApplPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseTypeApplPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormStyleCustom CustomFormForAllProject;
        private Design.CustomTextBox DocumentWorkTextBox;
        private Design.CustomButton CloseApplicWorkButton;
        private System.Windows.Forms.Label DateTimeDescrWorkLabel;
        private System.Windows.Forms.Label DescripApplWorkLabel;
        private System.Windows.Forms.Label CompanyNameWorkLabel;
        private System.Windows.Forms.DateTimePicker ApplWorkDTP;
        private Design.CustomTextBox DescripWorkTextBox;
        private Design.CustomTextBox CompanyWorkTextBox;
        private System.Windows.Forms.PictureBox ApplPictureBox;
        private Design.CustomButton RegApplButton;
        private Design.CustomButton DeleteDocumentButton;
        private Design.CustomButton ChooseDocumentButton;
        private System.Windows.Forms.Label SelectDocumentLabel;
        private System.Windows.Forms.PictureBox ChooseTypeApplPictureBox;
    }
}