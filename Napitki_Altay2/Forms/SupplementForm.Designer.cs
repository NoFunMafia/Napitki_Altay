namespace Napitki_Altay2.Forms
{
    partial class SupplementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplementForm));
            this.SelectDocumentLabel = new System.Windows.Forms.Label();
            this.ChooseDocumentButton = new Napitki_Altay2.Design.CustomButton();
            this.DocumentTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CancelSupButton = new Napitki_Altay2.Design.CustomButton();
            this.PlusSupButton = new Napitki_Altay2.Design.CustomButton();
            this.DateTimeDescrLabel = new System.Windows.Forms.Label();
            this.DescripApplLabel = new System.Windows.Forms.Label();
            this.TypeApplLabel = new System.Windows.Forms.Label();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.ApplDTP = new System.Windows.Forms.DateTimePicker();
            this.DescripTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.TypeApplTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CompanyTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.SupPictureBox = new System.Windows.Forms.PictureBox();
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.DeleteDocumentButton = new Napitki_Altay2.Design.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.SupPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectDocumentLabel
            // 
            this.SelectDocumentLabel.AutoSize = true;
            this.SelectDocumentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.SelectDocumentLabel.Location = new System.Drawing.Point(435, 176);
            this.SelectDocumentLabel.Name = "SelectDocumentLabel";
            this.SelectDocumentLabel.Size = new System.Drawing.Size(433, 25);
            this.SelectDocumentLabel.TabIndex = 36;
            this.SelectDocumentLabel.Text = "Прикрепить файл к дополнению (опционально):";
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
            this.ChooseDocumentButton.Location = new System.Drawing.Point(440, 254);
            this.ChooseDocumentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChooseDocumentButton.Name = "ChooseDocumentButton";
            this.ChooseDocumentButton.Size = new System.Drawing.Size(179, 56);
            this.ChooseDocumentButton.TabIndex = 35;
            this.ChooseDocumentButton.Text = "Прикрепить файл";
            this.ChooseDocumentButton.TextColor = System.Drawing.Color.White;
            this.ChooseDocumentButton.UseVisualStyleBackColor = false;
            this.ChooseDocumentButton.Click += new System.EventHandler(this.ChooseDocumentButton_Click);
            // 
            // DocumentTextBox
            // 
            this.DocumentTextBox.BackColor = System.Drawing.Color.White;
            this.DocumentTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.DocumentTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DocumentTextBox.BorderSize = 2;
            this.DocumentTextBox.Enabled = false;
            this.DocumentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DocumentTextBox.ForeColor = System.Drawing.Color.Black;
            this.DocumentTextBox.Location = new System.Drawing.Point(440, 206);
            this.DocumentTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DocumentTextBox.Multiline = false;
            this.DocumentTextBox.Name = "DocumentTextBox";
            this.DocumentTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.DocumentTextBox.PasswordChar = false;
            this.DocumentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DocumentTextBox.SelectionStart = 0;
            this.DocumentTextBox.Size = new System.Drawing.Size(383, 35);
            this.DocumentTextBox.TabIndex = 34;
            this.DocumentTextBox.Texts = "";
            this.DocumentTextBox.UnderlinedStyle = false;
            // 
            // CancelSupButton
            // 
            this.CancelSupButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CancelSupButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.CancelSupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CancelSupButton.BorderRadius = 0;
            this.CancelSupButton.BorderSize = 0;
            this.CancelSupButton.FlatAppearance.BorderSize = 0;
            this.CancelSupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelSupButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelSupButton.ForeColor = System.Drawing.Color.White;
            this.CancelSupButton.Location = new System.Drawing.Point(467, 692);
            this.CancelSupButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelSupButton.Name = "CancelSupButton";
            this.CancelSupButton.Size = new System.Drawing.Size(399, 82);
            this.CancelSupButton.TabIndex = 32;
            this.CancelSupButton.Text = "Прекратить дополнение";
            this.CancelSupButton.TextColor = System.Drawing.Color.White;
            this.CancelSupButton.UseVisualStyleBackColor = false;
            this.CancelSupButton.Click += new System.EventHandler(this.CancelSupButton_Click);
            // 
            // PlusSupButton
            // 
            this.PlusSupButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.PlusSupButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.PlusSupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.PlusSupButton.BorderRadius = 0;
            this.PlusSupButton.BorderSize = 0;
            this.PlusSupButton.FlatAppearance.BorderSize = 0;
            this.PlusSupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusSupButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusSupButton.ForeColor = System.Drawing.Color.White;
            this.PlusSupButton.Location = new System.Drawing.Point(25, 692);
            this.PlusSupButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlusSupButton.Name = "PlusSupButton";
            this.PlusSupButton.Size = new System.Drawing.Size(399, 82);
            this.PlusSupButton.TabIndex = 31;
            this.PlusSupButton.Text = "Дополнить обращение";
            this.PlusSupButton.TextColor = System.Drawing.Color.White;
            this.PlusSupButton.UseVisualStyleBackColor = false;
            this.PlusSupButton.Click += new System.EventHandler(this.PlusSupButton_Click);
            // 
            // DateTimeDescrLabel
            // 
            this.DateTimeDescrLabel.AutoSize = true;
            this.DateTimeDescrLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DateTimeDescrLabel.Location = new System.Drawing.Point(20, 606);
            this.DateTimeDescrLabel.Name = "DateTimeDescrLabel";
            this.DateTimeDescrLabel.Size = new System.Drawing.Size(385, 28);
            this.DateTimeDescrLabel.TabIndex = 30;
            this.DateTimeDescrLabel.Text = "Время подачи начального обращения:";
            // 
            // DescripApplLabel
            // 
            this.DescripApplLabel.AutoSize = true;
            this.DescripApplLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DescripApplLabel.Location = new System.Drawing.Point(20, 319);
            this.DescripApplLabel.Name = "DescripApplLabel";
            this.DescripApplLabel.Size = new System.Drawing.Size(182, 28);
            this.DescripApplLabel.TabIndex = 29;
            this.DescripApplLabel.Text = "Ваше обращение:";
            // 
            // TypeApplLabel
            // 
            this.TypeApplLabel.AutoSize = true;
            this.TypeApplLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.TypeApplLabel.Location = new System.Drawing.Point(20, 246);
            this.TypeApplLabel.Name = "TypeApplLabel";
            this.TypeApplLabel.Size = new System.Drawing.Size(165, 28);
            this.TypeApplLabel.TabIndex = 28;
            this.TypeApplLabel.Text = "Тип обращения:";
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.CompanyNameLabel.Location = new System.Drawing.Point(20, 170);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(262, 28);
            this.CompanyNameLabel.TabIndex = 27;
            this.CompanyNameLabel.Text = "Наименование компании:";
            // 
            // ApplDTP
            // 
            this.ApplDTP.Enabled = false;
            this.ApplDTP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplDTP.Location = new System.Drawing.Point(25, 634);
            this.ApplDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplDTP.Name = "ApplDTP";
            this.ApplDTP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ApplDTP.Size = new System.Drawing.Size(285, 38);
            this.ApplDTP.TabIndex = 26;
            // 
            // DescripTextBox
            // 
            this.DescripTextBox.AutoScroll = true;
            this.DescripTextBox.AutoScrollMinSize = new System.Drawing.Size(0, 2);
            this.DescripTextBox.BackColor = System.Drawing.Color.White;
            this.DescripTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.DescripTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DescripTextBox.BorderSize = 2;
            this.DescripTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DescripTextBox.ForeColor = System.Drawing.Color.Black;
            this.DescripTextBox.Location = new System.Drawing.Point(27, 348);
            this.DescripTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DescripTextBox.Multiline = true;
            this.DescripTextBox.Name = "DescripTextBox";
            this.DescripTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.DescripTextBox.PasswordChar = false;
            this.DescripTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescripTextBox.SelectionStart = 0;
            this.DescripTextBox.Size = new System.Drawing.Size(839, 254);
            this.DescripTextBox.TabIndex = 25;
            this.DescripTextBox.Texts = "";
            this.DescripTextBox.UnderlinedStyle = false;
            // 
            // TypeApplTextBox
            // 
            this.TypeApplTextBox.BackColor = System.Drawing.Color.White;
            this.TypeApplTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.TypeApplTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.TypeApplTextBox.BorderSize = 2;
            this.TypeApplTextBox.Enabled = false;
            this.TypeApplTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TypeApplTextBox.ForeColor = System.Drawing.Color.Black;
            this.TypeApplTextBox.Location = new System.Drawing.Point(25, 278);
            this.TypeApplTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TypeApplTextBox.Multiline = false;
            this.TypeApplTextBox.Name = "TypeApplTextBox";
            this.TypeApplTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.TypeApplTextBox.PasswordChar = false;
            this.TypeApplTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TypeApplTextBox.SelectionStart = 0;
            this.TypeApplTextBox.Size = new System.Drawing.Size(383, 35);
            this.TypeApplTextBox.TabIndex = 24;
            this.TypeApplTextBox.Texts = "";
            this.TypeApplTextBox.UnderlinedStyle = false;
            // 
            // CompanyTextBox
            // 
            this.CompanyTextBox.BackColor = System.Drawing.Color.White;
            this.CompanyTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.CompanyTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CompanyTextBox.BorderSize = 2;
            this.CompanyTextBox.Enabled = false;
            this.CompanyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.CompanyTextBox.ForeColor = System.Drawing.Color.Black;
            this.CompanyTextBox.Location = new System.Drawing.Point(25, 206);
            this.CompanyTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyTextBox.Multiline = false;
            this.CompanyTextBox.Name = "CompanyTextBox";
            this.CompanyTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.CompanyTextBox.PasswordChar = false;
            this.CompanyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CompanyTextBox.SelectionStart = 0;
            this.CompanyTextBox.Size = new System.Drawing.Size(383, 35);
            this.CompanyTextBox.TabIndex = 23;
            this.CompanyTextBox.Texts = "";
            this.CompanyTextBox.UnderlinedStyle = false;
            // 
            // SupPictureBox
            // 
            this.SupPictureBox.BackColor = System.Drawing.Color.White;
            this.SupPictureBox.Image = global::Napitki_Altay2.Properties.Resources.PictureLoginForm;
            this.SupPictureBox.Location = new System.Drawing.Point(327, 4);
            this.SupPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SupPictureBox.Name = "SupPictureBox";
            this.SupPictureBox.Size = new System.Drawing.Size(239, 210);
            this.SupPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SupPictureBox.TabIndex = 22;
            this.SupPictureBox.TabStop = false;
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
            this.DeleteDocumentButton.Location = new System.Drawing.Point(644, 254);
            this.DeleteDocumentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteDocumentButton.Name = "DeleteDocumentButton";
            this.DeleteDocumentButton.Size = new System.Drawing.Size(179, 56);
            this.DeleteDocumentButton.TabIndex = 37;
            this.DeleteDocumentButton.Text = "Удалить файл";
            this.DeleteDocumentButton.TextColor = System.Drawing.Color.White;
            this.DeleteDocumentButton.UseVisualStyleBackColor = false;
            this.DeleteDocumentButton.Click += new System.EventHandler(this.DeleteDocumentButton_Click);
            // 
            // SupplementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 790);
            this.Controls.Add(this.DeleteDocumentButton);
            this.Controls.Add(this.SelectDocumentLabel);
            this.Controls.Add(this.ChooseDocumentButton);
            this.Controls.Add(this.DocumentTextBox);
            this.Controls.Add(this.CancelSupButton);
            this.Controls.Add(this.PlusSupButton);
            this.Controls.Add(this.DateTimeDescrLabel);
            this.Controls.Add(this.DescripApplLabel);
            this.Controls.Add(this.TypeApplLabel);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.ApplDTP);
            this.Controls.Add(this.DescripTextBox);
            this.Controls.Add(this.TypeApplTextBox);
            this.Controls.Add(this.CompanyTextBox);
            this.Controls.Add(this.SupPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление доп. информации к обращению";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SupplementForm_FormClosed);
            this.Load += new System.EventHandler(this.SupplementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SupPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SelectDocumentLabel;
        private Design.CustomButton ChooseDocumentButton;
        private Design.CustomTextBox DocumentTextBox;
        private Design.CustomButton CancelSupButton;
        private Design.CustomButton PlusSupButton;
        private System.Windows.Forms.Label DateTimeDescrLabel;
        private System.Windows.Forms.Label DescripApplLabel;
        private System.Windows.Forms.Label TypeApplLabel;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.DateTimePicker ApplDTP;
        private Design.CustomTextBox DescripTextBox;
        private Design.CustomTextBox TypeApplTextBox;
        private Design.CustomTextBox CompanyTextBox;
        private System.Windows.Forms.PictureBox SupPictureBox;
        private Components.FormStyleCustom CustomFormForAllProject;
        private Design.CustomButton DeleteDocumentButton;
    }
}