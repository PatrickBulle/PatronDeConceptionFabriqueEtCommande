using PatronDeConceptionFabriqueEtCommande.Commandes.Parametres.Impl;
using System;
using System.Threading;
using System.Windows;

namespace PatronDeConceptionFabriqueEtCommande.Commandes
{
    class CommandeFermerLeProgramme : Commande
    {
        public override void Execute()
        {
            if (Parametre != null)
            {
                ParametreCommandeFermerLeProgramme param = (ParametreCommandeFermerLeProgramme)Parametre;
               
                MessageBox.Show(param.Message, param.Titre, MessageBoxButton.OK, MessageBoxImage.Exclamation);
                Thread.Sleep(param.DelaiAvantFermeture);
                Environment.Exit(0);
            }
        }
    }
}
