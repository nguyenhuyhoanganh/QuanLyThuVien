using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmTimKiemDocGia : Form
    {
        public static string conStr = @"Data Source=localhost;Initial Catalog=QLTV;Integrated Security=True";
        SqlConnection conn = new SqlConnection(conStr);
        public frmTimKiemDocGia()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Ma_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DocGia WHERE madocgia = @madocgia", conn);
                cmd.Parameters.AddWithValue("@madocgia", txtMaCanTim.Text);
                SqlDataReader read = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(read);
                TTDocGia_Ma.DataSource = table;
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Ten_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DocGia WHERE hoten LIKE N'%" + txtTenCanTim.Text + "%'", conn);
                SqlDataReader read = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(read);
                TTDocGia_Ten.DataSource = table;
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
