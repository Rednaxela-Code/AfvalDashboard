namespace AfvalDashboard.Shared
{
    public class Adres : DataEntity
    {
        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public string Postcode { get; set; }
        public string Woonplaats { get; set; }

        public Adres(int id, string straat, string huisnummer, string postcode, string woonplaats)
        {
            Id = id;
            Straat = straat;
            Huisnummer = huisnummer;
            Postcode = postcode;
            Woonplaats = woonplaats;
        }
    }
}