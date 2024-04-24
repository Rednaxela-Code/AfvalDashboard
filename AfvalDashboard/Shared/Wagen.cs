using System.ComponentModel.DataAnnotations;

namespace AfvalDashboard.Shared
{
    public class Wagen : DataEntity
    {
        public string Naam { get; set; }
        public bool Achterlader { get; set; }
        public bool Zijlader { get; set; }
        public string Merk { get; set; }
    }
}
