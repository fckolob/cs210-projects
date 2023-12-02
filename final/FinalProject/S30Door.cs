public class S30Door : Swinging
{

    

    public S30Door(System.String nameCustomer, System.String addressCustomer, int phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, string dueDate, bool instalationIncluded, System.String openingDirection, System.String outOrIn, System.String design, bool doubleShash,  bool perimeterFrame, bool buriedFrame): base( nameCustomer,  addressCustomer, phoneCustomer,  totalPrice,  amountPaid, widthMm,  heightMm,  color,  glassThickness,  dvh, dueDate, instalationIncluded, openingDirection,  outOrIn,  design,  doubleShash,   perimeterFrame, buriedFrame)
    {
        
    }

    public S30Door(System.String savedString): base(savedString)
    {
        
    }
    public override int GetVerticalShashFrame()
    {
        if (_perimeterFrame == true)
        {
            return _heightMm - 66;
        }
        else
        {
            return _heightMm - 38;
        }
    }
    public override int GetHorizontalShashFrame()
    {
        if (_doubleShash == true)
        {
            return _widthMm / 2 - 145;
        }
        else
        {
            return _widthMm - 176;

        }
    }
    public override int GetHorizontalGlazingBead()
    {
        if (_doubleShash == true)
        {
            return _widthMm / 2 - 146;

        }
        else
        {
            return _widthMm - 177;
        }
    }
    public override int GetVerticalGlazingBead()
    {
        if (_perimeterFrame == true)
        {
            return _heightMm - 266;
        }
        else
        {
            return _heightMm - 238;
        }
    }
    public override int GetGlassWidth()
    {
        if (_doubleShash == true)
        {
            return _widthMm / 2 - 150;
        }
        else
        {
            return _widthMm - 181;
        }
    }
    public override int GetGlassHeight()
    {
        if (_perimeterFrame == true)
        {
            return _heightMm - 241;
        }
        else
        {
            return _heightMm - 213;
        }
    }
    public override int GetOpaquePanel()
    {
        if (_doubleShash == true)
        {
            return _widthMm / 2 - 148;
        }
        else
        {
            return _widthMm - 179;
        }
    }

    

    
}