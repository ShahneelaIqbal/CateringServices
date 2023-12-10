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
    public partial class AddItemtoCartFormUI : Form
    {
        public string pathServicesItems = "servicesItems.csv";
        private string pathServices = "servicesFoodItems.csv";
        private string pathFavItems = "favoriteItems.csv";
        public string type;
        public AddItemtoCartFormUI(string type)
        {
            InitializeComponent();
            this.type = type;
            if (this.type == "Decoration")
            {
                label1.Text = "Main menu > Add item to cart > Decoration";
            }
            else if (this.type == "Catering")
            {
                label1.Text = "Main menu > Add item to cart > Catering";
            }
            else
            {
                label1.Text = "Main menu > Add item to cart > Food Items";
            }
            txt_name.ReadOnly = true;
            txt_price.ReadOnly = true;
        }

        private void CustomerDecorationFormUI_Load(object sender, EventArgs e)
        {
            LoadTableData();
        }

        public void LoadTableData()
        {
            List<Item> tableData = GetTableData();

            // Clear existing columns (if any)
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Add columns dynamically

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.HeaderText = "Name";
            nameColumn.Width = 180;
            nameColumn.DefaultCellStyle.Font = new Font("Calibri", 12);
            dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.Name = "Price";
            priceColumn.HeaderText = "Price (Rs/.)";
            priceColumn.Width = 180;
            priceColumn.DefaultCellStyle.Font = new Font("Calibri", 12);
            dataGridView1.Columns.Add(priceColumn);

            // Populate rows with data
            foreach (Item data in tableData)
            {
                dataGridView1.Rows.Add(data.Name, data.Price);
            }

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12, FontStyle.Bold);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public List<Item> GetTableData()
        {
            List<Item> tableData = new List<Item>();
            List<ServiceItems> servicelist = new List<ServiceItems>();
            if (this.type == "Decoration")
            {
                servicelist = ServiceItemDL.readData(pathServicesItems, "Decoration");
            }
            else if(this.type == "Catering")
            {
                servicelist = ServiceItemDL.readData(pathServicesItems, "Catering");
            }
            else
            {
                servicelist = ServiceItemDL.readData(pathServices, "Food");
            }
            var temp = "";
            if(servicelist != null)
            {
                if (servicelist.Count > 0)
                {
                    foreach (var item in servicelist)
                    {
                        if (temp != item.getName())
                        {
                            tableData.Add(new Item { Name = item.getName(), Price = item.getPrice() });
                            temp = item.getName();
                        }
                    }

                }
            }
           
            return tableData;
        }

        public void linklbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListofServicesUI listofServicesUI = new ListofServicesUI("Candidate");
            listofServicesUI.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txt_price.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
        }

        private void btn_addItemtoCart_Click(object sender, EventArgs e)
        {
            string itemName = txt_name.Text;
            string itemPrice = txt_price.Text;
            if (itemName == "" || itemPrice == "")
            {
                MessageBox.Show("Please select the item.");
            }
            else
            {
                ServiceItems serviceItems = new ServiceItems(0, this.type, itemName, "", itemPrice);
                serviceItems.setType(this.type);
                serviceItems.setName(itemName);
                serviceItems.setPrice(itemPrice);
                SignUIForm signUIForm = new SignUIForm("candidate");
                string loginUser = signUIForm.login_Username();
                bool response = ServiceItemDL.addItemtoCart(serviceItems, this.type);
                if(response)
                {
                    MessageBox.Show("Item added to cart successfuly!");
                }
                else
                {
                    MessageBox.Show("Error Occurred. Please try again");
                }
            }
        }

        private void btn_addToFavorite_Click(object sender, EventArgs e)
        {
            string itemName = txt_name.Text;
            string itemPrice = txt_price.Text;
            if (itemName == "" || itemPrice == "")
            {
                MessageBox.Show("Please select the item.");
            }
            else
            {
                ServiceItems serviceItems = new ServiceItems(0, this.type, itemName, "", itemPrice);
                serviceItems.setType(this.type);
                serviceItems.setName(itemName);
                serviceItems.setPrice(itemPrice);
                SignUIForm signUIForm = new SignUIForm("candidate");
                string loginUser = signUIForm.login_Username();
                bool response = ServiceItemDL.addItemtoFav(serviceItems, this.type, loginUser, pathFavItems);
                if (response)
                {
                    MessageBox.Show("Fav item added to cart successfuly!");
                }
                else
                {
                    MessageBox.Show("Error Occurred. Please try again");
                }
            }
        }
    }
}
