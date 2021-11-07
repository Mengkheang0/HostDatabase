using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRandomPerson.Models
{
    public class AnimeListResult
    {
        public List<AnimeListModel> Results { get; set; }
    }

    public class AnimeListModel
    {
        public string Url { get; set; }
        public string Image_url { get; set; }
        public string Title { get; set; }
        public bool Airing { get; set; }
        public string Synopsis { get; set; }
        public string Type { get; set; }
        public int Episodes { get; set; }
        public double Score { get; set; }
        public string Start_date { get; set; }
        public string End_date { get; set; }
        public int Members { get; set; }
        public string Rated { get; set; }


    }
}
