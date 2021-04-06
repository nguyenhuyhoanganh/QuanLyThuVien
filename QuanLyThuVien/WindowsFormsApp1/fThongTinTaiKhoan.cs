using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fThongTinTaiKhoan : Form
    {
        public DataTable dt;
        public fThongTinTaiKhoan()
        {
            InitializeComponent();
            
        }

        /*private void fThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            txbHoTen.Text = dt.Rows[0]["hoten"].ToString();
            dtpkNgaySinh.Value = (DateTime)dt.Rows[0]["ngaysinh"];
            if ((bool)dt.Rows[0]["gioitinh"] == false)
            {
                txbGioiTinh.Text = "Nữ";
            }
            else
                txbGioiTinh.Text = "Nam";
            txbDiaChi.Text = dt.Rows[0]["diachi"].ToString();
            txbSDT.Text = dt.Rows[0]["sdt"].ToString();
        }*/

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            fDoiMK f = new fDoiMK();
            f.a = dt.Rows[0]["mathuthu"].ToString();
            f.Show();
        }
    }
}
