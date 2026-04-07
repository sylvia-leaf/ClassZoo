#include <memory>
#include <string>
#include "../include/Animal.h"
#include "../include/Bear.h"
#include "../include/Lion.h"
#include "../include/Owl.h"
#include "../include/Zoo.h"



int main() {
    ClassZoo::Zoo myZoo(10, "My Zoo");
    myZoo.AddAnimal(std::make_unique<ClassZoo::Lion>("Amy", 1, 240.5f, 2.8f));
    myZoo.AddAnimal(std::make_unique<ClassZoo::Bear>("Bella", 2, 310.8f, 4.5f));
    myZoo.AddAnimal(std::make_unique<ClassZoo::Animal>("Undefined", 3, 0.0f, 0.0f));
    myZoo.AddAnimal(std::make_unique<ClassZoo::Owl>("Caitlyn", 4, 4.2f, 0.48f));
    myZoo.FreeAnimal(3);
    myZoo.GetAnimal(4).SetID(3);
    myZoo.ListAnimals();
    myZoo.GetAnimal(1).AnimalSound();
    myZoo.GetAnimal(2).AnimalSound();
    myZoo.GetAnimal(3).AnimalSound();
}