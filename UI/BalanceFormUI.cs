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
    public partial class BalanceFormUI : Form
    {
        private string balancePath = "balance.txt";

        int balanceAmount = 0;
        public BalanceFormUI()
        {
            InitializeComponent();
            balanceAmount = BalanceDL.readData(balancePath);
        }

        private void linklbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboardUI adminDashboardUI = new AdminDashboardUI();
            adminDashboardUI.Show();
            this.Hide();
        }

        private void BalanceFormUI_Load(object sender, EventArgs e)
        {
            this.label2.Text = balanceAmount.ToString();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string amount = txt_amount.Text;
            if (int.Parse(amount) != 0)
            {
                bool res = BalanceDL.storeDataInFile(int.Parse(amount), balancePath);
                if (res)
                {
                    MessageBox.Show("Balance added successfully!");
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}
