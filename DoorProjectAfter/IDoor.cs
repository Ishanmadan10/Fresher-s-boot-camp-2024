using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSelector
{
    public interface IDoor
    {
        DoorState State { get; }
        void Open();
        void Close();
    }

  
}
