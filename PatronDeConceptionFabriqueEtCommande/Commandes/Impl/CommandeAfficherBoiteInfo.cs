using PatronDeConceptionFabriqueEtCommande.Commandes.Parametres.Impl;
using System.Windows;

namespace PatronDeConceptionFabriqueEtCommande.Commandes
{
    class CommandeAfficherBoiteInfo : Commande
    {
        public override void Execute()
        {
            if (Parametre != null)
            {
                ParametreCommandeAfficherBoiteInfo param = (ParametreCommandeAfficherBoiteInfo)Parametre;

                MessageBox.Show(param.Message, param.Titre, MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
