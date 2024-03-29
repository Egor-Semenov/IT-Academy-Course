﻿using FirstTask.Models;
using System;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room();

            GreenPrinter greenPrinter = new GreenPrinter();
            room.printer = greenPrinter;

            room.MakeThisLazyPrinterWork("У этого принтера зелёные чернила!");

            BluePrinter bluePrinter = new BluePrinter();

            room.ChangePrinter(bluePrinter);

            room.MakeThisLazyPrinterWork("У этого принтера синие чернила!");
        }
    }
}
