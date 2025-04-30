namespace DBapplication
{
    partial class OrderCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderCust));
            this.PaymentMethodsComboBox = new System.Windows.Forms.ComboBox();
            this.PaymentAmountTextBox = new System.Windows.Forms.TextBox();
            this.PurchaseItemBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.PaymentComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddPaymentBTN = new System.Windows.Forms.Button();
            this.QuantityTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PurchaseHisGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseHisGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentMethodsComboBox
            // 
            this.PaymentMethodsComboBox.FormattingEnabled = true;
            this.PaymentMethodsComboBox.Location = new System.Drawing.Point(12, 54);
            this.PaymentMethodsComboBox.Name = "PaymentMethodsComboBox";
            this.PaymentMethodsComboBox.Size = new System.Drawing.Size(121, 24);
            this.PaymentMethodsComboBox.TabIndex = 1;
            // 
            // PaymentAmountTextBox
            // 
            this.PaymentAmountTextBox.Location = new System.Drawing.Point(179, 56);
            this.PaymentAmountTextBox.Name = "PaymentAmountTextBox";
            this.PaymentAmountTextBox.Size = new System.Drawing.Size(107, 22);
            this.PaymentAmountTextBox.TabIndex = 2;
            // 
            // PurchaseItemBTN
            // 
            this.PurchaseItemBTN.Location = new System.Drawing.Point(151, 309);
            this.PurchaseItemBTN.Name = "PurchaseItemBTN";
            this.PurchaseItemBTN.Size = new System.Drawing.Size(85, 30);
            this.PurchaseItemBTN.TabIndex = 3;
            this.PurchaseItemBTN.Text = "Purchase";
            this.PurchaseItemBTN.UseVisualStyleBackColor = true;
            this.PurchaseItemBTN.Click += new System.EventHandler(this.PurchaseItemBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select payment method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount to pay";
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(9, 239);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(121, 24);
            this.ItemComboBox.TabIndex = 8;
            // 
            // PaymentComboBox
            // 
            this.PaymentComboBox.FormattingEnabled = true;
            this.PaymentComboBox.Location = new System.Drawing.Point(9, 184);
            this.PaymentComboBox.Name = "PaymentComboBox";
            this.PaymentComboBox.Size = new System.Drawing.Size(121, 24);
            this.PaymentComboBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pay with";
            // 
            // AddPaymentBTN
            // 
            this.AddPaymentBTN.Location = new System.Drawing.Point(347, 49);
            this.AddPaymentBTN.Name = "AddPaymentBTN";
            this.AddPaymentBTN.Size = new System.Drawing.Size(115, 33);
            this.AddPaymentBTN.TabIndex = 12;
            this.AddPaymentBTN.Text = "Add payment";
            this.AddPaymentBTN.UseVisualStyleBackColor = true;
            this.AddPaymentBTN.Click += new System.EventHandler(this.AddPaymentBTN_Click);
            // 
            // QuantityTXT
            // 
            this.QuantityTXT.Location = new System.Drawing.Point(170, 241);
            this.QuantityTXT.Name = "QuantityTXT";
            this.QuantityTXT.Size = new System.Drawing.Size(109, 22);
            this.QuantityTXT.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantaty";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 107);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // PurchaseHisGrid
            // 
            this.PurchaseHisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseHisGrid.Location = new System.Drawing.Point(391, 101);
            this.PurchaseHisGrid.Name = "PurchaseHisGrid";
            this.PurchaseHisGrid.RowHeadersWidth = 51;
            this.PurchaseHisGrid.RowTemplate.Height = 24;
            this.PurchaseHisGrid.Size = new System.Drawing.Size(397, 337);
            this.PurchaseHisGrid.TabIndex = 18;
            this.PurchaseHisGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurchaseHisGrid_CellContentClick);
            // 
            // OrderCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PurchaseHisGrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QuantityTXT);
            this.Controls.Add(this.AddPaymentBTN);
            this.Controls.Add(this.PaymentComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurchaseItemBTN);
            this.Controls.Add(this.PaymentAmountTextBox);
            this.Controls.Add(this.PaymentMethodsComboBox);
            this.Name = "OrderCust";
            this.Text = "OrderCust";
            this.Load += new System.EventHandler(this.OrderCust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseHisGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox PaymentMethodsComboBox;
        private System.Windows.Forms.TextBox PaymentAmountTextBox;
        private System.Windows.Forms.Button PurchaseItemBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.ComboBox PaymentComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddPaymentBTN;
        private System.Windows.Forms.TextBox QuantityTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView PurchaseHisGrid;
    }
}