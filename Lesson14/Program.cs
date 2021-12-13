using System;
using System.Text.RegularExpressions;

namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("андрей", "Goggie", 18);
            Console.WriteLine(person1.IsValid()); 
        }
    }
}
