using System;
using Assignment1.Model;


namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(265, 300 / 220.5, 5900, 2994, 6.0, 6);
            Car car2 = new Car(266, 300 / 220, 5905, 2995, 5.9, 6);
            Car car3 = new Car(267, 300 / 219, 5904, 2993, 6.2, 6);
            Car car4 = new Car(268, 300 / 218, 5903, 2992, 5.8, 6);
            Car car5 = new Car(269, 300 / 217.5, 5902, 2991, 6.1, 6);
            Car car6 = new Car(270, 300 / 217, 5901, 2996, 5.99, 6);

            Car cars = new Car();

            cars.addCars(car1);
            cars.addCars(car2);
            cars.addCars(car3);
            cars.addCars(car4);
            cars.addCars(car5);
            cars.addCars(car6);

            Console.WriteLine(cars.kmPhr);
            Console.ReadKey();

        }
    }
}
