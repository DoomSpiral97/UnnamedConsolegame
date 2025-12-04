namespace Konsolengame;

public class Ruinenencounter : Encounter
{
    private readonly Skelett skelett = new Skelett
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

   

    public override void ShowIntro()
    {
        Console.WriteLine("Du betrittst die Gruft die unter den Ruinen liegt,");
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
        Console.WriteLine("Das Skelett geht zurück in den Sarg");
    }

    protected override Charakter GetGegner()
    {
        return skelett;
    }

    protected override void ShowQuestSuccess()
    {
        Console.WriteLine();
        Console.WriteLine("Du hast das Schild aus der Kammer des Magistrats erbeutet.");
    }

 
}
