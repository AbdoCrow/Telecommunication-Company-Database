namespace DBapplication
{
    partial class Technician
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
            this.label2 = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IssuesDataGridView = new System.Windows.Forms.DataGridView();
            this.ResolveBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TwoerID_textBox = new System.Windows.Forms.TextBox();
            this.SummaryTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IssuesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(593, 334);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 28);
            this.back_btn.TabIndex = 16;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Technician ID";
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(52, 34);
            this.id_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.ReadOnly = true;
            this.id_textbox.Size = new System.Drawing.Size(93, 22);
            this.id_textbox.TabIndex = 20;
            this.id_textbox.TextChanged += new System.EventHandler(this.id_textbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Netwrok Issues";
            // 
            // IssuesDataGridView
            // 
            this.IssuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssuesDataGridView.Location = new System.Drawing.Point(185, 34);
            this.IssuesDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IssuesDataGridView.Name = "IssuesDataGridView";
            this.IssuesDataGridView.RowHeadersWidth = 51;
            this.IssuesDataGridView.Size = new System.Drawing.Size(361, 185);
            this.IssuesDataGridView.TabIndex = 23;
            this.IssuesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IssuesDataGridView_CellContentClick);
            // 
            // ResolveBTN
            // 
            this.ResolveBTN.Location = new System.Drawing.Point(327, 302);
            this.ResolveBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResolveBTN.Name = "ResolveBTN";
            this.ResolveBTN.Size = new System.Drawing.Size(220, 28);
            this.ResolveBTN.TabIndex = 24;
            this.ResolveBTN.Text = "Resolve issue";
            this.ResolveBTN.UseVisualStyleBackColor = true;
            this.ResolveBTN.Click += new System.EventHandler(this.ResolveBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "TowerID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Resolution Summary";
            // 
            // TwoerID_textBox
            // 
            this.TwoerID_textBox.Location = new System.Drawing.Point(327, 238);
            this.TwoerID_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TwoerID_textBox.Name = "TwoerID_textBox";
            this.TwoerID_textBox.Size = new System.Drawing.Size(219, 22);
            this.TwoerID_textBox.TabIndex = 27;
            // 
            // SummaryTextBox
            // 
            this.SummaryTextBox.Location = new System.Drawing.Point(327, 270);
            this.SummaryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SummaryTextBox.Name = "SummaryTextBox";
            this.SummaryTextBox.Size = new System.Drawing.Size(219, 22);
            this.SummaryTextBox.TabIndex = 28;
            // 
            // Technician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 377);
            this.Controls.Add(this.SummaryTextBox);
            this.Controls.Add(this.TwoerID_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResolveBTN);
            this.Controls.Add(this.IssuesDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Technician";
            this.Text = "Technician";
            this.Load += new System.EventHandler(this.Technician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IssuesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView IssuesDataGridView;
        private System.Windows.Forms.Button ResolveBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TwoerID_textBox;
        private System.Windows.Forms.TextBox SummaryTextBox;
    }
}