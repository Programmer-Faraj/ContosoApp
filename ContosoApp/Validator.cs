namespace ContosoApp;

public sealed class Validator
{
    static readonly private string[] AllowedSpecies = new[] { "dog", "cat", "rabbit" };

    public static bool IsValidSpecies(string readResult)
        => AllowedSpecies.Contains(readResult);
}
