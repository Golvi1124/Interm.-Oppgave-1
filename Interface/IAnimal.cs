namespace Interm._Oppgave_1.Interface;

public interface IAnimal
{
   void MakeSound();
}

public interface ILegs
{
    int NumberOfLegs { get; set; }
}

public interface IPrintable
{
    void PrintAll();
}

