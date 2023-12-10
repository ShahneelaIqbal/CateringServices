namespace BA.UI
{
    partial class FoodItemsListUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodItemsListUI));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linklbl_Back = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.linklbl_Back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(173, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 287);
            this.panel1.TabIndex = 1;
            // 
            // linklbl_Back
            // 
            this.linklbl_Back.ActiveLinkColor = System.Drawing.Color.White;
            this.linklbl_Back.AutoSize = true;
            this.linklbl_Back.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_Back.ForeColor = System.Drawing.Color.White;
            this.linklbl_Back.LinkColor = System.Drawing.Color.White;
            this.linklbl_Back.Location = new System.Drawing.Point(438, 251);
            this.linklbl_Back.Name = "linklbl_Back";
            this.linklbl_Back.Size = new System.Drawing.Size(41, 19);
            this.linklbl_Back.TabIndex = 15;
            this.linklbl_Back.TabStop = true;
            this.linklbl_Back.Text = "Back";
            this.linklbl_Back.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.linklbl_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_Back_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Main menu > Services > Food service";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 203);
            this.dataGridView1.TabIndex = 4;
            // 
            // FoodItemsListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "FoodItemsListUI";
            this.Text = "Food Services";
            this.Load += new System.EventHandler(this.FoodItemsListUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linklbl_Back;
    }
}