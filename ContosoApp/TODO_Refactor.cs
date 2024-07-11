namespace ContosoApp;

public sealed class TODO_Refactor
{
    static readonly string[] allowedSpecies = new[] { "dog", "cat", "rabbit" };

    public static void MakePet(ref bool validEntry, string readResult)
    {
        validEntry = allowedSpecies.Contains(readResult);
    }
}
