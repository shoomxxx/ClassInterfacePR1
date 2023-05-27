using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterfacePR1
{
    class ElecScooter : Scooter
    {
        public new void CarName() => Console.WriteLine("NAME: Whoosh k612");
        public new void CarColor() => Console.WriteLine("COLOR: Orange");
        public new void MaxSpeed() => Console.WriteLine("MAXSPEED: 50");
        public new void DoorsInCar() => Console.WriteLine("DOORS: 0");
    }

}
