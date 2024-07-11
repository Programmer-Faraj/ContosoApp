namespace ContosoApp;

public sealed class PetManager
{
    string? readResult = "";
    bool validEntry = false;
    int petAge = 0;

    // Defining a method that creates animal species
    public void CreatePet(Pet pet)
    {
        // Prompt the user to enter the following animal species a dog, cat, rabbit
        do
        {
            Console.WriteLine("\n\rEnter 'dog' or 'cat' or 'rabbit' to begin a new entry");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                pet.AnimalSpecies = readResult.ToLower();
                MakePet();
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

    // Defining a method to take user input for physical description if it's left empty

    /****** soon *******/

    public PetsRepository EditCompleteAge(Pet age, PetsRepository petRepository)
    {
        // Searching for a specific pet by ID
        //PetsRepository petRepository = new PetsRepository();

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
                    validEntry = int.TryParse(age.AnimalAge, out petAge); // Modified
                }

                else
                {
                    validEntry = true;
                }
            }

            return petRepository;

        } while (validEntry == false);

        /* do
         {
             Console.WriteLine("Complete pet age: ");
             readResult= Console.ReadLine();

             if (readResult != null)
             {
                 validEntry = int.TryParse(readResult, out petAge);
             }

         } while (validEntry == false);*/
    }

    public void MakePet()
    {
        var allowedSpecies = new[] { "dog", "cat", "rabbit" };
        validEntry = allowedSpecies.Contains(readResult);
    }
}

/*
// Defining a method that creates animal species
    public void CreatePet()
    {
        string? animalSpecies = "";
        string? animalAge = "";
        string? animalPhysicalDescription = "";
        string? animalPersonalityDescription = "";
        string? animalNickname = "";

        // Prompt the user to enter the following animal species a dog, cat, rabbit
        do
        {
            Console.WriteLine("\n\rEnter 'dog' or 'cat' or 'rabbit' to begin a new entry");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                animalSpecies = readResult.ToLower();
                if (animalSpecies != "dog" && animalSpecies != "cat" && animalSpecies != "rabbit")
                {
                    validEntry = false;
                }
                else
                {
                    validEntry = true;
                }
            }

        } while (validEntry == false);

        // get the pet's age. can be ? at initial entry.
        do
        {
            Console.WriteLine("Enter the pet's age or enter ? if unknown");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                animalAge = readResult;
                if (animalAge != "?")
                {
                    validEntry = int.TryParse(animalAge, out petAge);
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
                animalPhysicalDescription = readResult.ToLower();
                if (animalPhysicalDescription == "")
                {
                    animalPhysicalDescription = "tbd";
                }
            }

        } while (animalPhysicalDescription == "");

        // get a description of the pet's personality - animalPersonalityDescription can be blank.
        do
        {
            Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                animalPersonalityDescription = readResult.ToLower();
                if (animalPersonalityDescription == "")
                {
                    animalPersonalityDescription = "tbd";
                }
            }

        } while (animalPersonalityDescription == "");

        // get the pet's nickname. animalNickname can be blank.
        do
        {
            // User input for nickname
            Console.WriteLine("Enter a nickname for the pet");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                animalNickname = readResult.ToLower();
                if (animalNickname == "")
                {
                    animalNickname = "tbd";
                }
            }

        } while (animalNickname == "");
        Pet pet = new Pet(animalSpecies, animalAge, animalPhysicalDescription, animalPersonalityDescription, animalNickname);
    }

    public void CompletePetAge()
    {

    }


    // Defining a method to take user input for physical description if it's left empty
    public PetsRepository EditCompleteDescriptions()
    {
        do
        {
            Console.WriteLine("Enter pet ID: ");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                validEntry = int.TryParse(readResult, out petAge);
            }

            PetsRepository petID = new PetsRepository();
            foreach (var ID in petID.GetAllID())
            {
                if (readResult == ID)
                {
                    Console.WriteLine($"The animal ID is: {ID}");
                    return petID;
                }
            }
            return null;

        } while (validEntry == false);
    }
*/