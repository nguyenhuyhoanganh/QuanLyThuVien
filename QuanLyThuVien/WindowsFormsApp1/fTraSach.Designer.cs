
namespace WindowsFormsApp1
{
    partial class fTraSach
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem_Tra = new System.Windows.Forms.Button();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnLamMoi_Tra = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayTra_Tra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon_Tra = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMaSach_Tra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaDocGia_Tra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDanhSachPhieuMuon = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieu_Tra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuMuon)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnTimKiem_Tra);
            this.groupBox1.Controls.Add(this.txtMaDG);
            this.groupBox1.Controls.Add(this.btnGiaHan);
            this.groupBox1.Controls.Add(this.btnLamMoi_Tra);
            this.groupBox1.Controls.Add(this.btnTra);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpNgayTra_Tra);
            this.groupBox1.Controls.Add(this.dtpNgayMuon_Tra);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgvDanhSachPhieuMuon);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 629);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Trả Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "(Mã)";
            // 
            // btnTimKiem_Tra
            // 
            this.btnTimKiem_Tra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnTimKiem_Tra.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTimKiem_Tra.Location = new System.Drawing.Point(434, 171);
            this.btnTimKiem_Tra.Name = "btnTimKiem_Tra";
            this.btnTimKiem_Tra.Size = new System.Drawing.Size(97, 35);
            this.btnTimKiem_Tra.TabIndex = 21;
            this.btnTimKiem_Tra.Text = "Tìm Kiếm";
            this.btnTimKiem_Tra.UseVisualStyleBackColor = false;
            this.btnTimKiem_Tra.Click += new System.EventHandler(this.btnTimKiem_Tra_Click);
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(583, 177);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(137, 22);
            this.txtMaDG.TabIndex = 20;
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnGiaHan.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGiaHan.Location = new System.Drawing.Point(772, 55);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(94, 47);
            this.btnGiaHan.TabIndex = 19;
            this.btnGiaHan.Text = "Gia Hạn";
            this.btnGiaHan.UseVisualStyleBackColor = false;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click_1);
            // 
            // btnLamMoi_Tra
            // 
            this.btnLamMoi_Tra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnLamMoi_Tra.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLamMoi_Tra.Location = new System.Drawing.Point(772, 165);
            this.btnLamMoi_Tra.Name = "btnLamMoi_Tra";
            this.btnLamMoi_Tra.Size = new System.Drawing.Size(94, 47);
            this.btnLamMoi_Tra.TabIndex = 17;
            this.btnLamMoi_Tra.Text = "Làm Mới";
            this.btnLamMoi_Tra.UseVisualStyleBackColor = false;
            this.btnLamMoi_Tra.Click += new System.EventHandler(this.btnLamMoi_Tra_Click);
            // 
            // btnTra
            // 
            this.btnTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnTra.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTra.Location = new System.Drawing.Point(772, 109);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(94, 47);
            this.btnTra.TabIndex = 16;
            this.btnTra.Text = "Trả Sách";
            this.btnTra.UseVisualStyleBackColor = false;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày mượn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày trả:";
            // 
            // dtpNgayTra_Tra
            // 
            this.dtpNgayTra_Tra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra_Tra.Location = new System.Drawing.Point(539, 120);
            this.dtpNgayTra_Tra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTra_Tra.MaxDate = new System.DateTime(2021, 10, 15, 0, 0, 0, 0);
            this.dtpNgayTra_Tra.MinDate = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            this.dtpNgayTra_Tra.Name = "dtpNgayTra_Tra";
            this.dtpNgayTra_Tra.Size = new System.Drawing.Size(181, 22);
            this.dtpNgayTra_Tra.TabIndex = 11;
            this.dtpNgayTra_Tra.Value = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            // 
            // dtpNgayMuon_Tra
            // 
            this.dtpNgayMuon_Tra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon_Tra.Location = new System.Drawing.Point(539, 67);
            this.dtpNgayMuon_Tra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayMuon_Tra.Name = "dtpNgayMuon_Tra";
            this.dtpNgayMuon_Tra.Size = new System.Drawing.Size(181, 22);
            this.dtpNgayMuon_Tra.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMaSach_Tra);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(83, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 49);
            this.panel3.TabIndex = 5;
            // 
            // txtMaSach_Tra
            // 
            this.txtMaSach_Tra.Location = new System.Drawing.Point(120, 13);
            this.txtMaSach_Tra.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSach_Tra.Name = "txtMaSach_Tra";
            this.txtMaSach_Tra.Size = new System.Drawing.Size(164, 22);
            this.txtMaSach_Tra.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Sách:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaDocGia_Tra);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(83, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 49);
            this.panel2.TabIndex = 5;
            // 
            // txtMaDocGia_Tra
            // 
            this.txtMaDocGia_Tra.Location = new System.Drawing.Point(120, 13);
            this.txtMaDocGia_Tra.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDocGia_Tra.Name = "txtMaDocGia_Tra";
            this.txtMaDocGia_Tra.Size = new System.Drawing.Size(164, 22);
            this.txtMaDocGia_Tra.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Độc Giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thông Tin";
            // 
            // dtgvDanhSachPhieuMuon
            // 
            this.dtgvDanhSachPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachPhieuMuon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvDanhSachPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachPhieuMuon.Location = new System.Drawing.Point(9, 291);
            this.dtgvDanhSachPhieuMuon.Name = "dtgvDanhSachPhieuMuon";
            this.dtgvDanhSachPhieuMuon.RowHeadersWidth = 51;
            this.dtgvDanhSachPhieuMuon.RowTemplate.Height = 24;
            this.dtgvDanhSachPhieuMuon.Size = new System.Drawing.Size(930, 329);
            this.dtgvDanhSachPhieuMuon.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtMaPhieu_Tra);
            this.panel4.Location = new System.Drawing.Point(83, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 49);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Phiếu Mượn:";
            // 
            // txtMaPhieu_Tra
            // 
            this.txtMaPhieu_Tra.Location = new System.Drawing.Point(120, 13);
            this.txtMaPhieu_Tra.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieu_Tra.Name = "txtMaPhieu_Tra";
            this.txtMaPhieu_Tra.Size = new System.Drawing.Size(164, 22);
            this.txtMaPhieu_Tra.TabIndex = 17;
            // 
            // fTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 653);
            this.Controls.Add(this.groupBox1);
            this.Name = "fTraSach";
            this.Text = "fTraSach";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuMuon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi_Tra;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgayTra_Tra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon_Tra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMaSach_Tra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDanhSachPhieuMuon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhieu_Tra;
        private System.Windows.Forms.TextBox txtMaDocGia_Tra;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiem_Tra;
        private System.Windows.Forms.TextBox txtMaDG;
    }
}