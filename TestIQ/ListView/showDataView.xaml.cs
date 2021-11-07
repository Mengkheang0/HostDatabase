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

namespace TestIQ.ListView
{
    /// <summary>
    /// Interaction logic for showDataView.xaml
    /// </summary>
    public partial class showDataView : Page
    {
        public showDataView()
        {
            InitializeComponent();
        }

        private async void LoadData()
        {
            var question = new DataAcces.QuestionAccess();
            var listUserData  = question.LoadQuestion();
            listUserDt.ItemsSource = await listUserData;
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
