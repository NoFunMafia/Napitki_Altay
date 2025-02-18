namespace Napitki_Altay2.Forms
{
    partial class CreateApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateApplicationForm));
            this.ApplDTP = new System.Windows.Forms.DateTimePicker();
            this.TypeApplLabel = new System.Windows.Forms.Label();
            this.DescripApplLabel = new System.Windows.Forms.Label();
            this.DateTimeDescrLabel = new System.Windows.Forms.Label();
            this.TypeApplMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.компенсацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постановкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectDocumentLabel = new System.Windows.Forms.Label();
            this.ChooseTypeApplPictureBox = new System.Windows.Forms.PictureBox();
            this.ApplPictureBox = new System.Windows.Forms.PictureBox();
            this.DocumentListBox = new System.Windows.Forms.ListBox();
            this.ClearFilesButton = new Napitki_Altay2.Design.CustomButton();
            this.ChooseDocumentButton = new Napitki_Altay2.Design.CustomButton();
            this.CancelApplButton = new Napitki_Altay2.Design.CustomButton();
            this.RegApplButton = new Napitki_Altay2.Design.CustomButton();
            this.DescripTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.TypeApplTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.AdministrationLabel = new System.Windows.Forms.Label();
            this.TypeApplMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseTypeApplPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.ApplDTP.TabIndex = 9;
            // 
            // TypeApplLabel
            // 
            this.TypeApplLabel.AutoSize = true;
            this.TypeApplLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.TypeApplLabel.Location = new System.Drawing.Point(33, 530);
            this.TypeApplLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeApplLabel.Name = "TypeApplLabel";
            this.TypeApplLabel.Size = new System.Drawing.Size(247, 45);
            this.TypeApplLabel.TabIndex = 11;
            this.TypeApplLabel.Text = "Тип заявления:";
            // 
            // DescripApplLabel
            // 
            this.DescripApplLabel.AutoSize = true;
            this.DescripApplLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DescripApplLabel.Location = new System.Drawing.Point(30, 735);
            this.DescripApplLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescripApplLabel.Name = "DescripApplLabel";
            this.DescripApplLabel.Size = new System.Drawing.Size(343, 45);
            this.DescripApplLabel.TabIndex = 12;
            this.DescripApplLabel.Text = "Описание заявления:";
            // 
            // DateTimeDescrLabel
            // 
            this.DateTimeDescrLabel.AutoSize = true;
            this.DateTimeDescrLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DateTimeDescrLabel.Location = new System.Drawing.Point(30, 1487);
            this.DateTimeDescrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateTimeDescrLabel.Name = "DateTimeDescrLabel";
            this.DateTimeDescrLabel.Size = new System.Drawing.Size(411, 45);
            this.DateTimeDescrLabel.TabIndex = 13;
            this.DateTimeDescrLabel.Text = "Время подачи заявления:";
            // 
            // TypeApplMenuStrip
            // 
            this.TypeApplMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.TypeApplMenuStrip.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            this.TypeApplMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TypeApplMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компенсацияToolStripMenuItem,
            this.постановкаToolStripMenuItem,
            this.получениеToolStripMenuItem});
            this.TypeApplMenuStrip.Name = "TypeApplMenuStip";
            this.TypeApplMenuStrip.Size = new System.Drawing.Size(774, 136);
            // 
            // компенсацияToolStripMenuItem
            // 
            this.компенсацияToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.компенсацияToolStripMenuItem.Name = "компенсацияToolStripMenuItem";
            this.компенсацияToolStripMenuItem.Size = new System.Drawing.Size(773, 44);
            this.компенсацияToolStripMenuItem.Text = "Компенсация родительской платы";
            this.компенсацияToolStripMenuItem.Click += new System.EventHandler(this.КомпенсацияToolStripMenuItem_Click);
            // 
            // постановкаToolStripMenuItem
            // 
            this.постановкаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.постановкаToolStripMenuItem.Name = "постановкаToolStripMenuItem";
            this.постановкаToolStripMenuItem.Size = new System.Drawing.Size(773, 44);
            this.постановкаToolStripMenuItem.Text = "Постановка на учет в образовательные организации";
            this.постановкаToolStripMenuItem.Click += new System.EventHandler(this.ПостановкаToolStripMenuItem_Click);
            // 
            // получениеToolStripMenuItem
            // 
            this.получениеToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.получениеToolStripMenuItem.Name = "получениеToolStripMenuItem";
            this.получениеToolStripMenuItem.Size = new System.Drawing.Size(773, 44);
            this.получениеToolStripMenuItem.Text = "Получение информации об образовании";
            this.получениеToolStripMenuItem.Click += new System.EventHandler(this.ПолучениеToolStripMenuItem_Click);
            // 
            // SelectDocumentLabel
            // 
            this.SelectDocumentLabel.AutoSize = true;
            this.SelectDocumentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SelectDocumentLabel.Location = new System.Drawing.Point(715, 67);
            this.SelectDocumentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectDocumentLabel.Name = "SelectDocumentLabel";
            this.SelectDocumentLabel.Size = new System.Drawing.Size(524, 45);
            this.SelectDocumentLabel.TabIndex = 20;
            this.SelectDocumentLabel.Text = "Прикрепить файлы к заявлению:";
            // 
            // ChooseTypeApplPictureBox
            // 
            this.ChooseTypeApplPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseTypeApplPictureBox.Image = global::Napitki_Altay2.Properties.Resources.PictureRegForm;
            this.ChooseTypeApplPictureBox.Location = new System.Drawing.Point(561, 588);
            this.ChooseTypeApplPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChooseTypeApplPictureBox.Name = "ChooseTypeApplPictureBox";
            this.ChooseTypeApplPictureBox.Size = new System.Drawing.Size(48, 42);
            this.ChooseTypeApplPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChooseTypeApplPictureBox.TabIndex = 16;
            this.ChooseTypeApplPictureBox.TabStop = false;
            this.ChooseTypeApplPictureBox.Click += new System.EventHandler(this.ChooseTypeApplPictureBox_Click);
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
            this.ApplPictureBox.TabIndex = 5;
            this.ApplPictureBox.TabStop = false;
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
            this.DocumentListBox.TabIndex = 22;
            this.DocumentListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DocumentListBox_MouseDoubleClick);
            // 
            // ClearFilesButton
            // 
            this.ClearFilesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.ClearFilesButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.ClearFilesButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.ClearFilesButton.BorderRadius = 0;
            this.ClearFilesButton.BorderSize = 0;
            this.ClearFilesButton.FlatAppearance.BorderSize = 0;
            this.ClearFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearFilesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearFilesButton.ForeColor = System.Drawing.Color.White;
            this.ClearFilesButton.Location = new System.Drawing.Point(1216, 669);
            this.ClearFilesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearFilesButton.Name = "ClearFilesButton";
            this.ClearFilesButton.Size = new System.Drawing.Size(307, 88);
            this.ClearFilesButton.TabIndex = 21;
            this.ClearFilesButton.Text = "Удалить файлы";
            this.ClearFilesButton.TextColor = System.Drawing.Color.White;
            this.ClearFilesButton.UseVisualStyleBackColor = false;
            this.ClearFilesButton.Click += new System.EventHandler(this.ClearFilesButton_Click);
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
            this.ChooseDocumentButton.TabIndex = 18;
            this.ChooseDocumentButton.Text = "Выбрать файлы";
            this.ChooseDocumentButton.TextColor = System.Drawing.Color.White;
            this.ChooseDocumentButton.UseVisualStyleBackColor = false;
            this.ChooseDocumentButton.Click += new System.EventHandler(this.ChooseDocumentButton_Click);
            // 
            // CancelApplButton
            // 
            this.CancelApplButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CancelApplButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CancelApplButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CancelApplButton.BorderRadius = 0;
            this.CancelApplButton.BorderSize = 0;
            this.CancelApplButton.FlatAppearance.BorderSize = 0;
            this.CancelApplButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelApplButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelApplButton.ForeColor = System.Drawing.Color.White;
            this.CancelApplButton.Location = new System.Drawing.Point(905, 1633);
            this.CancelApplButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelApplButton.Name = "CancelApplButton";
            this.CancelApplButton.Size = new System.Drawing.Size(598, 128);
            this.CancelApplButton.TabIndex = 15;
            this.CancelApplButton.Text = "Прекратить создание";
            this.CancelApplButton.TextColor = System.Drawing.Color.White;
            this.CancelApplButton.UseVisualStyleBackColor = false;
            this.CancelApplButton.Click += new System.EventHandler(this.CancelApplButton_Click);
            // 
            // RegApplButton
            // 
            this.RegApplButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.RegApplButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.RegApplButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.RegApplButton.BorderRadius = 0;
            this.RegApplButton.BorderSize = 0;
            this.RegApplButton.FlatAppearance.BorderSize = 0;
            this.RegApplButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegApplButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegApplButton.ForeColor = System.Drawing.Color.White;
            this.RegApplButton.Location = new System.Drawing.Point(117, 1633);
            this.RegApplButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RegApplButton.Name = "RegApplButton";
            this.RegApplButton.Size = new System.Drawing.Size(598, 128);
            this.RegApplButton.TabIndex = 14;
            this.RegApplButton.Text = "Создать заявление";
            this.RegApplButton.TextColor = System.Drawing.Color.White;
            this.RegApplButton.UseVisualStyleBackColor = false;
            this.RegApplButton.Click += new System.EventHandler(this.RegApplButton_Click);
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
            this.DescripTextBox.TabIndex = 8;
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
            this.TypeApplTextBox.TabIndex = 7;
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
            // AdministrationLabel
            // 
            this.AdministrationLabel.AutoSize = true;
            this.AdministrationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.AdministrationLabel.Location = new System.Drawing.Point(26, 374);
            this.AdministrationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdministrationLabel.Name = "AdministrationLabel";
            this.AdministrationLabel.Size = new System.Drawing.Size(662, 92);
            this.AdministrationLabel.TabIndex = 23;
            this.AdministrationLabel.Text = "Администрация Волчихинского района \r\nАлтайского края";
            this.AdministrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1619, 1817);
            this.Controls.Add(this.AdministrationLabel);
            this.Controls.Add(this.DocumentListBox);
            this.Controls.Add(this.ClearFilesButton);
            this.Controls.Add(this.SelectDocumentLabel);
            this.Controls.Add(this.ChooseDocumentButton);
            this.Controls.Add(this.ChooseTypeApplPictureBox);
            this.Controls.Add(this.CancelApplButton);
            this.Controls.Add(this.RegApplButton);
            this.Controls.Add(this.DateTimeDescrLabel);
            this.Controls.Add(this.DescripApplLabel);
            this.Controls.Add(this.TypeApplLabel);
            this.Controls.Add(this.ApplDTP);
            this.Controls.Add(this.DescripTextBox);
            this.Controls.Add(this.TypeApplTextBox);
            this.Controls.Add(this.ApplPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CreateApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание заявления";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateApplicationForm_FormClosed);
            this.TypeApplMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChooseTypeApplPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormStyleCustom CustomFormForAllProject;
        private System.Windows.Forms.PictureBox ApplPictureBox;
        private System.Windows.Forms.DateTimePicker ApplDTP;
        private Design.CustomTextBox DescripTextBox;
        private Design.CustomTextBox TypeApplTextBox;
        private System.Windows.Forms.Label DescripApplLabel;
        private System.Windows.Forms.Label TypeApplLabel;
        private System.Windows.Forms.Label DateTimeDescrLabel;
        private Design.CustomButton RegApplButton;
        private Design.CustomButton CancelApplButton;
        private System.Windows.Forms.PictureBox ChooseTypeApplPictureBox;
        private System.Windows.Forms.ContextMenuStrip TypeApplMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem компенсацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постановкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получениеToolStripMenuItem;
        private Design.CustomButton ChooseDocumentButton;
        private System.Windows.Forms.Label SelectDocumentLabel;
        private Design.CustomButton ClearFilesButton;
        private System.Windows.Forms.ListBox DocumentListBox;
        private System.Windows.Forms.Label AdministrationLabel;
    }
}