using FactoryMethod.Animal;
using FactoryMethod.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.AbstractFactory
{
    abstract class AbstractAnimalFactory : IAnimalFactory
    {
        public abstract IAnimal createAnimal();
    }
}
