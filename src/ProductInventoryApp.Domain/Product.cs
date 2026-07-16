namespace ProductInventoryApp.Domain;

public sealed class Product
{
    public Guid Id { get; }
    public string Name { get; }
    public string Sku { get; }
    public string Category { get; }
    public decimal Price { get; }
    public int Quantity { get; }
    public DateTime CreatedAt { get; }

    private Product(Guid id, string name, string sku, string category, decimal price, int quantity, DateTime createdAt)
    {
        Id = id;
        Name = name;
        Sku = sku;
        Category = category;
        Price = price;
        Quantity = quantity;
        CreatedAt = createdAt;
    }

    public static Product Create(string name, string sku, string category, decimal price, int quantity)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ProductValidationException("Product name is required.");
        }

        if (price < 0)
        {
            throw new ProductValidationException("Price cannot be negative.");
        }

        if (quantity < 0)
        {
            throw new ProductValidationException("Quantity cannot be negative.");
        }

        return new Product(Guid.NewGuid(), name.Trim(), sku?.Trim() ?? string.Empty, category?.Trim() ?? string.Empty, price, quantity, DateTime.Now);
    }
}
