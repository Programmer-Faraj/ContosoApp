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
                TODO_Refactor.MakePet(ref validEntry, readResult);
                //validEntry = pet.AnimalSpecies == "dog" || pet.AnimalSpecies == "cat" || pet.AnimalSpecies == "rabbit";
            }

        } while (validEntry == false);

        // get the pet's age. can be ? at initial entry.
        do
        {
            int petAge;
            Console.WriteLine("Enter the pet's age or enter ? if unknown");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                newPet.AnimalAge = readResult;
                if (newPet.AnimalAge != "?")
                {
                    validEntry = int.TryParse(newPet.AnimalAge, out petAge);
                }
                else
                {
                    validEntry = true;
                }
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

    public void EditCompleteAge(Pet age)
    {
        string readResult;
        bool validEntry = false;

        do
        {
            Console.WriteLine("Enter pet ID: ");
            readResult = Console.ReadLine();
            // deleted the extra pet object
            //UNDONE petRepository.FindPetById(readResult);

            Console.WriteLine("Complete pet age: ");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                age.AnimalAge = readResult;

                if (age.AnimalAge == null || age.AnimalAge == "?")
                {
                    validEntry = int.TryParse(age.AnimalAge, out var petAge);
                }

                else
                {
                    validEntry = true;
                }
            }
        } while (validEntry == false);
    }

    public void ProvideUserAllItems(IEnumerable<Pet> animals)
    {
        foreach (var animal in animals)
        {
            DisplayPetInformation(animal);
        }
    }
}
