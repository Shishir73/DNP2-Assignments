using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            IntList xs = new IntList();
            xs.Add(11); xs.Add(20); xs.Add(31); xs.Add(40);
            xs.Add(51); xs.Add(71); xs.Add(80); xs.Add(91);

            xs.Act(Console.WriteLine);
            Console.WriteLine(" ");

            Console.WriteLine("Elements divisible by 2. ");
            xs.Filter(delegate (int x) { return x % 2 == 0; }).Act(Console.WriteLine);

            Console.WriteLine(" ");
            Console.WriteLine("Elements greater than 25. ");
            xs.Filter(y => y > 25).Act(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
