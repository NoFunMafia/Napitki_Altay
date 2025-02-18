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
            this.DateTimeDescrLabel = new System.Windows.Forms.Label();
            this.DescripApplLabel = new System.Windows.Forms.Label();
            this.TypeApplLabel = new System.Windows.Forms.Label();
            this.ApplDTP = new System.Windows.Forms.DateTimePicker();
            this.SupPictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteDocumentButton = new Napitki_Altay2.Design.CustomButton();
            this.ChooseDocumentButton = new Napitki_Altay2.Design.CustomButton();
            this.CancelSupButton = new Napitki_Altay2.Design.CustomButton();
            this.PlusSupButton = new Napitki_Altay2.Design.CustomButton();
            this.DescripTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.TypeApplTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.DocumentListBox = new System.Windows.Forms.ListBox();
            this.AdministrationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SupPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectDocumentLabel
            // 
            this.SelectDocumentLabel.AutoSize = true;
            this.SelectDocumentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SelectDocumentLabel.Location = new System.Drawing.Point(715, 67);
            this.SelectDocumentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectDocumentLabel.Name = "SelectDocumentLabel";
            this.SelectDocumentLabel.Size = new System.Drawing.Size(842, 45);
            this.SelectDocumentLabel.TabIndex = 36;
            this.SelectDocumentLabel.Text = "Прикрепление дополнительных файлов к заявлению:";
            // 
            // DateTimeDescrLabel
            // 
            this.DateTimeDescrLabel.AutoSize = true;
            this.DateTimeDescrLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DateTimeDescrLabel.Location = new System.Drawing.Point(30, 1487);
            this.DateTimeDescrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateTimeDescrLabel.Name = "DateTimeDescrLabel";
            this.DateTimeDescrLabel.Size = new System.Drawing.Size(484, 45);
            this.DateTimeDescrLabel.TabIndex = 30;
            this.DateTimeDescrLabel.Text = "Время дополнения заявления:";
            // 
            // DescripApplLabel
            // 
            this.DescripApplLabel.AutoSize = true;
            this.DescripApplLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DescripApplLabel.Location = new System.Drawing.Point(30, 735);
            this.DescripApplLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescripApplLabel.Name = "DescripApplLabel";
            this.DescripApplLabel.Size = new System.Drawing.Size(343, 45);
            this.DescripApplLabel.TabIndex = 29;
            this.DescripApplLabel.Text = "Описание заявления:";
            // 
            // TypeApplLabel
            // 
            this.TypeApplLabel.AutoSize = true;
            this.TypeApplLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.TypeApplLabel.Location = new System.Drawing.Point(33, 530);
            this.TypeApplLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeApplLabel.Name = "TypeApplLabel";
            this.TypeApplLabel.Size = new System.Drawing.Size(247, 45);
            this.TypeApplLabel.TabIndex = 28;
            this.TypeApplLabel.Text = "Тип заявления:";
            // 
            // ApplDTP
            // 
            this.ApplDTP.Enabled = false;
            this.ApplDTP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplDTP.Location = new System.Drawing.Point(38, 1540);
            this.ApplDTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ApplDTP.Name = "ApplDTP";
            this.ApplDTP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ApplDTP.Size = new System.Drawing.Size(426, 56);
            this.ApplDTP.TabIndex = 26;
            // 
            // SupPictureBox
            // 
            this.SupPictureBox.BackColor = System.Drawing.Color.White;
            this.SupPictureBox.Image = global::Napitki_Altay2.Properties.Resources.Герб_Алтайского_края;
            this.SupPictureBox.Location = new System.Drawing.Point(200, 38);
            this.SupPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SupPictureBox.Name = "SupPictureBox";
            this.SupPictureBox.Size = new System.Drawing.Size(314, 320);
            this.SupPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SupPictureBox.TabIndex = 22;
            this.SupPictureBox.TabStop = false;
            // 
            // DeleteDocumentButton
            // 
            this.DeleteDocumentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.DeleteDocumentButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.DeleteDocumentButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DeleteDocumentButton.BorderRadius = 0;
            this.DeleteDocumentButton.BorderSize = 0;
            this.DeleteDocumentButton.FlatAppearance.BorderSize = 0;
            this.DeleteDocumentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteDocumentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDocumentButton.ForeColor = System.Drawing.Color.White;
            this.DeleteDocumentButton.Location = new System.Drawing.Point(1216, 669);
            this.DeleteDocumentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteDocumentButton.Name = "DeleteDocumentButton";
            this.DeleteDocumentButton.Size = new System.Drawing.Size(307, 88);
            this.DeleteDocumentButton.TabIndex = 37;
            this.DeleteDocumentButton.Text = "Удалить файлы";
            this.DeleteDocumentButton.TextColor = System.Drawing.Color.White;
            this.DeleteDocumentButton.UseVisualStyleBackColor = false;
            this.DeleteDocumentButton.Click += new System.EventHandler(this.DeleteDocumentButton_Click);
            // 
            // ChooseDocumentButton
            // 
            this.ChooseDocumentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.ChooseDocumentButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.ChooseDocumentButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.ChooseDocumentButton.BorderRadius = 0;
            this.ChooseDocumentButton.BorderSize = 0;
            this.ChooseDocumentButton.FlatAppearance.BorderSize = 0;
            this.ChooseDocumentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseDocumentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseDocumentButton.ForeColor = System.Drawing.Color.White;
            this.ChooseDocumentButton.Location = new System.Drawing.Point(783, 669);
            this.ChooseDocumentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChooseDocumentButton.Name = "ChooseDocumentButton";
            this.ChooseDocumentButton.Size = new System.Drawing.Size(307, 88);
            this.ChooseDocumentButton.TabIndex = 35;
            this.ChooseDocumentButton.Text = "Выбрать файлы";
            this.ChooseDocumentButton.TextColor = System.Drawing.Color.White;
            this.ChooseDocumentButton.UseVisualStyleBackColor = false;
            this.ChooseDocumentButton.Click += new System.EventHandler(this.ChooseDocumentButton_Click);
            // 
            // CancelSupButton
            // 
            this.CancelSupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CancelSupButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CancelSupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CancelSupButton.BorderRadius = 0;
            this.CancelSupButton.BorderSize = 0;
            this.CancelSupButton.FlatAppearance.BorderSize = 0;
            this.CancelSupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelSupButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelSupButton.ForeColor = System.Drawing.Color.White;
            this.CancelSupButton.Location = new System.Drawing.Point(905, 1633);
            this.CancelSupButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelSupButton.Name = "CancelSupButton";
            this.CancelSupButton.Size = new System.Drawing.Size(598, 128);
            this.CancelSupButton.TabIndex = 32;
            this.CancelSupButton.Text = "Закрыть заявление";
            this.CancelSupButton.TextColor = System.Drawing.Color.White;
            this.CancelSupButton.UseVisualStyleBackColor = false;
            this.CancelSupButton.Click += new System.EventHandler(this.CancelSupButton_Click);
            // 
            // PlusSupButton
            // 
            this.PlusSupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.PlusSupButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.PlusSupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.PlusSupButton.BorderRadius = 0;
            this.PlusSupButton.BorderSize = 0;
            this.PlusSupButton.FlatAppearance.BorderSize = 0;
            this.PlusSupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusSupButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusSupButton.ForeColor = System.Drawing.Color.White;
            this.PlusSupButton.Location = new System.Drawing.Point(117, 1633);
            this.PlusSupButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlusSupButton.Name = "PlusSupButton";
            this.PlusSupButton.Size = new System.Drawing.Size(598, 128);
            this.PlusSupButton.TabIndex = 31;
            this.PlusSupButton.Text = "Дополнить заявление";
            this.PlusSupButton.TextColor = System.Drawing.Color.White;
            this.PlusSupButton.UseVisualStyleBackColor = false;
            this.PlusSupButton.Click += new System.EventHandler(this.PlusSupButton_Click);
            // 
            // DescripTextBox
            // 
            this.DescripTextBox.AutoScroll = true;
            this.DescripTextBox.AutoScrollMinSize = new System.Drawing.Size(0, 2);
            this.DescripTextBox.BackColor = System.Drawing.Color.White;
            this.DescripTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.DescripTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.DescripTextBox.BorderSize = 2;
            this.DescripTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DescripTextBox.ForeColor = System.Drawing.Color.Black;
            this.DescripTextBox.Location = new System.Drawing.Point(41, 795);
            this.DescripTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.DescripTextBox.Multiline = true;
            this.DescripTextBox.Name = "DescripTextBox";
            this.DescripTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.DescripTextBox.PasswordChar = false;
            this.DescripTextBox.ReadOnly = false;
            this.DescripTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescripTextBox.SelectionStart = 0;
            this.DescripTextBox.Size = new System.Drawing.Size(1537, 669);
            this.DescripTextBox.TabIndex = 25;
            this.DescripTextBox.Texts = "";
            this.DescripTextBox.UnderlinedStyle = false;
            // 
            // TypeApplTextBox
            // 
            this.TypeApplTextBox.BackColor = System.Drawing.Color.White;
            this.TypeApplTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.TypeApplTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.TypeApplTextBox.BorderSize = 2;
            this.TypeApplTextBox.Enabled = false;
            this.TypeApplTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TypeApplTextBox.ForeColor = System.Drawing.Color.Black;
            this.TypeApplTextBox.Location = new System.Drawing.Point(41, 580);
            this.TypeApplTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.TypeApplTextBox.Multiline = false;
            this.TypeApplTextBox.Name = "TypeApplTextBox";
            this.TypeApplTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.TypeApplTextBox.PasswordChar = false;
            this.TypeApplTextBox.ReadOnly = false;
            this.TypeApplTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TypeApplTextBox.SelectionStart = 0;
            this.TypeApplTextBox.Size = new System.Drawing.Size(574, 55);
            this.TypeApplTextBox.TabIndex = 24;
            this.TypeApplTextBox.Texts = "";
            this.TypeApplTextBox.UnderlinedStyle = false;
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
            // DocumentListBox
            // 
            this.DocumentListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DocumentListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DocumentListBox.FormattingEnabled = true;
            this.DocumentListBox.ItemHeight = 31;
            this.DocumentListBox.Location = new System.Drawing.Point(723, 135);
            this.DocumentListBox.Name = "DocumentListBox";
            this.DocumentListBox.Size = new System.Drawing.Size(855, 500);
            this.DocumentListBox.TabIndex = 79;
            // 
            // AdministrationLabel
            // 
            this.AdministrationLabel.AutoSize = true;
            this.AdministrationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.AdministrationLabel.Location = new System.Drawing.Point(26, 374);
            this.AdministrationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdministrationLabel.Name = "AdministrationLabel";
            this.AdministrationLabel.Size = new System.Drawing.Size(662, 92);
            this.AdministrationLabel.TabIndex = 80;
            this.AdministrationLabel.Text = "Администрация Волчихинского района \r\nАлтайского края";
            this.AdministrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SupplementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1619, 1817);
            this.Controls.Add(this.AdministrationLabel);
            this.Controls.Add(this.DocumentListBox);
            this.Controls.Add(this.DeleteDocumentButton);
            this.Controls.Add(this.SelectDocumentLabel);
            this.Controls.Add(this.ChooseDocumentButton);
            this.Controls.Add(this.CancelSupButton);
            this.Controls.Add(this.PlusSupButton);
            this.Controls.Add(this.DateTimeDescrLabel);
            this.Controls.Add(this.DescripApplLabel);
            this.Controls.Add(this.TypeApplLabel);
            this.Controls.Add(this.ApplDTP);
            this.Controls.Add(this.DescripTextBox);
            this.Controls.Add(this.TypeApplTextBox);
            this.Controls.Add(this.SupPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(40, 30);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SupplementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ваше заявление";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SupplementForm_FormClosed);
            this.Load += new System.EventHandler(this.SupplementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SupPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SelectDocumentLabel;
        private Design.CustomButton ChooseDocumentButton;
        private Design.CustomButton CancelSupButton;
        private Design.CustomButton PlusSupButton;
        private System.Windows.Forms.Label DateTimeDescrLabel;
        private System.Windows.Forms.Label DescripApplLabel;
        private System.Windows.Forms.Label TypeApplLabel;
        private System.Windows.Forms.DateTimePicker ApplDTP;
        private Design.CustomTextBox DescripTextBox;
        private Design.CustomTextBox TypeApplTextBox;
        private System.Windows.Forms.PictureBox SupPictureBox;
        private Components.FormStyleCustom CustomFormForAllProject;
        private Design.CustomButton DeleteDocumentButton;
        private System.Windows.Forms.ListBox DocumentListBox;
        private System.Windows.Forms.Label AdministrationLabel;
    }
}