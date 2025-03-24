
namespace cwiczenia3;

public class LiquidContainer(double maxLoad, bool isHazardous) : Container("L", maxLoad), IHazardNotifier
{
    private bool _isHazardous = isHazardous;

    public override void LoadContainer(double newLoad)
    {
        if (_isHazardous)
        {
            if(Load + newLoad < MaxLoad*0.5)Load += newLoad;
            else Notify("Load is hazardous and cannot be loaded over 50% of max load");
        }
        else
        {
            if(Load + newLoad < MaxLoad*0.9)Load += newLoad;
            else Notify("Liquid container load cannot be loaded over 90% of max load");
        }
    }
    public void Notify(string message)
    {
        Console.WriteLine($"Hazardous operation attempted by liquid container: {SerialNumber}: {message}");
    }
}