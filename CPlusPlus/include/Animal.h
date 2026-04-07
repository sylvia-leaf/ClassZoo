#ifndef ANIMAL_H
#define ANIMAL_H

#include <string>

#pragma once

namespace ClassZoo {
class Animal {
    public:
        Animal(std::string inputName, int inputID, float inputWeight, float inputHeight);
        std::string GetName();
        int GetID();
        float GetWeight();
        float GetHeight();
        void SetName(std::string newName);
        void SetID(int newID);
        void SetWeight(float newWeight);
        void SetHeight(float newHeight);
        void PrintInfo();
        virtual void PrintSpecies();
        virtual void AnimalSound();
    private:
        std::string name;
        int id;
        float weight;
        float height;
};
}
#endif