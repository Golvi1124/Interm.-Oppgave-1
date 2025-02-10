namespace Interm._Oppgave_1.Classes;

// Generisk klasse som håndterer ulike datatyper
public class DataStorage<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void PrintAll()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}