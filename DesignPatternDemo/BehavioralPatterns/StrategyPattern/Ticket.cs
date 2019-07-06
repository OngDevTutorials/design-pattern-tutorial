using System;
namespace StrategyPattern
{
    public class Ticket
    {
        private IPromoteStrategy _promoteStrategy;
        private double _price;
        private string _name;

        public IPromoteStrategy GetPromoteStrategy()
        {
            return _promoteStrategy;
        }

        public void SetPromoteStrategy(IPromoteStrategy value)
        {
            _promoteStrategy = value;
        }

        public double GetPrice()
        {
            return _price;
        }

        public void SetPrice(double value)
        {
            _price = value;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }

        public Ticket()
        {

        }

        public Ticket(IPromoteStrategy promoteStrategy)
        {
            _promoteStrategy = promoteStrategy;
        }

        public double GetPromotedPrice()
        {
            return _promoteStrategy.DoDiscount(_price); 
        }
    }
}
