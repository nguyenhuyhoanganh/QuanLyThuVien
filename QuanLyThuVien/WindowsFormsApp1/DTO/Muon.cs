using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Muon
    {
            private string mamuon;
            private string mathuthu;
            private string madocgia;
            private string masach;
            private DateTime? ngaymuon;
            private DateTime? ngaytra;
            private Boolean tinhtrangmuon;
        public Muon(string mamuon, string mathuthu, string madocgia, string masach, DateTime? ngaymuon, DateTime? ngaytra, Boolean tinhtrangmuon)
        {
            this.Mamuon = mamuon;
            this.Mathuthu = mathuthu;
            this.Madocgia = madocgia;
            this.Masach = masach;
            this.Ngaymuon = ngaymuon;
            this.Ngaytra = ngaytra;
            this.Tinhtrangmuon = tinhtrangmuon;
        }

        public Muon(DataRow row)
        {
            this.Mamuon = row["mamuon"].ToString();
            this.Mathuthu = row["mathuthu"].ToString();
            this.Madocgia = row["madocgia"].ToString();
            this.Masach = row["masach"].ToString();
            this.Ngaymuon = (DateTime?)row["ngaymuon"];
            this.Ngaytra = (DateTime?)row["ngaytra"];
            this.Tinhtrangmuon = (Boolean)row["tinhtrangmuon"];
        }


        public string Mamuon
            {
                get
                {
                    return mamuon;
                }

                set
                {
                    mamuon = value;
                }
            }

            public string Mathuthu
            {
                get
                {
                    return mathuthu;
                }

                set
                {
                    mathuthu = value;
                }
            }

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

            public DateTime? Ngaymuon
            {
                get
                {
                    return ngaymuon;
                }

                set
                {
                    ngaymuon = value;
                }
            }

            public DateTime? Ngaytra
            {
                get
                {
                    return ngaytra;
                }

                set
                {
                    ngaytra = value;
                }
            }

            public Boolean Tinhtrangmuon
            {
                get
                {
                    return tinhtrangmuon;
                }

                set
                {
                    tinhtrangmuon= value;
                }
            }
        }
    }

