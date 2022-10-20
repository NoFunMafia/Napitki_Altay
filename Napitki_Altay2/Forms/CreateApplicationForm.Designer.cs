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
            this.CustomFormForAllProject = new Napitki_Altay2.DesignComponents.CustomForm(this.components);
            this.SuspendLayout();
            // 
            // CustomFormForAllProject
            // 
            this.CustomFormForAllProject.Form = this;
            this.CustomFormForAllProject.FormStyle = Napitki_Altay2.DesignComponents.CustomForm.fStyle.None;
            // 
            // CreateApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 432);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание заявки";
            this.ResumeLayout(false);

        }

        #endregion

        private DesignComponents.CustomForm CustomFormForAllProject;
    }
}