using WindowsFormsApp1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class MuonDAO
    {
        private static MuonDAO instance;

        public static MuonDAO Instance
        {
            get { if(instance == null) instance = new MuonDAO(); return MuonDAO.instance; }
            private set { MuonDAO.instance = value; }
        }

        private MuonDAO() { }

        public bool InsertPM(string mamuon, string mathuthu, string madocgia, string masach, DateTime ngaymuon, DateTime ngaytra, int tinhtrangmuon)
        {


            string query = string.Format(" insert into dbo.Muon values (N'{0}',N'{1}',N'{2}',N'{3}','{4}','{5}',{6})", mamuon, mathuthu, madocgia, masach, ngaymuon, ngaytra, tinhtrangmuon);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<Muon> GetListMuon()
        {
            List<Muon> list = new List<Muon>();
            string query = "select * from Muon where tinhtrangmuon = 'True'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Muon muon = new Muon(item);
                list.Add(muon);
            }
            return list;
        }

    }
}
