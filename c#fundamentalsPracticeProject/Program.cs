using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace c_fundamentalsPracticeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? readResult;
            string? menuSelection = "";

            PetManager petManager = new PetManager();
            do
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
                Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
                Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
                Console.WriteLine(" 5. Edit an animal’s age");
                Console.WriteLine(" 6. Edit an animal’s personality description");
                Console.WriteLine(" 7. Display all cats with a specified characteristic");
                Console.WriteLine(" 8. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                // display the top-level menu options

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                    // NOTE: We could put a do statement around the menuSelection entry to ensure a valid entry, but we
                    //  use a conditional statement below that only processes the valid entry values, so the do statement 
                    //  is not required here. 
                }

                // use switch-case to process the selected menu option
                switch (menuSelection)
                {
                    case "1":
                        // List all of our current pet information
                        petManager.DisplayPet();
                        Console.WriteLine("\n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();

                        break;

                    case "2":
                        // Add a new animal friend to the ourAnimals array
                        petManager.AddPet();
                        petManager.AddNewPet();

                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "3":
                        // Ensure animal ages and physical descriptions are complete
                        petManager.CompleteAgePhysicalDescriptions();
                        Console.WriteLine("The animal ages and physical descriptions are complete");
                        readResult = Console.ReadLine();

                        break;

                    case "4":
                        // Ensure animal nicknames and personality descriptions are complete
                        petManager.CompleteNicknamesPersonalityDescriptions();
                        Console.WriteLine("The animal nickname and physical personality are complete");
                        readResult = Console.ReadLine();

                        break;

                    case "5":
                        // Edit an animal’s age
                        Console.WriteLine("Enter the ID of the animal whose age you want to edit:");
                        readResult = Console.ReadLine();
                        petManager.FindPetById(readResult); // Implement this method in PetManager to find a pet by ID
                        if (readResult != null)
                        {
                            petManager.EditAnimalAgeDescription(readResult);
                            // Print specific pet information after age is updated
                            Console.WriteLine($"Updated age of {readResult}");
                           
                            Console.WriteLine("Press the Enter key to continue.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No pet found with the specified ID.");
                        }
                        break;


                    /* case "5":
                         // Edit an animal’s age");
                         petManager.EditAnimalAgeDescription();
                         Console.WriteLine("Press the Enter key to continue.");
                         readResult = Console.ReadLine();
                         break;*/

                    case "6":
                        // Edit an animal’s personality description");
                        petManager.EditAnimalPersonalityDescription();
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "7":
                        // Display all cats with a specified characteristic
                        petManager.DisplaySpecifiedPhysicalPersonalForCat();
                        Console.WriteLine("Press the Enter key to continue.");
                        Console.ReadLine();
                        break;

                    case "8":
                        // Display all dogs with a specified characteristic
                        petManager.DisplaySpecifiedPhysicalPersonalForDog();
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    default:
                        break;
                }

            } while (menuSelection != "exit");
        }
    }
}
            /*string animalSpecies;

            Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
            string readResult = Console.ReadLine();
            bool validEntry;
            if (readResult != null)
            {
                do
                {
                    animalSpecies = readResult.ToLower();

                    switch (animalSpecies)
                    {
                        case "dog":
                            validEntry = true;
                            break;

                        case "cat":
                            validEntry = true;
                            break;
                        default:
                            Console.WriteLine("Invalid, input!");
                            validEntry = false;
                            break;
                    }
                    break;
                } while (validEntry == false);

            }*/
            /*int petCount = 4;
            int maxPets = 8;

            Console.WriteLine($"{petCount} {maxPets - petCount}");*/
            /*string[][] jaggedArray = new string[][]
            {
                new string[] { "one1", "two1", "three1", "four1", "five1", "six1" },
                new string[] { "one2", "two2", "three2", "four2", "five2", "six2" },
                new string[] { "one3", "two3", "three3", "four3", "five3", "six3" },
                new string[] { "one4", "two4", "three4", "four4", "five4", "six4" },
                new string[] { "one5", "two5", "three5", "four5", "five5", "six5" },
                new string[] { "one6", "two6", "three6", "four6", "five6", "six6" },
                new string[] { "one7", "two7", "three7", "four7", "five7", "six7" },
                new string[] { "one8", "two8", "three8", "four8", "five8", "six8" }
            };

            foreach (string[] array in jaggedArray)
            {
                foreach (string value in array)
                {
                    Console.WriteLine(value);
                }
                Console.WriteLine();
            }*/
            /*try
            {
                Test();
            }
            catch (Exception ex)
            {

            }*/
            /*Console.WriteLine("Enter an IPAddress: ");
            var userInput = Console.ReadLine();
            ValidateIPAddress(userInput);*/
        

        /*public static async void Test()
        {
            throw new Exception();
        }*/
        /* public static bool ValidateIPAddress(string? IP)
         {
             List<string> collection = new List<string>();

             foreach (var item in collection)
             {
                 if (item.Length != 4)
                 {
                     Console.WriteLine("Please enter less than 4 digits!");
                     return false;
                 }
                 else
                 {
                     collection.Add(item);
                 }
             }

             return true;
         }*/
    

        // ********** Pets application **********
        /* string[,] ourAnimals = new string[,] 
          {
              { "ABC12345", "Cat", "5", "An energetic and friendly pet, vibrant and playful, perfect for active companionship with a sturdy build and graceful movements.", "being independent, curious, and sometimes aloof yet affectionate. They enjoy playfulness and exploration, varying between seeking solitude and seeking attention.", "Buddy" },
              { "DEF73737", "Dog", "3", "They're typically known for their friendly and gentle personalities. They're outgoing, devoted, and eager to please, making them great family pets and wonderful companions.", "Energetic, affectionate, and playful.", "Texas" },
              { "GHI64546", "Cat", "6", "Medium-sized with a fluffy golden coat, brown eyes, and a wagging tail.", "Friendly, outgoing, and curious; loves to play fetch and cuddle.", "Sunny" },
              { "JKL57848", "Cat", "2", "Sleek black fur, bright green eyes, slender build.", "Curious, independent, enjoys lounging in sunny spots.", "Shadow" },
              { "D1", "Dog", "2", "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.", "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.", "Lola" },
              { "D2", "Dog", "9", "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.", "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.", "Loki" },
              { "C3", "Cat", "1", "small white female weighing about 8 pounds. litter box trained.", "friendly", "Puss" },
              { "C4", "Cat", "40", "Medium-sized with a fluffy golden coat, brown eyes, and a wagging tail.", "Curious, independent, enjoys lounging in sunny spots.", "Sally" }
          }; */





        // **************** dementional arrays ****************
        //int[,] array2DDeclaration = new int[4, 2];

        //int[,,] array3DDeclaration = new int[4, 2, 3];

        // Two-dimensional array.
        /*int[,] array2DInitialization = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        // Three-dimensional array.
        int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4,   5,  6 } },
                                { { 7, 8, 9 }, { 10, 11, 12 } } };

        // Accessing array elements.
        System.Console.WriteLine(array2DInitialization[0, 0]);
        System.Console.WriteLine(array2DInitialization[0, 1]);
        System.Console.WriteLine(array2DInitialization[1, 0]);
        System.Console.WriteLine(array2DInitialization[1, 1]);

        System.Console.WriteLine(array2DInitialization[3, 0]);
        System.Console.WriteLine(array2DInitialization[3, 1]);
        // Output:
        // 1
        // 2
        // 3
        // 4
        // 7
        // 8

        System.Console.WriteLine(array3D[1, 0, 1]);
        System.Console.WriteLine(array3D[1, 1, 2]);
        // Output:
        // 8
        // 12
        var allLength = array3D.Length;
        var total = 1;
        for (int i = 0; i < array3D.Rank; i++)
        {
            total *= array3D.GetLength(i);
        }
        System.Console.WriteLine($"{allLength} equals {total}");*/


        // ********** Work Role application
        /* string? readResult;
         string roleName = "";
         bool validEntry = false;

         do
         {
             Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
             readResult = Console.ReadLine();
             if (readResult != null)
             {
                 roleName = readResult.Trim();
             }

             if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
             {
                 validEntry = true;
             }
             else
             {
                 Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
             }

         } while (validEntry == false);

         Console.WriteLine($"Your input value ({roleName}) has been accepted.");
         readResult = Console.ReadLine();*/

        // ******************
        //string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
        /*string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
        //int stringsCount = myStrings.Length;

        //string myString = "";
        //int periodLocation = 0;

        for (int i = 0; i < myStrings.Length; i++)
        {
            string myString = myStrings[i];
            int periodLocation = myString.IndexOf(".");

            string mySentence;

            // extract sentences from each string and display them one at a time
            while (periodLocation != -1)
            {

                // first sentence is the string value to the left of the period location
                mySentence = myString.Remove(periodLocation);

                // the remainder of myString is the string value to the right of the location
                myString = myString.Substring(periodLocation + 1);

                // remove any leading white-space from myString
                myString = myString.TrimStart();

                // update the comma location and increment the counter
                periodLocation = myString.IndexOf(".");

                Console.WriteLine(mySentence);
            }
            mySentence = myString.Trim();
            Console.WriteLine(mySentence);
        }*/

        // ************************
        /* string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
         int periodLocation = 0;

         foreach (var myString in myStrings)
         {
         periodLocation = myString.IndexOf(".");
         do
         { 
                 string firstPart = myString.Substring(0, periodLocation + 1);
                 string secondPart = myString.Substring(periodLocation + 1).TrimStart();
                 Console.WriteLine(firstPart);
                 Console.WriteLine(secondPart);
                 break;
         }
         while (periodLocation >= 0);
         }*/

        /*string? role;
        Console.WriteLine("Enter your role name (Administrator, Manager, or User): ");

        while (true) 
        {
            role = Console.ReadLine();
            string trimmedValue = role.ToLower().Trim();
            // if (!trimmedValue.Contains("administrator") && !trimmedValue.Contains("manager") && !trimmedValue.Contains("user"))
            if (!trimmedValue.Equals("administrator") && !trimmedValue.Equals("manager") && !trimmedValue.Equals("user"))
            {
                Console.WriteLine($"The role name that you entered, {role}, is not valid. Enter your role name (Administrator, Manager, or User)");
            }
            else
            {
                break;
            }
        }
        Console.WriteLine($"Your input value {role} has been accepted.");*/

        // **********************
        /* string? role;
         Console.WriteLine("Enter your role name (Administrator, Manager, or User): ");

         do
         {
             role = Console.ReadLine();
             role = role.Trim().ToLower();

             if (role != "administrator" && role != "manager" && role != "user")
             {
                 Console.WriteLine($"The role name that you entered, {role}, is not valid. Enter your role name (Administrator, Manager, or User)");
             }

             else
             {
                 break;
             }
         } while (true);

             Console.WriteLine($"Your input value {role} has been accepted.");*/

        // *********************** 
        /* string? role;
         Console.WriteLine("Enter your role name (Administrator, Manager, or User): ");

         //while (true) 
         do
         {
             role = Console.ReadLine();
             string trimedValue = role.ToLower();
            /* if (trimedValue != "Administrator" && trimedValue != "Manager" && trimedValue != "User")
             {
                 Console.WriteLine($"The role name that you entered, {trimedValue} is not valid. Enter your role name (Administrator, Manager, or User)");
             }*/
        /* if (trimedValue != "administrator")
         {
             Console.WriteLine($"The role name that you entered, {trimedValue} is not valid. Enter your role name (Administrator, Manager, or User)");
         }
         else if (trimedValue != "manager")
         {
             Console.WriteLine($"The role name that you entered, {trimedValue} is not valid. Enter your role name (Administrator, Manager, or User)");
         }

         else if (trimedValue != "user")
         {
             Console.WriteLine($"The role name that you entered, {trimedValue} is not valid. Enter your role name (Administrator, Manager, or User)");
         }

         else
         {
             Console.WriteLine($"Your input value {trimedValue} has been accepted.");
             break;
         }

      } while (true);*/
        // ***************
        //bool validNumber = false;

        /*string? readValue;
        int value = 0;
        Console.WriteLine("Enter a number between 5 - 10: ");
        do
        { 
            readValue = Console.ReadLine();
            int.TryParse(readValue, out value);
            switch (value)
            {
                case 0:
                    Console.WriteLine("Please enter a number not a different character!");
                    break;
                case < 5:
                case > 10:
                    Console.WriteLine($"Sorry, you entered an invalid number, please try again {value}!");
                    Console.WriteLine($"You entered {value}. Please enter a number between 5 and 10.");
                    Console.WriteLine(value);
                    break;
                default:
                    break;
            }
            if (value > 5 && value < 10) continue;

        } while (value < 5 || value > 10);

        if (value > 5 && value < 10)
        {
            Console.WriteLine($"Your input value {readValue} has been accepted.");
        }*/

        /* string? readValue;
         int value;
         Console.WriteLine("Enter a number between 5 - 10: ");
         do
         {
             readValue = Console.ReadLine();
             int.TryParse(readValue, out value);

             switch (value)
             {
                 case < 5:
                 case > 10:
                     Console.WriteLine($"Sorry, you entered an invalid number ({value}). Please enter a number between 5 and 10.");
                     break;
                 default:
                     break;
             }

         } while (value < 5 || value > 10); // Loop while the entered number is less than 5 or greater than 10

         Console.WriteLine($"Your input value {readValue} has been accepted.");*/


        // *******************
        /*string? readResult;
        int numericNumber = 0;
        bool validNumber = false;

        Console.WriteLine("Enter a number containing at least three characters: ");
        do
        {
            readResult = Console.ReadLine();
            validNumber = int.TryParse(readResult, out numericNumber);

            if (!validNumber || readResult.Length <= 3)
            {
                Console.WriteLine("Your input is invalid, please enter at least three digits!");
                validNumber = false;
            }
            else
            {
                validNumber = true;
            }

        } while (!validNumber);*/

        // *****************
        /* string? readResult;
         int numericNumber = 0;
         bool validNumber = false;

         Console.WriteLine("Enter a number containing at least three characters: ");
         do
         {
             readResult = Console.ReadLine();
             validNumber = int.TryParse(readResult, out numericNumber);
             if (numericNumber >= 3)
             {
                 validNumber = true;
             }
             else if (numericNumber < 3)
             {
                 validNumber = false;
                 Console.WriteLine("PLease enter at least three digits!");
             }
             else
             {
                 Console.WriteLine("Your input is invalid, please try again!");
             }
         } while (validNumber == false);*/
        /*int hero = 10;
        int monster = 10;

        Random dice = new Random();

        do
        {
            int roll = dice.Next(1, 11);
            monster -= roll;
            Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

            if (monster <= 0) continue;

            roll = dice.Next(1, 11);
            hero -= roll;
            Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

        } while (hero > 0 && monster > 0);

        Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");*/

        /*Random hero = new Random();
        //int healthScoreH = hero.Next(1, 10);

        Random monster = new Random();
        //int healthScoreM = monster.Next(1, 10);
        int healthScoreH, healthScoreM;
        do
        {
            healthScoreH = hero.Next(1, 10);
            
            healthScoreM = monster.Next(1, 10);

            if (healthScoreM > 0)
            {
                healthScoreM -= healthScoreH;
                Console.WriteLine($"Monster was damaged and lost {healthScoreH} health and now has {healthScoreM} health");
            }

            if (healthScoreH > 0)
            {
                healthScoreH -= healthScoreM;
                Console.WriteLine($"Hero was damaged and lost {healthScoreM} health and now has {healthScoreH} health");
            }
               /* : (healthScoreH <= 0) ? "Monster wins!"
                : (healthScoreM <= 0) ? "Hero wins!"
                :*/
        /* if (healthScoreM <= 0)
         {
             Console.WriteLine("Hero wins!");
         }

         else if (healthScoreH <= 0)
         {
             Console.WriteLine("Monster wins!");
         }

    } while (healthScoreH > 0 && healthScoreM > 0);
        Console.WriteLine((healthScoreH <= 0 || healthScoreM <= 0) ? "Monster wins!" : "Hero wins!");*/

        /*Random randomNumber = new Random();
        int current = 0;

        do
        {
            current = randomNumber.Next(1, 11);
            Console.WriteLine(current);
        } while (current != 7);*/

        /* for (int i = 1; i < 101; i++)
         {
             // if (i % 3 == 0 && i % 5 == 0)
             if ((i % 3 == 0) && (i % 5 == 0))
             {
                 Console.WriteLine($"{i} - FizzBuzz");
             }
             else if (i % 3 == 0)
             {
                 Console.WriteLine($"{i} - Fizz");
             }
             else if (i % 5 == 0)
             {
                 Console.WriteLine($"{i} - Buzz");
             }
             else
             {
                 Console.WriteLine($"{i}");
             }
         }*/


        /*string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == "David")
            {
                names[i] = "Sammy";
            }
        }
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }*/
        //Console.WriteLine(names[2]);
        /*Console.WriteLine(StringFromColor(Color.Red));
            Console.WriteLine(StringFromColor(Color.Green));
            Console.WriteLine(StringFromColor(Color.Blue));
        

        static string StringFromColor(Color c)
        {
            switch (c)
            {
                case Color.Red:
                    return $"Red = {(int)c}";
                case Color.Green:
                    return $"Green = {(int)c}";
                case Color.Blue:
                    return $"Blue = {(int)c}";
                default:
                    return "Invalid color";
            }
        }*/

        
    
