using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("405 s Washington St", "Johnson City", "MI", "USA");
        Customer customer1 = new Customer("Sam Smith", address1);

        Product C1P1 = new Product("Laptop", "1526434", 699.99, 1);
        Product C1P2 = new Product("Charging Cord", "7329841", 29.99, 4);

        Order O1 = new Order(customer1);
        O1.AddProduct(C1P1);
        O1.AddProduct(C1P2);

        Console.WriteLine(O1.GetPackingLabel());
        Console.WriteLine(O1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${O1.CalculateTotalPrice()}");
        Console.WriteLine();

        Address address2 = new Address("302 Jefferson St", "Big River", "OT", "Canada");
        Customer customer2 = new Customer("Jolly Roger", address2);

        Product C2P1 = new Product("Iphone X", "1542396", 999.99, 2);
        Product C2P2 = new Product("MacBook Pro", "1532201", 1299.99, 2);

        Order O2 = new Order(customer2);
        O2.AddProduct(C2P1);
        O2.AddProduct(C2P2);

        Console.WriteLine(O2.GetPackingLabel());
        Console.WriteLine(O2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${O2.CalculateTotalPrice()}");
    }
    
}