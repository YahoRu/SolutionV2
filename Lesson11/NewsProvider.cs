using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public class NewsProvider
    {
        public event Action<string, NewsType> News;


        public void AddNews(string str, NewsType type)
        {
            News?.Invoke(str, type);
        }
    }
}
