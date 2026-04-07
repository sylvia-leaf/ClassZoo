#include <iostream>
#include <string>
#include "../include/Owl.h"

namespace ClassZoo {
ClassZoo::Owl::Owl(std::string inputName, int inputID,
    float inputWeight, float inputHeight)
    : ClassZoo::Animal(inputName, inputID, inputWeight, inputHeight) {}
void ClassZoo::Owl::PrintSpecies() {
    std::cout << "Animal Species: Owl\n";
}
void ClassZoo::Owl::AnimalSound() {
    std::cout << ClassZoo::Animal::GetName() << " hoots\n";
}
}