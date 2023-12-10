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
using static BA.UI.ViewReviewFormUI;

namespace BA.UI
{
    public partial class ViewFavoriteFormUI : Form
    {
        private string pathFavItems = "favoriteItems.csv";
        public ViewFavoriteFormUI()
        {
            InitializeComponent();
        }

        private void linklbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerDashboardFormUI customerFormUI = new CustomerDashboardFormUI();
            customerFormUI.Show();
            this.Hide();
        }

        private void ViewFavoriteFormUI_Load(object sender, EventArgs e)
        {
            LoadTableData();
        }

        public void LoadTableData()
        {
            List<FavTableData> tableData = GetTableData();

            // Add columns dynamically
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Type";
            nameColumn.HeaderText = "Type";
            nameColumn.Width = 180;
            nameColumn.DefaultCellStyle.Font = new Font("Calibri", 12);
            dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn reviewColumn = new DataGridViewTextBoxColumn();
            reviewColumn.Name = "Name";
            reviewColumn.HeaderText = "Name";
            reviewColumn.Width = 180;
            reviewColumn.DefaultCellStyle.Font = new Font("Calibri", 12);
            dataGridView1.Columns.Add(reviewColumn);

            // Populate rows with data
            foreach (FavTableData data in tableData)
            {
                dataGridView1.Rows.Add(data.Type, data.Name);
            }

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12, FontStyle.Bold);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        public List<FavTableData> GetTableData()
        {
            SignUIForm signUIForm = new SignUIForm("candidate");
            string loginUser = signUIForm.login_Username();
            List<ServiceItems> favlist = ServiceItemDL.readFavItemData(pathFavItems, loginUser);

            List<FavTableData> tableData = new List<FavTableData>();
            if(favlist != null)
            {
                if (favlist.Count > 0)
                {
                    foreach (var item in favlist)
                    {
                        tableData.Add(new FavTableData { Type = item.getType(), Name = item.getName() });
                    }
                }
            }
            return tableData;
        }

        public class FavTableData
        {
            public string Type { get; set; }
            public string Name { get; set; }
        }
    }
}
