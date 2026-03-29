public class Order
{
    public List<Product>_products = new List<Product>();
    public Customer _customer; 

    public double TotalCost()
    {
        double subtotal = 0;
        foreach(Product p in _products )
        {
            subtotal += p.TotalCost();
        }
        
        if ( _customer.IsCxFromUSA())
        {
            return subtotal + 5;
        }
        else
        {
            return subtotal + 35;
        }
    
    }
    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in _products)
        {
            label += $"{p._name} (ID: {p._productid})\n";
        }
        return label;
        
        
    }

    public string ShippingLabel()
    {
        string _address = _customer._address.GetDisplayAddress();
        string label = $"Customer: {_customer._name}\nAddress:\n{_address}";
        return label;
    }

}
