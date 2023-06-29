using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HiLoConsoleApp
{
    internal static class HiLoGame
    {
        public const int maximum = 10;
        private static Random random = new();
        private static int pot = 3;
        private static int currentNumber = random.Next(maximum + 1);

        public static void Hint()
        {
            int half = maximum / 2;
            if (currentNumber >= half)
                Console.WriteLine($"The number is at least {maximum / 2}");
            else
                Console.WriteLine($"The number is at most {maximum / 2}");
            pot--;
        }

        public static int GetPot()
        {
            return pot;
        }

        public static void Guess(bool higher)
        {
            int next = random.Next(maximum + 1);
            if (next == currentNumber || next > currentNumber == higher)
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else 
            {
                Console.WriteLine("Bad luck, you guessed wrong.");
                pot--;
            }
            currentNumber = next;
            Console.WriteLine($"The current number is: {currentNumber}");
        }
    }
}
