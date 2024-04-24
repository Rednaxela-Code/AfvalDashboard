namespace AfvalDashboard.Shared
{
    public class Lediging : DataEntity
    {
        public DateTime Tijd { get; set; }
        public Double Gewicht { get; set; }
        public bool VerbodenLading { get; set; }
        public string WagenNummer { get; set; }

        public Lediging(int id, DateTime tijd, double gewicht, bool verbodenLading, string wagenNummer)
        {
            Id = id;
            Tijd = tijd;
            Gewicht = gewicht;
            VerbodenLading = verbodenLading;
            WagenNummer = wagenNummer;
        }
    }
}
