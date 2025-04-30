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
    public partial class CustFuns : Form
    {
        Controller controller;
        int customerId;
        public CustFuns(int customerId)
        {
            InitializeComponent();
            controller = new Controller();
            this.customerId = customerId;
            LoadRewardsComboBox();
        }

        private void CustFuns_Load(object sender, EventArgs e)
        {
            LoadCustomerDetails();
            LoadUsageDetails();
            InitializeServicePlans();

        }

        private void LoadCustomerDetails()
        {
            DataTable details = controller.GetCustomerDetails(customerId);
            if (details != null && details.Rows.Count > 0)
            {
                CustomerDetailsGrid.DataSource = details;
            }
        }

        private void LoadUsageDetails()
        {
            DataTable usage = controller.GetCustomerUsage(customerId);
            if (usage != null && usage.Rows.Count > 0)
            {
                UsageDetailsGrid.DataSource = usage;
            }
        }
        private void LoadRewardsComboBox()
        {
            RewardsComboBox.Items.Add("20 free SMS");
            RewardsComboBox.Items.Add("10 min for free");
            RewardsComboBox.Items.Add("30% Discount of Phones");
            RewardsComboBox.Items.Add("20% Discount on Plan");
        }

        private void InitializeServicePlans()
        {
            DataTable servicePlans = controller.GetServicePlans();
            if (servicePlans != null && servicePlans.Rows.Count > 0)
            {
                NewPlanComboBox.DataSource = servicePlans;
                NewPlanComboBox.DisplayMember = "plan_name";
                NewPlanComboBox.ValueMember = "plan_id";

                // Set current plan as selected value
                DataTable customerDetails = controller.GetCustomerDetails(customerId);
                if (customerDetails != null && customerDetails.Rows.Count > 0)
                {
                    NewPlanComboBox.SelectedValue = customerDetails.Rows[0]["service_plan_id"];
                }
            }
        }



        //get points required for each reward
        private int GetPointsForReward(string reward)
        {
            switch (reward)
            {
                case "20 free SMS": return 50;
                case "10 min for free": return 30;
                case "30% Discount of Phones": return 100;
                case "20% Discount on Plan": return 80;
                default: return 0;
            }
        }


        // Redeem loyalty points
        private void RedeemPointsButton_Click(object sender, EventArgs e)
        {
            string selectedReward = RewardsComboBox.SelectedItem.ToString();
            int currentPoints = controller.GetLoyaltyPoints(customerId); 
            int pointsRequired = GetPointsForReward(selectedReward);
            int points_selected = int.Parse(PointsTextBox.Text);

            if (currentPoints>0)
            {
                if (points_selected >= pointsRequired)
                {
                    if (controller.RedeemReward(customerId, selectedReward))
                    {
                        MessageBox.Show("Reward redeemed successfully!");
                        LoadCustomerDetails(); // Refresh customer details
                    }
                    else
                    {
                        MessageBox.Show("Failed to redeem reward.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Insufficient loyalty points to redeem this reward.");
            }
        }




        private void NewPlanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (NewPlanComboBox.SelectedValue != null)
                {
                    if (int.TryParse(NewPlanComboBox.SelectedValue.ToString(), out int planId))
                    {
                        decimal price = controller.GetPrice(planId);
                        PlanPriceShow.Text = price.ToString("");
                    }

                }
                
        }

        private void ContactsBTN_Click(object sender, EventArgs e)
        {
            Form c = new CustContacts(customerId);
            c.Show();

        }

        private void UsageDetailsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewBillingInfoButton_Click_1(object sender, EventArgs e)
        {
            DataTable billingInfo = controller.GetBillingInfo(customerId);
            if (billingInfo != null && billingInfo.Rows.Count > 0)
            {
                BillingInfoGrid.DataSource = billingInfo;
            }
            else
            {
                MessageBox.Show("No billing information available.");
            }
        }

       

        private void HelpBTN_Click(object sender, EventArgs e)
        {
            Form c = new ContactCSCust(customerId);
            c.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderBTN_Click(object sender, EventArgs e)
        {
            Form c = new OrderCust(customerId);
            c.Show();
        }

        private void UpdatePlanButton_Click_1(object sender, EventArgs e)
        {

            if (int.TryParse(NewPlanComboBox.SelectedValue.ToString(), out int newPlanId))
            {
                if (controller.UpdateServicePlan(customerId, newPlanId))
                {
                    MessageBox.Show("Service plan updated successfully.");
                    LoadCustomerDetails();
                }
                else
                {
                    MessageBox.Show("Failed to update service plan.");
                }
            }
            else
            {
                MessageBox.Show("Invalid plan selection.");
            }
            LoadCustomerDetails();
        }


        private void CustomerDetailsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RewardsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RewardsComboBox.SelectedItem != null)
            {
                string selectedReward = RewardsComboBox.SelectedItem.ToString();
                int pointsRequired = GetPointsForReward(selectedReward);
                PointsReqTXT.Text = pointsRequired.ToString();
            }
            else
            {
                PointsReqTXT.Text = ""; 
            }
        }

        private void PointsReqTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewusageBTN_Click(object sender, EventArgs e)
        {
            DataTable usage = controller.GetCustomerUsage(customerId);
            if (usage != null && usage.Rows.Count > 0)
            {
                UsageDetailsGrid.DataSource = usage;
            }
        }
    }
}
