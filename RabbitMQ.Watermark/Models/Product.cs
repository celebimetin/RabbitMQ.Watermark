using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RabbitMQ.Watermark.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Range(0, 500)]
        public int Stock { get; set; }
        [StringLength(500)]
        public string? ImageName { get; set; }
    }
}