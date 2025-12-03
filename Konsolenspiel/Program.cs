using System;
namespace Konsolengame
{ class Program
    {
        static void Main(string[] args)
        {
            bool spielLaeuft = true;

            Hilfsmethoden.Begrüßung();
            Spieler spieler = Hilfsmethoden.Charakterwahl();

            Console.WriteLine(
                $"Du hast {spieler.Beschreibung} gewählt. Deine Stats sind:\n" +
                $"Charisma: {spieler.Charisma}, Stärke: {spieler.Stärke}, Stealth: {spieler.Stealth}");

            while (spielLaeuft)
            {
                Console.WriteLine();
                Console.WriteLine("Du bist in der Stadt.");
                Console.WriteLine("Wohin möchtest du gehen?");
                Console.WriteLine("1) In den Wald");
                Console.WriteLine("2) Zur Kammer des Magisters");
                Console.WriteLine("3) Zur den Ruinen der Trauer");
                Console.WriteLine("4) Zur Drachenhöhle");
                Console.WriteLine("5) Inventar anzeigen");
                Console.WriteLine("0) Spiel beenden");
                string? eingabe = Console.ReadLine();

                switch (eingabe)
                {
                    case "1":
                    {
                        var encounter = new WaldEncounter();
                        bool waldGeschafft = encounter.StartEncounter(spieler); // Gegner kommt aus GetGegner()

                        if (waldGeschafft)
                        {
                            Console.WriteLine("Du hast den Wald geschafft.");
                            spieler.ItemHinzufügen(Items.Amulett);
                        }
                        else
                        {
                            Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
                        }
                        break;
                    }

                    case "2":
                    {
                        var encounter = new Stadtencounter();
                        bool stadtGeschafft = encounter.StartEncounter(spieler); 

                        if (stadtGeschafft)
                        {
                            Console.WriteLine("Du hast das Schild aus der Kammer des Magisters gestohlen.");
                            
                            spieler.ItemHinzufügen(Items.Schild);
                        }
                        else
                        {
                            Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
                        }
                        break;
                    }
                    case "3":
                    {
                        var encounter = new Ruinenencounter();
                        bool ruineGeschafft = encounter.StartEncounter(spieler); 

                        if (ruineGeschafft)
                        {
                            Console.WriteLine(
                                "Du kehrst erfolgreich in die Stadt zurück mit dem Kristall sicher in deinem Beutel");

                            spieler.ItemHinzufügen(Items.Kristall);
                        }
                        else
                        {
                            Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
                        }

                        break;
                    }
                    case "4":
                    {
                        if (spieler.Inventar.Contains(Items.Kristall) &&
                            spieler.Inventar.Contains(Items.Schild) &&
                            spieler.Inventar.Contains(Items.Amulett))
                        {
                            var encounter = new Drachenencounter();
                            bool dracheGeschafft = encounter.StartEncounter(spieler);

                            if (dracheGeschafft)
                            {
                                Console.WriteLine(
                                    "Du kehrst erfolgreich in die Stadt zurück mit dem Schatz des Drachen in deinem Beutel");
                                // Optional: weitere Belohnung
                            }
                            else
                            {
                                Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
                            }
                        }
                        else
                        {
                            Console.WriteLine(
                                "Du stehst vor dem Drachen und merkst, dass du keine Chance hast. Du rennst zurück in die sichere Stadt.");
                        }

                        break;
                    }

                    case "5":
                    {spieler.InventarAnzeigen();
                        break;
                    }
                    case "0":
                        Console.WriteLine("Tschüss, Spiel wird beendet.");
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
