using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class OrderCust : Form
    {
        private Controller controller;
        private int customerId;
        public OrderCust(int customerId)
        {
            InitializeComponent();
            controller = new Controller();
            this.customerId = customerId;
            LoadInventory();
            LoadPaymentMethods();
            LoadPayments();
            PictureBox myPictureBox = pictureBox1;
            myPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            int Item = (int)ItemComboBox.SelectedValue;
            DataTable dt = controller.PurchaseHistory(Item, customerId);
            PurchaseHisGrid.DataSource = dt;
        }
        private void LoadInventory()
        {
            DataTable inventory = controller.GetInventory();
            if (inventory != null && inventory.Rows.Count > 0)
            {
                ItemComboBox.DataSource = inventory;
                ItemComboBox.DisplayMember = "item_name";
                ItemComboBox.ValueMember = "inventory_id";
            }
        }

        private void LoadPayments()
        {
            DataTable payments = controller.GetCustomerPayments(customerId);
            if (payments != null && payments.Rows.Count > 0)
            {
                PaymentComboBox.DataSource = payments;
                PaymentComboBox.DisplayMember = "payment_method";
                PaymentComboBox.ValueMember = "payment_id";
            }
        }

        private void LoadPaymentMethods()
        {
            PaymentMethodsComboBox.Items.Add("Credit Card");
            PaymentMethodsComboBox.Items.Add("Debit Card");
            PaymentMethodsComboBox.Items.Add("Bank Transfer");
            PaymentMethodsComboBox.Items.Add("Fawry"); 
        }

        
        private void OrderCust_Load(object sender, EventArgs e)
        {

        }



        private void AddPaymentBTN_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(PaymentAmountTextBox.Text, out decimal paymentAmount) && paymentAmount > 0)
            {
                string paymentMethod = null; ////validationss
                if (PaymentMethodsComboBox.SelectedItem != null)
                {
                    paymentMethod = PaymentMethodsComboBox.SelectedItem.ToString();
                }
                if (!string.IsNullOrEmpty(paymentMethod))
                {
                    int paymentId = controller.AddPayment(customerId, paymentAmount, paymentMethod);
                    if (paymentId > 0)
                    {
                        MessageBox.Show($"Payment added successfully. ID: {paymentId}"); 
                        LoadPayments(); // Refresh the PaymentComboBox
                    }
                    else
                    {
                        MessageBox.Show("Failed to add payment.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a payment method.");
                }
            }

        }

        private void PurchaseItemBTN_Click(object sender, EventArgs e)
        {
            if (ItemComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select an item to purchase.");
                return;
            }

            if (PaymentComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a payment.");
                return;
            }

            if (!int.TryParse(QuantityTXT.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            int inventoryId = (int)ItemComboBox.SelectedValue;
            int paymentId = (int)PaymentComboBox.SelectedValue;

            string result = controller.PurchaseItem(customerId, inventoryId, quantity, paymentId);
            MessageBox.Show(result);

            ////////////////////////////////////////////////////
            // Refresh inventory and payments
            LoadInventory();
            LoadPayments();
            int Item = (int)ItemComboBox.SelectedValue;
            DataTable dt = controller.PurchaseHistory(Item, customerId);
            PurchaseHisGrid.DataSource = dt;
        }

        
        

        private void PurchaseHisGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
