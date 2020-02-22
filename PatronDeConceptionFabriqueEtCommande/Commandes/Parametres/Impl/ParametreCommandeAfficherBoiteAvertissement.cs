using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeConceptionFabriqueEtCommande.Commandes.Parametres.Impl
{
    class ParametreCommandeAfficherBoiteAvertissement : IParametreCommande
    {
        public string Titre { get; set; }
        public string Message { get; set; }
        public String Gravite { get; set; }
    }
}
