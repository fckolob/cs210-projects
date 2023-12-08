public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        
        _customer = customer;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public List<Product> GetProducts()
    {
        return _products;
    }
    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalPrice();
        }
        if (_customer.GetUsaCustomer() == true)
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        return totalPrice;
    }
    public string PackingLabel()
    {
        string packingLabel = $"";
        foreach (Product product in _products)
        {
            packingLabel += $"Product: {product.GetName()} Id: {product.GetProductId()} \n";
        }
        return packingLabel;
    }
    public string ShippingLabel()
    {
        return $"Customer's name: {_customer.GetName()} \nCustomer's Address: {_customer.GetAddress()} \n";
        
    }
}