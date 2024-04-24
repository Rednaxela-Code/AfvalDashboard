using System.ComponentModel.DataAnnotations;

namespace AfvalDashboard.Shared
{
    public abstract class DataEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
