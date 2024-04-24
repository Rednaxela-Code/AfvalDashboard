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

        public Wagen Find(List<Wagen>? List, int Id)
        {
            Wagen r = null;
            foreach (var i in List)
            {
                if (i.Id == Id)
                    r = i;
            }
            return r;
        }

        public Wagen FindWagenById(List<Wagen>? wagenList, int id)
        {
            if (!wagenList.Any())
            {
                return null;
            }

            foreach (var wagen in wagenList)
            {
                if (wagen.Id == id)
                {
                    return wagen;
                }
            }
            return null;
        }

        public Wagen FindWagenByIdLinq(List<Wagen>? wagenList, int id)
        {
            if (!wagenList.Any())
            {
                return null;
            }
            else
            {
                var wagen = wagenList.Where(w => w.Id.Equals(id))?.FirstOrDefault();
                if (wagen != null)
                {
                    return wagen;
                }
            }
            return null;
        }
    }
}
