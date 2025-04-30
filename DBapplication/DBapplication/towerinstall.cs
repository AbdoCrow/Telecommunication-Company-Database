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
    public partial class towerinstall : Form
    {
        Controller controller;
        public towerinstall()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool exit = true;
            if (textBoxlocation.Text == ""||textBoxcoverradius.Text==""|| textBoxstatus.Text == ""||textBoxmaintenance.Text==""||textBoxenergyusage.Text=="")
            {
                MessageBox.Show("please fill all data");
                exit = false;
            }
            
            if (exit)
            {
                controller.InstallTower(textBoxlocation.Text, float.Parse(textBoxcoverradius.Text), textBoxstatus.Text, DateTime.Parse(textBoxmaintenance.Text), float.Parse(textBoxenergyusage.Text));
                MessageBox.Show("Tower installed successfully");
            }
            
        }
    }
}
