using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerProj.TaskManager;

namespace TaskManagerProj
{


    namespace TaskManagerProj
    {
        public class PrintScanner : IPrintable, IScannable
        {
            private IPrintable printable;
            private IScannable scannable;

            PrintScanner() { 
                printable = new Printer();
                scannable = new Scanner();

            }

            public void Print(string path) {
                printable.Print(path);
            }

            public void Scan (string path)
            {
                scannable.Scan(path);
            }
        }
    }

}
