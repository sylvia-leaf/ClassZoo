#ifndef ZOO_H
#define ZOO_H

#include <memory>
#include <string>
#include <vector>
#include "../include/Animal.h"

#pragma once

namespace ClassZoo {
class Zoo {
    public:
        Zoo(int inputZooSize, std::string inputZooName);
        Zoo(int inputZooSize, std::string inputZooName, std::unique_ptr<ClassZoo::Animal> inputAnimal);
        Zoo(int inputZooSize, std::string inputZooName, std::vector<std::unique_ptr<ClassZoo::Animal>> inputAnimals);
        void AddAnimal(std::unique_ptr<ClassZoo::Animal> inputAnimal);
        ClassZoo::Animal& GetAnimal(int inputID);
        void FreeAnimal(int inputID);
        void AnimalInfo(int inputID);
        void ListAnimals();
        std::vector<std::unique_ptr<ClassZoo::Animal>>& GetAllAnimals();
    private:
        std::vector<std::unique_ptr<ClassZoo::Animal>> animals;
        int zooSize;
        std::string zooName;
};
}
#endif