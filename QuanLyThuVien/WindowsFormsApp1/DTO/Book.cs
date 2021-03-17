using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Book
    {
       
        public Book(string masach, string maloaisach, string matg, string manxb, string tensach, Boolean tinhtrang, DateTime ngaynhap)
        {
            this.Masach = masach;
            this.Maloaisach = maloaisach;
            this.Matg = matg;
            this.Manxb = manxb;
            this.Tensach = tensach;
            this.Tinhtrang = tinhtrang;
            this.Ngaynhap = ngaynhap;
        }
        
        public Book(DataRow row)
        {
            this.Masach = row["masach"].ToString();
            this.Maloaisach = row["maloaisach"].ToString();
            this.Matg = row["matg"].ToString(); 
            this.Manxb = row["manxb"].ToString(); 
            this.Tensach = row["tensach"].ToString(); 
            this.Tinhtrang = (Boolean)row["tinhtrang"];
            this.Ngaynhap = (DateTime)row["ngaynhap"];
        }

        private string masach;
        private string maloaisach;
        private string matg;
        private string manxb;
        private string tensach;
        private Boolean tinhtrang;
        private DateTime ngaynhap;
        public string Masach
        {
            get
            {
                return masach;
            }

            set
            {
                masach = value;
            }
        }

        public string Maloaisach
        {
            get
            {
                return maloaisach;
            }

            set
            {
                maloaisach = value;
            }
        }

        public string Matg
        {
            get
            {
                return matg;
            }

            set
            {
                matg = value;
            }
        }

        public string Manxb
        {
            get
            {
                return manxb;
            }

            set
            {
                manxb = value;
            }
        }

        public string Tensach
        {
            get
            {
                return tensach;
            }

            set
            {
                tensach = value;
            }
        }

        public Boolean Tinhtrang
        {
            get
            {
                return tinhtrang;
            }

            set
            {
                tinhtrang = value;
            }
        }

        public DateTime Ngaynhap
        {
            get
            {
                return ngaynhap;
            }

            set
            {
                ngaynhap = value;
            }
        }
    }
}