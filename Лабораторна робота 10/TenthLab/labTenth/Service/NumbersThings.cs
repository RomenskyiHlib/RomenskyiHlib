using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTenth.Service
{
    internal class NumbersThings
    {
        public Predicate<int> PrimeNumber => number =>
        {
            if (number < 2)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        };

        public Predicate<int> FibonacciNumber => n =>
        {
            if (n < 0) return false;

            bool IsPerfectSquare(int x)
            {
                int s = (int)Math.Sqrt(x);
                return s * s == x;
            }

            int a = 5 * n * n + 4;
            int b = 5 * n * n - 4;

            return IsPerfectSquare(a) || IsPerfectSquare(b);
        };
    }
}
