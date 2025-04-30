namespace Dungeon;

public class Schatzraum : ARaum
{
    public enum ESchätze
    {
        ENone,
        EKrone,
        ETrank
        
    }
    
    
    public ESchätze Schatz { get; set; }
   

    public Schatzraum(ESchätze schatz)
    {
        Schatz = schatz;
    }

    public override void Betreten(Welt welt, Held held)
    {
        held.Standort = this;

        if (Schatz == ESchätze.ENone)
        {
            Console.WriteLine("Schatzraum wurde ausgeraubt");
            Console.WriteLine("Kein Schatz mehr vorhanden");
        }
        else
        {
            held.Rucksack.Add(Schatz); //der held hat einen Rucksack welchen er mithilfe von "Add" befüllt -- Schatz
            Console.WriteLine("Schatz gehört dir");
            Schatz = ESchätze.ENone;
        }
    }
    
}