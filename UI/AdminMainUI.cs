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
    public partial class AdminMainUI : Form
    {
        private string role;
        public AdminMainUI(string role)
        {
            this.role = role;
            InitializeComponent();
        }

        private void AdminMainUI_Load(object sender, EventArgs e)
        {

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SignUpUI signUpUI = new SignUpUI(this.role);
            signUpUI.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Program program = new Program();
            program.Show();
            this.Hide();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            SignUIForm signUIForm = new SignUIForm(this.role);
            signUIForm.Show();
            this.Hide();
        }

    }
}
