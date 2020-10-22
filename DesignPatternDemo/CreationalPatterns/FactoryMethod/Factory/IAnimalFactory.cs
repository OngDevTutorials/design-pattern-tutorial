using FactoryMethod.Animal;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factory
{
    interface IAnimalFactory
    {
        IAnimal createAnimal();
    }
}
