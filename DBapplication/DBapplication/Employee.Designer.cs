namespace DBapplication
{
    partial class Employee
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
            this.LoginBTN = new System.Windows.Forms.Button();
            this.EmpPassTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpUserTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(220, 191);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(203, 37);
            this.LoginBTN.TabIndex = 14;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // EmpPassTXT
            // 
            this.EmpPassTXT.Location = new System.Drawing.Point(321, 139);
            this.EmpPassTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmpPassTXT.Name = "EmpPassTXT";
            this.EmpPassTXT.Size = new System.Drawing.Size(100, 22);
            this.EmpPassTXT.TabIndex = 13;
            this.EmpPassTXT.TextChanged += new System.EventHandler(this.EmpPassTXT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // EmpUserTXT
            // 
            this.EmpUserTXT.Location = new System.Drawing.Point(321, 95);
            this.EmpUserTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmpUserTXT.Name = "EmpUserTXT";
            this.EmpUserTXT.Size = new System.Drawing.Size(100, 22);
            this.EmpUserTXT.TabIndex = 11;
            this.EmpUserTXT.TextChanged += new System.EventHandler(this.EmpUserTXT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(531, 327);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 28);
            this.back_btn.TabIndex = 15;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 370);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.EmpPassTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpUserTXT);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.TextBox EmpPassTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmpUserTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
    }
}