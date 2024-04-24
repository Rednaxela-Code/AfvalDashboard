namespace AfvalDashboard.Shared
{
    public class Wagen : DataEntity
    {
        public string Naam { get; set; }
        public bool Achterlader { get; set; }
        public bool Zijlader { get; set; }
        public string Merk { get; set; }

        public Wagen(int id, string naam, bool achterlader, bool zijlader, string merk)
        {
            Id = id;
            Naam = naam;
            Achterlader = achterlader;
            Zijlader = zijlader;
            Merk = merk;
        }
    }
}
