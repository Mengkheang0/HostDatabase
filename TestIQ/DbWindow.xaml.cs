using Microsoft.Win32;
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

namespace TestIQ
{
    /// <summary>
    /// Interaction logic for DbWindow.xaml
    /// </summary>
    public partial class DbWindow : Window
    {
        public DbWindow()
        {
            InitializeComponent();
        }

        private void selectFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Database files (*.db)|*.db";
            opf.ShowDialog();



        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataAcces.QuestionAccess access = new DataAcces.QuestionAccess();
            dbList.ItemsSource = await access.LoadQuestion();
        }
    }
}
