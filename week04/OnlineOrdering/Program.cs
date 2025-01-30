using System;

class Program
{
    static void Main(string[] args)
    {

        //creates at least two orders with a 2-3 products each
        //get product names and quantities
        //then add them to list
        //then address and customer info
        //Call the methods to get the packing label, shipping label, and total price of the order, 
        //display the results of these methods.
        
        Product p1 = new Product("apples",9, 3445, 1.23);
        Product p2 = new Product("bananas", 10, 1232, .10);
        Product p3 = new Product("oranges",5, 8743, 1.25);
        Product p4 = new Product("grapes",2, 6565, 1.05);
        
        Order o1 = new Order();
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);
        o1.AddProduct(p4);

        Address a1 = new Address("1555 Chester Blvd", "Carrey", "Nebraska", "USA");
        Customer c1 = new Customer("Charley Bucket", a1);


        Product p5 = new Product("balloon", 3, 9212, 3.25);
        Product p6 = new Product("cake", 1, 8740, 29.99);
        Product p7 = new Product("streamers", 4, 5894, 2.25);
        Product p8 = new Product("cupcakes", 12, 9898, 15.99);
        
        Order o2 = new Order();
        o2.AddProduct(p5);
        o2.AddProduct(p6);
        o2.AddProduct(p7);
        o2.AddProduct(p8);

        Address a2 = new Address("286 W 19th Ave", "Vancouver", "BC ", "Canada");
        Customer c2 = new Customer("Sherri Trumpet", a2);

        Console.WriteLine("");
        o1.GetPackingLabel();
        o1.DisplayTotalOrderPrice();
        o1.GetShippingLabel(c1);


        Console.WriteLine("");
        o2.GetPackingLabel();
        o2.DisplayTotalOrderPrice();
        o2.GetShippingLabel(c2);

    }
}