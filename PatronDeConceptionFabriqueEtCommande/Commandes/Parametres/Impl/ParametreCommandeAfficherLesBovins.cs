using PatronDeConceptionFabriqueEtCommande.Domaine;
using System.Collections.Generic;

namespace PatronDeConceptionFabriqueEtCommande.Commandes.Parametres.Impl
{
    class ParametreCommandeAfficherLesBovins : IParametreCommande
    {
        public List<Bovin> ListeDesBovins { get; set; }
    }
}
