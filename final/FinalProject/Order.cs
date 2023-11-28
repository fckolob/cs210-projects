    public class Order
    {
        public Order(System.String nameCustomer, System.String addressCustomer, int phoneCustomer, double totalPrice, double amountPaid, int widthMm, int heightMm, System.String color, int glassThickness, bool dvh)
        {
            throw new System.NotImplementedException();
        }

        public Order(System.String savedString)
        {
            throw new System.NotImplementedException();
        }

        private string _nameCustomer
        {
            get => default(string);
            set
            {
            }
        }

        private int _phoneNumberCustomer
        {
            get => default(int);
            set
            {
            }
        }

        private double _totalPrice
        {
            get => default(double);
            set
            {
            }
        }

        private double _amountPaid
        {
            get => default(double);
            set
            {
            }
        }

        private string _dueDate
        {
            get => default(string);
            set
            {
            }
        }

        private string _color
        {
            get => default(string);
            set
            {
            }
        }

        private string _addressCustomer
        {
            get => default(string);
            set
            {
            }
        }

        private int _width
        {
            get => default(int);
            set
            {
            }
        }

        private double _height
        {
            get => default(double);
            set
            {
            }
        }

        private int _glassThicknessMm
        {
            get => default(int);
            set
            {
            }
        }

        private bool _dvh
        {
            get => default(bool);
            set
            {
            }
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
    }
