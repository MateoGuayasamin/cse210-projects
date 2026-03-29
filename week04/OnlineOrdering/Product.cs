public class Product{
    
    public string _name;
    public int _productid;
    public double _price;
    public int _quantity;

    public Product( string name, int productid, double price , int quantity )
    {
        _name = name; 
        _productid = productid;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        double tamount = _price * _quantity;
        return tamount;
    
    }


}