using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerProj
{


    namespace TaskManagerProj
    {
        public class PrintScanner : IPrintable, IScannable
        {
            public void Print(string path)
            {
                Console.WriteLine($"Printing .....{path} (from PrintScanner)");
            }

            public void Scan(string path)
            {
                Console.WriteLine($"Scanning .....{path} (from PrintScanner)");
            }
        }
    }

}
