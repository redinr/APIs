namespace CatalogAPI.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? UrlImage { get; set; }
        public float Stok { get; set; }
        public DateTime DateRegister { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
