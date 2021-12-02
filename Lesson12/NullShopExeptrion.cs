using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public class NullShopException : Exception
    {
        public NullShopException()
        {
        }

        public NullShopException(string message) : base(message)
        {
        }

    }
}
