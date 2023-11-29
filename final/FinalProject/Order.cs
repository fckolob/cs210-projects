    public class Order
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
        public Order(System.String nameCustomer, System.String addressCustomer, int phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh, string dueDate)
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
        }

        public Order(System.String savedString)
        {
            throw new System.NotImplementedException();
        }

        public double ReaminingAmount()
        {
            return _totalPrice - _amountPaid;
        }

       

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

        public virtual string ToSavedString()
        {
            throw new System.NotImplementedException();
        }

        public virtual string ProductionWorkSheet()
        {
            throw new System.NotImplementedException();
        }

        public virtual string AdministrationWorkSheet()
        {
            throw new System.NotImplementedException();
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
    }
