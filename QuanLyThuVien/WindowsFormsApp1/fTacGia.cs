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

namespace WindowsFormsApp1
{
    public partial class fTacGia : Form
    {
        public fTacGia()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery("Select * from Tacgia");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rez = 0;
            if(textBox1.Text!="" && textBox2.Text!="" && textBox3.Text!="")
            {
                try
                {
                    string que = "Insert into tacgia(matg,tentg,lienhe) values ('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "')";
                    rez = DataProvider.Instance.ExecuteNonQuery(que);
                    if (rez != 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
                catch { }
                {
                    MessageBox.Show("Mã đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin!!");
            }    

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rez = 0;
            if(textBox1.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 trường thông tin trong bảng để sửa");
            } else
            {
                string que = "Update tacgia set tentg='"+textBox1.Text+"', lienhe='"+textBox3.Text+"' where matg='"+textBox2.Text+"'";
                rez = DataProvider.Instance.ExecuteNonQuery(que);
                if (rez > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    load();
                }                    
                else MessageBox.Show("Sửa không thành công!!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rez = 0;
            if(textBox2.Text=="")
            {
                MessageBox.Show("Chọn dữ liệu cần xóa");

            }    else
            {
                try
                {
                    if(MessageBox.Show("Bạn có muốn xóa tác giả có mã " + textBox2.Text + "", "Cảnh báo xóa!!",MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
                    {
                        string queud = "Update Sach set matg=NULL where matg='"+textBox2.Text+"'";
                        DataProvider.Instance.ExecuteNonQuery(queud);
                        string que = "Delete tacgia where matg='"+textBox2.Text+"'";
                        rez = DataProvider.Instance.ExecuteNonQuery(que);
                    }
                    if (rez > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        load();
                    }
                    else MessageBox.Show("Xóa không thành công");   
                    
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("text", dataGridView1.DataSource, "matg");
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("text", dataGridView1.DataSource, "tentg");
            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("text", dataGridView1.DataSource, "lienhe");
        }
    }
}
