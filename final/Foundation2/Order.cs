public class Order
{
    private List<Product> _products;
    private Customer  _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double runningTotal = 0;
        foreach (Product product in _products)
        {
            runningTotal += product.GetTotalCost();
        }

        if (_customer.IsInUSA())
            runningTotal += 5;
        else
            runningTotal += 35;

        return runningTotal;
    }

    public string GetPackingLabel()
    {
        string res = "";

        foreach(Product product in _products)
        {
            res += product.GetProductDesc() + "\n";
        }

        return res;
    }

    public string GetShippingLabel()
    {
        return _customer.GetCustomerDesc();
    }

}