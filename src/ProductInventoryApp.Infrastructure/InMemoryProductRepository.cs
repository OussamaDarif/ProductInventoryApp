using ProductInventoryApp.Application;
using ProductInventoryApp.Domain;

namespace ProductInventoryApp.Infrastructure;

public sealed class InMemoryProductRepository : IProductRepository
{
    private readonly List<Product> _products = new();

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public IReadOnlyList<Product> GetAll() => _products.AsReadOnly();

    public bool ExistsByName(string name)
    {
        return _products.Any(p => string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));
    }
}
