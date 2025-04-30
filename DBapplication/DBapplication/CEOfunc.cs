using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class CEOfunc : Form
    {
        Controller controller;
        public CEOfunc()
        {
            InitializeComponent();
            controller = new Controller();

            DataTable dt1 = controller.GetServicePlans();
            comboBoxCEOsp.DataSource = dt1;
            comboBoxCEOsp.DisplayMember = "plan_name";
            comboBoxCEOsp.ValueMember = "plan_id";
            labeloldprice.Text = controller.GetPrice((Int32)comboBoxCEOsp.SelectedValue).ToString();
            DataTable dt2 = controller.getloyalty();
            dataGridView2.DataSource = dt2;
            dataGridView2.Refresh();
            DataTable dt3 = controller.gettowerloc();
            comboBoxCEOtower.DataSource = dt3;
            comboBoxCEOtower.DisplayMember = "location";
            comboBoxCEOtower.ValueMember = "tower_id";
                decimal usage = controller.getusage((Int32)(comboBoxCEOtower.SelectedValue));
            decimal eff = (usage / 1000) * 100;
                labeleff.Text = eff.ToString();
            DataTable dt4 = controller.getstat();
            dataGridViewstat.DataSource = dt4;
            dataGridViewstat.Refresh();



        }

        private void labelcustgrowth_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonremove_Click(object sender, EventArgs e)
        {
            controller.RemoveTower((Int32)comboBoxCEOtower.SelectedValue);
            MessageBox.Show("Tower removed successfully");
        }

        private void buttonnewprice_Click(object sender, EventArgs e)
        {
            if (textBoxnewprice.Text == "")
            {
                MessageBox.Show("please enter a price");
            }
            else
            {
                controller.updateprice(((Int32)comboBoxCEOsp.SelectedValue), float.Parse(textBoxnewprice.Text));
                MessageBox.Show("price updated successfully");
            }

        }

        private void buttoninstall_Click(object sender, EventArgs e)
        {
            Form t=new towerinstall();
            t.Show();
        }

        private void buttonlaunchservice_Click(object sender, EventArgs e)
        {
            Form s = new servicelaunch();
            s.Show();   
        }

        private void buttonfinancial_Click(object sender, EventArgs e)
        {
            Form f = new Fdata();
            f.Show();   
        }

        private void comboBoxCEOsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            labeloldprice.Text = controller.GetPrice((Int32)comboBoxCEOsp.SelectedValue).ToString();
        }

        private void comboBoxCEOtower_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal usage = controller.getusage((Int32)(comboBoxCEOtower.SelectedValue));
            decimal eff = (usage / 1000) * 100;
            labeleff.Text = eff.ToString();
        }
    }
}
