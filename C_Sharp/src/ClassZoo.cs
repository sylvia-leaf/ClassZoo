namespace ClassZoo;

class ClassZoo
{
    static void Main(string[] args)
    {
        Zoo MyZoo = new Zoo(10, "My Zoo");
        MyZoo.AddAnimal(new Lion("Amy",1,240.5f,2.8f));
        MyZoo.AddAnimal(new Bear("Bella",2,310.8f,4.5f));
        MyZoo.AddAnimal(new Animal("Undefined",3,0.0f,0.0f));
        MyZoo.AddAnimal(new Owl("Caitlyn",4,4.2f,0.48f));
        MyZoo.FreeAnimal(3);
        MyZoo.GetAnimal(4).SetID(3);
        MyZoo.ListAnimals();
        MyZoo.GetAnimal(1).AnimalSound();
        MyZoo.GetAnimal(2).AnimalSound();
        MyZoo.GetAnimal(3).AnimalSound();  
    }
}
