using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLesson9
{
    public interface IMovable<T> where T :  Transport
    {
        public void Move();
    }
}
