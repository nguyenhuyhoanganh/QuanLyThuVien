using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class fTraSach : Form
    {
        BindingSource PhieuMuonList = new BindingSource();

        public fTraSach()
        {
            InitializeComponent();
            LoadListMuon();
            LoadThongTinTra();
        }
        void LoadListMuon()
        {
            dtgvDanhSachPhieuMuon.DataSource = PhieuMuonList;
            PhieuMuonList.DataSource = MuonDAO.Instance.GetListMuon();
        }

        void LoadThongTinTra()
        {
            txtMaPhieu_Tra.DataBindings.Add(new Binding("Text", dtgvDanhSachPhieuMuon.DataSource, "Mamuon", true, DataSourceUpdateMode.Never));
            txtMaDocGia_Tra.DataBindings.Add(new Binding("Text", dtgvDanhSachPhieuMuon.DataSource, "Madocgia", true, DataSourceUpdateMode.Never));
            txtMaSach_Tra.DataBindings.Add(new Binding("Text", dtgvDanhSachPhieuMuon.DataSource, "Masach", true, DataSourceUpdateMode.Never));
            dtpNgayMuon_Tra.DataBindings.Add(new Binding("Text", dtgvDanhSachPhieuMuon.DataSource, "Ngaymuon", true, DataSourceUpdateMode.Never));
            dtpNgayTra_Tra.DataBindings.Add(new Binding("Text", dtgvDanhSachPhieuMuon.DataSource, "Ngaytra", true, DataSourceUpdateMode.Never));
        }

        private void btnTimKiem_Tra_Click(object sender, EventArgs e)
        {
            dtgvDanhSachPhieuMuon.DataSource = PhieuMuonList;
            string ma = txtMaDG.Text;
            string query = string.Format("Select * from Muon where tinhtrangmuon = 'True' and madocgia like '%{0}%'", ma);
            PhieuMuonList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }



        private void btnGiaHan_Click_1(object sender, EventArgs e)
        {
            dtgvDanhSachPhieuMuon.DataSource = PhieuMuonList;
            string mamuon = txtMaPhieu_Tra.Text;
            string madocgia = txtMaDocGia_Tra.Text;
            string masach = txtMaSach_Tra.Text;
            DateTime ngaymuon = dtpNgayMuon_Tra.Value;
            DateTime ngaytra = dtpNgayTra_Tra.Value;
            string query = string.Format("Update dbo.Muon set ngaytra = dateadd(day,5,ngaytra) where mamuon ='{0}' and madocgia = '{1}' and masach = '{2}' and ngaymuon = '{3}' and ngaytra='{4}' and tinhtrangmuon='True'", mamuon, madocgia, masach, ngaymuon, ngaytra);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
            {
                MessageBox.Show("Gia hạn thành công!");
            }
            else
            {
                MessageBox.Show("Có lỗi khi gia hạn phiếu mượn");
            }
        }

        private void btnLamMoi_Tra_Click(object sender, EventArgs e)
        {
            dtgvDanhSachPhieuMuon.DataSource = PhieuMuonList;
            string query = "Select * from Muon where tinhtrangmuon ='True' ";
            PhieuMuonList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            {

                string mamuon = txtMaPhieu_Tra.Text;
                string madocgia = txtMaDocGia_Tra.Text;
                string masach = txtMaSach_Tra.Text;
                DateTime ngaymuon = dtpNgayMuon_Tra.Value;
                DateTime ngaytra = dtpNgayTra_Tra.Value;
                string query = string.Format("Update dbo.Muon set tinhtrangmuon = 'False' where mamuon ='{0}' and madocgia = '{1}' and masach = '{2}' and ngaymuon = '{3}' and ngaytra='{4}' and tinhtrangmuon='True'", mamuon, madocgia, masach, ngaymuon, ngaytra);
                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                {
                    string query1 = string.Format("Update dbo.Sach set tinhtrang = 'False' where (masach in (select Muon.masach from Muon where tinhtrangmuon = 'False') and masach ='{0}' )", masach);
                    DataProvider.Instance.ExecuteNonQuery(query1);
                    MessageBox.Show("Trả sách thành công !");

                }
                else
                {
                    MessageBox.Show("Có lỗi khi trả sách ");
                }
            }
        }
    }

}
