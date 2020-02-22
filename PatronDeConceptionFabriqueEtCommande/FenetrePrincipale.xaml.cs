using PatronDeConceptionFabriqueEtCommande.Commandes;
using PatronDeConceptionFabriqueEtCommande.Commandes.Fabrique;
using System.Windows;

namespace PatronDeConceptionFabriqueEtCommande
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RadioButton_Information.IsChecked = true;
        }

        private void RadioButton_Check_Info(object sender, RoutedEventArgs e)
        {
            ExempleDeTrame.Text = "{\"Titre\":\"Pour information\",\"Message\":\"Message \\u00E0 titre informatif\"}";
        }

        private void RadioButton_Check_Avertissement(object sender, RoutedEventArgs e)
        {
            ExempleDeTrame.Text = "{\"Titre\":\"Attention\",\"Message\":\"Une erreur est survenue\",\"Gravite\":\"Attention\"}";
        }
        private void RadioButton_Check_FermerLeProgramme(object sender, RoutedEventArgs e)
        {
            ExempleDeTrame.Text = "{\"Titre\":\"Ca va couper\",\"Message\":\"Le programme va se fermer dans quelques secondes\",\"DelaiAvantFermeture\":1500}";
        }
        private void RadioButton_Check_AfficherLesBovins(object sender, RoutedEventArgs e)
        {
            ExempleDeTrame.Text = "[{\"Copaip\":\"FR\",\"Nunati\":\"2512345625\",\"Nobovi\":\"TITINE\"},{\"Copaip\":\"FR\",\"Nunati\":\"3912345639\",\"Nobovi\":\"PUPUCE\"},{\"Copaip\":\"FR\",\"Nunati\":\"7012345670\",\"Nobovi\":\"BLANCHE\"}]";
        }

        private void Button_GO_Click(object sender, RoutedEventArgs e)
        {
            PatronDeConceptionFabriqueEtCommande.Trame.Trame trame = new PatronDeConceptionFabriqueEtCommande.Trame.Trame();

            if (RadioButton_Information.IsChecked.Value)
                trame.TypeDeMessage = CommandeFactory.TypeMessageInfo;
            if (RadioButton_Avertissement.IsChecked.Value)
                trame.TypeDeMessage = CommandeFactory.TypeMessageAvertissement;
            if (RadioButton_Fermer.IsChecked.Value)
                trame.TypeDeMessage = CommandeFactory.TypeMessageFermerLeProgramme;
            if (RadioButton_AfficherLesBovins.IsChecked.Value)
                trame.TypeDeMessage = CommandeFactory.TypeMessageAfficherLesBovins;
            trame.ChargeUtile = ExempleDeTrame.Text;

            Commande commande = CommandeFactory.GetCommande(trame);
            if (commande != null)
                commande.Execute();


        }
    }
}
