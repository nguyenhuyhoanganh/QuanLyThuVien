
namespace WindowsFormsApp1
{
    partial class fSachR
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaS = new System.Windows.Forms.Button();
            this.btnSuaS = new System.Windows.Forms.Button();
            this.btnThemS = new System.Windows.Forms.Button();
            this.btnXemS = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpkNgayNhapS = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTenSach = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMaLoaiSach_S = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMaTG_S = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaSach = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txbTimKiemSach = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtTheoTen = new System.Windows.Forms.RadioButton();
            this.rbtTheoMa = new System.Windows.Forms.RadioButton();
            this.dtgvSach = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaS);
            this.groupBox1.Controls.Add(this.btnSuaS);
            this.groupBox1.Controls.Add(this.btnThemS);
            this.groupBox1.Controls.Add(this.btnXemS);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dtgvSach);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 629);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Sách";
            // 
            // btnXoaS
            // 
            this.btnXoaS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnXoaS.ForeColor = System.Drawing.SystemColors.Window;
            this.btnXoaS.Location = new System.Drawing.Point(599, 228);
            this.btnXoaS.Name = "btnXoaS";
            this.btnXoaS.Size = new System.Drawing.Size(75, 35);
            this.btnXoaS.TabIndex = 15;
            this.btnXoaS.Text = "Xóa";
            this.btnXoaS.UseVisualStyleBackColor = false;
            // 
            // btnSuaS
            // 
            this.btnSuaS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnSuaS.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSuaS.Location = new System.Drawing.Point(496, 228);
            this.btnSuaS.Name = "btnSuaS";
            this.btnSuaS.Size = new System.Drawing.Size(75, 35);
            this.btnSuaS.TabIndex = 14;
            this.btnSuaS.Text = "Sửa";
            this.btnSuaS.UseVisualStyleBackColor = false;
            // 
            // btnThemS
            // 
            this.btnThemS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnThemS.ForeColor = System.Drawing.SystemColors.Window;
            this.btnThemS.Location = new System.Drawing.Point(378, 228);
            this.btnThemS.Name = "btnThemS";
            this.btnThemS.Size = new System.Drawing.Size(75, 35);
            this.btnThemS.TabIndex = 13;
            this.btnThemS.Text = "Thêm";
            this.btnThemS.UseVisualStyleBackColor = false;
            this.btnThemS.Click += new System.EventHandler(this.btnThemS_Click);
            // 
            // btnXemS
            // 
            this.btnXemS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnXemS.ForeColor = System.Drawing.SystemColors.Window;
            this.btnXemS.Location = new System.Drawing.Point(275, 228);
            this.btnXemS.Name = "btnXemS";
            this.btnXemS.Size = new System.Drawing.Size(75, 35);
            this.btnXemS.TabIndex = 12;
            this.btnXemS.Text = "Xem";
            this.btnXemS.UseVisualStyleBackColor = false;
            this.btnXemS.Click += new System.EventHandler(this.btnXemS_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtpkNgayNhapS);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(652, 165);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 49);
            this.panel6.TabIndex = 7;
            // 
            // dtpkNgayNhapS
            // 
            this.dtpkNgayNhapS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayNhapS.Location = new System.Drawing.Point(108, 12);
            this.dtpkNgayNhapS.Name = "dtpkNgayNhapS";
            this.dtpkNgayNhapS.Size = new System.Drawing.Size(164, 22);
            this.dtpkNgayNhapS.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Nhập";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.txbTenSach);
            this.panel7.Location = new System.Drawing.Point(334, 165);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 49);
            this.panel7.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên Sách:";
            // 
            // txbTenSach
            // 
            this.txbTenSach.Location = new System.Drawing.Point(108, 11);
            this.txbTenSach.Name = "txbTenSach";
            this.txbTenSach.Size = new System.Drawing.Size(164, 22);
            this.txbTenSach.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.txbMaLoaiSach_S);
            this.panel8.Location = new System.Drawing.Point(16, 165);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(280, 49);
            this.panel8.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã Loại Sách:";
            // 
            // txbMaLoaiSach_S
            // 
            this.txbMaLoaiSach_S.Location = new System.Drawing.Point(108, 11);
            this.txbMaLoaiSach_S.Name = "txbMaLoaiSach_S";
            this.txbMaLoaiSach_S.Size = new System.Drawing.Size(164, 22);
            this.txbMaLoaiSach_S.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbTinhTrang);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(652, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 49);
            this.panel5.TabIndex = 4;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Đang Mượn",
            "Chưa Mượn"});
            this.cbTinhTrang.Location = new System.Drawing.Point(108, 12);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(162, 24);
            this.cbTinhTrang.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tình Trạng:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txbMaTG_S);
            this.panel4.Location = new System.Drawing.Point(334, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 49);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Tác Giả:";
            // 
            // txbMaTG_S
            // 
            this.txbMaTG_S.Location = new System.Drawing.Point(108, 12);
            this.txbMaTG_S.Name = "txbMaTG_S";
            this.txbMaTG_S.Size = new System.Drawing.Size(164, 22);
            this.txbMaTG_S.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txbMaSach);
            this.panel3.Location = new System.Drawing.Point(16, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 49);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Sách:";
            // 
            // txbMaSach
            // 
            this.txbMaSach.Location = new System.Drawing.Point(108, 12);
            this.txbMaSach.Name = "txbMaSach";
            this.txbMaSach.Size = new System.Drawing.Size(164, 22);
            this.txbMaSach.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txbTimKiemSach);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(277, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 83);
            this.panel1.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTimKiem.Location = new System.Drawing.Point(11, 26);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 35);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txbTimKiemSach
            // 
            this.txbTimKiemSach.Location = new System.Drawing.Point(116, 32);
            this.txbTimKiemSach.Name = "txbTimKiemSach";
            this.txbTimKiemSach.Size = new System.Drawing.Size(164, 22);
            this.txbTimKiemSach.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtTheoTen);
            this.panel2.Controls.Add(this.rbtTheoMa);
            this.panel2.Location = new System.Drawing.Point(286, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 76);
            this.panel2.TabIndex = 0;
            // 
            // rbtTheoTen
            // 
            this.rbtTheoTen.AutoSize = true;
            this.rbtTheoTen.Location = new System.Drawing.Point(4, 42);
            this.rbtTheoTen.Name = "rbtTheoTen";
            this.rbtTheoTen.Size = new System.Drawing.Size(91, 21);
            this.rbtTheoTen.TabIndex = 1;
            this.rbtTheoTen.TabStop = true;
            this.rbtTheoTen.Text = "Theo Tên";
            this.rbtTheoTen.UseVisualStyleBackColor = true;
            // 
            // rbtTheoMa
            // 
            this.rbtTheoMa.AutoSize = true;
            this.rbtTheoMa.Location = new System.Drawing.Point(4, 15);
            this.rbtTheoMa.Name = "rbtTheoMa";
            this.rbtTheoMa.Size = new System.Drawing.Size(85, 21);
            this.rbtTheoMa.TabIndex = 0;
            this.rbtTheoMa.TabStop = true;
            this.rbtTheoMa.Text = "Theo Mã";
            this.rbtTheoMa.UseVisualStyleBackColor = true;
            // 
            // dtgvSach
            // 
            this.dtgvSach.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSach.Location = new System.Drawing.Point(9, 291);
            this.dtgvSach.Name = "dtgvSach";
            this.dtgvSach.RowHeadersWidth = 51;
            this.dtgvSach.RowTemplate.Height = 24;
            this.dtgvSach.Size = new System.Drawing.Size(930, 329);
            this.dtgvSach.TabIndex = 0;
            this.dtgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSach_CellClick);
            // 
            // fSachR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 653);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fSachR";
            this.Text = "fSachR";
            this.groupBox1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtTheoTen;
        private System.Windows.Forms.RadioButton rbtTheoMa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txbTimKiemSach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaSach;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTenSach;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMaLoaiSach_S;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMaTG_S;
        private System.Windows.Forms.DateTimePicker dtpkNgayNhapS;
        private System.Windows.Forms.Button btnXoaS;
        private System.Windows.Forms.Button btnSuaS;
        private System.Windows.Forms.Button btnThemS;
        private System.Windows.Forms.Button btnXemS;
        private System.Windows.Forms.ComboBox cbTinhTrang;
    }
}