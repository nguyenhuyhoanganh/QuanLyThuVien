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
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }
        DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            string connectionSTR = SQLConStr.conStr;

            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] temp = query.Split(' ');
                    List<string> listPara = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item[0] == '@')
                            listPara.Add(item);
                    }
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.AddWithValue(listPara[i], parameter[i]);
                    }
                }
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
                catch { }

                connection.Close();
            }
            return data;
        }
        int ExecuteNonQuery(string query, object[] parameter = null)
        {
            string connectionSTR = SQLConStr.conStr;

            int acceptedRows = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] temp = query.Split(' ');
                        List<string> listPara = new List<string>();
                        foreach (string item in temp)
                        {
                            if (item[0] == '@')
                                listPara.Add(item);
                        }
                        for (int i = 0; i < parameter.Length; i++)
                        {
                            command.Parameters.AddWithValue(listPara[i], parameter[i]);
                        }
                    }
                    //thực thi câu query chả về số dòng câu truy vấn thực hiện được
                    acceptedRows = -1;

                    acceptedRows = command.ExecuteNonQuery();
                }
                catch { MessageBox.Show("Lỗi Dữ Liệu"); }
                connection.Close();
            }

            return acceptedRows;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable data = ExecuteQuery("Select * from ThuThu where mathuthu =N'" + txbMNV.Text + "'");
            DataTable data3 = ExecuteQuery("Select * from Account where mathuthu =N'" + txbMNV.Text + "'");
            DataTable data2 = ExecuteQuery("Select * from Account where username =N'" + txbTK.Text + "'");
            if ( txbMK.Text != txbNhaplai.Text || txbMK.Text =="")
            {
                MessageBox.Show("Nhập lại mật khẩu!");
            }
            else if(data.Rows.Count != 1)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
            }
            else if (data3.Rows.Count == 1)
            {
                MessageBox.Show("Nhân viên đã có tài khoản!");
            }
            else if (txbTK.Text =="")
            {
                MessageBox.Show("Nhập lại tài khoản!");
            }
            else if (data2.Rows.Count == 1)
            {
                MessageBox.Show("Tài khoản đã tồn tại!");
            }
            else
            {
                int i = ExecuteNonQuery("Insert into Account values(  N'" + txbMNV.Text + "',N'" + txbTK.Text + "', '" + txbMK.Text + "' )");
                if(i!= -1)
                {
                    MessageBox.Show("Đăng ký thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công!");
                }
            }
        }
    }
}
