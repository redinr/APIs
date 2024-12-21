using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogAPI.Models
{
    public class Product
    {
        [Key]
        public Guid Oid { get; set; }
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        [Required]
        [StringLength(100)]
        public string? Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        [StringLength(500)]
        public string? UrlImage { get; set; }
        [Required]
        public float Stok { get; set; }
        [Required]
        public DateTime DateRegister { get; set; }
        [Required]
        public Guid CategoryOid { get; set; }
        public Category? Category { get; set; }
    }
}
