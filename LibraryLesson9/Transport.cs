using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLesson9
{
    public class Transport
    {
        private int MaxSpeed { get; set; }  
        private int HorsePover { get; set; }

        public Transport(int maxSpeed, int horsePover)
        {
            MaxSpeed = maxSpeed;
            HorsePover = horsePover;
        }

        public virtual void Move()
        {
            Console.WriteLine("Start Moving");
        }
    }
}
