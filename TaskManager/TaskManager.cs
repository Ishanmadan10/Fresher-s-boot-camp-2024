using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerProj
{
    
        public static class TaskManagerClass
        {
            public static void ExecutePrintTask(IPrintable printable, string documentPath)
            {
                printable.Print(documentPath);
            }

            public static void ExecuteScanTask(IScannable scannable, string documentPath)
            {
                scannable.Scan(documentPath);
            }
        }
    }




