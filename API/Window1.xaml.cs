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

namespace API
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private async void  Window_Loaded(object sender, RoutedEventArgs e)
        {
             await LoadSunData();
        }
        private async Task LoadSunData()
        {
            var sunData = await SunProcessor.LoadSunInformation();
            sunrise.Text = String.Format("Sunrise  : {0}",sunData.Sunrise.ToLocalTime().ToShortTimeString());
            sunset.Text = String.Format("Sunrset  : {0}",sunData.Sunset.ToLocalTime().ToShortTimeString());
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await LoadSunData();
        }
    }
}
