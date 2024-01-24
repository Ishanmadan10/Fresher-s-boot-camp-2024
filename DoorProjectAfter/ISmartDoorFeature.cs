using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSelector
{
    
    public interface ISmartDoorFeature
    {
        void SetTimer(int interval);
        void EnableAlert();
        void EnableAutoClose();
        void NotifyAndClose();
    }

}
