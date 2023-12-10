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
    public partial class UpdatePasswordFormUI : Form
    {
        private string pathSign = "sign.txt";
        public UpdatePasswordFormUI()
        {
            InitializeComponent();
        }

        private void linklbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboardUI adminDashboardUI = new AdminDashboardUI();
            adminDashboardUI.Show();
            this.Hide();
        }

        private void btn_UpdatePassword_Click(object sender, EventArgs e)
        {
            SignUIForm signUIForm = new SignUIForm("admin");
            string currentPassword = txt_currentPassword.Text;
            string newPassword = txt_newPassword.Text;
            string loginUser = signUIForm.login_Username();
            string loginPassword = signUIForm.login_Password();
            if (currentPassword == "" || newPassword == "")
            {
                MessageBox.Show("Please enter valid input password.");
            }
            else if (loginPassword != currentPassword)
            {
                MessageBox.Show("Current password is not correct. Please try again.");
            }
            else
            {
             
                bool response = SignDL.updatePassword(loginUser, newPassword, pathSign);
                if (response)
                {
                    MessageBox.Show("Password update successfully!");
                    AdminDashboardUI adminDashboardUI = new AdminDashboardUI();
                    adminDashboardUI.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error occurred!");
                }
            }
        }

        private void UpdatePasswordFormUI_Load(object sender, EventArgs e)
        {

        }
    }
}
