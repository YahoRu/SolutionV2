using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson14
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class MyAttribute : System.Attribute
    {
        private readonly string RegexForCheck;

        public MyAttribute(string regex)
        {
            this.RegexForCheck = regex;
        }

        public string regexForCheck
        {
            get { return RegexForCheck; }
        }

        public bool IsCorrect(string value)
        {
            if (Regex.IsMatch(value.ToString(), this.regexForCheck, RegexOptions.IgnoreCase))
            {
                return true;
            }
            else return false;
        }
    }
}
