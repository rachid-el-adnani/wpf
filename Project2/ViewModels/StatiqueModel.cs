using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Project2.ViewModels
{
    class StatiqueModel
    {
        DataClasses1DataContext cl = new DataClasses1DataContext();
        public List<Statique> Data { get; set; }
    
        public StatiqueModel()
        {
            Data = new List<Statique>();
            var filiere = from f in cl.Filiere select f;

            foreach (var x in filiere)
            {
                var tmp = from e in cl.etudiant
                          where e.id_fil == x.Id_filiere
                          select e;

                Data.Add(new Statique() { Nom = x.Nom_filiere, nEtudiant = tmp.Count() });

        }
            
        }
       
    }
}
