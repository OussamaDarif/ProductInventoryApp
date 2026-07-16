using ProductInventoryApp.Domain;

namespace ProductInventoryApp.UI;

public partial class MainForm : Form, IMainView
{
    public MainForm()
    {
        InitializeComponent();
        ConfigureGridColumns();
    }

    public string ProductNameInput => txtName.Text;
    public string Sku => txtSku.Text;
    public string Category => txtCategory.Text;
    public string PriceText => txtPrice.Text;
    public string QuantityText => txtQuantity.Text;
    public string SearchTerm => txtSearch.Text;

    public event EventHandler? AddProductRequested;
    public event EventHandler? SearchTermChanged;

    public void DisplayProducts(IReadOnlyList<Product> products)
    {
        dgvProducts.DataSource = null;
        dgvProducts.DataSource = products.Select(p => new
        {
            p.Name,
            p.Sku,
            p.Category,
            p.Price,
            p.Quantity,
            CreatedAt = p.CreatedAt.ToString("g")
        }).ToList();
    }

    public void ShowError(string message)
    {
        lblError.Text = message;
    }

    public void ClearInputFields()
    {
        txtName.Clear();
        txtSku.Clear();
        txtCategory.Clear();
        txtPrice.Clear();
        txtQuantity.Clear();
        lblError.Text = string.Empty;
        txtName.Focus();
    }

    private void ConfigureGridColumns()
    {
        dgvProducts.AutoGenerateColumns = true;
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        lblError.Text = string.Empty;
        AddProductRequested?.Invoke(this, EventArgs.Empty);
    }

    private void txtSearch_TextChanged(object? sender, EventArgs e)
    {
        SearchTermChanged?.Invoke(this, EventArgs.Empty);
    }
}
