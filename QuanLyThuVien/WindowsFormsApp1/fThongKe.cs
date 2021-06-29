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
using ClosedXML;
using ClosedXML.Excel;

namespace WindowsFormsApp1
{
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();

        private void button_als_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            //dataGridView_report.DataSource = false;
            dataGridView_report.Refresh();
            //dgv_nameOfGridView.DataSource = false;
            if (radioButton_sach.Checked == true)
            {
                if (radioButton_all.Checked == true)
                {
                    using (SqlConnection sql = new SqlConnection(SQLConStr.conStr))
                    {
                        sql.Open();
                        SqlDataAdapter sqlData = new SqlDataAdapter("select mamuon as N'Mã mượn', mathuthu N'Mã thủ thư', Muon.madocgia N'Mã độc giả', masach N'Mã sách', ngaymuon N'Ngày mượn', ngaytra N'Ngày trả', tinhtrangmuon N'Tình trạng mượn', hoten N'Họ và tên', ngaysinh N'Ngày sinh', diachi N'Địa chỉ' from muon join docgia on Muon.madocgia=DocGia.madocgia", SQLConStr.conStr);
                        //DataTable dataTable = new DataTable();
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
                        //DataTable dataTable = new DataTable();
                        sqlData.Fill(dataTable);
                        dataGridView_report.DataSource = dataTable;
                    }
                }
                else if (radioButton_trehan.Checked == true)
                {
                    using (SqlConnection sql = new SqlConnection(SQLConStr.conStr))
                    {
                        sql.Open();
                        SqlDataAdapter sqlData = new SqlDataAdapter("select mamuon as N'Mã mượn', mathuthu N'Mã thủ thư', Muon.madocgia N'Mã độc giả', masach N'Mã sách', ngaymuon N'Ngày mượn', ngaytra N'Ngày trả', tinhtrangmuon N'Tình trạng mượn', hoten N'Họ và tên', ngaysinh N'Ngày sinh', diachi N'Địa chỉ', DATEDIFF(day,ngaymuon, ngaytra) as N'Số ngày quá hạn' from muon join docgia on Muon.madocgia=DocGia.madocgia where tinhtrangmuon=1 and ngaytra<getdate() order by DATEDIFF(day,ngaymuon, ngaytra) desc", SQLConStr.conStr);
                        //DataTable dataTable = new DataTable();
                        sqlData.Fill(dataTable);
                        dataGridView_report.DataSource = dataTable;
                    }
                }
            }
            if (radioButton_nguoimuon.Checked == true)
            {
                {
                    if (radioButton_all.Checked == true)
                    {
                        using (SqlConnection sql = new SqlConnection(SQLConStr.conStr))
                        {
                            sql.Open();
                            SqlDataAdapter sqlData = new SqlDataAdapter("select hoten N'Họ và tên', ngaysinh N'Ngày sinh', diachi N'Địa chỉ', mamuon as N'Mã mượn', mathuthu N'Mã thủ thư', Muon.madocgia N'Mã độc giả', masach N'Mã sách', ngaymuon N'Ngày mượn', ngaytra N'Ngày trả', tinhtrangmuon N'Tình trạng mượn'  from muon join docgia on Muon.madocgia=DocGia.madocgia order by hoten desc", SQLConStr.conStr);
                            //DataTable dataTable = new DataTable();
                            sqlData.Fill(dataTable);
                            dataGridView_report.DataSource = dataTable;
                        }
                    }
                    else if (radioButton_dangmuon.Checked == true)
                    {
                        using (SqlConnection sql = new SqlConnection(SQLConStr.conStr))
                        {
                            sql.Open();
                            SqlDataAdapter sqlData = new SqlDataAdapter("select hoten N'Họ và tên', ngaysinh N'Ngày sinh', diachi N'Địa chỉ', mamuon as N'Mã mượn', mathuthu N'Mã thủ thư', Muon.madocgia N'Mã độc giả', masach N'Mã sách', ngaymuon N'Ngày mượn', ngaytra N'Ngày trả', tinhtrangmuon N'Tình trạng mượn' from muon join docgia on Muon.madocgia=DocGia.madocgia where tinhtrangmuon=0 order by ngaytra asc", SQLConStr.conStr);
                            //DataTable dataTable = new DataTable();
                            sqlData.Fill(dataTable);
                            dataGridView_report.DataSource = dataTable;
                        }
                    }
                    else if (radioButton_trehan.Checked == true)
                    {
                        using (SqlConnection sql = new SqlConnection(SQLConStr.conStr))
                        {
                            sql.Open();
                            SqlDataAdapter sqlData = new SqlDataAdapter("select hoten N'Họ và tên', ngaysinh N'Ngày sinh', diachi N'Địa chỉ', mamuon as N'Mã mượn', mathuthu N'Mã thủ thư', Muon.madocgia N'Mã độc giả', masach N'Mã sách', ngaymuon N'Ngày mượn', ngaytra N'Ngày trả', tinhtrangmuon N'Tình trạng mượn', DATEDIFF(day,ngaymuon, ngaytra) as N'Số ngày quá hạn' from muon join docgia on Muon.madocgia=DocGia.madocgia where tinhtrangmuon=1 and ngaytra<getdate() order by DATEDIFF(day,ngaymuon, ngaytra) desc", SQLConStr.conStr);
                            //DataTable dataTable = new DataTable();
                            sqlData.Fill(dataTable);
                            dataGridView_report.DataSource = dataTable;
                        }
                    }
                }
            }
        }

        private void button_excel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog() { Filter = "SQLEXPORT|*.xlsx" })
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook xLWorkbook = new XLWorkbook())
                        {
                            xLWorkbook.Worksheets.Add(dataTable, "SQLEXPORT");
                            xLWorkbook.SaveAs(save.FileName);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
