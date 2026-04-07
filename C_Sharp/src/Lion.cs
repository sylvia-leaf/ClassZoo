namespace ClassZoo;

public class Lion : Animal 
{
    public Lion(string inputName, int inputID, float inputWeight, float inputHeight) 
    : base(inputName, inputID, inputWeight, inputHeight)
    {
    }

    public override void PrintSpecies()
    {
        Console.WriteLine("Animal Species: Lion");
    }
    public override void AnimalSound()
    {
        Console.WriteLine($"{this.GetName() + " roars"}");
    }
}