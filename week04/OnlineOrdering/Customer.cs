public class Customer
{
    private string _name;
    private Address _address;

    public bool GetInUSA()
    {
        Address a1 = new Address("","","","");
        bool inUSA = a1.IsInUSA();
        if (inUSA == true)
        {
            return true;
        }

        else
        {
            return false;
        }
        
    }

    public int ShippingCost()
    {
        //double shippingCost;
        Address a1 = new Address("","","","");
        bool inUSA = a1.IsInUSA();
        if (inUSA == true)
        {
            return 5;
            
        }

        else
        {
            return 35;
            
        }

    }

    public void DisplayCustomer()
    {
       
        Console.WriteLine(_name);
        Console.WriteLine(_address.DisplayAddressString());

    }

    //constructor need to do anything special?
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public Customer()
    {

    }
}