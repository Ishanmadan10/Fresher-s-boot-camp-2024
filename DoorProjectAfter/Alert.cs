using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSelector
{

    // AlertFeature.cs
    using System;

    public class AlertFeature : ISmartDoorFeature
    {
        public void SetTimer(int interval)
        {
            // AlertFeature doesn't provide this feature
        }

        public void EnableAlert()
        {
            Console.WriteLine("Alert is now enabled.");
        }

        public void EnableAutoClose()
        {
            // AlertFeature doesn't provide this feature
        }

        public void NotifyAndClose()
        {
            // AlertFeature doesn't provide this feature
        }
    }


}
