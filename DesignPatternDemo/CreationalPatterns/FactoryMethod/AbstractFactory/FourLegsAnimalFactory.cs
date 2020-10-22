using FactoryMethod.Animal;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.AbstractFactory
{
    class FourLegsAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimal createAnimal()
        {
            Random random = new Random();
            int type = random.Next(0, 2);
            if (type == 0)
            {
                return new Dog();
            }
            else
            {
                return new Cat();
            }
        }
    }
}
