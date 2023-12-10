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
    public partial class ListofServicesUI : Form
    {
        private string pathServices = "services.csv";
        private List<MenuServices> servicelist;
        private List<MenuServices> buttonNames;
        private string type;
        public ListofServicesUI(string type)
        {
            InitializeComponent();
            this.type = type;
            if (this.type == "ViewServices" || this.type == "Candidate")
            {
                label1.Text = "Main menu > View list of services";
            }
            else
            {
                label1.Text = "Main menu > Update services";
            }
        }

        private void ListofServicesUI_Load(object sender, EventArgs e)
        {
            servicelist = AdminDL.readData(pathServices);
            buttonNames = new List<MenuServices>();

            if (this.type == "ViewServices" || this.type == "Candidate")
            {
                if (servicelist.Count > 0)
                {
                    for (int i = 0; i < servicelist.Count; i++)
                    {
                        MenuServices menuServices = new MenuServices(servicelist[i].menuServiceName, servicelist[i].menuServiceCode);
                        buttonNames.Add(menuServices);
                    }
                }
            }
            else if (this.type == "UpdateServices")
            {
                if (servicelist.Count > 0)
                {
                    for (int i = 0; i < servicelist.Count; i++)
                    {
                        if (servicelist[i].menuServiceName != "Food Service")
                        {
                            MenuServices menuServices = new MenuServices(servicelist[i].menuServiceName, servicelist[i].menuServiceCode);
                            buttonNames.Add(menuServices);
                        }
                    }
                }
            }

            CreateButtons();
        }

        private void CreateButtons()
        {
            foreach (MenuServices buttonName in buttonNames)
            {
                Button button = new Button();
                if(buttonName.menuServiceName == "Decoration")
                {
                    button.Location = new System.Drawing.Point(231, 151);
                }
                else if (buttonName.menuServiceName == "Catering")
                {
                    button.Location = new System.Drawing.Point(360, 151);
                }
                else if (buttonName.menuServiceName == "Food Service")
                {
                    button.Location = new System.Drawing.Point(492, 151);
                }
                button.Text = buttonName.menuServiceName; 
                button.Name = "button_" + buttonName.menuServiceCode; 
                button.Click += Button_Click;
                button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
                button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = System.Drawing.Color.White;
                button.Size = new System.Drawing.Size(108, 77);
                button.TabIndex = 1;
                button.UseVisualStyleBackColor = false;
                this.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Handle button click event here
            Button button = (Button)sender;
            if(button.Name == "button_" + 1) // Decoration
            {
                if(this.type == "ViewServices")
                {
                    DecorationListUI decorationListUI = new DecorationListUI();
                    decorationListUI.Show();
                    this.Hide();
                }
                else if(this.type == "Candidate")
                {
                    AddItemtoCartFormUI childObj = new AddItemtoCartFormUI("Decoration");
                    childObj.Show();
                    this.Hide();
                }
                else
                {
                    UpdateServicesItemsFormUI updateServicesItemsFormUI = new UpdateServicesItemsFormUI("Decoration");
                    updateServicesItemsFormUI.Show();
                    this.Hide();
                }
                
            }
            else if (button.Name == "button_" + 2) // Caterging
            {
                if (this.type == "ViewServices")
                {
                    CateringListUI cateringListUI = new CateringListUI();
                    cateringListUI.Show();
                    this.Hide();
                }
                else if (this.type == "Candidate")
                {
                    AddItemtoCartFormUI childObj = new AddItemtoCartFormUI("Catering");
                    childObj.Show();
                    this.Hide();
                }
                else
                {
                    UpdateServicesItemsFormUI updateServicesItemsFormUI = new UpdateServicesItemsFormUI("Catering");
                    updateServicesItemsFormUI.Show();
                    this.Hide();
                }
            }
            else if (button.Name == "button_" + 3) // Food
            {
                if (this.type == "Candidate")
                {
                    AddItemtoCartFormUI childObj = new AddItemtoCartFormUI("Food");
                    childObj.Show();
                    this.Hide();
                }
                else
                {
                    FoodItemsListUI foodItemsListUI = new FoodItemsListUI();
                    foodItemsListUI.Show();
                    this.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.type == "Candidate")
            {
                CustomerDashboardFormUI customerDashboardFormUI = new CustomerDashboardFormUI();
                customerDashboardFormUI.Show();
                this.Hide();
            }
            else
            {
                AdminDashboardUI adminDashboardUI = new AdminDashboardUI();
                adminDashboardUI.Show();
                this.Hide();
            }
        }
    }
}
