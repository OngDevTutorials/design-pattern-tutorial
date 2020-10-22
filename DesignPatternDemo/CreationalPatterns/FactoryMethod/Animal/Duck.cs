using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Animal
{
    class Duck : TwoLegsAnimal
    {
        public override string GetName()
        {
            return "I am Duck";
        }
    }
}
