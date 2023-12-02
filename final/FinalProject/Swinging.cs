using System.Dynamic;

public  class Swinging : Order
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
    
    
    

    public Swinging(System.String nameCustomer, System.String addressCustomer, int phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, string dueDate, bool instalationIncluded, System.String openingDirection, System.String outOrIn,   System.String design, bool doubleShash,  bool perimeterFrame, bool buriedFrame) : base(nameCustomer, addressCustomer, phoneCustomer, totalPrice, amountPaid, widthMm, heightMm,  color, glassThickness, dvh, dueDate, instalationIncluded)
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
        string [] parts = savedString.Split(",");
        _nameCustomer = parts[0];
        _addressCustomer = parts[1];
        _phoneCustomer = int.Parse(parts[2]);
        _totalPrice = double.Parse(parts[3]);
        _amountPaid = double.Parse(parts[4]);
        _widthMm = int.Parse(parts[5]);
        _heightMm = int.Parse(parts[6]);
        _color = parts[7];
        _glassThickness = int.Parse(parts[8]);
        _dvh = bool.Parse(parts[9]);
        _dueDate = parts[10];
        _instalationIncluded = bool.Parse(parts[11]);
        _openingDirection = parts[12];
        _outOrIn = parts[13];
        _design = parts[14];
        _doubleShash = bool.Parse(parts[15]);
        _perimeterFrame = bool.Parse(parts[16]);
        _buriedFrame = bool.Parse(parts[17]);
        _delivered = bool.Parse(parts[18]);
        _remainingAmountPaid = bool.Parse(parts[19]);
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
        
        
        return $"Type of opening: {this.GetType()} \n Name of the customer: {_nameCustomer} \n Address of the costumer: {_addressCustomer} \n Phone of the costumer: {_phoneCustomer} \n Total price: ${_totalPrice} \n Amount already paid: ${_amountPaid} \n The due date for deliver the opening is {_dueDate} \n {GetInstalationIncludedMessage()} \n Width of the opening in mm: {_widthMm}mm \n Height of the opening in mm: {_heightMm}mm \n Color of the opening: {_color} \n Glass Thickness: {_glassThickness}mm \n {GetDvhMessage()} \n The opening direction of the opening is {_openingDirection} seeing from the outside of the house \n The opening is open {_outOrIn} \n The design of the opening is: {_design} \n {GetDoubleShashMessage()} \n {GetPerimeterFrameMessage()} \n {GetBuriedFrameMessage()} \n {GetDeliveredMessage()} \n {GetRemainingAmountPaidMessage()}. ";
        
        
    }

    public override string ToSavedString()
    {
        return $"{this.GetType()}:{_nameCustomer},{_addressCustomer},{_phoneCustomer.ToString()},{_totalPrice.ToString()},{_amountPaid.ToString()},{_widthMm.ToString()},{_heightMm.ToString()},{_color},{_glassThickness.ToString()},{_dvh.ToString()},{_dueDate},{_instalationIncluded.ToString()},{_openingDirection},{_outOrIn},{_design},{_doubleShash.ToString()},{_perimeterFrame.ToString()},{_buriedFrame.ToString()},{_delivered.ToString()},{_remainingAmountPaid.ToString()}";
    }
    public int GetBuriedFrameLenght()
    {
        if (_buriedFrame == true)
        {
            return _heightMm + 20;
        }
        else
        {
            return _heightMm;
        }
    }
    public virtual int GetVerticalShashFrame()
    {
        return 0;
    }
    public virtual int GetHorizontalShashFrame()
    {
        return 0;
    }
    public virtual int GetHorizontalGlazingBead()
    {
        return 0;
    }
    public virtual int GetVerticalGlazingBead()
    {
        return 0;
    }
    public virtual int GetOpaquePanel()
    {
        return 0;
    }
    public virtual int GetGlassWidth()
    {
        return 0;
    }
    public virtual int GetGlassHeight()
    {
        return 0;
    }
    


    public override string ProductionWorkSheet()
    {
        return $"Opening Type: {this.GetType()} \n Total width: {_widthMm}mm. \n Total height: {_heightMm}mm. \n Horizontal Frame lenght: {_widthMm}mm \n Vertical Frame lenght: {GetBuriedFrameLenght()}mm \n Vertical Sash Frame lenght: {GetVerticalShashFrame} \n Horizontal Shash Frame lenght: {GetHorizontalShashFrame()}mm \n Horizontal Glazing Bead lenght: {GetHorizontalGlazingBead()}mm \n Vertical Glazing Bead: {GetVerticalGlazingBead()}mm \n Glass Width: {GetGlassWidth()}mm \n Glass Height: {GetGlassHeight()}mm \n Opaque panel lenght: {GetOpaquePanel()}mm \n {GetDvhMessage()} \n {GetDoubleShashMessage()} \n {GetBuriedFrameMessage} \n The design for this opening: {_design}";
    }
    


}