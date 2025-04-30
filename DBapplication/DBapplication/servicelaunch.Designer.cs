namespace DBapplication
{
    partial class servicelaunch
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
            this.textBoxpname = new System.Windows.Forms.TextBox();
            this.textBoxpprice = new System.Windows.Forms.TextBox();
            this.textBoxdt = new System.Windows.Forms.TextBox();
            this.textBoxminutes = new System.Windows.Forms.TextBox();
            this.textBoxfeatures = new System.Windows.Forms.TextBox();
            this.buttonlaunch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plan name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "data limit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "call minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "additional features";
            // 
            // textBoxpname
            // 
            this.textBoxpname.Location = new System.Drawing.Point(138, 38);
            this.textBoxpname.Name = "textBoxpname";
            this.textBoxpname.Size = new System.Drawing.Size(100, 22);
            this.textBoxpname.TabIndex = 5;
            // 
            // textBoxpprice
            // 
            this.textBoxpprice.Location = new System.Drawing.Point(138, 91);
            this.textBoxpprice.Name = "textBoxpprice";
            this.textBoxpprice.Size = new System.Drawing.Size(100, 22);
            this.textBoxpprice.TabIndex = 6;
            // 
            // textBoxdt
            // 
            this.textBoxdt.Location = new System.Drawing.Point(138, 144);
            this.textBoxdt.Name = "textBoxdt";
            this.textBoxdt.Size = new System.Drawing.Size(100, 22);
            this.textBoxdt.TabIndex = 7;
            // 
            // textBoxminutes
            // 
            this.textBoxminutes.Location = new System.Drawing.Point(138, 195);
            this.textBoxminutes.Name = "textBoxminutes";
            this.textBoxminutes.Size = new System.Drawing.Size(100, 22);
            this.textBoxminutes.TabIndex = 8;
            // 
            // textBoxfeatures
            // 
            this.textBoxfeatures.Location = new System.Drawing.Point(138, 241);
            this.textBoxfeatures.Name = "textBoxfeatures";
            this.textBoxfeatures.Size = new System.Drawing.Size(100, 22);
            this.textBoxfeatures.TabIndex = 9;
            // 
            // buttonlaunch
            // 
            this.buttonlaunch.Location = new System.Drawing.Point(336, 224);
            this.buttonlaunch.Name = "buttonlaunch";
            this.buttonlaunch.Size = new System.Drawing.Size(104, 39);
            this.buttonlaunch.TabIndex = 10;
            this.buttonlaunch.Text = "Launch";
            this.buttonlaunch.UseVisualStyleBackColor = true;
            this.buttonlaunch.Click += new System.EventHandler(this.buttonlaunch_Click);
            // 
            // servicelaunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonlaunch);
            this.Controls.Add(this.textBoxfeatures);
            this.Controls.Add(this.textBoxminutes);
            this.Controls.Add(this.textBoxdt);
            this.Controls.Add(this.textBoxpprice);
            this.Controls.Add(this.textBoxpname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "servicelaunch";
            this.Text = "servicelaunch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxpname;
        private System.Windows.Forms.TextBox textBoxpprice;
        private System.Windows.Forms.TextBox textBoxdt;
        private System.Windows.Forms.TextBox textBoxminutes;
        private System.Windows.Forms.TextBox textBoxfeatures;
        private System.Windows.Forms.Button buttonlaunch;
    }
}