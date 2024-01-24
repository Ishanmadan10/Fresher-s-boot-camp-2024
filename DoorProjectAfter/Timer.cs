using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSelector
{

    // Timer.cs
    using System;
    using System.Threading.Tasks;

    public class Timer : ISmartDoorFeature
    {
        private const int predeterminedValue = 5; // Predetermined timer value in seconds

        public async Task Start()
        {
            Console.WriteLine($"Timer started with a predetermined value of {predeterminedValue} seconds.");
            await Task.Delay(predeterminedValue * 1000); // Delay in milliseconds
        }

        public void SetTimer(int interval)
        {
            // Timer doesn't provide this feature
        }

        public void EnableAlert()
        {
            // Timer doesn't provide this feature
        }

        public void EnableAutoClose()
        {
            // Timer doesn't provide this feature
        }

        public void NotifyAndClose()
        {
            // Timer doesn't provide this feature
        }
    }


}

