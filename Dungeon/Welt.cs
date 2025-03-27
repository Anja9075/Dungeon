using System.Security.Cryptography;

namespace Dungeon;

public class Welt
{
    public string Name { get; private set; }

    public ARaum StartRaum { get;private set; }
    
    public Welt welt { get; private set; }

    public Welt(string name)
    {
        Name = name;
    }
    

    public void Erschaffen()
    {
        StartRaum = new StartRaum();
        LeererRaum leer1 = new LeererRaum();
        LeererRaum leer2 = new LeererRaum();
        LeererRaum leer3 = new LeererRaum();
        Zeilraum ziel = new Zeilraum();
        FallenRaum fallen = new FallenRaum(20);
        FallenRaum fallen2 = new FallenRaum(30);
        
        //Räume verbinden
        StartRaum.Norden = leer1;
        leer1.Süden = StartRaum;
        leer1.Norden = fallen;
        fallen.Süden = leer1;
        fallen.Osten = leer3;
        leer3.Westen = fallen;
        leer3.Norden = fallen2;
        fallen2.Süden = leer3;
        leer3.Osten = ziel;
        ziel.Westen = leer3;
        leer3.Süden = leer2;
        leer2.Norden = leer3;
        leer2.Westen = leer1;
        leer1.Osten = leer2;










    }

    public void Enter(Held held)
    {
        held.welt = this;
        StartRaum.Betreten(this, held);
    }
}