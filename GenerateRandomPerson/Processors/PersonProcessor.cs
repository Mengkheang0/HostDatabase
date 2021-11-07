using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRandomPerson.Processors
{
    public class PersonProcessor
    {
        public static async Task<Models.PersonModel> GetPerson()
        {
            string url = "https://randomuser.me/api/";


            //call up
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<Models.PersonResult>();
                    return result.Results[0].Name as Models.PersonModel;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}
