namespace ContosoApp;

public sealed class PetsRepository //: IEnumerable<KeyValuePair<Guid, Pet>>
{
    // Defining a dictionary to store the animal and its attributes data.
    private Dictionary<Guid, Pet> _petsStorage;

    public PetsRepository()
    {
        _petsStorage = new Dictionary<Guid, Pet>();
    }

    public void AddPet(Pet pet)
    {
        //string animalID = GetNextID().ToString();
        _petsStorage.Add(Guid.NewGuid(), pet);
    }

    // The business logic
    // Defining a method that is resposible mplementing for searching and finding pets by ID
    public void FindPetById(string petId)
    {
    //PetsRepository petID = new PetsRepository();
        foreach (var ID in _petsStorage.Keys)
        {
            if (ID.ToString() == petId)
            {
                Console.WriteLine($"The animal ID is: {petId}");
            }
        }
    }

    public IEnumerable<Pet> GetAllPets()
        => _petsStorage.Values;
}

/*public int GetNextID()
{
// Generating an ID for the animals
Guid IDnumber = new Guid();
int generatedNumber = IDnumber;
return generatedNumber;
}*/
/*Random IDnumber = Random.Shared;
int generatedNumber = IDnumber.Next(100, 1000);

return generatedNumber;*/

/*string animalID = GetNextID().ToString();
ourPets?.Add(animalID, pet);*/