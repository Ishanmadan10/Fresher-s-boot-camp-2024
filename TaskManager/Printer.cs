using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerProj;


namespace TaskManagerProj
{

   
        public class Printer : IPrintable
        {
            public void Print(string path)
            {
                Console.WriteLine($"Printing .....{path}");
            }
        }
    }


