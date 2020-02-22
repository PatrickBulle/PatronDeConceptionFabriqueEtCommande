using PatronDeConceptionFabriqueEtCommande.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

            var b = new Bovin
            {
                Copaip = "FR",
                Nunati = "123456789",
                Nobovi = "TITINE"
            };

        }

        private void RadioButton_Check_Info(object sender, RoutedEventArgs e)
        {
            ExempleDeTrame.Text = @"tutu";
        }

        private void RadioButton_Check_Avertissement(object sender, RoutedEventArgs e)
        {
            ExempleDeTrame.Text = @"AVERTISSEMENT";
        }
        private void RadioButton_Check_FermerLeProgramme(object sender, RoutedEventArgs e)
        {
            ExempleDeTrame.Text = @"FERMER LE PROGRAMME";
        }
        private void RadioButton_Check_AfficherLesBovins(object sender, RoutedEventArgs e)
        {
            ExempleDeTrame.Text = @"AFFICHER LES BOVINS";
        }

        private void Button_GO_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
