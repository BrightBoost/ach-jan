namespace OOPexercise;
class Program
{
    static void Main(string[] args)
    {
        Square s = new Square("zwart", 3);
        Console.WriteLine(s.Circumference);
        Console.WriteLine(s.Surface);
        s.SideC = 4;
        Console.WriteLine(s.Circumference);
        Console.WriteLine(s.Surface);
    }
}

