namespace Konsolengame;


public class Stadtencounter : Encounter
    {
        private readonly Gegner gegner = new Gegner
        {
            Stärke = 22,
            Beschreibung = "Ein missmutiger Wachmann in der Livree des Magisters",            
            Charisma = 0,
            HP = 300,
            MaximaleHP = 10,
            Stealth = 2,
            Name = "Sigur Sigurdson",
            Wahrnehmnung = 2,
            Beleidigung = $"Der Magistrat wird dich finden du Schmutz!",
            SneakFail    = $"Du stolperst über eine lose Bordsteinkante. „Sehr unauffällig“, knurrt die Wache. „Willst du nicht gleich ein Schild hochhalten, auf dem ‘Einbrecher’ steht?“",
            KampfFail    = $"Ein harter Schlag seines Knüppels trifft dich an der Schläfe. „Nächster Möchtegern-Held erledigt“, murrt die Wache, während dir die Lichter ausgehen.",
            ÜberredenFail = $"Du erwähnst die Geschichte aus der Taverne – und siehst nur, wie seine Ader an der Schläfe pulsiert.\n„Du redest über MEINE Frau?“ faucht er, verpasst dir eine und schleudert dich die Treppe hinunter."
        };
        

    public override void PortraitAnsehen()
    {
        Console.WriteLine("  ,   A           {}\n / \\, | ,        .--.\n|    =|= >      /.--.\\\n \\ /` | `       |====|\n  `   |         |`::`|  \n      |     .-;`\\..../`;_.-^-._\n     /\\\\/  /  |...::..|`   :   `|\n     |:'\\ |   /'''::''|   .:.   |\n      \\ /\\;-,/\\   ::  |..:::::..|\n      |\\ <` >  >._::_.| ':::::' |\n      | `\"\"`  /   ^^  |   ':'   |\n      |       |       \\    :    /\n      |       |        \\   :   / \n      |       |___/\\___|`-.:.-`\n      |        \\_ || _/    `\n      |        <_ >< _>\n      |        |  ||  |\n      |        |  ||  |\n      |       _\\.:||:./_\n      |      /____/\\____\\");
    }

    public override void GameOverBild()
    {
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⡀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣤⠀⠀⠀⢀⣴⣿⡶⠀⣾⣿⣿⡿⠟⠛⠁\n⠀⠀⠀⠀⠀⠀⣀⣀⣄⣀⠀⠀⠀⠀⣶⣶⣦⠀⠀⠀⠀⣼⣿⣿⡇⠀⣠⣿⣿⣿⠇⣸⣿⣿⣧⣤⠀⠀⠀\n⠀⠀⢀⣴⣾⣿⡿⠿⠿⠿⠇⠀⠀⣸⣿⣿⣿⡆⠀⠀⢰⣿⣿⣿⣷⣼⣿⣿⣿⡿⢀⣿⣿⡿⠟⠛⠁⠀⠀\n⠀⣴⣿⡿⠋⠁⠀⠀⠀⠀⠀⠀⢠⣿⣿⣹⣿⣿⣿⣿⣿⣿⡏⢻⣿⣿⢿⣿⣿⠃⣼⣿⣯⣤⣴⣶⣿⡤⠀\n⣼⣿⠏⠀⣀⣠⣤⣶⣾⣷⠄⣰⣿⣿⡿⠿⠻⣿⣯⣸⣿⡿⠀⠀⠀⠁⣾⣿⡏⢠⣿⣿⠿⠛⠋⠉⠀⠀⠀\n⣿⣿⠲⢿⣿⣿⣿⣿⡿⠋⢰⣿⣿⠋⠀⠀⠀⢻⣿⣿⣿⠇⠀⠀⠀⠀⠙⠛⠀⠀⠉⠁⠀⠀⠀⠀⠀⠀⠀\n⠹⢿⣷⣶⣿⣿⠿⠋⠀⠀⠈⠙⠃⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠈⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣤⣴⣶⣦⣤⡀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⠀⠀⠀⠀⠀⣠⡇⢰⣶⣶⣾⡿⠷⣿⣿⣿⡟⠛⣉⣿⣿⣿⠆\n⠀⠀⠀⠀⠀⠀⢀⣤⣶⣿⣿⡎⣿⣿⣦⠀⠀⠀⢀⣤⣾⠟⢀⣿⣿⡟⣁⠀⠀⣸⣿⣿⣤⣾⣿⡿⠛⠁⠀\n⠀⠀⠀⠀⣠⣾⣿⡿⠛⠉⢿⣦⠘⣿⣿⡆⠀⢠⣾⣿⠋⠀⣼⣿⣿⣿⠿⠷⢠⣿⣿⣿⠿⢻⣿⣧⠀⠀⠀\n⠀⠀⠀⣴⣿⣿⠋⠀⠀⠀⢸⣿⣇⢹⣿⣷⣰⣿⣿⠃⠀⢠⣿⣿⢃⣀⣤⣤⣾⣿⡟⠀⠀⠀⢻⣿⣆⠀⠀\n⠀⠀⠀⣿⣿⡇⠀⠀⢀⣴⣿⣿⡟⠀⣿⣿⣿⣿⠃⠀⠀⣾⣿⣿⡿⠿⠛⢛⣿⡟⠀⠀⠀⠀⠀⠻⠿⠀⠀\n⠀⠀⠀⠹⣿⣿⣶⣾⣿⣿⣿⠟⠁⠀⠸⢿⣿⠇⠀⠀⠀⠛⠛⠁⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠈⠙⠛⠛⠛⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
    }

    public override void ShowIntro()
    {
        Console.WriteLine("Die Straßen der Stadt sind zu dieser Stunde ungewöhnlich still.\n" +
                          "Nur vereinzelte Laternen werfen flackernde Lichtkegel auf das Kopfsteinpflaster.");
        Console.ReadKey();

        Console.WriteLine("\nDu schleichst an geschlossenen Marktständen vorbei,\n" +
                          "deren bunte Planen im Nachtwind rascheln wie geflüsterte Anklagen.");
        Console.ReadKey();

        Console.WriteLine("\nVor dir erhebt sich das Anwesen des Magisters:\n" +
                          "ein viel zu prunkvolles Haus mit Marmorstufen und goldenen Beschlägen an der Tür.");
        Console.ReadKey();

        Console.WriteLine("\nHinter einem der oberen Fenster erkennst du den Schimmer des legendären Schildes,\n" +
                          "das er sich von den Steuern der Bürger gekauft hat.");
        Console.ReadKey();

        Console.WriteLine("\nGerade als du die Stufen hinaufsteigen willst,\n" +
                          "tritt eine Stadtwache aus dem Schatten der Tür und versperrt dir mit verschränkten Armen den Weg.");
        Console.ReadKey();

        Console.WriteLine("\nSein Blick wandert von deinen Stiefeln über deinen Gürtel zu deinem Gesicht.\n" +
                          "„Geschäftliche Angelegenheit mit dem Magister?“, fragt er mit einem Ton,\n" +
                          "der eindeutig schon die Antwort kennt.");
    }


    public override void Überredenstext()
    {
        Console.WriteLine("Du hebst die Hände, bevor der Wachmann nach seinem Knüppel greifen kann,\n" +
                          "und senkst die Stimme zu einem verschwörerischen Flüstern.");
        Console.ReadKey();

        Console.WriteLine("\n„Hör zu“, beginnst du, „ich bin nicht hier, um Ärger zu machen.\n" +
                          "Ich bin hier, um dem Magister ein kleines… gesellschaftliches Problem zu ersparen.“");
        Console.ReadKey();

        Console.WriteLine("\nDie Wache runzelt die Stirn, aber du machst weiter:");
        Console.ReadKey();

        Console.WriteLine("\n„Warst du gestern in der Taverne? Ich frage nur,\n" +
                          "weil dort eine Frau sehr laut erzählt hat, wie sie sich vor versammelter Runde entblößt hat…\n" +
                          "und dass ihr ‚hochansehnlicher Ehemann in Dienstuniform‘ NICHT amüsiert war.“");
        Console.ReadKey();

        Console.WriteLine("\nDer Wachmann wird kreidebleich. Seine Finger verkrampfen sich am Knauf seines Knüppels,\n" +
                          "doch nicht in deine Richtung.");
        Console.ReadKey();

        Console.WriteLine("\n„Wenn der Magister erfährt, dass seine Wache in so einer Geschichte vorkommt…“,\n" +
                          "setzt du nach und lässt den Satz bewusst offen im Raum hängen.");
        Console.ReadKey();

        Console.WriteLine("\nEin langer Moment vergeht, dann stößt er einen frustrierten Fluch aus,\n" +
                          "reißt den Helm vom Kopf und stopft ihn sich unter den Arm.");
        Console.ReadKey();

        Console.WriteLine("\n„Weißt du was? Ich war nie hier. Mach, was du willst“, knurrt er\n" +
                          "und stapft die Straße hinunter, während er unverständliche Dinge über Ehe, Lohn\n" +
                          "und den Magister vor sich hinbrummt.");
    }


    protected override Gegner GetGegner()
    {
        return gegner;
    }

    protected override void ShowQuestSuccess()
{
    Console.WriteLine("\nDas Haus des Magisters liegt nun still vor dir, die Wache ist kein Hinderniss mehr. Keine weiteren Schritte hallen mehr auf der Straße.");
    Console.ReadKey();

    Console.WriteLine("\nIm Inneren tastest du dich durch einen Flur voller teurer Teppiche\n" +
                      "und lächerlich vieler Gemälde, die alle nur das gleiche selbstgefällige Gesicht zeigen.");
    Console.ReadKey();

    Console.WriteLine("\nIm Arbeitszimmer findest du schließlich, wonach du gesucht hast:\n" +
                      "Auf einem Sockel über dem Kamin hängt das legendäre Schild,\n" +
                      "poliert und mit dem Siegel des Magisters verziert, als wäre es seine eigene Heldentat.");
    Console.ReadKey();

    Console.WriteLine("\nMit einem entschlossenen Griff nimmst du das Schild von der Halterung\n" +
                      "und verstaust es, so gut es geht – ein Stück wirklicher Geschichte,\n" +
                      "zurück in den Händen derer, die es verdienen.");
    Console.ReadKey();

    Console.WriteLine("\nDein Blick bleibt an den Stapeln von Schriftrollen, Steuerlisten und Bestechungsschreiben hängen,\n" +
                      "die sich auf seinem Schreibtisch türmen.");
    Console.ReadKey();

    Console.WriteLine("\nEin einzelnes Kerzenlicht reicht, um aus Papier ein Fanal zu machen:\n" +
                      "Flammen greifen nach den Dokumenten, kriechen über die Tischkante\n" +
                      "und springen auf die schweren Vorhänge über.");
    Console.ReadKey();

    Console.WriteLine("\nAls du das Haus verlässt, steigt bereits Rauch aus den oberen Fenstern.\n" +
                      "Keine Schreie, nur das Prasseln von Feuer und das Knacken von Holz\n" +
                      "mischen sich in die Nachtluft.");
    Console.ReadKey();

    Console.WriteLine("\nMit dem Schild auf dem Rücken und Ruß an den Händen gehst du zurück in die dunklen Gassen der Stadt.\n" +
                      "Morgen wird man sagen, ein Unfall sei geschehen –\n" +
                      "aber die Leute werden sich ansehen und zum ersten Mal seit Langem lächeln.");
}


 
}