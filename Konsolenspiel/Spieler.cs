namespace Konsolengame;

public class Spieler : Charakter
{ 
    public string Name { get; set; }
    public int HP { get; set; }
    public int MaximaleHP { get; set; }
    public int Stärke { get; set; }
    public int Charisma { get; set; }
    public int Stealth { get; set; }
    public string Beschreibung { get; set; }
    public int Perception { get; set; }
    public List<Item> Inventar { get; set; } = new List<Item>();
    public List<string> BekannteGeruechte { get; set; } = new List<string>();

    public void ItemHinzufügen(Item item)
    {

        Inventar.Add(item);
        Console.WriteLine($"{item.Name} wurde deinem Inventar hinzugefügt.");
    }

    public void InventarAnzeigen()
    {
        Console.WriteLine("Du hast folgende Items in deinem Inventar.");
        foreach (Item i in Inventar)
        {
            Console.WriteLine(i.Name);
        }
        Console.WriteLine("Drücke eine Taste um zurückzukehren");
        Console.ReadKey();
    }
}