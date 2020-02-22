using PatronDeConceptionFabriqueEtCommande.Commandes.Parametres.Impl;
using System;
using System.Windows;

namespace PatronDeConceptionFabriqueEtCommande.Commandes
{
    class CommandeAfficherBoiteAvertissement : Commande
    {
        public override void Execute()
        {
            if (Parametre != null)
            {
                ParametreCommandeAfficherBoiteAvertissement param = (ParametreCommandeAfficherBoiteAvertissement)Parametre;

                MessageBox.Show(param.Gravite + Environment.NewLine + param.Message, param.Titre, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
