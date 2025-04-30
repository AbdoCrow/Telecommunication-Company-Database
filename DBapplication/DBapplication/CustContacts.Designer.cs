namespace DBapplication
{
    partial class CustContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustContacts));
            this.button1 = new System.Windows.Forms.Button();
            this.CallBTN = new System.Windows.Forms.Button();
            this.SmsTXT = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.TextBox();
            this.NumberTXT = new System.Windows.Forms.TextBox();
            this.NumberTOTXT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoyalityPointsGain = new System.Windows.Forms.Label();
            this.DeclineBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SMSHISGrid = new System.Windows.Forms.DataGridView();
            this.CallHISGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMSHISGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CallHISGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send sms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CallBTN
            // 
            this.CallBTN.Location = new System.Drawing.Point(179, 108);
            this.CallBTN.Name = "CallBTN";
            this.CallBTN.Size = new System.Drawing.Size(75, 31);
            this.CallBTN.TabIndex = 1;
            this.CallBTN.Text = "Call";
            this.CallBTN.UseVisualStyleBackColor = true;
            this.CallBTN.Click += new System.EventHandler(this.CallBTN_Click);
            // 
            // SmsTXT
            // 
            this.SmsTXT.Location = new System.Drawing.Point(54, 212);
            this.SmsTXT.Name = "SmsTXT";
            this.SmsTXT.Size = new System.Drawing.Size(101, 22);
            this.SmsTXT.TabIndex = 2;
            this.SmsTXT.TextChanged += new System.EventHandler(this.SmsTXT_TextChanged);
            // 
            // Timer
            // 
            this.Timer.Location = new System.Drawing.Point(112, 112);
            this.Timer.Name = "Timer";
            this.Timer.ReadOnly = true;
            this.Timer.Size = new System.Drawing.Size(43, 22);
            this.Timer.TabIndex = 3;
            this.Timer.TextChanged += new System.EventHandler(this.Timer_TextChanged);
            // 
            // NumberTXT
            // 
            this.NumberTXT.Location = new System.Drawing.Point(397, 24);
            this.NumberTXT.Name = "NumberTXT";
            this.NumberTXT.Size = new System.Drawing.Size(100, 22);
            this.NumberTXT.TabIndex = 4;
            // 
            // NumberTOTXT
            // 
            this.NumberTOTXT.AutoSize = true;
            this.NumberTOTXT.Location = new System.Drawing.Point(302, 27);
            this.NumberTOTXT.Name = "NumberTOTXT";
            this.NumberTOTXT.Size = new System.Drawing.Size(89, 16);
            this.NumberTOTXT.TabIndex = 5;
            this.NumberTOTXT.Text = "Enter Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time of call";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "SMS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loyality points gained";
            // 
            // LoyalityPointsGain
            // 
            this.LoyalityPointsGain.AutoSize = true;
            this.LoyalityPointsGain.Location = new System.Drawing.Point(574, 123);
            this.LoyalityPointsGain.Name = "LoyalityPointsGain";
            this.LoyalityPointsGain.Size = new System.Drawing.Size(14, 16);
            this.LoyalityPointsGain.TabIndex = 9;
            this.LoyalityPointsGain.Text = "0";
            // 
            // DeclineBTN
            // 
            this.DeclineBTN.Location = new System.Drawing.Point(260, 108);
            this.DeclineBTN.Name = "DeclineBTN";
            this.DeclineBTN.Size = new System.Drawing.Size(75, 31);
            this.DeclineBTN.TabIndex = 10;
            this.DeclineBTN.Text = "Decline";
            this.DeclineBTN.UseVisualStyleBackColor = true;
            this.DeclineBTN.Click += new System.EventHandler(this.DeclineBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 173);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 50);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 50);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Messages History";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Call history";
            // 
            // SMSHISGrid
            // 
            this.SMSHISGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SMSHISGrid.Location = new System.Drawing.Point(551, 198);
            this.SMSHISGrid.Name = "SMSHISGrid";
            this.SMSHISGrid.RowHeadersWidth = 51;
            this.SMSHISGrid.RowTemplate.Height = 24;
            this.SMSHISGrid.Size = new System.Drawing.Size(237, 240);
            this.SMSHISGrid.TabIndex = 23;
            this.SMSHISGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SMSHISGrid_CellContentClick);
            // 
            // CallHISGrid
            // 
            this.CallHISGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CallHISGrid.Location = new System.Drawing.Point(299, 198);
            this.CallHISGrid.Name = "CallHISGrid";
            this.CallHISGrid.RowHeadersWidth = 51;
            this.CallHISGrid.RowTemplate.Height = 24;
            this.CallHISGrid.Size = new System.Drawing.Size(246, 240);
            this.CallHISGrid.TabIndex = 22;
            // 
            // CustContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SMSHISGrid);
            this.Controls.Add(this.CallHISGrid);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DeclineBTN);
            this.Controls.Add(this.LoyalityPointsGain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberTOTXT);
            this.Controls.Add(this.NumberTXT);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.SmsTXT);
            this.Controls.Add(this.CallBTN);
            this.Controls.Add(this.button1);
            this.Name = "CustContacts";
            this.Text = "CustContacts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMSHISGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CallHISGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CallBTN;
        private System.Windows.Forms.TextBox SmsTXT;
        private System.Windows.Forms.TextBox Timer;
        private System.Windows.Forms.TextBox NumberTXT;
        private System.Windows.Forms.Label NumberTOTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LoyalityPointsGain;
        private System.Windows.Forms.Button DeclineBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView SMSHISGrid;
        private System.Windows.Forms.DataGridView CallHISGrid;
    }
}