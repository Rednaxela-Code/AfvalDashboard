namespace AfvalDashboard.Shared
{
    public class Lediging : DataEntity
    {
        public DateTime Tijd { get; set; }
        public Double Gewicht { get; set; }
        public bool VerbodenLading { get; set; }
    }
}
