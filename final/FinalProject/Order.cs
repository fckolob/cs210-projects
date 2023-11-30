    public abstract class Order
    {
        protected string _nameCustomer
        {
            get => default(string);
            set
            {
            }
        }

        protected int _phoneCustomer
        {
            get => default(int);
            set
            {
            }
        }

        protected double _totalPrice
        {
            get => default(double);
            set
            {
            }
        }

        protected double _amountPaid
        {
            get => default(double);
            set
            {
            }
        }

        protected string _dueDate
        {
            get => default(string);
            set
            {
            }
        }

        protected string _color
        {
            get => default(string);
            set
            {
            }
        }

        protected string _addressCustomer
        {
            get => default(string);
            set
            {
            }
        }

        protected int _widthMm
        {
            get => default(int);
            set
            {
            }
        }

        protected double _heightMm
        {
            get => default(double);
            set
            {
            }
        }

        protected int _glassThickness
        {
            get => default(int);
            set
            {
            }
        }

        protected bool _dvh
        {
            get => default(bool);
            set
            {
            }
        }
        protected bool _instalationIncluded
        {
            get => default(bool);
            set
            {
            }
        }
        protected bool _delivered
        {
            get => default(bool);
            set
            {
            }
        }
        protected bool _remainingAmountPaid
        {
            get => default(bool);
            set
            {
            }
        }
        public Order(System.String nameCustomer, System.String addressCustomer, int phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, string dueDate, bool instalationIncluded)
        {
            _nameCustomer = nameCustomer;
            _addressCustomer = addressCustomer;
            _phoneCustomer = phoneCustomer;
            _totalPrice = totalPrice;
            _amountPaid = amountPaid;
            _widthMm = widthMm;
            _heightMm = heightMm;
            _color = color;
            _glassThickness = glassThickness;
            _dvh = dvh;
            _dueDate = dueDate;
            _instalationIncluded = instalationIncluded;
            
        }

        public Order(System.String savedString)
        {
            
        }

        public double RemainingAmount()
        {
            return _totalPrice - _amountPaid;
        }

       

        

        public abstract string ToSavedString();
        

        public abstract string ProductionWorkSheet();
        

        public string AdministrationWorkSheet()
        {
            return $"Type of opening: {this.GetType()} \n Name: {_nameCustomer} \n Address: {_addressCustomer} \n Phone number: {_phoneCustomer} \n Total price: ${_totalPrice} \n Amount already paid: ${_amountPaid} \n Remaining amount: ${RemainingAmount()} \n Due date for deliver this opening: {_dueDate} \n {GetInstalationIncludedMessage()}";
        }
        public string GetDvhMessage()
        {
            if (_dvh == true)
            {
                return "This opening will have DVH glass";
            }
            else
            {
                return "This opening will have single glass";
            }
        }
        public string GetInstalationIncludedMessage()
        {
            if (_instalationIncluded == true)
            {
                return "The instalation is included for this opening";
            }
            else
            {
                return "The instalation is not included for this opening";
            }
        }
        public string GetDeliveredMessage()
        {
            if (_delivered == true)
            {
                return "This opening was already delivered";
            }
            else
            {
                return "This opening is not delivered yet";
            }
        }
        public string GetRemainingAmountPaidMessage()
        {
            if (_remainingAmountPaid == true)
            {
                return "The remaining amount for this opening was already paid";
            }
            else
            {
                return "The remaining amount for this opening is not paid yet";
            }
        }
    }
