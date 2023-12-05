public class ProbbaSwingingWindowOrder : SwingingOrder
{
     

    public ProbbaSwingingWindowOrder(System.String nameCustomer, System.String addressCustomer, long phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, string dueDate, bool instalationIncluded, System.String openingDirection, System.String outOrIn, System.String design, bool doubleShash,  bool perimeterFrame, bool buriedFrame) : base(nameCustomer,  addressCustomer, phoneCustomer,  totalPrice,  amountPaid, widthMm,  heightMm,  color,  glassThickness,  dvh, dueDate, instalationIncluded,  openingDirection,  outOrIn,  design,  doubleShash,   perimeterFrame, buriedFrame)
    {
        throw new System.NotImplementedException();
    }

    public ProbbaSwingingWindowOrder(System.String savedString) : base(savedString)
    {
        throw new System.NotImplementedException();
    }
    

     public override int GetVerticalShashFrame()
    {
        if (_perimeterFrame == true)
        {
            return _heightMm - 48;
        }
        else
        {
            return _heightMm - 34;
        }
    }
    public override int GetHorizontalShashFrame()
    {
        if (_doubleShash == true)
        {
            return _widthMm / 2 - 26;
        }
        else
        {
            return _widthMm - 48;

        }
    }
    public override int GetHorizontalGlazingBead()
    {
        if (_doubleShash == true)
        {
            return _widthMm / 2 - 107;

        }
        else
        {
            return _widthMm - 100;
        }
    }
    public override int GetVerticalGlazingBead()
    {
        if (_perimeterFrame == true)
        {
            return _heightMm - 162;
        }
        else
        {
            return _heightMm - 148;
        }
    }
    public override int GetGlassWidth()
    {
        if (_doubleShash == true)
        {
            return _widthMm / 2 - 120;
        }
        else
        {
            return _widthMm - 142;
        }
    }
    public override int GetGlassHeight()
    {
        if (_perimeterFrame == true)
        {
            return _heightMm - 106;
        }
        else
        {
            return _heightMm - 95;
        }
    }
    public override int GetOpaquePanel()
    {
        if (_doubleShash == true)
        {
            return _widthMm / 2 - 110;
        }
        else
        {
            return _widthMm - 118;
        }
    }
    public override string ProductionWorkSheet()
    {
        return $"Opening Type: {this.GetType()} \n Total width: {_widthMm}mm. \n Total height: {_heightMm}mm. \n Horizontal Frame lenght: {_widthMm}mm \n Vertical Frame lenght: {GetBuriedFrameLenght()}mm \n Vertical Sash Frame lenght: {GetVerticalShashFrame} \n Horizontal Shash Frame lenght: {GetHorizontalShashFrame()}mm \n Horizontal Glazing Bead lenght: {GetHorizontalGlazingBead()}mm \n Vertical Glazing Bead: {GetVerticalGlazingBead()}mm \n Glass Width: {GetGlassWidth()}mm \n Glass Height: {GetGlassHeight()}mm \n Opaque panel lenght: {GetOpaquePanel()}mm \n {GetDvhMessage()} \n {GetDoubleShashMessage()} \n {GetBuriedFrameMessage} \n The design for this opening: {_design}";
    }
   
    
}