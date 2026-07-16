using System.Globalization;
using ProductInventoryApp.Application;
using ProductInventoryApp.Domain;

namespace ProductInventoryApp.UI;

public sealed class MainPresenter
{
    private readonly IMainView _view;
    private readonly IProductService _productService;

    public MainPresenter(IMainView view, IProductService productService)
    {
        _view = view;
        _productService = productService;

        _view.AddProductRequested += OnAddProductRequested;
        _view.SearchTermChanged += OnSearchTermChanged;
        _productService.ProductAdded += OnProductAdded;
    }

    public void Initialize()
    {
        RefreshView();
    }

    private void OnAddProductRequested(object? sender, EventArgs e)
    {
        if (!decimal.TryParse(_view.PriceText, NumberStyles.Number, CultureInfo.CurrentCulture, out var price) &&
            !decimal.TryParse(_view.PriceText, NumberStyles.Number, CultureInfo.InvariantCulture, out price))
        {
            _view.ShowError("Price must be a valid number.");
            return;
        }

        if (!int.TryParse(_view.QuantityText, out var quantity))
        {
            _view.ShowError("Quantity must be a whole number.");
            return;
        }

        try
        {
            _productService.AddProduct(_view.ProductNameInput, _view.Sku, _view.Category, price, quantity);
            _view.ClearInputFields();
        }
        catch (ProductValidationException ex)
        {
            _view.ShowError(ex.Message);
        }
    }

    private void OnProductAdded(object? sender, Product product) => RefreshView();

    private void OnSearchTermChanged(object? sender, EventArgs e) => RefreshView();

    private void RefreshView()
    {
        var filter = new NameContainsFilter(_view.SearchTerm);
        _view.DisplayProducts(_productService.Search(filter));
    }
}
