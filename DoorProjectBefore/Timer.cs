using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorProjectBefore
{


    public class Timer
    {
        public void SetTimer(int interval)
        {
            Console.WriteLine($"Timer interval set to {interval} seconds.");
        }

        public int GetTimerValue()
        {
            Console.WriteLine("Enter Timer Interval (in seconds):");
            if (int.TryParse(Console.ReadLine(), out int enteredTimerInterval))
            {
                return enteredTimerInterval;
            }
            else
            {
                Console.WriteLine("Invalid timer interval. Using default value.");
                return 0; // Default value, you can set it to any suitable default
            }
        }

        public bool IsTimerValid(int enteredTimerInterval)
        {
            return enteredTimerInterval > 0; // Add any validation logic as needed
        }
    }

}
