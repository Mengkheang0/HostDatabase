using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRandomPerson.Processors
{
    public class ImageProcessor
    {
        public static async Task<Models.ImageModel> GetImage()
        {
            string url = "https://dog.ceo/api/breeds/image/random";


            //call up
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<Models.ImageModel>();
                    return result as Models.ImageModel;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }

    }
}
