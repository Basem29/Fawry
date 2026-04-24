class ElectronicEngine : IEngine
{
    private int speed = 0;

    public void Increase()
    {
        speed++;
        Console.WriteLine("Electric engine speed: " + speed);
    }

    public void Decrease()
    {
        if (speed > 0) speed--;
        Console.WriteLine("Electric engine speed: " + speed);
    }

    public void SetSpeed(int speed)
    {
        this.speed = speed;
        Console.WriteLine("Electric engine updated to car speed: " + speed);
    }
}
