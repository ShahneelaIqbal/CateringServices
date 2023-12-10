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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BA.UI
{
    public partial class UpdateServicesItemsFormUI : Form
    {
        private string pathServicesItems = "servicesItems.csv";
        private List<ServiceItems> servicelist;

        private string serviceName;
        public UpdateServicesItemsFormUI(string serviceName)
        {
            InitializeComponent();
            this.serviceName = serviceName;
            label1.Text = "Main menu > Services > " + serviceName;
            txt_name.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = txt_name.Text;
            string itemPrice = txt_price.Text;
            if (itemName == "" || itemPrice == "")
            {
                MessageBox.Show("Please select the item.");
            }
            else
            {
                ServiceItems serviceItems = new ServiceItems(0, serviceName , itemName, "", itemPrice);
                serviceItems.setType(serviceName);
                serviceItems.setName(itemName);
                serviceItems.setPrice(itemPrice);
                bool response = ServiceItemDL.UpdateServiceItem(pathServicesItems, serviceItems);
                if (response == true)
                {
                    MessageBox.Show(itemName + " price has been updated successfully!");
                    LoadTableData();
                    txt_name.Text = "";
                    txt_price.Text = "";
                }
                else
                {
                    MessageBox.Show("No record found.");
                }
            }
        }

        private void UpdateServicesItemsFormUI_Load(object sender, EventArgs e)
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
            servicelist = ServiceItemDL.readData(pathServicesItems, serviceName);
            if (servicelist.Count > 0)
            {
                foreach (var item in servicelist)
                {
                    if(item.getName() != "" && item.getPrice() != "")
                    {
                        tableData.Add(new TableData { Name = item.getName(), Price = item.getPrice() });
                    }
                }
            }
            return tableData;
        }

        private void linklbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListofServicesUI listofServicesUI = new ListofServicesUI("UpdateServices");
            listofServicesUI.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txt_price.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
        }
        public class TableData
        {
            public string Name { get; set; }
            public string Price { get; set; }

            public string Item { get; set; }
        }
    }
}
