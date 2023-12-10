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
    public partial class SignUpUI : Form
    {
        private string role;
        string pathSign = "sign.txt";
        public SignUpUI(string role)
        {
            this.role = role;
            InitializeComponent();
            if(this.role == "admin")
            {
                label1.Text = "Please enter the inputs to sign up for Service Provider";
            }
            else
            {
                label1.Text = "Please enter the inputs to sign up for Customer";
            }
            label1.AutoSize = true;
        }

        private void linklbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminMainUI adminMainUI = new AdminMainUI(this.role);
            adminMainUI.Show();
            this.Hide();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_Password.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter valid input credentials");
            }
            else
            {
                SignIn signIn = new SignIn(username, password, this.role);
                signIn.setUserName(username);
                signIn.setPassworde(password);
                SignDL.addIntoList(signIn, this.role);
                SignDL.storeDataInFile(signIn, pathSign);
                MessageBox.Show("You have signed up successfully");
            }  
        }

        private void SignUpUI_Load(object sender, EventArgs e)
        {

        }
    }
}
