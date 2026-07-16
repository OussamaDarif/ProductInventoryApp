using ProductInventoryApp.Domain;

namespace ProductInventoryApp.Application;

public interface IProductFilter
{
    bool Matches(Product product);
}
