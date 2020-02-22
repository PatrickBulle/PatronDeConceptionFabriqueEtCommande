using System;

namespace PatronDeConceptionFabriqueEtCommande.Commandes.Parametres.Impl
{
    class ParametreCommandeAfficherBoiteAvertissement : IParametreCommande
    {
        public string Titre { get; set; }
        public string Message { get; set; }
        public String Gravite { get; set; }
    }
}
