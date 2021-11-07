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
    /// Interaction logic for signupView.xaml
    /// </summary>
    public partial class signupView : Page
    {
        public signupView()
        {
            InitializeComponent();
        }
        private Window _window;
        private int count = 0;
        public signupView(Window wd)
        {
            InitializeComponent();
            _window = wd;
        }

        private async void signinBtn_Click(object sender, RoutedEventArgs e)
        {
            if (userNameTb.Text.Length > 0 && passwordTb.Text.Length > 0 && roleCb.Text.Length > 0 &&confirmTb.Text.Length > 0) 
            {
               if(passwordTb.Text != confirmTb.Text)
                {
                    msgTb.Visibility = Visibility.Visible;
                    msgTb.Text = "Password didnt match!!";

                }
                else
                {
                    DataAcces.LogAccess access = new DataAcces.LogAccess();
                    await access.AddUser(new Models.LogModel() { UserName = userNameTb.Text, Password = passwordTb.Text ,Role = roleCb.Text});

                    msgTb.Text = "Sign up success";
                    _window.Close();
                }
            }
            else
            {
                msgTb.Text = "All field can't be blank!!";
                msgTb.Visibility = Visibility.Visible;
            }
        }
        private void WaitTime(int second,Window wd)
        {
            var time = new System.Timers.Timer(second * 1000) { AutoReset=true};
            time.Start();
            time.Elapsed += Time_Elapsed;

            void Time_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
            {
                count++;
                Console.WriteLine(count);
                if (count == 2)
                {
                    wd.Close();
                    count = 0;
                    
                }
            }
        }
        
      
    }
}
