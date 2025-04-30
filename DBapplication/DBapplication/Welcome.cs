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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void CustomerSelect_Click(object sender, EventArgs e)
        {
            Form c = new Customer();
            c.Show();
        }

        private void CeoSelect_Click(object sender, EventArgs e)
        {
            Form d = new CEO();
            d.Show();
        }

        private void EmployeeSelect_Click(object sender, EventArgs e)
        {
            
                Form f1 = new Employee();
                f1.Show();
                this.Hide();
            
        }
    }
}
