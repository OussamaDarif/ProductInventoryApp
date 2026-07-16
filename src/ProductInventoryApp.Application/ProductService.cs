using ProductInventoryApp.Domain;

namespace ProductInventoryApp.Application;

public sealed class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public event EventHandler<Product>? ProductAdded;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public Product AddProduct(string name, string sku, string category, decimal price, int quantity)
    {
        var product = Product.Create(name, sku, category, price, quantity);
        _repository.Add(product);
        ProductAdded?.Invoke(this, product);
        return product;
    }

    public IReadOnlyList<Product> GetAllProducts() => _repository.GetAll();

    public IReadOnlyList<Product> Search(IProductFilter filter)
    {
        return _repository.GetAll().Where(filter.Matches).ToList();
    }
}
