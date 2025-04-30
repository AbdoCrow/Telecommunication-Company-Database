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
    public partial class Complaint : Form
    {
        Controller controller;
        int CID;
        public Complaint(int cid)
        {
            CID = cid;
            InitializeComponent();
            controller = new Controller();
            DataTable details = controller.GetComplaintDetails(cid);
            if (details != null && details.Rows.Count > 0)
            {
                ComplaintGrid.DataSource = details;
            }
        }
        private void LoadComplaintDetails(int CID)
        {
            DataTable details = controller.GetComplaintDetails(CID);
            if (details != null && details.Rows.Count > 0)
            {
                ComplaintGrid.DataSource = details;
            }
            ComplaintGrid.DataSource = null;
        }
        private void Complaint_Load(object sender, EventArgs e) {}

        private void back_btn_Click(object sender, EventArgs e)
        {
            /*CS customerService = new CS();
            customerService.Show();
            this.Close();*/
        }

        private void ComplaintGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SolveComplaintButton_Click(object sender, EventArgs e)
        {
            controller.solvecomplaint(CID);
            DataTable details = controller.GetComplaintDetails(CID);
            LoadComplaintDetails(CID);
        }
    }
}
