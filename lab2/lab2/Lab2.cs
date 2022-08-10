using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main()
        {
            const float e=0.001f;
            double term=0, sum=0;
            int factorial=1;

            do
            {
                for (int j = 1; j>e; j++)
                {
                    factorial *= j;
                    if (j % 2 == 1)
                    {
                        term = -(Math.Pow(1, j) / factorial);
                        sum += term;
                    }
                    else 
                    {
                        term = (Math.Pow(2, j) / factorial);
                        sum += term;
                    }
                   
                }
            } while (term > e);

                Console.WriteLine($"sum={sum}");
            Console.ReadKey();
        }
    }
}
