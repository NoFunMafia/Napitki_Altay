namespace Napitki_Altay2.Forms
{
    partial class AnswerToUserApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnswerToUserApplicationForm));
            this.DateTimeAnsDescrWorkLabel = new System.Windows.Forms.Label();
            this.DescripApplWorkLabel = new System.Windows.Forms.Label();
            this.StatusApplicationLabel = new System.Windows.Forms.Label();
            this.ApplAnsWorkDTP = new System.Windows.Forms.DateTimePicker();
            this.ApplPictureBox = new System.Windows.Forms.PictureBox();
            this.SelectAnsWorkDocumentLabel = new System.Windows.Forms.Label();
            this.ChooseStatusApplPictureBox = new System.Windows.Forms.PictureBox();
            this.TypeApplWorkMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.расИзакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отказаноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.HelpThanksButton = new Napitki_Altay2.Design.CustomButton();
            this.HelpDiscussionButton = new Napitki_Altay2.Design.CustomButton();
            this.HelpCollaborationButton = new Napitki_Altay2.Design.CustomButton();
            this.DeleteAnsWorkDocumentButton = new Napitki_Altay2.Design.CustomButton();
            this.ChooseAnsWorkDocumentButton = new Napitki_Altay2.Design.CustomButton();
            this.AnswerApplButton = new Napitki_Altay2.Design.CustomButton();
            this.CloseAnsButton = new Napitki_Altay2.Design.CustomButton();
            this.DescripWorkAnsTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.StatusApplicationTextBox = new Napitki_Altay2.Design.CustomTextBox();
            this.CustomFormForAllProject = new Napitki_Altay2.Components.FormStyleCustom(this.components);
            this.AdministrationLabel = new System.Windows.Forms.Label();
            this.DocumentListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ApplPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseStatusApplPictureBox)).BeginInit();
            this.TypeApplWorkMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateTimeAnsDescrWorkLabel
            // 
            this.DateTimeAnsDescrWorkLabel.AutoSize = true;
            this.DateTimeAnsDescrWorkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DateTimeAnsDescrWorkLabel.Location = new System.Drawing.Point(30, 1487);
            this.DateTimeAnsDescrWorkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateTimeAnsDescrWorkLabel.Name = "DateTimeAnsDescrWorkLabel";
            this.DateTimeAnsDescrWorkLabel.Size = new System.Drawing.Size(442, 45);
            this.DateTimeAnsDescrWorkLabel.TabIndex = 45;
            this.DateTimeAnsDescrWorkLabel.Text = "Время ответа на заявление:";
            // 
            // DescripApplWorkLabel
            // 
            this.DescripApplWorkLabel.AutoSize = true;
            this.DescripApplWorkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DescripApplWorkLabel.Location = new System.Drawing.Point(30, 735);
            this.DescripApplWorkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescripApplWorkLabel.Name = "DescripApplWorkLabel";
            this.DescripApplWorkLabel.Size = new System.Drawing.Size(326, 45);
            this.DescripApplWorkLabel.TabIndex = 44;
            this.DescripApplWorkLabel.Text = "Ответ на заявление:";
            // 
            // StatusApplicationLabel
            // 
            this.StatusApplicationLabel.AutoSize = true;
            this.StatusApplicationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.StatusApplicationLabel.Location = new System.Drawing.Point(33, 530);
            this.StatusApplicationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusApplicationLabel.Name = "StatusApplicationLabel";
            this.StatusApplicationLabel.Size = new System.Drawing.Size(290, 45);
            this.StatusApplicationLabel.TabIndex = 42;
            this.StatusApplicationLabel.Text = "Статус заявления:";
            // 
            // ApplAnsWorkDTP
            // 
            this.ApplAnsWorkDTP.Enabled = false;
            this.ApplAnsWorkDTP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplAnsWorkDTP.Location = new System.Drawing.Point(38, 1540);
            this.ApplAnsWorkDTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ApplAnsWorkDTP.Name = "ApplAnsWorkDTP";
            this.ApplAnsWorkDTP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ApplAnsWorkDTP.Size = new System.Drawing.Size(426, 56);
            this.ApplAnsWorkDTP.TabIndex = 41;
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
            this.ApplPictureBox.TabIndex = 37;
            this.ApplPictureBox.TabStop = false;
            // 
            // SelectAnsWorkDocumentLabel
            // 
            this.SelectAnsWorkDocumentLabel.AutoSize = true;
            this.SelectAnsWorkDocumentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SelectAnsWorkDocumentLabel.Location = new System.Drawing.Point(715, 67);
            this.SelectAnsWorkDocumentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectAnsWorkDocumentLabel.Name = "SelectAnsWorkDocumentLabel";
            this.SelectAnsWorkDocumentLabel.Size = new System.Drawing.Size(658, 45);
            this.SelectAnsWorkDocumentLabel.TabIndex = 53;
            this.SelectAnsWorkDocumentLabel.Text = "Прикрепить файл к ответу на обращение:";
            // 
            // ChooseStatusApplPictureBox
            // 
            this.ChooseStatusApplPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseStatusApplPictureBox.Image = global::Napitki_Altay2.Properties.Resources.PictureRegForm;
            this.ChooseStatusApplPictureBox.Location = new System.Drawing.Point(561, 588);
            this.ChooseStatusApplPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChooseStatusApplPictureBox.Name = "ChooseStatusApplPictureBox";
            this.ChooseStatusApplPictureBox.Size = new System.Drawing.Size(48, 42);
            this.ChooseStatusApplPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChooseStatusApplPictureBox.TabIndex = 54;
            this.ChooseStatusApplPictureBox.TabStop = false;
            this.ChooseStatusApplPictureBox.Click += new System.EventHandler(this.ChooseStatusApplPictureBox_Click);
            // 
            // TypeApplWorkMenuStrip
            // 
            this.TypeApplWorkMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.TypeApplWorkMenuStrip.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            this.TypeApplWorkMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TypeApplWorkMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расИзакToolStripMenuItem,
            this.отказаноToolStripMenuItem});
            this.TypeApplWorkMenuStrip.Name = "TypeApplWorkMenuStrip";
            this.TypeApplWorkMenuStrip.Size = new System.Drawing.Size(426, 136);
            // 
            // расИзакToolStripMenuItem
            // 
            this.расИзакToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.расИзакToolStripMenuItem.Name = "расИзакToolStripMenuItem";
            this.расИзакToolStripMenuItem.Size = new System.Drawing.Size(425, 44);
            this.расИзакToolStripMenuItem.Text = "Рассмотрено и закрыто";
            this.расИзакToolStripMenuItem.Click += new System.EventHandler(this.РасИЗакToolStripMenuItem_Click);
            // 
            // отказаноToolStripMenuItem
            // 
            this.отказаноToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(20)))), ((int)(((byte)(1)))));
            this.отказаноToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.отказаноToolStripMenuItem.Name = "отказаноToolStripMenuItem";
            this.отказаноToolStripMenuItem.Size = new System.Drawing.Size(425, 44);
            this.отказаноToolStripMenuItem.Text = "Отказано в рассмотрении";
            this.отказаноToolStripMenuItem.Click += new System.EventHandler(this.ОтказаноToolStripMenuItem_Click);
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.HelpLabel.Location = new System.Drawing.Point(709, 1487);
            this.HelpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(640, 45);
            this.HelpLabel.TabIndex = 56;
            this.HelpLabel.Text = "Макеты для формирования документов:";
            // 
            // HelpThanksButton
            // 
            this.HelpThanksButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.HelpThanksButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.HelpThanksButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.HelpThanksButton.BorderRadius = 0;
            this.HelpThanksButton.BorderSize = 0;
            this.HelpThanksButton.FlatAppearance.BorderSize = 0;
            this.HelpThanksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpThanksButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.HelpThanksButton.ForeColor = System.Drawing.Color.White;
            this.HelpThanksButton.Location = new System.Drawing.Point(1247, 1535);
            this.HelpThanksButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HelpThanksButton.Name = "HelpThanksButton";
            this.HelpThanksButton.Size = new System.Drawing.Size(256, 81);
            this.HelpThanksButton.TabIndex = 58;
            this.HelpThanksButton.Text = "Письмо-претензия";
            this.HelpThanksButton.TextColor = System.Drawing.Color.White;
            this.HelpThanksButton.UseVisualStyleBackColor = false;
            this.HelpThanksButton.Click += new System.EventHandler(this.HelpThanksButton_Click);
            // 
            // HelpDiscussionButton
            // 
            this.HelpDiscussionButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.HelpDiscussionButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.HelpDiscussionButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.HelpDiscussionButton.BorderRadius = 0;
            this.HelpDiscussionButton.BorderSize = 0;
            this.HelpDiscussionButton.FlatAppearance.BorderSize = 0;
            this.HelpDiscussionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpDiscussionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.HelpDiscussionButton.ForeColor = System.Drawing.Color.White;
            this.HelpDiscussionButton.Location = new System.Drawing.Point(981, 1535);
            this.HelpDiscussionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HelpDiscussionButton.Name = "HelpDiscussionButton";
            this.HelpDiscussionButton.Size = new System.Drawing.Size(256, 81);
            this.HelpDiscussionButton.TabIndex = 57;
            this.HelpDiscussionButton.Text = "Письмо-\r\n-благодарность";
            this.HelpDiscussionButton.TextColor = System.Drawing.Color.White;
            this.HelpDiscussionButton.UseVisualStyleBackColor = false;
            this.HelpDiscussionButton.Click += new System.EventHandler(this.HelpDiscussionButton_Click);
            // 
            // HelpCollaborationButton
            // 
            this.HelpCollaborationButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.HelpCollaborationButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.HelpCollaborationButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.HelpCollaborationButton.BorderRadius = 0;
            this.HelpCollaborationButton.BorderSize = 0;
            this.HelpCollaborationButton.FlatAppearance.BorderSize = 0;
            this.HelpCollaborationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpCollaborationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.HelpCollaborationButton.ForeColor = System.Drawing.Color.White;
            this.HelpCollaborationButton.Location = new System.Drawing.Point(716, 1535);
            this.HelpCollaborationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HelpCollaborationButton.Name = "HelpCollaborationButton";
            this.HelpCollaborationButton.Size = new System.Drawing.Size(256, 81);
            this.HelpCollaborationButton.TabIndex = 55;
            this.HelpCollaborationButton.Text = "Сотрудничество";
            this.HelpCollaborationButton.TextColor = System.Drawing.Color.White;
            this.HelpCollaborationButton.UseVisualStyleBackColor = false;
            this.HelpCollaborationButton.Click += new System.EventHandler(this.HelpCollaborationButton_Click);
            // 
            // DeleteAnsWorkDocumentButton
            // 
            this.DeleteAnsWorkDocumentButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteAnsWorkDocumentButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.DeleteAnsWorkDocumentButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DeleteAnsWorkDocumentButton.BorderRadius = 0;
            this.DeleteAnsWorkDocumentButton.BorderSize = 0;
            this.DeleteAnsWorkDocumentButton.FlatAppearance.BorderSize = 0;
            this.DeleteAnsWorkDocumentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAnsWorkDocumentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAnsWorkDocumentButton.ForeColor = System.Drawing.Color.White;
            this.DeleteAnsWorkDocumentButton.Location = new System.Drawing.Point(1216, 669);
            this.DeleteAnsWorkDocumentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteAnsWorkDocumentButton.Name = "DeleteAnsWorkDocumentButton";
            this.DeleteAnsWorkDocumentButton.Size = new System.Drawing.Size(307, 88);
            this.DeleteAnsWorkDocumentButton.TabIndex = 52;
            this.DeleteAnsWorkDocumentButton.Text = "Удалить файлы";
            this.DeleteAnsWorkDocumentButton.TextColor = System.Drawing.Color.White;
            this.DeleteAnsWorkDocumentButton.UseVisualStyleBackColor = false;
            this.DeleteAnsWorkDocumentButton.Click += new System.EventHandler(this.DeleteAnsWorkDocumentButton_Click);
            // 
            // ChooseAnsWorkDocumentButton
            // 
            this.ChooseAnsWorkDocumentButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ChooseAnsWorkDocumentButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.ChooseAnsWorkDocumentButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.ChooseAnsWorkDocumentButton.BorderRadius = 0;
            this.ChooseAnsWorkDocumentButton.BorderSize = 0;
            this.ChooseAnsWorkDocumentButton.FlatAppearance.BorderSize = 0;
            this.ChooseAnsWorkDocumentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseAnsWorkDocumentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseAnsWorkDocumentButton.ForeColor = System.Drawing.Color.White;
            this.ChooseAnsWorkDocumentButton.Location = new System.Drawing.Point(783, 669);
            this.ChooseAnsWorkDocumentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChooseAnsWorkDocumentButton.Name = "ChooseAnsWorkDocumentButton";
            this.ChooseAnsWorkDocumentButton.Size = new System.Drawing.Size(307, 88);
            this.ChooseAnsWorkDocumentButton.TabIndex = 51;
            this.ChooseAnsWorkDocumentButton.Text = "Выбрать файлы";
            this.ChooseAnsWorkDocumentButton.TextColor = System.Drawing.Color.White;
            this.ChooseAnsWorkDocumentButton.UseVisualStyleBackColor = false;
            this.ChooseAnsWorkDocumentButton.Click += new System.EventHandler(this.ChooseAnsWorkDocumentButton_Click);
            // 
            // AnswerApplButton
            // 
            this.AnswerApplButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AnswerApplButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.AnswerApplButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.AnswerApplButton.BorderRadius = 0;
            this.AnswerApplButton.BorderSize = 0;
            this.AnswerApplButton.FlatAppearance.BorderSize = 0;
            this.AnswerApplButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerApplButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerApplButton.ForeColor = System.Drawing.Color.White;
            this.AnswerApplButton.Location = new System.Drawing.Point(117, 1730);
            this.AnswerApplButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AnswerApplButton.Name = "AnswerApplButton";
            this.AnswerApplButton.Size = new System.Drawing.Size(598, 128);
            this.AnswerApplButton.TabIndex = 50;
            this.AnswerApplButton.Text = "Ответить на заявление";
            this.AnswerApplButton.TextColor = System.Drawing.Color.White;
            this.AnswerApplButton.UseVisualStyleBackColor = false;
            this.AnswerApplButton.Click += new System.EventHandler(this.AnswerApplButton_Click);
            // 
            // CloseAnsButton
            // 
            this.CloseAnsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CloseAnsButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.CloseAnsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.CloseAnsButton.BorderRadius = 0;
            this.CloseAnsButton.BorderSize = 0;
            this.CloseAnsButton.FlatAppearance.BorderSize = 0;
            this.CloseAnsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAnsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseAnsButton.ForeColor = System.Drawing.Color.White;
            this.CloseAnsButton.Location = new System.Drawing.Point(905, 1730);
            this.CloseAnsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseAnsButton.Name = "CloseAnsButton";
            this.CloseAnsButton.Size = new System.Drawing.Size(598, 128);
            this.CloseAnsButton.TabIndex = 46;
            this.CloseAnsButton.Text = "Закрыть окно ";
            this.CloseAnsButton.TextColor = System.Drawing.Color.White;
            this.CloseAnsButton.UseVisualStyleBackColor = false;
            this.CloseAnsButton.Click += new System.EventHandler(this.CloseApplicWorkButton_Click);
            // 
            // DescripWorkAnsTextBox
            // 
            this.DescripWorkAnsTextBox.BackColor = System.Drawing.Color.White;
            this.DescripWorkAnsTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.DescripWorkAnsTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.DescripWorkAnsTextBox.BorderSize = 2;
            this.DescripWorkAnsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DescripWorkAnsTextBox.ForeColor = System.Drawing.Color.Black;
            this.DescripWorkAnsTextBox.Location = new System.Drawing.Point(41, 795);
            this.DescripWorkAnsTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.DescripWorkAnsTextBox.Multiline = true;
            this.DescripWorkAnsTextBox.Name = "DescripWorkAnsTextBox";
            this.DescripWorkAnsTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.DescripWorkAnsTextBox.PasswordChar = false;
            this.DescripWorkAnsTextBox.ReadOnly = false;
            this.DescripWorkAnsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescripWorkAnsTextBox.SelectionStart = 0;
            this.DescripWorkAnsTextBox.Size = new System.Drawing.Size(1537, 669);
            this.DescripWorkAnsTextBox.TabIndex = 40;
            this.DescripWorkAnsTextBox.Texts = "";
            this.DescripWorkAnsTextBox.UnderlinedStyle = false;
            // 
            // StatusApplicationTextBox
            // 
            this.StatusApplicationTextBox.BackColor = System.Drawing.Color.White;
            this.StatusApplicationTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.StatusApplicationTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.StatusApplicationTextBox.BorderSize = 2;
            this.StatusApplicationTextBox.Enabled = false;
            this.StatusApplicationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.StatusApplicationTextBox.ForeColor = System.Drawing.Color.Black;
            this.StatusApplicationTextBox.Location = new System.Drawing.Point(41, 580);
            this.StatusApplicationTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.StatusApplicationTextBox.Multiline = false;
            this.StatusApplicationTextBox.Name = "StatusApplicationTextBox";
            this.StatusApplicationTextBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.StatusApplicationTextBox.PasswordChar = false;
            this.StatusApplicationTextBox.ReadOnly = false;
            this.StatusApplicationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StatusApplicationTextBox.SelectionStart = 0;
            this.StatusApplicationTextBox.Size = new System.Drawing.Size(574, 55);
            this.StatusApplicationTextBox.TabIndex = 38;
            this.StatusApplicationTextBox.Texts = "";
            this.StatusApplicationTextBox.UnderlinedStyle = false;
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
            this.AdministrationLabel.TabIndex = 59;
            this.AdministrationLabel.Text = "Администрация Волчихинского района \r\nАлтайского края";
            this.AdministrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.DocumentListBox.TabIndex = 60;
            // 
            // AnswerToUserApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1619, 1914);
            this.Controls.Add(this.DocumentListBox);
            this.Controls.Add(this.AdministrationLabel);
            this.Controls.Add(this.HelpThanksButton);
            this.Controls.Add(this.HelpDiscussionButton);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.HelpCollaborationButton);
            this.Controls.Add(this.ChooseStatusApplPictureBox);
            this.Controls.Add(this.SelectAnsWorkDocumentLabel);
            this.Controls.Add(this.DeleteAnsWorkDocumentButton);
            this.Controls.Add(this.ChooseAnsWorkDocumentButton);
            this.Controls.Add(this.AnswerApplButton);
            this.Controls.Add(this.CloseAnsButton);
            this.Controls.Add(this.DateTimeAnsDescrWorkLabel);
            this.Controls.Add(this.DescripApplWorkLabel);
            this.Controls.Add(this.StatusApplicationLabel);
            this.Controls.Add(this.ApplAnsWorkDTP);
            this.Controls.Add(this.DescripWorkAnsTextBox);
            this.Controls.Add(this.StatusApplicationTextBox);
            this.Controls.Add(this.ApplPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnswerToUserApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ответ на заявление пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnswerToUserApplicationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ApplPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseStatusApplPictureBox)).EndInit();
            this.TypeApplWorkMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormStyleCustom CustomFormForAllProject;
        private Design.CustomButton CloseAnsButton;
        private System.Windows.Forms.Label DateTimeAnsDescrWorkLabel;
        private System.Windows.Forms.Label DescripApplWorkLabel;
        private System.Windows.Forms.Label StatusApplicationLabel;
        private System.Windows.Forms.DateTimePicker ApplAnsWorkDTP;
        private Design.CustomTextBox DescripWorkAnsTextBox;
        private Design.CustomTextBox StatusApplicationTextBox;
        private System.Windows.Forms.PictureBox ApplPictureBox;
        private Design.CustomButton AnswerApplButton;
        private Design.CustomButton DeleteAnsWorkDocumentButton;
        private Design.CustomButton ChooseAnsWorkDocumentButton;
        private System.Windows.Forms.Label SelectAnsWorkDocumentLabel;
        private System.Windows.Forms.PictureBox ChooseStatusApplPictureBox;
        private System.Windows.Forms.ContextMenuStrip TypeApplWorkMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem отказаноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расИзакToolStripMenuItem;
        private Design.CustomButton HelpCollaborationButton;
        private Design.CustomButton HelpThanksButton;
        private Design.CustomButton HelpDiscussionButton;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Label AdministrationLabel;
        private System.Windows.Forms.ListBox DocumentListBox;
    }
}