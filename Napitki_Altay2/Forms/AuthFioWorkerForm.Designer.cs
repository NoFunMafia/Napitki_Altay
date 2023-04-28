namespace Napitki_Altay2.Forms
{
    partial class AuthFioWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthFioWorkerForm));
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.AuthFamPictureBox = new System.Windows.Forms.PictureBox();
            this.EnterFamTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.EnterFamLabel = new System.Windows.Forms.Label();
            this.EnterNameLabel = new System.Windows.Forms.Label();
            this.EnterNameTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.EnterPatrLabel = new System.Windows.Forms.Label();
            this.EnterOtchTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CancelFioButton = new Napitki_Altay2.Design.CustomButton();
            this.EnterFioButton = new Napitki_Altay2.Design.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.AuthFamPictureBox)).BeginInit();
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
            this.CustomFormForAllProject.HeaderColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(48)))), ((int)(((byte)(207)))));
            this.CustomFormForAllProject.HeaderColorGradientEnable = true;
            this.CustomFormForAllProject.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.CustomFormForAllProject.HeaderHeight = 29;
            this.CustomFormForAllProject.HeaderImage = null;
            this.CustomFormForAllProject.HeaderTextColor = System.Drawing.Color.White;
            this.CustomFormForAllProject.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // AuthFamPictureBox
            // 
            this.AuthFamPictureBox.BackColor = System.Drawing.Color.White;
            this.AuthFamPictureBox.Image = global::Napitki_Altay2.Properties.Resources.PictureLoginForm;
            this.AuthFamPictureBox.Location = new System.Drawing.Point(114, 12);
            this.AuthFamPictureBox.Name = "AuthFamPictureBox";
            this.AuthFamPictureBox.Size = new System.Drawing.Size(179, 157);
            this.AuthFamPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AuthFamPictureBox.TabIndex = 6;
            this.AuthFamPictureBox.TabStop = false;
            // 
            // EnterFamTextBox
            // 
            this.EnterFamTextBox.BackColor = System.Drawing.Color.White;
            this.EnterFamTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.EnterFamTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.EnterFamTextBox.BorderSize = 2;
            this.EnterFamTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            this.EnterFamTextBox.ForeColor = System.Drawing.Color.Black;
            this.EnterFamTextBox.Location = new System.Drawing.Point(18, 174);
            this.EnterFamTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnterFamTextBox.Multiline = false;
            this.EnterFamTextBox.Name = "EnterFamTextBox";
            this.EnterFamTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.EnterFamTextBox.PasswordChar = false;
            this.EnterFamTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EnterFamTextBox.SelectionStart = 0;
            this.EnterFamTextBox.Size = new System.Drawing.Size(377, 37);
            this.EnterFamTextBox.TabIndex = 8;
            this.EnterFamTextBox.Texts = "";
            this.EnterFamTextBox.UnderlinedStyle = false;
            // 
            // EnterFamLabel
            // 
            this.EnterFamLabel.AutoSize = true;
            this.EnterFamLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterFamLabel.Location = new System.Drawing.Point(13, 142);
            this.EnterFamLabel.Name = "EnterFamLabel";
            this.EnterFamLabel.Size = new System.Drawing.Size(100, 28);
            this.EnterFamLabel.TabIndex = 9;
            this.EnterFamLabel.Text = "Фамилия:";
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterNameLabel.Location = new System.Drawing.Point(13, 221);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(55, 28);
            this.EnterNameLabel.TabIndex = 11;
            this.EnterNameLabel.Text = "Имя:";
            // 
            // EnterNameTextBox
            // 
            this.EnterNameTextBox.BackColor = System.Drawing.Color.White;
            this.EnterNameTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.EnterNameTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.EnterNameTextBox.BorderSize = 2;
            this.EnterNameTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            this.EnterNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.EnterNameTextBox.Location = new System.Drawing.Point(18, 253);
            this.EnterNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnterNameTextBox.Multiline = false;
            this.EnterNameTextBox.Name = "EnterNameTextBox";
            this.EnterNameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.EnterNameTextBox.PasswordChar = false;
            this.EnterNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EnterNameTextBox.SelectionStart = 0;
            this.EnterNameTextBox.Size = new System.Drawing.Size(377, 37);
            this.EnterNameTextBox.TabIndex = 10;
            this.EnterNameTextBox.Texts = "";
            this.EnterNameTextBox.UnderlinedStyle = false;
            // 
            // EnterPatrLabel
            // 
            this.EnterPatrLabel.AutoSize = true;
            this.EnterPatrLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterPatrLabel.Location = new System.Drawing.Point(13, 300);
            this.EnterPatrLabel.Name = "EnterPatrLabel";
            this.EnterPatrLabel.Size = new System.Drawing.Size(100, 28);
            this.EnterPatrLabel.TabIndex = 13;
            this.EnterPatrLabel.Text = "Отчество:";
            // 
            // EnterOtchTextBox
            // 
            this.EnterOtchTextBox.BackColor = System.Drawing.Color.White;
            this.EnterOtchTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.EnterOtchTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.EnterOtchTextBox.BorderSize = 2;
            this.EnterOtchTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            this.EnterOtchTextBox.ForeColor = System.Drawing.Color.Black;
            this.EnterOtchTextBox.Location = new System.Drawing.Point(18, 332);
            this.EnterOtchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnterOtchTextBox.Multiline = false;
            this.EnterOtchTextBox.Name = "EnterOtchTextBox";
            this.EnterOtchTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.EnterOtchTextBox.PasswordChar = false;
            this.EnterOtchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EnterOtchTextBox.SelectionStart = 0;
            this.EnterOtchTextBox.Size = new System.Drawing.Size(377, 37);
            this.EnterOtchTextBox.TabIndex = 12;
            this.EnterOtchTextBox.Texts = "";
            this.EnterOtchTextBox.UnderlinedStyle = false;
            // 
            // CancelFioButton
            // 
            this.CancelFioButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CancelFioButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.CancelFioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CancelFioButton.BorderRadius = 8;
            this.CancelFioButton.BorderSize = 0;
            this.CancelFioButton.FlatAppearance.BorderSize = 0;
            this.CancelFioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelFioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelFioButton.ForeColor = System.Drawing.Color.White;
            this.CancelFioButton.Location = new System.Drawing.Point(228, 386);
            this.CancelFioButton.Name = "CancelFioButton";
            this.CancelFioButton.Size = new System.Drawing.Size(126, 54);
            this.CancelFioButton.TabIndex = 15;
            this.CancelFioButton.Text = "Отмена";
            this.CancelFioButton.TextColor = System.Drawing.Color.White;
            this.CancelFioButton.UseVisualStyleBackColor = false;
            this.CancelFioButton.Click += new System.EventHandler(this.CancelFioButton_Click);
            // 
            // EnterFioButton
            // 
            this.EnterFioButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.EnterFioButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.EnterFioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.EnterFioButton.BorderRadius = 8;
            this.EnterFioButton.BorderSize = 0;
            this.EnterFioButton.FlatAppearance.BorderSize = 0;
            this.EnterFioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterFioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterFioButton.ForeColor = System.Drawing.Color.White;
            this.EnterFioButton.Location = new System.Drawing.Point(55, 386);
            this.EnterFioButton.Name = "EnterFioButton";
            this.EnterFioButton.Size = new System.Drawing.Size(126, 54);
            this.EnterFioButton.TabIndex = 14;
            this.EnterFioButton.Text = "ОК";
            this.EnterFioButton.TextColor = System.Drawing.Color.White;
            this.EnterFioButton.UseVisualStyleBackColor = false;
            this.EnterFioButton.Click += new System.EventHandler(this.EnterFioButton_Click);
            // 
            // AuthFioWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 455);
            this.Controls.Add(this.CancelFioButton);
            this.Controls.Add(this.EnterFioButton);
            this.Controls.Add(this.EnterPatrLabel);
            this.Controls.Add(this.EnterOtchTextBox);
            this.Controls.Add(this.EnterNameLabel);
            this.Controls.Add(this.EnterNameTextBox);
            this.Controls.Add(this.EnterFamLabel);
            this.Controls.Add(this.EnterFamTextBox);
            this.Controls.Add(this.AuthFamPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthFioWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подтверждение работника";
            ((System.ComponentModel.ISupportInitialize)(this.AuthFamPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormStyleCustom CustomFormForAllProject;
        private System.Windows.Forms.PictureBox AuthFamPictureBox;
        private Design.CustomTextBox EnterFamTextBox;
        private System.Windows.Forms.Label EnterFamLabel;
        private System.Windows.Forms.Label EnterPatrLabel;
        private Design.CustomTextBox EnterOtchTextBox;
        private System.Windows.Forms.Label EnterNameLabel;
        private Design.CustomTextBox EnterNameTextBox;
        private Design.CustomButton CancelFioButton;
        private Design.CustomButton EnterFioButton;
    }
}