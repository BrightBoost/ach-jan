namespace jan30;
class Program
{
    static void Main(string[] args)
    {
        Calculator c = new Calculator();
        Console.WriteLine(c.addNumbers(2, 3));
        Console.WriteLine(c.addNumbers(3, 4, 5));
    }

}
