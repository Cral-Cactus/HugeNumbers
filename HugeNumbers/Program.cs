using System;
using System.Linq;
using System.Collections.Generic;

namespace Project
{
    internal class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();

            List<int> numberList = new List<int>();

            if (number.Any(c => char.IsLetter(c)))
            {
                Console.WriteLine("Numbers only!");
                return;
            }

            // Loop through each character in the number string and add it to the list as an integer
            foreach (char c in number)
            {
                if (c == '-')
                {
                    Console.WriteLine("Negative sign found. Removing it...");
                    continue;
                }

                int digit = int.Parse(c.ToString());
                numberList.Add(digit);
            }

            string name = "";
            switch (numberList.Count - 1)
            {
                case 0: name = "Normal Number (10^0)"; break;
                case 1: name = "Decimal Number (10^1)"; break;
                case 2: name = "Hundreds Number (10^2)"; break;
                case 3: name = "Thousands Number (10^3)"; break;
                case 4: name = "Ten Thousands Number (10^4)"; break;
                case 5: name = "Hundred Thousands Number (10^5)"; break;
                case 6:
                case 7:
                case 8: name = "Million (10^6)"; break;
                case 9:
                case 10:
                case 11: name = "Billion (10^9)"; break;
                case 12:
                case 13:
                case 14: name = "Trillion (10^12)"; break;
                case 15:
                case 16:
                case 17: name = "Quadrillion (10^15)"; break;
                case 18:
                case 19:
                case 20: name = "Quintrillion (10^18)"; break;
                case 21:
                case 22:
                case 23: name = "Sextillion (10^21)"; break;
                case 24:
                case 25:
                case 26: name = "Septillion (10^24)"; break;
                case 27:
                case 28:
                case 29: name = "Octillion (10^7)"; break;
                case 30:
                case 31:
                case 32: name = "Nonillion (10^30)"; break;
                case 33:
                case 34:
                case 35: name = "Decillion (10^33)"; break;
                case 36:
                case 37:
                case 38: name = "Undecillion (10^36)"; break;
                case 39:
                case 40:
                case 41: name = "Duodecillion (10^39)"; break;
                case 42:
                case 43:
                case 44: name = "Tredecillion (10^42)"; break;
                case 45:
                case 46:
                case 47: name = "Quattuordecillion (10^45)"; break;
                case 48:
                case 49:
                case 50: name = "Quindecillion (10^48)"; break;
                case 51:
                case 52:
                case 53: name = "Sexdecillion (10^51)"; break;
                case 54:
                case 55:
                case 56: name = "Septendecillion (10^54)"; break;
                case 57:
                case 58:
                case 59: name = "Octodecillion (10^57)"; break;
                case 60:
                case 61:
                case 62: name = "Novemdecillion (10^60)"; break;
                case 63: name = "Vigintillion (10^63)"; break;
                default: name = "Unknown number, please use from 10^0 to 10^63!"; break;
            }
            Console.WriteLine(name);
        }
    }
}
