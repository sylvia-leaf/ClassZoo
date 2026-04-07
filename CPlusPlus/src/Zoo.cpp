#include <format>
#include <iostream>
#include <memory>
#include <string>
#include <vector>
#include "../include/Animal.h"
#include "../include/Zoo.h"

namespace ClassZoo
{
ClassZoo::Zoo::Zoo(int inputZooSize, std::string inputZooName) {
    animals.clear();
    zooSize = inputZooSize;
    zooName = inputZooName;
}
ClassZoo::Zoo::Zoo(int inputZooSize, std::string inputZooName, std::unique_ptr<ClassZoo::Animal> inputAnimal) {
    animals.clear();
    animals.push_back(std::move(inputAnimal));
    zooSize = inputZooSize;
    zooName = inputZooName;
}
ClassZoo::Zoo::Zoo(int inputZooSize, std::string inputZooName, std::vector<std::unique_ptr<ClassZoo::Animal>> inputAnimals) {
    animals = std::move(inputAnimals);
    zooSize = inputZooSize;
    zooName = inputZooName;
}
void ClassZoo::Zoo::AddAnimal(std::unique_ptr<ClassZoo::Animal> inputAnimal) {
    if (animals.size() >= zooSize) {
        throw std::runtime_error(std::format("Zoo {} cannot have more than {} animals", zooName, zooSize));
    }
    for (int a = 0; a < animals.size(); a++) {
        if (animals.at(a)->GetID() == inputAnimal->GetID()) {
            throw std::runtime_error(std::format("ID collision in {}: {}", zooName, inputAnimal->GetID()));
        }
    }

    animals.push_back(std::move(inputAnimal));
}
ClassZoo::Animal& ClassZoo::Zoo::GetAnimal(int inputID) {
    if (animals.empty()) {
        throw std::runtime_error(std::format("Empty zoo: {}", zooName));
    } else {
        for (int a = 0; a < animals.size(); a++) {
            if (animals.at(a)->GetID() == inputID) {
                return *animals.at(a).get();
            }
        }
        // Animal ID not found
        throw std::runtime_error(std::format("Animal ID not found in {}: {}", zooName, inputID));
    }
}
void ClassZoo::Zoo::FreeAnimal(int inputID) {
    bool deleted = false;
    if (animals.empty()) {
        throw std::runtime_error(std::format("Empty zoo: {}", zooName));
    } else {
        for (int a = 0; a < animals.size(); a++) {
            if ((animals.at(a)->GetID() == inputID) && deleted == false) {
                animals.erase(animals.begin() + a);
                deleted = true;
                break;
            }
        }
        if (!deleted) {
            throw std::runtime_error(std::format("Animal ID not found in {}: {}", zooName, inputID));
        }
    }
}
void ClassZoo::Zoo::AnimalInfo(int inputID) {
    bool found = false;
    if (animals.empty()) {
        throw std::runtime_error(std::format("Empty zoo: {}", zooName));
    } else {
        for (int a = 0; a < animals.size(); a++) {
            if (animals.at(a)->GetID() == inputID) {
                animals.at(a)->PrintInfo();
                animals.at(a)->PrintSpecies();
                found = true;
                break;
            }
        }
        if (!found) {
            throw std::runtime_error(std::format("Animal ID not found in {}: {}", zooName, inputID));
        }
    }
}
void ClassZoo::Zoo::ListAnimals() {
    std::cout << std::format("=== Information for zoo {} ===\n", zooName);
    if (animals.empty()) {
        std::cout << "No animals in zoo.\n";
    } else {
        for (int a = 0; a < animals.size(); a++) {
            std::cout << "=== Animal Information ===\n";
            animals.at(a)->PrintInfo();
            animals.at(a)->PrintSpecies(); 
        }
        std::cout << "=== Information end ===\n";
    }
}
std::vector<std::unique_ptr<ClassZoo::Animal>>& ClassZoo::Zoo::GetAllAnimals() {
    return animals;
}
}