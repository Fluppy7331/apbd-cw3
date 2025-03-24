namespace cwiczenia3;

public class GasContainer(double maxLoad, double pressure) : Container("G", maxLoad), IHazardNotifier
{
    private double _pressure = pressure;

    public override void UnloadContainer()
    {
        Load *= 0.05;
    }

    public override void LoadContainer(double newLoad)
    {
        if (Load + newLoad < maxLoad) Load += newLoad;
        else throw new OverfillException($"Can't load container '{newLoad}'");
    }

    public void Notify(string message)
    {
        Console.WriteLine($"Hazardous operation attempted by gas container: {SerialNumber}: {message}");
    }
}