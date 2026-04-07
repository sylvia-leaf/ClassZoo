#include <iostream>
#include <string>
#include "../include/Lion.h"

namespace ClassZoo {
ClassZoo::Lion::Lion(std::string inputName, int inputID,
    float inputWeight, float inputHeight)
    : ClassZoo::Animal(inputName, inputID, inputWeight, inputHeight) {}
void ClassZoo::Lion::PrintSpecies() {
    std::cout << "Animal Species: Lion\n";
}
void ClassZoo::Lion::AnimalSound() {
    std::cout << ClassZoo::Animal::GetName() << " roars\n";
}
}