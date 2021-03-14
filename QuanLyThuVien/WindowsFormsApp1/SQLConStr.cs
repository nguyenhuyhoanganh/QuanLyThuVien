using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SQLConStr
    {
        // connection string đây nha <3
        public static string conStr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";

        // cho ô nào tên sql server ko có \SQLEXPRESS
        //public static string conStr = @"Data Source=localhost;Initial Catalog=QLTV;Integrated Security=True";
    }
}
