#include <iostream>
#include <string>
#include <cmath>
#include "../include/Animal.h"

namespace ClassZoo
{
ClassZoo::Animal::Animal(std::string inputName, int inputID,
    float inputWeight, float inputHeight) {
    name = inputName;
    id = inputID;
    weight = inputWeight;
    height = inputHeight;
}
// getters
std::string ClassZoo::Animal::GetName() {
    return name;
}
int ClassZoo::Animal::GetID() {
    return id;
}
float ClassZoo::Animal::GetWeight() {
    return weight;
}
float ClassZoo::Animal::GetHeight() {
    return height;
}
// setters
void ClassZoo::Animal::SetName(std::string newName) {
    name = newName;
}
void ClassZoo::Animal::SetID(int newID) {
    id = newID;
}
void ClassZoo::Animal::SetWeight(float newWeight) {
    weight = newWeight;
}
void ClassZoo::Animal::SetHeight(float newHeight) {
    height = newHeight;
}
// print information
void ClassZoo::Animal::PrintInfo() {
    std::cout << "Animal Name: " << name << "\nAnimal ID: " << id
        << "\nAnimal Weight: " << std::round(1000 * weight) / 1000
        << "\nAnimal Height: " << std::round(100 * height) / 100 << "\n";
}
void ClassZoo::Animal::PrintSpecies() {
    std::cout << "Animal Species: Not Specified\n";
}
void ClassZoo::Animal::AnimalSound() {
    std::cout << name << " makes a sound\n";
}
}
