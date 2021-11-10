using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLesson8
{
    public class BluePrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ResetColor();
        }   
    }
}
