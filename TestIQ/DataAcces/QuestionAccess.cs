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
    public class QuestionAccess
    {
        public async Task<List<Models.QuestionModel>> LoadQuestion()
        {
            using(IDbConnection con = new SQLiteConnection(SqlHelper.GetConnectionString("default")))
            {
                var output = con.Query<Models.QuestionModel>("select * from QuestionReviewTb").ToList();

                return output;
            }

        }

        public async Task AddQuestion(Models.QuestionModel question)
        {
            using (IDbConnection con = new SQLiteConnection(SqlHelper.GetConnectionString("default")))
            {

                await con.ExecuteAsync("insert into QuestionReviewTb(Question,Answer) values(@Question,@Answer) ",question);
            }

        }
    }
}


    //QuestionReviewTb