namespace OOPexercise;
class Program
{
    // maak een class Mens aan
    // geef Mens een naam en een hobby
    // geen Mens een int voor totaalpopulatie
    // hoog deze op vanuit de constructor
    // totaal aantal mensen moet voor alle mensen hetzelfde zijn
    // geef mens een methode die een beschrijving van mens print incl totaalpopulatie
    // deze methode moet hetzelfde zijn voor alle instanties
    static void Main(string[] args)
    {
        Square s = new Square("zwart", 3);
        Console.WriteLine(s.Circumference);
        Console.WriteLine(s.Surface);
        s.SideC = 4;
        Console.WriteLine(s.Circumference);
        Console.WriteLine(s.Surface);
        // static helper method
        Square.CalcSurfaceSquare(5);

    }
}

