using System.Collections.Generic;
using System.Linq;

namespace Assignment1.Model
{
    class Hand
    {
        private List<Car> cars;

        public Hand()
        {
            cars = new List<Car>();
        }

        public void addCar(Car c)
        {
            cars.Add(c);
        }

        public List<Car> CarWithSpeedAbove(int speed)
        {
            return cars.Where<Car>(c => c.kmPhr >= speed).ToList<Car>();
        }
    }
}
