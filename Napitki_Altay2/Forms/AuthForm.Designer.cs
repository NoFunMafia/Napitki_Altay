namespace Napitki_Altay2
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.DetailsPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginPictureBox = new System.Windows.Forms.PictureBox();
            this.OpenFormRegistration = new System.Windows.Forms.LinkLabel();
            this.VisiblePassCheck = new System.Windows.Forms.CheckBox();
            this.LoginAdminLabel = new System.Windows.Forms.Label();
            this.LogInAppButton = new Napitki_Altay2.Design.CustomButton();
            this.PasswordTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.LoginTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DetailsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailsPictureBox
            // 
            this.DetailsPictureBox.Image = global::Napitki_Altay2.Properties.Resources.Лента_флага;
            this.DetailsPictureBox.Location = new System.Drawing.Point(3, 605);
            this.DetailsPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DetailsPictureBox.Name = "DetailsPictureBox";
            this.DetailsPictureBox.Size = new System.Drawing.Size(686, 200);
            this.DetailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DetailsPictureBox.TabIndex = 4;
            this.DetailsPictureBox.TabStop = false;
            // 
            // LoginPictureBox
            // 
            this.LoginPictureBox.BackColor = System.Drawing.Color.White;
            this.LoginPictureBox.Image = global::Napitki_Altay2.Properties.Resources.Герб_Алтайского_края;
            this.LoginPictureBox.Location = new System.Drawing.Point(242, 34);
            this.LoginPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginPictureBox.Name = "LoginPictureBox";
            this.LoginPictureBox.Size = new System.Drawing.Size(208, 200);
            this.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPictureBox.TabIndex = 3;
            this.LoginPictureBox.TabStop = false;
            // 
            // OpenFormRegistration
            // 
            this.OpenFormRegistration.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.OpenFormRegistration.AutoSize = true;
            this.OpenFormRegistration.Font = new System.Drawing.Font("Segoe UI Variable Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFormRegistration.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.OpenFormRegistration.Location = new System.Drawing.Point(217, 598);
            this.OpenFormRegistration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpenFormRegistration.Name = "OpenFormRegistration";
            this.OpenFormRegistration.Size = new System.Drawing.Size(246, 28);
            this.OpenFormRegistration.TabIndex = 5;
            this.OpenFormRegistration.TabStop = true;
            this.OpenFormRegistration.Text = "Нет аккаунта? Создайте!";
            this.OpenFormRegistration.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.OpenFormRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenFormRegistration_LinkClicked);
            // 
            // VisiblePassCheck
            // 
            this.VisiblePassCheck.AutoSize = true;
            this.VisiblePassCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisiblePassCheck.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisiblePassCheck.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.VisiblePassCheck.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisiblePassCheck.Location = new System.Drawing.Point(537, 436);
            this.VisiblePassCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VisiblePassCheck.Name = "VisiblePassCheck";
            this.VisiblePassCheck.Size = new System.Drawing.Size(146, 36);
            this.VisiblePassCheck.TabIndex = 6;
            this.VisiblePassCheck.Text = "Показать";
            this.VisiblePassCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VisiblePassCheck.UseVisualStyleBackColor = true;
            this.VisiblePassCheck.CheckedChanged += new System.EventHandler(this.Visible_Pass_Check_CheckedChanged);
            // 
            // LoginAdminLabel
            // 
            this.LoginAdminLabel.AutoSize = true;
            this.LoginAdminLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.LoginAdminLabel.Location = new System.Drawing.Point(17, 239);
            this.LoginAdminLabel.Name = "LoginAdminLabel";
            this.LoginAdminLabel.Size = new System.Drawing.Size(662, 92);
            this.LoginAdminLabel.TabIndex = 7;
            this.LoginAdminLabel.Text = "Администрация Волчихинского района \r\nАлтайского края";
            this.LoginAdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogInAppButton
            // 
            this.LogInAppButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.LogInAppButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.LogInAppButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(65)))), ((int)(((byte)(26)))));
            this.LogInAppButton.BorderRadius = 5;
            this.LogInAppButton.BorderSize = 0;
            this.LogInAppButton.FlatAppearance.BorderSize = 0;
            this.LogInAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInAppButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInAppButton.ForeColor = System.Drawing.Color.White;
            this.LogInAppButton.Location = new System.Drawing.Point(251, 504);
            this.LogInAppButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogInAppButton.Name = "LogInAppButton";
            this.LogInAppButton.Size = new System.Drawing.Size(189, 84);
            this.LogInAppButton.TabIndex = 2;
            this.LogInAppButton.Text = "Войти";
            this.LogInAppButton.TextColor = System.Drawing.Color.White;
            this.LogInAppButton.UseVisualStyleBackColor = false;
            this.LogInAppButton.Click += new System.EventHandler(this.LogInAppButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.PasswordTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.PasswordTextBox.BorderSize = 2;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTextBox.Location = new System.Drawing.Point(167, 424);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.PasswordTextBox.PasswordChar = false;
            this.PasswordTextBox.ReadOnly = false;
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.Size = new System.Drawing.Size(358, 60);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Texts = "Пароль";
            this.PasswordTextBox.UnderlinedStyle = false;
            this.PasswordTextBox.Enter += new System.EventHandler(this.User_Enter_In_TextBox_Pass);
            this.PasswordTextBox.Leave += new System.EventHandler(this.User_Leave_From_TextBox_Pass);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.White;
            this.LoginTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.LoginTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.LoginTextBox.BorderSize = 2;
            this.LoginTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            this.LoginTextBox.ForeColor = System.Drawing.Color.Black;
            this.LoginTextBox.Location = new System.Drawing.Point(167, 341);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.LoginTextBox.Multiline = false;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.LoginTextBox.PasswordChar = false;
            this.LoginTextBox.ReadOnly = false;
            this.LoginTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LoginTextBox.SelectionStart = 0;
            this.LoginTextBox.Size = new System.Drawing.Size(358, 60);
            this.LoginTextBox.TabIndex = 0;
            this.LoginTextBox.Texts = "Логин";
            this.LoginTextBox.UnderlinedStyle = false;
            this.LoginTextBox.Enter += new System.EventHandler(this.User_Enter_In_TextBox_Login);
            this.LoginTextBox.Leave += new System.EventHandler(this.User_Leave_From_TextBox_Login);
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
            this.CustomFormForAllProject.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 806);
            this.Controls.Add(this.LoginAdminLabel);
            this.Controls.Add(this.VisiblePassCheck);
            this.Controls.Add(this.OpenFormRegistration);
            this.Controls.Add(this.LogInAppButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginPictureBox);
            this.Controls.Add(this.DetailsPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.DetailsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Components.FormStyleCustom CustomFormForAllProject;
        private Design.CustomTextBox PasswordTextBox;
        private Design.CustomTextBox LoginTextBox;
        private Design.CustomButton LogInAppButton;
        private System.Windows.Forms.PictureBox LoginPictureBox;
        private System.Windows.Forms.PictureBox DetailsPictureBox;
        private System.Windows.Forms.LinkLabel OpenFormRegistration;
        private System.Windows.Forms.CheckBox VisiblePassCheck;
        private System.Windows.Forms.Label LoginAdminLabel;
    }
}

