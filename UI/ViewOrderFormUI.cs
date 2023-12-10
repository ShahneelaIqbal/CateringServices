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
    public partial class ViewOrderFormUI : Form
    {
        private string pathOrder = "orderItems.csv";
        public ViewOrderFormUI()
        {
            InitializeComponent();
        }

        private void ViewOrderFormUI_Load(object sender, EventArgs e)
        {
            CreateDynamicDataGridViews();
        }

        private void CreateDynamicDataGridViews()
        {
            List<Order> orderlist = ServiceItemDL.GetViewOrder(pathOrder);
            if(orderlist != null)
            {
                if (orderlist.Count > 0)
                {
                    int count = 1;
                    int labelY = 40;
                    for (int i = 0; i < orderlist.Count; i++)
                    {
                        Label label1 = new Label();
                        label1.Name = "label" + count;
                        label1.Text = "Order no: " + count;
                        label1.AutoSize = true;
                        label1.Location = new Point(20, labelY);
                        label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label1.ForeColor = System.Drawing.Color.White;

                        Label label2 = new Label();
                        label2.Name = "lbl_username";
                        label2.Text = "Username: " + orderlist[i].getName();
                        label2.AutoSize = true;
                        label2.Location = new Point(120, labelY);
                        label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label2.ForeColor = System.Drawing.Color.White;

                        Label label3 = new Label();
                        label3.Name = "lbl_noofPerson";
                        label3.Text = "Total no of person: " + orderlist[i].getTotalNoOfPerson();
                        label3.AutoSize = true;
                        label3.Location = new Point(250, labelY);
                        label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label3.ForeColor = System.Drawing.Color.White;

                        Label label4 = new Label();
                        label4.Name = "lbl_totalAmount";
                        label4.Text = "Total amount: " + orderlist[i].getTotalAmount();
                        label4.AutoSize = true;
                        label4.Location = new Point(450, labelY);
                        label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label4.ForeColor = System.Drawing.Color.White;

                        Label label5 = new Label();
                        label5.Name = "lbl_orderDate";
                        label5.Text = "Order date: " + orderlist[i].getOrderDate();
                        label5.AutoSize = true;
                        label5.Location = new Point(600, labelY);
                        label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label5.ForeColor = System.Drawing.Color.White;

                        panel1.Controls.Add(label1);
                        panel1.Controls.Add(label2);
                        panel1.Controls.Add(label3);
                        panel1.Controls.Add(label4);
                        panel1.Controls.Add(label5);
                        
                        if (orderlist[i].getOrderItems().Count > 0)
                        {
                            // Create a new instance of the DataGridView control
                            DataGridView dataGridView1 = new DataGridView();
                            dataGridView1.Name = "dataGridView1" + i.ToString();
                            dataGridView1.Size = new System.Drawing.Size(545, 150);
                            dataGridView1.Location = new System.Drawing.Point(60, labelY + 20);

                            DataGridViewTextBoxColumn typeColumn = new DataGridViewTextBoxColumn();
                            typeColumn.Name = "Type";
                            typeColumn.HeaderText = "Type";
                            typeColumn.Width = 180;
                            typeColumn.DefaultCellStyle.Font = new Font("Calibri", 12);
                            dataGridView1.Columns.Add(typeColumn);

                            DataGridViewTextBoxColumn onameColumn = new DataGridViewTextBoxColumn();
                            onameColumn.Name = "Name";
                            onameColumn.HeaderText = "Name";
                            onameColumn.Width = 180;
                            onameColumn.DefaultCellStyle.Font = new Font("Calibri", 12);
                            dataGridView1.Columns.Add(onameColumn);

                            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
                            priceColumn.Name = "TotalAmount";
                            priceColumn.HeaderText = "Total amount";
                            priceColumn.Width = 180;
                            priceColumn.DefaultCellStyle.Font = new Font("Calibri", 12);
                            dataGridView1.Columns.Add(priceColumn);

                            for (int j = 0; j < orderlist[i].getOrderItems().Count; j++)
                            {
                                dataGridView1.Rows.Add(orderlist[i].getOrderItems()[j].getType(), orderlist[i].getOrderItems()[j].getName(), orderlist[i].getOrderItems()[j].getPrice());
                            }
                            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12, FontStyle.Bold);
                            dataGridView1.AutoGenerateColumns = false;
                            dataGridView1.RowHeadersVisible = false;
                            dataGridView1.AllowUserToAddRows = false;
                            dataGridView1.ScrollBars = ScrollBars.Both;
                            panel1.Controls.Add(dataGridView1);
                        }

                        labelY += 200;

                        count = count + 1;
                    }
                }
            }
            
        }

        private void linklbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboardUI adminDashboardUI = new AdminDashboardUI();
            adminDashboardUI.Show();
            this.Hide();
        }

        public class TableData
        {
            public string Name { get; set; }
            public string TotalPerson { get; set; }
            public string TotalAmount { get; set; }
            public DateTime OrderDate { get; set; }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDashboardUI adminDashboardUI2 = new AdminDashboardUI();
            adminDashboardUI2.Show();
            this.Hide();
        }
    }
}
