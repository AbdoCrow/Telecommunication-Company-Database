using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace DBapplication
{

    public partial class Customer : Form
    {
        Controller controller;

        public Customer()
        {
            InitializeComponent();
            controller = new Controller();

            DataTable dt = controller.GetServicePlans(); 
            PlanCombo.DataSource = dt;
            PlanCombo.DisplayMember = "plan_name";
            PlanCombo.ValueMember = "plan_id";

            PictureBox myPictureBox = pictureBox1;
            myPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

   

        private void RegisterBTN_Click_1(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string address = AddressTextBox.Text;
            string phone = PhoneTextBox.Text;
            string email = EmailTextBox.Text;
            int planId = int.Parse(PlanCombo.SelectedValue.ToString());
            string username = CustUserTXT.Text;
            string password = CustPassTXT.Text;

            // Validation
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (phone.Length != 11 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 11-digit phone number.");
                return;
            }

            if (!email.Contains('@'))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }


            bool success = controller.RegisterCustomer(name, address, phone, email, planId, username, password);
            if (success)
            {
                MessageBox.Show("Registration successful!");
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
            NameTextBox.Clear();
            AddressTextBox.Clear();
            PhoneTextBox.Clear();
            EmailTextBox.Clear();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string username = CustUserTXT.Text;
            string password = CustPassTXT.Text;

           
            bool success = controller.LoginCustomer(username, password);
            if (success)
            {
                int CustID = controller.GetCustID(username);
                MessageBox.Show("Login successful!");
                Form c = new CustFuns(CustID);
                c.Show(); 
                this.Hide(); 

            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }

}
