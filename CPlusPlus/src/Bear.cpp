#include <iostream>
#include <string>
#include "../include/Bear.h"

namespace ClassZoo {
ClassZoo::Bear::Bear(std::string inputName, int inputID,
    float inputWeight, float inputHeight)
    : ClassZoo::Animal(inputName, inputID, inputWeight, inputHeight) {}
void ClassZoo::Bear::PrintSpecies() {
    std::cout << "Animal Species: Bear\n";
}
void ClassZoo::Bear::AnimalSound() {
    std::cout << ClassZoo::Animal::GetName() << " growls\n";
}
}