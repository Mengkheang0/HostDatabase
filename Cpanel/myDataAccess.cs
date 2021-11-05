using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Cpanel
{
    public  class myDataAccess
    {
        public static string conString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public static List<PersonModel> GetPeople()
        {
            using(IDbConnection con =new SQLiteConnection(conString))
            {
                var Output = con.Query<PersonModel>("select * from FolderTB", new DynamicParameters());

                return Output.ToList();
            }

        }

        public static void AddPeople(PersonModel person)
        {
            using (IDbConnection con = new SQLiteConnection(conString))
            {
                con.Execute("insert into FolderTB (Name,Path) values(@Name, @Path)", person);
            }

        }

        public static List<PersonModel> FilterPeople(PersonModel person)
        {
            using (IDbConnection con = new SQLiteConnection(conString))
            {
                var output = con.Query<PersonModel>($@"select * from FolderTB where Name like '{person.Name}%' ");

                return output.ToList(); 
            }

        }
    }
}
