﻿using System;
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
    public partial class servicelaunch : Form
    {
        Controller controller;
        public servicelaunch()
        {
            InitializeComponent();
            controller = new Controller();  
        }

        private void buttonlaunch_Click(object sender, EventArgs e)
        {
            bool exit = true;
            if (textBoxpname.Text == "" || textBoxpprice.Text == "" || textBoxdt.Text == "" || textBoxminutes.Text == "")
            {
                MessageBox.Show("Please fill all data");
                exit = false;   
            }
            else
            {
                controller.Launchservice(textBoxpname.Text, float.Parse(textBoxpprice.Text), textBoxdt.Text, Int32.Parse(textBoxminutes.Text), textBoxfeatures.Text);
                MessageBox.Show("Service successfully launched");
            }
        }
    }
}
