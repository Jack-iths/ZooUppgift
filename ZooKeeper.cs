namespace ZooUppgift;

public class ZooKeeper
{
    public string Name { get; private set; }

    public ZooKeeper(string name)
    {
        Name = name;
    }

    public void FeedAnimal(Animal animal)
    {
        Console.WriteLine($"{Name} is feeding animal {animal.Name} ");
    }
    
}