using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan = new Fan();

            ICommand turnOnCommand = new TurnOnCommand(fan);
            ICommand turnOffCommand = new TurnOffCommand(fan);

            Remote remote = new Remote(turnOnCommand, turnOffCommand);

            remote.TurnOnButtonClick();
            remote.TurnOffButtonClick();
        }
    }
}
