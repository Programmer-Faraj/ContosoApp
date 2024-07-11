using c_fundamentalsPracticeProject;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_fundamentalsPracticeProject
{
    internal class PetManager 
    {
        private const int maxPets = 8;
        private string? readResult;
        private string[,] ourAnimals = new string[maxPets, 6];
        private string menuSelection = "";
        private string anotherPet = "y";
        private int petAge = 0;
        private int petCount = 0;
        private bool validEntry = false;

        public void AddPet()
        {
            Pet pet = new Pet();

            // create some initial ourAnimals array entries
            for (int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:
                        pet.AnimalSpecies = "dog";
                        pet.AnimalID = "d1";
                        pet.AnimalAge = "2";
                        pet.AnimalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                        pet.AnimalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        pet.AnimalNickname = "lola";
                        break;

                    case 1:
                        pet.AnimalSpecies = "dog";
                        pet.AnimalID = "d2";
                        pet.AnimalAge = "9";
                        pet.AnimalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        pet.AnimalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        pet.AnimalNickname = "loki";
                        break;

                    case 2:
                        pet.AnimalSpecies = "cat";
                        pet.AnimalID = "c3";
                        pet.AnimalAge = "1";
                        pet.AnimalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        pet.AnimalPersonalityDescription = "friendly";
                        pet.AnimalNickname = "Puss";
                        break;

                    case 3:
                        pet.AnimalSpecies = "cat";
                        pet.AnimalID = "c4";
                        pet.AnimalAge = "3";
                        pet.AnimalPhysicalDescription = "Midium grey male weighing about 9 pounds. litter box trained"; /*"Midium grey male weighing about 9 pounds. litter box trained"*/
                        pet.AnimalPersonalityDescription = "Social";
                        pet.AnimalNickname = "Milton";
                        break;

                    default:
                        pet.AnimalSpecies = "";
                        pet.AnimalID = "";
                        pet.AnimalAge = "";
                        pet.AnimalPhysicalDescription = "";
                        pet.AnimalPersonalityDescription = "";
                        pet.AnimalNickname = "";
                        break;
                }

                ourAnimals[i, 0] = "ID #: " + pet.AnimalID;
                ourAnimals[i, 1] = "Species: " + pet.AnimalSpecies;
                ourAnimals[i, 2] = "Age: " + pet.AnimalAge;
                ourAnimals[i, 3] = "Nickname: " + pet.AnimalNickname;
                ourAnimals[i, 4] = "Physical description: " + pet.AnimalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + pet.AnimalPersonalityDescription;
            }
        }

        public void DisplayPet()
        {
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j].ToString());
                    }
                }
            }
        }

        public void AddNewPet()
        {
            Pet pet = new Pet();
            // You can directly access properties of the 'pet' parameter
            // the ourAnimals array will store the following: 

            // Add a new animal friend to the ourAnimals array
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                // get species (cat or dog) - string animalSpecies is a required field 
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        pet.AnimalSpecies = readResult.ToLower();
                        if (pet.AnimalSpecies != "dog" && pet.AnimalSpecies != "cat")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                pet.AnimalID = pet.AnimalSpecies.Substring(0, 1) + (petCount + 1).ToString();

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

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + pet.AnimalID;
                ourAnimals[petCount, 1] = "Species: " + pet.AnimalSpecies;
                ourAnimals[petCount, 2] = "Age: " + pet.AnimalAge;
                ourAnimals[petCount, 3] = "Nickname: " + pet.AnimalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + pet.AnimalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + pet.AnimalPersonalityDescription;

                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
            }
        }

        public void CompleteAgePhysicalDescriptions()
        {
            Pet pet = new Pet();

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 2] == "Age: ?" && ourAnimals[i, 0] != "ID #: ")
                {
                    do
                    {
                        Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            pet.AnimalAge = readResult;
                            validEntry = int.TryParse(pet.AnimalAge, out petAge);
                        }
                    } while (validEntry == false);
                    ourAnimals[i, 2] = "Age: " + pet.AnimalAge.ToString();
                }

                if (ourAnimals[i, 4] == "Physical description: tbd" && ourAnimals[i, 0] != "ID #: ")
                {
                    do
                    {
                        Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, gender, weight, housebroken)");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            pet.AnimalPhysicalDescription = readResult.ToLower();
                            if (pet.AnimalPhysicalDescription == "")
                            {
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;
                            }

                        }
                    } while (validEntry == false);

                    ourAnimals[i, 4] = "Physical description: " + pet.AnimalPhysicalDescription;
                }
            }
        }

        public void CompleteNicknamesPersonalityDescriptions()
        {
            Pet pet = new Pet();

            // Ensure animal nicknames and personality descriptions are complete
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 3] == "Nickname: tbd" && ourAnimals[i, 0] != "ID #: ")
                {
                    do
                    {
                        Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            pet.AnimalNickname = readResult.ToLower().Trim();
                            if (pet.AnimalNickname == "")
                            {
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                        ourAnimals[i, 3] = "Nickname: " + pet.AnimalNickname;

                    } while (validEntry == false);
                }

                if (ourAnimals[i, 5] == "Personality: tbd" && ourAnimals[i, 0] != "ID #: ")
                {
                    do
                    {
                        Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            pet.AnimalPersonalityDescription = readResult.ToLower().Trim();
                            if (pet.AnimalPersonalityDescription == "")
                            {
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                        ourAnimals[i, 5] = "Personality: " + pet.AnimalPersonalityDescription;

                    } while (validEntry == false);
                }
            }
        }

        public void EditAnimalAgeDescription(string? animalID)
        {
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: " && ourAnimals[i, 0] == "ID #: " + animalID)
                {
                    do
                    {
                        Console.WriteLine($"Edit {ourAnimals[i, 0]}'s age: ");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            petAge = 0;
                            if (int.TryParse(readResult, out petAge))
                            {
                                ourAnimals[i, 2] = "Age: " + readResult;
                            }
                            else
                            {
                                Console.WriteLine("Invalid age format. Please enter a valid age.");
                            }
                        }
                    } while (petAge <= 0);
                    return;
                }
            }
            Console.WriteLine("No pet found with the specified ID.");
        }

        public Pet FindPetById(string? animalID)
        {
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: " && ourAnimals[i, 0] == "ID #: " + animalID)
                {
                    Pet pet = new Pet();
                    // Populate pet's properties from ourAnimals
                    pet.AnimalID = ourAnimals[i, 0];
                    // Set other properties accordingly
                    return pet;
                }
            }
            return null;
        }

        /*public void EditAnimalAgeDescription(Pet pet)
        {
            // Edit an animal’s age");
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 2] == "Age: " + pet.AnimalAge && ourAnimals[i, 0] != "ID #: ")
                {
                    do
                    {
                        Console.WriteLine($"Edit animal's age {ourAnimals[i, 0]}");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            pet.AnimalAge = readResult.ToLower().Trim();
                            validEntry = int.TryParse(pet.AnimalAge, out petAge);
                        }

                    } while (validEntry == false);
                    ourAnimals[i, 2] = "Age: " + pet.AnimalAge;
                }
            }
        }

        public Pet FindPetById(string? animalID)
        { 
            Pet pet = new Pet();
            for (int i = 0; i < maxPets; i++) 
            {
                if (ourAnimals[i, 0] != "ID #: " && animalID != null && animalID == pet.AnimalID)
                {
                    return pet;
                }
            }
            return null;
        }*/

        public void EditAnimalPersonalityDescription()
        {
            Pet pet = new Pet();
            pet.AnimalPersonalityDescription = pet.AnimalPersonalityDescription;

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 5] == "Personality: " + pet.AnimalPersonalityDescription && ourAnimals[i, 0] != "ID #: ")
                {
                    do
                    {
                        Console.WriteLine($"Edit animal's personality description {ourAnimals[i, 0]}");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            pet.AnimalPersonalityDescription = readResult.ToLower().Trim();
                            if (pet.AnimalPersonalityDescription == "")
                            {
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                        ourAnimals[i, 5] = "Personality: " + pet.AnimalPersonalityDescription;

                    } while (validEntry == false);
                }
            }
        }

        public void DisplaySpecifiedPhysicalPersonalForCat()
        {
            Console.WriteLine("Enter specified physical characteristic for cats: ");
            readResult = Console.ReadLine();

            validEntry = false;

            if (readResult != null)
            {
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 1] == "Species: cat")
                    {
                        if (ourAnimals[i, 4].Contains(readResult))
                        {
                            Console.WriteLine($"Cat ID: {ourAnimals[i, 0]}, Physical Characteristic: {readResult}");
                            validEntry = true;
                        }
                    }
                }
            }

            if (!validEntry)
            {
                Console.WriteLine("No cats found with the specified physical characteristic.");
            }

            Console.WriteLine("Enter specified personal characteristic for cats: ");
            readResult = Console.ReadLine();

            validEntry = false;

            if (readResult != null)
            {
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 1] == "Species: cat")
                    {
                        if (ourAnimals[i, 5].Contains(readResult))
                        {
                            Console.WriteLine($"Cat ID: {ourAnimals[i, 0]}, Personal Characteristic: {readResult}");
                            validEntry = true;
                        }
                    }
                }
            }

            if (!validEntry)
            {
                Console.WriteLine("No cats found with the specified personal Characteristic!");
            }
        }

        public void DisplaySpecifiedPhysicalPersonalForDog()
        {
            Console.WriteLine("Enter specified physical characteristic for a dog: ");
            readResult = Console.ReadLine();

            validEntry = false;

            if (readResult != null)
            {
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 1] == "Species: dog")
                    {
                        if (ourAnimals[i, 4].Contains(readResult))
                        {
                            Console.WriteLine($"Dog ID: {ourAnimals[i, 0]}, Physical Characteristic: {readResult}");
                            validEntry = true;
                        }
                    }
                }
            }

            if (!validEntry)
            {
                Console.WriteLine("No dogs found with the specified physical characteristic.");
            }

            Console.WriteLine("Enter specified personal characteristic for a dog: ");
            readResult = Console.ReadLine();

            validEntry = false;

            if (readResult != null)
            {
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 1] == "Species: dog")
                    {
                        if (ourAnimals[i, 5].Contains(readResult))
                        {
                            Console.WriteLine($"Dog ID: {ourAnimals[i, 0]}, Personal Characteristic: {readResult}");
                            validEntry = true;
                        }
                    }
                }
            }
            if (!validEntry)
            {
                Console.WriteLine("No dogs found with the specified personal characteristic.");
            }
        }
    }
}
