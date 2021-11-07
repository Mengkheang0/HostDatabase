using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GenerateRandomPerson.Controls
{
    /// <summary>
    /// Interaction logic for AnimeDetailControl.xaml
    /// </summary>
    public partial class AnimeDetailControl : UserControl
    {
        Grid _grid;
        Models.AnimeListModel _animeListModel;
        public AnimeDetailControl(Grid grid,Models.AnimeListModel animeMd)
        {
            InitializeComponent();
            _grid = grid;
            _animeListModel = animeMd;

            //private 
            AddDetail();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _grid.Children.Remove(this);
        }

        private void AddDetail()
        {
            animeImg.Source = new BitmapImage(new Uri(_animeListModel.Image_url));
            animeTitle.Text = _animeListModel.Title;
            animeUrl.Text = _animeListModel.Url;
            animeAiring.Text = _animeListModel.Airing.ToString();
            animeEnd.Text = DateTime.Parse(_animeListModel.End_date).ToShortDateString();
            animeStart.Text = DateTime.Parse(_animeListModel.Start_date).ToShortDateString(); 
            animeMember.Text = _animeListModel.Members.ToString();
            animeRated.Text = _animeListModel.Rated;
            animeType.Text = _animeListModel.Type;
            animeEpisode.Text = _animeListModel.Episodes.ToString();
            animeScore.Text = _animeListModel.Score.ToString();
        }
    }

}
