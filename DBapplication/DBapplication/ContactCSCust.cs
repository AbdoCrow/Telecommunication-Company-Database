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
    public partial class ContactCSCust : Form
    {
        Controller controller;
        int customerId;
        public ContactCSCust(int customerId)
        {
            InitializeComponent();
            controller = new Controller();
            this.customerId = customerId;
            PictureBox myPictureBox = pictureBox1;
            myPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            DataTable dt = controller.GetCustomerComplaints(customerId);
            conplaintGrid.DataSource = dt;
            InitializeRatingComboBox();
            LoadCustomerFeedbacks();
            LoadCustomeComplaints();
        }
        private void CustFuns_Load(object sender, EventArgs e)
        {

            InitializeRatingComboBox();
        }
        private void InitializeRatingComboBox()
        {
            RatingComboBox.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            RatingComboBox.SelectedIndex = 4;
        }
        private void LoadCustomeComplaints()
        {

            DataTable complaint = controller.GetCustomerComplaints(customerId);
            if (complaint != null)
            {
                conplaintGrid.DataSource = complaint;
            }
            else
            {
                MessageBox.Show("No complaint found for this customer.");
            }
        }
        private void LoadCustomerFeedbacks()
        {

            DataTable feedbacks = controller.GetCustomerFeedbacks(customerId);
            if (feedbacks != null)
            {
                FeedbackGrid.DataSource = feedbacks;
            }
            else
            {
                MessageBox.Show("No feedbacks found for this customer.");
            }
        }


        private void SubmitIssueButton_Click(object sender, EventArgs e)
        {
            string issueDescription = IssueTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(issueDescription))
            {
                if (controller.AddComplaint(customerId, issueDescription))
                {
                    MessageBox.Show("Issue submitted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to submit issue.");
                }
            }
            else
            {
                MessageBox.Show("Please describe the issue.");
            }

            LoadCustomeComplaints();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitFeedbackButton_Click(object sender, EventArgs e)
        {
            string feedbackText = FeedbackTextBox.Text;
            int rating = RatingComboBox.SelectedIndex;

            if (controller.AddFeedback(customerId, feedbackText, rating))
            {
                MessageBox.Show("Feedback submitted successfully.");
                FeedbackTextBox.Clear();

            }
            else
            {
                MessageBox.Show("Failed to submit feedback.");
            }
            LoadCustomerFeedbacks();
        }

        private void FeedbackGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
