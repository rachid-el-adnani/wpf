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

namespace Project2
{
    /// <summary>
    /// Logique d'interaction pour LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        public static MainWindow dashboard = new MainWindow();
        
        DataClasses1DataContext cl = new DataClasses1DataContext();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var x = (from c in cl.Login
                     where c.User.Equals(textUser.Text) & c.Password.Equals(textPass.Password)
                     select c.User).Count();

            if (x != 0)
            {

                dashboard.Visibility = Visibility.Visible;
                this.Close();
            }
            else
            {
                labelog.Content = "Username or password false";
            }

        }
    }
}
