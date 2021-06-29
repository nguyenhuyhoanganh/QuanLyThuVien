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
    public partial class FormThuThu : Form
    {
        //private string connectString = @"Data Source=DESKTOP-E8F4EIG;Initial Catalog=QLTV;Integrated Security=True";
        // bro, có class SQLConStr để dùng chung cái connection string đc mà. Đừng dùng tên máy riêng vào chạy là lỗi
        // from thịnh with luv
        public static string connectString = SQLConStr.conStr;
        public FormThuThu()
        {
            InitializeComponent();
            show();
            hindText();
        }

        void show()
        {
            dataGridView1.DataSource = installQuery("select * from thuthu");
            comboBox1.DataSource = installQuery("select mathuthu from thuthu");
            comboBox1.DisplayMember = "mathuthu";

        }
        void hindText()
        {
            textBoxMaDG.ReadOnly = true;
            textBoxTenDG.ReadOnly = true;
            textBoxNgaySinh.ReadOnly = true;
            //textBoxGioiTinh.ReadOnly = true;
            comboBox2.Enabled = false;
            textBoxDiaChi.ReadOnly = true;
            textBoxSDT.ReadOnly = true;
            dateTimePicker1.Enabled = false;
        }
        void showText()
        {
            textBoxMaDG.ReadOnly = false;
            textBoxTenDG.ReadOnly = false;
            textBoxNgaySinh.ReadOnly = false;
            //textBoxGioiTinh.ReadOnly = false;
            comboBox2.Enabled = true;
            textBoxDiaChi.ReadOnly = false;
            textBoxSDT.ReadOnly = false;
            dateTimePicker1.Enabled = true;
        }
        void clearText()
        {
            textBoxMaDG.Clear();
            textBoxTenDG.Clear();
            textBoxNgaySinh.Clear();
            //textBoxGioiTinh.Clear();
            textBoxDiaChi.Clear();
            textBoxSDT.Clear();
        }
        public DataTable installQuery(string query, object[] para = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(connectString))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    if (para != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, para[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return data;
        }
        public int installNonQuery(string query, object[] para = null)
        {
            int data = 0;
            using (SqlConnection con = new SqlConnection(connectString))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    if (para != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, para[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return data;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (textBoxMaDG.Text != "")
            {
                using (SqlConnection con = new SqlConnection(connectString))
                {
                    try
                    {
                        con.Open();
                        string queKt = "select * from thuthu where mathuthu='" + textBoxMaDG.Text + "'";
                        SqlCommand com = new SqlCommand(queKt, con);
                        SqlDataReader da = com.ExecuteReader();
                        if (da.Read())
                        {
                            clearText();
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }
            int rez = 0;
            if (!textBoxMaDG.ReadOnly)
            {
                showText();
                if (textBoxMaDG.Text == "" || textBoxTenDG.Text == "" || textBoxNgaySinh.Text == "" || comboBox2.Text == "" || textBoxDiaChi.Text == "" || textBoxSDT.Text == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin và nhấn thêm");
                }
                else
                {
                    //chuyen 0,1->Gioi tinh

                    string que = @"Insert into thuthu(mathuthu, hoten, ngaysinh, gioitinh, diachi, sdt)
values('" + textBoxMaDG.Text + "', '" + textBoxTenDG.Text + "', '" + textBoxNgaySinh.Text + "', '" + comboBox2.Text + "', '" + textBoxDiaChi.Text + "', " + textBoxSDT.Text + ")";
                    rez = installNonQuery(que);

                }

            }
            else showText();

            if (rez != 0)
            {
                MessageBox.Show("Thêm thành công");
                clearText();
                hindText();
            }
            show();
            clearText();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            showText();
            textBoxMaDG.ReadOnly = true;
            int rez = 0;
            if (textBoxMaDG.Text == "" || textBoxTenDG.Text == "" || textBoxNgaySinh.Text == "" || comboBox2.Text == "" || textBoxDiaChi.Text == "" || textBoxSDT.Text == "")
            {
                MessageBox.Show("Chọn thủ thư cần sửa");
            }
            else
            {

                //Kt tồn tại
                int check = 0;
                string queKt = "select * from thuthu where mathuthu = '" + textBoxMaDG.Text + "'";
                string queUpdate = "update thuthu set hoten='" + textBoxTenDG.Text + "', ngaysinh='" + textBoxNgaySinh.Text + "', gioitinh = '" + comboBox2.Text + "', diachi ='" + textBoxDiaChi.Text + "', sdt=" + textBoxSDT.Text + " where mathuthu='" + textBoxMaDG.Text + "'";

                try
                {
                    SqlConnection cone = new SqlConnection(connectString);
                    cone.Open();
                    SqlCommand com = new SqlCommand(queKt, cone);
                    SqlDataReader da = com.ExecuteReader();
                    if (da.Read())
                    {
                        check = 1;
                    }
                    cone.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //nếu có trường thông tin
                if (check == 1)
                {
                    rez = installNonQuery(queUpdate);
                }
                if (rez != 0)
                {
                    MessageBox.Show("Thông tin lưu thành công");
                }
            }
            show();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string que = "delete from thuthu where mathuthu = '" + textBoxMaDG.Text + "'";
            string que2 = "delete from muon where mathuthu ='" + textBoxMaDG.Text + "' ";
            string que3 = "delete from account where mathuthu = '" + textBoxMaDG.Text + "'";
            int rez = 0;
            int rez2 = 0, rez3 = 0;
            if (textBoxMaDG.Text == "" || textBoxTenDG.Text == "" || textBoxNgaySinh.Text == "" || comboBox2.Text == "" || textBoxDiaChi.Text == "" || textBoxSDT.Text == "")
            {
                MessageBox.Show("Chọn thủ thư rồi nhấn xóa");
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa thủ thư có mã " + textBoxMaDG.Text + " không?", "Cảnh báo sẽ xóa thông tin liên quan!!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (MessageBox.Show("Thủ thư có thể liên quan đến danh sách mượn sách!! ", "Cảnh báo mất dữ liệu !!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        rez3 = installNonQuery(que3);
                        rez2 = installNonQuery(que2);
                        rez = installNonQuery(que);
                        //xóa luôn du lieu muon
                    }

                }
                if (rez != 0)
                {
                    MessageBox.Show("Xóa thành công!!");
                    clearText();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!");
                }
            }


            show();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string que = "select * from thuthu where mathuthu='" + comboBox1.Text + "'";
                dataGridView1.DataSource = installQuery(que);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hindText();
            //buttonThem.Enabled = false;
            textBoxMaDG.DataBindings.Clear();
            textBoxMaDG.DataBindings.Add("text", dataGridView1.DataSource, "mathuthu");
            textBoxTenDG.DataBindings.Clear();
            textBoxTenDG.DataBindings.Add("text", dataGridView1.DataSource, "hoten");
            textBoxNgaySinh.DataBindings.Clear();
            textBoxNgaySinh.DataBindings.Add("text", dataGridView1.DataSource, "ngaysinh");
            comboBox2.DataBindings.Clear();
            //lay gio tinh
            /*int gt = 0;
            string que = "select giotinh from docgia where madocgia ='" + textBoxMaDG.Text + "'";
            DataTable da = installQuery(que);*/
            comboBox2.DataBindings.Add("text", dataGridView1.DataSource, "gioitinh");
            textBoxDiaChi.DataBindings.Clear();
            textBoxDiaChi.DataBindings.Add("text", dataGridView1.DataSource, "diachi");
            textBoxSDT.DataBindings.Clear();
            textBoxSDT.DataBindings.Add("text", dataGridView1.DataSource, "sdt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show();
            hindText();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            textBoxNgaySinh.Text = date.ToString("MM/dd/yyyy");
            /*string dateFormat = dateTimePicker1.Value.ToString("mm/dd/yyyy");
            textBoxNgaySinh.Text = dateFormat;*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
