namespace Konsolengame;

public class Spieler : Charakter
{ 
    public string Name { get; set; }
    public List<Item> Inventar { get; set; } = new List<Item>();

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
    }
}