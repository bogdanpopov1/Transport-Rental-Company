using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Company.Classes
{


    class Boat : Transport
    {
        public override int Speed { get; set; }
        public override string Colour { get; set; }
        public override string Model { get; set; }
        public override string CategoryOfRights { get; set; }
        public override bool IsRented { get; set; }
        public override int NumberOfWheels { get; set; }
        public override double Motor { get; set; }

        public Boat(int speed, string colour, string model, string categoryofrights, bool isrented, int numberofwheels, double motor) : base(speed, colour, model, categoryofrights, isrented, numberofwheels, motor)
        {
        }

        public override void Rent()
        {
            IsRented = true; 
        }

        
    }
}
