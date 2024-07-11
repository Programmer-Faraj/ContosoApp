namespace ContosoApp;

public sealed class PetShopProgram
{
    private readonly NewBusinessLogic _allPets;
    private readonly PetManager _parsePet = new PetManager();
    private string? _menuSelection = "";
    private Pet _pet = new Pet();
    private readonly DisplayPets _pets = new DisplayPets();
    private string _readResult;
    private readonly PetsRepository _repository = new PetsRepository();

    public PetShopProgram()
    {
        _allPets = new NewBusinessLogic(_repository, _pets);
    }

    public void Run()
    {
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

            _readResult = Console.ReadLine();
            if (_readResult != null)
            {
                _menuSelection = _readResult.ToLower();
                // NOTE: We could put a do statement around the menuSelection entry to ensure a valid entry, but we
                //  use a conditional statement below that only processes the valid entry values, so the do statement
                //  is not required here.
            }

            // use switch-case to process the selected menu option
            switch (_menuSelection)
            {
                case "1":
                    _allPets.ProvideUserAllItems();
                    Console.WriteLine("Press the Enter key to continue.");
                    _readResult = Console.ReadLine();
                    break;

                case "2":
                    _repository.AddPet(_pet);
                    _parsePet.CreatePet(_pet);
                    Console.WriteLine("Press the Enter key to continue.");
                    _readResult = Console.ReadLine();
                    break;

                case "3":

                    break;

                case "4":

                    Console.WriteLine("The animal physical descriptions are complete");
                    _readResult = Console.ReadLine();
                    break;

                case "5":
                    _parsePet.EditCompleteAge(_pet, _repository);
                    Console.WriteLine("The animal age is complete");
                    _readResult = Console.ReadLine();
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

        } while (_menuSelection != "exit");
    }
}
