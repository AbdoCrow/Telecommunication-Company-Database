namespace DBapplication
{
    partial class CEO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCEOUSER = new System.Windows.Forms.TextBox();
            this.textBoxCEOPASS = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBoxCEOUSER
            // 
            this.textBoxCEOUSER.Location = new System.Drawing.Point(88, 33);
            this.textBoxCEOUSER.Name = "textBoxCEOUSER";
            this.textBoxCEOUSER.Size = new System.Drawing.Size(100, 22);
            this.textBoxCEOUSER.TabIndex = 2;
            // 
            // textBoxCEOPASS
            // 
            this.textBoxCEOPASS.Location = new System.Drawing.Point(88, 91);
            this.textBoxCEOPASS.Name = "textBoxCEOPASS";
            this.textBoxCEOPASS.PasswordChar = '*';
            this.textBoxCEOPASS.Size = new System.Drawing.Size(100, 22);
            this.textBoxCEOPASS.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(290, 81);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(84, 32);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // CEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxCEOPASS);
            this.Controls.Add(this.textBoxCEOUSER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CEO";
            this.Text = "CEO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCEOUSER;
        private System.Windows.Forms.TextBox textBoxCEOPASS;
        private System.Windows.Forms.Button buttonLogin;
    }
}