class MixedHybridEngine : IEngine
{
    private GasolineEngine gasEngine = new GasolineEngine();
    private ElectronicEngine electricEngine = new ElectronicEngine();

    public void Increase() { }
    public void Decrease() { }

    public void SetSpeed(int speed)
    {
        if (speed < 50)
        {
            Console.WriteLine("Using Electric Engine");
            electricEngine.SetSpeed(speed);
        }
        else
        {
            Console.WriteLine("Using Gas Engine");
            gasEngine.SetSpeed(speed);
        }
    }
}
