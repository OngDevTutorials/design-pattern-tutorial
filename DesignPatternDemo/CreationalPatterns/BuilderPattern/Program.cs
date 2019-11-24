using System;
using BuilderPattern.CarParts;

namespace BuilderPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      var car = new Car(4,
                        new SeatBelt("OngDev"),
                        "red",
                        new Windscreen("OngDev"),
                        new Engine("Foot"));
      var carByBuilder = new CarBuilder()
                                .AddWheels(4)
                                .AddSeatBelts(new SeatBelt("Ong Dev Seat Belt"))
                                .AddWindscreen(new Windscreen("Ong Dev wind screen"))
                                .AddEngine(new Engine("Ong Dev Foot"))
                                .Paint("red")
                                .Build();
      Console.WriteLine(car.ToString());
      Console.WriteLine("------------------------------------");
      Console.WriteLine(carByBuilder.ToString());
    }
  }
}
