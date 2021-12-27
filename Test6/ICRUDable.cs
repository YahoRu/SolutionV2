using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    public interface ICRUDable<T> where T : Client
    {
        void Create(T obj);
        T Read(string name);
        void Update(string name);
        void Delete(string name);
    }
}
