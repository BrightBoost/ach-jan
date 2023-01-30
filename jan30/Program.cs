namespace jan30;
class Program
{
    static void Main(string[] args)
    {
        Calculator c = new Calculator();
        Console.WriteLine(c.addNumbers(2, 3));
        Console.WriteLine(c.addNumbers(2, 3, 7, 8));
        Console.WriteLine(c.addNumbers(3, 4.0, 5));

        Car car = new Car(1000);
        car.Start();

        ElectricCar eCar = new ElectricCar(1500);
        eCar.Start();
        
        Car car1 = new Car();
       
    }

}
