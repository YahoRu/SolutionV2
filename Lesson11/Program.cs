using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            var sergey = new Client("Sergey");

            NewsProvider fastNews = new NewsProvider();

            sergey.AddSubscribe(NewsType.Sport, fastNews);

            fastNews.AddNews("Срочные Новости", NewsType.Lightning);

            fastNews.AddNews("Новости про спорт", NewsType.Sport);

            sergey.AddSubscribe(NewsType.Lightning, fastNews);
            sergey.AddSubscribe(NewsType.Lightning, fastNews);
            sergey.AddSubscribe(NewsType.Lightning, fastNews);
            sergey.AddSubscribe(NewsType.Lightning, fastNews);
            sergey.AddSubscribe(NewsType.Lightning, fastNews);

            sergey.RemoveSubscribe(NewsType.Sport, fastNews);
            sergey.RemoveSubscribe(NewsType.Sport, fastNews);

            fastNews.AddNews("Срочные Новости2", NewsType.Lightning);

            fastNews.AddNews("Новости про спорт2", NewsType.Sport);
        }
    }
}
