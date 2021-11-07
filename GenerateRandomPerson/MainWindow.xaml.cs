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

namespace GenerateRandomPerson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private async void generateBtn_Click(object sender, RoutedEventArgs e)
        {
           await LoadImage();
        }

       private async Task LoadImage()
        {
            Models.ImageModel Image =  await Processors.ImageProcessor.GetImage();
            var Url = new Uri(Image.Message);
            BitmapImage bmImg =new BitmapImage(Url);

            img.Source = bmImg;
            await LoadPerson();

        }

        private async Task LoadPerson()
        {
            var names = await Processors.PersonProcessor.GetPerson();
            name.Text = $"Name : {names.first} {names.last}";
            Random rn = new Random();
            age.Text = "Age : " + rn.Next(0, 100).ToString();
        }
    }
}
