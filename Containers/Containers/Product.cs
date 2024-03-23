public class Product()
{
    private string name;
    private double temp;

    public Product(string name, double temp) : this()
    {
        this.name = name;
        this.temp = temp;
    }

    public string getName()
    {
        return name;
    }
    
    public double getTemp()
    {
        return temp;
    }
}