using Project2.ViewModels;
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

namespace Project2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int i;
        public MainWindow()
        {
            InitializeComponent();
            if (i == 1)
            {
                this.Visibility = Visibility.Hidden;
            }

    }
        
        


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new EtudiantModel();
          
                        
        }

        private void Filiere(object sender, RoutedEventArgs e)
        {
            DataContext = new FiliereModel();
        }

        private void Statique(object sender, RoutedEventArgs e)
        {
            DataContext = new Statique();
        }
    }
}
