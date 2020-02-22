using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeConceptionFabriqueEtCommande.Commandes.Parametres.Impl
{
    class ParametreCommandeFermerLeProgramme
    {
        public string Titre { get; set; }
        public string Message { get; set; }
        public long DelaiAvantFermeture { get; set; }
    }
}
