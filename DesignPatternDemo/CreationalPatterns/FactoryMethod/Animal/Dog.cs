using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Animal
{
    class Dog : FourLegsAnimal
    {
        public override string GetName()
        {
            return "I am Dog";
        }
    }
}
