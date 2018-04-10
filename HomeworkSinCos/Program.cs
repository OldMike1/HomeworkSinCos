using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSinCos
{
    //class SinCos
    //{
    //    public void GetResult(int n)
    //    {
    //        double res = 0;
    //        double chislitel = 0;
    //        double znamenatel = 0;
    //        for (int i = 1; i <= n; i++)
    //        {
    //            chislitel += Math.Cos(i );
    //            znamenatel += Math.Sin(i );
    //            res += chislitel / znamenatel;
    //        }
    //        Console.WriteLine(res);
    //    }
    //}

    class Program
    {
        static double GetResult(int index, double chislitel, double znamenatel, double res)
        {
            double result = 0;
            index++;
            if (index != 4)
            {
                res += (chislitel += Math.Cos(index)) / (znamenatel += Math.Sin(index)) + GetResult(index, chislitel, znamenatel, res);
            }
            result += res;
            return result;
        }

        static void Main(string[] args)
        {
            int index = 0;
            double chislitel = 0;
            double znamenatel = 0;
            double res = 0;
            double result = GetResult(index, chislitel, znamenatel, res);
            Console.WriteLine(result);








            //int n = int.Parse(Console.ReadLine());
            //SinCos sincos = new SinCos();
            //sincos.GetResult(n);
        }
    }
}
