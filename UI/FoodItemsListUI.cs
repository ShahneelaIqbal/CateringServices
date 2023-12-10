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
    public partial class FoodItemsListUI : Form
    {
        private string pathServices = "servicesFoodItems.csv";
        private List<ServiceItems> servicelist;
        public FoodItemsListUI()
        {
            InitializeComponent();
        }

        private void FoodItemsListUI_Load(object sender, EventArgs e)
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
            priceColumn.HeaderText = "Price (Rs/person)";
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
            ListofServicesUI listofServicesUI = new ListofServicesUI("ViewServices");
            listofServicesUI.Show();
            this.Hide();
        }

        public class TableData
        {
            public string Name { get; set; }
            public string Price { get; set; }
        }
    }
}
