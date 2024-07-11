// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            string readResult;
            string? menuSelection = "";

            PetManager parsePet = new PetManager();
            // Add animal friend to the ourAnimals dictionary
            Pet pet = new Pet();
            PetsRepository repository = new PetsRepository();
            DisplayPets pets = new DisplayPets();
            NewBusinessLogic allPets = new NewBusinessLogic(repository, pets);
            do
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Add a new animal friend to the ourAnimals dictionary");
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
                        allPets.ProvideUserAllItems();
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "2":
                        repository.AddPet(pet);
                        parsePet.CreatePet(pet);
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "3":

                        break;

                    case "4":

                        Console.WriteLine("The animal physical descriptions are complete");
                        readResult = Console.ReadLine();
                        break;

                    case "5":
                        parsePet.EditCompleteAge(pet, repository);
                        Console.WriteLine("The animal age is complete");
                        readResult = Console.ReadLine();
                        break;

                    case "6":

                        break;

                    case "7":

                        break;

                    case "8":

                        break;

                    default:

                        break;
                }

            } while (menuSelection != "exit");
        }
    }
}

/*
string animalSpecies;

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
 }
*/