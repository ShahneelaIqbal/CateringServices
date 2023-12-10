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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace BA.UI
{
    public partial class PlaceOrderFormUI : Form
    {
        private string pathOrder = "orderItems.csv";
        private List<ServiceItems> itemlist = new List<ServiceItems>();
        public PlaceOrderFormUI()
        {
            InitializeComponent();
        }

        private void PlaceOrderFormUI_Load(object sender, EventArgs e)
        {
            LoadTableData();
        }

        public void LoadTableData()
        {
            List<TableData> tableData = GetTableData();

            // Clear existing columns (if any)
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Add columns dynamically
            DataGridViewTextBoxColumn typeColumn = new DataGridViewTextBoxColumn();
            typeColumn.Name = "Service";
            typeColumn.HeaderText = "Service";
            typeColumn.Width = 180;
            typeColumn.DefaultCellStyle.Font = new Font("Calibri", 12);
            dataGridView1.Columns.Add(typeColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.HeaderText = "Name";
            nameColumn.Width = 180;
            nameColumn.DefaultCellStyle.Font = new Font("Calibri", 12);
            dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.Name = "Price";
            priceColumn.HeaderText = "Price";
            priceColumn.Width = 180;
            priceColumn.DefaultCellStyle.Font = new Font("Calibri", 12);
            dataGridView1.Columns.Add(priceColumn);

            // Populate rows with data
            foreach (TableData data in tableData)
            {
                dataGridView1.Rows.Add(data.Type, data.Name, data.Price);
            }

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12, FontStyle.Bold);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        public List<TableData> GetTableData()
        {
            List<TableData> tableData = new List<TableData>();
            itemlist = ServiceItemDL.getCartList();
            if(itemlist != null)
            {
                if (itemlist.Count > 0)
                {
                    foreach (var item in itemlist)
                    {
                        tableData.Add(new TableData { Type = item.getType() ,Name = item.getName(), Price = item.getPrice() }); 
                    }
                }
            }
            return tableData;
        }

        private void linklbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListofServicesUI listofServicesUI = new ListofServicesUI("Candidate");
            listofServicesUI.Show();
            this.Hide();
        }

        public class TableData
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string Price { get; set; }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            int totalPrice = 0;
            string noOfPerson = txt_name.Text;
            int number;
            bool isNumeric = int.TryParse(noOfPerson, out number);
            if (isNumeric)
            {
                for (int i = 0; i < itemlist.Count; i++)
                {
                    if (itemlist[i].getType() == "Food")
                    {
                        totalPrice = totalPrice + (int.Parse(itemlist[i].getPrice()) * number);
                    }
                    else
                    {
                        totalPrice = totalPrice + int.Parse(itemlist[i].getPrice());
                    }
                }
                if(totalPrice!= 0)
                {
                    label2.Text = totalPrice.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid input");
            }
         }

        private void btn_confirOrder_Click(object sender, EventArgs e)
        {
            SignUIForm signUIForm = new SignUIForm("candidate");
            string loginUser = signUIForm.login_Username();

            string noOfPerson = txt_name.Text;
            string totalPrice = label2.Text;
            Order order = new Order(int.Parse(noOfPerson), int.Parse(totalPrice), 1, System.DateTime.Now.Date.ToShortDateString());

            bool orderResponse = ServiceItemDL.ConfirmOrder(loginUser, order, pathOrder);
            if(orderResponse)
            {
                MessageBox.Show("Your order has been confirmed!");
                CustomerDashboardFormUI customerDashboardFormUI = new CustomerDashboardFormUI();
                customerDashboardFormUI.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error Occurred. Please try again");
                txt_name.Text = "";
                label2.Text = "";
            }
        }
    }
}
