using System;

namespace HeadFirstCSharpPractice
{
    class Program
    {
        static void Main()
        {
            long lValue = 6000000000000L;
            char cValue = 'Z';
            bool tValue = true;
            int rv = MyMethod(tValue);
            System.Console.WriteLine(rv);
        }

        public static int MyMethod(bool add3)
        {
            int value = 12;

            if (add3)
                value += 3;
            else
                value -= 2;

            return value;

        }
    }
}
