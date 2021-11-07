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
    /// Interaction logic for SigninView.xaml
    /// </summary>
    public partial class SigninView : Page
    {
        public SigninView()
        {
            InitializeComponent();
        }
        Window _wd;
        public SigninView(Window wd)
        {
            InitializeComponent();
            _wd = wd;

        }

        private void signinBtn_Click(object sender, RoutedEventArgs e)
        {
            if(userNameTb.Text.Length >0 && passwordTb.Text.Length>0 && roleCb.Text.Length > 0)
            {
                if (isFound())
                {
                    UpdateMsg(isFound());
                    _wd.Close();        
                }
                else
                {
                    UpdateMsg(isFound());

                }
            }
            else
            {
                msgTb.Text = "All field can't be blank!!";
                msgTb.Visibility = Visibility.Visible;
            }
           
        }

        private bool isFound()
        {
            DataAcces.LogAccess logUser = new DataAcces.LogAccess();
            var isFound = logUser.CheckUserIfFound(new Models.LogModel() { UserName = userNameTb.Text, Password = passwordTb.Text, Role = roleCb.Text });
            return isFound;
        }
        private void UpdateMsg(bool isFound)
        {
            if(isFound)
            {
                msgTb.Text = "Sign in success";
                msgTb.Visibility = Visibility.Visible;
            }
            else
            {
                msgTb.Text = "Information unavailable!!";
                msgTb.Visibility = Visibility.Visible;
            }
        }
    }
}
