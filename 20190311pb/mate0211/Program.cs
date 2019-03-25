using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mate0211
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[10];
            while (n != 0)
            {
                a[n%10]++;
                n /= 10;
            }
            int nr = 0;
            for(int i = 9; i >= 0; i--)
            {
                while (a[i] != 0)
                {
                    nr = nr * 10 + i;
                    a[i]--;
                }
            }
            Console.WriteLine("{0}",(nr));


        }
    }
}
