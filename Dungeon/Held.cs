namespace Dungeon;

public class Held
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

    public void Bewegen(string richtung)
    {
        ARaum neu = null;
        switch (richtung)
        {
            case "Norden":
                neu = Standort.Norden;
                break;
            case "Osten":
                neu = Standort.Osten;
                break;
            case "Süden":
                neu = Standort.Süden;
                break;
            case "Westen":
                neu = Standort.Westen;
                break;
            case "Ende":
                Console.WriteLine("Welt Beendet");
                break;
            default: Console.WriteLine("Falsche Richtung"); return;
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
}