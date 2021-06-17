using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticProps
{
    class Car
    {
        //Automatic properties! no need to define backing fields
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public int MyReadOnlyProp { get; }
        public void DisplayStatus()
        {
            Console.WriteLine("Car Name:{0}", PetName);
            Console.WriteLine("Speed:{0}", Speed);
            Console.WriteLine("color:{0}",Color);

        }
    }
}
