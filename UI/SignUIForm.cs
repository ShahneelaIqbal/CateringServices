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
    public partial class SignUIForm : Form
    {
        private string role;
        string pathSign = "sign.txt";
        public static string loginUsername;
        public static string loginPassword;
        public SignUIForm(string role)
        {
            this.role = role;
            InitializeComponent();
            if (this.role == "admin")
            {
                label1.Text = "Please enter your credentials to sign in for Service Provider";
            }
            else
            {
                label1.Text = "Please enter your credentials to sign in for Customer";
            }
            label1.AutoSize = true;
        }

        private void linklbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminMainUI adminMainUI = new AdminMainUI(this.role);
            adminMainUI.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_Password.Text;
            if(username == "" || password == "")
            {
                MessageBox.Show("Please enter valid input credentials");
            }
            else
            {
                SignIn signIn = new SignIn(username, password, this.role);
                signIn.setUserName(username);
                signIn.setPassworde(password);
                SignDL.readData(pathSign, this.role);
                SignIn response = SignDL.isExists(signIn, this.role);
                if (response == null)
                {
                    MessageBox.Show("Invalid credentials");
                }
                else
                {
                    loginUsername = username;
                    loginPassword = password;
                    if(this.role == "admin")
                    {
                        AdminDashboardUI adminDashboardUI = new AdminDashboardUI();
                        adminDashboardUI.Show();
                        this.Hide();
                    }
                    else if(this.role == "customer")
                    {
                        CustomerDashboardFormUI customerDashboardFormUI = new CustomerDashboardFormUI();
                        customerDashboardFormUI.Show();
                        this.Hide();
                    }
                }
            }
        }

        public string login_Username()
        {
            return loginUsername;
        }
        public string login_Password()
        {
            return loginPassword;
        }

        private void SignUIForm_Load(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
