using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var maxNum = -1000000;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum = num + sum;
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            if ((sum - maxNum) == maxNum) Console.WriteLine("Yes Sum = {0}", sum - maxNum);

            else Console.WriteLine("No Diff = {0}", Math.Abs(maxNum - (sum - maxNum)));

        }
    }
}
