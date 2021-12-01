using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public class NullShopExeption : Exception
    {
        public NullShopExeption(string message) : base(message)
        {
        }

    }
}
