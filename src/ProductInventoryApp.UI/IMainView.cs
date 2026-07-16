using ProductInventoryApp.Domain;

namespace ProductInventoryApp.UI;

public interface IMainView
{
    string ProductNameInput { get; }
    string Sku { get; }
    string Category { get; }
    string PriceText { get; }
    string QuantityText { get; }
    string SearchTerm { get; }

    event EventHandler? AddProductRequested;
    event EventHandler? SearchTermChanged;

    void DisplayProducts(IReadOnlyList<Product> products);
    void ShowError(string message);
    void ClearInputFields();
}
