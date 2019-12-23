using System;
using System.Collections.Generic;
using Assignment1.Model;


namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 STORING THE CAR IN THE LIST

            List<Car> cars = new List<Car>();

            cars.Add(new Car(265, 300 / 220.5, 5900, 2994, 6.0, 6));
            cars.Add(new Car(266, 300 / 220, 5905, 2995, 5.9, 6));
            cars.Add(new Car(267, 300 / 219, 5904, 2993, 6.2, 6));
            cars.Add(new Car(268, 300 / 218, 5903, 2992, 5.8, 6));
            cars.Add(new Car(269, 300 / 217.5, 5902, 2991, 6.1, 6));
            cars.Add(new Car(270, 300 / 217, 5901, 2996, 5.99, 6));

            cars.ForEach(c => Console.WriteLine(c + "\n"));
            Console.WriteLine(" ");
            #endregion

            #region 2 SORTED CAR ON ALL OF THEIR PROPERTIES
            Console.WriteLine("CAR SORTED BY TOP SPEED.");
            cars.Sort();
            cars.ForEach(c => Console.WriteLine(c + "\n"));
            Console.WriteLine(" ");

            Console.WriteLine("CAR SORTED BY Ps/kw.");
            cars.Sort(new Car.SortingByPsPkw());
            cars.ForEach(c => Console.WriteLine(c + "\n"));
            Console.WriteLine(" ");

            Console.WriteLine("CAR SORTED BY U/Min.");
            cars.Sort(new Car.SortingByUPMin());
            cars.ForEach(c => Console.WriteLine(c + "\n"));
            Console.WriteLine(" ");

            //Console.WriteLine("CAR SORTED BY CCM.");
            //cars.Sort(new Car.SortingByCcm());
            //cars.ForEach(c => Console.WriteLine(c + "\n"));
            //Console.WriteLine(" ");

            Console.WriteLine("CAR SORTED BY 0-100 km/hr.");
            cars.Sort(new Car.SortingByZeroToHund());
            cars.ForEach(c => Console.WriteLine(c + "\n"));
            Console.WriteLine(" ");

            //Console.WriteLine("CAR SORTED BY Zylinder.");
            //cars.Sort(new Car.SortingByZylinder());
            //cars.ForEach(c => Console.WriteLine(c + "\n"));
            //Console.WriteLine(" ");


            #endregion

            #region 3 IMPLEMENTATION OF HAND CLASS AND SPEED MORE THAN X
            Hand h = new Hand();

            h.addCar(new Car(265, 300 / 220.5, 5900, 2994, 6.0, 6));
            h.addCar(new Car(266, 300 / 220, 5905, 2995, 5.9, 6));
            h.addCar(new Car(267, 300 / 219, 5904, 2993, 6.2, 6));
            h.addCar(new Car(268, 300 / 218, 5903, 2992, 5.8, 6));
            h.addCar(new Car(269, 300 / 217.5, 5902, 2991, 6.1, 6));
            h.addCar(new Car(270, 300 / 217, 5901, 2996, 5.99, 6));

            List<Car> certainSpeedLevel = h.CarWithSpeedAbove(267);
            certainSpeedLevel.ForEach(c => Console.WriteLine(c + " \n"));
            
            #endregion

            Console.ReadKey();

        }
    }
}
