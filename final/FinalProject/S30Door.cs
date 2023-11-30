public class S30Door : Swinging
{

    

    public S30Door(System.String nameCustomer, System.String addressCustomer, int phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, string dueDate, bool instalationIncluded, System.String openingDirection, System.String outOrIn, System.String design, bool doubleShash,  bool perimeterFrame, bool buriedFrame): base( nameCustomer,  addressCustomer, phoneCustomer,  totalPrice,  amountPaid, widthMm,  heightMm,  color,  glassThickness,  dvh, dueDate, instalationIncluded, openingDirection,  outOrIn,  design,  doubleShash,   perimeterFrame, buriedFrame)
    {
        
    }

    public S30Door(System.String savedString): base(savedString)
    {
        
    }
    

    public override string ProductionWorkSheet()
    {
        throw new System.NotImplementedException();
    }

    
}