/* class A { int X = 24, Y = 45; }
A a1 = new(), a2 = new();

record B(int X = 24, int Y = 45);
B b1 = new(), b2 = new();

Console.WriteLine((a1 == a2, b1 == b2));*/



/*        TcpClient client; // Declaring a field to used to establish a TCP connection to a the client program in the network
        const int port = 12345; // Declaring a constant integer variable and set the port number to it to denote the port number for the TCP networking operations
        public Form1() // Initializing the Form
        {
            InitializeComponent(); // This is a method call to typically generated by the designer to initialize the visual components of the Form 
            DataManager.LoadData(); // Loading or initializing the data for the customer & card so we can use these data 
        }
        public async void StartServer() // Defining an asynchronous method that is responsible for creating a TCP server that listens to incoming connections on a specified port
        {
            // Create a TcpListener object to listen for incoming connections on any available network IPAddress.Any and a specified port
            TcpListener listener = new TcpListener(IPAddress.Any, port);
            listener.Start(); // Start listening for incoming connection requests
            button1.BackColor = Color.Green; // Using an UI element and calling the button "StartServer" method is being updated to idicate that the server is running and by changing the button's color to green
            button2.Text = "Start Reading"; // The button's text will change to a "Server Running" text
        
                client = await listener.AcceptTcpClientAsync(); // Accept a pending connection asynchronously
                IPAddress address = ((IPEndPoint)client.Client.RemoteEndPoint).Address; // When a connection accepted assigning the connected ´TcpClient´ instance to ´client´ field and retrieving the ´IP address´ of the connected client  
                Console.WriteLine($"Client connected: {address}"); // Printing a message to the user indicating the client's connection
        }

        public async void StartReading() // Defining this method to start reading byte data sent by the client program
        {
            byte[] bytes = new byte[1024]; // Defining an array to save the incoming byte data from the client program when reading it

            int n = 0; // Decalaring a variable and initializing it to use it when storing data in the array that represents the beginning of the array 
            try // Handling 'System.IO.IOException' exception where can be thrown if there's a network error or the underlying stream is closed
            {
                n = await client.GetStream().ReadAsync(bytes, 0, bytes.Length); // Using asynchronous operation that reads data from the network stream associated with the client object and stores it in the bytes array
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; } // When an exception occurs it is cought by the `catch` block then we store the exception in the `error` variable so the program won't crash and display an error message to the user instead

            string receivedData = Encoding.Unicode.GetString(bytes, 0, n); // Converting the incoming byte data into string type and store them in a variable
            string response = CheckData(receivedData); // Receiving a stream data transmitted via TCP network and checking the data by validating and verifying it 
            SendToClient(response); // After validating and verifying the received data with the imported data from database, we need to invoke the method "CheckData" to send messages to the client program  

        }

        private string CheckData(string data)
        {
            string[] parts = data.Split("-"); // Spliting the incoming data string using the "-" delimiter and assign the first part to customerID and the second part to cardSerialNumber so we can use these two distinct data to validate and verify these data does exist in the database or not
            string customerID = parts[0]; // Using the index [0] to retrieve the first data which represents the "userID" number 
            string cardSerialNumber = parts[1]; // Using the index [1] to retrieve the second data which represents the card "serial" number
            Data<Customer> customers = DataManager.Customers; // Accessing the "Customers" data and retrieving a collection of objects using the "DataManager" class that way we can use these data for verifying it with the received userID data
            Data<Card> cards = DataManager.Cards; // Accessing the "Cards" data and retrieving a collection of objects using the "DataManager" class that way we can use these data for verifying it with the received user card serial data

            Customer foundCustomer = null; // Initializing the variable as ´null´ hence empty before counting start looking for it in the list indicating that at this point no specific ´Customer´ object has been assigned to this variable
            Card foundCard = null; // Initializing the variable as ´null´ hence empty before counting looking for it in the list indicating that at this point no specific ´Card´ object has been assigned to this variable
            bool validCustomer = false; // Declaring a boolean variable and initializing as false to indicating whether a matching customer found
            bool validCard = false; // Declaring a boolean variable and initializing as false to indicating whether a matching card found
            for (int i = 0; i < customers.GetAll().Count; i++) // Using for loop to iterate through ´Customer´ collection that's (uisng retrieved ´customers.GetAll()´) method invocation checking if the customer object matches the received customerID from client program or the one that we're looking for
            {
                Customer customer = customers.GetAll()[i];
                if (customer.GetUserID().Equals(customerID)) // If a match is found it assigns the mathced ´customer´ object to ´foundCustomer´ and setting validCustomer to ´true´
                {
                    foundCustomer = customer; // Setting the found/matched card to be the one that matches the customer ID
                    validCustomer = true; // Setting the valid customer to true indicating that the customer is valid
                }
            }
            for (int i = 0; i < cards.GetAll().Count; i++) // Using for loop to iterate through ´Card´ collection that's (uisng retrieved ´cards.GetAll()´) method invocation checking if the card object matches the received cardSerialNumber from client program or the one that we're looking for
            {
                Card card = cards.GetAll()[i];
                if (card.GetSerialNumber().Equals(cardSerialNumber)) // If a match is found it assigns the mathced ´card´ object to ´foundCard´ and setting validCard to ´true´
                {
                    foundCard = card; // Setting the found/matched card to be the one that matches the serial card
                    validCard = true; // Setting the valid card to true indicating that the card is valid
                }
            }
            // In this block we're constructing a response message based on the validation status of a customer and a card
            string response = string.Empty; // Initializing the variable ´response´ with an empty string value then it will be used to store the response messages
            // Conditional Messages based on Validation Status:
            // If both customer & card are not valid (´validCustomer´ and ´validCard´ are both ´false´)
            if (!validCustomer && !validCard)
            {   // Sets the response variable to a message indicating that the user ID is not registered, hence the user hasn't won anything
                response = "The message is received \n\nThe user ID is not registered therefore you haven't win anything this time";
            }
            // If the card is valid but the customer is not valid  (validCard is true and validCustomer is false)
            if (validCard && !validCustomer)
            {   // Sets response variable to a message indicating that the user ID is not registered but they have won a specific card (retrieved from foundCard)
                response = $"The message is received \n\nThe user ID is not registered but you have won a {foundCard.GetCardType()} gold card";
            }
            // If the card is not valid but the customer is valid (validCard is false and validCustomer is true)
            if (!validCard && validCustomer)
            {   // Sets responce to a message indicating that the user ID is registered but they haven't won a specific card
                response = "The message is received \n\nThe user ID is registered but you have not won any gold card";
            }
            // If both the customer and card are valid (validCustomer and validCard are both true)
            if (validCustomer && validCard)
            {   // Constructs a message congratulating the user (foundCustomer) for winning an exclusive card (foundCard) including the customer's name, the type of the card won, and instructions on where to collect it
                response = "The message is received\n\n" +
                    $"Congratulations {foundCustomer.GetName()}!\n" +
                    $"You have won this execlusive {foundCard.GetCardType()}-gold card!\n" +
                    $"You can bring your card from a local store in {foundCustomer.GetCity()}";
            }
            return response; // Returning the constructed response message back to the method based on the validation status of the customer and the card and the messages will be used further to be sent to the client program
        }

        public async void SendToClient(string message) // Defining a method and passing a parameter to send data to the client program
        {
            byte[] outData = Encoding.Unicode.GetBytes(message); // Defining an byte array to convert the string data into bytes and store them in the array
            // The expected exception that can occur in this line is a `System.IO.IOException` this exception can be thrown when an I/O error or a network-related errors for ex: when dissconnecting or timeouts
            try
            {
                await client.GetStream().WriteAsync(outData, 0, outData.Length); // Using asynchronous operation to write data from the ´outData´ byte array to the network stream associated with the client program
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; } // When an exception occurs it is cought by the `catch` block then we store the exception in the `error` variable so the program won't crash and display an error message to the user instead
        }

        private void startServer_btn(object sender, EventArgs e)
        {
            StartServer();
        }

        private void startReading_btn(object sender, EventArgs e)
        {
            StartReading();
        }*/
