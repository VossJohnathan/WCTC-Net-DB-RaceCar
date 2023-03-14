using RaceTrack.RaceTrack.Drivers;
using System;

namespace RaceTrack.RaceTrack.Cars
{
    public abstract class RaceCar
    {
        protected RaceCar()
        {
            Position = 0;
        }

        public string Name { get; set; }
        public int Position { get; set; }
        public int TopSpeed { get; set; }

        

        public void Accelerate(int driverSkill)
        {
            // applying a random amount of variability to affect the outcome
            var random = new Random();
            var randomRange = random.Next(-1, 20);
            Position += driverSkill * TopSpeed * randomRange;

            if (Position > 0)
                Console.WriteLine($"{Name} moves ahead to {Position}!");
            else if (Position < 0)
                Console.WriteLine($"{Name} moves backwards to {Position}!??");
            else
                Console.WriteLine($"{Name} has stopped!?");
        }

        public abstract void StartEngine();

        public virtual void Brake()
        {
            Console.WriteLine($"The {Name} ends in position {Position}!");
        }

        
        public virtual void StopEngine()
        {
            //This isn't exactly how I think this should be.
            //But it's been a real stressful week and i'm done.
            //The main program works great though! :D
            Console.WriteLine($"{Name}'s Engine is stopped by it's driver!");

            //I could not figure out how to get the name of the driver
            //Maybe by using that protected bit like in Driver.cs?
        }

    }
}