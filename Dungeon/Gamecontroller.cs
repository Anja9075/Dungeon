namespace Dungeon;

public class Gamecontroller
{
    public Welt Welt { get; set; }
    
    public Held Held { get; set; }

    public Gamecontroller()
    {
        Welt = new Welt();
        Held = new Held("harry", 120);
        Console.WriteLine($"Spiel startet im {Welt.StartRaum}");
        Welt.Enter(Held);
        Welt.Erschaffen();
    }
    public Gamecontroller(Welt wet, Held mänchen)
    {
        Welt = wet;
        Held = mänchen;
        Console.WriteLine($"Spiel startet im {Welt.StartRaum}");
        Welt.Enter(Held);
    }

    public void Run()
    {
        ConsoleKeyInfo key;
        key = Console.ReadKey();
        string eingabe;
        //zyklisch = schleife
        do
        {
            Console.WriteLine("In welche Richtung möchtest du gehen?");
            Console.WriteLine("Norden - W; Osten - D; Süden - S; Westen - A");
            Console.WriteLine("Oder aufgeben mit Z");
            eingabe = Console.ReadLine();

            if (key.Key == ConsoleKey.W)
            {
                // ConsoleKEy ist Enum 
                Held.Move(IMoveable.ERichtungen.EVorne);
                
            }
            else if (key.Key == ConsoleKey.D)
            {
                Held.Move(IMoveable.ERichtungen.ERechts);
            }
            else if (key.Key == ConsoleKey.S)
            {
                Held.Move(IMoveable.ERichtungen.EZurück);
            }
            else if (key.Key == ConsoleKey.A)
            {
                Held.Move(IMoveable.ERichtungen.ELinks);
            }
            else if (key.Key == ConsoleKey.Z)
            {
                Held.Move(IMoveable.ERichtungen.EZurück);
            }

        } while (eingabe != "Zrück");

    }
    
}