namespace Konsolengame;

public class Gerüchte
{
    private static readonly List<string> alleGeruechte = new List<string>()
    {   
        "„Ihr habt sicher von der alten Ruine östlich der Stadt gehört, oder?“ Der Adlige senkt die Stimme.\n „Dort liegt ein Kristall, vor Jahrzehnten verloren – ein Vermögen wert.\n Aber kein vernünftiger Mensch geht dorthin.\n Wer es versucht hat, kam mit leerem Blick oder gar nicht zurück.“",

        "„Der Drache da draußen macht aus dieser Stadt sein Spielzeug“, flüstert der Söldner und starrt in seinen Becher.\n „Unsere besten Krieger liegen längst in seinem Schatten begraben.\n Nur einmal wurde je ein Drache erschlagen – von Mendizil Disi, aber sie hatte auch  einem magisches Amulett und Schild mit einem Kristall voller vergessener Magie.“",

        "„Hast du gehört? Der Magister hat das Schild einer legendären Kriegerin aufgekauft“, zischt der Wirt verschwörerisch.\n „Mit Steuergeld, versteht sich – während wir kaum unsere Brote bezahlen können.\n Er lässt es im Saal prunken, als hätte er selbst je ein Schwert gehalten.“",

        "„Die Goblins im Wald… die sind nicht mehr wie früher“, murmelt ein Waldläufer mit Narben im Gesicht.\n „Früher haben sie dich nur aus dem Gebüsch beworfen und sind weggerannt.\n Jetzt lauern sie in Gruppen, stellen Fallen und flüstern in einer Sprache, die kein Mensch kennt.“"
    };
    
    private static readonly Random _random = new();

    public static void GerüchteHören(Spieler spieler)
    {

        Console.WriteLine("Du probierst interessanten Tratsch aufzuschnappen...");
        int wurf = _random.Next(1, 100);
        if (wurf > 69)
        {
            Console.WriteLine("Du hörst nichts sonderlich spannendes... ");
            return;
        }
        else
        {
            var unbekannteGerÜchte = new List<string>();

            foreach (var g in alleGeruechte)                // Perplexity Hilfe
            {
                if (!spieler.BekannteGeruechte.Contains(g))
                {
                    unbekannteGerÜchte.Add(g);
                }
            }
            
            if (unbekannteGerÜchte.Count == 0)
            {
                Console.WriteLine("Du kennst bereits alle Gerüchte in dieser Stadt.");
                return;
            }

            int index = _random.Next(unbekannteGerÜchte.Count);
            string gerücht = unbekannteGerÜchte[index];

            Console.WriteLine($"Du hörst ein neues Gerücht: \"{gerücht}\"");

            // Im Spieler vermerken
            spieler.BekannteGeruechte.Add(gerücht);
        }
    }
    

}