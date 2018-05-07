using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var washingMashinePrice = double.Parse(Console.ReadLine());
            var presentPrice = int.Parse(Console.ReadLine());
            var savings = 0;
            var moneyFromPresents = 0;
           
            var bonus = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savings += bonus;
                    savings -= 1;
                    bonus += 10;
                    //money += money;
                }
                else
                {
                    moneyFromPresents += presentPrice;
                }
            }
            //var moneyFromSoldToys = pricePerToy * toys;
            var savedMoney = savings + moneyFromPresents;
            if (savedMoney >= washingMashinePrice)
            {
                Console.WriteLine("Yes! {0:0.00}", savedMoney - washingMashinePrice);
            }
            else Console.WriteLine("No! {0:0.00}", washingMashinePrice- savedMoney);
        }
    }
}
