using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace BookReaderApp.Data
{
    class Connection
    {
        public Connection()
        {
        }
        private static string stringconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\WorkSpace\UIT\Kì 4\LapTrinhMangCanBan\Project\BookReaderApp\BookReaderApp\Database\BookReaderDB.mdf"";Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringconnection);
        }
    }
}
