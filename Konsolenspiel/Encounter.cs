namespace Konsolengame;

public abstract class Encounter
{
    protected readonly Random Random = new Random();

    public string Name { get; protected set; }

    public abstract void ShowIntro();
    public abstract void Überredenstext();

    // Jede Unterklasse liefert ihren Gegner
    protected abstract Charakter GetGegner();

    // Einstiegspunkt
    public bool StartEncounter(Spieler spieler)
    {
        ShowIntro();

        var gegner = GetGegner();
        bool erfolgreich = false;
        bool encounterBeendet = false;

        while (!encounterBeendet)
        {
            Console.WriteLine();
            Console.WriteLine("Wie möchtest du vorgehen?");
            Console.WriteLine("1) Kämpfen");
            Console.WriteLine("2) Überreden");
            Console.WriteLine("3) Schleichen");
            Console.Write("Deine Wahl: ");

            string? eingabe = Console.ReadLine();

            switch (eingabe)
            {
                case "1":
                    erfolgreich = Fight(spieler, gegner);
                    encounterBeendet = true;
                    break;
                case "2":
                    erfolgreich = TryPersuade(spieler, gegner);
                    encounterBeendet = true;
                    break;
                case "3":
                    erfolgreich = TrySneak(spieler, gegner);
                    encounterBeendet = true;
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl, bitte 1 / 2 / 3 eingeben.");
                    break;
            }
        }

        if (erfolgreich)
        {
            ShowQuestSuccess();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Du bist in diesem Encounter gescheitert.");
        }

        return erfolgreich;
    }

    // Standard-Kampflogik für alle Encounter
    protected virtual bool Fight(Spieler spieler, Charakter gegner)
    {
        Console.WriteLine();
        Console.WriteLine($"{gegner.Name} greift dich an!");
        Thread.Sleep(1000);

        while (spieler.HP > 0 && gegner.HP > 0)
        {
            // Spieler greift an
            int schadenSpieler = spieler.Stärke;
            gegner.HP -= schadenSpieler;
            Console.ResetColor();
            Console.WriteLine($"Du triffst {gegner.Name} für {schadenSpieler} Schaden. Gegner HP: {gegner.HP}");
            Thread.Sleep(1000);

            if (gegner.HP <= 0)
            {
                Console.WriteLine($"{gegner.Name} geht zu Boden!");
                return true;
            }

            // Gegner greift an
            int schadenGegner = gegner.Stärke;
            spieler.HP -= schadenGegner;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{gegner.Name} trifft dich für {schadenGegner} Schaden. Deine HP: {spieler.HP}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{gegner.Name} verflucht dich: {gegner.Beleidigung}");
            Console.ResetColor();
            Thread.Sleep(1000);

            if (spieler.HP <= 0)
            {   Thread.Sleep(1000);
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("Du brichst verwundet zusammen...");
                Console.ResetColor();
                return false;
            }
        }

        return spieler.HP > 0;
    }

    // Standard-Überreden
    protected virtual bool TryPersuade(Spieler spieler, Charakter gegner)
    {
        Console.WriteLine();
        Console.WriteLine($"Du versuchst, {gegner.Name} zu überreden, dich in Ruhe zu lassen...");

        int wurf = Random.Next(1, 21);
        int probe = wurf + spieler.Charisma;

        Console.WriteLine($"Wurf: {wurf} + Charisma {spieler.Charisma} = {probe}");

        if (probe >= 15)
        {Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{gegner.Name} scheint dir zu glauben.");
            Console.ResetColor();
            Überredenstext();
            return true;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{gegner.Name} lässt sich nicht überzeugen!");
        Console.ResetColor();
        return false;
    }

    // Standard-Schleichen
    protected virtual bool TrySneak(Spieler spieler, Charakter gegner)
    {
        Console.WriteLine();
        Console.WriteLine($"Du versuchst, dich an {gegner.Name} vorbeizuschleichen...");

        int wurf = Random.Next(1, 21);
        int stealthWert = wurf + spieler.Stealth;

        Console.WriteLine($"Wurf: {wurf} + Schleichen {spieler.Stealth} = {stealthWert}");
        Console.WriteLine($"Wahrnehmung des Gegners: {gegner.Wahrnehmnung}");

        if (stealthWert >= gegner.Wahrnehmnung)
        {Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Du verschwindest lautlos im Schatten. Der Gegner bemerkt dich nicht.");
            Console.ResetColor();
            return true;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Ein Geräusch verrät dich – {gegner.Name} bemerkt dich!");
        Console.ResetColor();
        return false;
    }

    protected abstract void ShowQuestSuccess();
}

