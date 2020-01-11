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
    /// Logique d'interaction pour Statique.xaml
    /// </summary>

    public partial class Statique : UserControl
    {
        
        public Statique()
        {
            InitializeComponent();
            Series.ItemsSource = (new StatiqueModel()).Data;
            Series.XBindingPath = "Nom";
            Series.YBindingPath = "nEtudiant";
            Series.ShowTooltip = true;
        }
      
    }
}
