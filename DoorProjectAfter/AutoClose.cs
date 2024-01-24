using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSelector
{
    public class AutoCloseFeature : ISmartDoorFeature
    {
        public void SetTimer(int interval)
        {
            // AutoCloseFeature doesn't provide this feature
        }

        public void EnableAlert()
        {
            // AutoCloseFeature doesn't provide this feature
        }

        public void EnableAutoClose()
        {
            Console.WriteLine("Auto close is now enabled.");
        }

        public void NotifyAndClose()
        {
            // AutoCloseFeature doesn't provide this feature
        }
    }


}
