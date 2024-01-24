using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorProjectBefore
{
  
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose the type of door:");
            Console.WriteLine("0. Simple Door");
            Console.WriteLine("1. Smart Door");

            if (Enum.TryParse(Console.ReadLine(), out DoorType choice))
            {
                if (choice == DoorType.Simple)
                {
                    IDoor simpleDoor = new SimpleDoor();
                    simpleDoor.Open();
                    simpleDoor.Close();
                }
                else if (choice == DoorType.Smart)
                {
                    Timer timer = new Timer();
                    NotificationFeature notificationFeature = new NotificationFeature();
                    AutoCloseFeature autoCloseFeature = new AutoCloseFeature();
                    AlertFeature alertFeature = new AlertFeature();

                    SmartDoor smartDoor = new SmartDoor(timer, notificationFeature, autoCloseFeature, alertFeature);

                    // Subscribe to events
                    
                    smartDoor.NotificationSend += message => notificationFeature.SendNotification(message);
                    smartDoor.AutoCloseEnable += () => autoCloseFeature.EnableAutoClose();
                    smartDoor.MakeSoundAlert += message => alertFeature.MakeSoundAlert(message);

                    // Show the demo of NotifyAndClose
                    smartDoor.NotifyAndClose();

                    // Open and close the smart door
                    smartDoor.Open();
                    smartDoor.Close();
                }
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }

    public enum DoorType
    {
        Simple,
        Smart
    }

}
