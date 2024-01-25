using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerProj.TaskManagerProj;
using TaskManagerProj.TaskManager;

namespace TaskManagerProj

{
        class Program
        {
            static void Main()
            {
                IPrintable printerObj = new Printer();
                IScannable scannerObj = new Scanner();
                IPrintable printScannerObj = new PrintScanner();
                IScannable printScannerScannableObj = new PrintScanner();

                TaskManagerClass.ExecutePrintTask(printerObj, "Test.doc");
                TaskManagerClass.ExecuteScanTask(scannerObj, "MyImage.png");
                TaskManagerClass.ExecutePrintTask(printScannerObj, "NewDoc.doc");
                TaskManagerClass.ExecuteScanTask(printScannerScannableObj, "YourImage.png");
            }
        }
    }

