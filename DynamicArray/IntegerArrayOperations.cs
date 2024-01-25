using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayProj
{
    public class IntegerArrayOperations : IArrayOperations
    {
        public void PerformOperations()
        {
            DynamicArray<int> numbers = new DynamicArray<int>(2);
            numbers.Add(0, 100);
            numbers.Add(1, 200);
            numbers.Add(2, 300);
            numbers.Add(3, 400);
            int value = numbers[2];
            System.Console.WriteLine($"Total Number Of Items in Array: {numbers.Count}, Value: {value} at index: 2");
        }
    }
}
