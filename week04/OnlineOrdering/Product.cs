public class Product
{
    private string _name;
    private int _id;
    private int _quantity;
    private double _price;

    public double CostProduct()
    {
        double totalCost = _price * _quantity;
        return totalCost;
    }

    public string DisplayProduct()
    {
        return $"{_id}- {_name}";
    }

    //constructor include name and quantity
    public Product(string nameProduct, int quantity, int id, double price)
    {
        _name = nameProduct;
        _quantity = quantity;
        _id = id;
        _price = price;
    }
}