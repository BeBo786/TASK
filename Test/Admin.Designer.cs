namespace Test
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdduser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.uc_Adduser1 = new Test.AdminUC.Uc_Adduser();
            this.uC_Dashbord1 = new Test.AdminUC.UC_Dashbord();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.btnAdduser);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 776);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 671);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dr.Bahaa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(269, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 765);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // btnlogout
            // 
            this.btnlogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnlogout.CheckedState.Parent = this.btnlogout;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.CustomImages.Parent = this.btnlogout;
            this.btnlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.HoverState.Parent = this.btnlogout;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnlogout.Location = new System.Drawing.Point(12, 559);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.ShadowDecoration.Parent = this.btnlogout;
            this.btnlogout.Size = new System.Drawing.Size(263, 45);
            this.btnlogout.TabIndex = 8;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button4.Location = new System.Drawing.Point(12, 490);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(263, 45);
            this.guna2Button4.TabIndex = 7;
            this.guna2Button4.Text = "Profile";
            // 
            // guna2Button3
            // 
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button3.Location = new System.Drawing.Point(12, 418);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(263, 45);
            this.guna2Button3.TabIndex = 6;
            this.guna2Button3.Text = "View User";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnAdduser
            // 
            this.btnAdduser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdduser.CheckedState.Parent = this.btnAdduser;
            this.btnAdduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdduser.CustomImages.Parent = this.btnAdduser;
            this.btnAdduser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdduser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAdduser.ForeColor = System.Drawing.Color.White;
            this.btnAdduser.HoverState.Parent = this.btnAdduser;
            this.btnAdduser.Image = ((System.Drawing.Image)(resources.GetObject("btnAdduser.Image")));
            this.btnAdduser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdduser.Location = new System.Drawing.Point(12, 345);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.ShadowDecoration.Parent = this.btnAdduser;
            this.btnAdduser.Size = new System.Drawing.Size(263, 45);
            this.btnAdduser.TabIndex = 5;
            this.btnAdduser.Text = "Add User";
            this.btnAdduser.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(12, 272);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(263, 45);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashbord";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.White;
            this.btnExit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1320, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedColor = System.Drawing.Color.White;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(38, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // uc_Adduser1
            // 
            this.uc_Adduser1.BackColor = System.Drawing.Color.White;
            this.uc_Adduser1.Location = new System.Drawing.Point(315, -21);
            this.uc_Adduser1.Name = "uc_Adduser1";
            this.uc_Adduser1.Size = new System.Drawing.Size(1119, 765);
            this.uc_Adduser1.TabIndex = 2;
            // 
            // uC_Dashbord1
            // 
            this.uC_Dashbord1.BackColor = System.Drawing.Color.White;
            this.uC_Dashbord1.Location = new System.Drawing.Point(269, 0);
            this.uC_Dashbord1.Name = "uC_Dashbord1";
            this.uC_Dashbord1.Size = new System.Drawing.Size(1101, 765);
            this.uC_Dashbord1.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.uc_Adduser1);
            this.Controls.Add(this.uC_Dashbord1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnAdduser;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AdminUC.UC_Dashbord uC_Dashbord1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AdminUC.Uc_Adduser uc_Adduser1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}