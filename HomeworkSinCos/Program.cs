using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSinCos
{
    class SinCos
    {
        public double GetResult(int n)
        {
            double res = 0;
            int angle = 1;
            double chislitel = Math.Cos(angle);
            double znamenatel = Math.Sin(angle);
            for (int i = 0; i < n; i++)
            {
                res += chislitel / znamenatel;
                chislitel += Math.Cos(angle++);
                znamenatel += Math.Sin(angle++);
            }
            return res;

            //double res = 0;
            
            //double chislitel = 1;
            //double znamenatel = 1;
            //for (int i = 0; i < n; i++)
            //{
            //    res += chislitel / znamenatel;
            //    chislitel += 1;
            //    znamenatel += 1;
            //}
            //return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SinCos sincos = new SinCos();
            double res = sincos.GetResult(n);
            Console.WriteLine(res);
        }
    }
}
