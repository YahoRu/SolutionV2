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

            var collection1 = new MyCollection<Transport>();
            var collection2 = new MyCollection<Transport>();
            var newCollection = new AnyCollection<Transport>();
            var collection3 = new AnyCollection<Transport>();

            collection1.AddInCollection(car1);
            collection1.AddInCollection(car2);
            collection1.AddInCollection(boat1);
            collection1.AddInCollection(boat2);

            newCollection.AddInCollection(car1);

            newCollection.Indexator(0);

            collection1.Indexator(2);

            Console.WriteLine(newCollection.AllElements);

            Console.WriteLine(collection1.AllElements);
        }
    }
}
