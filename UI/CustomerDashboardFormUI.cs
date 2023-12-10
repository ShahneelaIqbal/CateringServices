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
    public partial class CustomerDashboardFormUI : Form
    {
        public CustomerDashboardFormUI()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            SignUIForm signUIForm = new SignUIForm("customer");
            signUIForm.Show();
            this.Hide();
        }

        private void btn_writeReviews_Click(object sender, EventArgs e)
        {
            WriteReviewFormUI writeReviewFormUI = new WriteReviewFormUI();
            writeReviewFormUI.Show();
            this.Hide();
        }

        private void btn_addItemToCart_Click(object sender, EventArgs e)
        {
            ListofServicesUI listofServicesUI = new ListofServicesUI("Candidate");
            listofServicesUI.Show();
            this.Hide();
        }

        private void btn_viewCartItems_Click(object sender, EventArgs e)
        {
            PlaceOrderFormUI placeOrderFormUI = new PlaceOrderFormUI();
            placeOrderFormUI.Show();
            this.Hide();
        }

        private void btn_viewFavorite_Click(object sender, EventArgs e)
        {
            ViewFavoriteFormUI  viewFavoriteFormUI = new ViewFavoriteFormUI();
            viewFavoriteFormUI.Show();
            this.Hide();
        }

        private void CustomerDashboardFormUI_Load(object sender, EventArgs e)
        {

        }
    }
}
