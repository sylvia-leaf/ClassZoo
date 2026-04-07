using System.Reflection.PortableExecutable;

namespace ClassZoo;

public class Animal {
    private string name;
    private int id;
    private float weight;
    private float height;

    public Animal(string inputName, int inputID, float inputWeight, float inputHeight)
    {
        name = inputName;
        id = inputID;
        weight = inputWeight;
        height = inputHeight;
    }

    // Getters
    public string GetName()
    {
        return name;
    }
    public int GetID()
    {
        return id;
    }
    public float GetWeight()
    {
        return weight;
    }
    public float GetHeight()
    {
        return height;
    }

    // Setters
    public void SetName(string newName)
    {
        name = newName;
    }
    public void SetID(int newID)
    {
        id = newID;
    }
    public void SetWeight(float newWeight)
    {
        weight = newWeight;
    }
    public void SetHeight(float newHeight)
    {
        height = newHeight;
    }

    // Print information
    public void PrintInfo()
    {
        // TODO: Proper formatting
        Console.WriteLine($"{"Animal Name: " + name + "\nAnimal ID: " + id + "\nAnimal Weight: " + Math.Round(weight * 1000) / 1000 + "\nAnimal Height: " + Math.Round(height * 100) / 100}");
    }
    public virtual void PrintSpecies()
    {
        Console.WriteLine("Animal Species: Not Specified");
    }
    public virtual void AnimalSound()
    {
        Console.WriteLine($"{name + " makes a sound"}");
    }
}