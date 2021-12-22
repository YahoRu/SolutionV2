using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    public class Car
    {
        private int Age { get; set; }

        public Car(int age)
        {
            Age = age;
        }

        public void ChangeAge(int age)
        {
            Age = age;
        }
    }
}
