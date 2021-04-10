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
    public partial class fTimKiemDocGiaR : Form
    {
        SqlConnection conn = new SqlConnection(SQLConStr.conStr);
        public fTimKiemDocGiaR()
        {
            InitializeComponent();
        }
        private void btnTimKiem_Ma_Click(object sender, EventArgs e)
        {
            if (rbtTheoMa.Checked == true)
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM DocGia WHERE madocgia = @madocgia", conn);
                    cmd.Parameters.AddWithValue("@madocgia", txbTimKiemDG.Text);
                    SqlDataReader read = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(read);
                    TTDocGia.DataSource = table;
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM DocGia WHERE hoten LIKE N'%" + txbTimKiemDG.Text + "%'", conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(read);
                    TTDocGia.DataSource = table;
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fTimKiemDocGiaR_Load(object sender, EventArgs e)
        {
            rbtTheoMa.Checked = true;
        }
    }
}
