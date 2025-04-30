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
    public partial class ManageSub : Form
    {
        Controller controller;
        int customerID;
        public ManageSub(int customerID) {
            InitializeComponent();
            controller = new Controller();
            this.customerID = customerID;
            CustIDTextBox.Text = customerID.ToString();
        }

        private void LoadCustomerDetails() {
            DataTable details = controller.GetCustomerDetails(customerID);
            if (details != null && details.Rows.Count > 0)
            {
                CustomerDetailsGrid.DataSource = details;
            }
        }

        void InitializeServicePlans() {
            DataTable servicePlans = controller.GetServicePlans();
            if (servicePlans != null && servicePlans.Rows.Count > 0)
            {
                NewPlanComboBox.DataSource = servicePlans;
                NewPlanComboBox.DisplayMember = "plan_name";
                NewPlanComboBox.ValueMember = "plan_id";

                // Set current plan as selected value
                DataTable customerDetails = controller.GetCustomerDetails(customerID);
                if (customerDetails != null && customerDetails.Rows.Count > 0) {
                    NewPlanComboBox.SelectedValue = customerDetails.Rows[0]["service_plan_id"];
                }
            }
        }

        private void ManageSub_Load(object sender, EventArgs e) {
            LoadCustomerDetails();
            InitializeServicePlans();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            //CS customerService = new CS();
            //customerService.Show();
            //this.Close();
        }

        private void UpdatePlanButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(NewPlanComboBox.SelectedValue.ToString(), out int newPlanId))
            {
                if (controller.UpdateServicePlan(customerID, newPlanId)) {
                    MessageBox.Show("Service plan updated successfully.");
                    // LoadCustomerDetails();
                } else {
                    MessageBox.Show("Failed to update service plan.");
                }
            } else {
                MessageBox.Show("Invalid plan selection.");
            }
        }

        private void RedeemPointsButton_Click(object sender, EventArgs e) {
            if (int.TryParse(PointsTextBox.Text, out int pointsToRedeem)) {
                if (controller.RedeemLoyaltyPoints(customerID, pointsToRedeem)) {
                    MessageBox.Show("Points redeemed successfully.");
                     LoadCustomerDetails();
                    CustomerDetailsGrid.Refresh();
                } else {
                    MessageBox.Show("Failed to redeem points or insufficient balance.");
                }
            } else {
                MessageBox.Show("Enter a valid number of points.");
            }
        }

        private void CustomerDetailsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {}

        private void BillingInfoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {}

        private void ViewBillingInfoButton_Click(object sender, EventArgs e) {
            DataTable billingInfo = controller.GetBillingInfo(customerID);
            if (billingInfo != null && billingInfo.Rows.Count > 0)
            {
                BillingInfoGrid.DataSource = billingInfo;
            }
            else
            {
                MessageBox.Show("No billing information available.");
            }
        }

        private void CustIDTextBox_TextChanged(object sender, EventArgs e) {}
    }
}
