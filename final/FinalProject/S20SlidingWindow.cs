public class S20SlidingWindow : Sliding
{
    

    public S20SlidingWindow(System.String savedString): base(savedString)
    {
        throw new System.NotImplementedException();
    }

    public S20SlidingWindow(System.String nameCustomer, System.String addressCustomer, int phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, string dueDate, bool instalationIncluded, System.String closerType, bool threeShashes, bool bearingWheels): base(nameCustomer, addressCustomer, phoneCustomer, totalPrice, amountPaid, widthMm, heightMm, color, glassThickness, dvh, dueDate, instalationIncluded, closerType, threeShashes, bearingWheels)
    {
        
    }
    

    public override int GetHorizontalFrame()
    {
        return _widthMm - 25;
    }
    public override int GetVerticalShashFrame()
    {
        return _heightMm - 48;
    }
    public override int GetHorizontalShashFrame()
    {
        return _widthMm / 2 - 74;
    }
    public override int GetGlassWidth()
    {
        return _widthMm / 2 - 58;
    }
    public override int GetGlassHeight()
    {
        return _heightMm - 112;
    }
    public override int GetScreenWidth()
    {
        return _widthMm / 2 + 10;
    }
    public override int GetScreenHeight()
    {
        return _heightMm - 30;
    }
    public override int GetScreenGuides()
    {
        return _widthMm - 27;
    }
    

}