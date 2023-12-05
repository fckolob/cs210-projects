public class S20SlidingWindowOrder : SlidingOrder
{
    

    public S20SlidingWindowOrder(System.String savedString): base(savedString)
    {
        throw new System.NotImplementedException();
    }

    public S20SlidingWindowOrder(System.String nameCustomer, System.String addressCustomer, long phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, string dueDate, bool instalationIncluded, System.String closerType, bool threeShashes, bool bearingWheels): base(nameCustomer, addressCustomer, phoneCustomer, totalPrice, amountPaid, widthMm, heightMm, color, glassThickness, dvh, dueDate, instalationIncluded, closerType, threeShashes, bearingWheels)
    {
        
    }
    public override string GetBearingWheelsMessage()
    {
        return $"The {this.GetType()} kind opening can not have bearing wheels";
    }
    public override string GetThreeShashesMessage()
    {
        return "This opening will have two shashes";
    }
    public override string GetDvhMessage()
    {
        return "This opening will have single glass";
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
    public override string ProductionWorkSheet()
    {
        return $"Opening Type: {this.GetType()} \n Total width: {_widthMm}mm. \n Total height: {_heightMm}mm. \n Horizontal Frame lenght: {GetHorizontalFrame()}mm \n Vertical Frame lenght: {_heightMm}mm \n Vertical Sash Frame lenght: {GetVerticalShashFrame} \n Horizontal Shash Frame lenght: {GetHorizontalShashFrame()}mm \n Screen Width: {GetScreenWidth()}mm \n Screen Height: {GetScreenHeight()}mm \n Screen Guides: {GetScreenGuides()}mm \n Glass Width: {GetGlassWidth()}mm \n Glass Height: {GetGlassHeight()}mm \n {GetThreeShashesMessage()} \n {GetBearingWheelsMessage()} \n The Closer Type for this opening is: {_closerType} ";
    }
    public override string ToString()
    {
        return $"Type of opening: {this.GetType()} \n Name of the customer: {_nameCustomer} \n Address of the costumer: {_addressCustomer} \n Phone of the costumer: {_phoneCustomer} \n Total price: ${_totalPrice} \n Amount already paid: ${_amountPaid} \n The due date for deliver the opening is {_dueDate} \n {GetInstalationIncludedMessage()} \n Width of the opening in mm: {_widthMm}mm \n Height of the opening in mm: {_heightMm}mm \n Color of the opening: {_color} \n Glass Thickness: {_glassThickness}mm \n {GetDvhMessage()} \n The type of closer for this opening is {_closerType} \n {GetThreeShashesMessage()} \n {GetBearingWheelsMessage()} \n {GetDeliveredMessage()} \n {GetRemainingAmountPaidMessage()}.";
    }

}