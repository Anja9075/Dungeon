namespace Dungeon;

public class StartRaum : ARaum
{
    
    public override void Betreten(Welt welt, Held held)
    {
        held.Standort = this;
        Console.WriteLine($"Hallo {held} - Willkommen in der Welt {welt}");
        
    }
}