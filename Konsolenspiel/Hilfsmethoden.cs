namespace Konsolengame;

public class Hilfsmethoden
{
    public static void Begrüßung()
    {
        Console.WriteLine("Wilkommen");
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
                return spieler;
            }
            else
            {
                Console.WriteLine("Bitte nur Zahlen 1, 2 oder 3 eingeben:");
            }
        }
    }
}