namespace cwiczenia3;

public class RefrigeratedContainer: Container
{
    private double temperature;
    
    public RefrigeratedContainer(double loadWeight, double height, double contWeight, double depth, string serialNumber, double maxLoadWeight) : base(loadWeight, height, contWeight, depth, serialNumber, maxLoadWeight)
    {
    }
}