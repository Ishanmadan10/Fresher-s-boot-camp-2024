using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorProjectBefore
{
    
    public class SimpleDoor : IDoor
    {
        public DoorState State { get; private set; }

        public SimpleDoor()
        {
            State = DoorState.Closed;
        }

        public void Open()
        {
            State = DoorState.Opened;
            Console.WriteLine("Simple door is now open.");
        }

        public void Close()
        {
            State = DoorState.Closed;
            Console.WriteLine("Simple door is now closed.");
        }
    }

}
