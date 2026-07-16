using ProductInventoryApp.Domain;

namespace ProductInventoryApp.Application;

public interface IProductRepository
{
    void Add(Product product);
    IReadOnlyList<Product> GetAll();
    bool ExistsByName(string name);
}
