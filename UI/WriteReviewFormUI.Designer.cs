namespace BA.UI
{
    partial class WriteReviewFormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteReviewFormUI));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.linklbl_Back = new System.Windows.Forms.LinkLabel();
            this.lbl_review = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_review = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.linklbl_Back);
            this.panel1.Controls.Add(this.lbl_review);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.txt_review);
            this.panel1.Controls.Add(this.txt_name);
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
            this.label1.Size = new System.Drawing.Size(324, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Main menu > Write review";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.White;
            this.btn_submit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_submit.Location = new System.Drawing.Point(191, 356);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(176, 70);
            this.btn_submit.TabIndex = 15;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // linklbl_Back
            // 
            this.linklbl_Back.ActiveLinkColor = System.Drawing.Color.White;
            this.linklbl_Back.AutoSize = true;
            this.linklbl_Back.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_Back.ForeColor = System.Drawing.Color.White;
            this.linklbl_Back.LinkColor = System.Drawing.Color.White;
            this.linklbl_Back.Location = new System.Drawing.Point(535, 390);
            this.linklbl_Back.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linklbl_Back.Name = "linklbl_Back";
            this.linklbl_Back.Size = new System.Drawing.Size(70, 35);
            this.linklbl_Back.TabIndex = 14;
            this.linklbl_Back.TabStop = true;
            this.linklbl_Back.Text = "Back";
            this.linklbl_Back.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.linklbl_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_Back_LinkClicked);
            // 
            // lbl_review
            // 
            this.lbl_review.AutoSize = true;
            this.lbl_review.BackColor = System.Drawing.Color.Transparent;
            this.lbl_review.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_review.ForeColor = System.Drawing.Color.White;
            this.lbl_review.Location = new System.Drawing.Point(59, 218);
            this.lbl_review.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_review.Name = "lbl_review";
            this.lbl_review.Size = new System.Drawing.Size(373, 35);
            this.lbl_review.TabIndex = 13;
            this.lbl_review.Text = "Enter review (good/great/bad)";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(59, 96);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(209, 35);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "Enter your name";
            // 
            // txt_review
            // 
            this.txt_review.BackColor = System.Drawing.Color.White;
            this.txt_review.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_review.ForeColor = System.Drawing.Color.Black;
            this.txt_review.Location = new System.Drawing.Point(57, 260);
            this.txt_review.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_review.MaximumSize = new System.Drawing.Size(455, 40);
            this.txt_review.MinimumSize = new System.Drawing.Size(455, 40);
            this.txt_review.Name = "txt_review";
            this.txt_review.Size = new System.Drawing.Size(455, 42);
            this.txt_review.TabIndex = 11;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(57, 138);
            this.txt_name.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_name.MaximumSize = new System.Drawing.Size(455, 40);
            this.txt_name.MinimumSize = new System.Drawing.Size(455, 40);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(455, 42);
            this.txt_name.TabIndex = 10;
            // 
            // WriteReviewFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1610, 814);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WelcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "WriteReviewFormUI";
            this.Text = "Write Review";
            this.Load += new System.EventHandler(this.WriteReviewFormUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linklbl_Back;
        private System.Windows.Forms.Label lbl_review;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_review;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label1;
    }
}