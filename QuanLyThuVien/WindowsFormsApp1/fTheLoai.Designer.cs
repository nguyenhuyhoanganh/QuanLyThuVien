namespace WindowsFormsApp1
{
    partial class fTheLoai
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridTheloaiS = new System.Windows.Forms.DataGridView();
            this.maloaisach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaisach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenLoaiS = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtMaLoaiS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTheloaiS)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quản Lý Thể Loại";
            // 
            // dataGridTheloaiS
            // 
            this.dataGridTheloaiS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTheloaiS.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridTheloaiS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTheloaiS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloaisach,
            this.tenloaisach,
            this.mota});
            this.dataGridTheloaiS.Location = new System.Drawing.Point(12, 230);
            this.dataGridTheloaiS.Name = "dataGridTheloaiS";
            this.dataGridTheloaiS.RowHeadersWidth = 51;
            this.dataGridTheloaiS.RowTemplate.Height = 24;
            this.dataGridTheloaiS.Size = new System.Drawing.Size(948, 411);
            this.dataGridTheloaiS.TabIndex = 17;
            this.dataGridTheloaiS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TLS_CellClick);
            // 
            // maloaisach
            // 
            this.maloaisach.DataPropertyName = "maloaisach";
            this.maloaisach.HeaderText = "Mã loại sách";
            this.maloaisach.MinimumWidth = 6;
            this.maloaisach.Name = "maloaisach";
            // 
            // tenloaisach
            // 
            this.tenloaisach.DataPropertyName = "tenloaisach";
            this.tenloaisach.HeaderText = "Tên loại sách";
            this.tenloaisach.MinimumWidth = 6;
            this.tenloaisach.Name = "tenloaisach";
            // 
            // mota
            // 
            this.mota.DataPropertyName = "mota";
            this.mota.HeaderText = "Mô tả";
            this.mota.MinimumWidth = 6;
            this.mota.Name = "mota";
            // 
            // txtTenLoaiS
            // 
            this.txtTenLoaiS.Location = new System.Drawing.Point(422, 91);
            this.txtTenLoaiS.Name = "txtTenLoaiS";
            this.txtTenLoaiS.Size = new System.Drawing.Size(158, 22);
            this.txtTenLoaiS.TabIndex = 16;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(422, 145);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(158, 22);
            this.txtMoTa.TabIndex = 15;
            // 
            // txtMaLoaiS
            // 
            this.txtMaLoaiS.Location = new System.Drawing.Point(422, 45);
            this.txtMaLoaiS.Name = "txtMaLoaiS";
            this.txtMaLoaiS.Size = new System.Drawing.Size(158, 22);
            this.txtMaLoaiS.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên loại sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã loại sách:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(638, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 45);
            this.button2.TabIndex = 26;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(638, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 45);
            this.button3.TabIndex = 25;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(638, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 45);
            this.button4.TabIndex = 24;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // fTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 653);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridTheloaiS);
            this.Controls.Add(this.txtTenLoaiS);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtMaLoaiS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thể Loại Sách";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTheloaiS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridTheloaiS;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.TextBox txtTenLoaiS;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtMaLoaiS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}