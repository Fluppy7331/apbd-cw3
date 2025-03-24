namespace cwiczenia3;

public class Ship
{
    private string ShipName { get; }
    private List<Container> containers = new();
    private double maxSpeed { get; }
    private int maxContainers { get; }
    private double maxWeight { get; }

    public Ship(string shipName, double maxSpeed, int maxContainers, double maxWeight)
    {
        this.ShipName = shipName;
        this.maxSpeed = maxSpeed;
        this.maxContainers = maxContainers;
        this.maxWeight = maxWeight;
    }
    public void AddContainer(Container container)
    {
        if (containers.Count >= maxContainers) throw new Exception($"Too many containers for ship {ShipName}");
        double currentWeight = 0;
        foreach (Container vcontainer in containers) currentWeight += vcontainer.Load;
        if (currentWeight + container.Load >= maxWeight) throw new Exception($"Too much weight for ship {ShipName}");
        containers.Add(container);
    }
    public void AddContainers(IEnumerable<Container> containers)
    {
        foreach (var vContainer in containers)
        {
            this.AddContainer(vContainer);
        }
    }
    public void RemoveContainer(string serialNumber)
    {
        containers.RemoveAll(c => c.SerialNumber == serialNumber);
    }
    public void ReplaceContainer(string replacingSerialNumber, Container replacement)
    {
        Container? container = containers.Find(c => c.SerialNumber == replacingSerialNumber);
        if (container != null)
        {
            containers.Remove(container);
            try
            {
                containers.Add(replacement);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding replacement container: {ex.Message}");
                containers.Add(container);
                throw;
            }
        }
        else
        {
            throw new Exception("Container not found!");
        }
    }
    public void TransferContainers(Ship toShip, string serialNumber)
    {
        Container? container = containers.Find(c => c.SerialNumber == serialNumber);
        if (container != null)
        {
            containers.Remove(container);
            try
            {
                toShip.AddContainer(container);
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Destination ship cannot load this container. Container is comming back: {ex.Message}");
                containers.Add(container);
                throw;
            }
        }
        else
        {
            throw new Exception("Container not found!");
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Ship: {ShipName}, Speed: {maxSpeed} knots, Containers: {containers.Count}/{maxContainers}, Load: {containers.Sum(c=> c.Load)}kg/{maxWeight }t");
        foreach (var c in containers)
            c.PrintInfo();
    }
}