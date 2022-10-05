using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class Calculations
    {

        private static readonly object locker = new Object();

        public List<int> PrimeNumbersSequential(int start, int end)
        {
            List<int> primeNumbersList = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbersList.Add(i);
                }
            }
            return primeNumbersList;
        }

        public List<int> PrimeNumbersAsync(int first, int last)
        {
            List<int> primeNumberList = new List<int>();
            Parallel.ForEach(
                Partitioner.Create(first, last + 1),
                (range) =>
                {
                    List<int> partialList = new List<int>();
                    for (int i = range.Item1; i < range.Item2; i++)
                    {
                        if (IsPrime(i))
                        {
                            partialList.Add(i);
                        }
                    }

                    lock (locker)
                    {
                        for (int j = 0; j < partialList.Count; j++)
                        {
                            primeNumberList.Add(partialList[j]);
                        }
                    }
                });
            primeNumberList.Sort();
            return primeNumberList;
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
