using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class fTheLoai : Form
    {
        public fTheLoai()
        {
            InitializeComponent();
            LoadInformation();
            
        }


        private void ClearDL()
        {
            txtMaLoaiS.Text = "";
            txtTenLoaiS.Text = "";
            txtMoTa.Text = "";
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
        // trả về 1 data table  gọi trong phương thức xem, lấy dữ liệu qua câu truy vấn
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
        // trả về kiểu int, gọi trong phương thức thêm và xoá, kiểu int là số dòng  thực thi thay dổi database




        private void LoadInformation()
        {
            string connectionSTR = SQLConStr.conStr;
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = "select * from LoaiSach";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridTheloaiS.DataSource = data;



        }
        private void TLS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridTheloaiS.CurrentRow.Index;
            txtMaLoaiS.Text =dataGridTheloaiS.Rows[i].Cells[0].Value.ToString();
            txtTenLoaiS.Text = dataGridTheloaiS.Rows[i].Cells[1].Value.ToString();
            txtMoTa.Text = dataGridTheloaiS.Rows[i].Cells[2].Value.ToString();



        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiS.Text != "")
            {
                if (txtTenLoaiS.Text != "")
                {
                    if (txtMoTa.Text != "")
                    {


                        string mls = txtMaLoaiS.Text;

                        string tls =txtTenLoaiS.Text;
                        string mota = txtMoTa.Text;

                        string query = "Insert into LoaiSach values(  N'" + mls.ToString() + "',N'" + tls.ToString() + "',N'" + mota.ToString() + "' )";
                        int i = -1;
                        i = ExecuteNonQuery(query);
                        if (i != -1)
                        {
                            MessageBox.Show("Đã Thêm Thành Công!");


                            LoadInformation();
                            ClearDL();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Không Thành Công!");
                        }



                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập mô tả");
                    }

                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên loại sách");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã loại sách");

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {


            if (txtMaLoaiS.Text != "")
            {
                if (txtTenLoaiS.Text != "")
                {
                    if (txtMoTa.Text != "")
                    {


                        string mls = txtMaLoaiS.Text;

                        string tls = txtTenLoaiS.Text;
                        string mota = txtMoTa.Text;

                        string query = @"update  LoaiSach set maloaisach =  N'" + mls.ToString() + "',tenloaisach = N'" + tls.ToString() + "',mota= N'" + mota.ToString() + "'  where maloaisach=  N'" + mls.ToString() + "' ";
                        int i = -1;
                        i = ExecuteNonQuery(query);
                        if (i != -1)
                        {
                            MessageBox.Show("Đã Sửa Thành Công!");


                            LoadInformation();
                            ClearDL();
                        }
                        else
                        {
                            MessageBox.Show("Sửa Không Thành Công!");
                        }



                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập mô tả");
                    }

                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên loại sách");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã loại sách");

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtMaLoaiS.Text != "")
                {

                    string mls = txtMaLoaiS.Text;

                    string tls = txtTenLoaiS.Text;

                    string mota = txtMoTa.Text;
                    string query = @"exec XoaLoaiS @mls =  N'" + mls.ToString() + "'";
                    int i = -1;
                    i = ExecuteNonQuery(query);
                    if (i != -1)
                    {
                        MessageBox.Show("Đã Xóa Thành Công!");


                        LoadInformation();
                        ClearDL();
                    }


                }
                else
                {
                    MessageBox.Show(" Xóa Không Thành Công!");
                }
            }
        }
    }
}
