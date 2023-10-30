using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Company.Classes
{
    abstract class Transport
    {
        public abstract int Speed { get; set; }
        public abstract string Colour { get; set; }
        public abstract string Model { get; set; }
        public abstract string CategoryOfRights { get; set; }
        public abstract bool IsRented { get; set; }
        public abstract int NumberOfWheels { get; set; }
        public abstract double Motor { get; set; }

        protected Transport(int speed, string colour, string model, string categoryofrights, bool isrented, int numberofwheels, double motor)
        {
            Speed = speed;
            Colour = colour;
            Model = model;
            CategoryOfRights = categoryofrights;
            IsRented = isrented;
            NumberOfWheels = numberofwheels;
            Motor = motor;
        }
        public abstract void Rent();
    }
}
