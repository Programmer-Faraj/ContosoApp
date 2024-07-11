using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace TestingCode
{

    public class Pet
    {
         Dictionary<Guid, Pet> ourPets = new Dictionary<Guid, Pet>();

         public void AddPet(Pet pet)
         {
             //string animalID = GetNextID().ToString();
             ourPets.Add(new Guid(), pet);
         }
    }
    // ********************* IEnumerable testing code **********************
    /*public class Customer
    {
        private String _Name, _City;
        private long _Mobile;
        private double _Amount;

        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public String City
        {
            get { return _City; }
            set { _City = value; }
        }

        public long Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }

        public double Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            Customer[] customers = new Customer[]
      {
           new Customer {Name="Vithal Wadje", City="Mumbai", Mobile=99999999999, Amount=89.45 },
           new Customer { Name = "Sudhir Wadje", City = "Latur", Mobile = 8888888888888888888, Amount =426.00 },
           new Customer { Name = "Anil", City = "Delhi", Mobile = 7777777777777777777, Amount = 5896.20 }
      };
            return customers;
        }
        public void DisplayCustomers()
        {
            foreach (var cust in GetAllCustomer())
            {
                Console.WriteLine($"Name: {cust.Name} City: { cust.City} Mobile: {cust.Mobile} Amount: {cust.Amount.ToString("c")}");
            }
        }
    }*/
    // ********************* Contoso testing code **********************
    /*public class Pet
    {
        public string? AnimalAge { get; set; }

        public Pet(string age)
        {
            AnimalAge = age;
        }
    }

    public class PetManager
    {
        string? readResult;
        int petAge = 0;
        bool validEntry = false;
        //string? animalAge = "";

        public void CreatePetAge(Pet pet)
        {
            do
            {
                Console.WriteLine("Enter pet age or ? if unknown: ");
                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    pet.AnimalAge = readResult.Trim().ToLower();
                    if (pet.AnimalAge != "?")
                    {
                        validEntry = int.TryParse(pet.AnimalAge, out petAge);
                    }
                    else
                    {
                        validEntry = true;
                    }
                }

            } while (validEntry == false);
        }

        public void CompletePetAge(Pet pet)
        {
            if (pet.AnimalAge == "?")
            {
                do
                {
                    Console.WriteLine("Enter pet age: ");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        pet.AnimalAge = readResult.Trim().ToLower();
                        validEntry = int.TryParse(pet.AnimalAge, out petAge);
                    }

                } while (!validEntry);
            }
           /* else if (string.IsNullOrEmpty(pet.AnimalAge))
            {
                validEntry = false;
            }*/
    /* }

     public void DisplayAge(Pet pet)
     {
         readResult = pet.AnimalAge;
         List<string> ages = new List<string>();
         ages.Add(readResult);
         foreach (var age in ages)
         {
             Console.WriteLine($"The animal complete age is {ages[0]}");
         }
     }
 }*/

    public struct Location
    {
        public int x, y;

        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            // ************* Exercise - Complete a challenge activity to improve code readability *************
            /* The following code has a message
               and the letters are being reversed
               and then dsiplaying the total number
               of ´o´ appears to the window console.
            */

            string originalMessage = "The quick brown fox jumps over the lazy dog.";

            char[] convertedMessage = originalMessage.ToCharArray();
            Array.Reverse(convertedMessage);

            int letterCount = 0;

            foreach (char letter in convertedMessage)
            {
               if (letter == 'o')
               {
                    letterCount++;
               }
            }

            string newMessage = new String(convertedMessage);

            Console.WriteLine(newMessage);
            Console.WriteLine($"'o' appears {letterCount} times.");

            Pet pet = new Pet();
            //pet.
        }

        // ************* Exercise - Use whitespace to make your code easier to read *************
        /*Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }
        }*/

        // ************* Create and use code comments *************
        /*Random random = new Random();
        string[] orderIDs = new string[5];
        // Loop through each blank orderID
        for (int i = 0; i < orderIDs.Length; i++)
        {
            // Get a random value that equates to ASCII letters A through E
            int prefixValue = random.Next(65, 70);
            // Convert the random value into a char, then a string
            string prefix = Convert.ToChar(prefixValue).ToString();
            // Create a random number, pad with zeroes
            string suffix = random.Next(1, 1000).ToString("000");
            // Combine the prefix and suffix together, then assign to current OrderID
            orderIDs[i] = prefix + suffix;
        }
        // Print out each orderID
        foreach (var orderID in orderIDs)
        {
            Console.WriteLine(orderID);
        }*/

        /*
          The following code creates five random OrderIDs
          to test the fraud detection process.  OrderIDs
          consist of a letter from A to E, and a three
          digit number. Ex. A123.
        */

        // Belongs above
        /*Random random = new Random();
        string[] orderIDs = new string[5];

        for (int i = 0; i < orderIDs.Length; i++)
        {
            int prefixValue = random.Next(65, 70);
            string prefix = Convert.ToChar(prefixValue).ToString();
            string suffix = random.Next(1, 1000).ToString("000");

            orderIDs[i] = prefix + suffix;
        }

        foreach (var orderID in orderIDs)
        {
            Console.WriteLine(orderID);
        }*/


        public class Pet
            {
                public string name;
            }



        // ************* Inventory code example *************
        /*int[] inventory = { 200, 450, 700, 175, 250 };
        int sum = 0;
        int bin = sum;

        foreach (int items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }
        Console.WriteLine($"We have {sum} items in inventory.");*/


        // ************* Code challenge - Report the Order IDs that need further investigation *************
        /*string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
        foreach (var orderID in fraudulentOrderIDs)
        {
            if (orderID.StartsWith("B"))
            {
                Console.WriteLine(orderID);
            }
        }*/
        // ************* An example of looping through an array *************
        /*string[] names = { "Rowena", "Robin", "Bao" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }*/
        /* Location a = new Location(20, 20);
         Location b = a;
         a.x = 100;

         // Print the value of b.x
         Console.WriteLine(b.x);

         // Output: 20


     //      ******************** Challenge: Improve renewal rate of subscriptions *********************

     // Declare a new array, assign values and access the values
     /*string[] fraudulentOrderIDs = new string[3];

     fraudulentOrderIDs[0] = "A123";
     fraudulentOrderIDs[1] = "B456";
     fraudulentOrderIDs[2] = "C789";
     // fraudulentOrderIDs[3] = "D000";

     Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
     Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
     Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

     fraudulentOrderIDs[0] = "F000";

     Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");*/

        // Initialize an array
        /*string[] fraudulentOrderIDs = new string[] { "A123", "B456", "C789" };

        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");*/

        //      ******************** Challenge: Improve renewal rate of subscriptions *********************

        /*Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Your subscription expires within a day!");
            discountPercentage = 20;
        }
        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            discountPercentage = 10;
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }

        if (discountPercentage > 0)
        {
            Console.WriteLine($"Renew now and save {discountPercentage}%.");
        }*/

        // **************** second copy *****************
        /*Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        if (daysUntilExpiration == 1)
        {
            discountPercentage = 20;
            Console.WriteLine("Your subscription expires within a day!");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }

        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            Console.WriteLine($"Renew now and save {10}%!");
        }

        else if (daysUntilExpiration <= 10)
        {

            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }

        else if (daysUntilExpiration == 0)
        {
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("Your subscription has expired.");
        }*/


        //      ******************** Dice roll game ********************
        /*Random firstNumber = new Random();
        int roll1 = firstNumber.Next(1, 7);
        int roll2 = firstNumber.Next(1, 7);
        int roll3 = firstNumber.Next(1, 7);
        /*int roll1 = 3;
        int roll2 = 3;
        int roll3 = 3;*/
        /*int sum = roll1 + roll2 + roll3;
            //int total = 0;

            Console.WriteLine($"Dice roll: {roll1} {roll2} {roll3} = {sum}");*/

        //if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        /*if (roll1 == roll2 && roll1 == roll3 && roll2 == roll3)
        {
            sum += 6;
            Console.WriteLine($"You rolled triples! + 6 bonus to {sum}!");
        }*/

        //if ((roll1 == roll2) && (roll2 == roll3))
        /*else if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
        {
            sum += 2;
            Console.WriteLine($"You rolled doubles! +2 bonus to total {sum}!");
        }

        if (sum >= 15)
        {
            Console.WriteLine("You won");
        }
        else
        {
            Console.WriteLine("Sorry, you lost!");
        }*/

        /*if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
        {
            if (roll1 == roll2 && roll2 == roll3)
            {
                sum += 6;
                Console.WriteLine($"You rolled triples! + 6 bonus to {sum}!");
            }
            else
            {
                sum += 2;
                Console.WriteLine($"You rolled doubles! +2 bonus to total {sum}!");
            }
        }

        if (sum >= 16)
        {
            Console.WriteLine("You won a new car");
        }
        else if (sum > 10)
        {
            Console.WriteLine("You won a new laptop");
        }
        else if (sum == 7)
        {
            Console.WriteLine("You won a trip");
        }
        else
        {
            Console.WriteLine("You won a kitten");
        }*/
    }


        /*Customer customer = new Customer();
        customer.DisplayCustomers();*/
        // ********************* Contoso testing code **********************
        /*PetManager petManger = new PetManager();
        string menuSelection = "";
        string? readResult;
        // string? animalAge = "";
        Pet pet = new Pet(null);
        do
        {
            Console.Clear();
            Console.WriteLine("Enter a number: ");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                menuSelection = readResult.ToLower();
            }

            switch (menuSelection)
            {
                case "1":

                    petManger.DisplayAge(pet);
                    Console.WriteLine("\n\rPress the Enter key to continue");
                    readResult = Console.ReadLine();
                    break;

                case "2":

                    petManger.CreatePetAge(pet);
                    Console.WriteLine("\n\rPress the Enter key to continue");
                    readResult = Console.ReadLine();
                    break;

                case "3":

                    petManger.CompletePetAge(pet);
                    Console.WriteLine("\n\rPress the Enter key to continue");
                    readResult = Console.ReadLine();
                    break;
                default:
                    break;
            }
        } while (menuSelection != "exit");*/

    }

