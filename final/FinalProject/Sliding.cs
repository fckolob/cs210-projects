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
        
    }
    

    public override string ProductionWorkSheet()
    {
        throw new System.NotImplementedException();
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

    public override string ToSavedString()
    {
        return $"{this.GetType()}:{_nameCustomer},{_addressCustomer},{_phoneCustomer.ToString()},{_totalPrice.ToString()},{_amountPaid.ToString()},{_widthMm.ToString()},{_heightMm.ToString()},{_color},{_glassThickness.ToString()},{_dvh.ToString()},{_dueDate},{_instalationIncluded.ToString()},{_closerType},{_threeShashes.ToString()},{_bearingWheels.ToString()}";
    }

    public override string ToString()
    {
        return $"Type of opening: {this.GetType()} \n Name of the customer: {_nameCustomer} \n Address of the costumer: {_addressCustomer} \n Phone of the costumer: {_phoneCustomer} \n Total price: ${_totalPrice} \n Amount already paid: ${_amountPaid} \n The due date for deliver the opening is {_dueDate} \n {GetInstalationIncludedMessage()} \n Width of the opening in mm: {_widthMm}mm \n Height of the opening in mm: {_heightMm}mm \n Color of the opening: {_color} \n Glass Thickness: {_glassThickness}mm \n {GetDvhMessage()} \n The type of closer for this opening is {_closerType} \n {GetThreeShashesMessage()} \n {GetBearingWheelsMessage()}";
    }
}