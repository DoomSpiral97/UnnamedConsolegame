namespace Konsolengame;

public class Ruinenencounter : Encounter
{
    private readonly Gegner gegner = new Gegner
    {
        Stärke = 16,
        Beschreibung = "Ein Skelett",
        HP = 110,
        MaximaleHP = 10,
        Wahrnehmnung = 19,
        Name = "Skelelol",
        Beleidigung  = $"*Das Skelett klappert drohend mit seinem Unterkiefer und zeigt mit einem knochigen Finger auf dich.*",
        SneakFail    = $"*Ein Knochen knackt laut unter deinem Stiefel.* \"Du glaubst wohl, ich hab keine Ohren mehr?\", klappert Knochenkarl spöttisch.",
        KampfFail    = $"Mit einem letzten Hieb schickt dich Knochenkarl zu Boden. \"Siehst du? Fleisch ist einfach überschätzt\", rasselt er zufrieden.",
        ÜberredenFail = $"Du versuchst gerade ernsthaft, ein Skelett zu überreden.\nSelbst der Wind in der Gruft scheint dich auszulachen."
    };

   

    public override void ShowIntro()
    {
        Console.WriteLine("Hinter der Stadt werden die Felder karger, das Grün weicht grauem Staub\n" +
                          "und abgestorbenen Sträuchern.");
        Console.ReadKey();

        Console.WriteLine("\nDer Weg verwandelt sich in rissige Steinplatten, die von alten Wurzeln\n" +
                          "wie von Händen auseinander gedrückt werden.");
        Console.ReadKey();

        Console.WriteLine("\nVor dir ragen die Ruinen eines verfallenen Bauwerks auf,\n" +
                          "eingestürzte Säulen zeichnen zackige Schatten in das fahle Licht.");
        Console.ReadKey();

        Console.WriteLine("\nEine aufgebrochene Treppe führt hinab in die Dunkelheit einer Gruft.\n" +
                          "Die Luft wird kalt, trocken und riecht nach Staub und altem Eisen.");
        Console.ReadKey();

        Console.WriteLine("\nZwischen den zerbrochenen Sarkophagen regt sich etwas.\n" +
                          "Knochen klicken auf Stein, als sich ein Skelett aus einem Steinsarg erhebt\n" +
                          "und dir mit leer glimmenden Augenhöhlen entgegenstarrt.");
        Console.ReadKey();

        Console.WriteLine("\nLangsam greift es nach einem verrosteten Schwert und stellt sich dir in den Weg.");
    }

    
    public override void PortraitAnsehen()
    {
        Console.WriteLine("                              _.--\"\"-._\n  .                         .\"         \".\n / \\    ,^.         /(     Y             |      )\\\n/   `---. |--'\\    (  \\__..'--   -   -- -'\"\"-.-'  )\n|        :|    `>   '.     l_..-------.._l      .'\n|      __l;__ .'      \"-.__.||_.-'v'-._||`\"----\"\n \\  .-' | |  `              l._       _.'\n  \\/    | |                   l`^^'^^'j\n        | |                _   \\_____/     _\n        j |               l `--__)-'(__.--' |\n        | |               | /`---``-----'\"1 |  ,-----.\n        | |               )/  `--' '---'   \\'-'  ___  `-.\n        | |              //  `-'  '`----'  /  ,-'   I`.  \\\n      _ L |_            //  `-.-.'`-----' /  /  |   |  `. \\\n     '._' / \\         _/(   `/   )- ---' ;  /__.J   L.__.\\ :\n      `._;/7(-.......'  /        ) (     |  |            | |\n      `._;l _'--------_/        )-'/     :  |___.    _._./ ;\n        | |                 .__ )-'\\  __  \\  \\  I   1   / /\n        `-'                /   `-\\-(-'   \\ \\  `.|   | ,' /\n                           \\__  `-'    __/  `-. `---'',-'\n                              )-._.-- (        `-----'\n                             )(  l\\ o ('..-.\n                       _..--' _'-' '--'.-. |\n                __,,-'' _,,-''            \\ \\\n               f'. _,,-'                   \\ \\\n              ()--  |                       \\ \\\n                \\.  |                       /  \\\n                  \\ \\                      |._  |\n                   \\ \\                     |  ()|\n                    \\ \\                     \\  /\n                     ) `-.                   | |\n                    // .__)                  | |\n                 _.//7'                      | |\n               '---'                         j_| `\n                                            (| |\n                                             |  \\\n                                             |lllj\n                                             |||||"); 
    }

