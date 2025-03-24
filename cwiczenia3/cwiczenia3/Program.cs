namespace cwiczenia3;

class Program
{
    static void Main()
    {
        Ship ship1 = new Ship("Titanic", 40, 150, 5000);
        Ship ship2 = new Ship("Icon Of The Sead", 80, 200, 5000);
        Container c1 = new LiquidContainer(10000, true);
        Container c2 = new GasContainer(5000, 10);
        Container c3 = new RefrigeratedContainer(2000, -15,"Ice cream");
        Container c4 = new RefrigeratedContainer(3000, 22,"Butter");

        ship1.AddContainer(c1);
        ship1.AddContainers(new List<Container> { c2, c3 });
    
        
        c1.LoadContainer(1000);
        c1.LoadContainer(1500);
        c1.LoadContainer(2200);
        c2.LoadContainer(3000);
        c3.LoadContainer(500);
        c4.LoadContainer(1500);
        
        
        ship1.PrintInfo();
        ship1.RemoveContainer(c1.SerialNumber);
        ship1.PrintInfo();
        ship1.TransferContainers(ship2, c2.SerialNumber);
        ship1.PrintInfo();
        ship1.ReplaceContainer(c3.SerialNumber,c4);
        ship1.PrintInfo();
        ship2.PrintInfo();
    }
}