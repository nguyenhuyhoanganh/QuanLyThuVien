
namespace WindowsFormsApp1
{
    partial class FrmMuonTraSach
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvListBook = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LamMoi_Muon = new System.Windows.Forms.Button();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btnMuon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaThuThu_Muon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieu_Muon = new System.Windows.Forms.TextBox();
            this.cbMaDocGia_Muon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayTra_Muon = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon_Muon = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgvDanhSachPhieuMuon = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaSach_Tra = new System.Windows.Forms.TextBox();
            this.txtMaDocGia_Tra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTimKiem_Tra = new System.Windows.Forms.Button();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.btnThoat_Tra = new System.Windows.Forms.Button();
            this.btnLamMoi_Tra = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaPhieu_Tra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpNgayTra_Tra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon_Tra = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuMuon)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1221, 772);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1213, 743);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mượn sách ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvListBook);
            this.groupBox2.Location = new System.Drawing.Point(8, 240);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1195, 497);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sách ";
            // 
            // dtgvListBook
            // 
            this.dtgvListBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListBook.Location = new System.Drawing.Point(8, 23);
            this.dtgvListBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvListBook.Name = "dtgvListBook";
            this.dtgvListBook.RowHeadersWidth = 51;
            this.dtgvListBook.Size = new System.Drawing.Size(1179, 466);
            this.dtgvListBook.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LamMoi_Muon);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btnMuon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbMaThuThu_Muon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaPhieu_Muon);
            this.groupBox1.Controls.Add(this.cbMaDocGia_Muon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNgayTra_Muon);
            this.groupBox1.Controls.Add(this.dtpNgayMuon_Muon);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1195, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mượn";
            // 
            // LamMoi_Muon
            // 
            this.LamMoi_Muon.Location = new System.Drawing.Point(904, 175);
            this.LamMoi_Muon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LamMoi_Muon.Name = "LamMoi_Muon";
            this.LamMoi_Muon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LamMoi_Muon.Size = new System.Drawing.Size(100, 28);
            this.LamMoi_Muon.TabIndex = 16;
            this.LamMoi_Muon.Text = "Làm mới ";
            this.LamMoi_Muon.UseVisualStyleBackColor = true;
            this.LamMoi_Muon.Click += new System.EventHandler(this.LamMoi_Muon_Click);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(183, 187);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(264, 22);
            this.txtMaSach.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 187);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Mã Sách";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(1057, 175);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_Thoat.TabIndex = 13;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.Location = new System.Drawing.Point(745, 175);
            this.btnMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMuon.Size = new System.Drawing.Size(100, 28);
            this.btnMuon.TabIndex = 11;
            this.btnMuon.Text = "Mượn sách";
            this.btnMuon.UseVisualStyleBackColor = true;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày mượn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày trả:";
            // 
            // cbMaThuThu_Muon
            // 
            this.cbMaThuThu_Muon.FormattingEnabled = true;
            this.cbMaThuThu_Muon.Location = new System.Drawing.Point(183, 149);
            this.cbMaThuThu_Muon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaThuThu_Muon.Name = "cbMaThuThu_Muon";
            this.cbMaThuThu_Muon.Size = new System.Drawing.Size(264, 24);
            this.cbMaThuThu_Muon.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã thủ thư:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã độc giả:";
            // 
            // txtMaPhieu_Muon
            // 
            this.txtMaPhieu_Muon.Location = new System.Drawing.Point(183, 43);
            this.txtMaPhieu_Muon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPhieu_Muon.Name = "txtMaPhieu_Muon";
            this.txtMaPhieu_Muon.Size = new System.Drawing.Size(264, 22);
            this.txtMaPhieu_Muon.TabIndex = 4;
            // 
            // cbMaDocGia_Muon
            // 
            this.cbMaDocGia_Muon.FormattingEnabled = true;
            this.cbMaDocGia_Muon.Location = new System.Drawing.Point(183, 96);
            this.cbMaDocGia_Muon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaDocGia_Muon.Name = "cbMaDocGia_Muon";
            this.cbMaDocGia_Muon.Size = new System.Drawing.Size(264, 24);
            this.cbMaDocGia_Muon.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phiếu mượn:";
            // 
            // dtpNgayTra_Muon
            // 
            this.dtpNgayTra_Muon.Location = new System.Drawing.Point(804, 112);
            this.dtpNgayTra_Muon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayTra_Muon.MaxDate = new System.DateTime(2021, 10, 15, 0, 0, 0, 0);
            this.dtpNgayTra_Muon.MinDate = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            this.dtpNgayTra_Muon.Name = "dtpNgayTra_Muon";
            this.dtpNgayTra_Muon.Size = new System.Drawing.Size(265, 22);
            this.dtpNgayTra_Muon.TabIndex = 1;
            this.dtpNgayTra_Muon.Value = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            // 
            // dtpNgayMuon_Muon
            // 
            this.dtpNgayMuon_Muon.Location = new System.Drawing.Point(804, 39);
            this.dtpNgayMuon_Muon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayMuon_Muon.Name = "dtpNgayMuon_Muon";
            this.dtpNgayMuon_Muon.Size = new System.Drawing.Size(265, 22);
            this.dtpNgayMuon_Muon.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgvDanhSachPhieuMuon);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1213, 743);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trả sách";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgvDanhSachPhieuMuon
            // 
            this.dtgvDanhSachPhieuMuon.AllowUserToAddRows = false;
            this.dtgvDanhSachPhieuMuon.AllowUserToDeleteRows = false;
            this.dtgvDanhSachPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachPhieuMuon.Location = new System.Drawing.Point(8, 283);
            this.dtgvDanhSachPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvDanhSachPhieuMuon.Name = "dtgvDanhSachPhieuMuon";
            this.dtgvDanhSachPhieuMuon.RowHeadersWidth = 51;
            this.dtgvDanhSachPhieuMuon.Size = new System.Drawing.Size(1195, 523);
            this.dtgvDanhSachPhieuMuon.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMaSach_Tra);
            this.groupBox4.Controls.Add(this.txtMaDocGia_Tra);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btnTimKiem_Tra);
            this.groupBox4.Controls.Add(this.txtMaDG);
            this.groupBox4.Controls.Add(this.btnThoat_Tra);
            this.groupBox4.Controls.Add(this.btnLamMoi_Tra);
            this.groupBox4.Controls.Add(this.btnTra);
            this.groupBox4.Controls.Add(this.btnGiaHan);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtMaPhieu_Tra);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.dtpNgayTra_Tra);
            this.groupBox4.Controls.Add(this.dtpNgayMuon_Tra);
            this.groupBox4.Location = new System.Drawing.Point(8, 7);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(1195, 268);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết ";
            // 
            // txtMaSach_Tra
            // 
            this.txtMaSach_Tra.Location = new System.Drawing.Point(185, 130);
            this.txtMaSach_Tra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSach_Tra.Name = "txtMaSach_Tra";
            this.txtMaSach_Tra.Size = new System.Drawing.Size(264, 22);
            this.txtMaSach_Tra.TabIndex = 43;
            // 
            // txtMaDocGia_Tra
            // 
            this.txtMaDocGia_Tra.Location = new System.Drawing.Point(185, 85);
            this.txtMaDocGia_Tra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaDocGia_Tra.Name = "txtMaDocGia_Tra";
            this.txtMaDocGia_Tra.Size = new System.Drawing.Size(264, 22);
            this.txtMaDocGia_Tra.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 226);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "(Mã độc giả )";
            // 
            // btnTimKiem_Tra
            // 
            this.btnTimKiem_Tra.Location = new System.Drawing.Point(8, 188);
            this.btnTimKiem_Tra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem_Tra.Name = "btnTimKiem_Tra";
            this.btnTimKiem_Tra.Size = new System.Drawing.Size(163, 43);
            this.btnTimKiem_Tra.TabIndex = 40;
            this.btnTimKiem_Tra.Text = "Tìm kiếm ";
            this.btnTimKiem_Tra.UseVisualStyleBackColor = true;
            this.btnTimKiem_Tra.Click += new System.EventHandler(this.btnTimKiem_Tra_Click);
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(185, 198);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(321, 22);
            this.txtMaDG.TabIndex = 39;
            // 
            // btnThoat_Tra
            // 
            this.btnThoat_Tra.Location = new System.Drawing.Point(1060, 188);
            this.btnThoat_Tra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat_Tra.Name = "btnThoat_Tra";
            this.btnThoat_Tra.Size = new System.Drawing.Size(100, 28);
            this.btnThoat_Tra.TabIndex = 27;
            this.btnThoat_Tra.Text = "Thoát";
            this.btnThoat_Tra.UseVisualStyleBackColor = true;
            this.btnThoat_Tra.Click += new System.EventHandler(this.btnThoat_Tra_Click);
            // 
            // btnLamMoi_Tra
            // 
            this.btnLamMoi_Tra.Location = new System.Drawing.Point(908, 188);
            this.btnLamMoi_Tra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi_Tra.Name = "btnLamMoi_Tra";
            this.btnLamMoi_Tra.Size = new System.Drawing.Size(100, 28);
            this.btnLamMoi_Tra.TabIndex = 26;
            this.btnLamMoi_Tra.Text = "Làm mới";
            this.btnLamMoi_Tra.UseVisualStyleBackColor = true;
            this.btnLamMoi_Tra.Click += new System.EventHandler(this.btnLamMoi_Tra_Click);
            // 
            // btnTra
            // 
            this.btnTra.Location = new System.Drawing.Point(748, 188);
            this.btnTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(100, 28);
            this.btnTra.TabIndex = 25;
            this.btnTra.Text = "Trả";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Location = new System.Drawing.Point(593, 188);
            this.btnGiaHan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(100, 28);
            this.btnGiaHan.TabIndex = 24;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.UseVisualStyleBackColor = true;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(685, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày mượn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(685, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ngày trả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mã sách :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mã độc giả:";
            // 
            // txtMaPhieu_Tra
            // 
            this.txtMaPhieu_Tra.Location = new System.Drawing.Point(185, 38);
            this.txtMaPhieu_Tra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPhieu_Tra.Name = "txtMaPhieu_Tra";
            this.txtMaPhieu_Tra.Size = new System.Drawing.Size(264, 22);
            this.txtMaPhieu_Tra.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mã phiếu mượn:";
            // 
            // dtpNgayTra_Tra
            // 
            this.dtpNgayTra_Tra.Location = new System.Drawing.Point(807, 126);
            this.dtpNgayTra_Tra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayTra_Tra.Name = "dtpNgayTra_Tra";
            this.dtpNgayTra_Tra.Size = new System.Drawing.Size(265, 22);
            this.dtpNgayTra_Tra.TabIndex = 15;
            // 
            // dtpNgayMuon_Tra
            // 
            this.dtpNgayMuon_Tra.Location = new System.Drawing.Point(807, 53);
            this.dtpNgayMuon_Tra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayMuon_Tra.Name = "dtpNgayMuon_Tra";
            this.dtpNgayMuon_Tra.Size = new System.Drawing.Size(265, 22);
            this.dtpNgayMuon_Tra.TabIndex = 14;
            // 
            // FrmMuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 791);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMuonTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phiếu mượn";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuMuon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhieu_Muon;
        private System.Windows.Forms.ComboBox cbMaDocGia_Muon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayTra_Muon;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon_Muon;
        private System.Windows.Forms.ComboBox cbMaThuThu_Muon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvListBook;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.TextBox txtMaSach_Tra;
        private System.Windows.Forms.TextBox txtMaDocGia_Tra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTimKiem_Tra;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Button btnThoat_Tra;
        private System.Windows.Forms.Button btnLamMoi_Tra;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaPhieu_Tra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgayTra_Tra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon_Tra;
        private System.Windows.Forms.DataGridView dtgvDanhSachPhieuMuon;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button LamMoi_Muon;
    }
}

