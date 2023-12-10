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
    public partial class DecorationListUI : Form
    {
        public string pathServicesItems = "servicesItems.csv";
        public DecorationListUI()
        {
            InitializeComponent();
        }

        private void DecorationListUI_Load(object sender, EventArgs e)
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

            DataGridViewTextBoxColumn itemColumn = new DataGridViewTextBoxColumn();
            itemColumn.Name = "Item";
            itemColumn.HeaderText = "Item";
            itemColumn.Width = 180;
            itemColumn.DefaultCellStyle.Font = new Font("Calibri", 12);
            itemColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns.Add(itemColumn);

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.Name = "Price";
            priceColumn.HeaderText = "Price (Rs/.)";
            priceColumn.Width = 180;
            priceColumn.DefaultCellStyle.Font = new Font("Calibri", 12);
            dataGridView1.Columns.Add(priceColumn);

            // Populate rows with data
            foreach (Item data in tableData)
            {
                dataGridView1.Rows.Add(data.Name, data.ItemName, data.Price);
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
            List<ServiceItems> servicelist = ServiceItemDL.readData(pathServicesItems, "Decoration");
            var temp = "";
            if(servicelist != null )
            {
                if (servicelist.Count > 0)
                {
                    foreach (var item in servicelist)
                    {
                        if (temp != item.getName())
                        {
                            tableData.Add(new Item { Name = item.getName(), Price = item.getPrice() });

                            List<ServiceItems> itemlist = servicelist.FindAll(x => x.getName() == item.getName()).ToList();

                            for (int i = 0; i < itemlist.Count; i++)
                            {
                                tableData.Add(new Item { ItemName = itemlist[i].getItem() });
                                temp = item.getName();
                            }
                        }
                    }

                }
            }
            return tableData;
        }

        public virtual void linklbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListofServicesUI listofServicesUI = new ListofServicesUI("ViewServices");
            listofServicesUI.Show();
            this.Hide();
        }

    }
}
