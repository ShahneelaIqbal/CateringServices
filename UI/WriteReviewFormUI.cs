using BA.BL;
using BA.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA.UI
{
    public partial class WriteReviewFormUI : Form
    {
        private string reviewPath = "review.txt";
        public WriteReviewFormUI()
        {
            InitializeComponent();
        }

        private void linklbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerDashboardFormUI customerDashboardFormUI = new CustomerDashboardFormUI();
            customerDashboardFormUI.Show();
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string review = txt_review.Text;
            if (review == "" || review == "")
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else
            {
                Review w_review = new Review(name, review);
                w_review.setName(name);
                w_review.setReview(review);
                bool response = ReviewDL.storeReviewDataInFile(w_review, reviewPath);
                if (response)
                {
                    MessageBox.Show("Review sent successfully!");
                    CustomerDashboardFormUI customerDashboardFormUI2 = new CustomerDashboardFormUI();
                    customerDashboardFormUI2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
        }

        private void WriteReviewFormUI_Load(object sender, EventArgs e)
        {

        }
    }
}
