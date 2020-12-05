using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
