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

namespace API
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int maxNumber = 0;
        private int currentNumber = 0;
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            next.IsEnabled = false;
        }
        private async Task LoadImage(int imageNumber = 0)
        {
            var comic= await ComicProcessor.LoadComic(imageNumber);
            if(imageNumber == 0)
            {
                maxNumber = comic.Num;
            }
            currentNumber= comic.Num;

            var uriSource = new Uri(comic.Img, UriKind.Absolute) ;
            img.Source = new BitmapImage(uriSource);

            
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadImage();

        }

        private async void previus_Click(object sender, RoutedEventArgs e)
        {
            if(currentNumber > 1)
            {
                currentNumber--;
                next.IsEnabled = true;
                await LoadImage(currentNumber);

                if(currentNumber == 1)
                {
                    previus.IsEnabled = false;
                }
            }
        }

        private async void next_Click(object sender, RoutedEventArgs e)
        {
            if(currentNumber < maxNumber)
            {
                currentNumber++;
                previus.IsEnabled = true;
                await LoadImage(currentNumber);

                if(currentNumber == maxNumber)
                {
                    next.IsEnabled = false;
                }
            }
        }

        private void suninfo_Click(object sender, RoutedEventArgs e)
        {
            Window1 wd1 = new Window1();
            wd1.ShowDialog();
        }
    }
}
