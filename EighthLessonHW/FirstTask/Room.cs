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
        Printer printer;

        public Printer Printer
        {
            get
            {
                return printer;
            }
            set
            {
                printer = value;
            }
        }

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
