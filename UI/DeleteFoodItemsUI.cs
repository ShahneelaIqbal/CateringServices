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

namespace BA.UI
{
    public partial class DeleteFoodItemsUI : Form
    {
        private string pathServices = "servicesFoodItems.csv";
        private List<ServiceItems> servicelist;
        private string name = "";
        private string price = "";
        public DeleteFoodItemsUI()
        {
            InitializeComponent();
        }

        private void DeleteFoodItemsUI_Load(object sender, EventArgs e)
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

        private void btn_DeleteItem_Click(object sender, EventArgs e)
        {
            string itemName = this.name;
            string itemPrice = this.price;
            if (itemName == "" || itemPrice == "")
            {
                MessageBox.Show("Please select the item.");
            }
            else
            {
                ServiceItems serviceItems = new ServiceItems(0, "Food", itemName, "", itemPrice);
                serviceItems.setType("Food");
                serviceItems.setName(itemName);
                serviceItems.setPrice(itemPrice);

                bool response = ServiceItemDL.deleteFoodItem(serviceItems);
                if (response == true)
                {
                    bool responseFile = ServiceItemDL.deleteDataInFile(serviceItems, pathServices);
                    if (responseFile)
                    {
                        MessageBox.Show(itemName + " has been deleted successfully!");
                        this.name = "";
                        this.price = "";
                        LoadTableData();
                    }
                    else
                    {
                        MessageBox.Show("Item not found!");
                    }
                }
                else
                {
                    MessageBox.Show("Error Occurred!");
                }

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             this.name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            this.price = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
        }
    }
}
