using BA.BL;
using BA.DL;
using BA.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA
{
    public partial class Program : Form
    {
        static string loginUser = "";
        private Button btn_Exist;
        private Button btn_Customer;
        private Button btn_Admin;
        private Label WelcomeLabel;
        static string loginPassword = "";

        public Program()
        {
            InitializeComponent();
        }
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program));
            this.btn_Exist = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Exist
            // 
            this.btn_Exist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Exist.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exist.ForeColor = System.Drawing.Color.White;
            this.btn_Exist.Location = new System.Drawing.Point(216, 318);
            this.btn_Exist.Name = "btn_Exist";
            this.btn_Exist.Size = new System.Drawing.Size(146, 58);
            this.btn_Exist.TabIndex = 7;
            this.btn_Exist.Text = "Exist";
            this.btn_Exist.UseVisualStyleBackColor = false;
            this.btn_Exist.Click += new System.EventHandler(this.btn_Exist_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Customer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Customer.Location = new System.Drawing.Point(216, 235);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(146, 58);
            this.btn_Customer.TabIndex = 6;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Admin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.ForeColor = System.Drawing.Color.White;
            this.btn_Admin.Location = new System.Drawing.Point(216, 154);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(146, 58);
            this.btn_Admin.TabIndex = 5;
            this.btn_Admin.Text = "Service Provider";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.WelcomeLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(216, 66);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(10);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Padding = new System.Windows.Forms.Padding(3);
            this.WelcomeLabel.Size = new System.Drawing.Size(230, 47);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Toast the Host";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLabel.UseCompatibleTextRendering = true;
            this.WelcomeLabel.UseMnemonic = false;
            // 
            // Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 441);
            this.Controls.Add(this.btn_Exist);
            this.Controls.Add(this.btn_Customer);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "Program";
            this.Load += new System.EventHandler(this.Program_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Program_Load(object sender, EventArgs e)
        {

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            AdminMainUI adminMainUI = new AdminMainUI("admin");
            adminMainUI.Show();
            this.Hide();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            AdminMainUI adminMainUI = new AdminMainUI("customer");
            adminMainUI.Show();
            this.Hide();
        }

        private void btn_Exist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
