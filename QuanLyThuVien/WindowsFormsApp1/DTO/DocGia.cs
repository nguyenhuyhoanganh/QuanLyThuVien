using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    class DocGia
    {
       
        public DocGia(string madocgia, string hoten, DateTime ngaysinh, string gioitinh, string diachi, int sdt)
        {
            this.Madocgia = madocgia;
            this.Hoten = hoten;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;
            this.Sdt = sdt;
        }

        public DocGia(DataRow row)
        {
            this.Madocgia = row["madocgia"].ToString();
            this.Hoten = row["hoten"].ToString();
            this.Ngaysinh = (DateTime)row["ngaysinh"];
            this.Gioitinh = row["gioitinh"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.Sdt = (int)row["sdt"];
        }


        private string madocgia;
        private string hoten;
        private DateTime ngaysinh;
        private string gioitinh;
        private string diachi;
        private int sdt;

        public string Madocgia
        {
            get
            {
                return madocgia;
            }

            set
            {
                madocgia = value;
            }
        }

        public string Hoten
        {
            get
            {
                return hoten;
            }

            set
            {
                hoten = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public int Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

    }
}