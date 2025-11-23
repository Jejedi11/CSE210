public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public double TotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.TotalCost();
        }
        if (_customer.livesInUsa() == true)
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string MakePackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += product.GiveLabelInfo();
        }
        return label;
    }
    public string MakeShippingLabel()
    {
        string label = "";
            label += _customer.GiveShippingInfo();
        return label;
    }

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
}