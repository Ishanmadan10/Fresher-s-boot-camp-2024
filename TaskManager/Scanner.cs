using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerProj
{
    

    namespace TaskManager
    {
        public class Scanner : IScannable
        {
            public void Scan(string path)
            {
                Console.WriteLine($"Scanning .....{path}");
            }
        }
    }

}
