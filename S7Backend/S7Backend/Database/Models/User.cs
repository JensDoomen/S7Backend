using System.ComponentModel.DataAnnotations;

namespace S7Backend.Database.Models
{
    public class User
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }  
        public Guid deviceID { get; set; }

    }
}
