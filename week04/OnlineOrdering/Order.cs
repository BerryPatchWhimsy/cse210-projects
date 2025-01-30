public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public void AddProduct(Product newProduct)//works DON'T TOUCH
    {
        _products.Add(newProduct);
    }

    public double TotalCostProducts()
    {
        List<double> _costs = new List<double>();

        foreach (Product product in _products)
        {
            double productCost = product.CostProduct();
            _costs.Add(productCost);
        }

        double totalCost = _costs.Sum();
        return totalCost;
    }

    public double TotalOrderPrice()
    {
        double costOfProducts = TotalCostProducts();
        Customer c = new Customer();

        double shipping = c.ShippingCost();
        return costOfProducts + shipping;
    }

    public void DisplayTotalOrderPrice()
    {
        Console.WriteLine($"Total price: ${TotalOrderPrice()}");
    }

    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.DisplayProduct());
        }
    }

    public void GetShippingLabel(Customer customer)
    {
        _customer = customer;
        customer.DisplayCustomer();
    }

} 