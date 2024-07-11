namespace ContosoApp;

public sealed class PetsRepository
{
    private readonly Dictionary<Guid, Pet> _petsStorage = new();

    public void AddPet(Pet pet)
    {
        _petsStorage.Add(Guid.NewGuid(), pet);
    }

    public Pet? FindPetById(Guid petId)
    {
        _petsStorage.TryGetValue(petId, out Pet? pet);
        return pet;
    }

    public IEnumerable<Pet> GetAllPets()
        => _petsStorage.Values;

    public void UpdatePet(Guid petId, int? age)
    {
        if (false == _petsStorage.TryGetValue(petId, out Pet? pet))
            throw new ArgumentException("Pet not found", nameof(petId));

        pet.AnimalAge = age.ToString();
    }
}
