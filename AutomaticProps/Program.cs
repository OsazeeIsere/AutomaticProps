using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Fun with Automatic Properties");
            Car myCar = new Car();
            myCar.PetName = "Bitto";
            myCar.Speed = 90;
            myCar.Color = "Blue";
            Console.WriteLine("Your car is {0}", myCar.PetName);
            myCar.DisplayStatus();
            Console.ReadLine();

            //printing the default values of auto-
            //generated backing fied
            Garage g = new Garage();
            //print the default value of zero

            //put car into the garage
            g.MyAuto =myCar;
            Console.WriteLine("Number of car {0}", g.NumberOfCars);
            Console.WriteLine("Your car is {0}",g.MyAuto.PetName);
            Console.ReadLine();


        }
    }
}
