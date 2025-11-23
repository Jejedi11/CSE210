using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address address = new Address("1977 Star Wars Ln", "Skywalker Ranch", "California", "USA");
        Customer james = new Customer("James Michelson", address);
        List<Product> basket1 = new List<Product>();
        Product grapes = new Product("Grapes", 123456, 3.20, 2);
        Product apples = new Product("Apples", 234567, 1.90, 3);
        basket1.Add(grapes);
        basket1.Add(apples);
        List<Product> basket2 = new List<Product>();
        Product bananas = new Product("Bananas", 345678, 2.50, 1);
        Product oranges = new Product("Oranges", 456789, 1.20, 4);
        basket2.Add(bananas);
        basket2.Add(oranges);

        Order order1 = new Order(basket1, james);
        Order order2 = new Order(basket2, james);

        Console.WriteLine(order1.MakePackingLabel());
        Console.WriteLine(order1.MakeShippingLabel());
        Console.WriteLine("$" + order1.TotalCost());

        Console.WriteLine(order2.MakePackingLabel());
        Console.WriteLine(order2.MakeShippingLabel());
        Console.WriteLine("$" + order2.TotalCost());

    }
}