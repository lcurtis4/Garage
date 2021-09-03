using System;

namespace Garage
{
    public class Vehicle 
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn()
        {
            Console.WriteLine("The vehichle makes a smooth right turn.");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehichle comes to a clean stop");
            Console.WriteLine(" ");
        }
    }
}