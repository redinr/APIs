using System.Collections.ObjectModel;

namespace CatalogAPI.Models
{
    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }
        public Guid Oid { get; set; }
        public string? Name { get; set; }
        public string? UrlImage { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
