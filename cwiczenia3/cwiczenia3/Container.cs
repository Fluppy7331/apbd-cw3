namespace cwiczenia3;

public class Container
{
    private double loadWeight;
    private double height;
    private double contWeight;
    private double depth;
    private string serialNumber;
    private static int counter = 0;
    private double maxLoadWeight;

    public Container(double loadWeight, double height, double contWeight, double depth, 
        double maxLoadWeight)
    {
        this.loadWeight = loadWeight;
        this.height = height;
        this.contWeight = contWeight;
        this.depth = depth;
        counter++;
        this.serialNumber = "KON-";
        this.maxLoadWeight = maxLoadWeight;
        if (this.loadWeight > this.maxLoadWeight)
            throw new OverfillException("Przekroczono maksymalny udzwig");
    }

    public void UnloadContainer()
    {
        this.loadWeight = 0;
    }

    public virtual void LoadContainer(double newLoadWeight)
    {
        if (loadWeight + this.loadWeight < this.maxLoadWeight)
            this.loadWeight = this.loadWeight + loadWeight;
        else
        {
            throw new OverfillException("Nie można wiecej załadować");
        }
        
    }
    
    
    
}