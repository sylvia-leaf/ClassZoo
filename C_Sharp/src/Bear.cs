namespace ClassZoo;

public class Bear : Animal 
{
    public Bear(string inputName, int inputID, float inputWeight, float inputHeight) 
    : base(inputName, inputID, inputWeight, inputHeight)
    {
    }
    public override void PrintSpecies()
    {
        Console.WriteLine("Animal Species: Bear");
    }
    public override void AnimalSound()
    {
        Console.WriteLine($"{this.GetName() + " growls"}");
    }
}