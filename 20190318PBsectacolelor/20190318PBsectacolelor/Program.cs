using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20190318PBsectacolelor
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader dataload = new StreamReader("intervale.txt");
            int n = int.Parse(dataload.ReadLine());
            spectacol[] m = new spectacol[n];
            for (int i = 0; i < n; i++)
            {

                string l = dataload.ReadLine();

                string[] k=l.Split(new char[] { '(', ',', ')' });
                int ti = int.Parse(k[1]);
                int tf = int.Parse(k[2]);
                m[i] = new spectacol(ti, tf);
            }
           for (int i = 0; i < n-1; i++)
            {
                for (int j =i+1; j < n; j++)
                {
                    if(m[i].tf>m[j].tf)
                    {
                        int aux = m[j].tf;
                        m[j].tf = m[i].tf;
                        m[i].tf = aux;
                        aux = m[i].ti;
                        m[i].ti = m[j].ti;
                        m[j].ti = aux;
                    }
                }
            }
            m[0].view();
            int t = m[0].tf;
            for (int i = 1; i < m.Length; i++)
            {
                if(m[i].ti>=t)
                {
                    m[i].view();
                    t = m[i].tf;
                }
            }
        }
    }
}
