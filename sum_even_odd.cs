using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_even_odd
{
            class Program
        {
            static void Main(string[] args)
            {
                int sum, sum1, i, n = 30;
                for (i = 1; i <= n; i++)
                {
                    sum += 2 * i;
                    sum1 += (2 * i) - 1;
                    Console.WriteLine("Even numbers sum is={0}", sum);
                    Console.WriteLine("Even numbers sum is={0}", sum1);
                }
            }
        }
    }

