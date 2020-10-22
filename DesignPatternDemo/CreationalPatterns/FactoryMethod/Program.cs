using FactoryMethod.AbstractFactory;
using FactoryMethod.Animal;
using FactoryMethod.Factory;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            IAnimalFactory factory;

            Random random = new Random();
            int type = random.Next(0, 2);

            if(type == 0)
            {
                factory = new FourLegsAnimalFactory();
            }
            else
            {
                factory = new TwoLegsAnimalFactory();
            }

            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
        }
    }
}
