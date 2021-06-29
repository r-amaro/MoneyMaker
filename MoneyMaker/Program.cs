using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("What amount of Cents(¢) would you like to convert to the most efficient combination of coins? (Ex: 13)");

            string input = Console.ReadLine();
            double amount = Convert.ToDouble(input);
            Console.WriteLine($"\n{amount} cents is equal to...\n");

            int quarter = 25;
            int dime = 10;
            int nickle = 5;
            //int penny = 1;

            double qNum = Math.Floor(amount / quarter);//sees how many quarters are needed

            amount -= qNum * quarter;//takes quarters out of the amount

            double dNum = Math.Floor(amount / dime);//sees how many dimes are needed

            amount -= dNum * dime;//takes dimes out of the amount

            double nNum = Math.Floor(amount / nickle);//sees how many nickles are needed

            amount -= nNum * nickle;//takes nickles out of the amount

            double pNum = amount;//the remainder is the necessary pennies

            Console.WriteLine($"Quarters: {qNum}");
            Console.WriteLine($"Dimes: {dNum}");
            Console.WriteLine($"Nickles: {nNum}");
            Console.WriteLine($"Pennies: {pNum}");
            Console.ReadLine();
        }
    }
}
