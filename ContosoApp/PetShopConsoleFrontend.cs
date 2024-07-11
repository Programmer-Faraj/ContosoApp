namespace ContosoApp;

public sealed class PetShopConsoleFrontend
{
    public void CreatePet(Pet pet)
    {
        string readResult;
        bool validEntry = false;
        int petAge;

        // Prompt the user to enter the following animal species a dog, cat, rabbit
        do
        {
            Console.WriteLine("\n\rEnter 'dog' or 'cat' or 'rabbit' to begin a new entry");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                pet.AnimalSpecies = readResult.ToLower();
                TODO_Refactor.MakePet(ref validEntry, readResult);
                //validEntry = pet.AnimalSpecies == "dog" || pet.AnimalSpecies == "cat" || pet.AnimalSpecies == "rabbit";
            }

        } while (validEntry == false);

        // get the pet's age. can be ? at initial entry.
        do
        {
            Console.WriteLine("Enter the pet's age or enter ? if unknown");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                pet.AnimalAge = readResult;
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

        // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
        do
        {
            Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, houebroken): ");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                pet.AnimalPhysicalDescription = readResult.ToLower();
                if (pet.AnimalPhysicalDescription == "")
                {
                    pet.AnimalPhysicalDescription = "tbd";
                }
            }

        } while (pet.AnimalPhysicalDescription == "");

        // get a description of the pet's personality - animalPersonalityDescription can be blank.
        do
        {
            Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                pet.AnimalPersonalityDescription = readResult.ToLower();
                if (pet.AnimalPersonalityDescription == "")
                {
                    pet.AnimalPersonalityDescription = "tbd";
                }
            }

        } while (pet.AnimalPersonalityDescription == "");

        // get the pet's nickname. animalNickname can be blank.
        do
        {
            // User input for nickname
            Console.WriteLine("Enter a nickname for the pet");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                pet.AnimalNickname = readResult.ToLower();
                if (pet.AnimalNickname == "")
                {
                    pet.AnimalNickname = "tbd";
                }
            }

        } while (pet.AnimalNickname == "");
    }

    public void DisplayPetInformation(Pet pet)
        => Console.WriteLine(pet.ToString());

    public void EditCompleteAge(Pet age, PetsRepository petRepository)
    {
        string readResult;
        bool validEntry = false;
        int petAge;

        do
        {
            Console.WriteLine("Enter pet ID: ");
            readResult = Console.ReadLine();
            // deleted the extra pet object
            petRepository.FindPetById(readResult);

            Console.WriteLine("Complete pet age: ");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                age.AnimalAge = readResult;

                if (age.AnimalAge == null || age.AnimalAge == "?")
                {
                    validEntry = int.TryParse(age.AnimalAge, out petAge);
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
