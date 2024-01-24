using System;
namespace DoorProject{
class Program
{
    static void Main()
    {
        var eventAggregator = new EventAggregator();

        Console.WriteLine("Which door do you want? (Simple/Smart):");
        string doorType = Console.ReadLine();

        if (doorType.Equals("Simple", StringComparison.OrdinalIgnoreCase))
        {
            // Simple Door
            var simpleDoor = new SimpleDoor(eventAggregator);

            Console.WriteLine("Opening simple door...");
            simpleDoor.Open();
            Console.WriteLine("Closing simple door...");
            simpleDoor.Close();
        }
        else if (doorType.Equals("Smart", StringComparison.OrdinalIgnoreCase))
        {
            // Smart Door
            Console.WriteLine("Configuring smart door...");

            Console.WriteLine("Do you want to use the buzzer? (yes/no):");
            bool useBuzzer = Console.ReadLine().Equals("yes", StringComparison.OrdinalIgnoreCase);

            Console.WriteLine("Do you want to use the notifier? (yes/no):");
            bool useNotifier = Console.ReadLine().Equals("yes", StringComparison.OrdinalIgnoreCase);

            Console.WriteLine("Do you want to enable auto close? (yes/no):");
            bool autoClose = Console.ReadLine().Equals("yes", StringComparison.OrdinalIgnoreCase);

            int timerInterval;
            do
            {
                Console.WriteLine("Enter the timer interval in seconds:");
            } while (!int.TryParse(Console.ReadLine(), out timerInterval) || timerInterval <= 0);

            var smartDoor = new SmartDoor(eventAggregator, timerInterval * 1000); // Convert seconds to milliseconds

            Console.WriteLine("Opening smart door...");
            smartDoor.ActivateSmartFeatures(useBuzzer,  useNotifier, autoClose);
            smartDoor.Open();
        }
        else
        {
            Console.WriteLine("Invalid door type. Please choose Simple or Smart.");
        }
    }
}

}
