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
        held.Standort = this;
        if (held.Leben > Schaden)
        {
            held.Leben -= Schaden;
            Console.WriteLine($"FALLE! {held.Name} nimmt {Schaden} Schaden");
            if (held.Leben <= Schaden)
            {
                Console.WriteLine($"{held.Name} du bist tot!");
            }
        }
        else
        {
            Console.WriteLine("Spieler hat bereits keine Lebenspunkte mehr!");
        }
      
      
    }
    
}