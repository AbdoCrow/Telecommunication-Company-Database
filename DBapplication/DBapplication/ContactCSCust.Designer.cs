namespace DBapplication
{
    partial class ContactCSCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactCSCust));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.FeedbackTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IssueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RatingComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitIssueButton = new System.Windows.Forms.Button();
            this.SubmitFeedbackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FeedbackGrid = new System.Windows.Forms.DataGridView();
            this.conplaintGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conplaintGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FeedbackTextBox
            // 
            this.FeedbackTextBox.Location = new System.Drawing.Point(142, 76);
            this.FeedbackTextBox.Name = "FeedbackTextBox";
            this.FeedbackTextBox.Size = new System.Drawing.Size(100, 22);
            this.FeedbackTextBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Feedback";
            // 
            // IssueTextBox
            // 
            this.IssueTextBox.Location = new System.Drawing.Point(142, 34);
            this.IssueTextBox.Name = "IssueTextBox";
            this.IssueTextBox.Size = new System.Drawing.Size(100, 22);
            this.IssueTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Describe issue";
            // 
            // RatingComboBox
            // 
            this.RatingComboBox.FormattingEnabled = true;
            this.RatingComboBox.Location = new System.Drawing.Point(265, 76);
            this.RatingComboBox.Name = "RatingComboBox";
            this.RatingComboBox.Size = new System.Drawing.Size(121, 24);
            this.RatingComboBox.TabIndex = 16;
            // 
            // SubmitIssueButton
            // 
            this.SubmitIssueButton.Location = new System.Drawing.Point(265, 30);
            this.SubmitIssueButton.Name = "SubmitIssueButton";
            this.SubmitIssueButton.Size = new System.Drawing.Size(84, 31);
            this.SubmitIssueButton.TabIndex = 15;
            this.SubmitIssueButton.Text = "Complaint";
            this.SubmitIssueButton.UseVisualStyleBackColor = true;
            this.SubmitIssueButton.Click += new System.EventHandler(this.SubmitIssueButton_Click);
            // 
            // SubmitFeedbackButton
            // 
            this.SubmitFeedbackButton.Location = new System.Drawing.Point(265, 116);
            this.SubmitFeedbackButton.Name = "SubmitFeedbackButton";
            this.SubmitFeedbackButton.Size = new System.Drawing.Size(124, 30);
            this.SubmitFeedbackButton.TabIndex = 21;
            this.SubmitFeedbackButton.Text = "Submit Feedback";
            this.SubmitFeedbackButton.UseVisualStyleBackColor = true;
            this.SubmitFeedbackButton.Click += new System.EventHandler(this.SubmitFeedbackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 286);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FeedbackGrid
            // 
            this.FeedbackGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeedbackGrid.Location = new System.Drawing.Point(436, 12);
            this.FeedbackGrid.Name = "FeedbackGrid";
            this.FeedbackGrid.RowHeadersWidth = 51;
            this.FeedbackGrid.RowTemplate.Height = 24;
            this.FeedbackGrid.Size = new System.Drawing.Size(352, 196);
            this.FeedbackGrid.TabIndex = 26;
            this.FeedbackGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FeedbackGrid_CellContentClick);
            // 
            // conplaintGrid
            // 
            this.conplaintGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conplaintGrid.Location = new System.Drawing.Point(436, 214);
            this.conplaintGrid.Name = "conplaintGrid";
            this.conplaintGrid.RowHeadersWidth = 51;
            this.conplaintGrid.RowTemplate.Height = 24;
            this.conplaintGrid.Size = new System.Drawing.Size(352, 224);
            this.conplaintGrid.TabIndex = 25;
            // 
            // ContactCSCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FeedbackGrid);
            this.Controls.Add(this.conplaintGrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SubmitFeedbackButton);
            this.Controls.Add(this.FeedbackTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IssueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RatingComboBox);
            this.Controls.Add(this.SubmitIssueButton);
            this.Name = "ContactCSCust";
            this.Text = "ContactCSCust";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conplaintGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox FeedbackTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IssueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RatingComboBox;
        private System.Windows.Forms.Button SubmitIssueButton;
        private System.Windows.Forms.Button SubmitFeedbackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView FeedbackGrid;
        private System.Windows.Forms.DataGridView conplaintGrid;
    }
}