public class Product
{
    private int _productId;
    private string _name;
    private double _pricePerUnit;
    private int _quantity;

    public Product(int productId, string name, double pricePerUnit, int quantity)
    {
        _productId = productId;
        _name = name;
        _quantity = quantity;
        _pricePerUnit = pricePerUnit;
    }

    public double GetTotalCost()
    {
        return _quantity * _pricePerUnit;
    }

    public string GetProductDesc()
    {
        return $"{_productId}. {_name}";
    }
}