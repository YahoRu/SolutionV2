using System;
using LibraryLesson9;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            var boat1 = new Boat(20, 40);
            var boat2 = new Boat(50, 140);
            var car1 = new Car(250, 180);
            var car2 = new Car(310, 400);

            var newCollection = new MyCollection<Transport>();
            var collection3 = new MyCollection<Transport>();

            newCollection.AddInCollection(car2);
            collection3.AddInCollection(boat1);
            collection3.AddInCollection(boat2);
            newCollection.AddInCollection(car1);

            newCollection.Indexator(0);
            newCollection.Indexator(1);
            newCollection.Indexator(2);

            collection3.Indexator(0);
            collection3.Indexator(2);

            Console.WriteLine(newCollection.AllElements);

            Console.WriteLine(collection3.AllElements);
        }
    }
}
