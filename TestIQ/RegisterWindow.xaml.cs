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
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        Window _window;

        ListView.SigninView signinView;
        ListView.signupView signupView;


        public RegisterWindow()
        {
            InitializeComponent();
            _window = this;
            signinView = new ListView.SigninView(_window);
            signupView = new ListView.signupView(_window);

            AddContent(signinView);
        }

        
        private void signStatus_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(signStatus.Text == "Sign up")
            {
                signStatus.Text = "Sign in";
                //sing in form
                AddContent(signupView);

            }
            else
            {
                signStatus.Text = "Sign up";
                //sing up form
                AddContent(signinView);

            }
        }

        private void AddContent(System.Windows.Controls.Page page)
        {
            mainFrame.Content = page;
        }
    }
}
