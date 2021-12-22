using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            var carsList = new List<Car>();

            for (int i = 0; i < 100000; i++)
            {
                carsList.Add(new Car(i));
            }

            stopWatch.Start();
            foreach (var car in carsList)
            {
                car.ChangeAge((343 * 34 * DateTime.Now.Millisecond * 77) / DateTime.Now.Minute);
            }
            stopWatch.Stop();
            TimeSpan ts2 = stopWatch.Elapsed; 
            Console.WriteLine(ts2);

            stopWatch.Start();
            for (int i = 0; i < carsList.Count; i++)
            {
                carsList[i].ChangeAge((343 * 34 * DateTime.Now.Millisecond * 77) / DateTime.Now.Minute);
            }
            stopWatch.Stop();
            TimeSpan ts3 = stopWatch.Elapsed;
            Console.WriteLine(ts3);

            stopWatch.Start();
            Parallel.ForEach(carsList, car => car.ChangeAge((343 * 34 * DateTime.Now.Millisecond * 77) / DateTime.Now.Minute));
            stopWatch.Stop();
            TimeSpan ts4 = stopWatch.Elapsed;
            Console.WriteLine(ts4);

            Action<int> ChangeCarAge = (int i) =>
            {
                carsList[i].ChangeAge((343 * 34 * DateTime.Now.Millisecond * 77) / DateTime.Now.Minute);
            };

            stopWatch.Start();
            Parallel.For(0, carsList.Count, ChangeCarAge);
            stopWatch.Stop();
            TimeSpan ts5 = stopWatch.Elapsed;
            Console.WriteLine(ts5);
        }
    }
}
