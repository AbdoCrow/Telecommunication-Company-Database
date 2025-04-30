namespace DBapplication
{
    partial class CustFuns
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
            this.CustomerDetailsGrid = new System.Windows.Forms.DataGridView();
            this.UpdatePlanButton = new System.Windows.Forms.Button();
            this.RedeemPointsButton = new System.Windows.Forms.Button();
            this.ViewBillingInfoButton = new System.Windows.Forms.Button();
            this.UsageDetailsGrid = new System.Windows.Forms.DataGridView();
            this.NewPlanComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PointsTextBox = new System.Windows.Forms.TextBox();
            this.BillingInfoGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.HelpBTN = new System.Windows.Forms.Button();
            this.ContactsBTN = new System.Windows.Forms.Button();
            this.PlanPriceShow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderBTN = new System.Windows.Forms.Button();
            this.ViewusageBTN = new System.Windows.Forms.Button();
            this.RewardsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PointsReqTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsageDetailsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDetailsGrid
            // 
            this.CustomerDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDetailsGrid.Location = new System.Drawing.Point(425, 22);
            this.CustomerDetailsGrid.Name = "CustomerDetailsGrid";
            this.CustomerDetailsGrid.RowHeadersWidth = 51;
            this.CustomerDetailsGrid.RowTemplate.Height = 24;
            this.CustomerDetailsGrid.Size = new System.Drawing.Size(337, 191);
            this.CustomerDetailsGrid.TabIndex = 0;
            this.CustomerDetailsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDetailsGrid_CellContentClick);
            // 
            // UpdatePlanButton
            // 
            this.UpdatePlanButton.Location = new System.Drawing.Point(106, 216);
            this.UpdatePlanButton.Name = "UpdatePlanButton";
            this.UpdatePlanButton.Size = new System.Drawing.Size(146, 28);
            this.UpdatePlanButton.TabIndex = 1;
            this.UpdatePlanButton.Text = "Update your plan";
            this.UpdatePlanButton.UseVisualStyleBackColor = true;
            this.UpdatePlanButton.Click += new System.EventHandler(this.UpdatePlanButton_Click_1);
            // 
            // RedeemPointsButton
            // 
            this.RedeemPointsButton.Location = new System.Drawing.Point(250, 24);
            this.RedeemPointsButton.Name = "RedeemPointsButton";
            this.RedeemPointsButton.Size = new System.Drawing.Size(133, 23);
            this.RedeemPointsButton.TabIndex = 2;
            this.RedeemPointsButton.Text = "Reedem Points";
            this.RedeemPointsButton.UseVisualStyleBackColor = true;
            this.RedeemPointsButton.Click += new System.EventHandler(this.RedeemPointsButton_Click);
            // 
            // ViewBillingInfoButton
            // 
            this.ViewBillingInfoButton.Location = new System.Drawing.Point(425, 415);
            this.ViewBillingInfoButton.Name = "ViewBillingInfoButton";
            this.ViewBillingInfoButton.Size = new System.Drawing.Size(139, 31);
            this.ViewBillingInfoButton.TabIndex = 5;
            this.ViewBillingInfoButton.Text = "View billing info";
            this.ViewBillingInfoButton.UseVisualStyleBackColor = true;
            this.ViewBillingInfoButton.Click += new System.EventHandler(this.ViewBillingInfoButton_Click_1);
            // 
            // UsageDetailsGrid
            // 
            this.UsageDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsageDetailsGrid.Location = new System.Drawing.Point(425, 232);
            this.UsageDetailsGrid.Name = "UsageDetailsGrid";
            this.UsageDetailsGrid.RowHeadersWidth = 51;
            this.UsageDetailsGrid.RowTemplate.Height = 24;
            this.UsageDetailsGrid.Size = new System.Drawing.Size(337, 176);
            this.UsageDetailsGrid.TabIndex = 6;
            this.UsageDetailsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsageDetailsGrid_CellContentClick);
            // 
            // NewPlanComboBox
            // 
            this.NewPlanComboBox.FormattingEnabled = true;
            this.NewPlanComboBox.Location = new System.Drawing.Point(106, 186);
            this.NewPlanComboBox.Name = "NewPlanComboBox";
            this.NewPlanComboBox.Size = new System.Drawing.Size(121, 24);
            this.NewPlanComboBox.TabIndex = 8;
            this.NewPlanComboBox.SelectedIndexChanged += new System.EventHandler(this.NewPlanComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Points to reedem";
            // 
            // PointsTextBox
            // 
            this.PointsTextBox.Location = new System.Drawing.Point(127, 25);
            this.PointsTextBox.Name = "PointsTextBox";
            this.PointsTextBox.Size = new System.Drawing.Size(100, 22);
            this.PointsTextBox.TabIndex = 10;
            // 
            // BillingInfoGrid
            // 
            this.BillingInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillingInfoGrid.Location = new System.Drawing.Point(12, 258);
            this.BillingInfoGrid.Name = "BillingInfoGrid";
            this.BillingInfoGrid.RowHeadersWidth = 51;
            this.BillingInfoGrid.RowTemplate.Height = 24;
            this.BillingInfoGrid.Size = new System.Drawing.Size(297, 150);
            this.BillingInfoGrid.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Select a plan\r\nto update";
            // 
            // HelpBTN
            // 
            this.HelpBTN.Location = new System.Drawing.Point(18, 102);
            this.HelpBTN.Name = "HelpBTN";
            this.HelpBTN.Size = new System.Drawing.Size(119, 61);
            this.HelpBTN.TabIndex = 17;
            this.HelpBTN.Text = "Contact \r\ncustomer service";
            this.HelpBTN.UseVisualStyleBackColor = true;
            this.HelpBTN.Click += new System.EventHandler(this.HelpBTN_Click);
            // 
            // ContactsBTN
            // 
            this.ContactsBTN.Location = new System.Drawing.Point(143, 102);
            this.ContactsBTN.Name = "ContactsBTN";
            this.ContactsBTN.Size = new System.Drawing.Size(119, 61);
            this.ContactsBTN.TabIndex = 18;
            this.ContactsBTN.Text = "Your contacts";
            this.ContactsBTN.UseVisualStyleBackColor = true;
            this.ContactsBTN.Click += new System.EventHandler(this.ContactsBTN_Click);
            // 
            // PlanPriceShow
            // 
            this.PlanPriceShow.Location = new System.Drawing.Point(328, 186);
            this.PlanPriceShow.Name = "PlanPriceShow";
            this.PlanPriceShow.ReadOnly = true;
            this.PlanPriceShow.Size = new System.Drawing.Size(45, 22);
            this.PlanPriceShow.TabIndex = 19;
            this.PlanPriceShow.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Price";
            // 
            // OrderBTN
            // 
            this.OrderBTN.Location = new System.Drawing.Point(270, 102);
            this.OrderBTN.Name = "OrderBTN";
            this.OrderBTN.Size = new System.Drawing.Size(119, 61);
            this.OrderBTN.TabIndex = 21;
            this.OrderBTN.Text = "Make a Purchase";
            this.OrderBTN.UseVisualStyleBackColor = true;
            this.OrderBTN.Click += new System.EventHandler(this.OrderBTN_Click);
            // 
            // ViewusageBTN
            // 
            this.ViewusageBTN.Location = new System.Drawing.Point(623, 415);
            this.ViewusageBTN.Name = "ViewusageBTN";
            this.ViewusageBTN.Size = new System.Drawing.Size(139, 31);
            this.ViewusageBTN.TabIndex = 23;
            this.ViewusageBTN.Text = "View total usage ";
            this.ViewusageBTN.UseVisualStyleBackColor = true;
            this.ViewusageBTN.Click += new System.EventHandler(this.ViewusageBTN_Click);
            // 
            // RewardsComboBox
            // 
            this.RewardsComboBox.FormattingEnabled = true;
            this.RewardsComboBox.Location = new System.Drawing.Point(127, 53);
            this.RewardsComboBox.Name = "RewardsComboBox";
            this.RewardsComboBox.Size = new System.Drawing.Size(150, 24);
            this.RewardsComboBox.TabIndex = 24;
            this.RewardsComboBox.SelectedIndexChanged += new System.EventHandler(this.RewardsComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Points";
            // 
            // PointsReqTXT
            // 
            this.PointsReqTXT.Location = new System.Drawing.Point(344, 55);
            this.PointsReqTXT.Name = "PointsReqTXT";
            this.PointsReqTXT.ReadOnly = true;
            this.PointsReqTXT.Size = new System.Drawing.Size(45, 22);
            this.PointsReqTXT.TabIndex = 25;
            this.PointsReqTXT.TextChanged += new System.EventHandler(this.PointsReqTXT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "your reward";
            // 
            // CustFuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PointsReqTXT);
            this.Controls.Add(this.RewardsComboBox);
            this.Controls.Add(this.ViewusageBTN);
            this.Controls.Add(this.OrderBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlanPriceShow);
            this.Controls.Add(this.ContactsBTN);
            this.Controls.Add(this.HelpBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BillingInfoGrid);
            this.Controls.Add(this.PointsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPlanComboBox);
            this.Controls.Add(this.UsageDetailsGrid);
            this.Controls.Add(this.ViewBillingInfoButton);
            this.Controls.Add(this.RedeemPointsButton);
            this.Controls.Add(this.UpdatePlanButton);
            this.Controls.Add(this.CustomerDetailsGrid);
            this.Name = "CustFuns";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CustFuns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsageDetailsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingInfoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerDetailsGrid;
        private System.Windows.Forms.Button UpdatePlanButton;
        private System.Windows.Forms.Button RedeemPointsButton;
        private System.Windows.Forms.Button ViewBillingInfoButton;
        private System.Windows.Forms.DataGridView UsageDetailsGrid;
        private System.Windows.Forms.ComboBox NewPlanComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PointsTextBox;
        private System.Windows.Forms.DataGridView BillingInfoGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button HelpBTN;
        private System.Windows.Forms.Button ContactsBTN;
        private System.Windows.Forms.TextBox PlanPriceShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OrderBTN;
        private System.Windows.Forms.Button ViewusageBTN;
        private System.Windows.Forms.ComboBox RewardsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PointsReqTXT;
        private System.Windows.Forms.Label label5;
    }
}