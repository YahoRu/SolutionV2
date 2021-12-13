using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace Lesson14
{
    public class Person
    {
        [MyAttribute(@"^[a-z|а-я]{3,}$")]
        private string Name { get; set; }
        [MyAttribute(@"^[a-z|а-я]{3,}$")]
        private string SecondName { get; set; }
        //[Range(10, 99, ErrorMessage = "Возраст не дожен быть меньше 10 и больше 120")]
        [MyAttribute(@"^[1-9][0-9]$")]
        private int Age { get; set; }

        public Person(string name, string secondName, int age)
        {
            Name = name;
            SecondName = secondName;
            Age = age;
        }

        public bool IsValid()
        {
            Type type = this.GetType();

            PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (PropertyInfo property in properties)
            {
                foreach (var attrib in property.GetCustomAttributes())
                {
                    var temp = attrib as MyAttribute;
                    if (temp != null && !temp.IsCorrect(property.GetValue(this).ToString()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
