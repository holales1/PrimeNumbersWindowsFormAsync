using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Calculations
    {

        public List<long> PrimeNumbersSequential(long start, long end)
        {
            List<long> primeNumbersList = new List<long>();
            for (long i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbersList.Add(i);
                }
            }
            return primeNumbersList;
        }

        public static bool IsPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
