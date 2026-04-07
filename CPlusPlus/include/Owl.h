#ifndef OWL_H
#define OWL_H

#include <string>
#include "../include/Animal.h"

#pragma once

namespace ClassZoo {
class Owl : public ClassZoo::Animal {
    public:
        Owl(std::string inputName, int inputID, float inputWeight, float inputHeight);
        void PrintSpecies() override;
        void AnimalSound() override;
};
}

#endif