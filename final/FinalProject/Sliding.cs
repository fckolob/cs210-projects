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

    

    public Sliding(System.String nameCustomer, System.String addressCustomer, int phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, string dueDate, System.String closerType, bool threeShashes, bool bearingWheels) :base(nameCustomer, addressCustomer, phoneCustomer, totalPrice, amountPaid, widthMm, heightMm,  color, glassThickness, dvh, dueDate)
    {
        _closerType = closerType;
        _threeShashes = threeShashes;
        _bearingWheels = bearingWheels;
    }

    public Sliding(System.String savedString): base(savedString)
    {
        throw new System.NotImplementedException();
    }
    public override string AdministrationWorkSheet()
    {
        throw new System.NotImplementedException();
    }

    public override string ProductionWorkSheet()
    {
        throw new System.NotImplementedException();
    }

    public override string ToSavedString()
    {
        return $"{this.GetType()}:{_nameCustomer},{_addressCustomer},{_phoneCustomer.ToString()},{_totalPrice.ToString()},{_amountPaid.ToString()},{_widthMm.ToString()},{_heightMm.ToString()},{_color},{_glassThickness.ToString()},{_dvh.ToString()},{_dueDate},{_closerType},{_threeShashes.ToString()},{_bearingWheels.ToString()}";
    }

    public override string ToString()
    {
        throw new System.NotImplementedException();
    }
}