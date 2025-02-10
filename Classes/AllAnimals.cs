using Interm._Oppgave_1.Interface;

namespace Interm._Oppgave_1.Classes;

public class Dog : IAnimal, ILegs, IPrintable
{
    public int NumberOfLegs { get; set; } = 4;

    public void MakeSound()
    {
        Console.WriteLine("Woof, woof!");
    }

    public void PrintAll()
    {
        Console.Write($"Dog has {NumberOfLegs} legs and says: ");
        MakeSound();
    }
}

public class Cat : IAnimal, ILegs, IPrintable
{
    public int NumberOfLegs { get; set; } = 4;

    public void MakeSound()
    {
        Console.WriteLine("Meow, meow!");
    }

    public void PrintAll()
    {
        Console.Write($"Cat has {NumberOfLegs} legs and says: ");
        MakeSound();
    }
}

public class Chicken : IAnimal, ILegs, IPrintable
{
    public int NumberOfLegs { get; set; } = 2;

    public void MakeSound()
    {
        Console.WriteLine("Cluck, cluck!");
    }

    public void PrintAll()
    {
        Console.Write($"Chicken has {NumberOfLegs} legs and says: ");
        MakeSound();
    }
}

public class Fish : IAnimal, ILegs, IPrintable
{
    public int NumberOfLegs { get; set; } = 0;
    public void MakeSound()
    {
        Console.WriteLine("Blub, blub!");
    }

    public void PrintAll()
    {
        Console.Write($"Fish has {NumberOfLegs} legs and says: ");
        MakeSound();
    }
}