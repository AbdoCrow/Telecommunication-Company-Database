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
    public partial class CustContacts : Form
    {
        Controller controller;
        private int elapsedSeconds = 0;
        private int loyaltyPoints = 0; // Use this to store and display loyalty points
        private Timer callTimer;
        private int customerId;

        public CustContacts(int custId)
        {
            InitializeComponent();
            controller = new Controller();
            setupTimer();
            customerId = custId;
            loyaltyPoints = controller.GetLoyaltyPoints(customerId); // Get initial points
            UpdateLoyaltyPointsDisplay(); // Display initial points
            LoadHistory();

            PictureBox myPictureBox = pictureBox1;
            myPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox myPictureBox1 = pictureBox2;
            myPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox myPictureBox2 = pictureBox3;
            myPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;


        }

        private void LoadHistory()
        {
            DataTable historyCall = controller.GetSMSHistory(customerId);
            SMSHISGrid.DataSource = historyCall;
            DataTable historySMS = controller.GetCallHistory(customerId);
            CallHISGrid.DataSource = historySMS;
        }

        private void setupTimer()
        {
            callTimer = new Timer();
            callTimer.Interval = 1000; // 1 second
            callTimer.Tick += CallTimer_Tick;
        }

        private void CallTimer_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;

            // Calculate minutes and seconds
            int minutes = elapsedSeconds / 60;
            int seconds = elapsedSeconds % 60;

            // Get updated loyalty points
            loyaltyPoints = controller.GetLoyaltyPoints(customerId);
            
                UpdateLoyaltyPointsDisplay();
            


            string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
            
            
                UpdateTimerTextBox(timeString);
            
        }


        private void UpdateTimerTextBox(string seconds)
        {
            Timer.Text = seconds;
        }

        private void UpdateLoyaltyPointsDisplay()
        {
            // Use the current value of loyaltyPoints
            LoyalityPointsGain.Text = $"Loyalty Points: {loyaltyPoints}";
        }



        private void CallBTN_Click(object sender, EventArgs e)
        {
            string recipientPhoneNumber = NumberTXT.Text.Trim();

            if (recipientPhoneNumber.Length != 11 || !recipientPhoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 11-digit phone number.");
                return;
            }

            if (controller.VerifyRecipient(recipientPhoneNumber))
            {
                MessageBox.Show($"Calling {recipientPhoneNumber}...");

                elapsedSeconds = 0;


                callTimer.Start();
            }
            else
            {
                MessageBox.Show("Recipient number not found in the database.");
            }
        }

        private void DeclineBTN_Click(object sender, EventArgs e)
        {
            callTimer.Stop();
            string recipientPhoneNumber = NumberTXT.Text;

            if (controller.AddCall(customerId, recipientPhoneNumber, elapsedSeconds))
            {
                // Update loyalty points after adding the call
                loyaltyPoints = controller.GetLoyaltyPoints(customerId); 
                UpdateLoyaltyPointsDisplay();

                MessageBox.Show("Call ended.");
                elapsedSeconds = 0;
            }
            else
            {
                MessageBox.Show("Failed to call.");
            }
            //refresh
            LoadHistory();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string recipientPhoneNumber = NumberTXT.Text;
            if (controller.VerifyRecipient(recipientPhoneNumber))
            {

                if (controller.AddSMS(customerId, recipientPhoneNumber))
                {
                    MessageBox.Show($"SMS sent to {recipientPhoneNumber}.");

                    loyaltyPoints = controller.GetLoyaltyPoints(customerId); // Get updated points
                    UpdateLoyaltyPointsDisplay();
                }
                else
                {
                    MessageBox.Show("Failed to send SMS.");
                }
            }
            else
            {
                MessageBox.Show("Recipient number not found in the database.");
            }
            //refresh
            LoadHistory();
        }
        private void SmsTXT_TextChanged(object sender, EventArgs e)
        {

        }
        private void Timer_TextChanged(object sender, EventArgs e)
        {

        }

        private void SMSHISGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}