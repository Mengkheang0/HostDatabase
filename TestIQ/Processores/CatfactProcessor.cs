using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestIQ.Processores
{
    public class CatfactProcessor
    {
        public static async Task<Models.Catfact> LoadQuestion()
        {
            string url = "https://catfact.ninja/fact";

            using(HttpResponseMessage resp = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (resp.IsSuccessStatusCode)
                {
                    Models.Catfact result = await resp.Content.ReadAsAsync<Models.Catfact>();
                    return result;
                }
                else
                {
                    throw new Exception(resp.ReasonPhrase);
                }
            }
        }
    }
}
