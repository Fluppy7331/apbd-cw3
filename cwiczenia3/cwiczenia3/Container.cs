namespace cwiczenia3;

public abstract class Container
{
    public double Load { get; set; }
    public string SerialNumber { get; }
    protected static int Counter;
    protected double MaxLoad { get;}

    public Container(string type, double maxLoad)
    {
        Counter++;
        SerialNumber = $"KON-{type}-{Counter}";
        MaxLoad = maxLoad;
    }

    public virtual void UnloadContainer()
    {
        Load = 0;
    }

    public virtual void LoadContainer(double newLoad)
    {
        if (Load + newLoad < MaxLoad)
            Load += newLoad;
        else
        {
            throw new OverfillException("Nie można wiecej załadować");
        }
        
    }
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Container {SerialNumber}: {Load}kg / {MaxLoad}kg");
    }
    
    
    
}