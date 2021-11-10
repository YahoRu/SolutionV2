using System;
using LibraryLesson8;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer1 = new Printer();
            Printer printer2 = new GreenPrinter();
            Printer printer3 = new BluePrinter();

            printer1.Print("Wtf");
            printer2.Print("Wtf");
            printer3.Print("Wtf");

            Room room1 = new Room();
            room1.MakeThisLazyPrinterWork("Hi");
            room1.ChangePrinter(printer2);
            room1.MakeThisLazyPrinterWork("Hi Mark");
            room1.ChangePrinter(printer3);
            room1.MakeThisLazyPrinterWork("Hello");
        }
    }
}
