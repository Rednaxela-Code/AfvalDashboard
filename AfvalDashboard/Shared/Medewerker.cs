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
    // The medew class in the assignment is a no-go, for readability you should not shorten entitynames if you can help it.
    // Also i would never make a full name property without a Firstname or Lastname property this so you can check correctnes easyer
    // The same would go for an Adres, i made it a class in here just as an example.
}
