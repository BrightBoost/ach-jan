namespace jan_course2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int x; // declareren
        x = 5; // initialiseren
        int y = 4;
        string name = "Martijn";
        var blabla = "text";
        // blabla = 4; // dit kan niet, na toewijzen "text" is blabla van type string geworden

        // oefening variabelen
        string naam = "maaike";
        int age = 31;
        double result = Convert.ToDouble(27) / 7;

        Console.WriteLine(result);

        //string input = Console.ReadLine();
        //Console.WriteLine("Je zei: " + input);


        int nr = 3;
        Cat marvel = new Cat();
        marvel.aantalLevens = 9;

        Cat blacky = new Cat();
        blacky.aantalLevens = 8;

        string naamHond = "Bobbie";
        Console.WriteLine(naamHond.Length);

        // lengte getal
        int getal1 = 1234567;
        string getalString = getal1.ToString();
        int lengteGetal = getalString.Length;
        Console.WriteLine(lengteGetal);

        // andere manier
        Console.WriteLine(getal1.ToString().Length);

        // nog een
        Console.WriteLine(Convert.ToString(getal1).Length);

        string taal = "c#";

        if(taal.ToLower().Equals("c#") )
        {
            Console.WriteLine("Goede keuze, C#");
        }
        else if(taal.Equals("Rust") || taal.Equals("rust"))
        {
            Console.WriteLine("Ik hou van rust");
        }
        else if(taal.Equals("Java"))
        {
            Console.WriteLine("Leuk ook");
        }
        else
        {
            Console.WriteLine("Ik ken " + taal + " niet.");
        }

        WeekDay day = WeekDay.DINSDAG;
        int nrDay = Convert.ToInt32(day);
        Console.WriteLine(nrDay);

        switch(nrDay)
        {
            case 0:
                Console.WriteLine("Maandag");
                break;
            case 1:
                Console.WriteLine("Dinsdag");
                break;
            case 2:
                Console.WriteLine("Woensdag");
                break;
            default:
                Console.WriteLine("Een andere dag");
                break;
        }

        switch(day)
        {
            case WeekDay.MAANDAG:
                Console.WriteLine("maandag");
                break;
        }

        int i = 0;
        while(i < 10)
        {
            Console.WriteLine(i);
            i++;
        }

        string antw; 
        do
        {
            Console.WriteLine("Peer of appel?");
            antw = Console.ReadLine();
        }
        while (!antw.Equals("peer") && !antw.Equals("appel"));
       
        for(int j = 0; j < 10; j++)
        {
            Console.WriteLine(j);
        }
       
        int aantalMonkeys = 0;
        string song = " Little monkeys jumping on a bed, one jumped up and bumped his head, Mom called the Doctor and the doctor said........\"no more monkeys jumping on a bed.\"";
        for(int monkeys = aantalMonkeys; monkeys > 0; monkeys--)
        {
            song = monkeys == 1 ? song.Remove(14, 1).Replace("one", "he") : song;
            Console.WriteLine(monkeys + song);
        }

        Random r = new Random();
        int secret = r.Next(1, 500);

        Console.WriteLine(secret);

        Cat c = new Cat("Marvel");
        Console.WriteLine(c.aantalLevens);
        c.BijtInTV();
        Console.WriteLine(c.GeefCadeautje());
        c.GeefEten("Paté");
        

        Cat c1 = new Cat(3, "Blackie");
        Console.WriteLine(c1.aantalLevens);
        c1.BijtInTV();
        string cadeautje = c1.GeefCadeautje();
        Console.WriteLine(cadeautje);
        c1.GeefEten("brokken vis");
        DateTime date = new DateTime(2023, 1, 31, 9, 30, 0);
        c1.GeefEten("kip", 4);


    }
}

