using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterfacePR1
{
    public class Scooter : ITC, InterfaceCarTwo
    {
        public void CarName() => Console.WriteLine("NAME: Welz 31");
        public void CarColor() => Console.WriteLine("COLOR: Черно - белый");
        public void MaxSpeed() => Console.WriteLine("MAXSPEED: 30");
        public void DoorsInCar() => Console.WriteLine("DOORS: 0");
    }

}
