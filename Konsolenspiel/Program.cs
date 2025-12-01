using System;

namespace Konsolengame
{
    class Program
    {
        static void Main(string[] args)
        {
            Hilfsmethoden.Begrüßung();
            Spieler spieler = Hilfsmethoden.Charakterwahl();
            Console.WriteLine($"Du hast {spieler.Beschreibung} gewählt. Deine Stats sind:\n Charisma:{spieler.Charisma}");
            spieler.ItemHinzufügen(Items.Kristall);
            spieler.InventarAnzeigen();
        }
    }
}