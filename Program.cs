namespace ZooUppgift;

class Program
{
    static void Main(string[] args)
    {
        var animal = new Animal("", "", "");
        animal.AddAnimal("kalle", "get", "Herbivore");
        animal.Info();
    }
}