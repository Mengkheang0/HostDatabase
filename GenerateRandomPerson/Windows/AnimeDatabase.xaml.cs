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
using System.Windows.Shapes;

namespace GenerateRandomPerson.Windows
{
    /// <summary>
    /// Interaction logic for AnimeDatabase.xaml
    /// </summary>
    public partial class AnimeDatabase : Window
    {
        public AnimeDatabase()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

      
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();

        }
        private async Task GetAnime(string nameTitle)
        {
            var animeList = await Processors.AnimeListProcessor.GetAnime(nameTitle);
           animeListView.ItemsSource = animeList;
        }

        private async void searchTb_Click(object sender, RoutedEventArgs e)
        {
            if(searchTb.Text.Length > 0)
            {
                try
                {
                await GetAnime(searchTb.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("We can't find what you want to looking for?");
                }

            }
        }
        private void AddDetail(Grid grid,Models.AnimeListModel mdl)
        {

            Controls.AnimeDetailControl animeDetail = new Controls.AnimeDetailControl(grid,mdl);

            animeDetail.Width = grid.Width;
            animeDetail.Height = grid.Height;   
            grid.Children.Add(animeDetail);
            animeDetail.SetValue(Grid.RowProperty, 3);

        }

        private void animeListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (animeListView.SelectedItem is Models.AnimeListModel)
            {
                var detail = animeListView.SelectedItem as Models.AnimeListModel;
                AddDetail(mainGrid, detail);

            }
        }
    }
}
