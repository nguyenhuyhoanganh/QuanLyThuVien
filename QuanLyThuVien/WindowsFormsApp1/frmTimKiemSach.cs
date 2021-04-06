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
    public partial class frmTimKiemSach : Form
    {
        public static string conStr = @"Data Source=localhost;Initial Catalog=QLTV;Integrated Security=True";
        SqlConnection connection = new SqlConnection(conStr);
        public frmTimKiemSach()
        {
            InitializeComponent();
        }
        private void btnTimMa_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Sach WHERE masach = @masach", connection);
                cmd.Parameters.AddWithValue("@masach", txtMaCanTim.Text);
                SqlDataReader read = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(read);
                TTSach_Ma.DataSource = table;
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimTen_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Sach WHERE tensach LIKE N'%" + txtTenCanTim.Text + "%'", connection);
                SqlDataReader read = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(read);
                TTSach_Ten.DataSource = table;
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
