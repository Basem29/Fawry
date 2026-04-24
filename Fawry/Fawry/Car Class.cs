class Car
{
    private IEngine engine;
    private int speed = 0;

    public Car(IEngine engine)
    {
        this.engine = engine;
    }

    public void SetEngine(IEngine engine)
    {
        this.engine = engine;
        Console.WriteLine("Engine replaced successfully");
    }

    public void Start()
    {
        speed = 0;
        engine.SetSpeed(speed);
        Console.WriteLine("Car started");
    }

    public void Stop()
    {
        speed = 0;
        engine.SetSpeed(speed);
        Console.WriteLine("Car stopped");
    }

    public void Accelerate()
    {
        if (speed < 200)
        {
            speed += 20;
            if (speed > 200) speed = 200;

            engine.SetSpeed(speed);
            Console.WriteLine("Speed: " + speed);
        }
    }

    public void Brake()
    {
        if (speed > 0)
        {
            speed -= 20;
            if (speed < 0) speed = 0;

            engine.SetSpeed(speed);
            Console.WriteLine("Speed: " + speed);
        }
    }
}
