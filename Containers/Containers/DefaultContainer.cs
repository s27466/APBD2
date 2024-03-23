public abstract class DefaultContainer
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

    public void getInfo()
    {
        Console.WriteLine("container mass: " + mass + "\ncontainer height: " + height + "\ncontainer depth: " + depth +
                          "\ncontainer serial number: " + serialNumber + "\ncontainer max capacity: " + maxCapacity +
                          "\ncargo mass: " + cargoMass);
    }
    
    
}