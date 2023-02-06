namespace bank;
class Program
{
    static void Main(string[] args)
    {
        double x = 11.1;
        for(int i = 0; i < 100; i++)
        {
            x = x + 0.0001;
            Console.WriteLine(x);
        }
    }
}

