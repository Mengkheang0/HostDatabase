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

namespace TestIQ
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

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadQuestions();
        }
        private async Task LoadQuestions()
        {
            Models.Catfact  _data = await Processores.CatfactProcessor.LoadQuestion();
            question.Text = _data.Fact;

        }

        private  async void trueBtn_Click(object sender, RoutedEventArgs e)
        {
            DataAcces.QuestionAccess access = new DataAcces.QuestionAccess();

            await access.AddQuestion(new Models.QuestionModel() { Question= question.Text,Answer = trueBtn.Content.ToString()});

            //Update Text
            await LoadQuestions();
        }

        private async void falseBtn_Click(object sender, RoutedEventArgs e)
        {
            DataAcces.QuestionAccess access = new DataAcces.QuestionAccess();

            await access.AddQuestion(new Models.QuestionModel() { Question = question.Text, Answer = falseBtn.Content.ToString() });

            //Update Text
            await LoadQuestions();
        }
    }
}
