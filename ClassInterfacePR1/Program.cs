using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterfacePR1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORMATION ABOUT CAR");

            Car CarInfo = new Car();
            CarInfo.CarName();
            CarInfo.CarColor();
            CarInfo.DoorsInCar();
            CarInfo.MaxSpeed();

            Console.WriteLine("");
            Console.WriteLine("INFORMATION ABOUT SCOOTER");

            Scooter ScooterInfo = new Scooter();
            ScooterInfo.CarName();
            ScooterInfo.CarColor();
            ScooterInfo.DoorsInCar();
            ScooterInfo.MaxSpeed();

            Console.WriteLine("");
            Console.WriteLine("INFORMATION ABOUT ELECTROSCOOTER");

            ElecScooter ElecScooterInfo = new ElecScooter();
            ElecScooterInfo.CarName();
            ElecScooterInfo.CarColor();
            ElecScooterInfo.DoorsInCar();
            ElecScooterInfo.MaxSpeed();
            Console.ReadKey();
        }
    }
}
