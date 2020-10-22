using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Animal
{
    abstract class TwoLegsAnimal : IAnimal
    {
        public abstract string GetName();
    }
}
