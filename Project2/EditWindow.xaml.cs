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
    /// Logique d'interaction pour EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow()
        {
            InitializeComponent();
        }
        
        DataClasses1DataContext cl = new DataClasses1DataContext();
       

        private void Annuler(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            var x = (from E in cl.etudiant
                     where E.cne == Int32.Parse(textCne.Text)
                     select E).SingleOrDefault();
            var i = from c in cl.etudiant
                    select c;
            x.cne = Int32.Parse(textCne.Text);
            x.nom = textNom.Text;
            x.prenom = textPrenom.Text;
            cl.SubmitChanges();
            MessageBox.Show("la valeur est modifi");
            this.Visibility = Visibility.Hidden;
        
        }
    }
}
