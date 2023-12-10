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
using static BA.UI.FoodItemsListUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BA.UI
{
    public partial class AddFoodItemsUI : Form
    {
        private string pathServices = "servicesFoodItems.csv";
        private string pathFoodServicesItems = "servicesFoodItems.csv"; 
        private List<ServiceItems> servicelist;

        public AddFoodItemsUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = txt_name.Text;
            string itemPrice = txt_price.Text;
            if(itemName == "" || itemPrice == "")
            {
                MessageBox.Show("Please fill all fields.");
            }
            else
            {
                ServiceItems serviceItems = new ServiceItems(0, "Food", itemName, "", itemPrice);
                serviceItems.setType("Food");
                serviceItems.setName(itemName);
                serviceItems.setPrice(itemPrice);
                bool response = ServiceItemDL.addoneFoodItemList(serviceItems);
                if (response == true)
                {
                    ServiceItemDL.writeOneItemDataInFile(serviceItems, pathFoodServicesItems);
                    MessageBox.Show("Food items has been added successfully!");
                    LoadTableData();
                    txt_name.Text = "";
                    txt_price.Text = "";
                }
                else
                {
                    MessageBox.Show("Error occurred.");
                }
            }
        }

        private void AddFoodItemsUI_Load(object sender, EventArgs e)
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
                dataGridView1.Rows.Add(data.Name, data.Price);
            }

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12, FontStyle.Bold);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        public List<TableData> GetTableData()
        {
            List<TableData> tableData = new List<TableData>();
            servicelist = ServiceItemDL.readData(pathServices, "Food");
            if (servicelist.Count > 0)
            {
                foreach (var item in servicelist)
                {
                    tableData.Add(new TableData { Name = item.getName(), Price = item.getPrice() });
                }
            }
            return tableData;
        }

        private void linklbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboardUI adminDashboardUI = new AdminDashboardUI();
            adminDashboardUI.Show();
            this.Hide();
        }
    }
}
