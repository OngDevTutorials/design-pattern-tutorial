namespace DecoratorPattern.Base
{
    public abstract class MilkTeaDecorator : IMilkTea
    {
        private IMilkTea _milkTea;

        protected MilkTeaDecorator(IMilkTea inner)
        {
            _milkTea = inner;
        }

        public virtual double Cost()
        {
            return _milkTea.Cost();
        }
    }
}
