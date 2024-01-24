using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorProjectBefore
{
    
    public interface IDoor
    {
        DoorState State { get; }
        void Open();
        void Close();
    }

    public enum DoorState
    {
        Opened,
        Closed
    }

}
