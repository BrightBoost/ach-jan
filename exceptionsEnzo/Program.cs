namespace exceptionsEnzo;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            int x = 0;
            int y = 3 / x;
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine("Ja dat gaat niet he...\n" + e.StackTrace);
        }
        
        Console.WriteLine("Hoi!");

        Console.WriteLine(Convert.ToInt32("blabla"));
    }
}

