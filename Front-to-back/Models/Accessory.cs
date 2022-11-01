using System.ComponentModel.DataAnnotations.Schema;

namespace Front_to_back.Models
{
    public class Accessory: BaseEntity
    {
        public string Image { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
    }
}
