using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticProps
{
    class Garage
    {
        //the hidden int backing field is set to zero
        public int NumberOfCars { get; set; }

        //the hidden car backing field is set to null
        public Car MyAuto { get; set; }

        //must use constructor to overide default values
        //assigned to hidden backing fields
        public Garage()
        {
            MyAuto = new Car();
            NumberOfCars = 1;
        }
        public Garage(Car car,int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }

    }
}
