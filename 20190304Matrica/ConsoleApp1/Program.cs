using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("n="); n= int.Parse(Console.ReadLine());
            Console.Write("m="); m = int.Parse(Console.ReadLine());
            int[,] a = new int [n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("a[{0},{1}]= ",i,j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int k = 0; k < Math.Min(m, n) - m % 2; k++)
            {
                for (int i = 0; i < m - 1; i++)
                {
                    Console.WriteLine("{0}", a[0, i]);
                }
                for (int j = 0; j < n - 1; j++)
                {
                    Console.WriteLine("{0}", a[j, m - 1]);
                }
                for (int j = m - 1; j > 1; j++)
                {
                    Console.WriteLine("{0}", a[n - 1, j]);
                }
                for (int j = 0; j < n - 1; j++)
                {
                    Console.WriteLine("{0}", a[j, 0]);
                }
            }

            

        }
    }
}
