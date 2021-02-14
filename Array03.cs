using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array03
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arr = new int[100]; ;
                int i, j, k, size, isUnique;

              
                Console.WriteLine(" : ");
                size = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine(" : ");
                for (i = 0; i < size; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

             

                for (i = 0; i < size; i++)
                {
                 
                    isUnique = 1;

                    for (j = i + 1; j < size; j++)
                    {

                  

                        if (arr[i] == arr[j])
                        {
                           
                            for (k = j; k < size - 1; k++)
                            {
                                arr[k] = arr[k + 1];
                            }

                            size--;
                            j--;
                            isUnique = 0;
                        }
                    }

                  
                    if (isUnique != 1)
                    {
                        for (j = i; j < size - 1; j++)
                        {
                            arr[j] = arr[j + 1];
                        }

                        size--;
                        i--;
                    }
                }

       
                Console.WriteLine(" : ");
                for (i = 0; i < size; i++)
                {
                    Console.WriteLine(arr[i] + "\t");
                }
                Console.ReadLine();
            }

        }
    }
    }
}
