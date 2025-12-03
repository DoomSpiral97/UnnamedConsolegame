namespace Konsolengame;

public class Ruinenencounter : Encounter
{
    private readonly Skelett _skelett = new Skelett
    {
        Stärke = 22,
        Beschreibung = "Ein Skelett",
        Charisma = 0,
        HP = 300,
        MaximaleHP = 10,
        Stealth = 2,
        Name = "Knochenkarl",
        Wahrnehmnung = 2,
        Beleidigung = $"*das Skelett klappert wütend mit seinem Unterkiefer"
    };

    public Ruinenencounter()
    {
        Name = "Gruft";
    }

    public override void ShowIntro()
    {
        Console.WriteLine("Du betrittst die Gruft die unter den Ruinen liegt,");
    }

    public override void Überredenstext()
    {
        Console.WriteLine("Das Skelett geht zurück in den Sarg");
    }

    protected override Charakter GetGegner()
    {
        return _skelett;
    }

    protected override void ShowQuestSuccess()
    {
        Console.WriteLine();
        Console.WriteLine("Du hast das Schild aus der Kammer des Magistrats erbeutet.");
    }

 
}
