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
    public partial class Technician : Form
    {
        Controller controller;
        int id;
        public Technician(int id) {

            InitializeComponent();
            this.id = id;
            id_textbox.ReadOnly = true;
            id_textbox.Text = id.ToString();
            controller = new Controller();
            IssuesDataGridView.DataSource = controller.getNetworkIssues(id);
        }
        private void LoadNetworkIssues()
        {
                DataTable issues = controller.getNetworkIssues(id);
            if (issues != null)
            {
                IssuesDataGridView.DataSource = issues;
            }
            else
            {
                MessageBox.Show("No network issues found for this technician.");
            }
        }
        private void back_btn_Click(object sender, EventArgs e) {
            Employee emp = new Employee();
            emp.Show();
            this.Close();
        }

        private void IssuesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void tower_textbox_TextChanged(object sender, EventArgs e) {

        }

        private void id_textbox_TextChanged(object sender, EventArgs e) {

        }

        private void ResolveBTN_Click(object sender, EventArgs e)
        { int tid;
            if (int.TryParse(TwoerID_textBox.Text,out tid) && SummaryTextBox.Text!="")
            {
                controller.ResolveNetworkIssue(tid,SummaryTextBox.Text);
            }

            LoadNetworkIssues();
        }

        private void Technician_Load(object sender, EventArgs e)
        {

        }
    }
}
