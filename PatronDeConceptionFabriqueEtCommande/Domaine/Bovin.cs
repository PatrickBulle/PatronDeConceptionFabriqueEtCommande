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
