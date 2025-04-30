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
    public partial class Employee : Form
    {
        Controller controller;
        public Employee()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string usr = EmpUserTXT.Text;
            string pass = EmpPassTXT.Text;
            if (usr.Contains("tchn") && (pass == "123")) {
             
                int tchn_id = Convert.ToInt16(usr.Substring(4));
                bool tchn_exist = controller.tchnexist(tchn_id);
                if (tchn_exist)
                {
                    MessageBox.Show("Login successful!");
                    Technician f1 = new Technician(tchn_id);
                    f1.Show();
                    this.Close();
                }
                else
                { MessageBox.Show("invalid technician id"); }
            } else if (usr.Contains("cs") && (pass == "321")) {
                MessageBox.Show("Login successful!");
                int cs_id = Convert.ToInt16(usr.Substring(2));
                CS f2 = new CS(cs_id);
                f2.Show();
                this.Close();
            } else {
                MessageBox.Show("User not found. Invalid input.");
            }
        }

        private void EmpUserTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpPassTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
