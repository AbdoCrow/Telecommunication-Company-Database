namespace DBapplication
{
    partial class ManageSub
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
            this.PointsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RedeemPointsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NewPlanComboBox = new System.Windows.Forms.ComboBox();
            this.UpdatePlanButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CustIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomerDetailsGrid = new System.Windows.Forms.DataGridView();
            this.BillingInfoGrid = new System.Windows.Forms.DataGridView();
            this.ViewBillingInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(425, 234);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 17;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // PointsTextBox
            // 
            this.PointsTextBox.Location = new System.Drawing.Point(355, 49);
            this.PointsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PointsTextBox.Name = "PointsTextBox";
            this.PointsTextBox.Size = new System.Drawing.Size(76, 20);
            this.PointsTextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Points to reedem";
            // 
            // RedeemPointsButton
            // 
            this.RedeemPointsButton.Location = new System.Drawing.Point(268, 73);
            this.RedeemPointsButton.Margin = new System.Windows.Forms.Padding(2);
            this.RedeemPointsButton.Name = "RedeemPointsButton";
            this.RedeemPointsButton.Size = new System.Drawing.Size(163, 28);
            this.RedeemPointsButton.TabIndex = 18;
            this.RedeemPointsButton.Text = "Reedem Points";
            this.RedeemPointsButton.UseVisualStyleBackColor = true;
            this.RedeemPointsButton.Click += new System.EventHandler(this.RedeemPointsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Update to Plan";
            // 
            // NewPlanComboBox
            // 
            this.NewPlanComboBox.FormattingEnabled = true;
            this.NewPlanComboBox.Location = new System.Drawing.Point(350, 138);
            this.NewPlanComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewPlanComboBox.Name = "NewPlanComboBox";
            this.NewPlanComboBox.Size = new System.Drawing.Size(81, 21);
            this.NewPlanComboBox.TabIndex = 22;
            // 
            // UpdatePlanButton
            // 
            this.UpdatePlanButton.Location = new System.Drawing.Point(268, 163);
            this.UpdatePlanButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdatePlanButton.Name = "UpdatePlanButton";
            this.UpdatePlanButton.Size = new System.Drawing.Size(163, 27);
            this.UpdatePlanButton.TabIndex = 21;
            this.UpdatePlanButton.Text = "Update your plan";
            this.UpdatePlanButton.UseVisualStyleBackColor = true;
            this.UpdatePlanButton.Click += new System.EventHandler(this.UpdatePlanButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Subscription for Customer";
            // 
            // CustIDTextBox
            // 
            this.CustIDTextBox.Location = new System.Drawing.Point(146, 10);
            this.CustIDTextBox.Name = "CustIDTextBox";
            this.CustIDTextBox.ReadOnly = true;
            this.CustIDTextBox.Size = new System.Drawing.Size(54, 20);
            this.CustIDTextBox.TabIndex = 25;
            this.CustIDTextBox.TextChanged += new System.EventHandler(this.CustIDTextBox_TextChanged);
            // 
            // CustomerDetailsGrid
            // 
            this.CustomerDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDetailsGrid.Location = new System.Drawing.Point(11, 46);
            this.CustomerDetailsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerDetailsGrid.Name = "CustomerDetailsGrid";
            this.CustomerDetailsGrid.RowHeadersWidth = 51;
            this.CustomerDetailsGrid.RowTemplate.Height = 24;
            this.CustomerDetailsGrid.Size = new System.Drawing.Size(253, 95);
            this.CustomerDetailsGrid.TabIndex = 26;
            this.CustomerDetailsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDetailsGrid_CellContentClick);
            // 
            // BillingInfoGrid
            // 
            this.BillingInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillingInfoGrid.Location = new System.Drawing.Point(11, 163);
            this.BillingInfoGrid.Margin = new System.Windows.Forms.Padding(2);
            this.BillingInfoGrid.Name = "BillingInfoGrid";
            this.BillingInfoGrid.RowHeadersWidth = 51;
            this.BillingInfoGrid.RowTemplate.Height = 24;
            this.BillingInfoGrid.Size = new System.Drawing.Size(253, 100);
            this.BillingInfoGrid.TabIndex = 27;
            this.BillingInfoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillingInfoGrid_CellContentClick);
            // 
            // ViewBillingInfoButton
            // 
            this.ViewBillingInfoButton.Location = new System.Drawing.Point(268, 234);
            this.ViewBillingInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.ViewBillingInfoButton.Name = "ViewBillingInfoButton";
            this.ViewBillingInfoButton.Size = new System.Drawing.Size(104, 29);
            this.ViewBillingInfoButton.TabIndex = 28;
            this.ViewBillingInfoButton.Text = "View billing info";
            this.ViewBillingInfoButton.UseVisualStyleBackColor = true;
            this.ViewBillingInfoButton.Click += new System.EventHandler(this.ViewBillingInfoButton_Click);
            // 
            // ManageSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 269);
            this.Controls.Add(this.ViewBillingInfoButton);
            this.Controls.Add(this.BillingInfoGrid);
            this.Controls.Add(this.CustomerDetailsGrid);
            this.Controls.Add(this.CustIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewPlanComboBox);
            this.Controls.Add(this.UpdatePlanButton);
            this.Controls.Add(this.PointsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RedeemPointsButton);
            this.Controls.Add(this.back_btn);
            this.Name = "ManageSub";
            this.Text = "ManageSub";
            this.Load += new System.EventHandler(this.ManageSub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingInfoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox PointsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RedeemPointsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NewPlanComboBox;
        private System.Windows.Forms.Button UpdatePlanButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustIDTextBox;
        private System.Windows.Forms.DataGridView CustomerDetailsGrid;
        private System.Windows.Forms.DataGridView BillingInfoGrid;
        private System.Windows.Forms.Button ViewBillingInfoButton;
    }
}