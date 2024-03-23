namespace Containers;

public class ContainerShip
{
    private List<DefaultContainer> containersList = new List<DefaultContainer>();
    private int speed; //kt
    private int maxNumberOfContainers;
    private int maxMassOfContainers; //t
    private static int numberCounter = 1;
    private string name;
    public ContainerShip(int speed, int maxNumberOfContainers, int maxMassOfContainers)
    {
        this.speed = speed;
        this.maxMassOfContainers = maxMassOfContainers;
        this.maxNumberOfContainers = maxNumberOfContainers;
        this.name = "SHIP-" + numberCounter;
        numberCounter++;

    }

    public void addContainer(DefaultContainer con)
    {
        double massSum = this.getConMassSum(containersList);
        if (massSum + con.getMass() + con.getCargoMass() > maxMassOfContainers*1000 || maxNumberOfContainers == containersList.Count)
        {
            Console.WriteLine("nie mozna zaladowac kontenera");
        }
        else
        {
            this.containersList.Add(con); 
        }

    }

    private double getConMassSum(List<DefaultContainer> cons)
    {
        double sum = 0;
        foreach (var container in cons)
        {
            sum += container.getMass();
            sum += container.getCargoMass();
        }

        return sum;
    }

    public void addContainerList(List<DefaultContainer> cl)
    {
        double massSum = getConMassSum(containersList);
        double newSum = getConMassSum(cl);
        if (massSum + newSum > maxMassOfContainers*1000 || containersList.Count == maxNumberOfContainers)
        {
            Console.WriteLine("nie mozna zaladowac kontenera");
        }
        else
        {
            this.containersList.AddRange(cl);
        }
    }

    public void moveConToShip(ContainerShip ship2, string conName)
    {
        DefaultContainer con = getConFromName(conName);
        this.removeContainer(conName);
        ship2.addContainer(con);
    }

    public void removeContainer(string conName)
    {
        foreach (DefaultContainer con in containersList)
        {
            if (con.getSerial().Equals(conName))
            {
                containersList.Remove(con);
                break;
            }
        }
    }

    public void swapContainers(string conName, DefaultContainer newCon)
    {
        this.removeContainer(conName);
        this.addContainer(newCon);
    }

    public void getInfo()
    {
        Console.WriteLine("ship name: " + name + "\ncontaniers: ");
        foreach (var container in containersList)
        {
            Console.WriteLine(container.getSerial());
        }
    }

    private DefaultContainer getConFromName(string conName)
    {
        foreach (DefaultContainer con in containersList)
        {
            if (con.getSerial().Equals(conName))
            {
                return con;
            }
        }

        return null;
    }
}