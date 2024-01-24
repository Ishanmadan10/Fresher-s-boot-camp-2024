using System;
using System.Collections.Generic;

namespace DoorSelector
{
    public class SmartDoor : SimpleDoor, ISmartDoorFeature
    {
        private readonly List<ISmartDoorFeature> features;

        public List<ISmartDoorFeature> Features => features;


        public SmartDoor()
        {
            features = new List<ISmartDoorFeature>
            {
                new AutoCloseFeature(),
                new AlertFeature(),
                new Notify()
                // Add more features as needed
            };
        }

        public void AddFeature(ISmartDoorFeature feature)
        {
            features.Add(feature);
        }

        public void SetTimer(int interval)
        {
            foreach (var feature in features)
            {
                feature.SetTimer(interval);
            }
        }

        public void EnableAlert()
        {
            foreach (var feature in features)
            {
                feature.EnableAlert();
            }
        }

        public void EnableAutoClose()
        {
            foreach (var feature in features)
            {
                feature.EnableAutoClose();
            }
        }

        public void NotifyAndClose()
        {
            foreach (var feature in features)
            {
                feature.NotifyAndClose();
            }
        }

        // Additional method to execute selected features
        public void ExecuteSelectedFeatures(List<int> selectedFeatures)
        {
            foreach (var featureIndex in selectedFeatures)
            {
                if (featureIndex >= 0 && featureIndex < features.Count)
                {
                    ISmartDoorFeature selectedFeature = features[featureIndex];

                    Console.WriteLine($"Executing {selectedFeature.GetType().Name} feature:");

                    selectedFeature.NotifyAndClose();
                }
                else
                {
                    Console.WriteLine($"Invalid feature index: {featureIndex}");
                }
            }
        }
    }
}
