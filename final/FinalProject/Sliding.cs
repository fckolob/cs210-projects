public class Sliding : Order
{
    protected string _closerType
    {
        get => default(string);
        set
        {
        }
    }

    protected bool _threeShashes
    {
        get => default(bool);
        set
        {
        }
    }

    protected bool _bearingWheels
    {
        get => default(bool);
        set
        {
        }
    }

    

    public Sliding(System.String nameCustomer, System.String addressCustomer, int phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, string dueDate, bool instalationIncluded, System.String closerType, bool threeShashes, bool bearingWheels) :base(nameCustomer, addressCustomer, phoneCustomer, totalPrice, amountPaid, widthMm, heightMm,  color, glassThickness, dvh, dueDate, instalationIncluded)
    {
        _closerType = closerType;
        _threeShashes = threeShashes;
        _bearingWheels = bearingWheels;
    }

    public Sliding(System.String savedString): base(savedString)
    {
        string[] parts = savedString.Split(",");
        _nameCustomer = parts[0];
        _addressCustomer = parts[1];
        _phoneCustomer = int.Parse(parts[2]);
        _totalPrice = double.Parse(parts[3]);
        _amountPaid = double.Parse(parts[4]);
        _widthMm = int.Parse(parts[5]);
        _heightMm = int.Parse(parts[6]);
        _color = parts[7];
        _glassThickness = int.Parse(parts[8]);
        _dvh = bool.Parse(parts[9]);
        _dueDate = parts[10];
        _instalationIncluded = bool.Parse(parts[11]);
        _closerType = parts[12];
        _threeShashes = bool.Parse(parts[13]);
        _bearingWheels = bool.Parse(parts[14]);
        _delivered = bool.Parse(parts[15]);
        _remainingAmountPaid = bool.Parse(parts[16]);
    }
    

    
    public string GetThreeShashesMessage()
    {
        if (_threeShashes == true)
        {
            return "This opening will have three shashes";
        }
        else
        {
            return "This opening will have two shashes";
        }
    }
    public string GetBearingWheelsMessage()
    {
        if (_bearingWheels == true)
        {
            return "This opening will have bearing wheels";
        }
        else
        {
            return "This opening will have simple wheels";
        }
    }
    public virtual int GetHorizontalFrame()
    {
        return 0;
    }
    public virtual int GetVerticalShashFrame()
    {
        return 0;
    }
    public virtual int GetHorizontalShashFrame()
    {
        return 0;
    }
    public virtual int GetGlassWidth()
    {
        return 0;
    }
    public virtual int GetGlassHeight()
    {
        return 0;
    }
    public virtual int GetScreenWidth()
    {
        return 0;
    }
    public virtual int GetScreenHeight()
    {
        return 0;
    }
    public virtual int GetScreenGuides()
    {
        return 0;
    }
    public override string ToSavedString()
    {
        return $"{this.GetType()}:{_nameCustomer},{_addressCustomer},{_phoneCustomer.ToString()},{_totalPrice.ToString()},{_amountPaid.ToString()},{_widthMm.ToString()},{_heightMm.ToString()},{_color},{_glassThickness.ToString()},{_dvh.ToString()},{_dueDate},{_instalationIncluded.ToString()},{_closerType},{_threeShashes.ToString()},{_bearingWheels.ToString()},{_delivered.ToString()},{_remainingAmountPaid.ToString()}";
    }

    public override string ToString()
    {
        return $"Type of opening: {this.GetType()} \n Name of the customer: {_nameCustomer} \n Address of the costumer: {_addressCustomer} \n Phone of the costumer: {_phoneCustomer} \n Total price: ${_totalPrice} \n Amount already paid: ${_amountPaid} \n The due date for deliver the opening is {_dueDate} \n {GetInstalationIncludedMessage()} \n Width of the opening in mm: {_widthMm}mm \n Height of the opening in mm: {_heightMm}mm \n Color of the opening: {_color} \n Glass Thickness: {_glassThickness}mm \n {GetDvhMessage()} \n The type of closer for this opening is {_closerType} \n {GetThreeShashesMessage()} \n {GetBearingWheelsMessage()} \n {GetDeliveredMessage()} \n {GetRemainingAmountPaidMessage()}.";
    }
    public override string ProductionWorkSheet()
    {
        return $"Opening Type: {this.GetType()} \n Total width: {_widthMm}mm. \n Total height: {_heightMm}mm. \n Horizontal Frame lenght: {GetHorizontalFrame()}mm \n Vertical Frame lenght: {_heightMm}mm \n Vertical Sash Frame lenght: {GetVerticalShashFrame} \n Horizontal Shash Frame lenght: {GetHorizontalShashFrame()}mm \n Screen Width: {GetScreenWidth()}mm \n Screen Height: {GetScreenHeight()}mm \n Screen Guides: {GetScreenGuides()}mm \n Glass Width: {GetGlassWidth()}mm \n Glass Height: {GetGlassHeight()}mm \n {GetThreeShashesMessage()} \n {GetBearingWheelsMessage()} \n The Closer Type for this opening is: {_closerType} ";
    }
}