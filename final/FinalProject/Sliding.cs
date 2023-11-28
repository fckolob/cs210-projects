public class Sliding : Order
{
    private string _closerType
    {
        get => default(string);
        set
        {
        }
    }

    private bool _threeShashes
    {
        get => default(bool);
        set
        {
        }
    }

    private bool _bearingWheels
    {
        get => default(bool);
        set
        {
        }
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
        throw new System.NotImplementedException();
    }

    public override string ToString()
    {
        throw new System.NotImplementedException();
    }

    public Sliding(System.String nameCustomer, System.String addressCustomer, int phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, System.String closerType, bool threeShashes) :base(nameCustomer, addressCustomer, phoneCustomer, totalPrice, amountPaid, widthMm, heightMm,  color, glassThickness, dvh)
    {
        throw new System.NotImplementedException();
    }

    public Sliding(System.String savedString): base(savedString)
    {
        throw new System.NotImplementedException();
    }
}