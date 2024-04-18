using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToBeTested
{
    public class Calculator
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Input must be a non-negative integer.", nameof(n));
            }
            else
            if (n == 0 || n == 1)
            {
                return 1;
            }
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
