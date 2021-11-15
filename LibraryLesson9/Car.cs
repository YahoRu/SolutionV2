using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLesson9
{
    public class Car : Transport
    {
        private int MaxSpeed { get; set; }

        private int HorsePover { get; set; }
        public Car(int maxSpeed, int horsePover) : base(maxSpeed, horsePover)
        {
            MaxSpeed = maxSpeed;
            HorsePover = horsePover;
        }

        public override void Move()
        {
            Console.WriteLine("Started driving a Car");
        }

        public override string ToString()
        {

            return ($"Максимальная скорость: {MaxSpeed}, Количество лошадиных сил: {HorsePover}.");
        }
    }
}
