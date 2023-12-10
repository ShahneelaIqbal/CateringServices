namespace BA.UI
{
    partial class AdminMainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainUI));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.btn_SignUp = new System.Windows.Forms.Button();
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
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Back.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(216, 318);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(146, 58);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Back to home page";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_SignIn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignIn.ForeColor = System.Drawing.Color.White;
            this.btn_SignIn.Location = new System.Drawing.Point(216, 235);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(146, 58);
            this.btn_SignIn.TabIndex = 9;
            this.btn_SignIn.Text = "Sign in";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_SignUp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp.ForeColor = System.Drawing.Color.White;
            this.btn_SignUp.Location = new System.Drawing.Point(216, 154);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(146, 58);
            this.btn_SignUp.TabIndex = 8;
            this.btn_SignUp.Text = "Sign up";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // AdminMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 441);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "AdminMainUI";
            this.Text = "Admin Main";
            this.Load += new System.EventHandler(this.AdminMainUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Button btn_SignUp;
    }
}