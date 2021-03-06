using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLesson9
{
    public class Car : Transport, IMovable<Transport>
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
            try
            {
                return ($"Это машина. Максимальная скорость: {MaxSpeed}, Количество лошадиных сил: {HorsePover}.");
            }
            catch
            {
                return ($"Не найдено!");
            }
        }
    }
}
