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
    public void removeCargo()
    {
        cargoMass = cargoMass*0.05f;
    }
    
    public void getInfo()
    {
        Console.WriteLine("container mass: " + mass + "\ncontainer height: " + height + "\ncontainer depth: " + depth +
                          "\ncontainer serial number: " + serialNumber + "\ncontainer max capacity: " + maxCapacity +
                          "\ncargo mass: " + cargoMass + "\nhazardous: " + hazardous);
    }
    
    public void notify()
    {
        Console.WriteLine("Proba niebezpiecznej operacji na kontenerze " + serialNumber);
    }
}