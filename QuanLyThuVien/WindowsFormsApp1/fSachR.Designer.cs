
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMls = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.datetimeNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.DataGridSach = new System.Windows.Forms.DataGridView();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloaisach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNxb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã tác giả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã nxb:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên sách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tình trạng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(752, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày nhập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(446, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Quản Lý Sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(151, 90);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(100, 22);
            this.txtMaSach.TabIndex = 8;
            // 
            // txtMls
            // 
            this.txtMls.Location = new System.Drawing.Point(151, 143);
            this.txtMls.Name = "txtMls";
            this.txtMls.Size = new System.Drawing.Size(100, 22);
            this.txtMls.TabIndex = 9;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(389, 93);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(100, 22);
            this.txtTacGia.TabIndex = 10;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(625, 91);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(100, 22);
            this.txtTenSach.TabIndex = 12;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbTinhTrang.Location = new System.Drawing.Point(625, 145);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(100, 24);
            this.cbTinhTrang.TabIndex = 13;
            // 
            // datetimeNgayNhap
            // 
            this.datetimeNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.datetimeNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeNgayNhap.Location = new System.Drawing.Point(839, 91);
            this.datetimeNgayNhap.Name = "datetimeNgayNhap";
            this.datetimeNgayNhap.Size = new System.Drawing.Size(100, 22);
            this.datetimeNgayNhap.TabIndex = 14;
            // 
            // DataGridSach
            // 
            this.DataGridSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridSach.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach,
            this.maloaisach,
            this.matg,
            this.manxb,
            this.tensach,
            this.tinhtrang,
            this.ngaynhap});
            this.DataGridSach.Location = new System.Drawing.Point(12, 260);
            this.DataGridSach.Name = "DataGridSach";
            this.DataGridSach.RowHeadersWidth = 51;
            this.DataGridSach.RowTemplate.Height = 24;
            this.DataGridSach.Size = new System.Drawing.Size(948, 381);
            this.DataGridSach.TabIndex = 15;
            this.DataGridSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sach_CellClick);
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.MinimumWidth = 6;
            this.masach.Name = "masach";
            // 
            // maloaisach
            // 
            this.maloaisach.DataPropertyName = "maloaisach";
            this.maloaisach.HeaderText = "Mã loại sách";
            this.maloaisach.MinimumWidth = 6;
            this.maloaisach.Name = "maloaisach";
            // 
            // matg
            // 
            this.matg.DataPropertyName = "matg";
            this.matg.HeaderText = "Mã tác giả";
            this.matg.MinimumWidth = 6;
            this.matg.Name = "matg";
            // 
            // manxb
            // 
            this.manxb.DataPropertyName = "manxb";
            this.manxb.HeaderText = "Mã nxb";
            this.manxb.MinimumWidth = 6;
            this.manxb.Name = "manxb";
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "tensach";
            this.tensach.HeaderText = "Tên sách";
            this.tensach.MinimumWidth = 6;
            this.tensach.Name = "tensach";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.MinimumWidth = 6;
            this.tinhtrang.Name = "tinhtrang";
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.MinimumWidth = 6;
            this.ngaynhap.Name = "ngaynhap";
            // 
            // txtNxb
            // 
            this.txtNxb.Location = new System.Drawing.Point(389, 145);
            this.txtNxb.Name = "txtNxb";
            this.txtNxb.Size = new System.Drawing.Size(100, 22);
            this.txtNxb.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(628, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 45);
            this.button2.TabIndex = 29;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(440, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 45);
            this.button3.TabIndex = 28;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(234, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 45);
            this.button4.TabIndex = 27;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // fSachR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 653);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtNxb);
            this.Controls.Add(this.DataGridSach);
            this.Controls.Add(this.datetimeNgayNhap);
            this.Controls.Add(this.cbTinhTrang);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.txtMls);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fSachR";
            this.Text = "fSachR";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMls;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.DateTimePicker datetimeNgayNhap;
        private System.Windows.Forms.DataGridView DataGridSach;
        private System.Windows.Forms.TextBox txtNxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn matg;
        private System.Windows.Forms.DataGridViewTextBoxColumn manxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}