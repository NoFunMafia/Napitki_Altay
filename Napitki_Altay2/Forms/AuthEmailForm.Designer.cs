namespace Napitki_Altay2.Forms
{
    partial class AuthEmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthEmailForm));
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.AuthEmPictureBox = new System.Windows.Forms.PictureBox();
            this.EnterCodeLabel = new System.Windows.Forms.Label();
            this.EnterCodeTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.EnterCodeButton = new Napitki_Altay2.Design.CustomButton();
            this.CancelCodeButton = new Napitki_Altay2.Design.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.AuthEmPictureBox)).BeginInit();
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
            // AuthEmPictureBox
            // 
            this.AuthEmPictureBox.BackColor = System.Drawing.Color.White;
            this.AuthEmPictureBox.Image = global::Napitki_Altay2.Properties.Resources.Герб_Алтайского_края;
            this.AuthEmPictureBox.Location = new System.Drawing.Point(182, 18);
            this.AuthEmPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AuthEmPictureBox.Name = "AuthEmPictureBox";
            this.AuthEmPictureBox.Size = new System.Drawing.Size(248, 225);
            this.AuthEmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AuthEmPictureBox.TabIndex = 5;
            this.AuthEmPictureBox.TabStop = false;
            // 
            // EnterCodeLabel
            // 
            this.EnterCodeLabel.AutoSize = true;
            this.EnterCodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterCodeLabel.Location = new System.Drawing.Point(18, 247);
            this.EnterCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnterCodeLabel.Name = "EnterCodeLabel";
            this.EnterCodeLabel.Size = new System.Drawing.Size(582, 45);
            this.EnterCodeLabel.TabIndex = 6;
            this.EnterCodeLabel.Text = "Введите код высланный вам на почту:";
            // 
            // EnterCodeTextBox
            // 
            this.EnterCodeTextBox.BackColor = System.Drawing.Color.White;
            this.EnterCodeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.EnterCodeTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.EnterCodeTextBox.BorderSize = 2;
            this.EnterCodeTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            this.EnterCodeTextBox.ForeColor = System.Drawing.Color.Black;
            this.EnterCodeTextBox.Location = new System.Drawing.Point(26, 297);
            this.EnterCodeTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EnterCodeTextBox.Multiline = false;
            this.EnterCodeTextBox.Name = "EnterCodeTextBox";
            this.EnterCodeTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.EnterCodeTextBox.PasswordChar = false;
            this.EnterCodeTextBox.ReadOnly = false;
            this.EnterCodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EnterCodeTextBox.SelectionStart = 0;
            this.EnterCodeTextBox.Size = new System.Drawing.Size(566, 60);
            this.EnterCodeTextBox.TabIndex = 7;
            this.EnterCodeTextBox.Texts = "";
            this.EnterCodeTextBox.UnderlinedStyle = false;
            // 
            // EnterCodeButton
            // 
            this.EnterCodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.EnterCodeButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.EnterCodeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.EnterCodeButton.BorderRadius = 8;
            this.EnterCodeButton.BorderSize = 0;
            this.EnterCodeButton.FlatAppearance.BorderSize = 0;
            this.EnterCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterCodeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterCodeButton.ForeColor = System.Drawing.Color.White;
            this.EnterCodeButton.Location = new System.Drawing.Point(80, 366);
            this.EnterCodeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnterCodeButton.Name = "EnterCodeButton";
            this.EnterCodeButton.Size = new System.Drawing.Size(189, 84);
            this.EnterCodeButton.TabIndex = 10;
            this.EnterCodeButton.Text = "ОК";
            this.EnterCodeButton.TextColor = System.Drawing.Color.White;
            this.EnterCodeButton.UseVisualStyleBackColor = false;
            this.EnterCodeButton.Click += new System.EventHandler(this.EnterCodeButton_Click);
            // 
            // CancelCodeButton
            // 
            this.CancelCodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CancelCodeButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(165)))));
            this.CancelCodeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CancelCodeButton.BorderRadius = 8;
            this.CancelCodeButton.BorderSize = 0;
            this.CancelCodeButton.FlatAppearance.BorderSize = 0;
            this.CancelCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelCodeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelCodeButton.ForeColor = System.Drawing.Color.White;
            this.CancelCodeButton.Location = new System.Drawing.Point(342, 366);
            this.CancelCodeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelCodeButton.Name = "CancelCodeButton";
            this.CancelCodeButton.Size = new System.Drawing.Size(189, 84);
            this.CancelCodeButton.TabIndex = 11;
            this.CancelCodeButton.Text = "Отмена";
            this.CancelCodeButton.TextColor = System.Drawing.Color.White;
            this.CancelCodeButton.UseVisualStyleBackColor = false;
            this.CancelCodeButton.Click += new System.EventHandler(this.CancelCodeButton_Click);
            // 
            // AuthEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 470);
            this.Controls.Add(this.CancelCodeButton);
            this.Controls.Add(this.EnterCodeButton);
            this.Controls.Add(this.EnterCodeTextBox);
            this.Controls.Add(this.EnterCodeLabel);
            this.Controls.Add(this.AuthEmPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AuthEmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подтверждение регистрации";
            ((System.ComponentModel.ISupportInitialize)(this.AuthEmPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormStyleCustom CustomFormForAllProject;
        private System.Windows.Forms.Label EnterCodeLabel;
        private System.Windows.Forms.PictureBox AuthEmPictureBox;
        private Design.CustomTextBox EnterCodeTextBox;
        private Design.CustomButton CancelCodeButton;
        private Design.CustomButton EnterCodeButton;
    }
}