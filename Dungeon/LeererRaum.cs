namespace Dungeon;

public class LeererRaum :ARaum
{
    public string Beschreibung { get; set; }
    public override void Betreten(Welt welt, Held held)
    {
        Console.WriteLine($"{Beschreibung}");
        held.Standort = this;
    }
}