using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIQ.DataAcces
{
    public class LogAccess
    {
        public async Task<List<Models.LogModel>> LoadLogUser()
        {
            using (IDbConnection con = new SQLiteConnection(SqlHelper.GetConnectionString("default2")))
            {
                var output = con.Query<Models.LogModel>("select * from LogTb").ToList();

                return output;
            }

        }

        public async Task AddUser(Models.LogModel log)
        {
            using (IDbConnection con = new SQLiteConnection(SqlHelper.GetConnectionString("default2")))
            {

                await con.ExecuteAsync($"insert into LogTb(Username,Password,Role) values('{log.UserName}','{log.Password}','{log.Role}') ");
            }

        }

        //Check user
        public bool CheckUserIfFound(Models.LogModel logUser)
        {
            using (IDbConnection con = new SQLiteConnection(SqlHelper.GetConnectionString("default2")))
            {

               List<Models.LogModel> output = con.Query<Models.LogModel>("select * from LogTb").ToList();

                foreach (var user in output)
                {
                    if(user.UserName == logUser.UserName && user.Password == logUser.Password && user.Role == logUser.Role)
                    {
                        return true;
                    }
                    
                }
            }

            return false;

        }

    }
}
