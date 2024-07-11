namespace ContosoApp;

public sealed class PetsRepository //: IEnumerable<KeyValuePair<Guid, Pet>>
{
    private readonly Dictionary<Guid, Pet> _petsStorage = new Dictionary<Guid, Pet>();

    public void AddPet(Pet pet)
    {
        _petsStorage.Add(Guid.NewGuid(), pet);
    }

    public void FindPetById(string petId)
    {
        foreach (var id in _petsStorage.Keys)
        {
            if (id.ToString() != petId)
            {
                continue;
            }

            // UNDONE
        }
    }

    public IEnumerable<Pet> GetAllPets()
        => _petsStorage.Values;
}
