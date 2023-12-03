public class ProbbaSlidingWindow : Sliding
{
    

   
    

    public ProbbaSlidingWindow(System.String nameCustomer, System.String addressCustomer, long phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, string dueDate, bool instalationIncluded, System.String closerType, bool threeShashes, bool bearingWheels): base(nameCustomer, addressCustomer, phoneCustomer, totalPrice, amountPaid, widthMm, heightMm, color, glassThickness, dvh, dueDate, instalationIncluded, closerType, threeShashes, bearingWheels)
    {
        throw new System.NotImplementedException();
    }

    public ProbbaSlidingWindow(System.String savedString): base(savedString)
    {
        throw new System.NotImplementedException();
    }
    public override int GetHorizontalFrame()
    {
        return _widthMm - 36;
    }
    public override int GetVerticalShashFrame()
    {
        return _heightMm - 65;
    }
    public override int GetHorizontalShashFrame()
    {
        if (_threeShashes == true)
        {
            return _widthMm / 3 - 70;

        }
        else
        {
            return _widthMm / 2 - 23;
        }

        
    }
    public int GetCentralHorizontalShashFrame()
    {
        return _widthMm / 3 + 12;
    }
    public int GetCentralGlassWidth()
    {
        if(_dvh == true)
        {
            return _widthMm / 3 - 61;
        }
        else
        {
            return _widthMm / 3 - 68;
        }
    }
    public override int GetGlassWidth()
    {
        if (_dvh == true && _threeShashes == false)
        {
            return _widthMm / 2 - 86;
        }
        if (_dvh == false && _threeShashes == false)
        {
            return _widthMm / 2 - 94;
        }
        if (_dvh == true && _threeShashes == true)
        {
            return _widthMm / 3 - 70;
        }
        if (_dvh == false && _threeShashes == true)
        {
            return _widthMm / 3 - 77;
        }
        else
        {
            return 0;
        }
    }
    public override int GetGlassHeight()
    {
        if (_dvh == true)
        {
            return _heightMm - 165;
        }
        else
        {
            return _heightMm - 172;
        }
    }
    public override int GetScreenWidth()
    {
        return _widthMm / 2 + 11;
    }
    public override int GetScreenHeight()
    {
        return _heightMm - 62;
    }
    public override int GetScreenGuides()
    {
        return _widthMm - 5;
    }
    public override string ProductionWorkSheet()
    {
        return $"Opening Type: {this.GetType()} \n Total width: {_widthMm}mm. \n Total height: {_heightMm}mm. \n Horizontal Frame lenght: {GetHorizontalFrame()}mm \n Vertical Frame lenght: {_heightMm}mm \n Vertical Sash Frame lenght: {GetVerticalShashFrame} \n Horizontal Shash Frame lenght: {GetHorizontalShashFrame()}mm \n Horizontal Central Shash Frame lenght: {GetCentralHorizontalShashFrame()}mm \n Screen Width: {GetScreenWidth()}mm \n Screen Height: {GetScreenHeight()}mm \n Screen Guides: {GetScreenGuides()}mm \n Glass Width: {GetGlassWidth()}mm \n Central Shash Glass Width: {GetCentralGlassWidth()}mm \n Glass Height: {GetGlassHeight()}mm \n {GetThreeShashesMessage()} \n {GetBearingWheelsMessage()} \n The Closer Type for this opening is: {_closerType} ";
    }
    

}