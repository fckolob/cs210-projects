public class S30SwingingWindow: Swinging
{
    

    public S30SwingingWindow(System.String nameCustomer, System.String addressCustomer, int phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, string dueDate, System.String openingDirection, System.String outOrIn, System.String design, bool doubleShash,  bool perimeterFrame, bool buriedFrame): base( nameCustomer,  addressCustomer, phoneCustomer,  totalPrice,  amountPaid, widthMm,  heightMm,  color,  glassThickness,  dvh,  dueDate, openingDirection,  outOrIn,  design,  doubleShash,   perimeterFrame, buriedFrame)
    {
        
    }

    public S30SwingingWindow(System.String savedString): base(savedString)
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
        throw new System.NotImplementedException();
    }

    public override string ToString()
    {
        throw new System.NotImplementedException();
    }
}