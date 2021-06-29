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
    public partial class fSachR : Form
    {
        public fSachR()
        {
            InitializeComponent();
            LoadInformation();
        }
        private void ClearDL()
        {
            txtMaSach.Text = "";
            txtMls.Text = "";
            txtTacGia.Text = "";
            txtTenSach.Text = "";
            datetimeNgayNhap.Text = "";
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
            string query = "select * from Sach";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            DataGridSach.DataSource = data;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "")
            {
                if (txtMls.Text != "")
                {
                    if (txtTacGia.Text != "")
                    {


                        if (txtTenSach.Text != "")
                        {

                                if (datetimeNgayNhap.Text != "")
                                {
                                    string masach = txtMaSach.Text;
                                    string mls = txtMls.Text;
                                    string matg = txtTacGia.Text;
                                    string tensach = txtTenSach.Text;


                                    DateTime ngaynhap = (DateTime)datetimeNgayNhap.Value;



                                    string query = "Insert into Sach values(  N'" + masach.ToString() + "',N'" + mls.ToString() + "',N'" + matg.ToString() + "' ,N'" + tensach.ToString() + "','False','" + ngaynhap.ToString() + "')";
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
                                    MessageBox.Show("Bạn chưa nhập ngày nhập");
                                }

                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa nhập tên sách");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập mã tác giả");
                    }

                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mã loại sách");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã sách");

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtMaSach.Text != "")
            {
                if (txtMls.Text != "")
                {
                    if (txtTacGia.Text != "")
                    {

                        if (txtTenSach.Text != "")
                        {
                                if (datetimeNgayNhap.Text != "")
                                {
                                    string masach = txtMaSach.Text;
                                    string mls = txtMls.Text;
                                    string matg = txtTacGia.Text;
                                    string tensach = txtTenSach.Text;

                                    DateTime ngaynhap = datetimeNgayNhap.Value;



                                    string query = "Update Sach set masach=  N'" + masach.ToString() + "',maloaisach=N'" + mls.ToString() + "',matg=N'" + matg.ToString() + "' ,tensach=N'" + tensach.ToString() + "',ngaynhap='" + ngaynhap.ToString() + "' where masach=  N'" + masach.ToString() + "'";
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
                                    MessageBox.Show("Bạn chưa nhập ngày nhập");
                                }
                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa nhập tên sách");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập mã tác giả");
                    }

                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mã loại sách");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã sách");

            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtMaSach.Text != "")
                {
                    string masach = txtMaSach.Text;


                    string query = @"delete Sach where masach =  N'" + masach.ToString() + "'";
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


        private void DataGridSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DataGridSach.CurrentRow.Index;
            txtMaSach.Text = DataGridSach.Rows[i].Cells[0].Value.ToString();
            txtMls.Text = DataGridSach.Rows[i].Cells[1].Value.ToString();
            txtTacGia.Text = DataGridSach.Rows[i].Cells[2].Value.ToString();
            txtTenSach.Text = DataGridSach.Rows[i].Cells[3].Value.ToString();
            datetimeNgayNhap.Text = DataGridSach.Rows[i].Cells[5].Value.ToString();

        }
    }
}
