namespace Dungeon;

public class Held : IMoveable
{
    public string Name{get;set;}
    public int Leben { get; set; }
    public ARaum Standort { get; set; }
    public Welt welt { get; set; }

    public Held(string name, int leben)
    {
        this.Name = name;
        this.Leben = leben;
    }

    public void Move(ERichtungen richtung)
    {
        ARaum neu = null;
        switch (richtung)
        {
            case ERichtungen.EVorne:
                Standort.Norden?.Betreten(welt,this); // ? prüft ob Norden null ist und wenn ja dann führt er es gar nicht erst aus
                break;
            case ERichtungen.ELinks:
                Standort.Westen?.Betreten(welt,this);
                break;
            case ERichtungen.EZurück:
                Standort.Süden?.Betreten(welt,this);
                break;
            case ERichtungen.ERechts:
                Standort.Osten?.Betreten(welt,this);
                break;
            default:
                Console.WriteLine("Welt Beendet");
                Console.WriteLine("Falsche Richtung"); return;
                
        }

        if (neu != null)
        {
            neu.Betreten(welt, this);
            Standort = neu;
        }
        else
        {
            Console.WriteLine("Wand");
        }
    }
    
    public List<Schatzraum.ESchätze>Rucksack { get; set; }
    
    bool IsAlive()
    {
        if (Leben >= 0)
        {
            Console.WriteLine("Spieler ist Tot");
            return true;
        }
        else
        {
            return false;
        }
    }
}