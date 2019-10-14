using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Car
    {
        public int kmPhr { get; set; }
        public double PsPkW { get; set; }
        public int UPmin { get; set; }
        public int ccm { get; set; }
        public int zeroToHundred { get; set; }
        public int Zylinder { get; set; }

        private List<Car> _cars = new List<Car>();

        public void add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException("employee");
            }
            _cars.Add(car);
        }


    }
}
