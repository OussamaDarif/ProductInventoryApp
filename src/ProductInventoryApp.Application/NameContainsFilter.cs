using ProductInventoryApp.Domain;

namespace ProductInventoryApp.Application;

public sealed class NameContainsFilter : IProductFilter
{
    private readonly string _searchTerm;

    public NameContainsFilter(string searchTerm)
    {
        _searchTerm = searchTerm?.Trim() ?? string.Empty;
    }

    public bool Matches(Product product)
    {
        if (string.IsNullOrEmpty(_searchTerm))
        {
            return true;
        }

        return product.Name.Contains(_searchTerm, StringComparison.OrdinalIgnoreCase);
    }
}
