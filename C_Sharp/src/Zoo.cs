using System.Data;
using System.Runtime.InteropServices.Marshalling;

namespace ClassZoo;
    public class Zoo
    {
        private List<Animal> animals;
        private int zooSize;
        private string zooName;

        // Constructors
        public Zoo(int inputZooSize, string inputZooName)
        {
            animals = new List<Animal>();
            zooSize = inputZooSize;
            zooName = inputZooName;
        }

        public Zoo(int inputZooSize, string inputZooName, Animal inputAnimal)
        {
            animals = new List<Animal>();
            animals.Add(inputAnimal);
            zooSize = inputZooSize;
            zooName = inputZooName;
        }   

        public Zoo(int inputZooSize, string inputZooName, List<Animal> inputAnimals)
        {
            animals = inputAnimals;
            zooSize = inputZooSize;
            zooName = inputZooName;
        }

        // TODO: Learn iterators
        public void AddAnimal(Animal inputAnimal)
        {
            if (animals.Count() >= zooSize)
            {
                throw new Exception($"{zooName + " cannot have more than " + zooSize + " animals"}");
            }
            for (int a = 0; a < animals.Count(); a++)
            {
                if (animals[a].GetID() == inputAnimal.GetID())
                {
                    throw new Exception($"{"ID collision in " + zooName + " : " + inputAnimal.GetID()}");
                }
            }
            animals.Add(inputAnimal);
        }

        // TODO: Learn iterators
        public Animal GetAnimal(int inputID)
        {
            if (animals.Count() == 0)
            {
                throw new Exception($"{"Empty zoo: " + zooName}");
            }
            else
            {
                for (int a = 0; a < animals.Count(); a++)
                {
                    if (animals[a].GetID() == inputID)
                    {
                        return animals[a];
                    }
                }
                // Animal ID not found
                throw new Exception($"{"Animal ID not found in " + zooName + ": " + inputID}");
            }
        }

        // TODO: Learn iterators
        public void FreeAnimal(int inputID)
        {
            bool deleted = false;
            if (animals.Count() == 0)
            {
                throw new Exception($"{"Empty zoo: " + zooName}");
            }
            else
            {
                for (int a = 0; a < animals.Count(); a++)
                {
                    if ((animals[a].GetID() == inputID) && deleted == false)
                    {
                        animals.RemoveAt(a);
                        deleted = true;
                        break;
                    }
                }
                if (!deleted)
                {
                    throw new Exception($"{"Animal ID not found in " + zooName + ": " + inputID}");
                }
            }
        }

        // TODO: Learn iterators
        public void AnimalInfo(int inputID)
        {
            bool found = false;
            if (animals.Count() == 0)
            {
                throw new Exception($"{"Empty zoo: " + zooName}");
            }
            else
            {
                for (int a = 0; a < animals.Count(); a++)
                {
                    if (animals[a].GetID() == inputID)
                    {
                        animals[a].PrintInfo();
                        animals[a].PrintSpecies();
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    throw new Exception($"{"Animal ID not found in " + zooName + ": " + inputID}");
                }
            }
        }        
        // TODO: Learn iterators
        public void ListAnimals()
        {
            Console.WriteLine($"{"=== Information for zoo " + zooName + " ==="}");
            if (animals.Count() == 0)
            {
                Console.WriteLine("No animals in zoo.");
            }
            else
            {
                for (int a = 0; a < animals.Count(); a++)
                {
                    Console.WriteLine("=== Animal Information ===");
                    animals[a].PrintInfo();
                    animals[a].PrintSpecies();
                }
                Console.WriteLine("=== Information end ===");
            }
        }

        public List<Animal> GetAllAnimals()
        {
            return animals;
        }
    }