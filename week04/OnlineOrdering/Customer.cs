public class Customer
{
    private string _name;
    private Address _address;

    public bool livesInUsa()
    {
        if (_address.IfInUsa() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GiveShippingInfo()
    {
        return _name + " " + _address.ReturnAllFields();
    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
}