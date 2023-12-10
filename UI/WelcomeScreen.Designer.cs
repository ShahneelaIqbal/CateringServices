namespace BA.UI
{
    partial class WelcomeScreen
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Exist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.WelcomeLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.WelcomeLabel.Location = new System.Drawing.Point(0, 19);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(10);
            this.WelcomeLabel.MinimumSize = new System.Drawing.Size(799, 50);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Padding = new System.Windows.Forms.Padding(3);
            this.WelcomeLabel.Size = new System.Drawing.Size(799, 50);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Host the Toast";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLabel.UseCompatibleTextRendering = true;
            this.WelcomeLabel.UseMnemonic = false;
            this.WelcomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Location = new System.Drawing.Point(205, 124);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(146, 58);
            this.btn_Admin.TabIndex = 1;
            this.btn_Admin.Text = "Admin";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Location = new System.Drawing.Point(443, 124);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(146, 58);
            this.btn_Customer.TabIndex = 2;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Exist
            // 
            this.btn_Exist.Location = new System.Drawing.Point(324, 219);
            this.btn_Exist.Name = "btn_Exist";
            this.btn_Exist.Size = new System.Drawing.Size(146, 58);
            this.btn_Exist.TabIndex = 3;
            this.btn_Exist.Text = "Exist";
            this.btn_Exist.UseVisualStyleBackColor = true;
            this.btn_Exist.Click += new System.EventHandler(this.btn_Exist_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(135)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exist);
            this.Controls.Add(this.btn_Customer);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "WelcomeScreen";
            this.Text = "WelcomeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Exist;
    }
}