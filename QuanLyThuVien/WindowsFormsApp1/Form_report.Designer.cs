
namespace WindowsFormsApp1
{
    partial class Form_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_report));
            this.dataGridView_report = new System.Windows.Forms.DataGridView();
            this.button_als = new System.Windows.Forms.Button();
            this.button_excel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_nguoimuon = new System.Windows.Forms.RadioButton();
            this.radioButton_sach = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_dangmuon = new System.Windows.Forms.RadioButton();
            this.radioButton_trehan = new System.Windows.Forms.RadioButton();
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_report
            // 
            this.dataGridView_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_report.Location = new System.Drawing.Point(13, 228);
            this.dataGridView_report.Name = "dataGridView_report";
            this.dataGridView_report.RowHeadersWidth = 51;
            this.dataGridView_report.RowTemplate.Height = 24;
            this.dataGridView_report.Size = new System.Drawing.Size(775, 396);
            this.dataGridView_report.TabIndex = 0;
            // 
            // button_als
            // 
            this.button_als.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_als.Image = ((System.Drawing.Image)(resources.GetObject("button_als.Image")));
            this.button_als.Location = new System.Drawing.Point(40, 31);
            this.button_als.Name = "button_als";
            this.button_als.Size = new System.Drawing.Size(128, 75);
            this.button_als.TabIndex = 1;
            this.button_als.Text = "Thống kê";
            this.button_als.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_als.UseVisualStyleBackColor = true;
            this.button_als.Click += new System.EventHandler(this.button_als_Click);
            // 
            // button_excel
            // 
            this.button_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excel.Image = ((System.Drawing.Image)(resources.GetObject("button_excel.Image")));
            this.button_excel.Location = new System.Drawing.Point(165, 31);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(175, 75);
            this.button_excel.TabIndex = 3;
            this.button_excel.Text = "Làm việc với excel";
            this.button_excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_excel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_nguoimuon);
            this.groupBox1.Controls.Add(this.radioButton_sach);
            this.groupBox1.Location = new System.Drawing.Point(388, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo";
            // 
            // radioButton_nguoimuon
            // 
            this.radioButton_nguoimuon.AutoSize = true;
            this.radioButton_nguoimuon.Checked = true;
            this.radioButton_nguoimuon.Location = new System.Drawing.Point(16, 31);
            this.radioButton_nguoimuon.Name = "radioButton_nguoimuon";
            this.radioButton_nguoimuon.Size = new System.Drawing.Size(167, 21);
            this.radioButton_nguoimuon.TabIndex = 5;
            this.radioButton_nguoimuon.TabStop = true;
            this.radioButton_nguoimuon.Text = "Thông tin người mượn";
            this.radioButton_nguoimuon.UseVisualStyleBackColor = true;
            // 
            // radioButton_sach
            // 
            this.radioButton_sach.AutoSize = true;
            this.radioButton_sach.Location = new System.Drawing.Point(189, 31);
            this.radioButton_sach.Name = "radioButton_sach";
            this.radioButton_sach.Size = new System.Drawing.Size(123, 21);
            this.radioButton_sach.TabIndex = 4;
            this.radioButton_sach.TabStop = true;
            this.radioButton_sach.Text = "Thông tin sách";
            this.radioButton_sach.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_dangmuon);
            this.groupBox2.Controls.Add(this.radioButton_trehan);
            this.groupBox2.Controls.Add(this.radioButton_all);
            this.groupBox2.Location = new System.Drawing.Point(361, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 83);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê theo";
            // 
            // radioButton_dangmuon
            // 
            this.radioButton_dangmuon.AutoSize = true;
            this.radioButton_dangmuon.Location = new System.Drawing.Point(296, 31);
            this.radioButton_dangmuon.Name = "radioButton_dangmuon";
            this.radioButton_dangmuon.Size = new System.Drawing.Size(102, 21);
            this.radioButton_dangmuon.TabIndex = 9;
            this.radioButton_dangmuon.TabStop = true;
            this.radioButton_dangmuon.Text = "Đang mượn";
            this.radioButton_dangmuon.UseVisualStyleBackColor = true;
            // 
            // radioButton_trehan
            // 
            this.radioButton_trehan.AutoSize = true;
            this.radioButton_trehan.Location = new System.Drawing.Point(178, 31);
            this.radioButton_trehan.Name = "radioButton_trehan";
            this.radioButton_trehan.Size = new System.Drawing.Size(79, 21);
            this.radioButton_trehan.TabIndex = 8;
            this.radioButton_trehan.TabStop = true;
            this.radioButton_trehan.Text = "Trễ hạn";
            this.radioButton_trehan.UseVisualStyleBackColor = true;
            // 
            // radioButton_all
            // 
            this.radioButton_all.AutoSize = true;
            this.radioButton_all.Checked = true;
            this.radioButton_all.Location = new System.Drawing.Point(17, 31);
            this.radioButton_all.Name = "radioButton_all";
            this.radioButton_all.Size = new System.Drawing.Size(128, 21);
            this.radioButton_all.TabIndex = 7;
            this.radioButton_all.TabStop = true;
            this.radioButton_all.Text = "Tất cả thông tin";
            this.radioButton_all.UseVisualStyleBackColor = true;
            // 
            // Form_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.button_als);
            this.Controls.Add(this.dataGridView_report);
            this.Name = "Form_report";
            this.Text = "Form_report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_report;
        private System.Windows.Forms.Button button_als;
        private System.Windows.Forms.Button button_excel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_nguoimuon;
        private System.Windows.Forms.RadioButton radioButton_sach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_dangmuon;
        private System.Windows.Forms.RadioButton radioButton_trehan;
        private System.Windows.Forms.RadioButton radioButton_all;
    }
}