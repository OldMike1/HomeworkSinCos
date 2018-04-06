using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSinCos
{
    class SinCos
    {
        public void GetResult(int n)
        {
            double res = 0;
            double chislitel = 0;
            double znamenatel = 0;
            for (int i = 1; i <= n; i++)
            {
                chislitel += Math.Cos(i );
                znamenatel += Math.Sin(i );
                res += chislitel / znamenatel;
            }
            Console.WriteLine(res);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SinCos sincos = new SinCos();
            sincos.GetResult(n);
            

        }
    }
}