// This class is mutable. Its data can be modified from
// outside the class.
/*public class Customer
{
    // Auto-implemented properties for trivial get and set
    public double TotalPurchases { get; set; }
    public string Name { get; set; }
    public int CustomerId { get; set; }

    // Constructor
    public Customer(double purchases, string name, int id)
    {
        TotalPurchases = purchases;
        Name = name;
        CustomerId = id;
    }

    // Methods
    public string GetContactInfo() { return "ContactInfo"; }
    public string GetTransactionHistory() { return "History"; }

    // .. Additional methods, events, etc.
}

class Program
{
    static void Main()
    {
        // Initialize a new object.
        Customer cust1 = new Customer(4987.63, "Northwind", 90108);

        // Modify a property.
        cust1.TotalPurchases += 499.99;
        Console.WriteLine($"{cust1.TotalPurchases} {cust1.Name} {cust1.CustomerId}");
    }
}*/



/////////////////////////
/*
class PersonPrivateSet
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public PersonPrivateSet(string first, string last) => (FirstName, LastName) = (first, last);

    public void ChangeName(string first, string last) => (FirstName, LastName) = (first, last);
}

class PersonReadOnly
{
    public string FirstName { get; }
    public string LastName { get; }
    public PersonReadOnly(string first, string last) => (FirstName, LastName) = (first, last);
}

class PersonInit
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
}

class Program
{
    private static void Main(string[] args)
    {
        PersonPrivateSet personPrivateSet = new("Bill", "Gates");
        PersonReadOnly personReadOnly = new("Bill", "Gates");
        PersonInit personInit = new(){ FirstName = "Bill", LastName = "Gates" };
        Console.WriteLine($"{personInit.FirstName} {personInit.LastName}");
    }
}*/



