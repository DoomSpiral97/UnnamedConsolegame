using Konsolengame;

public class WaldEncounter : Encounter
{
    private readonly Gegner gegner = new Gegner
    {
        Stärke = 10,
        Beschreibung = "Ein fieser Goblin",
        Charisma = 0,
        HP = 85,
        Name = "Groff der Brecher",
        Wahrnehmnung = 22,
        Beleidigung = $"Ich werde dich zu Wurst verarbeiten!",
        SneakFail = $"Ha! Dacht’ wohl, ich seh dich nicht, was? Du schleichst so laut wie ein betrunkener Ochse!",
        KampfFail = $"Zu langsam, Mensch! Groff der Brecher macht aus dir heute noch Fußabtreter!",        
        ÜberredenFail = $"Netter Versuch. Groff klaut lieber dein Zeug als deinen dummen Geschichten zu glauben!",
    };

    public override void ShowIntro()
    {
        Console.WriteLine("Der Pfad aus der Stadt führt dich zwischen verwitterten Feldern hindurch,\n" +
                          "bis das Pflaster endet und nur noch feuchte Erde unter deinen Stiefeln nachgibt.");
        Console.ReadKey();
        Console.WriteLine("\nMit jedem Schritt werden die Bäume dichter, ihre Kronen verschlingen das Licht\n" +
                          "wie gierige Münder.");
        Console.ReadKey();
        Console.WriteLine("\nDer Wind verfängt sich in knorrigen Ästen, die wie Finger über dein Gepäck kratzen.");
        Console.ReadKey();
        Console.WriteLine("\nGerade als du glaubst, allein zu sein, raschelt es heftig im Unterholz –\n" +
                          "und ein Goblin mit schiefem Lederhelm und viel zu großem Speer springt auf den Weg."); 
        Console.ReadKey();
        Console.WriteLine("\nMit einem kreischenden Lachen stellt er sich breitbeinig vor dich,\n" +
                          "als wäre er der König dieses Waldes.");
    }

    public override void PortraitAnsehen()
    {
        Console.WriteLine("        .-\"\"\"\".\n       /       \\\n   __ /   .-.  .\\\n  /  `\\  /   \\/  \\\n  |  _ \\/   .==.==.\n  | (   \\  /____\\__\\\n   \\ \\      (_()(_()\n    \\ \\            '---._\n     \\                   \\_\n  /\\ |`       (__)________/\n /  \\|     /\\___/\n|    \\     \\||VV\n|     \\     \\|\"\"\"\",\n|      \\     ______)\n\\       \\  /`\n      \\(");
    }

