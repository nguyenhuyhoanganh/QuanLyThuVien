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
    public partial class fDoiMK : Form
    {
        public string a;
        public fDoiMK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            using (SqlConnection connec = new SqlConnection(SQLConStr.conStr))
            {
                connec.Open();
                string query = "select * from Account where mathuthu = '" +a+ "'";
                SqlCommand com = new SqlCommand(query, connec);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                connec.Close();
                try { adapter.Fill(data); }
                catch { }
            }
            if (data.Rows[0]["pass"].ToString() == txbMKcu.Text)
            {
                if (txbMKmoi.Text != txbNhaplai.Text)
                {
                    MessageBox.Show("Mật Khẩu Nhập Lại Không Đúng!");
                }
                else
                {
                    int acceptedRows = -1;
                    string query = "Update Account set pass = '"+txbMKmoi.Text+"'";
                    using (SqlConnection connection = new SqlConnection(SQLConStr.conStr))
                    {

                        connection.Open();

                        SqlCommand command = new SqlCommand(query, connection);
                        
                        try
                        {
                            acceptedRows = command.ExecuteNonQuery();
                        }
                        catch { }
                        connection.Close();
                    }
                    if (acceptedRows > 0)
                    {
                        MessageBox.Show("Đổi Mật Khâu Thành Công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đổi Mật Khẩu Thất Bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Sai Mật Khẩu");
            }
        }
    }
}
