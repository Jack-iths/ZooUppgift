namespace ZooUppgift;

class Program
{
    static void Main(string[] args)
    {
       var a1 = new Animal("Kalle", "Get", "Herbivore");

        var zooKeeper = new ZooKeeper("Kalle");
        
        zooKeeper.FeedAnimal(a1);
    }
}