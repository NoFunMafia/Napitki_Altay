namespace Napitki_Altay2.Forms
{
    partial class NoInternetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoInternetForm));
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.NoInternetPictureBox = new System.Windows.Forms.PictureBox();
            this.NoInternetLabel = new System.Windows.Forms.Label();
            this.RestartInternetButton = new Napitki_Altay2.Design.CustomButton();
            this.RestartInternetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NoInternetPictureBox)).BeginInit();
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
            // NoInternetPictureBox
            // 
            this.NoInternetPictureBox.Image = global::Napitki_Altay2.Properties.Resources.PictureLoginForm;
            this.NoInternetPictureBox.Location = new System.Drawing.Point(243, 30);
            this.NoInternetPictureBox.Name = "NoInternetPictureBox";
            this.NoInternetPictureBox.Size = new System.Drawing.Size(239, 210);
            this.NoInternetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NoInternetPictureBox.TabIndex = 0;
            this.NoInternetPictureBox.TabStop = false;
            // 
            // NoInternetLabel
            // 
            this.NoInternetLabel.AutoSize = true;
            this.NoInternetLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoInternetLabel.Location = new System.Drawing.Point(131, 232);
            this.NoInternetLabel.Name = "NoInternetLabel";
            this.NoInternetLabel.Size = new System.Drawing.Size(456, 38);
            this.NoInternetLabel.TabIndex = 1;
            this.NoInternetLabel.Text = "Нет подключения к Интернету :(";
            // 
            // RestartInternetButton
            // 
            this.RestartInternetButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.RestartInternetButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.RestartInternetButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.RestartInternetButton.BorderRadius = 20;
            this.RestartInternetButton.BorderSize = 0;
            this.RestartInternetButton.FlatAppearance.BorderSize = 0;
            this.RestartInternetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartInternetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartInternetButton.ForeColor = System.Drawing.Color.White;
            this.RestartInternetButton.Location = new System.Drawing.Point(243, 354);
            this.RestartInternetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestartInternetButton.Name = "RestartInternetButton";
            this.RestartInternetButton.Size = new System.Drawing.Size(237, 67);
            this.RestartInternetButton.TabIndex = 36;
            this.RestartInternetButton.Text = "Повторить";
            this.RestartInternetButton.TextColor = System.Drawing.Color.White;
            this.RestartInternetButton.UseVisualStyleBackColor = false;
            this.RestartInternetButton.Click += new System.EventHandler(this.RestartInternetButton_Click);
            // 
            // RestartInternetLabel
            // 
            this.RestartInternetLabel.AutoSize = true;
            this.RestartInternetLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.RestartInternetLabel.Location = new System.Drawing.Point(31, 289);
            this.RestartInternetLabel.Name = "RestartInternetLabel";
            this.RestartInternetLabel.Size = new System.Drawing.Size(614, 30);
            this.RestartInternetLabel.TabIndex = 37;
            this.RestartInternetLabel.Text = "Проверьте подключение к Интернету и повторите попытку.";
            // 
            // NoInternetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 482);
            this.Controls.Add(this.RestartInternetLabel);
            this.Controls.Add(this.RestartInternetButton);
            this.Controls.Add(this.NoInternetLabel);
            this.Controls.Add(this.NoInternetPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoInternetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интернет отсутствует";
            ((System.ComponentModel.ISupportInitialize)(this.NoInternetPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormStyleCustom CustomFormForAllProject;
        private System.Windows.Forms.PictureBox NoInternetPictureBox;
        private System.Windows.Forms.Label NoInternetLabel;
        private Design.CustomButton RestartInternetButton;
        private System.Windows.Forms.Label RestartInternetLabel;
    }
}