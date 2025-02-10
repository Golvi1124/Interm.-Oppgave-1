using Interm._Oppgave_1.Classes;
using Interm._Oppgave_1.Interface;

namespace Interm._Oppgave_1;

class Program
{
    static void Main(string[] args)
    {
        // Generic classes with different data types
        DataStorage<int> intStorage = new DataStorage<int>();
        intStorage.AddItem(10);
        intStorage.AddItem(20);
        intStorage.PrintAll();

        DataStorage<double> doubleStorage = new DataStorage<double>();
        doubleStorage.AddItem(9.5);
        doubleStorage.AddItem(21.9);
        doubleStorage.PrintAll();

        DataStorage<string> stringStorage = new DataStorage<string>();
        stringStorage.AddItem("Hello");
        stringStorage.AddItem("World");
        stringStorage.PrintAll();

        // Arrays
        int[] intArray = { 1, 2, 3, 4, 5 };
        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        string[] stringArray = { "One", "Two", "Three", "Four", "Five" };

        PrintArray(intArray);
        PrintArray(doubleArray);
        PrintArray(stringArray);

        //Generic method that prints any type of arrays.
        static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine(); //just to make empty line in the terminal


        // Interfaces
        List<IAnimal> animals = new List<IAnimal>();
        Dog dog = new Dog();
        Cat cat = new Cat();
        Chicken chicken = new Chicken();
        Fish fish = new Fish();

        animals.Add(dog);
        animals.Add(cat);
        animals.Add(chicken);
        animals.Add(fish);

        foreach (IPrintable animal in animals)
        {
            animal.PrintAll();
        }
    }
}