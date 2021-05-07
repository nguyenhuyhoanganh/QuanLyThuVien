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
    public partial class fTacGia : Form
    {
        

        public fTacGia()
        {
            InitializeComponent();
            LoadInformation();
            
        }
       

        private void ClearDL()
        {
            txtMaTg.Text = "";
            txtTenTg.Text = "";
            txtLienHe.Text = "";
        }


        DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            string connectionSTR = @"Data Source=DESKTOP-53IQ0S1\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";

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
            string connectionSTR = @"Data Source=DESKTOP-53IQ0S1\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";

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
            string connectionSTR = @"Data Source=DESKTOP-53IQ0S1\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = "select * from TacGia";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridTacGia.DataSource = data;



        }
        private void TG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridTacGia.CurrentRow.Index;
            txtMaTg.Text = dataGridTacGia.Rows[i].Cells[0].Value.ToString();
            txtTenTg.Text = dataGridTacGia.Rows[i].Cells[1].Value.ToString();
            txtLienHe.Text = dataGridTacGia.Rows[i].Cells[2].Value.ToString();



        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaTg.Text != "")
            {
                if (txtTenTg.Text != "")
                {
                    if (txtLienHe.Text != "")
                    {
                       

                              string  matg = txtMaTg.Text;

                              string tentg = txtTenTg.Text;
                              string lh = txtLienHe.Text;
                                
                                string query = "Insert into TacGia values(  N'" + matg.ToString() + "',N'" + tentg.ToString() + "',N'" + lh.ToString() + "' )";
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
                        MessageBox.Show("Bạn chưa nhập liên hệ");
                    }

                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên tác giả");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã tác giả");

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {


            if (txtMaTg.Text != "")
            {
                if (txtTenTg.Text != "")
                {
                    if (txtLienHe.Text != "")
                    {


                        string matg = txtMaTg.Text;

                        string tentg = txtTenTg.Text;
                        string lh = txtLienHe.Text;

                        string query = @"update  TacGia set matg=  N'" + matg.ToString() + "',tentg = N'" + tentg.ToString() + "',lienhe= N'" + lh.ToString() + "'  where matg=  N'" + matg.ToString() + "' ";
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
                        MessageBox.Show("Bạn chưa nhập liên hệ");
                    }

                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên tác giả");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã tác giả");

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtMaTg.Text != "")
                {

                    string matg = txtMaTg.Text;

                    string tentg = txtTenTg.Text;
                   
                    string lh = txtLienHe.Text;
                    string query = @"exec XoaTG @matg =  N'" + matg.ToString() + "'";
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
