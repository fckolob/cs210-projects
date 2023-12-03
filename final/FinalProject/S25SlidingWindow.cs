 public class S25SlidingWindow : Sliding
 {

     

    

    
    public S25SlidingWindow(System.String savedString): base(savedString)
    {
        
    }

    public S25SlidingWindow(System.String nameCustomer, System.String addressCustomer, long phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh,string dueDate, bool instalationIncluded, System.String closerType, bool threeShashes, bool bearingWheels): base(nameCustomer, addressCustomer, phoneCustomer, totalPrice, amountPaid, widthMm, heightMm, color, glassThickness, dvh, dueDate, instalationIncluded, closerType, threeShashes, bearingWheels)
    {
        
    }
    public override int GetHorizontalFrame()
    {
        return _widthMm - 51;
    }
    public override int GetVerticalShashFrame()
    {
        return _heightMm - 48;
    }
    public override int GetHorizontalShashFrame()
    {
        if (_threeShashes == true)
        {
            return _widthMm / 3 - 77;

        }
        else
        {
            return _widthMm / 2 - 96;
        }
        
    }
    public override int GetGlassWidth()
    {
        if (_dvh == true && _threeShashes == false)
        {
            return _widthMm / 2 - 111;
        }
        if (_dvh == false && _threeShashes == false)
        {
            return _widthMm / 2 - 80;
        }
        if (_dvh == true && _threeShashes == true)
        {
            return _widthMm / 3 - 91;
        }
        if (_dvh == false && _threeShashes == true)
        {
            return _widthMm / 3 - 60;
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
            return _heightMm - 168;
        }
        else
        {
            return _heightMm - 137;
        }
    }
    public override int GetScreenWidth()
    {
        return _widthMm / 2 + 10;
    }
    public override int GetScreenHeight()
    {
        return _heightMm - 40;
    }
    public override int GetScreenGuides()
    {
        return _widthMm - 5;
    }
    public override string ProductionWorkSheet()
    {
        return $"Opening Type: {this.GetType()} \n Total width: {_widthMm}mm. \n Total height: {_heightMm}mm. \n Horizontal Frame lenght: {GetHorizontalFrame()}mm \n Vertical Frame lenght: {_heightMm}mm \n Vertical Sash Frame lenght: {GetVerticalShashFrame} \n Horizontal Shash Frame lenght: {GetHorizontalShashFrame()}mm \n Screen Width: {GetScreenWidth()}mm \n Screen Height: {GetScreenHeight()}mm \n Screen Guides: {GetScreenGuides()}mm \n Glass Width: {GetGlassWidth()}mm \n Glass Height: {GetGlassHeight()}mm \n {GetThreeShashesMessage()} \n {GetBearingWheelsMessage()} \n The Closer Type for this opening is: {_closerType} ";
    }
   
 }