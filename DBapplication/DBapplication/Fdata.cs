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
    public partial class Fdata : Form
    {
        Controller controller;
        public Fdata()
        {
            InitializeComponent();
            controller = new Controller();

            DataTable dt4 = controller.getpayments();
            dataGridView1.DataSource = dt4;
            dataGridView1.Refresh();
            DataTable dt5 = controller.getsalaries();
            dataGridView2.DataSource = dt5;
            dataGridView2.Refresh();
        }

        
    }
}
