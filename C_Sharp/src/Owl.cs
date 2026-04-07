namespace ClassZoo;

public class Owl : Animal 
{
    public Owl(string inputName, int inputID, float inputWeight, float inputHeight) 
    : base(inputName, inputID, inputWeight, inputHeight)
    {
    }

    public override void PrintSpecies()
    {
        Console.WriteLine("Animal Species: Owl");
    }
    public override void AnimalSound()
    {
        Console.WriteLine($"{this.GetName() + " hoots"}");
    }
}