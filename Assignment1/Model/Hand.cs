using System.Collections.Generic;

namespace Assignment1.Model
{
    class Hand
    {
        List<Car> cars;

        public Hand(List<Car> car)
        {
            cars = new List<Car>(car);
        }
    }
}
