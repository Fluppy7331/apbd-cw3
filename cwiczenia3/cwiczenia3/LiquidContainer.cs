namespace cwiczenia3;

public class LiquidContainer : Container, IHazardNotifier
{




    public override void LoadContainer(double newLoadWeight)
    {
        if(newLoadWeight+ this < 0)
        
    }
    
}