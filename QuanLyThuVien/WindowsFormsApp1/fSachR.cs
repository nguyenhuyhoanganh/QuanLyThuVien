using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class fSachR : Form
    {
        public fSachR()
        {
            InitializeComponent();
        }
        void load()
        {

        }
        private void btnXemS_Click(object sender, EventArgs e)
        {
            dtgvSach.DataSource = DataProvider.Instance.ExecuteQuery("Select * from Sach");
        }

        private void dtgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaSach.DataBindings.Clear();
            txbMaSach.DataBindings.Add("text", dtgvSach.DataSource, "masach");
            txbMaLoaiSach_S.DataBindings.Clear();
            txbMaLoaiSach_S.DataBindings.Add("text", dtgvSach.DataSource, "maloaisach");
            txbMaTG_S.DataBindings.Clear();
            txbMaTG_S.DataBindings.Add("text", dtgvSach.DataSource, "matg");
            txbTenSach.DataBindings.Clear();
            txbTenSach.DataBindings.Add("text", dtgvSach.DataSource, "tensach");
            dtpkNgayNhapS.DataBindings.Clear();
            dtpkNgayNhapS.DataBindings.Add("text", dtgvSach.DataSource, "ngaynhap");
            if (dtgvSach.Rows[e.RowIndex].Cells[5].Value.ToString() == "True")
            {
                cbTinhTrang.Text = "Đang Mượn";
            }
            else
                cbTinhTrang.Text = "Chưa Mượn";

        }
        bool kiemTraEmpty()
        {
            if (txbMaLoaiSach_S.Text == "" && txbMaSach.Text == "" && txbMaTG_S.Text == "" && txbTenSach.Text == "") return false;
            else return true;
        }
        private void btnThemS_Click(object sender, EventArgs e)
        {
            int rez = 0;
            cbTinhTrang.Text = "Chưa Mượn";
            if (kiemTraEmpty())
            {
                try
                {
                    string tinhtrang = "";
                    string ngaynhap = "";
                    if (cbTinhTrang.Text == "Đang Mượn")
                        tinhtrang = "1";
                    else tinhtrang = "0";
                    ngaynhap = dtpkNgayNhapS.Value.ToString("MM/dd/yyyy");
                    string que = "Insert into sach(masach, maloaisach, matg, manxb, tensach, tinhtrang, ngaynhap) values('" + txbMaSach.Text + "','" + txbMaLoaiSach_S.Text + "','" + txbMaTG_S.Text + "','NXB01','" + txbTenSach.Text + "'," + tinhtrang + ", '" + ngaynhap + "')";
                    rez = DataProvider.Instance.ExecuteNonQuery(que);
                    if (rez > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        btnXemS_Click(sender, e);
                    }
                    else MessageBox.Show("Thêm không thành công");
                }
                catch { }
                {
                    MessageBox.Show("Hãy chỉnh sửa thông tin");
                }

            }
            else
            {
                MessageBox.Show("Hãy Thêm Thông Tin!!!");
            }
        }
    }
}
