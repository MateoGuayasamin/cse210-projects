using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Customer cx1 = new Customer("mateogs", "1221e12 st","Miami","FL","USA" );
        Customer cx2 = new Customer("luis diaz", "1221e12 st","Miami","FL","Ecuador");
        Product p1= new Product("playstation", 1423, 12.15, 2 );

        Order order1 = new Order();
        order1._customer = cx1;
        order1._products.Add(p1);
        Console.WriteLine(order1.TotalCost());
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());

    }
}