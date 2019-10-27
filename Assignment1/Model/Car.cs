using System.Collections.Generic;
using System.Linq;

namespace Assignment1.Model
{
    class Car
    {
        public int kmPhr { get; set; }
        public double psPkw { get; set; }
        public int uPmin { get; set; }
        public int ccm { get; set; }
        public double zeroToHundred { get; set; }
        public int zylinder { get; set; }


        public Car(int kmPhr, double psPkw, int uPmin, int ccm, double zeroToHundred, int zylinder)
        {
            this.kmPhr = kmPhr;
            this.psPkw = psPkw;
            this.uPmin = uPmin;
            this.ccm = ccm;
            this.zeroToHundred = zeroToHundred;
            this.zylinder = zylinder;
        }
        public Car() { }

        public List<Car> addCars(Car car)
        {
            List<Car> _cars = new List<Car>();
            List<Car> sortedCar = new List<Car>();
            _cars.Add(car);
            sortedCar.AddRange(_cars.OrderBy(o => o.kmPhr));

            return sortedCar;
        }


    }
}
