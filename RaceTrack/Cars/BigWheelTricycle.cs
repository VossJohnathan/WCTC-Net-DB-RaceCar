using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class BigWheelTricycle : RaceCar
    { 
        public BigWheelTricycle()
        {
            Name = "Timmy's Big Wheel Tricycle";
            TopSpeed = 120;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"Little Timmy is making engine noises!");
        }

        public override void Brake()
        {
            Console.WriteLine($"Little Timmy does a sick drift to stop across the finish line!");
            base.Brake();
        }
    }
}
