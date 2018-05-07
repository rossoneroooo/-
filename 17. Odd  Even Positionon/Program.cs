using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Odd__Even_Positionon
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0.0;
            var evenSum = 0.0;
            var oddSum = 0.0;
            var oddMin = -100000000.0;
            var oddMax = 10000000.0;
            var evenMin = -100000000.0;
            var evenMax = 10000000.0;
            if (n == 0)
            {
                Console.WriteLine("OddSum=0");
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            //else if (n == 1)
            //{
            //    Console.WriteLine("OddSum=1");
            //    Console.WriteLine("OddMin=1");
            //    Console.WriteLine("OddMax=1");
            //    Console.WriteLine("EvenSum=0");
            //    Console.WriteLine("EvenMin=No");
            //    Console.WriteLine("EvenMax=No");
           // }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    var nums = double.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        evenSum = evenSum + nums + sum;
                        if (nums >= evenMin) evenMin = nums;
                        if (nums <= evenMin) evenMax = nums;
                    }
                    if (i % 2 == 1)
                    {
                        oddSum = oddSum + nums + sum;
                        if (nums >= oddMin) oddMin = nums;
                        if (nums <= oddMin) oddMax = nums;
                    }

                }
                Console.WriteLine("OddSum={0}", oddSum);
                Console.WriteLine("OddMin={0}", oddMax);
                Console.WriteLine("OddMax={0}", oddMin);
                Console.WriteLine("EvenSum={0}", evenSum);
                Console.WriteLine("EvenMin={0}", evenMax);
                Console.WriteLine("EvenMax={0}", evenMin);
            }
        }
    }
}
