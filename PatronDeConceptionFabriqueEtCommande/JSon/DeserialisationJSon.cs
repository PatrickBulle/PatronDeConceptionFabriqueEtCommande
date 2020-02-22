using Newtonsoft.Json;
using PatronDeConceptionFabriqueEtCommande.Commandes.Parametres.Impl;
using PatronDeConceptionFabriqueEtCommande.Domaine;
using System.Collections.Generic;

namespace PatronDeConceptionFabriqueEtCommande.JSon
{
    static class DeserialisationJSon
    {
        public static ParametreCommandeAfficherBoiteInfo GetParametreAfficherBoiteInfo(string chargeUtile)
        {
            return JsonConvert.DeserializeObject<ParametreCommandeAfficherBoiteInfo>(chargeUtile);
        }

        public static ParametreCommandeAfficherBoiteAvertissement GetParametreAfficherBoiteAvertissement(string chargeUtile)
        {
            return JsonConvert.DeserializeObject<ParametreCommandeAfficherBoiteAvertissement>(chargeUtile);
        }

        public static ParametreCommandeFermerLeProgramme GetParametreFermerLeProgramme(string chargeUtile)
        {
            return JsonConvert.DeserializeObject<ParametreCommandeFermerLeProgramme>(chargeUtile);
        }

        public static ParametreCommandeAfficherLesBovins GetParametreAfficherLesBovins(string chargeUtile)
        {
            List<Bovin> bovins = JsonConvert.DeserializeObject<List<Bovin>>(chargeUtile);
            ParametreCommandeAfficherLesBovins param = new ParametreCommandeAfficherLesBovins
            {
                ListeDesBovins = bovins
            };
            return param;
        }

    }
}
