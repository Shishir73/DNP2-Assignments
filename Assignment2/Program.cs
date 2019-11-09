using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            IntList ls = new IntList();
            ls.Add(11); ls.Add(20); ls.Add(31); ls.Add(40);
            ls.Add(51); ls.Add(71); ls.Add(80); ls.Add(91);

            ls.Act(Console.WriteLine);
            Console.WriteLine(" ");
            ls.Filter(delegate (int x) { return x % 2 == 0; }).Act(Console.WriteLine);
            Console.WriteLine(" ");
            ls.Filter(y => y > 25).Act(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
