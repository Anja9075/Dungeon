namespace Dungeon;

public class FallenRaum : ARaum
{
    public FallenRaum(int schaden)
    {
        Schaden = schaden;
    }
    public int Schaden { get; set; }
    public override void Betreten(Welt welt, Held held)
    {
        if (held.Leben > Schaden)
        {
            held.Leben -= Schaden;
        }
        Console.WriteLine($"FALLE! {held.Name} nimmt {Schaden} Schaden");
        held.Standort = this;
    }
}