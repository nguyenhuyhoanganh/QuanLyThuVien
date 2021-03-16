using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DAO
{
     public class BookDAO
    {
        private static BookDAO instance;
        public static BookDAO Instance

        {
            get { if (instance == null) instance = new BookDAO(); return BookDAO.instance; }
            private set { BookDAO.instance = value; }
        }
        private BookDAO() { }

        /*public List<Book> GetListBook()
        {
            List<Book> list = new List<Book>();
            string query = "select * from Sach where tinhtrang = 'False'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows) 
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;    
        }*/

       
        
    }
}
