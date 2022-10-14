namespace Napitki_Altay2.Design
{
    partial class CustomTextBox
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxForCustomSetting = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxForCustomSetting
            // 
            this.TextBoxForCustomSetting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxForCustomSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxForCustomSetting.Location = new System.Drawing.Point(7, 7);
            this.TextBoxForCustomSetting.Name = "TextBoxForCustomSetting";
            this.TextBoxForCustomSetting.Size = new System.Drawing.Size(236, 18);
            this.TextBoxForCustomSetting.TabIndex = 0;
            this.TextBoxForCustomSetting.Click += new System.EventHandler(this.TextBoxForCustomSetting_Click);
            this.TextBoxForCustomSetting.TextChanged += new System.EventHandler(this.TextBoxForCustomSetting_TextChanged);
            this.TextBoxForCustomSetting.Enter += new System.EventHandler(this.TextBoxForCustomSetting_Enter);
            this.TextBoxForCustomSetting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxForCustomSetting_KeyPress);
            this.TextBoxForCustomSetting.Leave += new System.EventHandler(this.TextBoxForCustomSetting_Leave);
            this.TextBoxForCustomSetting.MouseEnter += new System.EventHandler(this.TextBoxForCustomSetting_MouseEnter);
            this.TextBoxForCustomSetting.MouseLeave += new System.EventHandler(this.TextBoxForCustomSetting_MouseLeave);
            // 
            // CustomTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.TextBoxForCustomSetting);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomTextBox";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxForCustomSetting;
    }
}
