using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var max = 1000000000;
            for (var i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (max > num)
                    max = num;
            }
            Console.WriteLine(max);
        }
    }
}
