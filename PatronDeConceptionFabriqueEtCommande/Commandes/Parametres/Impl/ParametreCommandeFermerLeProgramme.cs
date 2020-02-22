using System;

namespace PatronDeConceptionFabriqueEtCommande.Commandes.Parametres.Impl
{
    class ParametreCommandeFermerLeProgramme : IParametreCommande
    {
        public string Titre { get; set; }
        public string Message { get; set; }
        public Int32 DelaiAvantFermeture { get; set; }
    }
}
