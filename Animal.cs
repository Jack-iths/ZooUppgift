using System.Globalization;

namespace ZooUppgift;

public class Animal
{
    public string Name { get; private set; }
    private string Species { get; set; }
    
    public string Diet { get; private set; }
    

    public Animal(string name, string species, string diet)
    {
        Name = name;
        Species = species;
        Diet = diet;

    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} The {Species} Makes a noise");
    }
    public string GetSpecies()
    {
        return Species;
    }


    private List<Animal> Animals = new List<Animal>();

    public void AddAnimal(string animal, string species, string diet)
    {
        Animals.Add(new Animal(animal, species, diet));
    }

    public void Info()
    {
        foreach (var a in Animals)
        {
            Console.WriteLine($"{a.Name} is a {a.GetSpecies()} and its diet is {a.Diet}");
        }
    }


}