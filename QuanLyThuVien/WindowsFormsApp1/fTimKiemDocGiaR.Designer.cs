
namespace WindowsFormsApp1
{
    partial class fTimKiemDocGiaR
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
            this.label1 = new System.Windows.Forms.Label();
            this.TTDocGia = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txbTimKiemDG = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtTheoTen = new System.Windows.Forms.RadioButton();
            this.rbtTheoMa = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTDocGia)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TTDocGia);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 629);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Độc Giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông Tin Độc Giả";
            // 
            // TTDocGia
            // 
            this.TTDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TTDocGia.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TTDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TTDocGia.Location = new System.Drawing.Point(9, 291);
            this.TTDocGia.Name = "TTDocGia";
            this.TTDocGia.RowHeadersWidth = 51;
            this.TTDocGia.RowTemplate.Height = 24;
            this.TTDocGia.Size = new System.Drawing.Size(930, 329);
            this.TTDocGia.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txbTimKiemDG);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(277, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 83);
            this.panel1.TabIndex = 2;
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
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Ma_Click);
            // 
            // txbTimKiemDG
            // 
            this.txbTimKiemDG.Location = new System.Drawing.Point(116, 32);
            this.txbTimKiemDG.Name = "txbTimKiemDG";
            this.txbTimKiemDG.Size = new System.Drawing.Size(164, 22);
            this.txbTimKiemDG.TabIndex = 1;
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
            // fTimKiemDocGiaR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 653);
            this.Controls.Add(this.groupBox1);
            this.Name = "fTimKiemDocGiaR";
            this.Text = "fTimKiemDocGiaR";
            this.Load += new System.EventHandler(this.fTimKiemDocGiaR_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTDocGia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TTDocGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txbTimKiemDG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtTheoTen;
        private System.Windows.Forms.RadioButton rbtTheoMa;
    }
}