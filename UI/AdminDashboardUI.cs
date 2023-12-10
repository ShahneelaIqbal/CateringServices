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
    public partial class AdminDashboardUI : Form
    {
        public AdminDashboardUI()
        {
            InitializeComponent();
        }

        private void AdminDashboardUI_Load(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            SignUIForm signUIForm = new SignUIForm("admin");
            signUIForm.Show();
            this.Hide();
        }

        private void btn_viewListofServices_Click(object sender, EventArgs e)
        {
            ListofServicesUI listofServicesUI = new ListofServicesUI("ViewServices");
            listofServicesUI.Show();
            this.Hide();
        }

        private void btn_addFoodtoMenu_Click(object sender, EventArgs e)
        {
            AddFoodItemsUI addFoodItemsUI = new AddFoodItemsUI();
            addFoodItemsUI.Show();
            this.Hide();
        }

        private void btn_updatePassword_Click(object sender, EventArgs e)
        {
            UpdatePasswordFormUI updatePasswordFormUI = new UpdatePasswordFormUI();
            updatePasswordFormUI.Show();
            this.Hide();
        }

        private void btn_addServiceProvider_Click(object sender, EventArgs e)
        {
            AddServiceProviderUI addServiceProviderUI = new AddServiceProviderUI();
            addServiceProviderUI.Show();
            this.Hide();
        }

        private void btn_calculateBalance_Click(object sender, EventArgs e)
        {
            BalanceFormUI balanceFormUI = new BalanceFormUI();  
            balanceFormUI.Show();
            this.Hide();
        }

        private void btn_updateFoodItem_Click(object sender, EventArgs e)
        {
            UpdateFoodItemsUI updateFoodItemsUI = new UpdateFoodItemsUI();
            updateFoodItemsUI.Show();
            this.Hide();
        }

        private void btn_deleteFoodItem_Click(object sender, EventArgs e)
        {
            DeleteFoodItemsUI deleteFoodItemsUI = new DeleteFoodItemsUI();
            deleteFoodItemsUI.Show();
            this.Hide();
        }

        private void btn_viewReview_Click(object sender, EventArgs e)
        {
            ViewReviewFormUI viewReviewFormUI = new ViewReviewFormUI();
            viewReviewFormUI.Show();
            this.Hide();
        }

        private void btn_updateServices_Click(object sender, EventArgs e)
        {
            ListofServicesUI listofServicesUI = new ListofServicesUI("UpdateServices");
            listofServicesUI.Show();
            this.Hide();
        }

        private void btn_viewOrders_Click(object sender, EventArgs e)
        {
            ViewOrderFormUI viewOrderFormUI = new ViewOrderFormUI();
            viewOrderFormUI.Show();
            this.Hide();
        }
    }
}
