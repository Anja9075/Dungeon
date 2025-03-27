namespace Dungeon;

public class Zeilraum :ARaum
{
    public override void Betreten(Welt welt, Held held)
    {
        Console.WriteLine($"Ausgang erreicht");
        Console.WriteLine($"Glückwunsch {held.Name}");
        Console.WriteLine($"Welt: {welt} - Ziel erreicht");
        held.Standort = this;
    }
}