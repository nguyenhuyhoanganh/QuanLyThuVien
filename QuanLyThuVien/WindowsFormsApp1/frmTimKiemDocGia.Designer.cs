
namespace WindowsFormsApp1
{
    partial class frmTimKiemDocGia
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem_Ma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCanTim = new System.Windows.Forms.TextBox();
            this.TTDocGia_Ma = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenCanTim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem_Ten = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TTDocGia_Ten = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTDocGia_Ma)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTDocGia_Ten)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGreen;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.GroupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tìm kiếm theo mã";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Pink;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm kiếm theo tên";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TTDocGia_Ma);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox1.Location = new System.Drawing.Point(40, 153);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(838, 233);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Thông tin độc giả";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.txtMaCanTim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTimKiem_Ma);
            this.panel1.Location = new System.Drawing.Point(40, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnTimKiem_Ma
            // 
            this.btnTimKiem_Ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem_Ma.Location = new System.Drawing.Point(682, 21);
            this.btnTimKiem_Ma.Name = "btnTimKiem_Ma";
            this.btnTimKiem_Ma.Size = new System.Drawing.Size(105, 32);
            this.btnTimKiem_Ma.TabIndex = 0;
            this.btnTimKiem_Ma.Text = "Tìm kiếm";
            this.btnTimKiem_Ma.UseVisualStyleBackColor = true;
            this.btnTimKiem_Ma.Click += new System.EventHandler(this.btnTimKiem_Ma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã độc giả cần tìm";
            // 
            // txtMaCanTim
            // 
            this.txtMaCanTim.Location = new System.Drawing.Point(269, 21);
            this.txtMaCanTim.Multiline = true;
            this.txtMaCanTim.Name = "txtMaCanTim";
            this.txtMaCanTim.Size = new System.Drawing.Size(365, 32);
            this.txtMaCanTim.TabIndex = 2;
            // 
            // TTDocGia_Ma
            // 
            this.TTDocGia_Ma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TTDocGia_Ma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TTDocGia_Ma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TTDocGia_Ma.Location = new System.Drawing.Point(3, 23);
            this.TTDocGia_Ma.Name = "TTDocGia_Ma";
            this.TTDocGia_Ma.RowHeadersWidth = 51;
            this.TTDocGia_Ma.RowTemplate.Height = 24;
            this.TTDocGia_Ma.Size = new System.Drawing.Size(832, 207);
            this.TTDocGia_Ma.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.txtTenCanTim);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnTimKiem_Ten);
            this.panel2.Location = new System.Drawing.Point(40, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 100);
            this.panel2.TabIndex = 3;
            // 
            // txtTenCanTim
            // 
            this.txtTenCanTim.Location = new System.Drawing.Point(269, 21);
            this.txtTenCanTim.Multiline = true;
            this.txtTenCanTim.Name = "txtTenCanTim";
            this.txtTenCanTim.Size = new System.Drawing.Size(365, 32);
            this.txtTenCanTim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập tên độc giả cần tìm";
            // 
            // btnTimKiem_Ten
            // 
            this.btnTimKiem_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem_Ten.Location = new System.Drawing.Point(682, 21);
            this.btnTimKiem_Ten.Name = "btnTimKiem_Ten";
            this.btnTimKiem_Ten.Size = new System.Drawing.Size(110, 32);
            this.btnTimKiem_Ten.TabIndex = 0;
            this.btnTimKiem_Ten.Text = "Tìm kiếm";
            this.btnTimKiem_Ten.UseVisualStyleBackColor = true;
            this.btnTimKiem_Ten.Click += new System.EventHandler(this.btnTimKiem_Ten_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TTDocGia_Ten);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(40, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 233);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin độc giả";
            // 
            // TTDocGia_Ten
            // 
            this.TTDocGia_Ten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TTDocGia_Ten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TTDocGia_Ten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TTDocGia_Ten.Location = new System.Drawing.Point(3, 23);
            this.TTDocGia_Ten.Name = "TTDocGia_Ten";
            this.TTDocGia_Ten.RowHeadersWidth = 51;
            this.TTDocGia_Ten.RowTemplate.Height = 24;
            this.TTDocGia_Ten.Size = new System.Drawing.Size(832, 207);
            this.TTDocGia_Ten.TabIndex = 0;
            // 
            // frmTimKiemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTimKiemDocGia";
            this.Text = "Tìm kiếm độc giả";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTDocGia_Ma)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TTDocGia_Ten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaCanTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem_Ma;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.DataGridView TTDocGia_Ma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenCanTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem_Ten;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView TTDocGia_Ten;
    }
}