using PatronDeConceptionFabriqueEtCommande.Commandes.Parametres.Impl;
using PatronDeConceptionFabriqueEtCommande.Domaine;
using System;
using System.Text;
using System.Windows;

namespace PatronDeConceptionFabriqueEtCommande.Commandes
{
    class CommandeAfficherLesBovins : Commande
    {
        public override void Execute()
        {
            if (Parametre != null)
            {
                ParametreCommandeAfficherLesBovins param = (ParametreCommandeAfficherLesBovins)Parametre;
                StringBuilder bovins = new StringBuilder();

                foreach (Bovin bovin in param.ListeDesBovins)
                    bovins.Append(bovin.ToString() + Environment.NewLine);
                MessageBox.Show(bovins.ToString(), "Liste des bovins", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
