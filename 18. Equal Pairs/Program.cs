using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //var sum = 0;
            var firstSum = 0;
            
            for (var i = 0; i < n; i++)
            {
                firstSum = firstSum+ int.Parse(Console.ReadLine());
            }
            var secondSum = 0;
            for (var i = 0; i < n; i++)
            {
                secondSum = secondSum + int.Parse(Console.ReadLine());
            }
            var thirdSum = 0;
            for (var i = 0; i < n; i++)
            {
                thirdSum = thirdSum + int.Parse(Console.ReadLine());
            }
            var fourthSum = 0;
            for (var i = 0; i < n; i++)
            {
                fourthSum = fourthSum + int.Parse(Console.ReadLine());
            }
            if (firstSum == secondSum && secondSum == thirdSum && thirdSum == fourthSum)
            {
                Console.WriteLine("Yes, value={0}", firstSum);
            }
        }
    }
}
