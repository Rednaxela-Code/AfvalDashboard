namespace AfvalDashboard.Shared
{
    public class Medewerker : DataEntity
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set;}
        public DateOnly GeboorteDatum { get; set; }
        public Adres Adres{ get; set; }

        public Medewerker(int id, string voornaam, string achternaam, DateOnly geboorteDatum, Adres adres)
        {
            Id = id;
            Voornaam = voornaam;
            Achternaam = achternaam;
            GeboorteDatum = geboorteDatum;
            Adres = adres;
        }
    }
}
