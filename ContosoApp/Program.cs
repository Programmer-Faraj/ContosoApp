// See https://aka.ms/new-console-template for more information
namespace ContosoApp;

class Program
{
    public static void Main(string[] args)
    {
        var psp = new PetShopProgram();
        psp.Run();
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
/
 return true;
}
*/