using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders  = new List<Order>();
        void ShowWorkSheetKinds()
        {
            int userInputWorkSheetInt = 1;
            while (userInputWorkSheetInt != -12345)
            {
                Console.Clear();
                Console.WriteLine("What kind of worksheet do you want to create?");
                Console.WriteLine("1. Administration worksheet");
                Console.WriteLine("2. Production worksheet");
                Console.WriteLine("Select a choice from the menu");
                string userInputWorkSheetString = Console.ReadLine();
                int.TryParse(userInputWorkSheetString, out userInputWorkSheetInt);
                if (userInputWorkSheetInt == 1)
                {
                    int indexToShow = 0;
                    Console.WriteLine("The orders are:");
                    Console.WriteLine();
                
                    foreach (Order order in orders)
                    {
                        indexToShow += 1;
                        Console.WriteLine($"{indexToShow}.{order.GetName()}");
                    }
                    Console.WriteLine("For wich order do you want to create the worksheet?");
                    int selected = int.Parse(Console.ReadLine());
                    indexToShow = 0;
                    foreach (Order order in orders)
                    {
                        indexToShow += 1;
                        if (indexToShow == selected)
                        {
                        
                            Console.WriteLine(order.AdministrationWorkSheet());
                        }
                    
                    }
                    Console.WriteLine("Press Enter for return to the menu.");
                    Console.ReadLine();
                    userInputWorkSheetInt = -12345;

                }
                else if (userInputWorkSheetInt == 2)
                {
                    int indexToShow = 0;
                    Console.WriteLine("The orders are:");
                    Console.WriteLine();
                
                    foreach (Order order in orders)
                    {
                        indexToShow += 1;
                        Console.WriteLine($"{indexToShow}.{order.GetName()}");
                    }
                    Console.WriteLine("For wich order do you want to create the worksheet?");
                    int selected = int.Parse(Console.ReadLine());
                    indexToShow = 0;
                    foreach (Order order in orders)
                    {
                        indexToShow += 1;
                        if (indexToShow == selected)
                        {
                        
                            Console.WriteLine(order.ProductionWorkSheet());
                        }
                    
                    }
                    Console.WriteLine("Press Enter for return to the menu.");
                    Console.ReadLine();
                    userInputWorkSheetInt = -12345;
                }

                else if (userInputWorkSheetInt != 1 && userInputWorkSheetInt != 2  && userInputWorkSheetInt != -12345)
                {
                    Console.Clear();
                    Console.WriteLine("This is not a valid option, please try again");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                

            }
        }
        void ShowEventKinds()
        {
            int userInputRecordInt = 1;
            while (userInputRecordInt != -12345)
            {
                Console.Clear();
                Console.WriteLine("What kind of event do you want to record?");
                Console.WriteLine("1. Opening Delivered");
                Console.WriteLine("2. Remaining amount paid");
                Console.WriteLine("Select a choice from the menu");
            
                string userInputRecordString = Console.ReadLine();
                int.TryParse(userInputRecordString, out userInputRecordInt);
                if (userInputRecordInt == 1)
                {
                    int indexToShow = 0;
                    Console.WriteLine("The orders are:");
                    Console.WriteLine();
                
                    foreach (Order order in orders)
                    {
                        indexToShow += 1;
                        Console.WriteLine($"{indexToShow}.{order.GetName()}");
                    }
                    Console.WriteLine("For wich order do you want to record this event?");
                    int selected = int.Parse(Console.ReadLine());
                    indexToShow = 0;
                    foreach (Order order in orders)
                    {
                        indexToShow += 1;
                        if (indexToShow == selected)
                        {
                        
                            order.RecordEventDelivered();
                        }
                    
                    }
                    Console.Clear();
                    Console.WriteLine("Your event was recorded");
                    Thread.Sleep(2000);
                    userInputRecordInt = -12345;

                }
                else if (userInputRecordInt == 2)
                {
                    int indexToShow = 0;
                    Console.WriteLine("The orders are:");
                    Console.WriteLine();
                
                    foreach (Order order in orders)
                    {
                        indexToShow += 1;
                        Console.WriteLine($"{indexToShow}.{order.GetName()}");
                    }
                    Console.WriteLine("For wich order do you want to record this event?");
                    int selected = int.Parse(Console.ReadLine());
                    indexToShow = 0;
                    foreach (Order order in orders)
                    {
                        indexToShow += 1;
                        if (indexToShow == selected)
                        {
                        
                            order.RecordEventRemainingAmountPaid();
                        }
                    
                    }
                    Console.Clear();
                    Console.WriteLine("Your event was recorded");
                    Thread.Sleep(2000);
                    userInputRecordInt = -12345;
                }
                else if (userInputRecordInt != 1 && userInputRecordInt != 2  && userInputRecordInt != -12345)
                {
                    Console.Clear();
                    Console.WriteLine("This is not a valid option, please try again");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

            }
        }
        void ShowSwingingOpeningKinds()
        {
            int userInputSwingingOpeningInt = 1;
            while (userInputSwingingOpeningInt != -12345)
            {

                Console.Clear();
                Console.WriteLine("What kind of swinging opening do you want to order?");
                Console.WriteLine("1. S-30 swinging Door");
                Console.WriteLine("2. S-30 swinging window");
                Console.WriteLine("3. Probba swinging Door");
                Console.WriteLine("4. Probba swinging window");
                Console.WriteLine("Select a choice from the menu");
            
                string userInputSwingingOpeningString = Console.ReadLine();
                int.TryParse(userInputSwingingOpeningString, out userInputSwingingOpeningInt);
                if (userInputSwingingOpeningInt == 1)
                {
                    Console.Clear();
                    Console.WriteLine("What is the customer's name?");
                    string nameCustomer = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the customer's address");
                    string addressCustomer = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the customer's phone number?");
                    long phoneCustomer = long.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the total price of the opening in dollars?");
                    double totalPrice = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is paid amount for this opening in dollars?");
                    double amountPaid = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Is the instalation included for this opening? (yes/no)");
                    bool instalationIncluded;
                    string instalationIncludedOption = Console.ReadLine().ToLower();

                    if (instalationIncludedOption == "yes")
                    {
                        instalationIncluded = true;
                    }
                    else
                    {
                        instalationIncluded = false;
                    }
                    Console.Clear();
                    Console.WriteLine("What is the due date for deliver this opening?");
                    string dueDate = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is color of this opening?");
                    string color = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the width of this opening in mm?");
                    int widthMm = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the heigth of this opening in mm?");
                    int heightMm = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the design for this opening?");
                    string design = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the glass thickness for this opening in mm?");
                    int glassThickness = int.Parse(Console.ReadLine());
                    Console.Clear();
                    
                    Console.Clear();
                    Console.WriteLine("Will this opening have DVH glass? (yes/no)");
                    bool dvh;
                    string dvhOption = Console.ReadLine().ToLower();
                    if(dvhOption == "yes")
                    {
                        dvh = true;
                    }
                    else
                    {
                        dvh = false;
                    }
                    Console.Clear();
                    Console.WriteLine("What is the opening direction for this opening seeing from the outside?");
                    string openingDirection = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Will this opening open in or open out? (in/out)");
                    string outOrIn = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Will this opening be a double shash opening? (yes/no)");
                    bool doubleShash;
                    string doubleShashOption = Console.ReadLine().ToLower();
                    if (doubleShashOption == "yes")
                    {
                        doubleShash = true;

                    }
                    else
                    {
                        doubleShash = false;
                    }
                    Console.Clear();
                    Console.WriteLine("Will this opening have a frame for all the perimeter? (yes/no)");
                    bool perimeterFrame;
                    string perimeterFrameOption = Console.ReadLine().ToLower();
                    if (perimeterFrameOption == "yes")
                    {
                        perimeterFrame = true;
                    }
                    else
                    {
                        perimeterFrame = false;
                    }
                    Console.Clear();
                    Console.WriteLine("Will the bottom frame of this opening be buried? (yes/no)");
                    bool buriedFrame;
                    string buriedFrameOption = Console.ReadLine().ToLower();
                    if (buriedFrameOption == "yes")
                    {
                        buriedFrame = true;
                    }
                    else
                    {
                        buriedFrame = false;
                    }
                    S30DoorOrder s30door1 = new S30DoorOrder(nameCustomer, addressCustomer, phoneCustomer, totalPrice,amountPaid, widthMm, heightMm, color, glassThickness, dvh, dueDate, instalationIncluded, openingDirection, outOrIn, design, doubleShash, perimeterFrame, buriedFrame );
                    orders.Add(s30door1);
                    Console.WriteLine("Your order was created");
                    Thread.Sleep(2000);
                    userInputSwingingOpeningInt = -12345;
                }
                else if (userInputSwingingOpeningInt == 2)
                {
                    Console.Clear();
                    Console.WriteLine("What is the customer's name?");
                    string nameCustomer = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the customer's address");
                    string addressCustomer = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the customer's phone number?");
                    long phoneCustomer = long.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the total price of the opening in dollars?");
                    double totalPrice = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is paid amount for this opening in dollars?");
                    double amountPaid = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Is the instalation included for this opening? (yes/no)");
                    bool instalationIncluded;
                    string instalationIncludedOption = Console.ReadLine().ToLower();

                    if (instalationIncludedOption == "yes")
                    {
                        instalationIncluded = true;
                    }
                    else
                    {
                        instalationIncluded = false;
                    }
                    Console.Clear();
                    Console.WriteLine("What is the due date for deliver this opening?");
                    string dueDate = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is color of this opening?");
                    string color = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the width of this opening in mm?");
                    int widthMm = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the heigth of this opening in mm?");
                    int heightMm = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the design for this opening?");
                    string design = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the glass thickness for this opening in mm?");
                    int glassThickness = int.Parse(Console.ReadLine());
                    
                    Console.Clear();
                    Console.WriteLine("Will this opening have DVH glass? (yes/no)");
                    bool dvh;
                    string dvhOption = Console.ReadLine().ToLower();
                    if(dvhOption == "yes")
                    {
                        dvh = true;
                    }
                    else
                    {
                        dvh = false;
                    }
                    Console.Clear();
                    Console.WriteLine("What is the opening direction for this opening seeing from the outside?");
                    string openingDirection = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Will this opening open in or open out? (in/out)");
                    string outOrIn = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Will this opening be a double shash opening? (yes/no)");
                    bool doubleShash;
                    string doubleShashOption = Console.ReadLine().ToLower();
                    if (doubleShashOption == "yes")
                    {
                        doubleShash = true;

                    }
                    else
                    {
                        doubleShash = false;
                    }
                    Console.Clear();
                    Console.WriteLine("Will this opening have a frame for all the perimeter? (yes/no)");
                    bool perimeterFrame;
                    string perimeterFrameOption = Console.ReadLine().ToLower();
                    if (perimeterFrameOption == "yes")
                    {
                        perimeterFrame = true;
                    }
                    else
                    {
                        perimeterFrame = false;
                    }
                    Console.Clear();
                    Console.WriteLine("Will the bottom frame of this opening be buried? (yes/no)");
                    bool buriedFrame;
                    string buriedFrameOption = Console.ReadLine().ToLower();
                    if (buriedFrameOption == "yes")
                    {
                        buriedFrame = true;
                    }
                    else
                    {
                        buriedFrame = false;
                    }
                    S30SwingingWindowOrder s30SwingingWindow1 = new S30SwingingWindowOrder(nameCustomer, addressCustomer, phoneCustomer, totalPrice,amountPaid, widthMm, heightMm, color, glassThickness, dvh, dueDate, instalationIncluded, openingDirection, outOrIn, design, doubleShash, perimeterFrame, buriedFrame);
                    orders.Add(s30SwingingWindow1);
                    Console.WriteLine("Your order was created");
                    Thread.Sleep(2000);
                    userInputSwingingOpeningInt = -12345;

                }
                else if (userInputSwingingOpeningInt == 3)
                {
                    Console.Clear();
                    Console.WriteLine("What is the customer's name?");
                    string nameCustomer = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the customer's address");
                    string addressCustomer = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the customer's phone number?");
                    long phoneCustomer = long.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the total price of the opening in dollars?");
                    double totalPrice = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is paid amount for this opening in dollars?");
                    double amountPaid = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Is the instalation included for this opening? (yes/no)");
                    bool instalationIncluded;
                    string instalationIncludedOption = Console.ReadLine().ToLower();

                    if (instalationIncludedOption == "yes")
                    {
                        instalationIncluded = true;
                    }
                    else
                    {
                        instalationIncluded = false;
                    }
                    Console.Clear();
                    Console.WriteLine("What is the due date for deliver this opening?");
                    string dueDate = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is color of this opening?");
                    string color = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the width of this opening in mm?");
                    int widthMm = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the heigth of this opening in mm?");
                    int heightMm = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the design for this opening?");
                    string design = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the glass thickness for this opening in mm?");
                    int glassThickness = int.Parse(Console.ReadLine());
                    
                    Console.Clear();
                    Console.WriteLine("Will this opening have DVH glass? (yes/no)");
                    bool dvh;
                    string dvhOption = Console.ReadLine().ToLower();
                    if(dvhOption == "yes")
                    {
                        dvh = true;
                    }
                    else
                    {
                        dvh = false;
                    }
                    Console.Clear();
                    Console.WriteLine("What is the opening direction for this opening seeing from the outside?");
                    string openingDirection = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Will this opening open in or open out? (in/out)");
                    string outOrIn = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Will this opening be a double shash opening? (yes/no)");
                    bool doubleShash;
                    string doubleShashOption = Console.ReadLine().ToLower();
                    if (doubleShashOption == "yes")
                    {
                        doubleShash = true;

                    }
                    else
                    {
                        doubleShash = false;
                    }
                    Console.Clear();
                    Console.WriteLine("Will this opening have a frame for all the perimeter? (yes/no)");
                    bool perimeterFrame;
                    string perimeterFrameOption = Console.ReadLine().ToLower();
                    if (perimeterFrameOption == "yes")
                    {
                        perimeterFrame = true;
                    }
                    else
                    {
                        perimeterFrame = false;
                    }
                    Console.Clear();
                    Console.WriteLine("Will the bottom frame of this opening be buried? (yes/no)");
                    bool buriedFrame;
                    string buriedFrameOption = Console.ReadLine().ToLower();
                    if (buriedFrameOption == "yes")
                    {
                        buriedFrame = true;
                    }
                    else
                    {
                        buriedFrame = false;
                    }
                    ProbbaDoorOrder probbaDoor1 = new ProbbaDoorOrder(nameCustomer, addressCustomer, phoneCustomer, totalPrice,amountPaid, widthMm, heightMm, color, glassThickness, dvh, dueDate, instalationIncluded, openingDirection, outOrIn, design, doubleShash, perimeterFrame, buriedFrame);
                    orders.Add(probbaDoor1);
                    Console.WriteLine("Your order was created");
                    Thread.Sleep(2000);
                    userInputSwingingOpeningInt = -12345;
                }
                else if (userInputSwingingOpeningInt == 4)
                {
                    Console.Clear();
                    Console.WriteLine("What is the customer's name?");
                    string nameCustomer = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the customer's address");
                    string addressCustomer = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the customer's phone number?");
                    long phoneCustomer = long.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the total price of the opening in dollars?");
                    double totalPrice = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is paid amount for this opening in dollars?");
                    double amountPaid = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Is the instalation included for this opening? (yes/no)");
                    bool instalationIncluded;
                    string instalationIncludedOption = Console.ReadLine().ToLower();

                    if (instalationIncludedOption == "yes")
                    {
                        instalationIncluded = true;
                    }
                    else
                    {
                        instalationIncluded = false;
                    }
                    Console.Clear();
                    Console.WriteLine("What is the due date for deliver this opening?");
                    string dueDate = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is color of this opening?");
                    string color = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the width of this opening in mm?");
                    int widthMm = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the heigth of this opening in mm?");
                    int heightMm = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the design for this opening?");
                    string design = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the glass thickness for this opening in mm?");
                    int glassThickness = int.Parse(Console.ReadLine());
                    
                    Console.Clear();
                    Console.WriteLine("Will this opening have DVH glass? (yes/no)");
                    bool dvh;
                    string dvhOption = Console.ReadLine().ToLower();
                    if(dvhOption == "yes")
                    {
                        dvh = true;
                    }
                    else
                    {
                        dvh = false;
                    }
                    Console.Clear();
                    Console.WriteLine("What is the opening direction for this opening seeing from the outside?");
                    string openingDirection = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Will this opening open in or open out? (in/out)");
                    string outOrIn = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Will this opening be a double shash opening? (yes/no)");
                    bool doubleShash;
                    string doubleShashOption = Console.ReadLine().ToLower();
                    if (doubleShashOption == "yes")
                    {
                        doubleShash = true;

                    }
                    else
                    {
                        doubleShash = false;
                    }
                    Console.Clear();
                    Console.WriteLine("Will this opening have a frame for all the perimeter? (yes/no)");
                    bool perimeterFrame;
                    string perimeterFrameOption = Console.ReadLine().ToLower();
                    if (perimeterFrameOption == "yes")
                    {
                        perimeterFrame = true;
                    }
                    else
                    {
                        perimeterFrame = false;
                    }
                    Console.Clear();
                    Console.WriteLine("Will the bottom frame of this opening be buried? (yes/no)");
                    bool buriedFrame;
                    string buriedFrameOption = Console.ReadLine().ToLower();
                    if (buriedFrameOption == "yes")
                    {
                        buriedFrame = true;
                    }
                    else
                    {
                        buriedFrame = false;
                    }
                    ProbbaSwingingWindowOrder probbaSwingingWindow1 = new ProbbaSwingingWindowOrder(nameCustomer, addressCustomer, phoneCustomer, totalPrice,amountPaid, widthMm, heightMm, color, glassThickness, dvh, dueDate, instalationIncluded, openingDirection, outOrIn, design, doubleShash, perimeterFrame, buriedFrame);
                    orders.Add(probbaSwingingWindow1);
                    Console.WriteLine("Your order was created");
                    Thread.Sleep(2000);
                    userInputSwingingOpeningInt = -12345; 
                }
                else if (userInputSwingingOpeningInt != 1 && userInputSwingingOpeningInt != 2 && userInputSwingingOpeningInt != 3 && userInputSwingingOpeningInt != 4 && userInputSwingingOpeningInt != -12345)
                {
                    Console.Clear();
                    Console.WriteLine("This is not a valid option, please try again");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
        void ShowSlidingOpeningKinds()
        {
            int userInputSlidingOpeningInt = 1;
            while (userInputSlidingOpeningInt != -12345)
            {

            
                Console.WriteLine("What kind of sliding opening do you want to order?");
                Console.WriteLine("1. S-20 sliding window");
                Console.WriteLine("2. S-25 sliding window");
                Console.WriteLine("3. Probba sliding window");
                
                Console.WriteLine("Select a choice from the menu");
            
                string userInputSlidingOpeningString = Console.ReadLine();
                int.TryParse(userInputSlidingOpeningString, out userInputSlidingOpeningInt);
                if (userInputSlidingOpeningInt == 1)
                {
                    Console.Clear();
                    Console.WriteLine("What is the customer's name?");
                    string nameCustomer = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the customer's address");
                    string addressCustomer = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the customer's phone number?");
                    long phoneCustomer = long.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the total price of the opening in dollars?");
                    double totalPrice = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is paid amount for this opening in dollars?");
                    double amountPaid = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Is the instalation included for this opening? (yes/no)");
                    bool instalationIncluded;
                    string instalationIncludedOption = Console.ReadLine().ToLower();

                    if (instalationIncludedOption == "yes")
                    {
                        instalationIncluded = true;
                    }
                    else
                    {
                        instalationIncluded = false;
                    }
                    Console.Clear();
                    Console.WriteLine("What is the due date for deliver this opening?");
                    string dueDate = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is color of this opening?");
                    string color = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the width of this opening in mm?");
                    int widthMm = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the heigth of this opening in mm?");
                    int heightMm = int.Parse(Console.ReadLine());
                    
                    Console.Clear();
                    Console.WriteLine("What is the glass thickness for this opening in mm?");
                    int glassThickness = int.Parse(Console.ReadLine());
                    
                    Console.Clear();
                    Console.WriteLine("Will this opening have DVH glass? (yes/no)");
                    bool dvh;
                    string dvhOption = Console.ReadLine().ToLower();
                    if(dvhOption == "yes")
                    {
                        dvh = true;
                    }
                    else
                    {
                        dvh = false;
                    }
                    Console.Clear();
                    Console.WriteLine("What is the closer type for this opening?");
                    string closerType = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Is this opening a three shashes opening? (yes/no)");
                    bool threeShashes;
                    string threeShashesOption = Console.ReadLine
                    ().ToLower();
                    if (threeShashesOption == "yes")
                    {
                        threeShashes = true;
                    }
                    else
                    {
                        threeShashes = false;
                    }
                    Console.Clear();
                    Console.WriteLine("Will this opening has bearing wheels? (yes/no)");
                    bool bearingWheels;
                    string bearingWheelsOption = Console.ReadLine
                    ().ToLower();
                    if (bearingWheelsOption == "yes")
                    {
                        bearingWheels = true;
                    }
                    else
                    {
                        bearingWheels = false;
                    }



                    S20SlidingWindowOrder s20SlidingWindow1 = new S20SlidingWindowOrder(nameCustomer, addressCustomer, phoneCustomer, totalPrice, amountPaid, widthMm, heightMm, color, glassThickness, dvh, dueDate, instalationIncluded, closerType, threeShashes, bearingWheels);
                    
                    orders.Add(s20SlidingWindow1);
                    Console.WriteLine("Your order was created");
                    Thread.Sleep(2000);
                    userInputSlidingOpeningInt = -12345;
                }
                else if (userInputSlidingOpeningInt == 2)
                {
                    Console.Clear();
                    Console.WriteLine("What is the customer's name?");
                    string nameCustomer = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the customer's address");
                    string addressCustomer = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the customer's phone number?");
                    long phoneCustomer = long.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the total price of the opening in dollars?");
                    double totalPrice = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is paid amount for this opening in dollars?");
                    double amountPaid = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Is the instalation included for this opening? (yes/no)");
                    bool instalationIncluded;
                    string instalationIncludedOption = Console.ReadLine().ToLower();

                    if (instalationIncludedOption == "yes")
                    {
                        instalationIncluded = true;
                    }
                    else
                    {
                        instalationIncluded = false;
                    }
                    Console.Clear();
                    Console.WriteLine("What is the due date for deliver this opening?");
                    string dueDate = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is color of this opening?");
                    string color = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the width of this opening in mm?");
                    int widthMm = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the heigth of this opening in mm?");
                    int heightMm = int.Parse(Console.ReadLine());
                    
                    Console.Clear();
                    Console.WriteLine("What is the glass thickness for this opening in mm?");
                    int glassThickness = int.Parse(Console.ReadLine());
                    
                    Console.Clear();
                    Console.WriteLine("Will this opening have DVH glass? (yes/no)");
                    bool dvh;
                    string dvhOption = Console.ReadLine().ToLower();
                    if(dvhOption == "yes")
                    {
                        dvh = true;
                    }
                    else
                    {
                        dvh = false;
                    }
                    Console.Clear();
                    Console.WriteLine("What is the closer type for this opening?");
                    string closerType = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Is this opening a three shashes opening? (yes/no)");
                    bool threeShashes;
                    string threeShashesOption = Console.ReadLine
                    ().ToLower();
                    if (threeShashesOption == "yes")
                    {
                        threeShashes = true;
                    }
                    else
                    {
                        threeShashes = false;
                    }
                    Console.Clear();
                    Console.WriteLine("Will this opening has bearing wheels? (yes/no)");
                    bool bearingWheels;
                    string bearingWheelsOption = Console.ReadLine
                    ().ToLower();
                    if (bearingWheelsOption == "yes")
                    {
                        bearingWheels = true;
                    }
                    else
                    {
                        bearingWheels = false;
                    }



                    S25SlidingWindowOrder s25SlidingWindow1 = new S25SlidingWindowOrder(nameCustomer, addressCustomer, phoneCustomer, totalPrice, amountPaid, widthMm, heightMm, color, glassThickness, dvh, dueDate, instalationIncluded, closerType, threeShashes, bearingWheels);
                    
                    orders.Add(s25SlidingWindow1);
                    Console.WriteLine("Your order was created");
                    Thread.Sleep(2000);
                    userInputSlidingOpeningInt = -12345;
                }
                else if (userInputSlidingOpeningInt == 3)
                {
                    Console.Clear();
                    Console.WriteLine("What is the customer's name?");
                    string nameCustomer = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the customer's address");
                    string addressCustomer = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the customer's phone number?");
                    long phoneCustomer = long.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the total price of the opening in dollars?");
                    double totalPrice = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is paid amount for this opening in dollars?");
                    double amountPaid = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Is the instalation included for this opening? (yes/no)");
                    bool instalationIncluded;
                    string instalationIncludedOption = Console.ReadLine().ToLower();

                    if (instalationIncludedOption == "yes")
                    {
                        instalationIncluded = true;
                    }
                    else
                    {
                        instalationIncluded = false;
                    }
                    Console.Clear();
                    Console.WriteLine("What is the due date for deliver this opening?");
                    string dueDate = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is color of this opening?");
                    string color = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is the width of this opening in mm?");
                    int widthMm = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("What is the heigth of this opening in mm?");
                    int heightMm = int.Parse(Console.ReadLine());
                    
                    Console.Clear();
                    Console.WriteLine("What is the glass thickness for this opening in mm?");
                    int glassThickness = int.Parse(Console.ReadLine());
                    
                    Console.Clear();
                    Console.WriteLine("Will this opening have DVH glass? (yes/no)");
                    bool dvh;
                    string dvhOption = Console.ReadLine().ToLower();
                    if(dvhOption == "yes")
                    {
                        dvh = true;
                    }
                    else
                    {
                        dvh = false;
                    }
                    Console.Clear();
                    Console.WriteLine("What is the closer type for this opening?");
                    string closerType = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Is this opening a three shashes opening? (yes/no)");
                    bool threeShashes;
                    string threeShashesOption = Console.ReadLine
                    ().ToLower();
                    if (threeShashesOption == "yes")
                    {
                        threeShashes = true;
                    }
                    else
                    {
                        threeShashes = false;
                    }
                    Console.Clear();
                    Console.WriteLine("Will this opening has bearing wheels? (yes/no)");
                    bool bearingWheels;
                    string bearingWheelsOption = Console.ReadLine
                    ().ToLower();
                    if (bearingWheelsOption == "yes")
                    {
                        bearingWheels = true;
                    }
                    else
                    {
                        bearingWheels = false;
                    }



                    ProbbaSlidingWindowOrder probbaSlidingWindow1 = new ProbbaSlidingWindowOrder(nameCustomer, addressCustomer, phoneCustomer, totalPrice, amountPaid, widthMm, heightMm, color, glassThickness, dvh, dueDate, instalationIncluded, closerType, threeShashes, bearingWheels);
                    
                    orders.Add(probbaSlidingWindow1);
                    Console.WriteLine("Your order was created");
                    Thread.Sleep(2000);
                    userInputSlidingOpeningInt = -12345;
                }
                
                else if (userInputSlidingOpeningInt != 1 && userInputSlidingOpeningInt != 2 && userInputSlidingOpeningInt != 3 &&  userInputSlidingOpeningInt != -12345)
                {
                    Console.Clear();
                    Console.WriteLine("This is not a valid option, please try again");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
        void ShowOrderKinds()
        {
            int userInputOrderInt = 1;
            while (userInputOrderInt != -12345)
            {
                Console.Clear();
                Console.WriteLine("What kind of order do you want to create?");
                Console.WriteLine("1.Order for a Swinging opening");
                Console.WriteLine("2.Order for a Sliding opening");
                
                Console.Write("Select a choice from the menu: ");
                string userInputOrderString = Console.ReadLine();
                int.TryParse(userInputOrderString, out userInputOrderInt);
                if(userInputOrderInt == 1)
                {
                    
                    ShowSwingingOpeningKinds();
                    
                    
                    userInputOrderInt = -12345;
                }
                else if (userInputOrderInt == 2)
                {
                   ShowSlidingOpeningKinds();
                   userInputOrderInt = -12345;
                }
               
                else if (userInputOrderInt != 1 && userInputOrderInt != 2 && userInputOrderInt != 3 && userInputOrderInt != -12345)
                {
                    Console.Clear();
                    Console.WriteLine("This is not a valid option, please try again");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }

        Console.WriteLine("Welcome to the Aluminum Order Program");
        Console.WriteLine();
        Thread.Sleep(2000);
        int userInput = 1;
        while (userInput != 7)
        {
            Console.Clear();
            
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Order");
            Console.WriteLine("2. List Orders");
            Console.WriteLine("3. Save Orders");
            Console.WriteLine("4. Load Orders");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Create worksheet");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");
            string stringUserInput = Console.ReadLine();
            int.TryParse(stringUserInput, out userInput);
            

            
            if (userInput == 1)
            {
                
                ShowOrderKinds();

               

            }

            else if (userInput == 2)
            {
                Console.Clear();
                int indexToShow = 0;
                
                foreach (Order order in orders)
                {
                    indexToShow += 1;
                    Console.WriteLine($"{indexToShow}.{order.ToString()}");
                    Console.WriteLine("------------------------------------------------------------------------");
                }
                Console.WriteLine("Press enter for return to the menu");
                Console.ReadLine();
            }
            else if(userInput == 3)
            {
                Console.WriteLine("What is the filename for the orders file");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    
                    foreach (Order order in orders)
                    {
                        outputFile.WriteLine(order.ToSavedString());
                    }
                }
                Console.WriteLine($"Your orders were saved as {fileName}");
                Thread.Sleep(2000);
            }
            else if (userInput == 4)
            {
                Console.Clear();
                orders.Clear();
                Console.WriteLine("What is the filename for the orders file");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    
                    
                    
                    
                    
                        string [] lineParts = line.Split(":");
                        string orderType= lineParts[0];
                        string content = lineParts[1];
                        if (orderType == "S30Door")
                        {
                            S30DoorOrder s30Door1 = new S30DoorOrder(content);
                            orders.Add(s30Door1);
                        
                        }
                        else if (orderType == "ProbbaDoor")
                        {
                            ProbbaDoorOrder probbaDoor1 = new ProbbaDoorOrder(content);
                            orders.Add(probbaDoor1);
                        }
                        else if(orderType == "S30SwingingWindow")
                        {
                            S30SwingingWindowOrder s30SwingingWindow1 = new S30SwingingWindowOrder(content);
                            orders.Add(s30SwingingWindow1);
                        }
                        else if(orderType == "ProbbaSwingingWindow")
                        {
                            ProbbaSwingingWindowOrder probbaSwingingWindow1 = new ProbbaSwingingWindowOrder(content);
                            orders.Add(probbaSwingingWindow1);
                        }
                        else if(orderType == "S20SlidingWindow")
                        {
                            S20SlidingWindowOrder s20SlidingWindow1 = new S20SlidingWindowOrder(content);
                            orders.Add(s20SlidingWindow1);
                        }
                        else if(orderType == "S25SlidingWindow")
                        {
                            S25SlidingWindowOrder s25SlidingWindow1 = new S25SlidingWindowOrder(content);
                            orders.Add(s25SlidingWindow1);
                        }
                        else if(orderType == "ProbbaSlidingWindow")
                        {
                            ProbbaSlidingWindowOrder probbaSlidingWindow1 = new ProbbaSlidingWindowOrder(content);
                            orders.Add(probbaSlidingWindow1);
                        }
                        
                        

                        
                    

                    
                }
                int indexToShow = 0;
                
                    foreach (Order order in orders)
                    {
                        indexToShow += 1;
                        Console.WriteLine($"{indexToShow}.{order.ToString()}");
                        Console.WriteLine("------------------------------------------------------------------------");
                    }
                Console.WriteLine("Press enter for go to the menu");
                Console.ReadLine();
            }
            else if (userInput == 5)
            {
                ShowEventKinds();
            }
            else if (userInput == 6)
            {
                ShowWorkSheetKinds();
            }
            
            else if (userInput != 7 && userInput != 6 && userInput != 5 && userInput != 4 && userInput != 3 && userInput != 2 && userInput != 1)
            {
                Console.WriteLine("This is not a valid option, please try again");
                Thread.Sleep(2000);
                Console.Clear();
            
            }
        
           
        }
    }
}