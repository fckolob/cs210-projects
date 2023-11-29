using System.Dynamic;

public class Swinging : Order
{
    protected string _openingDirection
        {
            get => default(string);
            set
            {
            }
        }
    protected string _outOrIn
        {
            get => default(string);
            set
            {
            }
        }
    protected string _design
        {
            get => default(string);
            set
            {
            }
        }
    protected bool _doubleShash
        {
            get => default(bool);
            set
            {
            }
        }
    protected bool _perimeterFrame
        {
            get => default(bool);
            set
            {
            }
        }
    protected bool _buriedFrame
        {
            get => default(bool);
            set
            {
            }
        }
    
    
    

    public Swinging(System.String nameCustomer, System.String addressCustomer, int phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, string dueDate, System.String openingDirection, System.String outOrIn,   System.String design, bool doubleShash,  bool perimeterFrame, bool buriedFrame) : base(nameCustomer, addressCustomer, phoneCustomer, totalPrice, amountPaid, widthMm, heightMm,  color, glassThickness, dvh, dueDate)
    {
        _openingDirection = openingDirection;
        _doubleShash = doubleShash;
        _design = design;
        _outOrIn = outOrIn;
        _perimeterFrame = perimeterFrame;
        _buriedFrame = buriedFrame;
    }

    public Swinging(System.String savedString) : base(savedString)
    {
        throw new System.NotImplementedException();
    }
    public string GetDoubleShashMessage()
    {
        if (_doubleShash == true)
        {
            return $"This opening has two shashes";
        }
        else
        {
            return $"This opening has one shash";
        }
    }
    public string GetPerimeterFrameMessage()
    {
        if (_perimeterFrame == true)
        {
            return $"This opening will have a Perimeter Frame type";
        }
        else
        {
            return $"This opening will not have a Perimeter frame type";
        }
    }
    public string GetBuriedFrameMessage()
    {
        if (_buriedFrame == true)
        {
            return $"The frame of this opening will be buried";
        }
        else
        {
            return $"The frame of this opening will be not buried";
        }
    }
    
    public override string ToString()
    {
        
        
        return $"Type of opening: {this.GetType()} \n Name of the customer: {_nameCustomer} \n Address of the costumer: {_addressCustomer} \n Phone of the costumer: {_phoneCustomer} \n Total price: ${_totalPrice} \n Amount already paid: ${_amountPaid} \n The due date for deliver the opening is {_dueDate} \n Width of the opening in mm: {_widthMm}mm \n Height of the opening in mm: {_heightMm}mm \n Color of the opening: {_color} \n Glass Thickness: {_glassThickness}mm \n {GetDvhMessage()} \n The opening direction of the opening is {_openingDirection} seeing from the outside of the house \n The opening is open {_outOrIn} \n The design of the opening is: {_design} \n {GetDoubleShashMessage()} \n {GetPerimeterFrameMessage()} \n {GetBuriedFrameMessage()}. ";
        
        
    }

    public override string ToSavedString()
    {
        return $"{this.GetType()}:{_nameCustomer},{_addressCustomer},{_phoneCustomer.ToString()},{_totalPrice.ToString()},{_amountPaid.ToString()},{_widthMm.ToString()},{_heightMm.ToString()},{_color},{_glassThickness.ToString()},{_dvh.ToString()},{_dueDate},{_openingDirection},{_outOrIn},{_design},{_doubleShash.ToString()},{_perimeterFrame.ToString()},{_buriedFrame.ToString()}";
    }

    public override string ProductionWorkSheet()
    {
        throw new System.NotImplementedException();
    }
    public override string AdministrationWorkSheet()
    {
        throw new System.NotImplementedException();
    }


}