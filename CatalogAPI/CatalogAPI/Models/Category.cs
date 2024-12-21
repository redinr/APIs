using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CatalogAPI.Models
{
    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }
        [Key]
        public Guid Oid { get; set; }
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        [StringLength(500)]
        public string? UrlImage { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
