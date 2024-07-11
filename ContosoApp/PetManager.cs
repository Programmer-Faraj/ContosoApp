namespace ContosoApp;

public sealed class PetManager
{
    static readonly string[] allowedSpecies = new[] { "dog", "cat", "rabbit" };

    public static void MakePet(ref bool validEntry, string readResult)
    {
        validEntry = allowedSpecies.Contains(readResult);
    }
}
