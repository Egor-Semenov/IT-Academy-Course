using FirstTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class Room
    {
        public Printer printer;

        public void MakeThisLazyPrinterWork(string value)
        {
            printer.Print(value);
        }

        public Printer ChangePrinter(Printer printer)
        {
            this.printer = printer;
            return printer;
        }
    }
}
