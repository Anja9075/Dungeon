using System.IO.Compression;
using Dungeon;
using Microsoft.VisualBasic.CompilerServices;

Welt rj = new Welt("zist");
Held nw = new Held("harry", 102);
rj.Erschaffen();
rj.Enter(nw);
string me;

do

{
    Console.WriteLine("geben sie eine Richtung an - Norden, Osten, Süden, Westen und Ende");
    me = Console.ReadLine();
    nw.Bewegen(me);
    
}while(me.ToLower()!="ende");