    public override void GameOverBild()
    {
        Console.WriteLine("    _,_\n  /7/Y/^\\\n  vuVV|C)|                        __ _\n    \\|^ /                       .'  Y '>,\n    )| \\)                      / _   _   \\\n   //)|\\\\                      )(_) (_)(|}\n  / ^| \\ \\                     {  4A   } /\n //^| || \\\\                     \\uLuJJ/\\l\n>//||| |\\\\\\|                    |3    p)/\n| \"\"\"\"\"  7/>l__ _____ ____      /nnm_n//\nL>_   _-< 7/|_-__,__-)\\,__)(\".  \\_>-<_/D\n)D\" Y \"c)  9)       //V     \\_\"-._.__G G_c__.-__<\"/ ( \\\n | | |  |(|               < \"-._\"> _.G_.___)\\   \\7\\\n  \\\"=\" // |              (,\"-.__.|\\ \\<.__.-\" )   \\ \\\n   '---'  |              |,\"-.__\"| \\!\"-.__.-\".\\   \\ \\\n     |_;._/              (_\"-.__\"'\\ \\\"-.__.-\".|    \\_\\\n     )(\" V                \\\"-.__\"'|\\ \\-.__.-\".)     \\ \\\n        (                  \"-.__'\"\\_\\ \\.__.-\"./      \\ l\n         )                  \".__\"\">>G\\ \\__.-\">        V )\n                                \"\"  G<\\ \\_.-\"        ./7\n                                     G<\\ \\          ///\n                                ___  GD'\n                           /  /             )E_>\"\n                         _/  (             |  \\()\n                        / \\ /              |  |\n                        /\\\\|               |  |\n                       / '((               |  |\n                      /  / )\\              \\  |\n                     /  y  \\y              |Y |\n                    /  /    (              |  |\n                   L .\"     |              |  /\n                  | \\(                     |  |\n                   \\_|                     |  |\n                   |  \\                    { \"|\n                   | ||                    |  |\n                   |x||                    \\_,/\n                   } ||                    / \\'\n                   | ||                    |_/\n                   | (|                    | }\\\n                   | ||                    } ||\n                   | ||                    | ||\n                   | ||                    |\\||\n                   / ||                    | ||\n                   | ||                    ( |!\n                   | |/                    ) ||\n                 _/   \\                    | }|\n             _.-\"_ ( )|   jjs              ! ||\n          c_\"-_-\"_    )                    | ||\n           c,-_-'_--\"\"                     { ||\n           \"C(_/\"                          \\ /|\n                                           (! )\n                                           /| \\\n                                          /  |(\n                                         /7||\\\\\n                                        ()U cUu\"");
    }
    public override void Überredenstext()
    {
        Console.WriteLine("Du atmest tief durch und stellst dich vor das Skelett, so würdevoll wie möglich,\n" +
                          "während sein leerer Blick dich mustert.");
        Console.ReadKey();

        Console.WriteLine("\n„Ehrwürdiger Wächter“, beginnst du, „deine Pflicht ist längst erfüllt.\n" +
                          "Die Jahre haben dein Fleisch genommen, doch dein Dienst dauert immer noch an.“");
        Console.ReadKey();

        Console.WriteLine("\nEinen Moment lang bleibt alles still, nur ein loses Schlüsselbein klappert leicht,\n" +
                          "als würde Knochenkarl nachdenklich den Kopf schief legen.");
        Console.ReadKey();

        Console.WriteLine("\n„Selbst Helden brauchen irgendwann Ruhe“, fährst du fort.\n" +
                          "„Lass mich passieren, damit ich vollenden kann, was du einst begonnen hast.“");
        Console.ReadKey();

        Console.WriteLine("\nDas Skelett senkt langsam sein Schwert.\n" +
                          "Ein feines Knirschen geht durch die Knochen, als würde ein uralter Entschluss brechen.");
        Console.ReadKey();

        Console.WriteLine("\nOhne ein Wort tritt Knochenkarl beiseite und lässt dich an sich vorbeigehen,\n" +
                          "während sein Blick dir noch lange in den Rücken zu brennen scheint.");
    }


    protected override Gegner GetGegner()
    {
        return gegner;
    }

    protected override void ShowQuestSuccess()
    {
        Console.WriteLine("\nDu lässt den Wächter der Gruft hinter dir und gehst tiefer zwischen die steinernen Sarkophage.");
        Console.ReadKey();

        Console.WriteLine("\nAm Ende des Ganges öffnet sich eine kleine Kammer, in der die Stille schwer wiegt.");
        Console.ReadKey();

        Console.WriteLine("\nIn einem aufgebrochenen Grab schimmert ein Kristall in blassem Licht.\n" +
                          "Auf der zerbrochenen Platte kannst du gerade noch die Inschrift lesen:");
        Console.ReadKey();

        Console.WriteLine("\n„Hier ruht Mendizil Disi, Heldin dieser Stadt.“");
        Console.ReadKey();

        Console.WriteLine("\nBehutsam nimmst du den Kristall an dich.\n" +
                          "Sein Licht pulsiert einen Herzschlag lang in deiner Hand.");
        Console.ReadKey();

        Console.WriteLine("\nAus den Gängen um dich herum hörst du das leise Klicken von Knochen,\n" +
                          "die nach und nach in sich zusammenfallen.");
        Console.ReadKey();

        Console.WriteLine("\nDie ruhelosen Skelette sinken in sich zusammen, als hätte jemand die Fäden\n" +
                          "einer unsichtbaren Marionette zerschnitten.");
        Console.ReadKey();

        Console.WriteLine("\nEine tiefe, ehrfürchtige Stille erfüllt die Gruft.\n" +
                          "Zum ersten Mal seit langer Zeit scheint hier wirkliche Ruhe eingekehrt zu sein.");
        Console.ReadKey();

        Console.WriteLine("\nMit dem Kristall sicher verstaut machst du dich auf den Rückweg zur Oberfläche,\n" +
                          "während hinter dir die Dunkelheit nicht mehr drohend, sondern friedlich wirkt.");
    }


 
}
