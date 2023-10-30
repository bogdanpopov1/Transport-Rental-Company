using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Classes
{
    internal class Motobike : Transport
    {
        public override int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Colour { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string CategoryOfRights { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool IsRented { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int NumberOfWheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Motor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Motobike(int speed, string colour, string model, string categoryofrights, bool isrented, int numberofwheels, double motor) : base(speed, colour, model, categoryofrights, isrented, numberofwheels, motor)
        {
        }

        public override void Rent()
        {
            IsRented = true;
        }
    }
}
