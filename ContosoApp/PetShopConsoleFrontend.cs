namespace ContosoApp;

public sealed class PetShopConsoleFrontend
{
    public Pet CreatePet()
    {
        string readResult;
        bool validEntry = false;
        var newPet = new Pet();

        do
        {
            Console.WriteLine("\n\rEnter 'dog' or 'cat' or 'rabbit' to begin a new entry");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                newPet.AnimalSpecies = readResult.ToLower();
                validEntry = Validator.IsValidSpecies(readResult);
            }
        } while (validEntry == false);

        // get the pet's age. can be ? at initial entry.
        do
        {
            Console.WriteLine("Enter the pet's age or enter ? if unknown");
            readResult = Console.ReadLine();

            if (readResult == null)
            {
                continue;
            }

            switch (readResult)
            {
                case "?":
                    newPet.AnimalAge = null;
                    validEntry = true;
                    break;

                case string when int.TryParse(readResult, out var petAge):
                    newPet.AnimalAge = petAge;
                    validEntry = true;
                    break;
            }
        } while (validEntry == false);

        // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
        do
        {
            Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, houebroken): ");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                newPet.AnimalPhysicalDescription = readResult.ToLower();
                if (newPet.AnimalPhysicalDescription == "")
                {
                    newPet.AnimalPhysicalDescription = "tbd";
                }
            }

        } while (newPet.AnimalPhysicalDescription == "");

        // get a description of the pet's personality - animalPersonalityDescription can be blank.
        do
        {
            Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                newPet.AnimalPersonalityDescription = readResult.ToLower();
                if (newPet.AnimalPersonalityDescription == "")
                {
                    newPet.AnimalPersonalityDescription = "tbd";
                }
            }

        } while (newPet.AnimalPersonalityDescription == "");

        // get the pet's nickname. animalNickname can be blank.
        do
        {
            // User input for nickname
            Console.WriteLine("Enter a nickname for the pet");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                newPet.AnimalNickname = readResult.ToLower();
                if (newPet.AnimalNickname == "")
                {
                    newPet.AnimalNickname = "tbd";
                }
            }

        } while (newPet.AnimalNickname == "");

        return newPet;
    }

    public void DisplayPetInformation(Pet pet)
        => Console.WriteLine(pet.ToString());

    public Guid FindPetById()
    {
        Guid parsed;
        string readResult;

        do
        {
            Console.WriteLine("Enter pet ID: ");
            readResult = Console.ReadLine();
        } while (Guid.TryParse(readResult, out parsed) == false);

        return Guid.Parse(readResult);
    }

    public void ProvideUserAllItems(IEnumerable<Pet> animals)
    {
        foreach (var animal in animals)
        {
            DisplayPetInformation(animal);
        }
    }

    public int? UpdateAge(Pet pet)
    {
        Console.WriteLine($"Complete age for pet '{pet.AnimalNickname}': ");

        int? newAge = null;
        bool valid = false;

        do
        {
            var readResult = Console.ReadLine();

            switch (readResult)
            {
                case null:
                case "?":
                    newAge = null;
                    valid = true;
                    break;

                case string when int.TryParse(readResult, out var petAge):
                    newAge = petAge;
                    valid = true;
                    break;
            }
        }
        while (false == valid);

        return newAge;
    }
}
