using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Animal
{
    class Cat : FourLegsAnimal
    {
        public override string GetName()
        {
            return "I am Cat";    
        }
    }
}
