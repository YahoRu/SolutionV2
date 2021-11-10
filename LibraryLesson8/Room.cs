using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLesson8
{
    public class Room
    {
        private Printer printer;

        public Room()
        {
            this.printer = new Printer();
        }

        public void MakeThisLazyPrinterWork(string value)
        {
            printer.Print(value);
        }

        public void ChangePrinter(Printer printer)
        {
            this.printer = printer;
        }
    }
}
