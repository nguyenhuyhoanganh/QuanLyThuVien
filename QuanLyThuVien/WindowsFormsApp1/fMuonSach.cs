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
    public partial class fMuonSach : Form
    {
        public fMuonSach()
        {
            InitializeComponent();
            LoadDateTimePickerMuon();
            LoadListBook();
            LoadPhieuMuon();
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

                string query = string.Format("update Sach set Sach.tinhtrang = 'True' Where (Sach.masach in (select muon.masach from dbo.Muon) and Sach.masach=N'{0}')", masach);
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Tạo Phiếu mượn thành công!");
                LoadListBook();
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

                    //fManager main = new fManager();
                    //main.Show();
                    this.Close();
                }
                else
                {
                    LoadListBook();
                }
            }
        }

        private void LamMoi_Muon_Click(object sender, EventArgs e)
        {

            LoadListBook();
        }

    }
}
