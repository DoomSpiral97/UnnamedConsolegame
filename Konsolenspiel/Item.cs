namespace Konsolengame;

public class Item
{
    public string Name { get; set; }
    public string Beschreibung { get; set; }

    public Item(string name,string beschreibung)
    {
        Name = name;
        Beschreibung = beschreibung;
    }
    
}

public static class Items
{
    public static Item Kristall = new Item("Kristall","Ein Kristall");
    public static Item Schild   = new Item("Schild","Ein Schild");
    public static Item Amulett  = new Item("Amulett","Ein Amulett");
    public static Item Goldkiste  = new Item("Goldkiste","Eine Kiste voll Gold");

}