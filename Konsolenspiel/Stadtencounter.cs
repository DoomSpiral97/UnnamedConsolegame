namespace Konsolengame;


public class Stadtencounter : Encounter
    {
        private readonly Wache wache = new Wache
        {
            Stärke = 22,
            Beschreibung = "Ein Stadtwache",
            Charisma = 0,
            HP = 300,
            MaximaleHP = 10,
            Stealth = 2,
            Name = "Sigur Sigurdson",
            Wahrnehmnung = 2,
            Beleidigung = $"Der Magistrat wird dich finden du Schnutz!"
        };

    public Stadtencounter()
    {
        Name = "Düsterer Wald";
    }

    public override void ShowIntro()
    {
        Console.WriteLine("Du betrittst die Gassen der Stadt");
    }

    public override void Überredenstext()
    {
        Console.WriteLine("Die Stadtwache freut sich und geht in die Taverne.");
    }

    protected override Charakter GetGegner()
    {
        return wache;
    }

    protected override void ShowQuestSuccess()
    {
        Console.WriteLine();
        Console.WriteLine("Du hast das Schild aus der Kammer des Magistrats erbeutet.");
    }

 
}