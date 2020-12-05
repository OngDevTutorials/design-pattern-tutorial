using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class TurnOffCommand : ICommand
    {
        private readonly Fan fan;

        public TurnOffCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.TurnOff();
        }

        public void Undo()
        {
            fan.TurnOn();
        }
    }
}
