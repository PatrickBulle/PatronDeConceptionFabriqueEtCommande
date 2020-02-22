using PatronDeConceptionFabriqueEtCommande.Commandes.Parametres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeConceptionFabriqueEtCommande.Commandes
{
    abstract class Commande
    {
        public IParametreCommande Parametre { protected get; set; }

        public abstract void Execute();
    }
}
