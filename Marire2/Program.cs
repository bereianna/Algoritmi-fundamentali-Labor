using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Marire2
{
    class Program
    {
        static string [,] oper=new string[,] { { "+", "-" }, { "*", "/" } };
        static double operatie(double a, double b, char op)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return a / b;
            }
            return 0;
        }
       // static int prio(char);
        /*static void forma_pol(char expr[], char fpol[])
        {
            int k = 0, p = 0;
            char st[maxn];
            for (int i = 0; expr[i]; ++i)
                if (expr[i] >= '0' && expr[i] <= '9')
                    fpol[p++] = expr[i];
                else if (expr[i] == '(')
                    st[k++] = expr[i];
                else if (expr[i] == ')')
                {
                    while (k - 1 >= 0)
                        if (st[k - 1] != '(')
                            fpol[p++] = st[--k];
                        else break;
                    --k;
                }
                else // am neaparat un operator
                {
                    while (k - 1 >= 0)
                        if (prio(st[k - 1]) >=
                            prio(expr[i]))
                            fpol[p++] = st[--k];
                        else
                            break;

                    st[k++] = expr[i];
                }
            while (k - 1 >= 0)
                fpol[p++] = st[--k];
            fpol[p] = '\0';
        }
        public static int prio(char oper)
        {
            if (oper == '-' || oper == '+')
                return 0;
            else if (oper == '(')
                return -1;
            return 1;
        }
       /* double eval(string[] expr1, char expr[])
        {
            char fpol[maxn];
            forma_pol(expr, fpol);
            // la sfarsit va contine
            // rezultatul final
            double st[maxn];
            int p = 0;
            for (int k = 0; fpol[k]; ++k)
            {
                if (fpol[k] >= '0' &&
                    fpol[k] <= '9')
                    st[p++] = fpol[k] - '0';
                else
                {
                    st[p - 2] = operatie(st[p - 2],
                        st[p - 1],
                        fpol[k]);
                    --p;
                }
            }
            return st[0];
        }*/
        static void Main(string[] args)
        {
            int maxn = 1001;
            string[] expr=new string[maxn];
            StreamReader s = new StreamReader("expr.in");
            s.ReadLine();
            int k = 0;
            StreamWriter sw = new StreamWriter("expr.out");
            sw.Write(eval(expr, 0, ref k));
        }
        private static double eval(string [] expr, int nivel, ref int k)
        {
            double ret;
            if (nivel == 2) // paranteze sau operand
            {
                char h;
                char.TryParse(expr[k], out h);
                if (h == '(')
                {
                    ++k; ret = eval(expr, 0, ref k); ++k;
                }
                else
                {
                    double j;
                    double.TryParse(expr[k++], out j);
                    ret = j;// - '0';
                }
                    

                return ret;
            }
            // +, -, * sau /
            ret = eval(expr, nivel /*+ 1*/, ref k);
            while (expr[k] == oper[nivel, 0] ||expr[k] == oper[nivel, 1])
            {
                int poz = k++;
                char l;
                char.TryParse(expr[poz],out l);
                ret = operatie(ret,eval(expr, nivel + 1, ref k), l);
            }
            return ret;
        }
    }
}
