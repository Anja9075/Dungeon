using System.IO.Compression;
using System.Security.Cryptography;

namespace Dungeon;

public class Welt
{
    public string Name { get; private set; }

    public ARaum StartRaum { get; set; } = new StartRaum();
    
    private Zeilraum zielraum { get; set; }
    
    

    bool IsExit(ARaum raum)
    {
        if (raum == zielraum)
        {
            return true;
        }

        return false;
    }
    

    public void Erschaffen()
    {
        LeererRaum leer1 = new LeererRaum();
        LeererRaum leer2 = new LeererRaum();
        LeererRaum leer3 = new LeererRaum();
        FallenRaum falle1 = new FallenRaum(20);
        FallenRaum falle2 = new FallenRaum(30);
        Zeilraum ziel = new Zeilraum();
        zielraum = ziel;
        Schatzraum schatzraum1 = new Schatzraum(Schatzraum.ESchätze.EKrone);
        Schatzraum schatzraum2 = new Schatzraum(Schatzraum.ESchätze.ETrank);
        
        //Räume verbinden
        StartRaum.Norden = leer1;
        leer1.Süden = StartRaum;
        leer1.Norden = falle1;
        leer1.Osten = leer2;
        leer2.Westen = leer1;
        leer2.Norden = leer3;
        leer2.Osten = schatzraum2;
        schatzraum2.Westen = leer2;
        leer2.Süden = schatzraum1;
        schatzraum1.Norden = leer2;
        falle1.Osten = leer3;
        falle1.Süden = leer1;
        leer3.Westen = falle1;
        leer3.Norden = falle2;
        leer3.Osten = ziel;
        leer3.Süden = leer2;
        falle2.Süden = leer3;
        ziel.Westen = leer3;
        
    }

    public void Enter(Held held)
    {
        held.welt = this;
        StartRaum.Betreten(this, held);
    }
}