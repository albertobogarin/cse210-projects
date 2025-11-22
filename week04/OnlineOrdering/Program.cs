using System;

class Program
{
    static void Main(string[] args)
    {
    
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");

        
        Customer customer1 = new Customer("Alice Johnson", address1);
        Customer customer2 = new Customer("Bob Smith", address2);

    
        Product product1 = new Product("T-shirt", "TS001", 15.0, 2);
        Product product2 = new Product("Mug", "MG002", 10.0, 3);
        Product product3 = new Product("Notebook", "NB003", 7.5, 4);
        Product product4 = new Product("Pen", "PN004", 2.0, 10);

       
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

       
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
