using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public class Client
    {
        private readonly Dictionary<NewsType, bool> SubscribeList = new Dictionary<NewsType, bool>()
        {
            [NewsType.Animals] = false,
            [NewsType.Lightning] = false,
            [NewsType.Sport] = false,
            [NewsType.Weather] = false,
        };
        private string Name { get; set; }
        public Client(string name)
        {
            Name = name;
        }
        public void AddSubscribe(NewsType type, NewsProvider prov)
        {
            if (SubscribeList.ContainsKey(type) && !SubscribeList[type])
            {
                    SubscribeList[type] = true;
                    prov.News += ReadNews;
            }

        }
        public void RemoveSubscribe(NewsType type, NewsProvider prov)
        {
            if (SubscribeList.ContainsKey(type) && SubscribeList[type])
            {
                    SubscribeList[type] = false;
                    prov.News -= ReadNews;
            }
        }
        public void ReadNews(string str, NewsType type)
        {
            bool x = false;
            SubscribeList.TryGetValue(type, out x);
            if (x) { Console.WriteLine($"Клиент {Name}, подписанный на рассылку {type}, gолучил новость: {str}"); }
        }

    }
}
