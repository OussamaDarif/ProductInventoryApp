namespace ProductInventoryApp.Domain;

public sealed class ProductValidationException : Exception
{
    public ProductValidationException(string message) : base(message)
    {
    }
}
