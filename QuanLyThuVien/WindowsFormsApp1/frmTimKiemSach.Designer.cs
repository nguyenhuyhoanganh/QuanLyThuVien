
namespace WindowsFormsApp1
{
    partial class frmTimKiemSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemSach));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TTSach_Ma = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimMa = new System.Windows.Forms.Button();
            this.txtMaCanTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TTSach_Ten = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimTen = new System.Windows.Forms.Button();
            this.txtTenCanTim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTSach_Ma)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTSach_Ten)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(972, 653);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GreenYellow;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(964, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tìm kiếm theo mã";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TTSach_Ma);
            this.groupBox1.Location = new System.Drawing.Point(38, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // TTSach_Ma
            // 
            this.TTSach_Ma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TTSach_Ma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TTSach_Ma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TTSach_Ma.Location = new System.Drawing.Point(3, 18);
            this.TTSach_Ma.Name = "TTSach_Ma";
            this.TTSach_Ma.RowHeadersWidth = 51;
            this.TTSach_Ma.RowTemplate.Height = 24;
            this.TTSach_Ma.Size = new System.Drawing.Size(862, 206);
            this.TTSach_Ma.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.btnTimMa);
            this.panel1.Controls.Add(this.txtMaCanTim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(41, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnTimMa
            // 
            this.btnTimMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMa.Location = new System.Drawing.Point(600, 27);
            this.btnTimMa.Name = "btnTimMa";
            this.btnTimMa.Size = new System.Drawing.Size(121, 33);
            this.btnTimMa.TabIndex = 2;
            this.btnTimMa.Text = "Tìm kiếm";
            this.btnTimMa.UseVisualStyleBackColor = true;
            this.btnTimMa.Click += new System.EventHandler(this.btnTimMa_Click);
            // 
            // txtMaCanTim
            // 
            this.txtMaCanTim.Location = new System.Drawing.Point(252, 27);
            this.txtMaCanTim.Multiline = true;
            this.txtMaCanTim.Name = "txtMaCanTim";
            this.txtMaCanTim.Size = new System.Drawing.Size(298, 33);
            this.txtMaCanTim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã sách cần tìm";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGreen;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm kiếm theo tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TTSach_Ten);
            this.groupBox2.Location = new System.Drawing.Point(36, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 227);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            // 
            // TTSach_Ten
            // 
            this.TTSach_Ten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TTSach_Ten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TTSach_Ten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TTSach_Ten.Location = new System.Drawing.Point(3, 18);
            this.TTSach_Ten.Name = "TTSach_Ten";
            this.TTSach_Ten.RowHeadersWidth = 51;
            this.TTSach_Ten.RowTemplate.Height = 24;
            this.TTSach_Ten.Size = new System.Drawing.Size(862, 206);
            this.TTSach_Ten.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.btnTimTen);
            this.panel2.Controls.Add(this.txtTenCanTim);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(39, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 100);
            this.panel2.TabIndex = 2;
            // 
            // btnTimTen
            // 
            this.btnTimTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTen.Location = new System.Drawing.Point(598, 29);
            this.btnTimTen.Name = "btnTimTen";
            this.btnTimTen.Size = new System.Drawing.Size(97, 31);
            this.btnTimTen.TabIndex = 2;
            this.btnTimTen.Text = "Tìm kiếm";
            this.btnTimTen.UseVisualStyleBackColor = true;
            this.btnTimTen.Click += new System.EventHandler(this.btnTimTen_Click);
            // 
            // txtTenCanTim
            // 
            this.txtTenCanTim.Location = new System.Drawing.Point(244, 29);
            this.txtTenCanTim.Multiline = true;
            this.txtTenCanTim.Name = "txtTenCanTim";
            this.txtTenCanTim.Size = new System.Drawing.Size(294, 31);
            this.txtTenCanTim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập tên sách cần tìm";
            // 
            // frmTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 653);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimKiemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm sách";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TTSach_Ma)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TTSach_Ten)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TTSach_Ma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimMa;
        private System.Windows.Forms.TextBox txtMaCanTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView TTSach_Ten;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTimTen;
        private System.Windows.Forms.TextBox txtTenCanTim;
        private System.Windows.Forms.Label label2;
    }
}