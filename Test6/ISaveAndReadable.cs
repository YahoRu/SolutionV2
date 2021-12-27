using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Test6
{
    public interface ISaveAndReadable<T> where T : Client
    {
        void Save();
        void Read();

    }
}