//////////////////////
/*
class A
{
    protected int x = 123;
}

class B : A
{
    static void Main()
    {
        var a = new A();
        var b = new B();

        // Error CS1540, because x can only be accessed by
        // classes derived from A.
        // a.x = 10;

        // OK, because this class derives from A.
        b.x = 10;
    }
}*/



///////////////////
/*abstract class Shape
{
    public abstract int GetArea();
}

class Square : Shape
{
    private int _side;

    public Square(int n) => _side = n;

    // GetArea method is required to avoid a compile-time error.
    public override int GetArea() => _side * _side;

    static void Main()
    {
        var sq = new Square(12);
        Console.WriteLine($"Area of the square = {sq.GetArea()}");
    }
}*/
// Output: Area of the square = 144



/////////////////////

// This class is immutable. After an object is created,
// it cannot be modified from outside the class. It uses a
// constructor to initialize its properties.
/*class Contact
{
    // Read-only property.
    public string Name { get; }

    // Read-write property with a private set accessor.
    public string Address { get; private set; }

    // Public constructor.
    public Contact(string contactName, string contactAddress)
    {
        Name = contactName;
        Address = contactAddress;
    }
}

// This class is immutable. After an object is created,
// it cannot be modified from outside the class. It uses a
// static method and private constructor to initialize its properties.
public class Contact2
{
    // Read-write property with a private set accessor.
    public string Name { get; private set; }

    // Read-only property.
    public string Address { get; }

    // Private constructor.
    private Contact2(string contactName, string contactAddress)
    {
        Name = contactName;
        Address = contactAddress;
    }

    // Public factory method.
    public static Contact2 CreateContact(string name, string address)
    {
        return new Contact2(name, address);
    }
}

public class Program
{
    static void Main()
    {
        // Some simple data sources.
        string[] names = ["Terry Adams",
            "Fadi Fakhouri",
            "Hanying Feng",
            "Cesar Garcia",
            "Debra Garcia"];
        string[] addresses = ["123 Main St.",
            "345 Cypress Ave.",
            "678 1st Ave",
            "12 108th St.",
            "89 E. 42nd St."];

        // Simple query to demonstrate object creation in select clause.
        // Create Contact objects by using a constructor.
        var query1 = from i in Enumerable.Range(0, 5)
                     select new Contact(names[i], addresses[i]);

        // List elements cannot be modified by client code.
        var list = query1.ToList();
        foreach (var contact in list)
        {
            Console.WriteLine("{0}, {1}", contact.Name, contact.Address);
        }

        // Create Contact2 objects by using a static factory method.
        var query2 = from i in Enumerable.Range(0, 5)
                     select Contact2.CreateContact(names[i], addresses[i]);

        // Console output is identical to query1.
        var list2 = query2.ToList();

        // List elements cannot be modified by client code.
        // CS0272:
         list2[0].Name = "Eugene Zabokritski";
    }
}*/

/* Output:
    Terry Adams, 123 Main St.
    Fadi Fakhouri, 345 Cypress Ave.
    Hanying Feng, 678 1st Ave
    Cesar Garcia, 12 108th St.
    Debra Garcia, 89 E. 42nd St.
*/


/*public class TimePeriod
{
    private double _seconds;

    public double Hours
    {
        get { return _seconds / 3600; }
        set
        {
            if (value < 0 || value > 24)
                throw new ArgumentOutOfRangeException(nameof(value),
                      "The valid range is between 0 and 24.");

            _seconds = value * 3600;
        }
    }
}*/
/*class Program
{
    public static void Main(string[] args)
    {
        TimePeriod t = new TimePeriod();
        // The property assignment causes the 'set' accessor to be called.
        t.Hours = 24;*/

        // Retrieving the property causes the 'get' access
        // or to be called.
       /* Console.WriteLine($"Time in hours: {t.Hours}");
    }
}*/
        // The example displays the following output:
        //    Time in hours: 24