/*TcpClient client; // Declaring a field to used to establish a TCP connection to a the client program in the network
        TcpListener listener;
        const int port = 12345; // Declaring a constant integer variable and set the port number to it to denote the port number for the TCP networking operations
        public Form1() // Initializing the Form
        {
            InitializeComponent(); // This is a method call to typically generated by the designer to initialize the visual components of the Form 
            DataManager.LoadData(); // Loading or initializing the data for the customer & card so we can use these data 
        }

        public async void StartReceiving() // Defining an async method to accept an incoming client connections asynchronously from the client program
        {
            try // Applying exception handling if not getting a connection or our programs disconnects
            {
                client = await listener.AcceptTcpClientAsync(); // Using the the object to accept incoming client connections and the keyword await means this is an asynchronous operation that the method will paus and wait for a client connection
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; } // Catching the exception and displaying an error message instead of allowing the program to crash and display an error message to the user instead

            StartReading(client); // Invoking the method to read and wait for incoming byte data through the connection
        }

        public async void StartReading(TcpClient client) // Defining this method to start reading byte data sent by the client program
        {
            byte[] bytes = new byte[1024]; // Defining an array to save the incoming byte data from the client program when reading it

            int n = 0; // Decalaring a variable and initializing it to use it when storing data in the array that represents the beginning of the array 
            try // Handling 'System.IO.IOException' exception where can be thrown if there's a network error or the underlying stream is closed
            {
                n = await client.GetStream().ReadAsync(bytes, 0, bytes.Length); // Using asynchronous operation that reads data from the network stream associated with the client object and stores it in the bytes array
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; } // When an exception occurs it is cought by the `catch` block then we store the exception in the `error` variable so the program won't crash and display an error message to the user instead

            string receivedData = Encoding.Unicode.GetString(bytes, 0, n); // Converting the incoming byte data into string type and store them in a variable
           
            string[] parts = receivedData.Split("-"); // Spliting the incoming data string using the "-" delimiter and assign the first part to customerID and the second part to cardSerialNumber so we can use these two distinct data to validate and verify these data does exist in the database or not
            string customerID = parts[0]; // Using the index [0] to retrieve the first data which represents the "userID" number 
            string cardSerialNumber = parts[1]; // Using the index [1] to retrieve the second data which represents the card "serial" number
            Data<Customer> customers = DataManager.Customers; // Accessing the "Customers" data and retrieving a collection of objects using the "DataManager" class that way we can use these data for verifying it with the received userID data
            Data<Card> cards = DataManager.Cards; // Accessing the "Cards" data and retrieving a collection of objects using the "DataManager" class that way we can use these data for verifying it with the received user card serial data

            Customer foundCustomer = null; // Initializing the variable as ´null´ hence empty before counting start looking for it in the list indicating that at this point no specific ´Customer´ object has been assigned to this variable
            Card foundCard = null; // Initializing the variable as ´null´ hence empty before counting looking for it in the list indicating that at this point no specific ´Card´ object has been assigned to this variable
            bool validCustomer = false; // Declaring a boolean variable and initializing as false to indicating whether a matching customer found
            bool validCard = false; // Declaring a boolean variable and initializing as false to indicating whether a matching card found
            for (int i = 0; i < customers.GetAll().Count; i++) // Using for loop to iterate through ´Customer´ collection that's (uisng retrieved ´customers.GetAll()´) method invocation checking if the customer object matches the received customerID from client program or the one that we're looking for
            {
                Customer customer = customers.GetAll()[i];
                if (customer.GetUserID().Equals(customerID)) // If a match is found it assigns the mathced ´customer´ object to ´foundCustomer´ and setting validCustomer to ´true´
                {
                    foundCustomer = customer; // Setting the found/matched card to be the one that matches the customer ID
                    validCustomer = true; // Setting the valid customer to true indicating that the customer is valid
                }
            }
            for (int i = 0; i < cards.GetAll().Count; i++) // Using for loop to iterate through ´Card´ collection that's (uisng retrieved ´cards.GetAll()´) method invocation checking if the card object matches the received cardSerialNumber from client program or the one that we're looking for
            {
                Card card = cards.GetAll()[i];
                if (card.GetSerialNumber().Equals(cardSerialNumber)) // If a match is found it assigns the mathced ´card´ object to ´foundCard´ and setting validCard to ´true´
                {
                    foundCard = card; // Setting the found/matched card to be the one that matches the serial card
                    validCard = true; // Setting the valid card to true indicating that the card is valid
                }
            }
            // In this block we're constructing a response message based on the validation status of a customer and a card
            string response = string.Empty; // Initializing the variable ´response´ with an empty string value then it will be used to store the response messages
            // Conditional Messages based on Validation Status:
            // If both customer & card are not valid (´validCustomer´ and ´validCard´ are both ´false´)
            if (!validCustomer && !validCard)
            {   // Sets the response variable to a message indicating that the user ID is not registered, hence the user hasn't won anything
                response = "The message is received \n\nThe user ID is not registered therefore you haven't win anything this time";
            }
            // If the card is valid but the customer is not valid  (validCard is true and validCustomer is false)
            if (validCard && !validCustomer)
            {   // Sets response variable to a message indicating that the user ID is not registered but they have won a specific card (retrieved from foundCard)
                response = $"The message is received \n\nThe user ID is not registered but you have won a {foundCard.GetCardType()} gold card";
            }
            // If the card is not valid but the customer is valid (validCard is false and validCustomer is true)
            if (!validCard && validCustomer)
            {   // Sets responce to a message indicating that the user ID is registered but they haven't won a specific card
                response = "The message is received \n\nThe user ID is registered but you have not won any gold card";
            }
            // If both the customer and card are valid (validCustomer and validCard are both true)
            if (validCustomer && validCard)
            {   // Constructs a message congratulating the user (foundCustomer) for winning an exclusive card (foundCard) including the customer's name, the type of the card won, and instructions on where to collect it
                response = "The message is received\n\n" +
                    $"Congratulations {foundCustomer.GetName()}!\n" +
                    $"You have won this execlusive {foundCard.GetCardType()}-gold card!\n" +
                    $"You can bring your card from a local store in {foundCustomer.GetCity()}";
            }
            SendToClient(response); // After validating and verifying the received data with the imported data from database, we need to invoke the method "CheckData" to send messages to the client program  
            StartReading(client);
        }

        public async void SendToClient(string message) // Defining a method and passing a parameter to send data to the client program
        {
            byte[] outData = Encoding.Unicode.GetBytes(message); // Defining an byte array to convert the string data into bytes and store them in the array
            // The expected exception that can occur in this line is a `System.IO.IOException` this exception can be thrown when an I/O error or a network-related errors for ex: when dissconnecting or timeouts
            try
            {
                await client.GetStream().WriteAsync(outData, 0, outData.Length); // Using asynchronous operation to write data from the ´outData´ byte array to the network stream associated with the client program
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; } // When an exception occurs it is cought by the `catch` block then we store the exception in the `error` variable so the program won't crash and display an error message to the user instead
        }

        private void startServer_btn(object sender, EventArgs e)
        {
            try
            {
                // Create a TcpListener object to listen for incoming connections on any available network IPAddress.Any and a specified port
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start(); // Start listening for incoming connection requests
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; } // When an exception occurs it is cought by the `catch` block then we store the exception in the `error` variable so the program won't crash and display an error message to the user instead
            StartReceiving(); // Invoking this method which to handle incoming connections from the client program if no exception occurs
            button1.BackColor = Color.Green; // Using an UI element and calling the button "StartServer" method is being updated to idicate that the server is running and by changing the button's color to green
            
        }
 */