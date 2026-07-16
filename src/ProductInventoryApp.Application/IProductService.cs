using ProductInventoryApp.Domain;

namespace ProductInventoryApp.Application;

public interface IProductService
{
    event EventHandler<Product>? ProductAdded;

    Product AddProduct(string name, string sku, string category, decimal price, int quantity);
    IReadOnlyList<Product> GetAllProducts();
    IReadOnlyList<Product> Search(IProductFilter filter);
}
