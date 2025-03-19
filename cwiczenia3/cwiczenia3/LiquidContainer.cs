namespace cwiczenia3;

public class LiquidContainer : Container, IHazardNotifier
{
    public LiquidContainer(double loadWeight, double height, double contWeight, double depth, string serialNumber, double maxLoadWeight) : base(loadWeight, height, contWeight, depth, serialNumber, maxLoadWeight)
    {
    }

    public override void LoadContainer(double newLoadWeight)
    {
        if (newLoadWeight + this < 0)

    }
}