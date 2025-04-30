namespace DBapplication
{
    partial class CS
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
            this.back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FeedbackDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ManageSubBTN = new System.Windows.Forms.Button();
            this.CustIDTextBox = new System.Windows.Forms.TextBox();
            this.ComplaintIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ViewComplaintBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(608, 335);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 28);
            this.back_btn.TabIndex = 17;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Active Complaints";
            // 
            // FeedbackDataGridView
            // 
            this.FeedbackDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeedbackDataGridView.Location = new System.Drawing.Point(20, 31);
            this.FeedbackDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FeedbackDataGridView.Name = "FeedbackDataGridView";
            this.FeedbackDataGridView.RowHeadersWidth = 51;
            this.FeedbackDataGridView.Size = new System.Drawing.Size(380, 185);
            this.FeedbackDataGridView.TabIndex = 19;
            this.FeedbackDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FeedbackDataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Customer ID";
            // 
            // ManageSubBTN
            // 
            this.ManageSubBTN.Location = new System.Drawing.Point(457, 228);
            this.ManageSubBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManageSubBTN.Name = "ManageSubBTN";
            this.ManageSubBTN.Size = new System.Drawing.Size(224, 28);
            this.ManageSubBTN.TabIndex = 21;
            this.ManageSubBTN.Text = "Manage Subscription";
            this.ManageSubBTN.UseVisualStyleBackColor = true;
            this.ManageSubBTN.Click += new System.EventHandler(this.ManageSubBTN_Click);
            // 
            // CustIDTextBox
            // 
            this.CustIDTextBox.Location = new System.Drawing.Point(548, 196);
            this.CustIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustIDTextBox.Name = "CustIDTextBox";
            this.CustIDTextBox.Size = new System.Drawing.Size(132, 22);
            this.CustIDTextBox.TabIndex = 22;
            this.CustIDTextBox.TextChanged += new System.EventHandler(this.CustIDTextBox_TextChanged);
            // 
            // ComplaintIDTextBox
            // 
            this.ComplaintIDTextBox.Location = new System.Drawing.Point(117, 225);
            this.ComplaintIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComplaintIDTextBox.Name = "ComplaintIDTextBox";
            this.ComplaintIDTextBox.Size = new System.Drawing.Size(132, 22);
            this.ComplaintIDTextBox.TabIndex = 23;
            this.ComplaintIDTextBox.TextChanged += new System.EventHandler(this.ComplaintIDTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Complaint ID";
            // 
            // ViewComplaintBTN
            // 
            this.ViewComplaintBTN.Location = new System.Drawing.Point(259, 224);
            this.ViewComplaintBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewComplaintBTN.Name = "ViewComplaintBTN";
            this.ViewComplaintBTN.Size = new System.Drawing.Size(141, 28);
            this.ViewComplaintBTN.TabIndex = 25;
            this.ViewComplaintBTN.Text = "View Complaint";
            this.ViewComplaintBTN.UseVisualStyleBackColor = true;
            this.ViewComplaintBTN.Click += new System.EventHandler(this.ViewComplaintBTN_Click);
            // 
            // CS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 378);
            this.Controls.Add(this.ViewComplaintBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComplaintIDTextBox);
            this.Controls.Add(this.CustIDTextBox);
            this.Controls.Add(this.ManageSubBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FeedbackDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CS";
            this.Text = "CS";
            this.Load += new System.EventHandler(this.CS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FeedbackDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ManageSubBTN;
        private System.Windows.Forms.TextBox CustIDTextBox;
        private System.Windows.Forms.TextBox ComplaintIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ViewComplaintBTN;
    }
}