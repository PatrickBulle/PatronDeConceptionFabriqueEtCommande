using PatronDeConceptionFabriqueEtCommande.Commandes.Parametres;

namespace PatronDeConceptionFabriqueEtCommande.Commandes
{
    abstract class Commande
    {
        public IParametreCommande Parametre { protected get; set; }

        public abstract void Execute();
    }
}
