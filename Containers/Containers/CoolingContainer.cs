using System.Runtime.CompilerServices;

public class CoolingContainer : DefaultContainer
{
    private static int serialCounter = 1;
    private List<Product> possibleProducts = new List<Product>();
    private string productName;
    private double temperature;

    public CoolingContainer(float mass, float height, float depth, float maxCapacity, List<Product> possibleProducts, string productName, double temperature)
    {
        this.mass = mass;
        this.height = height;
        this.depth = depth;
        this.maxCapacity = maxCapacity;
        this.possibleProducts = possibleProducts;
        this.productName = productName;

        if (!IsValid())
        {
            throw new InvalidOperationException("Invalid product name or temperature.");
        }

        this.serialNumber = "KON-C-" + serialCounter;
        serialCounter++;
        this.temperature = temperature;
    }

    private bool IsValid()
    {
        foreach (Product product in possibleProducts)
        {
            if (product.getName() == productName && this.temperature < product.getTemp())
            {
                return true;
            }
        }
        return false;
    }
    
    public void getInfo()
    {
        Console.WriteLine("container mass: " + mass + "\ncontainer height: " + height + "\ncontainer depth: " + depth +
                          "\ncontainer serial number: " + serialNumber + "\ncontainer max capacity: " + maxCapacity + "\ntemperature: " + temperature + "\ncargo type: " + productName +
                          "\ncargo mass: " + cargoMass);
    }
}