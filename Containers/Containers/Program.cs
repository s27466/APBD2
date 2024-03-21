
LiquidContainer waterContainer1 = new LiquidContainer(10,50,45,50,true);
LiquidContainer waterContainer2 = new LiquidContainer(15,60,55,70,false);

GasContainer heliumContainer = new GasContainer();
CoolingContainer bananaContainer = new CoolingContainer();

waterContainer1.addCargo(30);
waterContainer2.addCargo(30);


Console.WriteLine(waterContainer1.getInfo());
Console.WriteLine(waterContainer2.getInfo());

waterContainer2.removeCargo();

public class DefaultContainer
{
    protected float cargoMass;
    protected float mass;
    protected float height;
    protected float depth;
    protected string serialNumber;
    protected float maxCapacity;
    
    public void addCargo(float m)
    {
        if (cargoMass + m > maxCapacity)
        {
            throw new OverfillException();
        }
        
        cargoMass += m;
    }

    public void removeCargo()
    {
        cargoMass = 0;
    }

    public String getInfo()
    {
        return "container mass: " + mass + "\ncontainer height: " + height + "\ncontainer depth: " + depth +
               "\ncontainer serial number: " + serialNumber + "\ncontainer max capacity: " + maxCapacity +
               "\ncargo mass: " + cargoMass + "\n";
    }
    
    
}

public class OverfillException : Exception
{
}


public class LiquidContainer : DefaultContainer, IHazardNotifier
{
    private static int serialCounter = 1;
    private bool hazardous;
    public LiquidContainer(float mass, float height, float depth, float maxCapacity, bool hazardous)
    {
        this.mass = mass;
        this.height = height;
        this.depth = depth;
        this.maxCapacity = maxCapacity;
        this.hazardous = hazardous;

        this.serialNumber = "KON-L-" + serialCounter;
        serialCounter++;
    }

    public void addCargo(float m)
    {
        bool canAdd = true;
        if (hazardous && cargoMass + m > maxCapacity/2)
        {
            canAdd = false;
            notify();
        }else if (cargoMass + m > maxCapacity*0.9)
        {
            canAdd = false;
            notify();
        }

        if (canAdd)
        {
            cargoMass += m;
        }
        
    }
    
    public void notify()
    {
        Console.WriteLine("Proba niebezpiecznej operacji na kontenerze " + serialNumber);
    }
}

public class GasContainer : DefaultContainer, IHazardNotifier
{
    private static int serialCounter = 1;
    
    public void notify()
    {
        Console.WriteLine("Proba niebezpiecznej operacji na kontenerze " + serialNumber);
    }
}

public class CoolingContainer : DefaultContainer
{
    private static int serialCounter = 1;
    
}

public interface IHazardNotifier
{
    void notify();
}

