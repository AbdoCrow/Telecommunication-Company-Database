namespace DBapplication
{
    partial class Complaint
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
            this.ComplaintGrid = new System.Windows.Forms.DataGridView();
            this.SolveComplaintButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComplaintGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(564, 308);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 28);
            this.back_btn.TabIndex = 17;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // ComplaintGrid
            // 
            this.ComplaintGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComplaintGrid.Location = new System.Drawing.Point(12, 37);
            this.ComplaintGrid.Name = "ComplaintGrid";
            this.ComplaintGrid.RowHeadersWidth = 51;
            this.ComplaintGrid.RowTemplate.Height = 24;
            this.ComplaintGrid.Size = new System.Drawing.Size(652, 79);
            this.ComplaintGrid.TabIndex = 18;
            this.ComplaintGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComplaintGrid_CellContentClick);
            // 
            // SolveComplaintButton
            // 
            this.SolveComplaintButton.Location = new System.Drawing.Point(266, 197);
            this.SolveComplaintButton.Name = "SolveComplaintButton";
            this.SolveComplaintButton.Size = new System.Drawing.Size(115, 46);
            this.SolveComplaintButton.TabIndex = 19;
            this.SolveComplaintButton.Text = "Solve Complaint";
            this.SolveComplaintButton.UseVisualStyleBackColor = true;
            this.SolveComplaintButton.Click += new System.EventHandler(this.SolveComplaintButton_Click);
            // 
            // Complaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 351);
            this.Controls.Add(this.SolveComplaintButton);
            this.Controls.Add(this.ComplaintGrid);
            this.Controls.Add(this.back_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Complaint";
            this.Text = "Complaint";
            this.Load += new System.EventHandler(this.Complaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComplaintGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView ComplaintGrid;
        private System.Windows.Forms.Button SolveComplaintButton;
    }
}