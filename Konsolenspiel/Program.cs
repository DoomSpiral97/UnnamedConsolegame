using System;
namespace Konsolengame
{ class Program
    {
        static void Main(string[] args)
        {
            bool spielLaeuft = true;

            Hilfsmethoden.Begrüßung();
            Spieler spieler = Hilfsmethoden.Charakterwahl();

            

            while (spielLaeuft)
            {

                string? eingabe = Hilfsmethoden.Questboard();

                switch (eingabe)
                {
                    case "1":
                    {
                        Quests.WaldQuest(spieler);
                        break;
                    }

                    case "2":
                    {
                        Quests.WaldQuest(spieler);
                        break;
                    }
                    case "3":
                    {
                       Quests.RuinenQuest(spieler);
                       break;
                    }
                    case "4":
                    {
                        Quests.DrachenQuest(spieler);
                        break;
                    }

                    case "I":
                    {spieler.InventarAnzeigen();
                        break;
                    }
                    case "6":
                        StadtErkunden.Start(spieler);
                        break;
                    case "0":
                        Console.WriteLine("Bis zum nächsten Mal Noob");
                        spielLaeuft = false;
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe.");
                        break;
                }
            }
        }
    }
}
