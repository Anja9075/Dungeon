using Dungeon;
/*
Welt rj = new Welt("zist");
Held nw = new Held("harry", 102);
/*
rj.Erschaffen();
rj.Enter(nw);
string me;

do

{
    Console.WriteLine("geben sie eine Richtung an - Norden, Osten, Süden, Westen und Ende");
    me = Console.ReadLine();
    nw.Move(richtung);
    
}while(me.ToLower()!="ende");
*/
Gamecontroller spiel = new Gamecontroller();
spiel.Run();

