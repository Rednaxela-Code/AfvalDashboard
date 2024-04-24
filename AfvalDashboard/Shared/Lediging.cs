namespace AfvalDashboard.Shared
{
    public class Lediging : DataEntity
    {
        public DateTime Tijd { get; set; }
        public Double Gewicht { get; set; }
        public bool VerbodenLading { get; set; }

        public Lediging()
        {
            
        }

        public List<Lediging> MaakHonderLedigingen()
        {
            var random = new Random();
            var list = new List<Lediging>();
            for (int i = 0; i < 100; i++)
            {
                var lediging = new Lediging()
                {
                    Id = i,
                    Tijd = DateTime.Now,
                    Gewicht = random.NextDouble() * 100,
                    VerbodenLading = random.Next(2) == 0
                };
                list.Add(lediging);
            }
            return list;
        }
    }
}
