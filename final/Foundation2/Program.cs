using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Headphones",1524, 99.99, 3);
        Product product1A = new Product("Tv",3487, 500.55, 1);
        Product product1B = new Product("Bike",2202, 300.99, 2);
        Product product2 = new Product("Toy gun",3333, 20.45, 6);
        Product product2A = new Product("Smartphone",1010, 300.35, 3);
        Product product2B = new Product("Clasicc Guitar",2222, 150.90, 1);
        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product1A);
        products1.Add(product1B);
        List<Product> products2 = new List<Product>();
        products2.Add(product2);
        products2.Add(product2A);
        products2.Add(product2B);
        Address address1 = new Address("Waves and Lake", "Chicago", "Illinois", "USA");
        Address address2 = new Address("Uruguayana y Capurro", "Montevideo", "Montevideo", "Uruguay");
        Customer customer1 = new Customer("George Harrison", address1 );
        Customer customer2 = new Customer("Paul Reed Smith", address2);
        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);
        Console.WriteLine($"Order 1 Packing Label: \n{order1.PackingLabel()}");
        Console.WriteLine($"Order 1 Shipping Label: \n{order1.ShippingLabel()}");
        Console.WriteLine($"Order 1 Total Price: ${order1.GetTotalPrice()}");
        Console.WriteLine($"Order 2 Packing Label: \n{order2.PackingLabel()}");
        Console.WriteLine($"Order 2 Shipping Label: \n{order2.ShippingLabel()}");
        Console.WriteLine($"Order 2 Total Price: ${order2.GetTotalPrice()}");

        
    }
}