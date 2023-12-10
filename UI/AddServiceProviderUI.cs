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
    public partial class AddServiceProviderUI : Form
    {
        private string pathSign = "sign.txt";
        public AddServiceProviderUI()
        {
            InitializeComponent();
        }

        private void linklbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboardUI adminMainUI = new AdminDashboardUI();
            adminMainUI.Show();
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_Password.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter valid input credentials.");
            }
            else
            {
                SignIn sigup = new SignIn(username, password, "admin");
                sigup.setUserName(username);
                sigup.setPassworde(password);
                int response = SignDL.addServiceProviderIntoList(sigup);
                if (response == 1)
                {
                    int response1 = SignDL.storeDataInFile(sigup, pathSign);
                    if (response1 == 2)
                    {
                        MessageBox.Show("Service provider has been added successfully!");
                    }
                    else if (response1 == 1)
                    {
                        MessageBox.Show("Same username already exist.");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong.");
                    }
                }
                else if (response == 0)
                {
                    MessageBox.Show("You cannot add more service providers.");
                }
                else if (response == 2)
                {
                    MessageBox.Show("Username cannot be empty. Please try again.");
                }
                else
                {
                    MessageBox.Show("Same username & password already exists.");
                }
            }
        }

        private void AddServiceProviderUI_Load(object sender, EventArgs e)
        {

        }
    }
}
