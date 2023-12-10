namespace BA.UI
{
    partial class CustomerDashboardFormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboardFormUI));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.btn_addItemToCart = new System.Windows.Forms.Button();
            this.btn_viewCartItems = new System.Windows.Forms.Button();
            this.btn_writeReviews = new System.Windows.Forms.Button();
            this.btn_viewFavorite = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.WelcomeLabel.Location = new System.Drawing.Point(396, 122);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(18, 18, 18, 18);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.WelcomeLabel.Size = new System.Drawing.Size(404, 81);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Toast the Host";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLabel.UseCompatibleTextRendering = true;
            this.WelcomeLabel.UseMnemonic = false;
            // 
            // btn_addItemToCart
            // 
            this.btn_addItemToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_addItemToCart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItemToCart.ForeColor = System.Drawing.Color.White;
            this.btn_addItemToCart.Location = new System.Drawing.Point(290, 279);
            this.btn_addItemToCart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_addItemToCart.Name = "btn_addItemToCart";
            this.btn_addItemToCart.Size = new System.Drawing.Size(198, 142);
            this.btn_addItemToCart.TabIndex = 1;
            this.btn_addItemToCart.Text = "Add items to cart";
            this.btn_addItemToCart.UseVisualStyleBackColor = false;
            this.btn_addItemToCart.Click += new System.EventHandler(this.btn_addItemToCart_Click);
            // 
            // btn_viewCartItems
            // 
            this.btn_viewCartItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_viewCartItems.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewCartItems.ForeColor = System.Drawing.Color.White;
            this.btn_viewCartItems.Location = new System.Drawing.Point(537, 279);
            this.btn_viewCartItems.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_viewCartItems.Name = "btn_viewCartItems";
            this.btn_viewCartItems.Size = new System.Drawing.Size(198, 142);
            this.btn_viewCartItems.TabIndex = 2;
            this.btn_viewCartItems.Text = "View cart items";
            this.btn_viewCartItems.UseVisualStyleBackColor = false;
            this.btn_viewCartItems.Click += new System.EventHandler(this.btn_viewCartItems_Click);
            // 
            // btn_writeReviews
            // 
            this.btn_writeReviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_writeReviews.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_writeReviews.ForeColor = System.Drawing.Color.White;
            this.btn_writeReviews.Location = new System.Drawing.Point(788, 279);
            this.btn_writeReviews.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_writeReviews.Name = "btn_writeReviews";
            this.btn_writeReviews.Size = new System.Drawing.Size(198, 142);
            this.btn_writeReviews.TabIndex = 3;
            this.btn_writeReviews.Text = "Write review";
            this.btn_writeReviews.UseVisualStyleBackColor = false;
            this.btn_writeReviews.Click += new System.EventHandler(this.btn_writeReviews_Click);
            // 
            // btn_viewFavorite
            // 
            this.btn_viewFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_viewFavorite.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewFavorite.ForeColor = System.Drawing.Color.White;
            this.btn_viewFavorite.Location = new System.Drawing.Point(1041, 279);
            this.btn_viewFavorite.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_viewFavorite.Name = "btn_viewFavorite";
            this.btn_viewFavorite.Size = new System.Drawing.Size(198, 142);
            this.btn_viewFavorite.TabIndex = 4;
            this.btn_viewFavorite.Text = "View favorite";
            this.btn_viewFavorite.UseVisualStyleBackColor = false;
            this.btn_viewFavorite.Click += new System.EventHandler(this.btn_viewFavorite_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(1470, 22);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(117, 89);
            this.btn_logout.TabIndex = 11;
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label1.Size = new System.Drawing.Size(160, 47);
            this.label1.TabIndex = 12;
            this.label1.Text = "Main menu";
            // 
            // CustomerDashboardFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1610, 814);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_viewFavorite);
            this.Controls.Add(this.btn_writeReviews);
            this.Controls.Add(this.btn_viewCartItems);
            this.Controls.Add(this.btn_addItemToCart);
            this.Controls.Add(this.WelcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CustomerDashboardFormUI";
            this.Text = "Customer Dashboard";
            this.Load += new System.EventHandler(this.CustomerDashboardFormUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button btn_addItemToCart;
        private System.Windows.Forms.Button btn_viewCartItems;
        private System.Windows.Forms.Button btn_writeReviews;
        private System.Windows.Forms.Button btn_viewFavorite;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
    }
}