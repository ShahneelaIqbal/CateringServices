using BA.BL;
using BA.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BA.UI.FoodItemsListUI;

namespace BA.UI
{
    public partial class ViewReviewFormUI : Form
    {
        private string reviewPath = "review.txt";
        private List<Review> reviewlist;
        public ViewReviewFormUI()
        {
            InitializeComponent();
        }

        private void linklbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboardUI adminDashboardFormUI = new AdminDashboardUI();
            adminDashboardFormUI.Show();
            this.Hide();
        }

        private void ViewReviewFormUI_Load(object sender, EventArgs e)
        {
            LoadTableData();
        }

        public void LoadTableData()
        {
            List<ReviewTableData> tableData = GetTableData();

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

            DataGridViewTextBoxColumn reviewColumn = new DataGridViewTextBoxColumn();
            reviewColumn.Name = "Review";
            reviewColumn.HeaderText = "Review";
            reviewColumn.Width = 180;
            reviewColumn.DefaultCellStyle.Font = new Font("Calibri", 12);
            dataGridView1.Columns.Add(reviewColumn);

            // Populate rows with data
            foreach (ReviewTableData data in tableData)
            {
                dataGridView1.Rows.Add(data.Name, data.Review);
            }

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12, FontStyle.Bold);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        public List<ReviewTableData> GetTableData()
        {
            List<ReviewTableData> tableData = new List<ReviewTableData>();
            reviewlist = ReviewDL.viewReview(reviewPath);
            if (reviewlist.Count > 0)
            {
                foreach (var item in reviewlist)
                {
                    tableData.Add(new ReviewTableData { Name = item.getName(), Review = item.getReview() });
                }
            }
            return tableData;
        }

        public class ReviewTableData
        {
            public string Name { get; set; }
            public string Review { get; set; }
        }

    }
}
