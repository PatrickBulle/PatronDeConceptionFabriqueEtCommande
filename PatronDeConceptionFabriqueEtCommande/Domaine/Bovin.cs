using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeConceptionFabriqueEtCommande.Domaine
{
    class Bovin
    {
        public string Copaip { get; set; }
        public string Nunati { get; set; }
        public string Nobovi { get; set; }

        public override string ToString()
        {
            return Copaip + Nunati + " - " + Nobovi;
        }

    }
}
