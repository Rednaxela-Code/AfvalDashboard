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
            
        }

        public List<Wagen> MaakTienWagens()
        {
            var list = new List<Wagen>
            {
                new Wagen(Id = 1, Naam = "Wagen #1", Achterlader = true, Zijlader = false, Merk = "DAF"),
                new Wagen(Id = 2, Naam = "Wagen #2", Achterlader = false, Zijlader = true, Merk = "Scania"),
                new Wagen(Id = 3, Naam = "Wagen #3", Achterlader = true, Zijlader = false, Merk = "Mercedes"),
                new Wagen(Id = 4, Naam = "Wagen #4", Achterlader = false, Zijlader = true, Merk = "Renault"),
                new Wagen(Id = 5, Naam = "Wagen #5", Achterlader = true, Zijlader = false, Merk = "Volvo"),
                new Wagen(Id = 6, Naam = "Wagen #6", Achterlader = false, Zijlader = true, Merk = "DAF"),
                new Wagen(Id = 7, Naam = "Wagen #7", Achterlader = true, Zijlader = false, Merk = "Scania"),
                new Wagen(Id = 8, Naam = "Wagen #8", Achterlader = false, Zijlader = true, Merk = "Mercedes"),
                new Wagen(Id = 9, Naam = "Wagen #9", Achterlader = true, Zijlader = false, Merk = "Renault"),
                new Wagen(Id = 10, Naam = "Wagen #10", Achterlader = false, Zijlader = true, Merk = "Volvo")
            };
            return list;
        }
    }
}
