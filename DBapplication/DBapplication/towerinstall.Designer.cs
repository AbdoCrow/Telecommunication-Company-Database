namespace DBapplication
{
    partial class towerinstall
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxlocation = new System.Windows.Forms.TextBox();
            this.textBoxcoverradius = new System.Windows.Forms.TextBox();
            this.textBoxstatus = new System.Windows.Forms.TextBox();
            this.textBoxmaintenance = new System.Windows.Forms.TextBox();
            this.textBoxenergyusage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coverage radius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last maintenance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "energy usage";
            // 
            // textBoxlocation
            // 
            this.textBoxlocation.Location = new System.Drawing.Point(141, 41);
            this.textBoxlocation.Name = "textBoxlocation";
            this.textBoxlocation.Size = new System.Drawing.Size(100, 22);
            this.textBoxlocation.TabIndex = 5;
            // 
            // textBoxcoverradius
            // 
            this.textBoxcoverradius.Location = new System.Drawing.Point(141, 78);
            this.textBoxcoverradius.Name = "textBoxcoverradius";
            this.textBoxcoverradius.Size = new System.Drawing.Size(100, 22);
            this.textBoxcoverradius.TabIndex = 6;
            // 
            // textBoxstatus
            // 
            this.textBoxstatus.Location = new System.Drawing.Point(141, 113);
            this.textBoxstatus.Name = "textBoxstatus";
            this.textBoxstatus.Size = new System.Drawing.Size(100, 22);
            this.textBoxstatus.TabIndex = 7;
            // 
            // textBoxmaintenance
            // 
            this.textBoxmaintenance.Location = new System.Drawing.Point(141, 147);
            this.textBoxmaintenance.Name = "textBoxmaintenance";
            this.textBoxmaintenance.Size = new System.Drawing.Size(100, 22);
            this.textBoxmaintenance.TabIndex = 8;
            // 
            // textBoxenergyusage
            // 
            this.textBoxenergyusage.Location = new System.Drawing.Point(141, 182);
            this.textBoxenergyusage.Name = "textBoxenergyusage";
            this.textBoxenergyusage.Size = new System.Drawing.Size(100, 22);
            this.textBoxenergyusage.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Install";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // towerinstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxenergyusage);
            this.Controls.Add(this.textBoxmaintenance);
            this.Controls.Add(this.textBoxstatus);
            this.Controls.Add(this.textBoxcoverradius);
            this.Controls.Add(this.textBoxlocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "towerinstall";
            this.Text = "towerinstall";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxlocation;
        private System.Windows.Forms.TextBox textBoxcoverradius;
        private System.Windows.Forms.TextBox textBoxstatus;
        private System.Windows.Forms.TextBox textBoxmaintenance;
        private System.Windows.Forms.TextBox textBoxenergyusage;
        private System.Windows.Forms.Button button1;
    }
}