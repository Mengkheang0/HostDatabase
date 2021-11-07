using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using System.Configuration;

namespace Images.data
{
    public class DataAccess
    {
        static string ConString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public static List<ImageModel> LoadImages()
        {
            using(IDbConnection connection = new SQLiteConnection(ConString))
            {
                var output = connection.Query<ImageModel>("select * from UrlsTb");
                return output.ToList();
            }
        }

        public static void AddData (string data)
        {
            using (IDbConnection connection = new SQLiteConnection(ConString))
            {
                connection.Execute($"insert into UrlsTb(Url) values('{data}')");
            }
        }

       

    }
}
