class Program
{
    static void Main(string[] args)
    {
        Car car = CarFactory.CreateCar("hybrid");

        car.Start();
        car.Accelerate(); // 20→Electric
        car.Accelerate(); // 40→Electric
        car.Accelerate(); // 60→Gas
        car.Brake();      // 40→Electric
        car.Stop();

        Console.WriteLine("Changing Engine");

        CarFactory.ReplaceEngine(car, "gas");

        car.Start();
        car.Accelerate();
        car.Stop();
    }
}
