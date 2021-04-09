
namespace WindowsFormsApp1
{
    partial class fDangNhapR
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSignin = new Guna.UI2.WinForms.Guna2Button();
            this.btnChangePasswordChar = new Guna.UI2.WinForms.Guna2Button();
            this.iconPassword = new Guna.UI2.WinForms.Guna2Button();
            this.iconUsername = new Guna.UI2.WinForms.Guna2Button();
            this.panelTitleBar = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 81);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChangePasswordChar);
            this.panel2.Controls.Add(this.iconPassword);
            this.panel2.Controls.Add(this.txbPassword);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.iconUsername);
            this.panel2.Controls.Add(this.txbUsername);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 107);
            this.panel2.TabIndex = 2;
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.txbUsername.Location = new System.Drawing.Point(95, 19);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(197, 15);
            this.txbUsername.TabIndex = 3;
            this.txbUsername.Text = "admin";
            this.txbUsername.Click += new System.EventHandler(this.txbUsername_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Location = new System.Drawing.Point(64, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 1);
            this.panel3.TabIndex = 0;
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txbPassword.Location = new System.Drawing.Point(95, 60);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(168, 15);
            this.txbPassword.TabIndex = 6;
            this.txbPassword.Text = "1";
            this.txbPassword.Click += new System.EventHandler(this.txbPassword_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Location = new System.Drawing.Point(64, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 1);
            this.panel4.TabIndex = 5;
            // 
            // btnSignin
            // 
            this.btnSignin.BorderRadius = 8;
            this.btnSignin.CheckedState.Parent = this.btnSignin;
            this.btnSignin.CustomImages.Parent = this.btnSignin;
            this.btnSignin.FillColor = System.Drawing.SystemColors.Window;
            this.btnSignin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnSignin.HoverState.Parent = this.btnSignin;
            this.btnSignin.Image = global::WindowsFormsApp1.Properties.Resources.icons8_login_96B;
            this.btnSignin.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSignin.Location = new System.Drawing.Point(76, 380);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.ShadowDecoration.Parent = this.btnSignin;
            this.btnSignin.Size = new System.Drawing.Size(228, 47);
            this.btnSignin.TabIndex = 5;
            this.btnSignin.Text = "Sign In";
            this.btnSignin.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnChangePasswordChar
            // 
            this.btnChangePasswordChar.CheckedState.Parent = this.btnChangePasswordChar;
            this.btnChangePasswordChar.CustomImages.Parent = this.btnChangePasswordChar;
            this.btnChangePasswordChar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnChangePasswordChar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangePasswordChar.ForeColor = System.Drawing.Color.White;
            this.btnChangePasswordChar.HoverState.Parent = this.btnChangePasswordChar;
            this.btnChangePasswordChar.Image = global::WindowsFormsApp1.Properties.Resources.icons8_eye_96;
            this.btnChangePasswordChar.ImageSize = new System.Drawing.Size(26, 26);
            this.btnChangePasswordChar.Location = new System.Drawing.Point(257, 51);
            this.btnChangePasswordChar.Name = "btnChangePasswordChar";
            this.btnChangePasswordChar.ShadowDecoration.Parent = this.btnChangePasswordChar;
            this.btnChangePasswordChar.Size = new System.Drawing.Size(37, 31);
            this.btnChangePasswordChar.TabIndex = 8;
            this.btnChangePasswordChar.Click += new System.EventHandler(this.btnChangePasswordChar_Click);
            // 
            // iconPassword
            // 
            this.iconPassword.CheckedState.Parent = this.iconPassword;
            this.iconPassword.CustomImages.Parent = this.iconPassword;
            this.iconPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.iconPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconPassword.ForeColor = System.Drawing.Color.White;
            this.iconPassword.HoverState.Parent = this.iconPassword;
            this.iconPassword.Image = global::WindowsFormsApp1.Properties.Resources.icons8_security_shield_green_96;
            this.iconPassword.ImageSize = new System.Drawing.Size(30, 30);
            this.iconPassword.Location = new System.Drawing.Point(54, 51);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.ShadowDecoration.Parent = this.iconPassword;
            this.iconPassword.Size = new System.Drawing.Size(37, 31);
            this.iconPassword.TabIndex = 7;
            // 
            // iconUsername
            // 
            this.iconUsername.CheckedState.Parent = this.iconUsername;
            this.iconUsername.CustomImages.Parent = this.iconUsername;
            this.iconUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.iconUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconUsername.ForeColor = System.Drawing.Color.White;
            this.iconUsername.HoverState.Parent = this.iconUsername;
            this.iconUsername.Image = global::WindowsFormsApp1.Properties.Resources.icons8_male_user_96;
            this.iconUsername.ImageSize = new System.Drawing.Size(30, 30);
            this.iconUsername.Location = new System.Drawing.Point(54, 10);
            this.iconUsername.Name = "iconUsername";
            this.iconUsername.ShadowDecoration.Parent = this.iconUsername;
            this.iconUsername.Size = new System.Drawing.Size(37, 31);
            this.iconUsername.TabIndex = 4;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.CheckedState.Parent = this.panelTitleBar;
            this.panelTitleBar.CustomImages.Parent = this.panelTitleBar;
            this.panelTitleBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panelTitleBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelTitleBar.ForeColor = System.Drawing.Color.White;
            this.panelTitleBar.HoverState.Parent = this.panelTitleBar;
            this.panelTitleBar.Image = global::WindowsFormsApp1.Properties.Resources.icons8_book_shelf_100__1_;
            this.panelTitleBar.ImageSize = new System.Drawing.Size(70, 70);
            this.panelTitleBar.Location = new System.Drawing.Point(122, 111);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.ShadowDecoration.Parent = this.panelTitleBar;
            this.panelTitleBar.Size = new System.Drawing.Size(150, 110);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = global::WindowsFormsApp1.Properties.Resources.icons8_close_window_96;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(349, -3);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(37, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fDangNhapR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDangNhapR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDangNhapR";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button panelTitleBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbUsername;
        private Guna.UI2.WinForms.Guna2Button iconUsername;
        private Guna.UI2.WinForms.Guna2Button iconPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnChangePasswordChar;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnSignin;
    }
}