namespace Konsolengame;

public class Hilfsmethoden
{
    public static void Begrüßung()
    {
        Console.WriteLine("Wilkommen");
    }
    
    public static string Questboard()
    {
        Console.WriteLine();
        Console.WriteLine("Du bist in der Stadt.");
        Console.WriteLine("Wohin möchtest du gehen?");
        Console.WriteLine("1) In den Wald");
        Console.WriteLine("2) Zur Kammer des Magisters");
        Console.WriteLine("3) Zu den Ruinen der Trauer");
        Console.WriteLine("4) Zur Drachenhöhle");
        Console.WriteLine("I) Inventar anzeigen");
        Console.WriteLine("6) Stadt erkunden");
        Console.WriteLine("0) Spiel beenden");
        Console.Write("Deine Wahl: ");

        return Console.ReadLine();
    }

    public static void HappyEnd()
    {
        Console.WriteLine("Du hast das Abenteuer gemeistert, mehr Quests gibt es mit dem Addon * Eisklauen von Sommerfell* für nur 12,99€");
    }

    public static Spieler Charakterwahl()
    {
        Console.WriteLine("Gib deinen Namen ein:");
        string sname = Console.ReadLine();

        Console.WriteLine("Wähle deine Klasse:");
        Console.WriteLine("1. Krieger");
        Console.WriteLine("2. Barde");
        Console.WriteLine("3. Schurke");

        while (true)
        {
            string input = Console.ReadLine();
            Spieler spieler;

            if (input == "1")
            {
                spieler = new Spieler
                {
                    Name = sname,
                    Beschreibung = "Krieger",
                    HP = 200,
                    MaximaleHP = 150,
                    Stärke = 20,
                    Charisma = 5,
                    Stealth = 3
                };
                Console.WriteLine(
                    $"Du hast {spieler.Beschreibung} gewählt. Deine Stats sind:\n" +
                    $"Charisma: {spieler.Charisma}, Stärke: {spieler.Stärke}, Stealth: {spieler.Stealth}");
                return spieler;
            }
            else if (input == "2")
            {
                spieler = new Spieler
                {
                    Name = sname,
                    Beschreibung = "Barde",
                    HP = 100,
                    MaximaleHP = 100,
                    Stärke = 10,
                    Charisma = 20,
                    Stealth = 10
                };
                Console.WriteLine(
                    $"Du hast {spieler.Beschreibung} gewählt. Deine Stats sind:\n" +
                    $"Charisma: {spieler.Charisma}, Stärke: {spieler.Stärke}, Stealth: {spieler.Stealth}");
                return spieler;
            }
            else if (input == "3")
            {
                spieler = new Spieler
                {
                    Name = sname,
                    Beschreibung = "Schurke",
                    HP = 120,
                    MaximaleHP = 120,
                    Stärke = 15,
                    Charisma = 10,
                    Stealth = 20
                };
                Console.WriteLine(
                    $"Du hast {spieler.Beschreibung} gewählt. Deine Stats sind:\n" +
                    $"Charisma: {spieler.Charisma}, Stärke: {spieler.Stärke}, Stealth: {spieler.Stealth}");
                return spieler;
            }
            else
            {
                Console.WriteLine("Bitte nur Zahlen 1, 2 oder 3 eingeben:");
            }
        }
    }
}