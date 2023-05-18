namespace Napitki_Altay2.Forms
{
    partial class ReadyApplicationInfoForUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadyApplicationInfoForUserForm));
            this.OpenPinDocumentLabel = new System.Windows.Forms.Label();
            this.DateTimeCompleteLabel = new System.Windows.Forms.Label();
            this.AnswerToApplicationLabel = new System.Windows.Forms.Label();
            this.CompleteStatusApplicationLabel = new System.Windows.Forms.Label();
            this.ApplCompleteDTP = new System.Windows.Forms.DateTimePicker();
            this.ApplPictureBox = new System.Windows.Forms.PictureBox();
            this.OpenPinDocumentButton = new Napitki_Altay2.Design.CustomButton();
            this.PinDocumentTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CloseCompleteApplicationButton = new Napitki_Altay2.Design.CustomButton();
            this.DescripCompleteTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.StatusCompleteTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.TypeAppealAnswerLabel = new System.Windows.Forms.Label();
            this.TypeAppealAnswerTextBox = new Napitki_Altay2.Design.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ApplPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenPinDocumentLabel
            // 
            this.OpenPinDocumentLabel.AutoSize = true;
            this.OpenPinDocumentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.OpenPinDocumentLabel.Location = new System.Drawing.Point(452, 176);
            this.OpenPinDocumentLabel.Name = "OpenPinDocumentLabel";
            this.OpenPinDocumentLabel.Size = new System.Drawing.Size(214, 25);
            this.OpenPinDocumentLabel.TabIndex = 49;
            this.OpenPinDocumentLabel.Text = "Прикрепленный файл:";
            // 
            // DateTimeCompleteLabel
            // 
            this.DateTimeCompleteLabel.AutoSize = true;
            this.DateTimeCompleteLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DateTimeCompleteLabel.Location = new System.Drawing.Point(20, 606);
            this.DateTimeCompleteLabel.Name = "DateTimeCompleteLabel";
            this.DateTimeCompleteLabel.Size = new System.Drawing.Size(289, 28);
            this.DateTimeCompleteLabel.TabIndex = 45;
            this.DateTimeCompleteLabel.Text = "Время ответа на обращение:";
            // 
            // AnswerToApplicationLabel
            // 
            this.AnswerToApplicationLabel.AutoSize = true;
            this.AnswerToApplicationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.AnswerToApplicationLabel.Location = new System.Drawing.Point(20, 319);
            this.AnswerToApplicationLabel.Name = "AnswerToApplicationLabel";
            this.AnswerToApplicationLabel.Size = new System.Drawing.Size(270, 28);
            this.AnswerToApplicationLabel.TabIndex = 44;
            this.AnswerToApplicationLabel.Text = "Ответ на ваше обращение:";
            // 
            // CompleteStatusApplicationLabel
            // 
            this.CompleteStatusApplicationLabel.AutoSize = true;
            this.CompleteStatusApplicationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.CompleteStatusApplicationLabel.Location = new System.Drawing.Point(20, 246);
            this.CompleteStatusApplicationLabel.Name = "CompleteStatusApplicationLabel";
            this.CompleteStatusApplicationLabel.Size = new System.Drawing.Size(266, 28);
            this.CompleteStatusApplicationLabel.TabIndex = 42;
            this.CompleteStatusApplicationLabel.Text = "Статус вашего обращения:";
            // 
            // ApplCompleteDTP
            // 
            this.ApplCompleteDTP.Enabled = false;
            this.ApplCompleteDTP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplCompleteDTP.Location = new System.Drawing.Point(25, 634);
            this.ApplCompleteDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplCompleteDTP.Name = "ApplCompleteDTP";
            this.ApplCompleteDTP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ApplCompleteDTP.Size = new System.Drawing.Size(285, 38);
            this.ApplCompleteDTP.TabIndex = 41;
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
            // OpenPinDocumentButton
            // 
            this.OpenPinDocumentButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OpenPinDocumentButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.OpenPinDocumentButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.OpenPinDocumentButton.BorderRadius = 0;
            this.OpenPinDocumentButton.BorderSize = 0;
            this.OpenPinDocumentButton.FlatAppearance.BorderSize = 0;
            this.OpenPinDocumentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPinDocumentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenPinDocumentButton.ForeColor = System.Drawing.Color.White;
            this.OpenPinDocumentButton.Location = new System.Drawing.Point(531, 257);
            this.OpenPinDocumentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenPinDocumentButton.Name = "OpenPinDocumentButton";
            this.OpenPinDocumentButton.Size = new System.Drawing.Size(237, 67);
            this.OpenPinDocumentButton.TabIndex = 48;
            this.OpenPinDocumentButton.Text = "Открыть файл";
            this.OpenPinDocumentButton.TextColor = System.Drawing.Color.White;
            this.OpenPinDocumentButton.UseVisualStyleBackColor = false;
            this.OpenPinDocumentButton.Click += new System.EventHandler(this.OpenPinDocumentButton_Click);
            // 
            // PinDocumentTextBox
            // 
            this.PinDocumentTextBox.BackColor = System.Drawing.Color.White;
            this.PinDocumentTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PinDocumentTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.PinDocumentTextBox.BorderSize = 2;
            this.PinDocumentTextBox.Enabled = false;
            this.PinDocumentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PinDocumentTextBox.ForeColor = System.Drawing.Color.Black;
            this.PinDocumentTextBox.Location = new System.Drawing.Point(457, 206);
            this.PinDocumentTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PinDocumentTextBox.Multiline = false;
            this.PinDocumentTextBox.Name = "PinDocumentTextBox";
            this.PinDocumentTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.PinDocumentTextBox.PasswordChar = false;
            this.PinDocumentTextBox.ReadOnly = false;
            this.PinDocumentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PinDocumentTextBox.SelectionStart = 0;
            this.PinDocumentTextBox.Size = new System.Drawing.Size(383, 35);
            this.PinDocumentTextBox.TabIndex = 47;
            this.PinDocumentTextBox.Texts = "";
            this.PinDocumentTextBox.UnderlinedStyle = false;
            // 
            // CloseCompleteApplicationButton
            // 
            this.CloseCompleteApplicationButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CloseCompleteApplicationButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.CloseCompleteApplicationButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CloseCompleteApplicationButton.BorderRadius = 0;
            this.CloseCompleteApplicationButton.BorderSize = 0;
            this.CloseCompleteApplicationButton.FlatAppearance.BorderSize = 0;
            this.CloseCompleteApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseCompleteApplicationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseCompleteApplicationButton.ForeColor = System.Drawing.Color.White;
            this.CloseCompleteApplicationButton.Location = new System.Drawing.Point(419, 625);
            this.CloseCompleteApplicationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseCompleteApplicationButton.Name = "CloseCompleteApplicationButton";
            this.CloseCompleteApplicationButton.Size = new System.Drawing.Size(399, 82);
            this.CloseCompleteApplicationButton.TabIndex = 46;
            this.CloseCompleteApplicationButton.Text = "Закрыть ответ";
            this.CloseCompleteApplicationButton.TextColor = System.Drawing.Color.White;
            this.CloseCompleteApplicationButton.UseVisualStyleBackColor = false;
            this.CloseCompleteApplicationButton.Click += new System.EventHandler(this.CloseCompleteApplicationButton_Click);
            // 
            // DescripCompleteTextBox
            // 
            this.DescripCompleteTextBox.BackColor = System.Drawing.Color.White;
            this.DescripCompleteTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.DescripCompleteTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DescripCompleteTextBox.BorderSize = 2;
            this.DescripCompleteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DescripCompleteTextBox.ForeColor = System.Drawing.Color.Black;
            this.DescripCompleteTextBox.Location = new System.Drawing.Point(27, 348);
            this.DescripCompleteTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DescripCompleteTextBox.Multiline = true;
            this.DescripCompleteTextBox.Name = "DescripCompleteTextBox";
            this.DescripCompleteTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.DescripCompleteTextBox.PasswordChar = false;
            this.DescripCompleteTextBox.ReadOnly = true;
            this.DescripCompleteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescripCompleteTextBox.SelectionStart = 0;
            this.DescripCompleteTextBox.Size = new System.Drawing.Size(839, 254);
            this.DescripCompleteTextBox.TabIndex = 40;
            this.DescripCompleteTextBox.Texts = "";
            this.DescripCompleteTextBox.UnderlinedStyle = false;
            // 
            // StatusCompleteTextBox
            // 
            this.StatusCompleteTextBox.BackColor = System.Drawing.Color.White;
            this.StatusCompleteTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.StatusCompleteTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.StatusCompleteTextBox.BorderSize = 2;
            this.StatusCompleteTextBox.Enabled = false;
            this.StatusCompleteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.StatusCompleteTextBox.ForeColor = System.Drawing.Color.Black;
            this.StatusCompleteTextBox.Location = new System.Drawing.Point(25, 278);
            this.StatusCompleteTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.StatusCompleteTextBox.Multiline = false;
            this.StatusCompleteTextBox.Name = "StatusCompleteTextBox";
            this.StatusCompleteTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.StatusCompleteTextBox.PasswordChar = false;
            this.StatusCompleteTextBox.ReadOnly = false;
            this.StatusCompleteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StatusCompleteTextBox.SelectionStart = 0;
            this.StatusCompleteTextBox.Size = new System.Drawing.Size(383, 35);
            this.StatusCompleteTextBox.TabIndex = 38;
            this.StatusCompleteTextBox.Texts = "";
            this.StatusCompleteTextBox.UnderlinedStyle = false;
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
            // TypeAppealAnswerLabel
            // 
            this.TypeAppealAnswerLabel.AutoSize = true;
            this.TypeAppealAnswerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.TypeAppealAnswerLabel.Location = new System.Drawing.Point(20, 170);
            this.TypeAppealAnswerLabel.Name = "TypeAppealAnswerLabel";
            this.TypeAppealAnswerLabel.Size = new System.Drawing.Size(240, 28);
            this.TypeAppealAnswerLabel.TabIndex = 51;
            this.TypeAppealAnswerLabel.Text = "Тип вашего обращения:";
            // 
            // TypeAppealAnswerTextBox
            // 
            this.TypeAppealAnswerTextBox.BackColor = System.Drawing.Color.White;
            this.TypeAppealAnswerTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.TypeAppealAnswerTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.TypeAppealAnswerTextBox.BorderSize = 2;
            this.TypeAppealAnswerTextBox.Enabled = false;
            this.TypeAppealAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TypeAppealAnswerTextBox.ForeColor = System.Drawing.Color.Black;
            this.TypeAppealAnswerTextBox.Location = new System.Drawing.Point(25, 206);
            this.TypeAppealAnswerTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TypeAppealAnswerTextBox.Multiline = false;
            this.TypeAppealAnswerTextBox.Name = "TypeAppealAnswerTextBox";
            this.TypeAppealAnswerTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.TypeAppealAnswerTextBox.PasswordChar = false;
            this.TypeAppealAnswerTextBox.ReadOnly = false;
            this.TypeAppealAnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TypeAppealAnswerTextBox.SelectionStart = 0;
            this.TypeAppealAnswerTextBox.Size = new System.Drawing.Size(383, 35);
            this.TypeAppealAnswerTextBox.TabIndex = 50;
            this.TypeAppealAnswerTextBox.Texts = "";
            this.TypeAppealAnswerTextBox.UnderlinedStyle = false;
            // 
            // ReadyApplicationInfoForUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 730);
            this.Controls.Add(this.TypeAppealAnswerLabel);
            this.Controls.Add(this.TypeAppealAnswerTextBox);
            this.Controls.Add(this.OpenPinDocumentLabel);
            this.Controls.Add(this.OpenPinDocumentButton);
            this.Controls.Add(this.PinDocumentTextBox);
            this.Controls.Add(this.CloseCompleteApplicationButton);
            this.Controls.Add(this.DateTimeCompleteLabel);
            this.Controls.Add(this.AnswerToApplicationLabel);
            this.Controls.Add(this.CompleteStatusApplicationLabel);
            this.Controls.Add(this.ApplCompleteDTP);
            this.Controls.Add(this.DescripCompleteTextBox);
            this.Controls.Add(this.StatusCompleteTextBox);
            this.Controls.Add(this.ApplPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReadyApplicationInfoForUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ответ сотрудника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReadyApplicationInfoForUserForm_FormClosed);
            this.Load += new System.EventHandler(this.ReadyApplicationInfoForUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApplPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormStyleCustom CustomFormForAllProject;
        private System.Windows.Forms.Label OpenPinDocumentLabel;
        private Design.CustomButton OpenPinDocumentButton;
        private Design.CustomTextBox PinDocumentTextBox;
        private Design.CustomButton CloseCompleteApplicationButton;
        private System.Windows.Forms.Label DateTimeCompleteLabel;
        private System.Windows.Forms.Label AnswerToApplicationLabel;
        private System.Windows.Forms.Label CompleteStatusApplicationLabel;
        private System.Windows.Forms.DateTimePicker ApplCompleteDTP;
        private Design.CustomTextBox DescripCompleteTextBox;
        private Design.CustomTextBox StatusCompleteTextBox;
        private System.Windows.Forms.PictureBox ApplPictureBox;
        private System.Windows.Forms.Label TypeAppealAnswerLabel;
        private Design.CustomTextBox TypeAppealAnswerTextBox;
    }
}