    public override void GameOverBild()
    {
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⡀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣤⠀⠀⠀⢀⣴⣿⡶⠀⣾⣿⣿⡿⠟⠛⠁\n⠀⠀⠀⠀⠀⠀⣀⣀⣄⣀⠀⠀⠀⠀⣶⣶⣦⠀⠀⠀⠀⣼⣿⣿⡇⠀⣠⣿⣿⣿⠇⣸⣿⣿⣧⣤⠀⠀⠀\n⠀⠀⢀⣴⣾⣿⡿⠿⠿⠿⠇⠀⠀⣸⣿⣿⣿⡆⠀⠀⢰⣿⣿⣿⣷⣼⣿⣿⣿⡿⢀⣿⣿⡿⠟⠛⠁⠀⠀\n⠀⣴⣿⡿⠋⠁⠀⠀⠀⠀⠀⠀⢠⣿⣿⣹⣿⣿⣿⣿⣿⣿⡏⢻⣿⣿⢿⣿⣿⠃⣼⣿⣯⣤⣴⣶⣿⡤⠀\n⣼⣿⠏⠀⣀⣠⣤⣶⣾⣷⠄⣰⣿⣿⡿⠿⠻⣿⣯⣸⣿⡿⠀⠀⠀⠁⣾⣿⡏⢠⣿⣿⠿⠛⠋⠉⠀⠀⠀\n⣿⣿⠲⢿⣿⣿⣿⣿⡿⠋⢰⣿⣿⠋⠀⠀⠀⢻⣿⣿⣿⠇⠀⠀⠀⠀⠙⠛⠀⠀⠉⠁⠀⠀⠀⠀⠀⠀⠀\n⠹⢿⣷⣶⣿⣿⠿⠋⠀⠀⠈⠙⠃⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠈⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣤⣴⣶⣦⣤⡀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⠀⠀⠀⠀⠀⣠⡇⢰⣶⣶⣾⡿⠷⣿⣿⣿⡟⠛⣉⣿⣿⣿⠆\n⠀⠀⠀⠀⠀⠀⢀⣤⣶⣿⣿⡎⣿⣿⣦⠀⠀⠀⢀⣤⣾⠟⢀⣿⣿⡟⣁⠀⠀⣸⣿⣿⣤⣾⣿⡿⠛⠁⠀\n⠀⠀⠀⠀⣠⣾⣿⡿⠛⠉⢿⣦⠘⣿⣿⡆⠀⢠⣾⣿⠋⠀⣼⣿⣿⣿⠿⠷⢠⣿⣿⣿⠿⢻⣿⣧⠀⠀⠀\n⠀⠀⠀⣴⣿⣿⠋⠀⠀⠀⢸⣿⣇⢹⣿⣷⣰⣿⣿⠃⠀⢠⣿⣿⢃⣀⣤⣤⣾⣿⡟⠀⠀⠀⢻⣿⣆⠀⠀\n⠀⠀⠀⣿⣿⡇⠀⠀⢀⣴⣿⣿⡟⠀⣿⣿⣿⣿⠃⠀⠀⣾⣿⣿⡿⠿⠛⢛⣿⡟⠀⠀⠀⠀⠀⠻⠿⠀⠀\n⠀⠀⠀⠹⣿⣿⣶⣾⣿⣿⣿⠟⠁⠀⠸⢿⣿⠇⠀⠀⠀⠛⠛⠁⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠈⠙⠛⠛⠛⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
    }
    public override void Überredenstext()
    {
        Console.WriteLine("Du hebst beschwichtigend die Hände, bevor der Goblin zustechen kann.\n" +
                          "„Moment, großer Krieger“, sagst du ernst, „du WIRST heute jemanden ausrauben –\n" +
                          "aber garantiert nicht mich.“");
        Console.ReadKey();
        Console.WriteLine("\n„Hinter mir kommt gleich ein Händler mit drei Maultieren voller Bier.“");
        Console.ReadKey();
        Console.WriteLine("\nDer Goblin blinzelt, senkt den Speer ein Stück.\n" +
                          "„Bier…? Drei Maultiere…?“");
        Console.ReadKey();
        Console.WriteLine("\nDu legst verschwörerisch den Finger an die Lippen:\n" +
                          "„Wenn du mich jetzt durchlässt, erzähle ich natürlich niemandem,\n" +
                          "dass Groff der Brecher persönlich den Handel des Jahres gemacht hat.“");
        Console.ReadKey();
        Console.WriteLine("\nNach einem Moment angestrengten Nachdenkens bricht er in ein schiefes Grinsen aus,\n" +
                          "stolpert vom Weg und duckt sich in die Büsche.");
        Console.ReadKey();
        Console.WriteLine("\n„Na gut, Mensch. Geh schon.\n" +
                          "Aber wenn kein Bierhändler kommt, dann beiß ich dir beim nächsten Mal die Stiefel ab!“");
    }

    protected override Gegner GetGegner()
    {
        return gegner;
    }

    protected override void ShowQuestSuccess()
    {
        Console.WriteLine("\nDie bedrohliche Spannung in der Luft löst sich,\n" +
                          "und nur das Rascheln der Blätter und das entfernte Rufen eines Vogels bleiben zurück.");
        Console.ReadKey();

        Console.WriteLine("\nDu folgst dem schmalen Pfad weiter, bis er sich zu einer kleinen Lichtung öffnet.");
        Console.ReadKey();

        Console.WriteLine("\nIn der Mitte steht ein kruder Altar aus zusammengetragenen Steinen,\n" +
                          "offensichtlich von Goblins errichtet.");
        Console.ReadKey();

        Console.WriteLine("\nDarauf liegt ein Amulett, dessen Oberfläche in einem tiefen Rot glimmt;\n" +
                          "von dem Altar ziehen sich glühende Energiefäden wie feine Wurzeln in den Boden.");
        Console.ReadKey();

        Console.WriteLine("\nVorsichtig nimmst du das Amulett an dich.\n" +
                          "In dem Moment verlöschen die roten Adern, und die Lichtung wirkt schlagartig friedlicher.");
        Console.ReadKey();

        Console.WriteLine("\nDer Wald scheint aufzuseufzen – als hätte jemand einen alten Fluch gelöst.\n" +
                          "Mit deinem neuen Fund machst du dich auf den Weg zurück zur Stadt.");
    }
}