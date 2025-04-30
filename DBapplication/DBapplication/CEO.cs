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
    public partial class CEO : Form
    {
        Controller controller;
        public CEO()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string username = textBoxCEOUSER.Text;
            string password = textBoxCEOPASS.Text;

            // Hash the entered password
            //string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            if (username == "" || password == "")
            {
                MessageBox.Show("please enter all data");
            }
            else if (username == "CEO" && Int32.Parse(password) == 1234)
            {
                MessageBox.Show("Login successful!");
                Form d = new CEOfunc();
                d.Show();


            }
            


            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        } 
    }
}
