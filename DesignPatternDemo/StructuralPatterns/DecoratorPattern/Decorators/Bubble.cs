using DecoratorPattern.Base;

namespace DecoratorPattern.Decorators
{
    public class Bubble : MilkTeaDecorator
    {
        public Bubble(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 1d + base.Cost();
        }
    }
}
