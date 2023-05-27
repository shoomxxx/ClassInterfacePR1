using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterfacePR1
{
    class Car : ITC, InterfaceCarTwo
    {
        public void CarName() => Console.WriteLine("NAME: Audi RS6");
        public void CarColor() => Console.WriteLine("COLOR: Белый");
        public void MaxSpeed() => Console.WriteLine("MAXSPEED: 550");
        public void DoorsInCar() => Console.WriteLine("DOORS: 5");
    }
}
