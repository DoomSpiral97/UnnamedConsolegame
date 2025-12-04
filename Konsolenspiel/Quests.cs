namespace Konsolengame;

public class Quests
{
    public static void WaldQuest(Spieler spieler)
    {
        var encounter = new WaldEncounter();
        bool waldGeschafft = encounter.StartEncounter(spieler); // Gegner kommt aus GetGegner()

        if (waldGeschafft)
        {
            spieler.ItemHinzufügen(Items.Amulett);
        }
        else
        {
            Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
        }
    }

    public static void MagisterQuest(Spieler spieler)
    {
        var encounter = new Stadtencounter();
        bool stadtGeschafft = encounter.StartEncounter(spieler); 

        if (stadtGeschafft)
        {
            spieler.ItemHinzufügen(Items.Schild);
        }
        else
        {
            Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
        }
    }

    public static void RuinenQuest(Spieler spieler)
    {
        var encounter = new Ruinenencounter();
        bool ruineGeschafft = encounter.StartEncounter(spieler); 

        if (ruineGeschafft)
        {
            spieler.ItemHinzufügen(Items.Kristall);
        }
        else
        {
            Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
        }
    }

    public static void DrachenQuest(Spieler spieler)
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
    }
}