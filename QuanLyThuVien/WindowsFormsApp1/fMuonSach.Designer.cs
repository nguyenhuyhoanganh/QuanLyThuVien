
namespace WindowsFormsApp1
{
    partial class fMuonSach
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
            this.btnMuon = new System.Windows.Forms.Button();
            this.LamMoi_Muon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayTra_Muon = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon_Muon = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaDocGia_Muon = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaThuThu_Muon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvListBook = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieu_Muon = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBook)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMuon);
            this.groupBox1.Controls.Add(this.LamMoi_Muon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpNgayTra_Muon);
            this.groupBox1.Controls.Add(this.dtpNgayMuon_Muon);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgvListBook);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 629);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách Mượn";
            // 
            // btnMuon
            // 
            this.btnMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnMuon.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMuon.Location = new System.Drawing.Point(546, 156);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(94, 47);
            this.btnMuon.TabIndex = 17;
            this.btnMuon.Text = "Làm Mới";
            this.btnMuon.UseVisualStyleBackColor = false;
            this.btnMuon.Click += new System.EventHandler(this.LamMoi_Muon_Click);
            // 
            // LamMoi_Muon
            // 
            this.LamMoi_Muon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.LamMoi_Muon.ForeColor = System.Drawing.SystemColors.Window;
            this.LamMoi_Muon.Location = new System.Drawing.Point(660, 156);
            this.LamMoi_Muon.Name = "LamMoi_Muon";
            this.LamMoi_Muon.Size = new System.Drawing.Size(94, 47);
            this.LamMoi_Muon.TabIndex = 16;
            this.LamMoi_Muon.Text = "Mượn Sách";
            this.LamMoi_Muon.UseVisualStyleBackColor = false;
            this.LamMoi_Muon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày mượn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày trả:";
            // 
            // dtpNgayTra_Muon
            // 
            this.dtpNgayTra_Muon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra_Muon.Location = new System.Drawing.Point(591, 101);
            this.dtpNgayTra_Muon.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTra_Muon.MaxDate = new System.DateTime(2021, 10, 15, 0, 0, 0, 0);
            this.dtpNgayTra_Muon.MinDate = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            this.dtpNgayTra_Muon.Name = "dtpNgayTra_Muon";
            this.dtpNgayTra_Muon.Size = new System.Drawing.Size(181, 22);
            this.dtpNgayTra_Muon.TabIndex = 11;
            this.dtpNgayTra_Muon.Value = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            // 
            // dtpNgayMuon_Muon
            // 
            this.dtpNgayMuon_Muon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon_Muon.Location = new System.Drawing.Point(591, 43);
            this.dtpNgayMuon_Muon.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayMuon_Muon.Name = "dtpNgayMuon_Muon";
            this.dtpNgayMuon_Muon.Size = new System.Drawing.Size(181, 22);
            this.dtpNgayMuon_Muon.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMaSach);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(135, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 49);
            this.panel3.TabIndex = 5;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(120, 13);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(164, 22);
            this.txtMaSach.TabIndex = 19;
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
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbMaDocGia_Muon);
            this.panel2.Location = new System.Drawing.Point(135, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 49);
            this.panel2.TabIndex = 5;
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
            // cbMaDocGia_Muon
            // 
            this.cbMaDocGia_Muon.FormattingEnabled = true;
            this.cbMaDocGia_Muon.Location = new System.Drawing.Point(120, 13);
            this.cbMaDocGia_Muon.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaDocGia_Muon.Name = "cbMaDocGia_Muon";
            this.cbMaDocGia_Muon.Size = new System.Drawing.Size(164, 24);
            this.cbMaDocGia_Muon.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbMaThuThu_Muon);
            this.panel1.Location = new System.Drawing.Point(135, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 49);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Thủ Thư:";
            // 
            // cbMaThuThu_Muon
            // 
            this.cbMaThuThu_Muon.FormattingEnabled = true;
            this.cbMaThuThu_Muon.Location = new System.Drawing.Point(120, 13);
            this.cbMaThuThu_Muon.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaThuThu_Muon.Name = "cbMaThuThu_Muon";
            this.cbMaThuThu_Muon.Size = new System.Drawing.Size(164, 24);
            this.cbMaThuThu_Muon.TabIndex = 18;
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
            // dtgvListBook
            // 
            this.dtgvListBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListBook.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListBook.Location = new System.Drawing.Point(9, 291);
            this.dtgvListBook.Name = "dtgvListBook";
            this.dtgvListBook.RowHeadersWidth = 51;
            this.dtgvListBook.RowTemplate.Height = 24;
            this.dtgvListBook.Size = new System.Drawing.Size(930, 329);
            this.dtgvListBook.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtMaPhieu_Muon);
            this.panel4.Location = new System.Drawing.Point(135, 30);
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
            // txtMaPhieu_Muon
            // 
            this.txtMaPhieu_Muon.Location = new System.Drawing.Point(120, 13);
            this.txtMaPhieu_Muon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieu_Muon.Name = "txtMaPhieu_Muon";
            this.txtMaPhieu_Muon.Size = new System.Drawing.Size(164, 22);
            this.txtMaPhieu_Muon.TabIndex = 17;
            // 
            // fMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 653);
            this.Controls.Add(this.groupBox1);
            this.Name = "fMuonSach";
            this.Text = "fMuonSach";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBook)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvListBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.ComboBox cbMaDocGia_Muon;
        private System.Windows.Forms.ComboBox cbMaThuThu_Muon;
        private System.Windows.Forms.TextBox txtMaPhieu_Muon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgayTra_Muon;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon_Muon;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.Button LamMoi_Muon;
    }
}