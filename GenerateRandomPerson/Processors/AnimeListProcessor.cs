using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRandomPerson.Processors
{
    public class AnimeListProcessor
    {
        public static async Task<List<Models.AnimeListModel>> GetAnime(string animeTitle)
        {
            string url = $"https://api.jikan.moe/v3/search/anime?q={animeTitle}";

            //call up
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<Models.AnimeListResult>();
                    //add
                    var output = new List<Models.AnimeListModel>();
                    foreach (var item in result.Results)
                    {
                        output.Add(item);
                    }

                    return output;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}
