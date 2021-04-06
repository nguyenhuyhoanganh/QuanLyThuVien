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
    public partial class fLogin : Form
    {

        public fLogin()
        {
            InitializeComponent();
        }
        bool Login(string tk, string mk)
        {
            DataTable data = new DataTable();
            using (SqlConnection connec = new SqlConnection(SQLConStr.conStr))
            {
                connec.Open();
                string query = "select * from Account where username = '" + tk + "' and pass = '" + mk + "'";
                SqlCommand com = new SqlCommand(query, connec);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                connec.Close();
                try { adapter.Fill(data); }
                catch { }
            }
            return data.Rows.Count > 0;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            if (Login(txbUserName.Text, txbPassWord.Text) == true)
            {
                this.Hide();
                fManager f = new fManager();
                DataTable dt = new DataTable();
                using (SqlConnection connec = new SqlConnection(SQLConStr.conStr))
                {
                    connec.Open();
                    string query = "select tt.hoten,tt.ngaysinh, tt.gioitinh, tt.diachi,tt.sdt,tt.mathuthu  from Account, ThuThu as tt where username = '" + txbUserName.Text + "' and pass = '" + txbPassWord.Text + "'";
                    SqlCommand com = new SqlCommand(query, connec);
                    SqlDataAdapter adapter = new SqlDataAdapter(com);
                    connec.Close();
                    try { adapter.Fill(dt); }
                    catch { }
                }
                
                f.data = dt;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
