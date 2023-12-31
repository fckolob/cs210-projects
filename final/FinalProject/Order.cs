// SMT I would expect an Order to manage a list of things (which should be abstracted into there own classes) ordered.
public abstract class Order
{
    // SMT Consider abstracting the customer info into it's own class
    protected string _nameCustomer;


    protected long _phoneCustomer;

    protected double _totalPrice;

    protected double _amountPaid;

    protected string _dueDate;

    // SMT I'm not sure why Order would have a color. Color should be managed by the item in the Order.
    protected string _color;

    protected string _addressCustomer;

    // SMT I'm not sure why Order would have a width and height. Those attributes should be managed by the item in the Order.
    protected int _widthMm;

    protected int _heightMm;

    // SMT same with glassThickness. Should be managed by the item in the order
    protected int _glassThickness;


    protected bool _dvh;
    protected bool _instalationIncluded;

    protected bool _delivered;
    protected bool _remainingAmountPaid;

    public Order(System.String nameCustomer, System.String addressCustomer, long phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, string dueDate, bool instalationIncluded)
    {
        _nameCustomer = nameCustomer;
        _addressCustomer = addressCustomer;
        _phoneCustomer = phoneCustomer;
        _totalPrice = totalPrice;
        _amountPaid = amountPaid;
        _widthMm = widthMm;
        _heightMm = heightMm;
        _color = color;
        _glassThickness = glassThickness;
        _dvh = dvh;
        _dueDate = dueDate;
        _instalationIncluded = instalationIncluded;

    }

    public Order(System.String savedString)
    {

    }

    // SMT consider passing in the payment to the method.
    public double RemainingAmount()
    {
        return _totalPrice - _amountPaid;
    }

    // SMT You don't need this since isn't not implmented.
    public override string ToString()
    {
        return base.ToString();
    }


    public abstract string ToSavedString();



    public abstract string ProductionWorkSheet();


    public string AdministrationWorkSheet()
    {
        return $"Type of opening: {this.GetType()} \n Name: {_nameCustomer} \n Address: {_addressCustomer} \n Phone number: {_phoneCustomer} \n Total price: ${_totalPrice} \n Amount already paid: ${_amountPaid} \n Remaining amount: ${RemainingAmount()} \n Due date for deliver this opening: {_dueDate} \n {GetInstalationIncludedMessage()} \n {GetDeliveredMessage()} \n {GetRemainingAmountPaidMessage()}";
    }
    public string GetName()
    {
        return $"Name: {_nameCustomer} Type: {this.GetType()} Measures: width: {_widthMm}mm height: {_heightMm}mm ";
    }
    public virtual string GetDvhMessage()
    {
        if (_dvh == true)
        {
            return "This opening will have DVH glass";
        }
        else
        {
            return "This opening will have single glass";
        }
    }
    public string GetInstalationIncludedMessage()
    {
        if (_instalationIncluded == true)
        {
            return "The instalation is included for this opening";
        }
        else
        {
            return "The instalation is not included for this opening";
        }
    }
    public string GetDeliveredMessage()
    {
        if (_delivered == true)
        {
            return "This opening was already delivered";
        }
        else
        {
            return "This opening is not delivered yet";
        }
    }
    public string GetRemainingAmountPaidMessage()
    {
        if (_remainingAmountPaid == true)
        {
            return "The remaining amount for this opening was already paid";
        }
        else
        {
            return "The remaining amount for this opening is not paid yet";
        }
    }
    public void RecordEventDelivered()
    {
        _delivered = true;
    }
    public void RecordEventRemainingAmountPaid()
    {
        _remainingAmountPaid = true;
        _amountPaid = _totalPrice;
    }
}
