#ifndef BEAR_H
#define BEAR_H

#include <string>
#include "../include/Animal.h"

#pragma once

namespace ClassZoo {
class Bear : public ClassZoo::Animal {
    public:
        Bear(std::string inputName, int inputID, float inputWeight, float inputHeight);
        void PrintSpecies() override;
        void AnimalSound() override;
};
}

#endif