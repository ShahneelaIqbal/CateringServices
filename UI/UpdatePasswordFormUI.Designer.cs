namespace BA.UI
{
    partial class UpdatePasswordFormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePasswordFormUI));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_UpdatePassword = new System.Windows.Forms.Button();
            this.linklbl_Back = new System.Windows.Forms.LinkLabel();
            this.lbl_currentPassword = new System.Windows.Forms.Label();
            this.lbl_newPassword = new System.Windows.Forms.Label();
            this.txt_currentPassword = new System.Windows.Forms.TextBox();
            this.txt_newPassword = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.btn_UpdatePassword);
            this.panel1.Controls.Add(this.linklbl_Back);
            this.panel1.Controls.Add(this.lbl_currentPassword);
            this.panel1.Controls.Add(this.lbl_newPassword);
            this.panel1.Controls.Add(this.txt_currentPassword);
            this.panel1.Controls.Add(this.txt_newPassword);
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
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Main menu > Update password";
            // 
            // btn_UpdatePassword
            // 
            this.btn_UpdatePassword.BackColor = System.Drawing.Color.White;
            this.btn_UpdatePassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdatePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_UpdatePassword.Location = new System.Drawing.Point(191, 356);
            this.btn_UpdatePassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_UpdatePassword.Name = "btn_UpdatePassword";
            this.btn_UpdatePassword.Size = new System.Drawing.Size(176, 70);
            this.btn_UpdatePassword.TabIndex = 15;
            this.btn_UpdatePassword.Text = "Submit";
            this.btn_UpdatePassword.UseVisualStyleBackColor = false;
            this.btn_UpdatePassword.Click += new System.EventHandler(this.btn_UpdatePassword_Click);
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
            // lbl_currentPassword
            // 
            this.lbl_currentPassword.AutoSize = true;
            this.lbl_currentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_currentPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentPassword.ForeColor = System.Drawing.Color.White;
            this.lbl_currentPassword.Location = new System.Drawing.Point(59, 96);
            this.lbl_currentPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_currentPassword.Name = "lbl_currentPassword";
            this.lbl_currentPassword.Size = new System.Drawing.Size(222, 35);
            this.lbl_currentPassword.TabIndex = 13;
            this.lbl_currentPassword.Text = "Current password";
            // 
            // lbl_newPassword
            // 
            this.lbl_newPassword.AutoSize = true;
            this.lbl_newPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_newPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newPassword.ForeColor = System.Drawing.Color.White;
            this.lbl_newPassword.Location = new System.Drawing.Point(59, 218);
            this.lbl_newPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_newPassword.Name = "lbl_newPassword";
            this.lbl_newPassword.Size = new System.Drawing.Size(186, 35);
            this.lbl_newPassword.TabIndex = 12;
            this.lbl_newPassword.Text = "New password";
            // 
            // txt_currentPassword
            // 
            this.txt_currentPassword.BackColor = System.Drawing.Color.White;
            this.txt_currentPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currentPassword.ForeColor = System.Drawing.Color.Black;
            this.txt_currentPassword.Location = new System.Drawing.Point(57, 138);
            this.txt_currentPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_currentPassword.MaximumSize = new System.Drawing.Size(455, 40);
            this.txt_currentPassword.MinimumSize = new System.Drawing.Size(455, 40);
            this.txt_currentPassword.Name = "txt_currentPassword";
            this.txt_currentPassword.Size = new System.Drawing.Size(455, 42);
            this.txt_currentPassword.TabIndex = 11;
            // 
            // txt_newPassword
            // 
            this.txt_newPassword.BackColor = System.Drawing.Color.White;
            this.txt_newPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newPassword.ForeColor = System.Drawing.Color.Black;
            this.txt_newPassword.Location = new System.Drawing.Point(57, 260);
            this.txt_newPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_newPassword.MaximumSize = new System.Drawing.Size(455, 40);
            this.txt_newPassword.MinimumSize = new System.Drawing.Size(455, 40);
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.Size = new System.Drawing.Size(455, 42);
            this.txt_newPassword.TabIndex = 10;
            // 
            // UpdatePasswordFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1610, 814);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WelcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UpdatePasswordFormUI";
            this.Text = "Update Password";
            this.Load += new System.EventHandler(this.UpdatePasswordFormUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linklbl_Back;
        private System.Windows.Forms.Label lbl_currentPassword;
        private System.Windows.Forms.Label lbl_newPassword;
        private System.Windows.Forms.TextBox txt_currentPassword;
        private System.Windows.Forms.TextBox txt_newPassword;
        private System.Windows.Forms.Button btn_UpdatePassword;
        private System.Windows.Forms.Label label1;
    }
}