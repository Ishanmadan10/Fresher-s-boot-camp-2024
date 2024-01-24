using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoorSelector
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Choose the type of door:");
            Console.WriteLine("0. Simple Door");
            Console.WriteLine("1. Smart Door");

            if (Enum.TryParse(Console.ReadLine(), out DoorType choice))
            {
                IDoor selectedDoor = choice == DoorType.Simple ? new SimpleDoor() : new SmartDoor();
                SmartDoor smartDoor = selectedDoor as SmartDoor;

                if (smartDoor != null)
                {
                    Console.WriteLine("Starting the timer...");

                    Timer timer = new Timer();
                    await timer.Start(); // Start the timer with a predetermined value

                    Console.WriteLine("Timer finished. Choose Smart Door Features:");

                    for (int i = 0; i < smartDoor.Features.Count; i++)
                    {
                        Console.WriteLine($"{i}. {smartDoor.Features[i].GetType().Name}");
                    }

                    Console.WriteLine("Enter the feature numbers (separated by space) to execute:");
                    string[] selectedFeatureIndexes = Console.ReadLine().Split(' ');

                    List<int> selectedFeatures = new List<int>();
                    foreach (var indexStr in selectedFeatureIndexes)
                    {
                        if (int.TryParse(indexStr, out int index))
                        {
                            selectedFeatures.Add(index);
                        }
                    }

                    smartDoor.ExecuteSelectedFeatures(selectedFeatures);
                }

                selectedDoor.Open();
                selectedDoor.Close();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        public enum DoorType
        {
            Simple,
            Smart
        }
    }
}
