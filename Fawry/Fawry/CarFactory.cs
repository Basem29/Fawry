class CarFactory
{
    public static Car CreateCar(string type)
    {
        switch (type.ToLower())
        {
            case "gas":
                return new Car(new GasolineEngine());
            case "electric":
                return new Car(new ElectronicEngine());
            case "hybrid":
                return new Car(new MixedHybridEngine());
            default:
                throw new Exception("Invalid engine type");
        }
    }

    public static void ReplaceEngine(Car car, string type)
    {
        switch (type.ToLower())
        {
            case "gas":
                car.SetEngine(new GasolineEngine());
                break;
            case "electric":
                car.SetEngine(new ElectronicEngine());
                break;
            case "hybrid":
                car.SetEngine(new MixedHybridEngine());
                break;
        }
    }
}
