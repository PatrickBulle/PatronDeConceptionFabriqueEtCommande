using PatronDeConceptionFabriqueEtCommande.JSon;
using System;
using System.Windows;

namespace PatronDeConceptionFabriqueEtCommande.Commandes.Fabrique
{
    static class CommandeFactory
    {

        public const Int32 TypeMessageInfo = 0x01;
        public const Int32 TypeMessageAvertissement = 0x02;
        public const Int32 TypeMessageFermerLeProgramme = 0x03;
        public const Int32 TypeMessageAfficherLesBovins = 0x04;

        static public Commande GetCommande(PatronDeConceptionFabriqueEtCommande.Trame.Trame trame)
        {
            Commande commande = null;

            if (trame != null)
            {
                switch (trame.TypeDeMessage)
                {
                    case TypeMessageInfo:
                        commande = new CommandeAfficherBoiteInfo();
                        commande.Parametre = DeserialisationJSon.GetParametreAfficherBoiteInfo(trame.ChargeUtile);
                        break;
                    case TypeMessageAvertissement:
                        commande = new CommandeAfficherBoiteAvertissement();
                        commande.Parametre = DeserialisationJSon.GetParametreAfficherBoiteAvertissement(trame.ChargeUtile);
                        break;
                    case TypeMessageFermerLeProgramme:
                        commande = new CommandeFermerLeProgramme();
                        commande.Parametre = DeserialisationJSon.GetParametreFermerLeProgramme(trame.ChargeUtile);
                        break;
                    case TypeMessageAfficherLesBovins:
                        commande = new CommandeAfficherLesBovins();
                        commande.Parametre = DeserialisationJSon.GetParametreAfficherLesBovins(trame.ChargeUtile);
                        break;
                }
            }
            return commande;
        }
    }
}
