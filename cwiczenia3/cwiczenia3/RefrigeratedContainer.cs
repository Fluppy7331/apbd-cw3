namespace cwiczenia3;

public class RefrigeratedContainer : Container
{
    private double _temperature;
    private string _productName;
    private readonly Dictionary<string, double> _productTemperatures = new Dictionary<string, double>
    {
        { "Bananas", 13.3 },
        { "Chocolate", 18 },
        { "Fish", 2 },
        { "Meat", -15 },
        { "Ice cream", -18 },
        { "Frozen pizza", -30 },
        { "Cheese", 7.2 },
        { "Sausages", 5 },
        { "Butter", 20.5 },
        { "Eggs", 19 }
    };

    public RefrigeratedContainer(double maxLoad, double temperature, string productName)
        : base("C", maxLoad)
    {
        if(!_productTemperatures.ContainsKey(productName)) throw new ArgumentException("Invalid product name");
        if(temperature<_productTemperatures[productName]) throw new ArgumentException("Invalid temperature");
        _temperature = temperature;
        _productName = productName;
    }
}