namespace CatalogAPI.Models;
public class Product
{
    public int IdProduct { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImageUtl { get; set; }
    public float Stok { get; set; }
    public DateTime RegistretionDate { get; set; }
}
