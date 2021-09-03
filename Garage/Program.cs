using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
        }
    }
}
