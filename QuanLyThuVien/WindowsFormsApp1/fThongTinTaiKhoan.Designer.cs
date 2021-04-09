namespace WindowsFormsApp1
{
    partial class fThongTinTaiKhoan
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
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbGioiTinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbHoTen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(482, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 46);
            this.panel1.TabIndex = 0;
            // 
            // txbHoTen
            // 
            this.txbHoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txbHoTen.Location = new System.Drawing.Point(79, 9);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.ReadOnly = true;
            this.txbHoTen.Size = new System.Drawing.Size(247, 22);
            this.txbHoTen.TabIndex = 1;
            this.txbHoTen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnDoiMK);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 639);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tài Khoản";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnDoiMK.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDoiMK.Location = new System.Drawing.Point(592, 373);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(130, 46);
            this.btnDoiMK.TabIndex = 5;
            this.btnDoiMK.Text = "Đổi Mật Khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = false;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbSDT);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(482, 310);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(329, 46);
            this.panel5.TabIndex = 4;
            // 
            // txbSDT
            // 
            this.txbSDT.BackColor = System.Drawing.SystemColors.Window;
            this.txbSDT.Location = new System.Drawing.Point(79, 9);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.ReadOnly = true;
            this.txbSDT.Size = new System.Drawing.Size(247, 22);
            this.txbSDT.TabIndex = 1;
            this.txbSDT.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số ĐT:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbDiaChi);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(482, 258);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(329, 46);
            this.panel4.TabIndex = 3;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txbDiaChi.Location = new System.Drawing.Point(79, 9);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.ReadOnly = true;
            this.txbDiaChi.Size = new System.Drawing.Size(247, 22);
            this.txbDiaChi.TabIndex = 1;
            this.txbDiaChi.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbGioiTinh);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(482, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 46);
            this.panel3.TabIndex = 2;
            // 
            // txbGioiTinh
            // 
            this.txbGioiTinh.BackColor = System.Drawing.SystemColors.Window;
            this.txbGioiTinh.Location = new System.Drawing.Point(79, 9);
            this.txbGioiTinh.Name = "txbGioiTinh";
            this.txbGioiTinh.ReadOnly = true;
            this.txbGioiTinh.Size = new System.Drawing.Size(247, 22);
            this.txbGioiTinh.TabIndex = 1;
            this.txbGioiTinh.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới Tính:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpkNgaySinh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(482, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 46);
            this.panel2.TabIndex = 1;
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(79, 9);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(247, 22);
            this.dtpkNgaySinh.TabIndex = 1;
            this.dtpkNgaySinh.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ảnh Đại Diện";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Location = new System.Drawing.Point(130, 97);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(233, 313);
            this.panel6.TabIndex = 7;
            // 
            // fThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 653);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fThongTinTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Tài Khoản";
            this.Load += new System.EventHandler(this.fThongTinTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbGioiTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
    }
}