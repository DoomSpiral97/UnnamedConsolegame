namespace Konsolengame;

public abstract class Encounter
{
    protected readonly Random Random = new Random();
    public abstract void ShowIntro();       // Wird alles in abgeleiteten Klassen befüllt
    public abstract void Überredenstext();
    public abstract void PortraitAnsehen();
    public abstract void GameOverBild();
    protected abstract void ShowQuestSuccess();
    
    // Jede Unterklasse liefert ihren Gegner
    protected abstract Gegner GetGegner();
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
            Console.WriteLine("4) Portrait ansehen");
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
                case "4":
                PortraitAnsehen();    
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
  protected virtual bool Fight(Spieler spieler, Gegner gegner)
{
    Random random = new Random();

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{gegner.Name} stellt sich dir zum Kampf!");
    Console.ResetColor();
    Console.ReadKey();

    while (spieler.HP > 0 && gegner.HP > 0)
    {
        // === SPIELER-RUNDE ===
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n--- Deine Runde ---");
        Console.ResetColor();

        int wurfSpieler = random.Next(1, 21); // d20
        int attackSpieler = wurfSpieler + spieler.Stärke;
        
        Console.WriteLine($"Du würfelst: d20={wurfSpieler} + Stärke={spieler.Stärke} = {attackSpieler}");
        Console.ReadKey();

        if (wurfSpieler == 20)
        {
            // Kritischer Treffer
            int schaden = spieler.Stärke * 2;
            gegner.HP -= schaden;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"KRITISCHER TREFFER! Du verursachst {schaden} Schaden!");
            Console.WriteLine($"Gegner HP: {gegner.HP}");
        }
        else if (attackSpieler >= 12) // Treffer-Schwelle
        {
            int schaden = random.Next(1, spieler.Stärke + 1); // 1dStärke
            gegner.HP -= schaden;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Treffer! Du verursachst {schaden} Schaden.");
            Console.WriteLine($"Gegner HP: {gegner.HP}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Verfehlt!");
        }
        Console.ResetColor();
        Console.ReadKey();

        if (gegner.HP <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{gegner.Name} geht zu Boden!");
            Console.ResetColor();
            return true;
        }

        // === GEGNER-RUNDE ===
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n--- {gegner.Name}s Runde ---");
        Console.ResetColor();

        int wurfGegner = random.Next(1, 21); // d20
        int attackGegner = wurfGegner + gegner.Stärke;
        
        Console.WriteLine($"{gegner.Name} würfelt: d20={wurfGegner} + Stärke={gegner.Stärke} = {attackGegner}");
        Console.ReadKey();

        if (wurfGegner == 20)
        {
            // Kritischer Treffer
            int schaden = gegner.Stärke * 2;
            spieler.HP -= schaden;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{gegner.Name} landet KRITISCHEN TREFFER! {schaden} Schaden!");
            Console.WriteLine($"Deine HP: {spieler.HP}");
        }
        else if (attackGegner >= 12) // Treffer-Schwelle
        {
            int schaden = random.Next(1, gegner.Stärke + 1); // 1dStärke
            spieler.HP -= schaden;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{gegner.Name} trifft! {schaden} Schaden.");
            Console.WriteLine($"Deine HP: {spieler.HP}");
            
            // Beleidigung nach Treffer
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{gegner.Name} verflucht dich: {gegner.Beleidigung}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"{gegner.Name} verfehlt!");
        }
        Console.ResetColor();
        Console.ReadKey();

        if (spieler.HP <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{gegner.KampfFail}");
            Console.WriteLine("Du brichst verwundet zusammen...");
            Console.WriteLine("Hier endet deine Reise...");
            Console.ResetColor();
            GameOverBild();
            Environment.Exit(0);
        }
    }

    return spieler.HP > 0;
}


    // Standard-Überreden
    protected virtual bool TryPersuade(Spieler spieler, Gegner gegner)
    {
        Console.WriteLine();
        Console.WriteLine($"Du versuchst, {gegner.Name} zu überreden, dich in Ruhe zu lassen...");

        int wurf = Random.Next(1, 21);
        int probe = wurf + spieler.Charisma;

        Console.WriteLine($"Wurf: {wurf} + Charisma {spieler.Charisma} = {probe}");

        if (probe >= 15)
        {Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Erfolg!");
            Console.ResetColor();
            Überredenstext();
            return true;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Versagt");
        Console.ResetColor();
        Console.WriteLine($"{gegner.ÜberredenFail} ");
        
        return false;
    }

    // Standard-Schleichen
    protected virtual bool TrySneak(Spieler spieler, Gegner gegner)
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
        Console.WriteLine($"Versagt");
        Console.ResetColor();
        Console.WriteLine($"{gegner.SneakFail} ");
        return false;
    }

    
}

