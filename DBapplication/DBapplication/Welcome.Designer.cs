namespace DBapplication
{///test
    partial class Welcome
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
            this.EmployeeSelect = new System.Windows.Forms.Button();
            this.CustomerSelect = new System.Windows.Forms.Button();
            this.CeoSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeSelect
            // 
            this.EmployeeSelect.Location = new System.Drawing.Point(295, 295);
            this.EmployeeSelect.Name = "EmployeeSelect";
            this.EmployeeSelect.Size = new System.Drawing.Size(210, 104);
            this.EmployeeSelect.TabIndex = 5;
            this.EmployeeSelect.Text = "Employee";
            this.EmployeeSelect.UseVisualStyleBackColor = true;
            this.EmployeeSelect.Click += new System.EventHandler(this.EmployeeSelect_Click);
            // 
            // CustomerSelect
            // 
            this.CustomerSelect.Location = new System.Drawing.Point(295, 171);
            this.CustomerSelect.Name = "CustomerSelect";
            this.CustomerSelect.Size = new System.Drawing.Size(210, 104);
            this.CustomerSelect.TabIndex = 4;
            this.CustomerSelect.Text = "Customer";
            this.CustomerSelect.UseVisualStyleBackColor = true;
            this.CustomerSelect.Click += new System.EventHandler(this.CustomerSelect_Click);
            // 
            // CeoSelect
            // 
            this.CeoSelect.Location = new System.Drawing.Point(295, 51);
            this.CeoSelect.Name = "CeoSelect";
            this.CeoSelect.Size = new System.Drawing.Size(210, 104);
            this.CeoSelect.TabIndex = 3;
            this.CeoSelect.Text = "CEO";
            this.CeoSelect.UseVisualStyleBackColor = true;
            this.CeoSelect.Click += new System.EventHandler(this.CeoSelect_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeeSelect);
            this.Controls.Add(this.CustomerSelect);
            this.Controls.Add(this.CeoSelect);
            this.Name = "Welcome";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmployeeSelect;
        private System.Windows.Forms.Button CustomerSelect;
        private System.Windows.Forms.Button CeoSelect;
    }
}