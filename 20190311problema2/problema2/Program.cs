using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n="); int n = int.Parse(Console.ReadLine());
            Console.Write("m="); int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            int[] suma = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("a[{0},{1}]=",i,j);
                    a[i, j] = int.Parse(Console.ReadLine());
                    suma[i] = suma[i] + a[i, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i <n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (suma[i] > suma[j])
                    {
                        int k = 0;
                        while (k < m)
                        {
                            int aux = a[i, k];
                            a[i, k] = a[j, k];
                            a[j, k] = aux;
                            k++;
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}",a[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
