using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start getting tickets!");

            var random = new Random();

            for(var i = 1; i <= 5; i++)
            {
                var ticket = new Ticket();
                ticket.SetName("Ticket " + i);
                ticket.SetPrice(50d * i);
                GeneratePromoteStrategy(random, ticket);
                LogTicketDetails(ticket);

                GeneratePromoteStrategy(random, ticket);
                LogTicketDetails(ticket);
            }
        }

        private static void LogTicketDetails(Ticket ticket)
        {
            Console.WriteLine(
                                "Promoted price of " +
                                ticket.GetName() +
                                " is " +
                                ticket.GetPromotedPrice() +
                                " " +
                                ticket.GetPromoteStrategy().GetType().Name +
                                "\n");
        }

        private static void GeneratePromoteStrategy(Random random, Ticket ticket)
        {
            var strategyIndex = random.Next(0, 4);
            switch (strategyIndex)
            {
                case 0:
                    ticket.SetPromoteStrategy(new NoDiscountStrategy());
                    break;
                case 1:
                    ticket.SetPromoteStrategy(new QuarterDiscountStrategy());
                    break;
                case 2:
                    ticket.SetPromoteStrategy(new HalfDiscountStrategy());
                    break;
                default:
                    ticket.SetPromoteStrategy(new EightyDiscountStrategy());
                    break;
            }
        }
    }
}
