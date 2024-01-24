using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSelector
{
    // AutoCloseFeature.cs
    using System;

    public class Notify : ISmartDoorFeature
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
           
        }

        public void NotifyAndClose()
        {
            Console.WriteLine("NotifyAndClose is now enabled.");
        }
    }


}
