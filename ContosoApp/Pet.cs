namespace ContosoApp;

public sealed class Pet
{
    public int? AnimalAge { get; set; }
    public string? AnimalId { get; set; }
    public string? AnimalNickname { get; set; }
    public string? AnimalPersonalityDescription { get; set; }
    public string? AnimalPhysicalDescription { get; set; }
    public string? AnimalSpecies { get; set; }

    public override string ToString()
        => $"{AnimalId} {AnimalSpecies} {AnimalAge} {AnimalPhysicalDescription} {AnimalPersonalityDescription} {AnimalNickname}";
}
