namespace Homework04._03
{


    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the currency type (USD, RUB, AMD): ");
            string currencyType = Console.ReadLine().ToUpper();

            Console.Write("Enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            double exchangeRate = 0.0;
            switch (currencyType)
            {
                case "USD":
                    exchangeRate = 520.0; // exchange rate from USD to AMD
                    break;
                case "RUB":
                    exchangeRate = 7.0; // exchange rate from RUB to AMD
                    break;
                case "AMD":
                    exchangeRate = 1.0; // exchange rate from AMD to AMD
                    break;
                default:
                    Console.WriteLine("Invalid currency type.");
                    return;
            }

            int dram = (int)(exchangeRate * amount);

            int thousands = dram / 1000;
            int hundreds = (dram % 1000) / 100;
            int tens = (dram % 100) / 10;

            Console.WriteLine("{0} {1} = {2} {3} + {4} {5} + {6} {7}",
                              amount, currencyType, thousands, "x 1000",
                              hundreds, "x 100", tens, "x 10");
        }
    }
}
