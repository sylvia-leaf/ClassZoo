#ifndef LION_H
#define LION_H

#include <string>
#include "../include/Animal.h"

#pragma once

namespace ClassZoo {
class Lion : public ClassZoo::Animal {
    public:
        Lion(std::string inputName, int inputID, float inputWeight, float inputHeight);
        void PrintSpecies() override;
        void AnimalSound() override;
};
}

#endif