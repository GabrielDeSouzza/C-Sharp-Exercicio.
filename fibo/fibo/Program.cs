using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            long fibonnaci = 1, cont,resu=0,x;
            Console.Write(fibonnaci + " ");
            for (cont= 2; cont <50; cont++)
            {
                
                resu = resu + fibonnaci;
                Console.Write(resu+ " ");
                x = fibonnaci;
                fibonnaci = resu;
                resu = x;
            }
            Console.ReadKey();

        }
    }
}
