using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSelector
{

    public enum DoorState
    {
        Opened,
        Closed
    }

    public class SimpleDoor : IDoor
    {
        public DoorState State { get; set; }

        public SimpleDoor()
        {
            State = DoorState.Closed;
        }

        public void Open()
        {
            State = DoorState.Opened;
            Console.WriteLine("Door is now open.");
        }

        public void Close()
        {
            State = DoorState.Closed;
            Console.WriteLine("Door is now closed.");
        }
    }


}
