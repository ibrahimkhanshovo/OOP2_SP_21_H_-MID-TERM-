using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array01
{
    class Program
    {
                int[] arr1 = new int[100];
                int[] arr2 = new int[100];
                int i, n;


                Console.Write(" \n");
                Console.Write(" \n");

                Console.Write("Input:");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input \n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }
               
                for (i = 0; i < n; i++)
                {
                    arr2[i] = arr1[i];
                }

             
                Console.Write(" \n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("{0}  ", arr1[i]);
                }

               
                Console.Write(" \n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("{0}  ", arr2[i]);
                }
                Console.Write("\n\n");
            }
        }
    }
    }
}
