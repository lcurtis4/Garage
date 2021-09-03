using System;

namespace Garage
{
    public class Cessna : Vehicle
    {

        public void ChargeBattery()
        {
            
        }

        public override void Drive()
        {
            Console.WriteLine($"The White Cessna flyes by with a Zoooom");
        }

        public override void Turn()
        {
            Console.WriteLine("The vehichle hands a right");
        }

        public override void Stop()
        {
            Console.WriteLine("The vehichle screaches to a stop");
            Console.WriteLine(" ");
        }
    }
}