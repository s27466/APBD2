public class GasContainer : DefaultContainer, IHazardNotifier
{
    private static int serialCounter = 1;
    private float pressure; //atmospheres
    
    public GasContainer(float mass, float height, float depth, float maxCapacity, float pressure)
    {
        this.mass = mass;
        this.height = height;
        this.depth = depth;
        this.maxCapacity = maxCapacity;
        this.pressure = pressure;

        this.serialNumber = "KON-G-" + serialCounter;
        serialCounter++;
    }
    
    public void notify()
    {
        Console.WriteLine("Proba niebezpiecznej operacji na kontenerze " + serialNumber);
    }
    
    public void getInfo()
    {
        Console.WriteLine("container mass: " + mass + "\ncontainer height: " + height + "\ncontainer depth: " + depth +
                          "\ncontainer serial number: " + serialNumber + "\ncontainer max capacity: " + maxCapacity + "\ncontainer pressure: " + pressure +
                          "\ncargo mass: " + cargoMass);
    }
}