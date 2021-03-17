
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
        }

        private void fManager_Load(object sender, EventArgs e)
        {

        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHelp help = new fHelp();
            help.Show();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_report report = new Form_report();
            report.Show();
        }

        private void tìmKếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemSach tksach = new frmTimKiemSach();
            tksach.Show();
        }

        private void tìmKiếmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemDocGia tkdocgia = new frmTimKiemDocGia();
            tkdocgia.Show();
        }

        private void chiTiếtMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMuonTraSach pm= new FrmMuonTraSach();
            pm.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTheLoai loaisach = new fTheLoai();
            loaisach.Show();
           
        }

        private void quảnLýThủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSach sach = new fSach();
            sach.Show();
            
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThuThu thuthu = new FormThuThu();
            thuthu.Show();
           
        }

        private void thôngTinTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDocGia docgia = new FormDocGia();
            docgia.Show();
            
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTacGia tacgia = new fTacGia();
            tacgia.Show();
        }
    }
}
