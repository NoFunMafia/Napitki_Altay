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
            this.ApplPictureBox = new System.Windows.Forms.PictureBox();
            this.ApplDTP = new System.Windows.Forms.DateTimePicker();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.TypeApplLabel = new System.Windows.Forms.Label();
            this.DescripApplLabel = new System.Windows.Forms.Label();
            this.DateTimeDescrLabel = new System.Windows.Forms.Label();
            this.ChooseTypeApplPictureBox = new System.Windows.Forms.PictureBox();
            this.TypeApplMenuStip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сотрудничествоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обсуждениеПроблемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ознакомлениеСКаталогомПродукцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.письмопритензияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.письмоблагодарностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectDocumentLabel = new System.Windows.Forms.Label();
            this.DeleteDocumentButton = new Napitki_Altay2.Design.CustomButton();
            this.ChooseDocumentButton = new Napitki_Altay2.Design.CustomButton();
            this.DocumentTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CancelApplButton = new Napitki_Altay2.Design.CustomButton();
            this.RegApplButton = new Napitki_Altay2.Design.CustomButton();
            this.DescripTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.TypeApplTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CompanyTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ApplPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseTypeApplPictureBox)).BeginInit();
            this.TypeApplMenuStip.SuspendLayout();
            this.SuspendLayout();
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
            this.ApplPictureBox.TabIndex = 5;
            this.ApplPictureBox.TabStop = false;
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
            this.ApplDTP.TabIndex = 9;
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.CompanyNameLabel.Location = new System.Drawing.Point(20, 170);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(262, 28);
            this.CompanyNameLabel.TabIndex = 10;
            this.CompanyNameLabel.Text = "Наименование компании:";
            // 
            // TypeApplLabel
            // 
            this.TypeApplLabel.AutoSize = true;
            this.TypeApplLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.TypeApplLabel.Location = new System.Drawing.Point(20, 246);
            this.TypeApplLabel.Name = "TypeApplLabel";
            this.TypeApplLabel.Size = new System.Drawing.Size(165, 28);
            this.TypeApplLabel.TabIndex = 11;
            this.TypeApplLabel.Text = "Тип обращения:";
            // 
            // DescripApplLabel
            // 
            this.DescripApplLabel.AutoSize = true;
            this.DescripApplLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DescripApplLabel.Location = new System.Drawing.Point(20, 319);
            this.DescripApplLabel.Name = "DescripApplLabel";
            this.DescripApplLabel.Size = new System.Drawing.Size(225, 28);
            this.DescripApplLabel.TabIndex = 12;
            this.DescripApplLabel.Text = "Описание обращения:";
            // 
            // DateTimeDescrLabel
            // 
            this.DateTimeDescrLabel.AutoSize = true;
            this.DateTimeDescrLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DateTimeDescrLabel.Location = new System.Drawing.Point(20, 606);
            this.DateTimeDescrLabel.Name = "DateTimeDescrLabel";
            this.DateTimeDescrLabel.Size = new System.Drawing.Size(269, 28);
            this.DateTimeDescrLabel.TabIndex = 13;
            this.DateTimeDescrLabel.Text = "Время подачи обращения:";
            // 
            // ChooseTypeApplPictureBox
            // 
            this.ChooseTypeApplPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseTypeApplPictureBox.Image = global::Napitki_Altay2.Properties.Resources.PictureRegForm;
            this.ChooseTypeApplPictureBox.Location = new System.Drawing.Point(372, 283);
            this.ChooseTypeApplPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChooseTypeApplPictureBox.Name = "ChooseTypeApplPictureBox";
            this.ChooseTypeApplPictureBox.Size = new System.Drawing.Size(32, 27);
            this.ChooseTypeApplPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChooseTypeApplPictureBox.TabIndex = 16;
            this.ChooseTypeApplPictureBox.TabStop = false;
            this.ChooseTypeApplPictureBox.Click += new System.EventHandler(this.ChooseTypeApplPictureBox_Click);
            // 
            // TypeApplMenuStip
            // 
            this.TypeApplMenuStip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.TypeApplMenuStip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TypeApplMenuStip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудничествоToolStripMenuItem,
            this.обсуждениеПроблемыToolStripMenuItem,
            this.ознакомлениеСКаталогомПродукцииToolStripMenuItem,
            this.письмопритензияToolStripMenuItem,
            this.письмоблагодарностьToolStripMenuItem});
            this.TypeApplMenuStip.Name = "TypeApplMenuStip";
            this.TypeApplMenuStip.Size = new System.Drawing.Size(307, 124);
            // 
            // сотрудничествоToolStripMenuItem
            // 
            this.сотрудничествоToolStripMenuItem.Name = "сотрудничествоToolStripMenuItem";
            this.сотрудничествоToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
            this.сотрудничествоToolStripMenuItem.Text = "Сотрудничество";
            this.сотрудничествоToolStripMenuItem.Click += new System.EventHandler(this.сотрудничествоToolStripMenuItem_Click);
            // 
            // обсуждениеПроблемыToolStripMenuItem
            // 
            this.обсуждениеПроблемыToolStripMenuItem.Name = "обсуждениеПроблемыToolStripMenuItem";
            this.обсуждениеПроблемыToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
            this.обсуждениеПроблемыToolStripMenuItem.Text = "Обсуждение проблемы";
            this.обсуждениеПроблемыToolStripMenuItem.Click += new System.EventHandler(this.обсуждениеПроблемыToolStripMenuItem_Click);
            // 
            // ознакомлениеСКаталогомПродукцииToolStripMenuItem
            // 
            this.ознакомлениеСКаталогомПродукцииToolStripMenuItem.Name = "ознакомлениеСКаталогомПродукцииToolStripMenuItem";
            this.ознакомлениеСКаталогомПродукцииToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
            this.ознакомлениеСКаталогомПродукцииToolStripMenuItem.Text = "Вопросы по каталогу продукции";
            this.ознакомлениеСКаталогомПродукцииToolStripMenuItem.Click += new System.EventHandler(this.ознакомлениеСКаталогомПродукцииToolStripMenuItem_Click);
            // 
            // письмопритензияToolStripMenuItem
            // 
            this.письмопритензияToolStripMenuItem.Name = "письмопритензияToolStripMenuItem";
            this.письмопритензияToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
            this.письмопритензияToolStripMenuItem.Text = "Письмо-притензия";
            this.письмопритензияToolStripMenuItem.Click += new System.EventHandler(this.письмопритензияToolStripMenuItem_Click);
            // 
            // письмоблагодарностьToolStripMenuItem
            // 
            this.письмоблагодарностьToolStripMenuItem.Name = "письмоблагодарностьToolStripMenuItem";
            this.письмоблагодарностьToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
            this.письмоблагодарностьToolStripMenuItem.Text = "Письмо-благодарность";
            this.письмоблагодарностьToolStripMenuItem.Click += new System.EventHandler(this.письмоблагодарностьToolStripMenuItem_Click);
            // 
            // SelectDocumentLabel
            // 
            this.SelectDocumentLabel.AutoSize = true;
            this.SelectDocumentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.SelectDocumentLabel.Location = new System.Drawing.Point(423, 176);
            this.SelectDocumentLabel.Name = "SelectDocumentLabel";
            this.SelectDocumentLabel.Size = new System.Drawing.Size(426, 25);
            this.SelectDocumentLabel.TabIndex = 20;
            this.SelectDocumentLabel.Text = "Прикрепить файл к обращению (опционально):";
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
            this.DeleteDocumentButton.TabIndex = 21;
            this.DeleteDocumentButton.Text = "Удалить файл";
            this.DeleteDocumentButton.TextColor = System.Drawing.Color.White;
            this.DeleteDocumentButton.UseVisualStyleBackColor = false;
            this.DeleteDocumentButton.Click += new System.EventHandler(this.DeleteDocumentButton_Click);
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
            this.ChooseDocumentButton.TabIndex = 18;
            this.ChooseDocumentButton.Text = "Выбрать файл";
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
            this.DocumentTextBox.Size = new System.Drawing.Size(383, 35);
            this.DocumentTextBox.TabIndex = 17;
            this.DocumentTextBox.Texts = "";
            this.DocumentTextBox.UnderlinedStyle = false;
            // 
            // CancelApplButton
            // 
            this.CancelApplButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CancelApplButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.CancelApplButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CancelApplButton.BorderRadius = 0;
            this.CancelApplButton.BorderSize = 0;
            this.CancelApplButton.FlatAppearance.BorderSize = 0;
            this.CancelApplButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelApplButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelApplButton.ForeColor = System.Drawing.Color.White;
            this.CancelApplButton.Location = new System.Drawing.Point(467, 692);
            this.CancelApplButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelApplButton.Name = "CancelApplButton";
            this.CancelApplButton.Size = new System.Drawing.Size(399, 82);
            this.CancelApplButton.TabIndex = 15;
            this.CancelApplButton.Text = "Прекратить создание";
            this.CancelApplButton.TextColor = System.Drawing.Color.White;
            this.CancelApplButton.UseVisualStyleBackColor = false;
            this.CancelApplButton.Click += new System.EventHandler(this.CancelApplButton_Click);
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
            this.RegApplButton.TabIndex = 14;
            this.RegApplButton.Text = "Создать обращение";
            this.RegApplButton.TextColor = System.Drawing.Color.White;
            this.RegApplButton.UseVisualStyleBackColor = false;
            this.RegApplButton.Click += new System.EventHandler(this.RegApplButton_Click);
            // 
            // DescripTextBox
            // 
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
            this.DescripTextBox.Size = new System.Drawing.Size(839, 254);
            this.DescripTextBox.TabIndex = 8;
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
            this.TypeApplTextBox.Size = new System.Drawing.Size(383, 35);
            this.TypeApplTextBox.TabIndex = 7;
            this.TypeApplTextBox.Texts = "";
            this.TypeApplTextBox.UnderlinedStyle = false;
            // 
            // CompanyTextBox
            // 
            this.CompanyTextBox.BackColor = System.Drawing.Color.White;
            this.CompanyTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.CompanyTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CompanyTextBox.BorderSize = 2;
            this.CompanyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.CompanyTextBox.ForeColor = System.Drawing.Color.Black;
            this.CompanyTextBox.Location = new System.Drawing.Point(25, 206);
            this.CompanyTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyTextBox.Multiline = false;
            this.CompanyTextBox.Name = "CompanyTextBox";
            this.CompanyTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.CompanyTextBox.PasswordChar = false;
            this.CompanyTextBox.Size = new System.Drawing.Size(383, 35);
            this.CompanyTextBox.TabIndex = 6;
            this.CompanyTextBox.Texts = "";
            this.CompanyTextBox.UnderlinedStyle = false;
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
            // CreateApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 790);
            this.Controls.Add(this.DeleteDocumentButton);
            this.Controls.Add(this.SelectDocumentLabel);
            this.Controls.Add(this.ChooseDocumentButton);
            this.Controls.Add(this.DocumentTextBox);
            this.Controls.Add(this.ChooseTypeApplPictureBox);
            this.Controls.Add(this.CancelApplButton);
            this.Controls.Add(this.RegApplButton);
            this.Controls.Add(this.DateTimeDescrLabel);
            this.Controls.Add(this.DescripApplLabel);
            this.Controls.Add(this.TypeApplLabel);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.ApplDTP);
            this.Controls.Add(this.DescripTextBox);
            this.Controls.Add(this.TypeApplTextBox);
            this.Controls.Add(this.CompanyTextBox);
            this.Controls.Add(this.ApplPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание обращения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateApplicationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ApplPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseTypeApplPictureBox)).EndInit();
            this.TypeApplMenuStip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormStyleCustom CustomFormForAllProject;
        private System.Windows.Forms.PictureBox ApplPictureBox;
        private System.Windows.Forms.DateTimePicker ApplDTP;
        private Design.CustomTextBox DescripTextBox;
        private Design.CustomTextBox TypeApplTextBox;
        private Design.CustomTextBox CompanyTextBox;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label DescripApplLabel;
        private System.Windows.Forms.Label TypeApplLabel;
        private System.Windows.Forms.Label DateTimeDescrLabel;
        private Design.CustomButton RegApplButton;
        private Design.CustomButton CancelApplButton;
        private System.Windows.Forms.PictureBox ChooseTypeApplPictureBox;
        private System.Windows.Forms.ContextMenuStrip TypeApplMenuStip;
        private System.Windows.Forms.ToolStripMenuItem сотрудничествоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обсуждениеПроблемыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ознакомлениеСКаталогомПродукцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem письмопритензияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem письмоблагодарностьToolStripMenuItem;
        private Design.CustomTextBox DocumentTextBox;
        private Design.CustomButton ChooseDocumentButton;
        private System.Windows.Forms.Label SelectDocumentLabel;
        private Design.CustomButton DeleteDocumentButton;
    }
}