 public class S25SlidingWindow : Sliding
 {

     

    

    
    public S25SlidingWindow(System.String savedString): base(savedString)
    {
        
    }

    public S25SlidingWindow(System.String nameCustomer, System.String addressCustomer, int phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh,string dueDate, bool instalationIncluded, System.String closerType, bool threeShashes, bool bearingWheels): base(nameCustomer, addressCustomer, phoneCustomer, totalPrice, amountPaid, widthMm, heightMm, color, glassThickness, dvh, dueDate, instalationIncluded, closerType, threeShashes, bearingWheels)
    {
        
    }
    public override string ProductionWorkSheet()
    {
        throw new System.NotImplementedException();
    }
 }