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
        Product p2 = new Product("TV", 1424, 548.25, 1 );
        Product p3 = new Product("phone", 1425, 200, 1 );
        Product p4 = new Product("food", 1426, 155.25, 4 );
        Product p5 = new Product("table", 1425, 75.24, 1 );

        Order order1 = new Order();
        order1._customer = cx1;
        order1._products.Add(p1);
        order1._products.Add(p2);
        order1._products.Add(p3);
        Console.WriteLine(order1.TotalCost());
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());

        Order order2 = new Order();
        order2._customer = cx2;
        order2._products.Add(p4);
        order2._products.Add(p5);
        Console.WriteLine(order2.TotalCost());
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());

    }
}