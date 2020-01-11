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
    /// Logique d'interaction pour GestionFiliere.xaml
    /// </summary>
    public partial class GestionFiliere : UserControl
    {
        DataClasses1DataContext cl = new DataClasses1DataContext();
        public GestionFiliere()
        {
            int k = 0;
            InitializeComponent();
            var x = (from c in cl.Filiere
                    select c).Take(3);
            foreach(var i in x)
            {
               
                if(k == 0)
                {
                    labId1.Content = i.Id_filiere.ToString();
                    labName1.Content = i.Nom_filiere;
                    k++;

                }
                else if (k == 1)
                {
                    labId2.Content = i.Id_filiere.ToString();
                    labName2.Content = i.Nom_filiere;
                    k++;
                }
                else 
                {
                    labId3.Content = i.Id_filiere.ToString();
                    labName3.Content = i.Nom_filiere;
                    k = 0;
                }

            }
            
        }


        
        private void Modifier(object sender, RoutedEventArgs e)
        {
            var x = (from E in cl.Filiere
                     where E.Id_filiere == Int32.Parse(textId.Text)
                     select E).SingleOrDefault();
            var i = from c in cl.etudiant
                    select c;
            x.Id_filiere = Int32.Parse(textId.Text);
            x.Nom_filiere = textFil.Text;
            cl.SubmitChanges();
            MessageBox.Show("la valeur est modifi");
            this.Visibility = Visibility.Hidden;
        }

        private void Ajouter(object sender, RoutedEventArgs e)
        {
            var x = (from E in cl.Filiere
                     where E.Id_filiere == Int32.Parse(textId.Text)
                     select E.Id_filiere).Count();
            if (x == 0)
            {
                Filiere filiere = new Filiere();
                filiere.Id_filiere = Int32.Parse(textId.Text);
                filiere.Nom_filiere = textFil.Text;
                cl.Filiere.InsertOnSubmit(filiere);
                cl.SubmitChanges();
                MessageBox.Show("ouii");

            }
            else
            {
                MessageBox.Show("Ce Id deja existe ");
            }

        }

        private void Supprimer(object sender, RoutedEventArgs e)
        {
            var x = (from c in cl.Filiere
                     where c.Id_filiere == Int32.Parse(textId.Text)
                     select c).SingleOrDefault();
            cl.Filiere.DeleteOnSubmit(x);
            cl.SubmitChanges();
            MessageBox.Show("ce Id est Supprimer");
        }
    }
}
