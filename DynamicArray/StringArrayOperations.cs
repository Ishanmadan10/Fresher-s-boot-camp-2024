using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayProj
{
    public class StringArrayOperations : IArrayOperations
    {
        public void PerformOperations()
        {
            DynamicArray<string> stringItems = new DynamicArray<string>(2);
            stringItems.Add(0, "100");
            stringItems.Add(1, "200");
            stringItems.Add(2, "300");
            stringItems.Add(3, "400");
            string itemValue = stringItems[3];
            System.Console.WriteLine($"Total Number Of Items in Array: {stringItems.Count}, Value: {itemValue} at index: 3");
        }
    }
}
