using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wnformUI.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace wnformUI.DataAccess
{
    public class PeronDataAccess
    {
        string Constring = ConfigurationManager.ConnectionStrings["person"].ConnectionString;
        public List<PersonModel> GetData()
        {
            using(IDbConnection connection = new SqlConnection(Constring))
            {
                var output = connection.Query<PersonModel>("select * from postDb.dbo.PersonTB").ToList();

                return output;  
            }

        }

        public void AddData(PersonModel personModel)
        {
            using (IDbConnection connection = new SqlConnection(Constring))
            {
                connection.Query<PersonModel>($@"insert into postDb.dbo.PersonTB(Id,FirstName,LastName)
                                                                values({personModel.Id},'{personModel.FirstName}','{personModel.LastName}')");
            }

        }
    }
}
