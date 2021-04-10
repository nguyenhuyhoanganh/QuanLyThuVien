
namespace WindowsFormsApp1
{
    partial class fThongKe
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
            this.button_excel = new System.Windows.Forms.Button();
            this.button_als = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.radioButton_dangmuon = new System.Windows.Forms.RadioButton();
            this.radioButton_trehan = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_sach = new System.Windows.Forms.RadioButton();
            this.radioButton_nguoimuon = new System.Windows.Forms.RadioButton();
            this.dataGridView_report = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_excel);
            this.groupBox1.Controls.Add(this.button_als);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridView_report);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 629);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thông Tin ";
            // 
            // button_excel
            // 
            this.button_excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button_excel.ForeColor = System.Drawing.SystemColors.Window;
            this.button_excel.Location = new System.Drawing.Point(223, 178);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(100, 46);
            this.button_excel.TabIndex = 5;
            this.button_excel.Text = "Xuất Excel";
            this.button_excel.UseVisualStyleBackColor = false;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // button_als
            // 
            this.button_als.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button_als.ForeColor = System.Drawing.SystemColors.Window;
            this.button_als.Location = new System.Drawing.Point(223, 53);
            this.button_als.Name = "button_als";
            this.button_als.Size = new System.Drawing.Size(100, 47);
            this.button_als.TabIndex = 4;
            this.button_als.Text = "Thống Kê";
            this.button_als.UseVisualStyleBackColor = false;
            this.button_als.Click += new System.EventHandler(this.button_als_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_all);
            this.groupBox3.Controls.Add(this.radioButton_dangmuon);
            this.groupBox3.Controls.Add(this.radioButton_trehan);
            this.groupBox3.Location = new System.Drawing.Point(528, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 134);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin";
            // 
            // radioButton_all
            // 
            this.radioButton_all.AutoSize = true;
            this.radioButton_all.Location = new System.Drawing.Point(53, 97);
            this.radioButton_all.Name = "radioButton_all";
            this.radioButton_all.Size = new System.Drawing.Size(71, 21);
            this.radioButton_all.TabIndex = 2;
            this.radioButton_all.TabStop = true;
            this.radioButton_all.Text = "Tất Cả";
            this.radioButton_all.UseVisualStyleBackColor = true;
            // 
            // radioButton_dangmuon
            // 
            this.radioButton_dangmuon.AutoSize = true;
            this.radioButton_dangmuon.Location = new System.Drawing.Point(53, 58);
            this.radioButton_dangmuon.Name = "radioButton_dangmuon";
            this.radioButton_dangmuon.Size = new System.Drawing.Size(102, 21);
            this.radioButton_dangmuon.TabIndex = 1;
            this.radioButton_dangmuon.TabStop = true;
            this.radioButton_dangmuon.Text = "Đang Mượn";
            this.radioButton_dangmuon.UseVisualStyleBackColor = true;
            // 
            // radioButton_trehan
            // 
            this.radioButton_trehan.AutoSize = true;
            this.radioButton_trehan.Location = new System.Drawing.Point(53, 22);
            this.radioButton_trehan.Name = "radioButton_trehan";
            this.radioButton_trehan.Size = new System.Drawing.Size(81, 21);
            this.radioButton_trehan.TabIndex = 0;
            this.radioButton_trehan.TabStop = true;
            this.radioButton_trehan.Text = "Trễ Hạn";
            this.radioButton_trehan.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_sach);
            this.groupBox2.Controls.Add(this.radioButton_nguoimuon);
            this.groupBox2.Location = new System.Drawing.Point(528, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // radioButton_sach
            // 
            this.radioButton_sach.AutoSize = true;
            this.radioButton_sach.Location = new System.Drawing.Point(53, 58);
            this.radioButton_sach.Name = "radioButton_sach";
            this.radioButton_sach.Size = new System.Drawing.Size(134, 21);
            this.radioButton_sach.TabIndex = 1;
            this.radioButton_sach.TabStop = true;
            this.radioButton_sach.Text = "Thông Tin Sách ";
            this.radioButton_sach.UseVisualStyleBackColor = true;
            // 
            // radioButton_nguoimuon
            // 
            this.radioButton_nguoimuon.AutoSize = true;
            this.radioButton_nguoimuon.Location = new System.Drawing.Point(53, 22);
            this.radioButton_nguoimuon.Name = "radioButton_nguoimuon";
            this.radioButton_nguoimuon.Size = new System.Drawing.Size(174, 21);
            this.radioButton_nguoimuon.TabIndex = 0;
            this.radioButton_nguoimuon.TabStop = true;
            this.radioButton_nguoimuon.Text = "Thông Tin Người Mượn";
            this.radioButton_nguoimuon.UseVisualStyleBackColor = true;
            // 
            // dataGridView_report
            // 
            this.dataGridView_report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_report.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_report.Location = new System.Drawing.Point(9, 291);
            this.dataGridView_report.Name = "dataGridView_report";
            this.dataGridView_report.RowHeadersWidth = 51;
            this.dataGridView_report.RowTemplate.Height = 24;
            this.dataGridView_report.Size = new System.Drawing.Size(930, 329);
            this.dataGridView_report.TabIndex = 1;
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 653);
            this.Controls.Add(this.groupBox1);
            this.Name = "fThongKe";
            this.Text = "fThongKe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_report;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_nguoimuon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_dangmuon;
        private System.Windows.Forms.RadioButton radioButton_trehan;
        private System.Windows.Forms.RadioButton radioButton_sach;
        private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.Button button_als;
        private System.Windows.Forms.Label label1;
    }
}