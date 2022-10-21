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
            this.DataGridViewApplication = new System.Windows.Forms.DataGridView();
            this.DocPage = new System.Windows.Forms.TabPage();
            this.UserDataPage = new System.Windows.Forms.TabPage();
            this.PasswordInfoLabel = new System.Windows.Forms.Label();
            this.SurnameInfoLabel = new System.Windows.Forms.Label();
            this.NameInfoLabel = new System.Windows.Forms.Label();
            this.FamInfoLabel = new System.Windows.Forms.Label();
            this.InfoUserLabel = new System.Windows.Forms.Label();
            this.UpdateDataInDGW = new Napitki_Altay2.Design.CustomButton();
            this.DeleteApplicationButton = new Napitki_Altay2.Design.CustomButton();
            this.ModifyApplicationButton = new Napitki_Altay2.Design.CustomButton();
            this.CreateApplicationButton = new Napitki_Altay2.Design.CustomButton();
            this.UpdLogPassButton = new Napitki_Altay2.Design.CustomButton();
            this.CreateUserFIOButton = new Napitki_Altay2.Design.CustomButton();
            this.PassCreaUpdaTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.PatrCreateTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.NameCreateTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.FamCreateTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CustomFormForAllProject = new Napitki_Altay2.DesignComponents.CustomForm(this.components);
            this.MainWorkTabControl.SuspendLayout();
            this.ApplicationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewApplication)).BeginInit();
            this.UserDataPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWorkTabControl
            // 
            this.MainWorkTabControl.Controls.Add(this.ApplicationPage);
            this.MainWorkTabControl.Controls.Add(this.DocPage);
            this.MainWorkTabControl.Controls.Add(this.UserDataPage);
            this.MainWorkTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainWorkTabControl.Location = new System.Drawing.Point(3, 4);
            this.MainWorkTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainWorkTabControl.Name = "MainWorkTabControl";
            this.MainWorkTabControl.SelectedIndex = 0;
            this.MainWorkTabControl.Size = new System.Drawing.Size(758, 448);
            this.MainWorkTabControl.TabIndex = 0;
            // 
            // ApplicationPage
            // 
            this.ApplicationPage.Controls.Add(this.InfoApplicationLabel);
            this.ApplicationPage.Controls.Add(this.UpdateDataInDGW);
            this.ApplicationPage.Controls.Add(this.DeleteApplicationButton);
            this.ApplicationPage.Controls.Add(this.ModifyApplicationButton);
            this.ApplicationPage.Controls.Add(this.CreateApplicationButton);
            this.ApplicationPage.Controls.Add(this.DataGridViewApplication);
            this.ApplicationPage.Location = new System.Drawing.Point(4, 24);
            this.ApplicationPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApplicationPage.Name = "ApplicationPage";
            this.ApplicationPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApplicationPage.Size = new System.Drawing.Size(750, 420);
            this.ApplicationPage.TabIndex = 0;
            this.ApplicationPage.Text = "Заявки";
            this.ApplicationPage.UseVisualStyleBackColor = true;
            // 
            // InfoApplicationLabel
            // 
            this.InfoApplicationLabel.AutoSize = true;
            this.InfoApplicationLabel.BackColor = System.Drawing.Color.White;
            this.InfoApplicationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.InfoApplicationLabel.ForeColor = System.Drawing.Color.Black;
            this.InfoApplicationLabel.Location = new System.Drawing.Point(487, 3);
            this.InfoApplicationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoApplicationLabel.Name = "InfoApplicationLabel";
            this.InfoApplicationLabel.Size = new System.Drawing.Size(261, 38);
            this.InfoApplicationLabel.TabIndex = 14;
            this.InfoApplicationLabel.Text = "Данные о пользователе не заполнены,\r\nфункции создания заявки отключены.\r\n";
            this.InfoApplicationLabel.Visible = false;
            // 
            // DataGridViewApplication
            // 
            this.DataGridViewApplication.AllowUserToAddRows = false;
            this.DataGridViewApplication.AllowUserToDeleteRows = false;
            this.DataGridViewApplication.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewApplication.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewApplication.Location = new System.Drawing.Point(2, 46);
            this.DataGridViewApplication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridViewApplication.Name = "DataGridViewApplication";
            this.DataGridViewApplication.ReadOnly = true;
            this.DataGridViewApplication.RowHeadersWidth = 51;
            this.DataGridViewApplication.RowTemplate.Height = 24;
            this.DataGridViewApplication.Size = new System.Drawing.Size(746, 372);
            this.DataGridViewApplication.TabIndex = 0;
            // 
            // DocPage
            // 
            this.DocPage.Location = new System.Drawing.Point(4, 24);
            this.DocPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DocPage.Name = "DocPage";
            this.DocPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DocPage.Size = new System.Drawing.Size(750, 420);
            this.DocPage.TabIndex = 1;
            this.DocPage.Text = "Документы";
            this.DocPage.UseVisualStyleBackColor = true;
            // 
            // UserDataPage
            // 
            this.UserDataPage.Controls.Add(this.UpdLogPassButton);
            this.UserDataPage.Controls.Add(this.CreateUserFIOButton);
            this.UserDataPage.Controls.Add(this.PasswordInfoLabel);
            this.UserDataPage.Controls.Add(this.SurnameInfoLabel);
            this.UserDataPage.Controls.Add(this.NameInfoLabel);
            this.UserDataPage.Controls.Add(this.FamInfoLabel);
            this.UserDataPage.Controls.Add(this.InfoUserLabel);
            this.UserDataPage.Controls.Add(this.PassCreaUpdaTextBox);
            this.UserDataPage.Controls.Add(this.PatrCreateTextBox);
            this.UserDataPage.Controls.Add(this.NameCreateTextBox);
            this.UserDataPage.Controls.Add(this.FamCreateTextBox);
            this.UserDataPage.Location = new System.Drawing.Point(4, 24);
            this.UserDataPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserDataPage.Name = "UserDataPage";
            this.UserDataPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserDataPage.Size = new System.Drawing.Size(750, 420);
            this.UserDataPage.TabIndex = 2;
            this.UserDataPage.Text = "Данные о пользователе";
            this.UserDataPage.UseVisualStyleBackColor = true;
            // 
            // PasswordInfoLabel
            // 
            this.PasswordInfoLabel.AutoSize = true;
            this.PasswordInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordInfoLabel.Location = new System.Drawing.Point(384, 81);
            this.PasswordInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordInfoLabel.Name = "PasswordInfoLabel";
            this.PasswordInfoLabel.Size = new System.Drawing.Size(71, 21);
            this.PasswordInfoLabel.TabIndex = 16;
            this.PasswordInfoLabel.Text = "Пароль:";
            // 
            // SurnameInfoLabel
            // 
            this.SurnameInfoLabel.AutoSize = true;
            this.SurnameInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SurnameInfoLabel.Location = new System.Drawing.Point(167, 201);
            this.SurnameInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SurnameInfoLabel.Name = "SurnameInfoLabel";
            this.SurnameInfoLabel.Size = new System.Drawing.Size(85, 21);
            this.SurnameInfoLabel.TabIndex = 14;
            this.SurnameInfoLabel.Text = "Отчество:";
            // 
            // NameInfoLabel
            // 
            this.NameInfoLabel.AutoSize = true;
            this.NameInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.NameInfoLabel.Location = new System.Drawing.Point(167, 141);
            this.NameInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameInfoLabel.Name = "NameInfoLabel";
            this.NameInfoLabel.Size = new System.Drawing.Size(47, 21);
            this.NameInfoLabel.TabIndex = 13;
            this.NameInfoLabel.Text = "Имя:";
            // 
            // FamInfoLabel
            // 
            this.FamInfoLabel.AutoSize = true;
            this.FamInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FamInfoLabel.Location = new System.Drawing.Point(167, 81);
            this.FamInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FamInfoLabel.Name = "FamInfoLabel";
            this.FamInfoLabel.Size = new System.Drawing.Size(84, 21);
            this.FamInfoLabel.TabIndex = 12;
            this.FamInfoLabel.Text = "Фамилия:";
            // 
            // InfoUserLabel
            // 
            this.InfoUserLabel.AutoSize = true;
            this.InfoUserLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoUserLabel.Location = new System.Drawing.Point(184, 26);
            this.InfoUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoUserLabel.Name = "InfoUserLabel";
            this.InfoUserLabel.Size = new System.Drawing.Size(348, 32);
            this.InfoUserLabel.TabIndex = 11;
            this.InfoUserLabel.Text = "Информация о пользователе";
            // 
            // UpdateDataInDGW
            // 
            this.UpdateDataInDGW.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateDataInDGW.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.UpdateDataInDGW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.UpdateDataInDGW.BorderRadius = 0;
            this.UpdateDataInDGW.BorderSize = 0;
            this.UpdateDataInDGW.FlatAppearance.BorderSize = 0;
            this.UpdateDataInDGW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDataInDGW.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateDataInDGW.ForeColor = System.Drawing.Color.White;
            this.UpdateDataInDGW.Location = new System.Drawing.Point(328, 7);
            this.UpdateDataInDGW.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateDataInDGW.Name = "UpdateDataInDGW";
            this.UpdateDataInDGW.Size = new System.Drawing.Size(155, 35);
            this.UpdateDataInDGW.TabIndex = 13;
            this.UpdateDataInDGW.Text = "Обновить данные";
            this.UpdateDataInDGW.TextColor = System.Drawing.Color.White;
            this.UpdateDataInDGW.UseVisualStyleBackColor = false;
            this.UpdateDataInDGW.Click += new System.EventHandler(this.UpdateDataInDGW_Click);
            // 
            // DeleteApplicationButton
            // 
            this.DeleteApplicationButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteApplicationButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.DeleteApplicationButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DeleteApplicationButton.BorderRadius = 0;
            this.DeleteApplicationButton.BorderSize = 0;
            this.DeleteApplicationButton.FlatAppearance.BorderSize = 0;
            this.DeleteApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteApplicationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteApplicationButton.ForeColor = System.Drawing.Color.White;
            this.DeleteApplicationButton.Location = new System.Drawing.Point(220, 7);
            this.DeleteApplicationButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteApplicationButton.Name = "DeleteApplicationButton";
            this.DeleteApplicationButton.Size = new System.Drawing.Size(100, 35);
            this.DeleteApplicationButton.TabIndex = 12;
            this.DeleteApplicationButton.Text = "Удалить";
            this.DeleteApplicationButton.TextColor = System.Drawing.Color.White;
            this.DeleteApplicationButton.UseVisualStyleBackColor = false;
            // 
            // ModifyApplicationButton
            // 
            this.ModifyApplicationButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ModifyApplicationButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.ModifyApplicationButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.ModifyApplicationButton.BorderRadius = 0;
            this.ModifyApplicationButton.BorderSize = 0;
            this.ModifyApplicationButton.FlatAppearance.BorderSize = 0;
            this.ModifyApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyApplicationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ModifyApplicationButton.ForeColor = System.Drawing.Color.White;
            this.ModifyApplicationButton.Location = new System.Drawing.Point(112, 7);
            this.ModifyApplicationButton.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyApplicationButton.Name = "ModifyApplicationButton";
            this.ModifyApplicationButton.Size = new System.Drawing.Size(100, 35);
            this.ModifyApplicationButton.TabIndex = 11;
            this.ModifyApplicationButton.Text = "Изменить";
            this.ModifyApplicationButton.TextColor = System.Drawing.Color.White;
            this.ModifyApplicationButton.UseVisualStyleBackColor = false;
            // 
            // CreateApplicationButton
            // 
            this.CreateApplicationButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CreateApplicationButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.CreateApplicationButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CreateApplicationButton.BorderRadius = 0;
            this.CreateApplicationButton.BorderSize = 0;
            this.CreateApplicationButton.FlatAppearance.BorderSize = 0;
            this.CreateApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateApplicationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateApplicationButton.ForeColor = System.Drawing.Color.White;
            this.CreateApplicationButton.Location = new System.Drawing.Point(4, 7);
            this.CreateApplicationButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateApplicationButton.Name = "CreateApplicationButton";
            this.CreateApplicationButton.Size = new System.Drawing.Size(100, 35);
            this.CreateApplicationButton.TabIndex = 10;
            this.CreateApplicationButton.Text = "Создать";
            this.CreateApplicationButton.TextColor = System.Drawing.Color.White;
            this.CreateApplicationButton.UseVisualStyleBackColor = false;
            this.CreateApplicationButton.Click += new System.EventHandler(this.CreateApplicationButton_Click);
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
            this.UpdLogPassButton.Location = new System.Drawing.Point(424, 149);
            this.UpdLogPassButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdLogPassButton.Name = "UpdLogPassButton";
            this.UpdLogPassButton.Size = new System.Drawing.Size(110, 44);
            this.UpdLogPassButton.TabIndex = 20;
            this.UpdLogPassButton.Text = "Изменить";
            this.UpdLogPassButton.TextColor = System.Drawing.Color.White;
            this.UpdLogPassButton.UseVisualStyleBackColor = false;
            this.UpdLogPassButton.Click += new System.EventHandler(this.UpdLogPassButton_Click);
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
            this.CreateUserFIOButton.Location = new System.Drawing.Point(208, 270);
            this.CreateUserFIOButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateUserFIOButton.Name = "CreateUserFIOButton";
            this.CreateUserFIOButton.Size = new System.Drawing.Size(110, 44);
            this.CreateUserFIOButton.TabIndex = 19;
            this.CreateUserFIOButton.Text = "Внести";
            this.CreateUserFIOButton.TextColor = System.Drawing.Color.White;
            this.CreateUserFIOButton.UseVisualStyleBackColor = false;
            this.CreateUserFIOButton.Click += new System.EventHandler(this.CreateUserFIOButton_Click);
            // 
            // PassCreaUpdaTextBox
            // 
            this.PassCreaUpdaTextBox.BackColor = System.Drawing.Color.White;
            this.PassCreaUpdaTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PassCreaUpdaTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.PassCreaUpdaTextBox.BorderSize = 2;
            this.PassCreaUpdaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PassCreaUpdaTextBox.ForeColor = System.Drawing.Color.Black;
            this.PassCreaUpdaTextBox.Location = new System.Drawing.Point(388, 106);
            this.PassCreaUpdaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PassCreaUpdaTextBox.Multiline = false;
            this.PassCreaUpdaTextBox.Name = "PassCreaUpdaTextBox";
            this.PassCreaUpdaTextBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PassCreaUpdaTextBox.PasswordChar = false;
            this.PassCreaUpdaTextBox.Size = new System.Drawing.Size(179, 30);
            this.PassCreaUpdaTextBox.TabIndex = 9;
            this.PassCreaUpdaTextBox.Texts = "";
            this.PassCreaUpdaTextBox.UnderlinedStyle = false;
            // 
            // PatrCreateTextBox
            // 
            this.PatrCreateTextBox.BackColor = System.Drawing.Color.White;
            this.PatrCreateTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PatrCreateTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.PatrCreateTextBox.BorderSize = 2;
            this.PatrCreateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PatrCreateTextBox.ForeColor = System.Drawing.Color.Black;
            this.PatrCreateTextBox.Location = new System.Drawing.Point(171, 227);
            this.PatrCreateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PatrCreateTextBox.Multiline = false;
            this.PatrCreateTextBox.Name = "PatrCreateTextBox";
            this.PatrCreateTextBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PatrCreateTextBox.PasswordChar = false;
            this.PatrCreateTextBox.Size = new System.Drawing.Size(179, 30);
            this.PatrCreateTextBox.TabIndex = 8;
            this.PatrCreateTextBox.Texts = "";
            this.PatrCreateTextBox.UnderlinedStyle = false;
            // 
            // NameCreateTextBox
            // 
            this.NameCreateTextBox.BackColor = System.Drawing.Color.White;
            this.NameCreateTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.NameCreateTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.NameCreateTextBox.BorderSize = 2;
            this.NameCreateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.NameCreateTextBox.ForeColor = System.Drawing.Color.Black;
            this.NameCreateTextBox.Location = new System.Drawing.Point(171, 166);
            this.NameCreateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameCreateTextBox.Multiline = false;
            this.NameCreateTextBox.Name = "NameCreateTextBox";
            this.NameCreateTextBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NameCreateTextBox.PasswordChar = false;
            this.NameCreateTextBox.Size = new System.Drawing.Size(179, 30);
            this.NameCreateTextBox.TabIndex = 7;
            this.NameCreateTextBox.Texts = "";
            this.NameCreateTextBox.UnderlinedStyle = false;
            // 
            // FamCreateTextBox
            // 
            this.FamCreateTextBox.BackColor = System.Drawing.Color.White;
            this.FamCreateTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.FamCreateTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.FamCreateTextBox.BorderSize = 2;
            this.FamCreateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.FamCreateTextBox.ForeColor = System.Drawing.Color.Black;
            this.FamCreateTextBox.Location = new System.Drawing.Point(171, 106);
            this.FamCreateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FamCreateTextBox.Multiline = false;
            this.FamCreateTextBox.Name = "FamCreateTextBox";
            this.FamCreateTextBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.FamCreateTextBox.PasswordChar = false;
            this.FamCreateTextBox.Size = new System.Drawing.Size(179, 30);
            this.FamCreateTextBox.TabIndex = 6;
            this.FamCreateTextBox.Texts = "";
            this.FamCreateTextBox.UnderlinedStyle = false;
            // 
            // CustomFormForAllProject
            // 
            this.CustomFormForAllProject.Form = this;
            this.CustomFormForAllProject.FormStyle = Napitki_Altay2.DesignComponents.CustomForm.fStyle.None;
            // 
            // MainWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 456);
            this.Controls.Add(this.MainWorkTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Напитки Алтая";
            this.Load += new System.EventHandler(this.MainWorkForm_Load);
            this.MainWorkTabControl.ResumeLayout(false);
            this.ApplicationPage.ResumeLayout(false);
            this.ApplicationPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewApplication)).EndInit();
            this.UserDataPage.ResumeLayout(false);
            this.UserDataPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DesignComponents.CustomForm CustomFormForAllProject;
        private System.Windows.Forms.TabControl MainWorkTabControl;
        private System.Windows.Forms.TabPage ApplicationPage;
        private System.Windows.Forms.TabPage DocPage;
        private System.Windows.Forms.TabPage UserDataPage;
        private System.Windows.Forms.DataGridView DataGridViewApplication;
        private Design.CustomButton DeleteApplicationButton;
        private Design.CustomButton ModifyApplicationButton;
        private Design.CustomButton CreateApplicationButton;
        private Design.CustomButton UpdateDataInDGW;
        private System.Windows.Forms.Label InfoUserLabel;
        private Design.CustomTextBox PassCreaUpdaTextBox;
        private Design.CustomTextBox PatrCreateTextBox;
        private Design.CustomTextBox NameCreateTextBox;
        private Design.CustomTextBox FamCreateTextBox;
        private System.Windows.Forms.Label FamInfoLabel;
        private System.Windows.Forms.Label NameInfoLabel;
        private System.Windows.Forms.Label SurnameInfoLabel;
        private System.Windows.Forms.Label PasswordInfoLabel;
        private Design.CustomButton UpdLogPassButton;
        private Design.CustomButton CreateUserFIOButton;
        private System.Windows.Forms.Label InfoApplicationLabel;
    }
}