using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class LittleTimmy : Driver
    {
        public LittleTimmy(RaceCar car) : base(car)
        {
            Name = "Little Timmy";
            SkillLevel = 12;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

    }
}
