using System;
using System.Globalization;

namespace isPrime
{
    public class IsPrime
    {
        public static bool IsPrimeNumber(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i > 0)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
