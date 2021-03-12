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
    public partial class Form_report : Form
    {
        public Form_report()
        {
            InitializeComponent();
        }

        private void button_als_Click(object sender, EventArgs e)
        {
            if (radioButton_nguoimuon.Checked == true)
            {
                if (radioButton_all.Checked == true)
                {
                    using (SqlConnection sql = new SqlConnection(SQLConStr.conStr))
                    {
                        sql.Open();
                        SqlDataAdapter sqlData = new SqlDataAdapter("select mamuon as N'Mã mượn', mathuthu N'Mã thủ thư', Muon.madocgia N'Mã độc giả', masach N'Mã sách', ngaymuon N'Ngày mượn', ngaytra N'Ngày trả', tinhtrangmuon N'Tình trạng mượn', hoten N'Họ và tên', ngaysinh N'Ngày sinh', diachi N'Địa chỉ' from muon join docgia on Muon.madocgia=DocGia.madocgia", SQLConStr.conStr);
                        DataTable dataTable = new DataTable();
                        sqlData.Fill(dataTable);
                        dataGridView_report.DataSource = dataTable;
                    }
                }
                else if (radioButton_dangmuon.Checked == true)
                {
                    using (SqlConnection sql = new SqlConnection(SQLConStr.conStr))
                    {
                        sql.Open();
                        SqlDataAdapter sqlData = new SqlDataAdapter("select mamuon as N'Mã mượn', mathuthu N'Mã thủ thư', Muon.madocgia N'Mã độc giả', masach N'Mã sách', ngaymuon N'Ngày mượn', ngaytra N'Ngày trả', tinhtrangmuon N'Tình trạng mượn', hoten N'Họ và tên', ngaysinh N'Ngày sinh', diachi N'Địa chỉ' from muon join docgia on Muon.madocgia=DocGia.madocgia where tinhtrangmuon=0 order by ngaytra asc", SQLConStr.conStr);
                        DataTable dataTable = new DataTable();
                        sqlData.Fill(dataTable);
                        dataGridView_report.DataSource = dataTable;
                    }
                }
                else if (radioButton_trehan.Checked == true)
                    using (SqlConnection sql = new SqlConnection(SQLConStr.conStr))
                    {
                        sql.Open();
                        SqlDataAdapter sqlData = new SqlDataAdapter("select mamuon as N'Mã mượn', mathuthu N'Mã thủ thư', Muon.madocgia N'Mã độc giả', masach N'Mã sách', ngaymuon N'Ngày mượn', ngaytra N'Ngày trả', tinhtrangmuon N'Tình trạng mượn', hoten N'Họ và tên', ngaysinh N'Ngày sinh', diachi N'Địa chỉ', DATEDIFF(day,ngaymuon, ngaytra) as N'Số ngày quá hạn' from muon join docgia on Muon.madocgia=DocGia.madocgia where tinhtrangmuon=1 and ngaytra<getdate() order by DATEDIFF(day,ngaymuon, ngaytra) desc", SQLConStr.conStr);
                        DataTable dataTable = new DataTable();
                        sqlData.Fill(dataTable);
                        dataGridView_report.DataSource = dataTable;
                    }
            }    
        }
    }
}
