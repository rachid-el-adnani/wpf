using System;
using System.Collections.Generic;
using System.Data;
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
    /// Logique d'interaction pour Gestionetudiant.xaml
    /// </summary>
    public partial class Gestionetudiant : UserControl
    {
        DataClasses1DataContext cl = new DataClasses1DataContext();
        public Gestionetudiant()
        {
            InitializeComponent();
            var x = from c in cl.Filiere
                    select new { c.Nom_filiere };
            foreach (var i in x)
            {
                filiereCombo.Items.Add(i.Nom_filiere);   
            }
            filiereCombo.SelectedItem = "G.Infoo";
           

        }
        
        EditWindow dash = new EditWindow();
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var x = (from c in cl.Filiere
                     where c.Nom_filiere.Equals(filiereCombo.SelectedItem)
                     select new { c.Nom_filiere, c.Resp_filiere}).SingleOrDefault();
            //chaque element selectionne on va changer les element 
            labNomFi.Content = x.Nom_filiere;
            labNomF.Content = labNomFi.Content;
            labResp.Content = x.Resp_filiere;
            DisplayData();

        }

        private void Form(object sender, ContextMenuEventArgs e)
        {
            
           
        }
        

        public void DisplayData()
        {
            //on va cherger les donnes de la base de donne a dataGrid on utilise link to sql 
            var x = (from E in cl.etudiant
                     join F in cl.Filiere
                      on E.id_fil equals F.Id_filiere
                      where F.Nom_filiere.Equals(filiereCombo.SelectedItem)
                     select new {E.cne,E.nom,E.prenom,E.date_naiss,E.sexe,E.image,F.Nom_filiere});
        
        DataEtudient.ItemsSource = x;
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           if(DataEtudient.SelectedItem != null) {
               
                dash.Visibility = Visibility.Visible;
             
               
            }
            else
            {
                MessageBox.Show("Vous devez selection un element");
            }
        }

        private void DataEtudient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //on va selection des element est l affiicher dans les texbox de la gae modifier 
            object items        = DataEtudient.SelectedItem;
            if(items != null)
            {
                dash.textCne.Text = (DataEtudient.SelectedCells[0].Column.GetCellContent(items) as TextBlock).Text;
                dash.textNom.Text = (DataEtudient.SelectedCells[1].Column.GetCellContent(items) as TextBlock).Text;
                dash.textPrenom.Text = (DataEtudient.SelectedCells[2].Column.GetCellContent(items) as TextBlock).Text;
                dash.textSexe.Text = (DataEtudient.SelectedCells[4].Column.GetCellContent(items) as TextBlock).Text;
                dash.textDate.Text = (DataEtudient.SelectedCells[3].Column.GetCellContent(items) as TextBlock).Text;

            }
         

        }
      
    }
}
