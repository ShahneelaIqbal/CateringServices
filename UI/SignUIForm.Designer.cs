namespace BA.UI
{
    partial class SignUIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUIForm));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.linklbl_Back = new System.Windows.Forms.LinkLabel();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.linklbl_Back);
            this.panel1.Controls.Add(this.lbl_Password);
            this.panel1.Controls.Add(this.lbl_Username);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Location = new System.Drawing.Point(339, 279);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 449);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.MaximumSize = new System.Drawing.Size(532, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Please enter your credentials to sign in";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_login.Location = new System.Drawing.Point(191, 356);
            this.btn_login.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(176, 70);
            this.btn_login.TabIndex = 15;
            this.btn_login.Text = "Sign in";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // linklbl_Back
            // 
            this.linklbl_Back.ActiveLinkColor = System.Drawing.Color.White;
            this.linklbl_Back.AutoSize = true;
            this.linklbl_Back.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_Back.ForeColor = System.Drawing.Color.White;
            this.linklbl_Back.LinkColor = System.Drawing.Color.White;
            this.linklbl_Back.Location = new System.Drawing.Point(548, 391);
            this.linklbl_Back.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linklbl_Back.Name = "linklbl_Back";
            this.linklbl_Back.Size = new System.Drawing.Size(70, 35);
            this.linklbl_Back.TabIndex = 14;
            this.linklbl_Back.TabStop = true;
            this.linklbl_Back.Text = "Back";
            this.linklbl_Back.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.linklbl_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_Back_LinkClicked);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.White;
            this.lbl_Password.Location = new System.Drawing.Point(59, 218);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(126, 35);
            this.lbl_Password.TabIndex = 13;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Username.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.White;
            this.lbl_Username.Location = new System.Drawing.Point(59, 96);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(134, 35);
            this.lbl_Username.TabIndex = 12;
            this.lbl_Username.Text = "Username";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.White;
            this.txt_Password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.Black;
            this.txt_Password.Location = new System.Drawing.Point(57, 260);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Password.MaximumSize = new System.Drawing.Size(455, 40);
            this.txt_Password.MinimumSize = new System.Drawing.Size(455, 40);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(455, 42);
            this.txt_Password.TabIndex = 11;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.Location = new System.Drawing.Point(57, 138);
            this.txt_username.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_username.MaximumSize = new System.Drawing.Size(455, 40);
            this.txt_username.MinimumSize = new System.Drawing.Size(455, 40);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(455, 42);
            this.txt_username.TabIndex = 10;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // SignUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1610, 814);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WelcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SignUIForm";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignUIForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linklbl_Back;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
    }
}