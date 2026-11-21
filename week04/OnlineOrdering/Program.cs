using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("4356 Lake St", "Rockcir", "ID", "USA");
        Customer customer1 = new Customer("Joseph Goka", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP-01", 999.99,1));
        order1.AddProduct(new Product("Hard Drive", "HDD-02",200.99,2));
        order1.AddProduct(new Product("keyboard", "KEY-03", 78.50,1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");
        Console.WriteLine("\n---------------------------------------\n");

        Address address2 = new Address("543 King Fahad Street","Khobar", "Easten Province", "Kingdom Of Saudi Arabia");
        Customer customer2 = new Customer("Francisca Goka", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headset", "HES-04", 125.55,1));
        order2.AddProduct(new Product("phone Case","PHO-005", 15.66,1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");


    }
}