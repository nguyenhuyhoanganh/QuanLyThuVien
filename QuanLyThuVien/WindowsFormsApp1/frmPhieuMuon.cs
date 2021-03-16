using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.DAO;
using System.Data.SqlClient;
using WindowsFormsApp1;

namespace QLTV
{
    public partial class FrmMuonTraSach : Form
    {
        BindingSource PhieuMuonList = new BindingSource();
        public FrmMuonTraSach()
        {
            InitializeComponent();
            LoadDateTimePickerMuon();
            LoadListBook();
            LoadPhieuMuon();
            LoadListMuon();
            LoadThongTinTra();
        }


        void LoadDateTimePickerMuon()
        {
            DateTime today = DateTime.Now;
            dtpNgayMuon_Muon.Value = new DateTime(today.Year, today.Month, today.Day);
            dtpNgayTra_Muon.Value = dtpNgayMuon_Muon.Value.AddDays(5);
            dtpNgayTra_Muon.MaxDate = today.AddDays(30);
        }

        public void LoadListBook()
        {
            string query = "select * from Sach where tinhtrang = 'False'";
            dtgvListBook.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadPhieuMuon()
        {
            txtMaSach.DataBindings.Add(new Binding("Text", dtgvListBook.DataSource, "Masach"));
            cbMaDocGia_Muon.DataSource = DataProvider.Instance.ExecuteQuery("Select * from dbo.docgia");
            cbMaDocGia_Muon.DisplayMember = "madocgia";
            cbMaDocGia_Muon.ValueMember = "madocgia";
            cbMaThuThu_Muon.DataSource = DataProvider.Instance.ExecuteQuery("Select * from dbo.Thuthu");
            cbMaThuThu_Muon.DisplayMember = "mathuthu";
            cbMaThuThu_Muon.ValueMember = "mathuthu";
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            string mamuon = txtMaPhieu_Muon.Text;
            string mathuthu = cbMaThuThu_Muon.Text;
            string madocgia = cbMaDocGia_Muon.Text;
            string masach = txtMaSach.Text;
            DateTime ngaymuon = dtpNgayMuon_Muon.Value;
            DateTime ngaytra = dtpNgayTra_Muon.Value;
            int tinhtrangmuon = 1;

            if (MuonDAO.Instance.InsertPM(mamuon, mathuthu, madocgia, masach, ngaymuon, ngaytra, tinhtrangmuon))
            {
                
                string query = string.Format("update Sach set Sach.tinhtrang = 'True' Where (Sach.masach in (select muon.masach from dbo.Muon) and Sach.masach={0})",masach);
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Tạo Phiếu mượn thành công!");
            }
            else
            {
                MessageBox.Show("Có lỗi khi tạo phiếu mượn");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    fManager main = new fManager();
                    main.Show();
                    this.Close();
                }
                else
                {
                    LoadListBook();
                }
            }
        }

        void LoadListMuon()
        {
            dtgvDanhSachPhieuMuon.DataSource = PhieuMuonList;
            PhieuMuonList.DataSource = MuonDAO.Instance.GetListMuon();
        }

        void LoadThongTinTra()
        {
            txtMaPhieu_Tra.DataBindings.Add(new Binding("Text", dtgvDanhSachPhieuMuon.DataSource, "Mamuon",true,DataSourceUpdateMode.Never));
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
            if (DataProvider.Instance.ExecuteNonQuery(query)>0)
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
                    string query1 = string.Format("Update dbo.Sach set tinhtrang = 'False' where (masach in (select Muon.masach from Muon where tinhtrangmuon = 'False') and masach ='{0}' )",masach);
                    DataProvider.Instance.ExecuteNonQuery(query1);
                    MessageBox.Show("Trả sách thành công !");
                    
                }
                else
                {
                    MessageBox.Show("Có lỗi khi trả sách ");
                }
            }
        }

        private void LamMoi_Muon_Click(object sender, EventArgs e)
        {

            LoadListBook();
        }

        private void btnThoat_Tra_Click(object sender, EventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    fManager main = new fManager();
                    main.Show();
                    this.Close();
                }
                else
                {
                    LoadListBook();
                }
            }
        }

        
    }    
}
