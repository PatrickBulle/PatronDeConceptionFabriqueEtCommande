using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeConceptionFabriqueEtCommande.Commandes.Parametres.Impl
{
    class ParametreCommandeAfficherBoiteInfo : IParametreCommande
    {
        public string Titre { get; set; }
        public string Message { get; set; }
    }
}
