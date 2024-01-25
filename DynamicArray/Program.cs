using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicArrayProj;

namespace DynamucArrayProj
{
    public class Program
    {
        static void Main()
        {
            IArrayOperations integerOperations = new IntegerArrayOperations();
            integerOperations.PerformOperations();

            IArrayOperations stringOperations = new StringArrayOperations();
            stringOperations.PerformOperations();
        }
    }

}
