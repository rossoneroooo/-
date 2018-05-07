using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var n = int.Parse(Console.ReadLine());
          
            var leftSum = 0000000000;
            var rightSum = 0;
            for (var i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                leftSum += num;
            }
            for (var i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                rightSum += num;
            }
            if (rightSum == leftSum)
            {
                Console.WriteLine("Yes, sum = {0}" , leftSum);
            }
            else Console.WriteLine("No, diff = {0}", Math.Abs(leftSum-rightSum));
            

        }
    }
}
