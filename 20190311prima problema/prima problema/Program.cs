using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prima_problema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cate elem are v? ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i]=int.Parse(Console.ReadLine());
            }
            Random r = new Random();
            int nra = 0;
            for(int k=0;k<1000000;k++)
            {
                int ind = r.Next(n);
                bool isl = false;
                bool isr = false;
                for(int j=ind-1;j>=0;j--)
                {
                    if(v[j]>v[ind])
                    {
                        isl = true;
                        break;
                    }
                }
                for (int j = ind +1 ; j <n; j++)
                {
                    if (v[j] > v[ind])
                    {
                        isr = true;
                        break;
                    }
                }
                if(isr&&isl)
                {
                    //if()
                    nra++;
                    v[ind]++;
                }
            }
            Console.WriteLine("numarul picurilor de apa={0}",nra);
            Console.Read();
        }
    }
}
