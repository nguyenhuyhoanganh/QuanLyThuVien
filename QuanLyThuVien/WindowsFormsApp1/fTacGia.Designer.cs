namespace WindowsFormsApp1
{
    partial class fTacGia
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
            this.txtMaTg = new System.Windows.Forms.TextBox();
            this.txtLienHe = new System.Windows.Forms.TextBox();
            this.txtTenTg = new System.Windows.Forms.TextBox();
            this.dataGridTacGia = new System.Windows.Forms.DataGridView();
            this.matg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lienhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tác giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tác giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liên hệ:";
            // 
            // txtMaTg
            // 
            this.txtMaTg.Location = new System.Drawing.Point(408, 50);
            this.txtMaTg.Name = "txtMaTg";
            this.txtMaTg.Size = new System.Drawing.Size(158, 22);
            this.txtMaTg.TabIndex = 3;
            // 
            // txtLienHe
            // 
            this.txtLienHe.Location = new System.Drawing.Point(408, 150);
            this.txtLienHe.Name = "txtLienHe";
            this.txtLienHe.Size = new System.Drawing.Size(158, 22);
            this.txtLienHe.TabIndex = 4;
            // 
            // txtTenTg
            // 
            this.txtTenTg.Location = new System.Drawing.Point(408, 96);
            this.txtTenTg.Name = "txtTenTg";
            this.txtTenTg.Size = new System.Drawing.Size(158, 22);
            this.txtTenTg.TabIndex = 5;
            // 
            // dataGridTacGia
            // 
            this.dataGridTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTacGia.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matg,
            this.tentg,
            this.lienhe});
            this.dataGridTacGia.Location = new System.Drawing.Point(12, 230);
            this.dataGridTacGia.Name = "dataGridTacGia";
            this.dataGridTacGia.RowHeadersWidth = 51;
            this.dataGridTacGia.RowTemplate.Height = 24;
            this.dataGridTacGia.Size = new System.Drawing.Size(948, 411);
            this.dataGridTacGia.TabIndex = 6;
            this.dataGridTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TG_CellClick);
            // 
            // matg
            // 
            this.matg.DataPropertyName = "matg";
            this.matg.HeaderText = "Mã tác giả";
            this.matg.MinimumWidth = 6;
            this.matg.Name = "matg";
            // 
            // tentg
            // 
            this.tentg.DataPropertyName = "tentg";
            this.tentg.HeaderText = "Tên tác giả";
            this.tentg.MinimumWidth = 6;
            this.tentg.Name = "tentg";
            // 
            // lienhe
            // 
            this.lienhe.DataPropertyName = "lienhe";
            this.lienhe.HeaderText = "Liên hệ";
            this.lienhe.MinimumWidth = 6;
            this.lienhe.Name = "lienhe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quản Lý Tác Giả";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(636, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 45);
            this.button2.TabIndex = 29;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.AutoSizeChanged += new System.EventHandler(this.btnXoa_Click);
            this.button2.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(636, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 45);
            this.button3.TabIndex = 28;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.AutoSizeChanged += new System.EventHandler(this.btnSua_Click);
            this.button3.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(636, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 45);
            this.button4.TabIndex = 27;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.AutoSizeChanged += new System.EventHandler(this.btnThem_Click);
            this.button4.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // fTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 653);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridTacGia);
            this.Controls.Add(this.txtTenTg);
            this.Controls.Add(this.txtLienHe);
            this.Controls.Add(this.txtMaTg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tác Giả";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaTg;
        private System.Windows.Forms.TextBox txtLienHe;
        private System.Windows.Forms.TextBox txtTenTg;
        private System.Windows.Forms.DataGridView dataGridTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn matg;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentg;
        private System.Windows.Forms.DataGridViewTextBoxColumn lienhe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}