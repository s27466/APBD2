public abstract class DefaultContainer
{
    protected float cargoMass; //kg
    protected float mass; //kg
    protected float height; //cm
    protected float depth; //cm
    protected string serialNumber;
    protected float maxCapacity; //kg
    
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

    public string getSerial()
    {
        return serialNumber;
    }

    public float getCargoMass()
    {
        return cargoMass;
    }

    public float getMass()
    {
        return mass;
    }
}