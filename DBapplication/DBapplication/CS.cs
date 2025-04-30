using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class CS : Form
    {
        Controller controller;
        public CS(int id) {
            InitializeComponent();
            controller = new Controller();
            DataTable complaints = controller.GetAllComplaintDetails();
            if (complaints != null && complaints.Rows.Count > 0)
            {
                FeedbackDataGridView.DataSource = complaints;
            }
        }

        private void back_btn_Click(object sender, EventArgs e) {
            Employee emp = new Employee();
            emp.Show();
            this.Close();
        }

        private void FeedbackDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewComplaintBTN_Click(object sender, EventArgs e) {
            int x = Convert.ToInt32(ComplaintIDTextBox.Text);
            Complaint f2 = new Complaint(x);
            f2.Show();
        }

        private void ManageSubBTN_Click(object sender, EventArgs e) {
            int y = Convert.ToInt32(CustIDTextBox.Text);
            ManageSub f1 = new ManageSub(y);
            f1.Show();
        }

        private void ComplaintIDTextBox_TextChanged(object sender, EventArgs e) {}

        private void CustIDTextBox_TextChanged(object sender, EventArgs e) {}

        private void CS_Load(object sender, EventArgs e)
        {

        }
    }
}
