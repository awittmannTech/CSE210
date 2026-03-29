using System;

class Program
{
    static void Main()
    {
        var product1 = new Product(1, "Laptop", 500.00, 1);
        var product2 = new Product(2, "Phone", 1000.50, 1);
        var product3 = new Product(3, "Monitor", 299.99, 2);
        var product4 = new Product(4, "Keyboard", 79.99, 1);

        var address1 = new Address("123 Main St", "Scranton", "PA", "USA");
        var customer1 = new Customer("Jim Halpert", address1);

        var address2 = new Address("456 Oak Ave", "Scranton", "PA", "Canada");
        var customer2 = new Customer("Micheal Scott", address2);

        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}